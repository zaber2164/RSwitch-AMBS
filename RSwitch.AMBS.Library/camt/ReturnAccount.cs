using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Asai.Ambs.RSwitch.Library.camt
{
    public class ReturnAccount
    {
        //camt.004.001.08
        public class BusinessMessage
        {
            // [XmlElement(ElementName = "AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
            public AppHdr AppHdr { get; set; }

            // [XmlElement(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.004.001.08")]
            public Document Document { get; set; }
        }

        public class AppHdr
        {
            // [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public Signature Signature { get; set; }
        }

        public class Signature
        {
            // [XmlElement(ElementName = "SignedInfo")]
            public SignedInfo SignedInfo { get; set; }

            // [XmlElement(ElementName = "SignatureValue")]
            public string SignatureValue { get; set; }

            // [XmlElement(ElementName = "KeyInfo")]
            public KeyInfo KeyInfo { get; set; }
        }

        public class SignedInfo
        {
            // [XmlElement(ElementName = "CanonicalizationMethod")]
            public CanonicalizationMethod CanonicalizationMethod { get; set; }

            // [XmlElement(ElementName = "SignatureMethod")]
            public SignatureMethod SignatureMethod { get; set; }

            // [XmlElement(ElementName = "Reference")]
            public List<Reference> References { get; set; }
        }

        public class CanonicalizationMethod
        {
            // [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        public class SignatureMethod
        {
            // [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        public class Reference
        {
            // [XmlAttribute(AttributeName = "URI")]
            public string URI { get; set; }

            // [XmlElement(ElementName = "Transforms")]
            public Transforms Transforms { get; set; }

            // [XmlElement(ElementName = "DigestMethod")]
            public DigestMethod DigestMethod { get; set; }

            // [XmlElement(ElementName = "DigestValue")]
            public string DigestValue { get; set; }
        }

        public class Transforms
        {
            // [XmlElement(ElementName = "Transform")]
            public List<Transform> TransformList { get; set; }
        }

        public class Transform
        {
            // [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        public class DigestMethod
        {
            // [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        public class KeyInfo
        {
            // [XmlAttribute(AttributeName = "Id")]
            public string Id { get; set; }

            // [XmlElement(ElementName = "KeyValue")]
            public KeyValue KeyValue { get; set; }

            // [XmlElement(ElementName = "X509Data")]
            public X509Data X509Data { get; set; }
        }

        public class KeyValue
        {
            // [XmlElement(ElementName = "RSAKeyValue")]
            public RSAKeyValue RSAKeyValue { get; set; }
        }

        public class RSAKeyValue
        {
            // [XmlElement(ElementName = "Modulus")]
            public string Modulus { get; set; }

            // [XmlElement(ElementName = "Exponent")]
            public string Exponent { get; set; }
        }

        public class X509Data
        {
            // [XmlElement(ElementName = "X509Certificate")]
            public string X509Certificate { get; set; }
        }

        public class Document
        {
            // [XmlElement(ElementName = "RtrAcct")]
            public RtrAcct RtrAcct { get; set; }
        }

        public class RtrAcct
        {
            // [XmlElement(ElementName = "MsgHdr")]
            public MsgHdr MsgHdr { get; set; }

            // [XmlElement(ElementName = "RptOrErr")]
            public RptOrErr RptOrErr { get; set; }
        }

        public class MsgHdr
        {
            // [XmlElement(ElementName = "MsgId")]
            public string MsgId { get; set; }
        }

        public class RptOrErr
        {
            // [XmlElement(ElementName = "AcctRpt")]
            public AcctRpt AcctRpt { get; set; }
        }

        public class AcctRpt
        {
            // [XmlElement(ElementName = "AcctId")]
            public AcctId AcctId { get; set; }

            // [XmlElement(ElementName = "AcctOrErr")]
            public AcctOrErr AcctOrErr { get; set; }
        }

        public class AcctId
        {
            // [XmlElement(ElementName = "Othr")]
            public Othr Othr { get; set; }
        }

        public class Othr
        {
            // [XmlElement(ElementName = "Id")]
            public string Id { get; set; }
        }

        public class AcctOrErr
        {
            // [XmlElement(ElementName = "Acct")]
            public Acct Acct { get; set; }
        }

        public class Acct
        {
            // [XmlElement(ElementName = "Ownr")]
            public Ownr Ownr { get; set; }

            // [XmlElement(ElementName = "Svcr")]
            public Svcr Svcr { get; set; }
        }

        public class Ownr
        {
            // [XmlElement(ElementName = "PstlAdr")]
            public string PstlAdr { get; set; }

            // [XmlElement(ElementName = "Id")]
            public string Id { get; set; }

            // [XmlElement(ElementName = "CtctDtls")]
            public CtctDtls CtctDtls { get; set; }
        }

        public class CtctDtls
        {
            // [XmlElement(ElementName = "Nm")]
            public string Nm { get; set; }

            // [XmlElement(ElementName = "MobNb")]
            public string MobNb { get; set; }

            // [XmlElement(ElementName = "EmailAdr")]
            public string EmailAdr { get; set; }
        }

        public class Svcr
        {
            // [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        public class FinInstnId
        {
            // [XmlElement(ElementName = "Othr")]
            public Othr Othr { get; set; }
        }

    }
}
