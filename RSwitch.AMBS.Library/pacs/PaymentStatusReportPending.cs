using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RSwitch.AMBS.Library.pacs
{
    public class PaymentStatusReportPending
    {
        //pacs.002.001.10

        [XmlRoot(ElementName = "BusinessMessage")]
        public class BusinessMessage
        {
            [XmlElement(ElementName = "AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
            public AppHdr AppHdr { get; set; }

            [XmlElement(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
            public Document Document { get; set; }
        }

        public class AppHdr
        {
            [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public Signature Signature { get; set; }
        }

        public class Signature
        {
            [XmlElement(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public SignedInfo SignedInfo { get; set; }

            [XmlElement(ElementName = "SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public string SignatureValue { get; set; }

            [XmlElement(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public KeyInfo KeyInfo { get; set; }
        }

        public class SignedInfo
        {
            [XmlElement(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public CanonicalizationMethod CanonicalizationMethod { get; set; }

            [XmlElement(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public SignatureMethod SignatureMethod { get; set; }

            [XmlElement(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public Reference[] Reference { get; set; }
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
            public string? URI { get; set; }

            [XmlElement(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public Transforms Transforms { get; set; }

            [XmlElement(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public DigestMethod DigestMethod { get; set; }

            [XmlElement(ElementName = "DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public string DigestValue { get; set; }
        }

        public class Transforms
        {
            [XmlElement(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public Transform[] Transform { get; set; }
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

            [XmlElement(ElementName = "KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public KeyValue KeyValue { get; set; }

            [XmlElement(ElementName = "X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public X509Data X509Data { get; set; }
        }

        public class KeyValue
        {
            [XmlElement(ElementName = "RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public RSAKeyValue RSAKeyValue { get; set; }
        }

        public class RSAKeyValue
        {
            [XmlElement(ElementName = "Modulus", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public string Modulus { get; set; }

            [XmlElement(ElementName = "Exponent", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public string Exponent { get; set; }
        }

        public class X509Data
        {
            [XmlElement(ElementName = "X509Certificate", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public string X509Certificate { get; set; }
        }

        public class Document
        {
            [XmlElement(ElementName = "FIToFIPmtStsRpt", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
            public FIToFIPmtStsRpt FIToFIPmtStsRpt { get; set; }
        }

        public class FIToFIPmtStsRpt
        {
            [XmlElement(ElementName = "GrpHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
            public GrpHdr GrpHdr { get; set; }

            [XmlElement(ElementName = "TxInfAndSts", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
            public TxInfAndSts TxInfAndSts { get; set; }
        }

        public class GrpHdr
        {
            [XmlElement(ElementName = "MsgId", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
            public string MsgId { get; set; }

            [XmlElement(ElementName = "CreDtTm", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
            public string CreDtTm { get; set; }
        }

        public class TxInfAndSts
        {
            [XmlElement(ElementName = "OrgnlInstrId", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
            public string OrgnlInstrId { get; set; }

            [XmlElement(ElementName = "OrgnlEndToEndId", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
            public string OrgnlEndToEndId { get; set; }

            [XmlElement(ElementName = "OrgnlTxId", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
            public string OrgnlTxId { get; set; }

            [XmlElement(ElementName = "TxSts", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10")]
            public string TxSts { get; set; }
        }

    }
}
