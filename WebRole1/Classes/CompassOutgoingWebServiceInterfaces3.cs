﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Web.Services.WebServiceBindingAttribute(Name="CompassOutgoingWebServicePortBinding", Namespace="http://host.wm6.swisslog.com/")]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(messageResponse))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(hostOrderLu))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(messageRequest))]
public interface ICompassOutgoingWebServicePortBinding {
    
    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("orderStatusChangeNotification", RequestNamespace="http://host.wm6.swisslog.com/", ResponseNamespace="http://host.wm6.swisslog.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("orderStatusChangeNotificationMessageResponse", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    orderStatusChangeNotificationMessageResponse orderStatusChangeNotification([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] orderStatusChangeNotificationMessageRequest orderStatusChangeNotificationMessageRequest);
    
    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("orderPickConfirmation ", RequestNamespace="http://host.wm6.swisslog.com/", ResponseNamespace="http://host.wm6.swisslog.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("orderPickConfirmationMessageResponse", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    orderPickConfirmationMessageResponse orderPickConfirmation([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] cpOrderPickConfirmationMessageRequest orderPickConfirmationMessageRequest);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public partial class orderStatusChangeNotificationMessageRequest : messageRequest {
    
    private string orderIdField;
    
    private string ownerField;
    
    private string prevStatusField;
    
    private string statusField;
    
    private string workstationIdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string orderId {
        get {
            return this.orderIdField;
        }
        set {
            this.orderIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string owner {
        get {
            return this.ownerField;
        }
        set {
            this.ownerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string prevStatus {
        get {
            return this.prevStatusField;
        }
        set {
            this.prevStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string workstationId {
        get {
            return this.workstationIdField;
        }
        set {
            this.workstationIdField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(orderStatusChangeNotificationMessageRequest))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(orderPickConfirmationMessageRequest))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(cpOrderPickConfirmationMessageRequest))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public abstract partial class messageRequest {
    
    private messageHeader messageHeaderField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public messageHeader messageHeader {
        get {
            return this.messageHeaderField;
        }
        set {
            this.messageHeaderField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public partial class messageHeader {
    
    private string msgIdField;
    
    private string msgTypeField;
    
    private string transCodeField;
    
    private System.DateTime msgTimeField;
    
    private bool msgTimeFieldSpecified;
    
    private string senderField;
    
    private string receiverField;
    
    private string versionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string msgId {
        get {
            return this.msgIdField;
        }
        set {
            this.msgIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string msgType {
        get {
            return this.msgTypeField;
        }
        set {
            this.msgTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string transCode {
        get {
            return this.transCodeField;
        }
        set {
            this.transCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime msgTime {
        get {
            return this.msgTimeField;
        }
        set {
            this.msgTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool msgTimeSpecified {
        get {
            return this.msgTimeFieldSpecified;
        }
        set {
            this.msgTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string sender {
        get {
            return this.senderField;
        }
        set {
            this.senderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string receiver {
        get {
            return this.receiverField;
        }
        set {
            this.receiverField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public partial class messageError {
    
    private int codeField;
    
    private bool codeFieldSpecified;
    
    private string messageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool codeSpecified {
        get {
            return this.codeFieldSpecified;
        }
        set {
            this.codeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string message {
        get {
            return this.messageField;
        }
        set {
            this.messageField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(orderStatusChangeNotificationMessageResponse))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(orderPickConfirmationMessageResponse))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public partial class messageResponse {
    
    private messageHeader messageHeaderField;
    
    private messageError messageErrorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public messageHeader messageHeader {
        get {
            return this.messageHeaderField;
        }
        set {
            this.messageHeaderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public messageError messageError {
        get {
            return this.messageErrorField;
        }
        set {
            this.messageErrorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public partial class orderStatusChangeNotificationMessageResponse : messageResponse {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public partial class orderPickConfirmationMessageResponse : messageResponse {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public partial class hostAttributeValue {
    
    private string nameField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(cpHostOrderLu))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public partial class hostOrderLu {
    
    private int orderLineNumberField;
    
    private string orderTuIdField;
    
    private string orderTuTypeField;
    
    private string productIdField;
    
    private string productVersionIdField;
    
    private double quantityField;
    
    private hostAttributeValue[] attributeValueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int orderLineNumber {
        get {
            return this.orderLineNumberField;
        }
        set {
            this.orderLineNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string orderTuId {
        get {
            return this.orderTuIdField;
        }
        set {
            this.orderTuIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string orderTuType {
        get {
            return this.orderTuTypeField;
        }
        set {
            this.orderTuTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string productId {
        get {
            return this.productIdField;
        }
        set {
            this.productIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string productVersionId {
        get {
            return this.productVersionIdField;
        }
        set {
            this.productVersionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public double quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("attributeValue", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public hostAttributeValue[] attributeValue {
        get {
            return this.attributeValueField;
        }
        set {
            this.attributeValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public partial class cpHostOrderLu : hostOrderLu {
    
    private string trackingNumberField;
    
    private double parcelWeightField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string trackingNumber {
        get {
            return this.trackingNumberField;
        }
        set {
            this.trackingNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public double parcelWeight {
        get {
            return this.parcelWeightField;
        }
        set {
            this.parcelWeightField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(cpOrderPickConfirmationMessageRequest))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public partial class orderPickConfirmationMessageRequest : messageRequest {
    
    private string orderIdField;
    
    private string ownerField;
    
    private string shipmentIdField;
    
    private int stopSequenceField;
    
    private bool stopSequenceFieldSpecified;
    
    private cpHostOrderLu[] orderLineField;
    
    private string workstationIdField;
    
    private string operatorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string orderId {
        get {
            return this.orderIdField;
        }
        set {
            this.orderIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string owner {
        get {
            return this.ownerField;
        }
        set {
            this.ownerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string shipmentId {
        get {
            return this.shipmentIdField;
        }
        set {
            this.shipmentIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int stopSequence {
        get {
            return this.stopSequenceField;
        }
        set {
            this.stopSequenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool stopSequenceSpecified {
        get {
            return this.stopSequenceFieldSpecified;
        }
        set {
            this.stopSequenceFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("orderLine", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public cpHostOrderLu[] orderLine {
        get {
            return this.orderLineField;
        }
        set {
            this.orderLineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string workstationId {
        get {
            return this.workstationIdField;
        }
        set {
            this.workstationIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string @operator {
        get {
            return this.operatorField;
        }
        set {
            this.operatorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://host.wm6.swisslog.com/")]
public partial class cpOrderPickConfirmationMessageRequest : orderPickConfirmationMessageRequest {
}
