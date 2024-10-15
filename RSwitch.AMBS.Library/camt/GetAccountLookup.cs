using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RSwitch.AMBS.Library.camt
{
    public class GetAccountLookup
    {
        //camt.003.001.07
        public class BusinessMessage
        {
            [XmlElement(ElementName = "AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
            public AppHdr AppHdr { get; set; }

            [XmlElement(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
            public Document Document { get; set; }
        }

        public class AppHdr
        {
            [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public Signature Signature { get; set; }
        }

        public class Signature
        {
            [XmlElement(ElementName = "SignedInfo")]
            public SignedInfo SignedInfo { get; set; }

            [XmlElement(ElementName = "SignatureValue")]
            public string SignatureValue { get; set; }

            [XmlElement(ElementName = "KeyInfo")]
            public KeyInfo KeyInfo { get; set; }
        }

        public class SignedInfo
        {
            [XmlElement(ElementName = "CanonicalizationMethod")]
            public CanonicalizationMethod CanonicalizationMethod { get; set; }

            [XmlElement(ElementName = "SignatureMethod")]
            public SignatureMethod SignatureMethod { get; set; }

            [XmlElement(ElementName = "Reference")]
            public List<Reference> Reference { get; set; }
        }

        public class CanonicalizationMethod
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        public class SignatureMethod
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        public class Reference
        {
            [XmlAttribute(AttributeName = "URI")]
            public string URI { get; set; }

            [XmlElement(ElementName = "Transforms")]
            public Transforms Transforms { get; set; }

            [XmlElement(ElementName = "DigestMethod")]
            public DigestMethod DigestMethod { get; set; }

            [XmlElement(ElementName = "DigestValue")]
            public string DigestValue { get; set; }
        }

        public class Transforms
        {
            [XmlElement(ElementName = "Transform")]
            public List<Transform> Transform { get; set; }
        }

        public class Transform
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        public class DigestMethod
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        public class KeyInfo
        {
            [XmlAttribute(AttributeName = "Id")]
            public string Id { get; set; }

            [XmlElement(ElementName = "KeyValue")]
            public KeyValue KeyValue { get; set; }

            [XmlElement(ElementName = "X509Data")]
            public X509Data X509Data { get; set; }
        }

        public class KeyValue
        {
            [XmlElement(ElementName = "RSAKeyValue")]
            public RSAKeyValue RSAKeyValue { get; set; }
        }

        public class RSAKeyValue
        {
            [XmlElement(ElementName = "Modulus")]
            public string Modulus { get; set; }

            [XmlElement(ElementName = "Exponent")]
            public string Exponent { get; set; }
        }

        public class X509Data
        {
            [XmlElement(ElementName = "X509Certificate")]
            public string X509Certificate { get; set; }
        }

        #region GetAcccountLookup

        public class Document
        {
            [XmlElement(ElementName = "GetAcct")]
            public GetAcct GetAcct { get; set; }
        }

        public class GetAcct
        {
            [XmlElement(ElementName = "MsgHdr")]
            public MsgHdr MsgHdr { get; set; }

            [XmlElement(ElementName = "AcctQryDef")]
            public AcctQryDef AcctQryDef { get; set; }
        }

        public class MsgHdr
        {
            [XmlElement(ElementName = "MsgId")]
            public string MsgId { get; set; }

            [XmlElement(ElementName = "CreDtTm")]
            public string CreDtTm { get; set; }
        }

        public class AcctQryDef
        {
            [XmlElement(ElementName = "AcctCrit")]
            public AcctCrit AcctCrit { get; set; }
        }

        public class AcctCrit
        {
            [XmlElement(ElementName = "NewCrit")]
            public NewCrit NewCrit { get; set; }
        }

        public class NewCrit
        {
            [XmlElement(ElementName = "SchCrit")]
            public SchCrit SchCrit { get; set; }
        }

        public class SchCrit
        {
            [XmlElement(ElementName = "AcctId")]
            public AcctId AcctId { get; set; }

            [XmlElement(ElementName = "AcctOwnr")]
            public AcctOwnr AcctOwnr { get; set; }

            [XmlElement(ElementName = "AcctSvcr")]
            public AcctSvcr AcctSvcr { get; set; }
        }

        public class AcctId
        {
            [XmlElement(ElementName = "EQ")]
            public EQ EQ { get; set; }
        }

        public class EQ
        {
            [XmlElement(ElementName = "Othr")]
            public Othr Othr { get; set; }
        }

        public class Othr
        {
            [XmlElement(ElementName = "Id")]
            public string Id { get; set; }
        }

        public class AcctOwnr
        {
            [XmlElement(ElementName = "CtctDtls")]
            public CtctDtls CtctDtls { get; set; }
        }

        public class CtctDtls
        {
            [XmlElement(ElementName = "MobNb")]
            public string MobNb { get; set; }
        }

        public class AcctSvcr
        {
            [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        public class FinInstnId
        {
            [XmlElement(ElementName = "Othr")]
            public Othr Othr { get; set; }
        }

        #endregion
    }
}
