using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RSwitch.AMBS.Controllers;
using RSwitch.AMBS.Library;
using RSwitch.AMBS.Model.DTO.Auth;
using RSwitch.AMBS.Service.Implementation;
using RSwitch.AMBS.Service.Interface.User;

namespace RSwitch_AMBS_Integration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthService _authService;

        public AuthController(IMapper mapper, ILogger<AuthController> logger, IAuthService authService)
        {
            _mapper = mapper;
            _logger = logger;
            _authService = authService;
        }
        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginData)
        {
            try
            {
                var res = await _authService.Login(loginData);
                return Ok(res);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
