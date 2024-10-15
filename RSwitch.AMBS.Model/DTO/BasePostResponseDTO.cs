using Newtonsoft.Json;

namespace RSwitch.AMBS.Model.DTO
{
    public abstract record BasePostResponseDTO(long Id, bool Success, string Message, object Data)
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    };
}
