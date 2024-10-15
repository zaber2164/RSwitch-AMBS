namespace RSwitch.AMBS.Model.DTO.Auth
{
    public record LoginPostResponseDTO(long Id,bool Success, string Message,object Data = null): BasePostResponseDTO(Id,Success,Message,Data)
    {
    }
}
