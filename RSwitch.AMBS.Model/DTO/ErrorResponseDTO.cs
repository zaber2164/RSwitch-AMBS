using Newtonsoft.Json;

namespace RSwitch.AMBS.Model.DTO
{
    public class ErrorResponseDTO
    {
        public string Error { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}