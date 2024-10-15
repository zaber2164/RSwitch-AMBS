using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RSwitch.AMBS.Library.pacs
{
    public class PaymentStatusReportReject
    {
        //pacs.002.001.10

        [XmlRoot(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class CanonicalizationMethod
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        [XmlRoot(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class SignatureMethod
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        [XmlRoot(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class Transform
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        [XmlRoot(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class Transforms
        {
            [XmlElement(ElementName = "Transform")]
            public List<Transform> Transform { get; set; }
        }

        [XmlRoot(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class DigestMethod
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        [XmlRoot(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class Reference
        {
            [XmlElement(ElementName = "Transforms")]
            public Transforms Transforms { get; set; }
            [XmlElement(ElementName = "DigestMethod")]
            public DigestMethod DigestMethod { get; set; }
            [XmlElement(ElementName = "DigestValue")]
            public string DigestValue { get; set; }
            [XmlAttribute(AttributeName = "URI")]
            public string? URI { get; set; }
        }

        [XmlRoot(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class SignedInfo
        {
            [XmlElement(ElementName = "CanonicalizationMethod")]
            public CanonicalizationMethod CanonicalizationMethod { get; set; }
            [XmlElement(ElementName = "SignatureMethod")]
            public SignatureMethod SignatureMethod { get; set; }
            [XmlElement(ElementName = "Reference")]
            public List<Reference> Reference { get; set; }
        }

        [XmlRoot(ElementName = "SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class SignatureValue
        {
            [XmlText]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class RSAKeyValue
        {
            [XmlElement(ElementName = "Modulus")]
            public string Modulus { get; set; }
            [XmlElement(ElementName = "Exponent")]
            public string Exponent { get; set; }
        }

        [XmlRoot(ElementName = "KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class KeyValue
        {
            [XmlElement(ElementName = "RSAKeyValue")]
            public RSAKeyValue RSAKeyValue { get; set; }
        }

        [XmlRoot(ElementName = "X509Certificate", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class X509Certificate
        {
            [XmlText]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class X509Data
        {
            [XmlElement(ElementName = "X509Certificate")]
            public X509Certificate X509Certificate { get; set; }
        }

        [XmlRoot(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class KeyInfo
        {
            [XmlElement(ElementName = "KeyValue")]
            public KeyValue KeyValue { get; set; }
            [XmlElement(ElementName = "X509Data")]
            public X509Data X509Data { get; set; }
            [XmlAttribute(AttributeName = "Id")]
            public string Id { get; set; }
        }

        [XmlRoot(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class Signature
        {
            [XmlElement(ElementName = "SignedInfo")]
            public SignedInfo SignedInfo { get; set; }
            [XmlElement(ElementName = "SignatureValue")]
            public SignatureValue SignatureValue { get; set; }
            [XmlElement(ElementName = "KeyInfo")]
            public KeyInfo KeyInfo { get; set; }
        }

        [XmlRoot(ElementName = "AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
        public class AppHdr
        {
            [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public Signature Signature { get; set; }
        }

        [XmlRoot(ElementName = "GrpHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
        public class GrpHdr
        {
            [XmlElement(ElementName = "MsgId")]
            public string MsgId { get; set; }
            [XmlElement(ElementName = "CreDtTm")]
            public DateTime CreDtTm { get; set; }
        }

        [XmlRoot(ElementName = "TxInfAndSts", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
        public class TxInfAndSts
        {
            [XmlElement(ElementName = "StsId")]
            public string StsId { get; set; }
            [XmlElement(ElementName = "OrgnlEndToEndId")]
            public string OrgnlEndToEndId { get; set; }
            [XmlElement(ElementName = "OrgnlTxId")]
            public string OrgnlTxId { get; set; }
        }

        [XmlRoot(ElementName = "FIToFIPmtStsRpt", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
        public class FIToFIPmtStsRpt
        {
            [XmlElement(ElementName = "GrpHdr")]
            public GrpHdr GrpHdr { get; set; }
            [XmlElement(ElementName = "TxInfAndSts")]
            public TxInfAndSts TxInfAndSts { get; set; }
        }

        [XmlRoot(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
        public class Document
        {
            [XmlElement(ElementName = "FIToFIPmtStsRpt")]
            public FIToFIPmtStsRpt FIToFIPmtStsRpt { get; set; }
        }

        [XmlRoot(ElementName = "BusinessMessage")]
        public class BusinessMessage
        {
            [XmlElement(ElementName = "AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
            public AppHdr AppHdr { get; set; }
            [XmlElement(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
            public Document Document { get; set; }
        }
    }
}

