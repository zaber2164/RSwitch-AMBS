using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Asai.Ambs.RSwitch.Library.pacs
{
    public class PaymentReversal
    {
        //pacs.007.001.10
        public class BusinessMessage
        {
            // [XmlElement(ElementName = "AppHdr")]
            public AppHdr AppHdr { get; set; }

            // [XmlElement(ElementName = "Document")]
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
            public List<Reference> Reference { get; set; }
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
            public List<Transform> Transform { get; set; }
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
            // [XmlElement(ElementName = "FIToFIPmtRvsl")]
            public FIToFIPmtRvsl FIToFIPmtRvsl { get; set; }
        }

        public class FIToFIPmtRvsl
        {
            // [XmlElement(ElementName = "GrpHdr")]
            public GrpHdr GrpHdr { get; set; }

            // [XmlElement(ElementName = "OrgnlGrpInf")]
            public OrgnlGrpInf OrgnlGrpInf { get; set; }

            // [XmlElement(ElementName = "TxInf")]
            public TxInf TxInf { get; set; }
        }

        public class GrpHdr
        {
            // [XmlElement(ElementName = "MsgId")]
            public string MsgId { get; set; }

            // [XmlElement(ElementName = "CreDtTm")]
            public string CreDtTm { get; set; }

            // [XmlElement(ElementName = "NbOfTxs")]
            public string NbOfTxs { get; set; }

            // [XmlElement(ElementName = "IntrBkSttlmDt")]
            public string IntrBkSttlmDt { get; set; }

            // [XmlElement(ElementName = "SttlmInf")]
            public SttlmInf SttlmInf { get; set; }

            // [XmlElement(ElementName = "InstgAgt")]
            public InstgAgt InstgAgt { get; set; }

            // [XmlElement(ElementName = "InstdAgt")]
            public InstdAgt InstdAgt { get; set; }
        }

        public class SttlmInf
        {
            // [XmlElement(ElementName = "SttlmMtd")]
            public string SttlmMtd { get; set; }
        }

        public class InstgAgt
        {
            // [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        public class InstdAgt
        {
            // [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        public class FinInstnId
        {
            // [XmlElement(ElementName = "Othr")]
            public Othr Othr { get; set; }
        }

        public class Othr
        {
            // [XmlElement(ElementName = "Id")]
            public string Id { get; set; }
        }

        public class OrgnlGrpInf
        {
            // [XmlElement(ElementName = "OrgnlMsgId")]
            public string OrgnlMsgId { get; set; }

            // [XmlElement(ElementName = "OrgnlMsgNmId")]
            public string OrgnlMsgNmId { get; set; }

            // [XmlElement(ElementName = "OrgnlCreDtTm")]
            public string OrgnlCreDtTm { get; set; }
        }

        public class TxInf
        {
            // [XmlElement(ElementName = "RvslId")]
            public string RvslId { get; set; }

            // [XmlElement(ElementName = "OrgnlEndToEndId")]
            public string OrgnlEndToEndId { get; set; }

            // [XmlElement(ElementName = "OrgnlTxId")]
            public string OrgnlTxId { get; set; }

            // [XmlElement(ElementName = "RvsdIntrBkSttlmAmt")]
            public RvsdIntrBkSttlmAmt RvsdIntrBkSttlmAmt { get; set; }

            // [XmlElement(ElementName = "RvsdInstdAmt")]
            public RvsdInstdAmt RvsdInstdAmt { get; set; }

            // [XmlElement(ElementName = "RvslRsnInf")]
            public RvslRsnInf RvslRsnInf { get; set; }

            // [XmlElement(ElementName = "OrgnlTxRef")]
            public OrgnlTxRef OrgnlTxRef { get; set; }
        }

        public class RvsdIntrBkSttlmAmt
        {
            // [XmlAttribute(AttributeName = "Ccy")]
            public string Ccy { get; set; }

            [XmlText]
            public decimal Value { get; set; }
        }

        public class RvsdInstdAmt
        {
            // [XmlAttribute(AttributeName = "Ccy")]
            public string Ccy { get; set; }

            [XmlText]
            public decimal Value { get; set; }
        }

        public class RvslRsnInf
        {
            // [XmlElement(ElementName = "Orgtr")]
            public Orgtr Orgtr { get; set; }

            // [XmlElement(ElementName = "Rsn")]
            public Rsn Rsn { get; set; }
        }

        public class Orgtr
        {
            // [XmlElement(ElementName = "Id")]
            public Id Id { get; set; }
        }

        public class Id
        {
            // [XmlElement(ElementName = "OrgId")]
            public OrgId OrgId { get; set; }
        }

        public class OrgId
        {
            // [XmlElement(ElementName = "Othr")]
            public Othr Othr { get; set; }
        }

        public class Rsn
        {
            // [XmlElement(ElementName = "Cd")]
            public string Cd { get; set; }
        }

        public class OrgnlTxRef
        {
            // [XmlElement(ElementName = "MndtRltdInf")]
            public MndtRltdInf MndtRltdInf { get; set; }

            // [XmlElement(ElementName = "DbtrAcct")]
            public DbtrAcct DbtrAcct { get; set; }

            // [XmlElement(ElementName = "DbtrAgt")]
            public DbtrAgt DbtrAgt { get; set; }
        }

        public class MndtRltdInf
        {
            // [XmlElement(ElementName = "MndtId")]
            public string MndtId { get; set; }
        }

        public class DbtrAcct
        {
            // [XmlElement(ElementName = "Id")]
            public Id Id { get; set; }
        }

        public class DbtrAgt
        {
            // [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

    }
}
