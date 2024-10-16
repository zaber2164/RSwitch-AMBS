using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using RSwitch.AMBS.DAL.Repositories.Implementation.User;
using RSwitch.AMBS.DAL.Repositories.Interface;
using RSwitch.AMBS.DAL.Repositories.Interface.User;
using RSwitch.AMBS.Model.DTO.Auth;
using RSwitch.AMBS.Model.User;
using RSwitch.AMBS.Service.Interface.User;
using RSwitch.AMBS.Utility;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace RSwitch.AMBS.Service.Implementation.User
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authenticationRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AuthService(IAuthRepository authenticationRepository, IUserRepository userRepository, IUserService userService,IConfiguration configuration,
            IMapper mapper,IUnitOfWork unitOfWork)
        {
            this._authenticationRepository = authenticationRepository;
            _userRepository = userRepository;
            this._userService = userService;
            this._configuration = configuration;
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public Task<LoginUser> Authenticate(string userName, string password)
        {
            return _authenticationRepository.Authenticate(userName, password);
        }
        public async Task UpdateUserRefreshToken(string userLogin, string refreshToken, DateTime refreshTokenExpiryDate)
        {
            var user = await _userService.GetUserDetails(userLogin);
            if (user == null)
            {
                throw new Exception("Invalid user details");
            }

            if (string.IsNullOrEmpty(refreshToken))
            {
                throw new Exception("Invalid user refresh token");
            }

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryDate = refreshTokenExpiryDate;

            await _userRepository.UpdateAsync(user);
        }
        public async Task<LoginPostResponseDTO> Login(LoginRequestDTO request)
        {
            var user = _mapper.Map<LoginUser, LoginResponseDTO>(await this.Authenticate(request.Login, request.Password));

            if (user == null)
                return new LoginPostResponseDTO(0, false, "Invalid credentials", null);
            //var userRoles =
            //    _mapper.Map<IEnumerable<UserRole>, IEnumerable<UserInRoleResponseDTO>>(await _userInRoleService.GetUserRoles(user.Login));
            //user.UserRoles = userRoles.ToList();
            user.Token = GenerateJwtToken(user);
            user.RefreshToken = GenerateRefreshToken();
            //user.RefreshTokenExpiryDate = DateTime.Now.AddDays(7);
            user.RefreshTokenExpiryDate = DateTime.Now.AddMinutes(int.Parse(_configuration["Jwt:ExpiryMinutes"]));
            user.AccessTokenLifeTimeDuration = int.Parse(_configuration["Jwt:ExpiryMinutes"]);
            //user.IsMfaEnabled = user.Is2FAFingerEnabled && DBUtility.ToNullableDateTime((await _configService.GetConfiguration(ConfigKeys.FACE_RECOGNITION_APPLICABLE_DATE)).Value) <= DateTime.Now;

            //await UpdateUserRefreshToken(request.Login, user.RefreshToken, user.RefreshTokenExpiryDate);
            //await _unitOfWork.CommitAsync();

            return new LoginPostResponseDTO(0, true, "Login successful", user);
        }
        public async Task<RefreshTokenPostResponseDTO> RenewJwtToken(string refreshToken, string oldAccessToken)
        {
            var principal = GetPrincipalFromExpiredToken(oldAccessToken);
            if (principal.Identity == null)
            {
                return new RefreshTokenPostResponseDTO(0, false, "Invalid Access token", null);
            }
            var userLogin = principal.Identity.Name;
            var user = _mapper.Map<LoginUser, LoginResponseDTO>(await _userService.GetUserDetails(userLogin));
            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryDate <= DateTime.Now)
            {
                return new RefreshTokenPostResponseDTO(0, false, "Invalid Client Request", null);
            }

            //var userRoles =
            //    _mapper.Map<IEnumerable<UserRole>, IEnumerable<UserInRoleResponseDTO>>(await _userInRoleService.GetUserRoles(user.Login));
            //user.UserRoles = userRoles.ToList();
            user.Token = GenerateJwtToken(user);
            user.RefreshToken = GenerateRefreshToken(); ;

            await UpdateUserRefreshToken(userLogin, user.RefreshToken, user.RefreshTokenExpiryDate);
            await _unitOfWork.CommitAsync();

            return new RefreshTokenPostResponseDTO(0, true, "New Token Generated Successfully", new RefreshTokenResponseDTO()
            {
                RefreshToken = user.RefreshToken,
                Token = user.Token
            });
        }
        private static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        private string GenerateJwtToken(LoginResponseDTO request)
        {
            try
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, request.Login),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Name,request.Login)
            };
                //claims.AddRange(request.UserRoles.Select(role => new Claim(ClaimTypes.Role, role.RoleName)));

                var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Issuer"],
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(int.Parse(_configuration["Jwt:ExpiryMinutes"])),
                    signingCredentials: credentials
                );

                var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);
                return encodedToken;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                
            }            
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"])),
                ValidateLifetime = false,
                ValidAudience = _configuration["Jwt:Audience"],
                ValidIssuer = _configuration["Jwt:Issuer"]
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");
            return principal;
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
    }
}
