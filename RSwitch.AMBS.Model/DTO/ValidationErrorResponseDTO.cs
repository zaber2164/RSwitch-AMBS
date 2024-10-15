namespace RSwitch.AMBS.Model.DTO
{
    public record ValidationErrorResponseDTO(long Id, bool Success, string Message, string Title) : BasePostResponseDTO(Id,Success,Message,null)
    {
    }
}
