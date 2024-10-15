using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RSwitch.AMBS.Library
{

    //// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07", IsNullable = false)]
    //public partial class Document
    //{

    //    private DocumentGetAcct getAcctField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public DocumentGetAcct GetAcct
    //    {
    //        get
    //        {
    //            return this.getAcctField;
    //        }
    //        set
    //        {
    //            this.getAcctField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcct
    //{

    //    private DocumentGetAcctMsgHdr msgHdrField;

    //    private DocumentGetAcctAcctQryDef acctQryDefField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public DocumentGetAcctMsgHdr MsgHdr
    //    {
    //        get
    //        {
    //            return this.msgHdrField;
    //        }
    //        set
    //        {
    //            this.msgHdrField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDef AcctQryDef
    //    {
    //        get
    //        {
    //            return this.acctQryDefField;
    //        }
    //        set
    //        {
    //            this.acctQryDefField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctMsgHdr
    //{

    //    private string msgIdField;

    //    private System.DateTime creDtTmField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public string MsgId
    //    {
    //        get
    //        {
    //            return this.msgIdField;
    //        }
    //        set
    //        {
    //            this.msgIdField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public System.DateTime CreDtTm
    //    {
    //        get
    //        {
    //            return this.creDtTmField;
    //        }
    //        set
    //        {
    //            this.creDtTmField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDef
    //{

    //    private DocumentGetAcctAcctQryDefAcctCrit acctCritField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDefAcctCrit AcctCrit
    //    {
    //        get
    //        {
    //            return this.acctCritField;
    //        }
    //        set
    //        {
    //            this.acctCritField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDefAcctCrit
    //{

    //    private DocumentGetAcctAcctQryDefAcctCritNewCrit newCritField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDefAcctCritNewCrit NewCrit
    //    {
    //        get
    //        {
    //            return this.newCritField;
    //        }
    //        set
    //        {
    //            this.newCritField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDefAcctCritNewCrit
    //{

    //    private DocumentGetAcctAcctQryDefAcctCritNewCritSchCrit schCritField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDefAcctCritNewCritSchCrit SchCrit
    //    {
    //        get
    //        {
    //            return this.schCritField;
    //        }
    //        set
    //        {
    //            this.schCritField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDefAcctCritNewCritSchCrit
    //{

    //    private DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctId acctIdField;

    //    private DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctOwnr acctOwnrField;

    //    private DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctSvcr acctSvcrField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctId AcctId
    //    {
    //        get
    //        {
    //            return this.acctIdField;
    //        }
    //        set
    //        {
    //            this.acctIdField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctOwnr AcctOwnr
    //    {
    //        get
    //        {
    //            return this.acctOwnrField;
    //        }
    //        set
    //        {
    //            this.acctOwnrField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctSvcr AcctSvcr
    //    {
    //        get
    //        {
    //            return this.acctSvcrField;
    //        }
    //        set
    //        {
    //            this.acctSvcrField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctId
    //{

    //    private DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctIdEQ eqField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctIdEQ EQ
    //    {
    //        get
    //        {
    //            return this.eqField;
    //        }
    //        set
    //        {
    //            this.eqField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctIdEQ
    //{

    //    private DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctIdEQOthr othrField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctIdEQOthr Othr
    //    {
    //        get
    //        {
    //            return this.othrField;
    //        }
    //        set
    //        {
    //            this.othrField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctIdEQOthr
    //{

    //    private ulong idField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public ulong Id
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctOwnr
    //{

    //    private DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctOwnrCtctDtls ctctDtlsField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctOwnrCtctDtls CtctDtls
    //    {
    //        get
    //        {
    //            return this.ctctDtlsField;
    //        }
    //        set
    //        {
    //            this.ctctDtlsField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctOwnrCtctDtls
    //{

    //    private ulong mobNbField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public ulong MobNb
    //    {
    //        get
    //        {
    //            return this.mobNbField;
    //        }
    //        set
    //        {
    //            this.mobNbField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctSvcr
    //{

    //    private DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctSvcrFinInstnId finInstnIdField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctSvcrFinInstnId FinInstnId
    //    {
    //        get
    //        {
    //            return this.finInstnIdField;
    //        }
    //        set
    //        {
    //            this.finInstnIdField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctSvcrFinInstnId
    //{

    //    private DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctSvcrFinInstnIdOthr othrField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctSvcrFinInstnIdOthr Othr
    //    {
    //        get
    //        {
    //            return this.othrField;
    //        }
    //        set
    //        {
    //            this.othrField = value;
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
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07")]
    //public partial class DocumentGetAcctAcctQryDefAcctCritNewCritSchCritAcctSvcrFinInstnIdOthr
    //{

    //    private byte idField;

    //    private string[] textField;

    //    /// <remarks/>
    //    public byte Id
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
    //    public Document Document { get; set; }
    //}

    //[XmlRoot(ElementName = "Document")]
    //public class Document
    //{
    //    [XmlAttribute(AttributeName = "xmlns")]
    //    public string xmlns { get; set; }
    //    [XmlAttribute(AttributeName = "xmlns:xsi")]
    //    public string xmlns_xsi { get; set; }
    //    [XmlAttribute(AttributeName = "xsi:schemaLocation")]
    //    public string xsi_schemaLocation { get; set; }
    //    [XmlElement(ElementName = "GetAcct")]
    //    public Getacct GetAcct { get; set; }
    //}

    //public class Getacct
    //{
    //    [XmlElement(Order = 0)]
    //    public Msghdr MsgHdr { get; set; }
    //    [XmlElement(Order = 1)]
    //    public Acctqrydef AcctQryDef { get; set; }
    //}

    //public class Msghdr
    //{
    //    [XmlElement(Order = 0)]
    //    public string MsgId { get; set; }
    //    [XmlElement(Order = 1)]
    //    public DateTime CreDtTm { get; set; }
    //}

    //public class Acctqrydef
    //{
    //    [XmlElement(Order = 0)]
    //    public Acctcrit AcctCrit { get; set; }
    //}

    //public class Acctcrit
    //{
    //    [XmlElement(Order = 0)]
    //    public Newcrit NewCrit { get; set; }
    //}

    //public class Newcrit
    //{
    //    [XmlElement(Order = 0)]
    //    public Schcrit SchCrit { get; set; }
    //}

    //public class Schcrit
    //{
    //    [XmlElement(Order = 0)]
    //    public Acctid AcctId { get; set; }
    //    [XmlElement(Order = 1)]
    //    public Acctownr AcctOwnr { get; set; }
    //    [XmlElement(Order = 2)]
    //    public Acctsvcr AcctSvcr { get; set; }
    //}

    //public class Acctid
    //{
    //    [XmlElement(Order = 0)]
    //    public EQ EQ { get; set; }
    //}

    //public class EQ
    //{
    //    [XmlElement(Order = 0)]
    //    public Othr Othr { get; set; }
    //}

    //public class Othr
    //{
    //    public long Id { get; set; }
    //}

    //public class Acctownr
    //{
    //    [XmlElement(Order = 0)]
    //    public Ctctdtls CtctDtls { get; set; }
    //}

    //public class Ctctdtls
    //{
    //    public long MobNb { get; set; }
    //}

    //public class Acctsvcr
    //{
    //    [XmlElement(Order = 0)]
    //    public Fininstnid FinInstnId { get; set; }
    //}

    //public class Fininstnid
    //{
    //    [XmlElement(Order = 0)]
    //    public Othr1 Othr { get; set; }
    //}

    //public class Othr1
    //{
    //    public int Id { get; set; }
    //}

}
