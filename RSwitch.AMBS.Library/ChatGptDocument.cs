using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Asai.Ambs.RSwitch.Library
{
    //[XmlRoot(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    public class Document
    {
        //[XmlElement(ElementName = "GetAcct", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public GetAcct GetAcct { get; set; }

        //[XmlAttribute(AttributeName = "xmlns:xsi")]
        //public string XmlnsXsi { get; set; }

        //[XmlAttribute(AttributeName = "xsi:schemaLocation")]
        //public string XsiSchemaLocation { get; set; }
    }

    public class GetAcct
    {
        //[XmlElement(ElementName = "MsgHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public MsgHdr MsgHdr { get; set; }

        //[XmlElement(ElementName = "AcctQryDef", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public AcctQryDef AcctQryDef { get; set; }
    }

    public class MsgHdr
    {
        //[XmlElement(ElementName = "MsgId", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public string MsgId { get; set; }

        //[XmlElement(ElementName = "CreDtTm", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public DateTime CreDtTm { get; set; }
    }

    public class AcctQryDef
    {
        //[XmlElement(ElementName = "AcctCrit", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public AcctCrit AcctCrit { get; set; }
    }

    public class AcctCrit
    {
        //[XmlElement(ElementName = "NewCrit", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public NewCrit NewCrit { get; set; }
    }

    public class NewCrit
    {
        //[XmlElement(ElementName = "SchCrit", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public SchCrit SchCrit { get; set; }
    }

    public class SchCrit
    {
        //[XmlElement(ElementName = "AcctId", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public AcctId AcctId { get; set; }

        //[XmlElement(ElementName = "AcctOwnr", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public AcctOwnr AcctOwnr { get; set; }

        //[XmlElement(ElementName = "AcctSvcr", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public AcctSvcr AcctSvcr { get; set; }
    }

    public class AcctId
    {
        //[XmlElement(ElementName = "EQ", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public EQ EQ { get; set; }
    }

    public class EQ
    {
        //[XmlElement(ElementName = "Othr", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public Othr Othr { get; set; }
    }

    public class Othr
    {
        //[XmlElement(ElementName = "Id", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public string Id { get; set; }
    }

    public class AcctOwnr
    {
        //[XmlElement(ElementName = "CtctDtls", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public CtctDtls CtctDtls { get; set; }
    }

    public class CtctDtls
    {
        //[XmlElement(ElementName = "MobNb", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public string MobNb { get; set; }
    }

    public class AcctSvcr
    {
        //[XmlElement(ElementName = "FinInstnId", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public FinInstnId FinInstnId { get; set; }
    }

    public class FinInstnId
    {
        //[XmlElement(ElementName = "Othr", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
        public Othr Othr { get; set; }
    }
}



