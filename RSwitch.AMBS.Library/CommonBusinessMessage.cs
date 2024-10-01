using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Asai.Ambs.RSwitch.Library
{
    public class CommonBusinessMessage
    {
        [XmlElement(ElementName = "Apphdr")]
        public Apphdr Apphdr { get; set; }
        [XmlElement(ElementName = "Document")]
        public Document Document { get; set; }
    }
}
