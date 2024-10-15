namespace RSwitch.AMBS.Model.DTO.Auth
{
    public record RefreshTokenRequestDTO: BasePostRequestDTO
    {
        public string RefreshToken { get; set; }
        public string AccessToken { get; set; }
    }
}
