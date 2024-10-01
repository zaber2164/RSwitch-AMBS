using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Asai.Ambs.RSwitch.Library
{

    //// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01", IsNullable = false)]
    //public partial class AppHdr
    //{

    //    private Signature signatureField;

    //    private string[] textField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //    public Signature Signature
    //    {
    //        get
    //        {
    //            return this.signatureField;
    //        }
    //        set
    //        {
    //            this.signatureField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string[] Text
    //    {
    //        get
    //        {
    //            return this.textField;
    //        }
    //        set
    //        {
    //            this.textField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    //public partial class Signature
    //{

    //    private SignatureSignedInfo signedInfoField;

    //    private string signatureValueField;

    //    private SignatureKeyInfo keyInfoField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public SignatureSignedInfo SignedInfo
    //    {
    //        get
    //        {
    //            return this.signedInfoField;
    //        }
    //        set
    //        {
    //            this.signedInfoField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public string SignatureValue
    //    {
    //        get
    //        {
    //            return this.signatureValueField;
    //        }
    //        set
    //        {
    //            this.signatureValueField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public SignatureKeyInfo KeyInfo
    //    {
    //        get
    //        {
    //            return this.keyInfoField;
    //        }
    //        set
    //        {
    //            this.keyInfoField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string[] Text
    //    {
    //        get
    //        {
    //            return this.textField;
    //        }
    //        set
    //        {
    //            this.textField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //public partial class SignatureSignedInfo
    //{

    //    private SignatureSignedInfoCanonicalizationMethod canonicalizationMethodField;

    //    private SignatureSignedInfoSignatureMethod signatureMethodField;

    //    private SignatureSignedInfoReference[] referenceField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public SignatureSignedInfoCanonicalizationMethod CanonicalizationMethod
    //    {
    //        get
    //        {
    //            return this.canonicalizationMethodField;
    //        }
    //        set
    //        {
    //            this.canonicalizationMethodField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public SignatureSignedInfoSignatureMethod SignatureMethod
    //    {
    //        get
    //        {
    //            return this.signatureMethodField;
    //        }
    //        set
    //        {
    //            this.signatureMethodField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute("Reference")]
    //    public SignatureSignedInfoReference[] Reference
    //    {
    //        get
    //        {
    //            return this.referenceField;
    //        }
    //        set
    //        {
    //            this.referenceField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string[] Text
    //    {
    //        get
    //        {
    //            return this.textField;
    //        }
    //        set
    //        {
    //            this.textField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //public partial class SignatureSignedInfoCanonicalizationMethod
    //{

    //    private string algorithmField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string Algorithm
    //    {
    //        get
    //        {
    //            return this.algorithmField;
    //        }
    //        set
    //        {
    //            this.algorithmField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //public partial class SignatureSignedInfoSignatureMethod
    //{

    //    private string algorithmField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string Algorithm
    //    {
    //        get
    //        {
    //            return this.algorithmField;
    //        }
    //        set
    //        {
    //            this.algorithmField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //public partial class SignatureSignedInfoReference
    //{

    //    private SignatureSignedInfoReferenceTransforms transformsField;

    //    private SignatureSignedInfoReferenceDigestMethod digestMethodField;

    //    private string digestValueField;

    //    private string[] textField;

    //    private string uRIField;

    //    /// <remarks/>
    //    public SignatureSignedInfoReferenceTransforms Transforms
    //    {
    //        get
    //        {
    //            return this.transformsField;
    //        }
    //        set
    //        {
    //            this.transformsField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public SignatureSignedInfoReferenceDigestMethod DigestMethod
    //    {
    //        get
    //        {
    //            return this.digestMethodField;
    //        }
    //        set
    //        {
    //            this.digestMethodField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public string DigestValue
    //    {
    //        get
    //        {
    //            return this.digestValueField;
    //        }
    //        set
    //        {
    //            this.digestValueField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string[] Text
    //    {
    //        get
    //        {
    //            return this.textField;
    //        }
    //        set
    //        {
    //            this.textField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string URI
    //    {
    //        get
    //        {
    //            return this.uRIField;
    //        }
    //        set
    //        {
    //            this.uRIField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //public partial class SignatureSignedInfoReferenceTransforms
    //{

    //    private SignatureSignedInfoReferenceTransformsTransform[] transformField;

    //    private string[] textField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute("Transform")]
    //    public SignatureSignedInfoReferenceTransformsTransform[] Transform
    //    {
    //        get
    //        {
    //            return this.transformField;
    //        }
    //        set
    //        {
    //            this.transformField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string[] Text
    //    {
    //        get
    //        {
    //            return this.textField;
    //        }
    //        set
    //        {
    //            this.textField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //public partial class SignatureSignedInfoReferenceTransformsTransform
    //{

    //    private string algorithmField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string Algorithm
    //    {
    //        get
    //        {
    //            return this.algorithmField;
    //        }
    //        set
    //        {
    //            this.algorithmField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //public partial class SignatureSignedInfoReferenceDigestMethod
    //{

    //    private string algorithmField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string Algorithm
    //    {
    //        get
    //        {
    //            return this.algorithmField;
    //        }
    //        set
    //        {
    //            this.algorithmField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //public partial class SignatureKeyInfo
    //{

    //    private SignatureKeyInfoKeyValue keyValueField;

    //    private SignatureKeyInfoX509Data x509DataField;

    //    private string[] textField;

    //    private string idField;

    //    /// <remarks/>
    //    public SignatureKeyInfoKeyValue KeyValue
    //    {
    //        get
    //        {
    //            return this.keyValueField;
    //        }
    //        set
    //        {
    //            this.keyValueField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public SignatureKeyInfoX509Data X509Data
    //    {
    //        get
    //        {
    //            return this.x509DataField;
    //        }
    //        set
    //        {
    //            this.x509DataField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string[] Text
    //    {
    //        get
    //        {
    //            return this.textField;
    //        }
    //        set
    //        {
    //            this.textField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string Id
    //    {
    //        get
    //        {
    //            return this.idField;
    //        }
    //        set
    //        {
    //            this.idField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //public partial class SignatureKeyInfoKeyValue
    //{

    //    private SignatureKeyInfoKeyValueRSAKeyValue rSAKeyValueField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public SignatureKeyInfoKeyValueRSAKeyValue RSAKeyValue
    //    {
    //        get
    //        {
    //            return this.rSAKeyValueField;
    //        }
    //        set
    //        {
    //            this.rSAKeyValueField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string[] Text
    //    {
    //        get
    //        {
    //            return this.textField;
    //        }
    //        set
    //        {
    //            this.textField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //public partial class SignatureKeyInfoKeyValueRSAKeyValue
    //{

    //    private string modulusField;

    //    private string exponentField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public string Modulus
    //    {
    //        get
    //        {
    //            return this.modulusField;
    //        }
    //        set
    //        {
    //            this.modulusField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public string Exponent
    //    {
    //        get
    //        {
    //            return this.exponentField;
    //        }
    //        set
    //        {
    //            this.exponentField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string[] Text
    //    {
    //        get
    //        {
    //            return this.textField;
    //        }
    //        set
    //        {
    //            this.textField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    //public partial class SignatureKeyInfoX509Data
    //{

    //    private string x509CertificateField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public string X509Certificate
    //    {
    //        get
    //        {
    //            return this.x509CertificateField;
    //        }
    //        set
    //        {
    //            this.x509CertificateField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string[] Text
    //    {
    //        get
    //        {
    //            return this.textField;
    //        }
    //        set
    //        {
    //            this.textField = value;
    //        }
    //    }
    //}


    //public class Rootobject
    //{
    //    public Apphdr AppHdr { get; set; }
    //}

    [XmlRoot(ElementName = "Apphdr")]
    public class Apphdr
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string xmlns { get; set; }
        [XmlElement(ElementName = "ds:Signature")]
        public Signature Signature { get; set; }
    }

    public class Signature
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string xmlns { get; set; }
        [XmlElement(ElementName = "ds:SignedInfo")]
        public Signedinfo SignedInfo { get; set; }
        [XmlElement(ElementName = "ds:SignatureValue")]
        public string SignatureValue { get; set; }
        [XmlElement(ElementName = "ds:KeyInfo")]
        public Keyinfo KeyInfo { get; set; }
    }

    public class Signedinfo
    {
        [XmlElement(ElementName = "ds:CanonicalizationMethod")]
        public CanonicalizationMethod CanonicalizationMethod { get; set; }
        [XmlElement(ElementName = "ds:SignatureMethod")]
        public SignatureMethod SignatureMethod { get; set; }
        [XmlElement(ElementName = "ds:Reference")]
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
        public string URI { get; set; }
        [XmlElement(ElementName = "ds:Transforms")]
        public Transforms Transforms { get; set; }
        [XmlElement(ElementName = "ds:DigestMethod")]
        public DigestMethod DigestMethod { get; set; }
        [XmlElement(ElementName = "ds:DigestValue")]
        public string DigestValue { get; set; }
    }
    public class DigestMethod
    {
        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    public class Transforms
    {
        public Transform Transform { get; set; }
    }
    public class Transform
    {
        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    public class Keyinfo
    {
        [XmlElement(ElementName = "ds:KeyValue")]
        public Keyvalue KeyValue { get; set; }
        [XmlElement(ElementName = "ds:X509Data")]
        public X509data X509Data { get; set; }
    }

    public class Keyvalue
    {
        [XmlElement(ElementName = "ds:RSAKeyValue")]
        public Rsakeyvalue RSAKeyValue { get; set; }
    }

    public class Rsakeyvalue
    {
        [XmlElement(ElementName = "ds:Modulus")]
        public string Modulus { get; set; }
        [XmlElement(ElementName = "ds:Exponent")]
        public string Exponent { get; set; }
    }

    public class X509data
    {
        [XmlElement(ElementName = "ds:X509Certificate")]
        public string X509Certificate { get; set; }
    }

}
