namespace Biztalk.Demo.Test {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Biztalk.Demo.Test.ImageWebServiceService_schemas_xmlsoap_org_soap_encoding", typeof(global::Biztalk.Demo.Test.ImageWebServiceService_schemas_xmlsoap_org_soap_encoding))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Biztalk.Demo.Test.ImageWebServiceService_messaging_edscs_exigen_com", typeof(global::Biztalk.Demo.Test.ImageWebServiceService_messaging_edscs_exigen_com))]
    public sealed class ImageWebServiceService_image_messaging_edscs_exigen_com : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://image.messaging.edscs.exigen.com"" xmlns:q1=""http://messaging.edscs.exigen.com"" targetNamespace=""http://image.messaging.edscs.exigen.com"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <import schemaLocation=""Biztalk.Demo.Test.ImageWebServiceService_schemas_xmlsoap_org_soap_encoding"" namespace=""http://schemas.xmlsoap.org/soap/encoding/"" />
  <import schemaLocation=""Biztalk.Demo.Test.ImageWebServiceService_messaging_edscs_exigen_com"" namespace=""http://messaging.edscs.exigen.com"" />
  <annotation>
    <appinfo>
      <b:references>
        <b:reference targetNamespace=""http://messaging.edscs.exigen.com"" />
        <b:reference targetNamespace=""http://schemas.xmlsoap.org/soap/encoding/"" />
      </b:references>
    </appinfo>
  </annotation>
  <complexType name=""CreateDocumentRequest"">
    <sequence>
      <element name=""DRUID"" nillable=""true"" type=""string"" />
      <element name=""clientId"" nillable=""true"" type=""string"" />
      <element name=""createDate"" nillable=""true"" type=""dateTime"" />
      <element name=""createUser"" nillable=""true"" type=""string"" />
      <element name=""creditApplicationId"" nillable=""true"" type=""long"" />
      <element name=""docSource"" nillable=""true"" type=""string"" />
      <element name=""docType"" nillable=""true"" type=""string"" />
      <element name=""pageCount"" nillable=""true"" type=""int"" />
      <element name=""trxId"" nillable=""true"" type=""long"" />
    </sequence>
  </complexType>
  <complexType name=""ExistingTransactionNotFound"">
    <complexContent mixed=""false"">
      <extension base=""q1:InterfaceException"">
        <sequence />
      </extension>
    </complexContent>
  </complexType>
  <complexType name=""CreateImageRequest"">
    <sequence>
      <element name=""imageBLOB"" type=""base64Binary"" />
      <element name=""imageType"" nillable=""true"" type=""string"" />
    </sequence>
  </complexType>
  <complexType name=""RetrieveImageRequest"">
    <sequence>
      <element name=""DRUID"" nillable=""true"" type=""string"" />
      <element name=""clientId"" nillable=""true"" type=""string"" />
      <element name=""documentID"" nillable=""true"" type=""int"" />
    </sequence>
  </complexType>
  <complexType name=""ImageResponse"">
    <sequence>
      <element name=""imageBLOB"" type=""base64Binary"" />
      <element name=""imageType"" nillable=""true"" type=""string"" />
    </sequence>
  </complexType>
  <complexType name=""DocumentNotFoundByID"">
    <complexContent mixed=""false"">
      <extension xmlns:q2=""http://messaging.edscs.exigen.com"" base=""q2:InterfaceException"">
        <sequence />
      </extension>
    </complexContent>
  </complexType>
  <complexType name=""DocumentImageNotFound"">
    <complexContent mixed=""false"">
      <extension xmlns:q3=""http://messaging.edscs.exigen.com"" base=""q3:InterfaceException"">
        <sequence />
      </extension>
    </complexContent>
  </complexType>
  <complexType name=""DocumentAndDRUIDUnmatched"">
    <complexContent mixed=""false"">
      <extension xmlns:q4=""http://messaging.edscs.exigen.com"" base=""q4:InterfaceException"">
        <sequence />
      </extension>
    </complexContent>
  </complexType>
  <complexType name=""DocumentNotFoundByDRUID"">
    <complexContent mixed=""false"">
      <extension xmlns:q5=""http://messaging.edscs.exigen.com"" base=""q5:InterfaceException"">
        <sequence />
      </extension>
    </complexContent>
  </complexType>
</schema>";
        
        public ImageWebServiceService_image_messaging_edscs_exigen_com() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [0];
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
