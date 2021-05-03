namespace Biztalk.Demo.Test {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Biztalk.Demo.Test.ImageWebServiceService_schemas_xmlsoap_org_soap_encoding", typeof(global::Biztalk.Demo.Test.ImageWebServiceService_schemas_xmlsoap_org_soap_encoding))]
    public sealed class ImageWebServiceService_messaging_edscs_exigen_com : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://messaging.edscs.exigen.com"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <import schemaLocation=""Biztalk.Demo.Test.ImageWebServiceService_schemas_xmlsoap_org_soap_encoding"" namespace=""http://schemas.xmlsoap.org/soap/encoding/"" />
  <annotation>
    <appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.xmlsoap.org/soap/encoding/"" />
      </references>
    </appinfo>
  </annotation>
  <complexType name=""InterfaceException"">
    <sequence />
  </complexType>
  <complexType name=""MandatoryParameterNotSupplied"">
    <complexContent mixed=""false"">
      <extension xmlns:q1=""http://messaging.edscs.exigen.com"" base=""q1:InterfaceException"">
        <sequence />
      </extension>
    </complexContent>
  </complexType>
  <complexType name=""ApplicationException"">
    <complexContent mixed=""false"">
      <extension xmlns:q2=""http://messaging.edscs.exigen.com"" base=""q2:InterfaceException"">
        <sequence />
      </extension>
    </complexContent>
  </complexType>
</schema>";
        
        public ImageWebServiceService_messaging_edscs_exigen_com() {
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
