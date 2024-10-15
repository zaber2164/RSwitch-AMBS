namespace RSwitch.AMBS.Model.DTO.Auth
{
    public record LoginRequestDTO : BasePostRequestDTO
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
