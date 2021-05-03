namespace Biztalk.Demo.Test {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://image.messaging.edscs.exigen.com",@"retrieveDocumentImage")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"retrieveDocumentImage"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Biztalk.Demo.Test.ImageWebServiceService_image_messaging_edscs_exigen_com", typeof(global::Biztalk.Demo.Test.ImageWebServiceService_image_messaging_edscs_exigen_com))]
    public sealed class ImageWebServiceService_image_messaging_edscs_exigen_com_5 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://image.messaging.edscs.exigen.com"" targetNamespace=""http://image.messaging.edscs.exigen.com"" id=""retrieveDocumentImageRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:include schemaLocation=""Biztalk.Demo.Test.ImageWebServiceService_image_messaging_edscs_exigen_com"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://messaging.edscs.exigen.com"" />
        <reference targetNamespace=""http://schemas.xmlsoap.org/soap/encoding/"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""retrieveDocumentImage"">
    <xs:annotation>
      <xs:documentation>Wrapper element for message ""retrieveDocumentImageRequest"" of RPC operation ""retrieveDocumentImage"".</xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""request"" type=""tns:RetrieveImageRequest"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ImageWebServiceService_image_messaging_edscs_exigen_com_5() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "retrieveDocumentImage";
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
