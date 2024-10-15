using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSwitch.AMBS.Model.DTO
{
    public class AmbsMessage
    {
        public MessageType Type { get; set; }
        public string Msg { get; set; }
    }
    public enum MessageType
    {
        Information,
        Warning,
        Error
    }
}
