using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RSwitch.AMBS.Library.pacs
{
    public class CheckPaymentStatusRequest
    {
        //pacs.028.001.03

        [XmlRoot(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03")]
        public class Document
        {
            [XmlElement(ElementName = "FIToFIPmtStsReq", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03")]
            public FIToFIPmtStsReq FIToFIPmtStsReq { get; set; }
        }

        public class FIToFIPmtStsReq
        {
            [XmlElement(ElementName = "GrpHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03")]
            public GrpHdr GrpHdr { get; set; }

            [XmlElement(ElementName = "TxInf", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03")]
            public TxInf TxInf { get; set; }
        }

        public class GrpHdr
        {
            [XmlElement(ElementName = "MsgId", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03")]
            public string MsgId { get; set; }

            [XmlElement(ElementName = "CreDtTm", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03")]
            public string CreDtTm { get; set; }
        }

        public class TxInf
        {
            [XmlElement(ElementName = "OrgnlEndToEndId", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03")]
            public string OrgnlEndToEndId { get; set; }

            [XmlElement(ElementName = "InstgAgt", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03")]
            public InstgAgt InstgAgt { get; set; }
        }

        public class InstgAgt
        {
            [XmlElement(ElementName = "FinInstnId", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03")]
            public FinInstnId FinInstnId { get; set; }
        }

        public class FinInstnId
        {
            [XmlElement(ElementName = "Othr", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03")]
            public Othr Othr { get; set; }
        }

        public class Othr
        {
            [XmlElement(ElementName = "Id", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.03")]
            public string Id { get; set; }
        }
    }
}
