using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RSwitch.AMBS.Library.pacs
{
    public class CreditTransfer
    {
        //pacs.008.001.08

        [XmlRoot(ElementName = "BusinessMessage")]
        public class BusinessMessage
        {
            [XmlElement(ElementName = "AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
            public AppHdr AppHdr { get; set; }

            [XmlElement(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.08")]
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
            [XmlElement(ElementName = "FIToFICstmrCdtTrf", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.08")]
            public FIToFICstmrCdtTrf FIToFICstmrCdtTrf { get; set; }
        }

        public class FIToFICstmrCdtTrf
        {
            [XmlElement(ElementName = "GrpHdr")]
            public GrpHdr GrpHdr { get; set; }

            [XmlElement(ElementName = "CdtTrfTxInf")]
            public CdtTrfTxInf CdtTrfTxInf { get; set; }
        }

        public class GrpHdr
        {
            [XmlElement(ElementName = "MsgId")]
            public string MsgId { get; set; }

            [XmlElement(ElementName = "CreDtTm")]
            public string CreDtTm { get; set; }

            [XmlElement(ElementName = "NbOfTxs")]
            public int NbOfTxs { get; set; }

            [XmlElement(ElementName = "SttlmInf")]
            public SttlmInf SttlmInf { get; set; }

            [XmlElement(ElementName = "InstgAgt")]
            public InstgAgt InstgAgt { get; set; }

            [XmlElement(ElementName = "InstdAgt")]
            public InstdAgt InstdAgt { get; set; }
        }

        public class SttlmInf
        {
            [XmlElement(ElementName = "SttlmMtd")]
            public string SttlmMtd { get; set; }
        }

        public class InstgAgt
        {
            [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        public class InstdAgt
        {
            [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        public class FinInstnId
        {
            [XmlElement(ElementName = "Othr")]
            public Othr Othr { get; set; }
        }

        public class Othr
        {
            [XmlElement(ElementName = "Id")]
            public string Id { get; set; }
        }

        public class CdtTrfTxInf
        {
            [XmlElement(ElementName = "PmtId")]
            public PmtId PmtId { get; set; }

            [XmlElement(ElementName = "PmtTpInf")]
            public PmtTpInf PmtTpInf { get; set; }

            [XmlElement(ElementName = "IntrBkSttlmAmt")]
            public IntrBkSttlmAmt IntrBkSttlmAmt { get; set; }

            [XmlElement(ElementName = "IntrBkSttlmDt")]
            public string IntrBkSttlmDt { get; set; }

            [XmlElement(ElementName = "ChrgBr")]
            public string ChrgBr { get; set; }

            [XmlElement(ElementName = "InitgPty")]
            public InitgPty InitgPty { get; set; }

            [XmlElement(ElementName = "Dbtr")]
            public Dbtr Dbtr { get; set; }

            [XmlElement(ElementName = "DbtrAcct")]
            public DbtrAcct DbtrAcct { get; set; }

            [XmlElement(ElementName = "DbtrAgt")]
            public DbtrAgt DbtrAgt { get; set; }

            [XmlElement(ElementName = "CdtrAgt")]
            public CdtrAgt CdtrAgt { get; set; }

            [XmlElement(ElementName = "Cdtr")]
            public Cdtr Cdtr { get; set; }

            [XmlElement(ElementName = "CdtrAcct")]
            public CdtrAcct CdtrAcct { get; set; }

            [XmlElement(ElementName = "Purp")]
            public Purp Purp { get; set; }

            [XmlElement(ElementName = "RmtInf")]
            public RmtInf RmtInf { get; set; }
        }

        public class PmtId
        {
            [XmlElement(ElementName = "InstrId")]
            public string InstrId { get; set; }

            [XmlElement(ElementName = "EndToEndId")]
            public string EndToEndId { get; set; }

            [XmlElement(ElementName = "TxId")]
            public string TxId { get; set; }
        }

        public class PmtTpInf
        {
            [XmlElement(ElementName = "InstrPrty")]
            public string? InstrPrty { get; set; }
        }

        public class IntrBkSttlmAmt
        {
            [XmlAttribute(AttributeName = "Ccy")]
            public string Ccy { get; set; }

            [XmlText]
            public decimal Value { get; set; }
        }

        public class InitgPty
        {
            [XmlElement(ElementName = "Nm")]
            public string Nm { get; set; }
        }

        public class Dbtr
        {
            [XmlElement(ElementName = "Nm")]
            public string Nm { get; set; }
        }

        public class DbtrAcct
        {
            [XmlElement(ElementName = "Id")]
            public Id Id { get; set; }
        }

        public class DbtrAgt
        {
            [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        public class CdtrAgt
        {
            [XmlElement(ElementName = "FinInstnId")]
            public FinInstnId FinInstnId { get; set; }
        }

        public class Cdtr
        {
            [XmlElement(ElementName = "Nm")]
            public string Nm { get; set; }
        }

        public class CdtrAcct
        {
            [XmlElement(ElementName = "Id")]
            public Id Id { get; set; }
        }

        public class Purp
        {
            [XmlElement(ElementName = "Cd")]
            public string Cd { get; set; }
        }

        public class RmtInf
        {
            [XmlElement(ElementName = "Ustrd")]
            public string Ustrd { get; set; }
        }

        public class Id
        {
            [XmlElement(ElementName = "Othr")]
            public Othr Othr { get; set; }
        }

    }
}
