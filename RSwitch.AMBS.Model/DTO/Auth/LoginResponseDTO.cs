namespace RSwitch.AMBS.Model.DTO.Auth
{
    public class LoginResponseDTO
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public long? HRM_EmployeeId { get; init; }
        public bool Is2FAFingerEnabled { get; init; }
        public bool? IsEmailOTPEnabled { get; init; }
        public bool? IsSmsOTPEnabled { get; init; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryDate { get; set; }
        //public List<UserInRoleResponseDTO> UserRoles { get; set; }
        public string Token { get; set; }
        public bool IsMfaEnabled { get; set; }
        public int AccessTokenLifeTimeDuration { get; set; }
    }
}
