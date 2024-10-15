namespace RSwitch.AMBS.Model.DTO.Auth
{
    public record RefreshTokenPostResponseDTO(long Id, bool Success, string Message, object Data) : BasePostResponseDTO(Id, Success, Message, Data)
    {
    }
}
