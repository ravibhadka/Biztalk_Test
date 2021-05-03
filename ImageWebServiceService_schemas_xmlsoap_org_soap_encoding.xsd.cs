namespace Biztalk.Demo.Test {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Array", @"Struct", @"duration", @"dateTime", @"NOTATION", @"time", @"date", @"gYearMonth", @"gYear", @"gMonthDay", @"gDay", @"gMonth", @"boolean", @"base64Binary", @"hexBinary", @"float", @"double", @"anyURI", @"QName", @"string", @"normalizedString", @"token", @"language", @"Name", @"NMTOKEN", @"NCName", @"NMTOKENS", @"ID", @"IDREF", @"ENTITY", @"IDREFS", @"ENTITIES", @"decimal", @"integer", @"nonPositiveInteger", @"negativeInteger", @"long", @"int", @"short", 
@"byte", @"nonNegativeInteger", @"unsignedLong", @"unsignedInt", @"unsignedShort", @"unsignedByte", @"positiveInteger", @"anyType"})]
    public sealed class ImageWebServiceService_schemas_xmlsoap_org_soap_encoding : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.xmlsoap.org/soap/encoding/"" targetNamespace=""http://schemas.xmlsoap.org/soap/encoding/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:attribute name=""root"">
    <xs:annotation>
      <xs:documentation>
	   'root' can be used to distinguish serialization roots from other
       elements that are present in a serialization but are not roots of
       a serialized value graph 
	 </xs:documentation>
    </xs:annotation>
    <xs:simpleType>
      <xs:restriction base=""xs:boolean"">
        <xs:pattern value=""0|1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:attribute>
  <xs:attributeGroup name=""commonAttributes"">
    <xs:annotation>
      <xs:documentation>
	    Attributes common to all elements that function as accessors or 
        represent independent (multi-ref) values.  The href attribute is
        intended to be used in a manner like CONREF.  That is, the element
        content should be empty iff the href attribute appears
	  </xs:documentation>
    </xs:annotation>
    <xs:attribute name=""id"" type=""xs:ID"" />
    <xs:attribute name=""href"" type=""xs:anyURI"" />
    <xs:anyAttribute namespace=""##other"" processContents=""lax"" />
  </xs:attributeGroup>
  <xs:simpleType name=""arrayCoordinate"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:attribute name=""arrayType"" type=""xs:string"" />
  <xs:attribute name=""offset"" type=""tns:arrayCoordinate"" />
  <xs:attributeGroup name=""arrayAttributes"">
    <xs:attribute ref=""tns:arrayType"" />
    <xs:attribute ref=""tns:offset"" />
  </xs:attributeGroup>
  <xs:attribute name=""position"" type=""tns:arrayCoordinate"" />
  <xs:attributeGroup name=""arrayMemberAttributes"">
    <xs:attribute ref=""tns:position"" />
  </xs:attributeGroup>
  <xs:group name=""Array"">
    <xs:sequence>
      <xs:any minOccurs=""0"" maxOccurs=""unbounded"" namespace=""##any"" processContents=""lax"" />
    </xs:sequence>
  </xs:group>
  <xs:element name=""Array"" type=""tns:Array"" />
  <xs:complexType name=""Array"">
    <xs:annotation>
      <xs:documentation>
	   'Array' is a complex type for accessors identified by position 
	  </xs:documentation>
    </xs:annotation>
    <xs:group minOccurs=""0"" ref=""tns:Array"" />
    <xs:attributeGroup ref=""tns:arrayAttributes"" />
    <xs:attributeGroup ref=""tns:commonAttributes"" />
  </xs:complexType>
  <xs:element name=""Struct"" type=""tns:Struct"" />
  <xs:group name=""Struct"">
    <xs:sequence>
      <xs:any minOccurs=""0"" maxOccurs=""unbounded"" namespace=""##any"" processContents=""lax"" />
    </xs:sequence>
  </xs:group>
  <xs:complexType name=""Struct"">
    <xs:group minOccurs=""0"" ref=""tns:Struct"" />
    <xs:attributeGroup ref=""tns:commonAttributes"" />
  </xs:complexType>
  <xs:simpleType name=""base64"">
    <xs:restriction base=""xs:base64Binary"" />
  </xs:simpleType>
  <xs:element name=""duration"" type=""tns:duration"" />
  <xs:complexType name=""duration"">
    <xs:simpleContent>
      <xs:extension base=""xs:duration"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""dateTime"" type=""tns:dateTime"" />
  <xs:complexType name=""dateTime"">
    <xs:simpleContent>
      <xs:extension base=""xs:dateTime"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""NOTATION"" type=""tns:NOTATION"" />
  <xs:complexType name=""NOTATION"">
    <xs:simpleContent>
      <xs:extension base=""xs:QName"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""time"" type=""tns:time"" />
  <xs:complexType name=""time"">
    <xs:simpleContent>
      <xs:extension base=""xs:time"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""date"" type=""tns:date"" />
  <xs:complexType name=""date"">
    <xs:simpleContent>
      <xs:extension base=""xs:date"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""gYearMonth"" type=""tns:gYearMonth"" />
  <xs:complexType name=""gYearMonth"">
    <xs:simpleContent>
      <xs:extension base=""xs:gYearMonth"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""gYear"" type=""tns:gYear"" />
  <xs:complexType name=""gYear"">
    <xs:simpleContent>
      <xs:extension base=""xs:gYear"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""gMonthDay"" type=""tns:gMonthDay"" />
  <xs:complexType name=""gMonthDay"">
    <xs:simpleContent>
      <xs:extension base=""xs:gMonthDay"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""gDay"" type=""tns:gDay"" />
  <xs:complexType name=""gDay"">
    <xs:simpleContent>
      <xs:extension base=""xs:gDay"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""gMonth"" type=""tns:gMonth"" />
  <xs:complexType name=""gMonth"">
    <xs:simpleContent>
      <xs:extension base=""xs:gMonth"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""boolean"" type=""tns:boolean"" />
  <xs:complexType name=""boolean"">
    <xs:simpleContent>
      <xs:extension base=""xs:boolean"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""base64Binary"" type=""tns:base64Binary"" />
  <xs:complexType name=""base64Binary"">
    <xs:simpleContent>
      <xs:extension base=""xs:base64Binary"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""hexBinary"" type=""tns:hexBinary"" />
  <xs:complexType name=""hexBinary"">
    <xs:simpleContent>
      <xs:extension base=""xs:hexBinary"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""float"" type=""tns:float"" />
  <xs:complexType name=""float"">
    <xs:simpleContent>
      <xs:extension base=""xs:float"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""double"" type=""tns:double"" />
  <xs:complexType name=""double"">
    <xs:simpleContent>
      <xs:extension base=""xs:double"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""anyURI"" type=""tns:anyURI"" />
  <xs:complexType name=""anyURI"">
    <xs:simpleContent>
      <xs:extension base=""xs:anyURI"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""QName"" type=""tns:QName"" />
  <xs:complexType name=""QName"">
    <xs:simpleContent>
      <xs:extension base=""xs:QName"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""string"" type=""tns:string"" />
  <xs:complexType name=""string"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""normalizedString"" type=""tns:normalizedString"" />
  <xs:complexType name=""normalizedString"">
    <xs:simpleContent>
      <xs:extension base=""xs:normalizedString"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""token"" type=""tns:token"" />
  <xs:complexType name=""token"">
    <xs:simpleContent>
      <xs:extension base=""xs:token"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""language"" type=""tns:language"" />
  <xs:complexType name=""language"">
    <xs:simpleContent>
      <xs:extension base=""xs:language"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""Name"" type=""tns:Name"" />
  <xs:complexType name=""Name"">
    <xs:simpleContent>
      <xs:extension base=""xs:Name"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""NMTOKEN"" type=""tns:NMTOKEN"" />
  <xs:complexType name=""NMTOKEN"">
    <xs:simpleContent>
      <xs:extension base=""xs:NMTOKEN"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""NCName"" type=""tns:NCName"" />
  <xs:complexType name=""NCName"">
    <xs:simpleContent>
      <xs:extension base=""xs:NCName"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""NMTOKENS"" type=""tns:NMTOKENS"" />
  <xs:complexType name=""NMTOKENS"">
    <xs:simpleContent>
      <xs:extension base=""xs:NMTOKENS"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""ID"" type=""tns:ID"" />
  <xs:complexType name=""ID"">
    <xs:simpleContent>
      <xs:extension base=""xs:ID"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""IDREF"" type=""tns:IDREF"" />
  <xs:complexType name=""IDREF"">
    <xs:simpleContent>
      <xs:extension base=""xs:IDREF"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""ENTITY"" type=""tns:ENTITY"" />
  <xs:complexType name=""ENTITY"">
    <xs:simpleContent>
      <xs:extension base=""xs:ENTITY"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""IDREFS"" type=""tns:IDREFS"" />
  <xs:complexType name=""IDREFS"">
    <xs:simpleContent>
      <xs:extension base=""xs:IDREFS"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""ENTITIES"" type=""tns:ENTITIES"" />
  <xs:complexType name=""ENTITIES"">
    <xs:simpleContent>
      <xs:extension base=""xs:ENTITIES"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""decimal"" type=""tns:decimal"" />
  <xs:complexType name=""decimal"">
    <xs:simpleContent>
      <xs:extension base=""xs:decimal"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""integer"" type=""tns:integer"" />
  <xs:complexType name=""integer"">
    <xs:simpleContent>
      <xs:extension base=""xs:integer"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""nonPositiveInteger"" type=""tns:nonPositiveInteger"" />
  <xs:complexType name=""nonPositiveInteger"">
    <xs:simpleContent>
      <xs:extension base=""xs:nonPositiveInteger"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""negativeInteger"" type=""tns:negativeInteger"" />
  <xs:complexType name=""negativeInteger"">
    <xs:simpleContent>
      <xs:extension base=""xs:negativeInteger"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""long"" type=""tns:long"" />
  <xs:complexType name=""long"">
    <xs:simpleContent>
      <xs:extension base=""xs:long"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""int"" type=""tns:int"" />
  <xs:complexType name=""int"">
    <xs:simpleContent>
      <xs:extension base=""xs:int"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""short"" type=""tns:short"" />
  <xs:complexType name=""short"">
    <xs:simpleContent>
      <xs:extension base=""xs:short"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""byte"" type=""tns:byte"" />
  <xs:complexType name=""byte"">
    <xs:simpleContent>
      <xs:extension base=""xs:byte"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""nonNegativeInteger"" type=""tns:nonNegativeInteger"" />
  <xs:complexType name=""nonNegativeInteger"">
    <xs:simpleContent>
      <xs:extension base=""xs:nonNegativeInteger"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""unsignedLong"" type=""tns:unsignedLong"" />
  <xs:complexType name=""unsignedLong"">
    <xs:simpleContent>
      <xs:extension base=""xs:unsignedLong"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""unsignedInt"" type=""tns:unsignedInt"" />
  <xs:complexType name=""unsignedInt"">
    <xs:simpleContent>
      <xs:extension base=""xs:unsignedInt"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""unsignedShort"" type=""tns:unsignedShort"" />
  <xs:complexType name=""unsignedShort"">
    <xs:simpleContent>
      <xs:extension base=""xs:unsignedShort"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""unsignedByte"" type=""tns:unsignedByte"" />
  <xs:complexType name=""unsignedByte"">
    <xs:simpleContent>
      <xs:extension base=""xs:unsignedByte"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""positiveInteger"" type=""tns:positiveInteger"" />
  <xs:complexType name=""positiveInteger"">
    <xs:simpleContent>
      <xs:extension base=""xs:positiveInteger"">
        <xs:attributeGroup ref=""tns:commonAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""anyType"" type=""xs:anyType"" />
</xs:schema>";
        
        public ImageWebServiceService_schemas_xmlsoap_org_soap_encoding() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [47];
                _RootElements[0] = "Array";
                _RootElements[1] = "Struct";
                _RootElements[2] = "duration";
                _RootElements[3] = "dateTime";
                _RootElements[4] = "NOTATION";
                _RootElements[5] = "time";
                _RootElements[6] = "date";
                _RootElements[7] = "gYearMonth";
                _RootElements[8] = "gYear";
                _RootElements[9] = "gMonthDay";
                _RootElements[10] = "gDay";
                _RootElements[11] = "gMonth";
                _RootElements[12] = "boolean";
                _RootElements[13] = "base64Binary";
                _RootElements[14] = "hexBinary";
                _RootElements[15] = "float";
                _RootElements[16] = "double";
                _RootElements[17] = "anyURI";
                _RootElements[18] = "QName";
                _RootElements[19] = "string";
                _RootElements[20] = "normalizedString";
                _RootElements[21] = "token";
                _RootElements[22] = "language";
                _RootElements[23] = "Name";
                _RootElements[24] = "NMTOKEN";
                _RootElements[25] = "NCName";
                _RootElements[26] = "NMTOKENS";
                _RootElements[27] = "ID";
                _RootElements[28] = "IDREF";
                _RootElements[29] = "ENTITY";
                _RootElements[30] = "IDREFS";
                _RootElements[31] = "ENTITIES";
                _RootElements[32] = "decimal";
                _RootElements[33] = "integer";
                _RootElements[34] = "nonPositiveInteger";
                _RootElements[35] = "negativeInteger";
                _RootElements[36] = "long";
                _RootElements[37] = "int";
                _RootElements[38] = "short";
                _RootElements[39] = "byte";
                _RootElements[40] = "nonNegativeInteger";
                _RootElements[41] = "unsignedLong";
                _RootElements[42] = "unsignedInt";
                _RootElements[43] = "unsignedShort";
                _RootElements[44] = "unsignedByte";
                _RootElements[45] = "positiveInteger";
                _RootElements[46] = "anyType";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"Array")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Array"})]
        public sealed class Array : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Array() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Array";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"Struct")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Struct"})]
        public sealed class Struct : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Struct() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Struct";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"duration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"duration"})]
        public sealed class duration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public duration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "duration";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"dateTime")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"dateTime"})]
        public sealed class dateTime : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public dateTime() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "dateTime";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"NOTATION")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"NOTATION"})]
        public sealed class NOTATION : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public NOTATION() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "NOTATION";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"time")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"time"})]
        public sealed class time : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public time() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "time";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"date")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"date"})]
        public sealed class date : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public date() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "date";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"gYearMonth")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"gYearMonth"})]
        public sealed class gYearMonth : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public gYearMonth() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "gYearMonth";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"gYear")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"gYear"})]
        public sealed class gYear : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public gYear() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "gYear";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"gMonthDay")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"gMonthDay"})]
        public sealed class gMonthDay : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public gMonthDay() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "gMonthDay";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"gDay")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"gDay"})]
        public sealed class gDay : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public gDay() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "gDay";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"gMonth")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"gMonth"})]
        public sealed class gMonth : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public gMonth() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "gMonth";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"boolean")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"boolean"})]
        public sealed class boolean : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public boolean() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "boolean";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"base64Binary")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"base64Binary"})]
        public sealed class base64Binary : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public base64Binary() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "base64Binary";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"hexBinary")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"hexBinary"})]
        public sealed class hexBinary : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public hexBinary() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "hexBinary";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"float")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"float"})]
        public sealed class @float : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @float() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "float";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"double")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"double"})]
        public sealed class @double : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @double() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "double";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"anyURI")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"anyURI"})]
        public sealed class anyURI : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public anyURI() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "anyURI";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"QName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QName"})]
        public sealed class QName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QName";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"string"})]
        public sealed class @string : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @string() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "string";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"normalizedString")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"normalizedString"})]
        public sealed class normalizedString : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public normalizedString() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "normalizedString";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"token")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"token"})]
        public sealed class token : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public token() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "token";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"language")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"language"})]
        public sealed class language : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public language() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "language";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"Name")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Name"})]
        public sealed class Name : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Name() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Name";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"NMTOKEN")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"NMTOKEN"})]
        public sealed class NMTOKEN : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public NMTOKEN() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "NMTOKEN";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"NCName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"NCName"})]
        public sealed class NCName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public NCName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "NCName";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"NMTOKENS")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"NMTOKENS"})]
        public sealed class NMTOKENS : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public NMTOKENS() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "NMTOKENS";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"ID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ID"})]
        public sealed class ID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ID";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"IDREF")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IDREF"})]
        public sealed class IDREF : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IDREF() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IDREF";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"ENTITY")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ENTITY"})]
        public sealed class ENTITY : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ENTITY() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ENTITY";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"IDREFS")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IDREFS"})]
        public sealed class IDREFS : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IDREFS() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IDREFS";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"ENTITIES")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ENTITIES"})]
        public sealed class ENTITIES : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ENTITIES() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ENTITIES";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"decimal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"decimal"})]
        public sealed class @decimal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @decimal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "decimal";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"integer")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"integer"})]
        public sealed class integer : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public integer() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "integer";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"nonPositiveInteger")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"nonPositiveInteger"})]
        public sealed class nonPositiveInteger : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public nonPositiveInteger() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "nonPositiveInteger";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"negativeInteger")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"negativeInteger"})]
        public sealed class negativeInteger : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public negativeInteger() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "negativeInteger";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"long")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"long"})]
        public sealed class @long : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @long() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "long";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"int")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"int"})]
        public sealed class @int : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @int() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "int";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"short")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"short"})]
        public sealed class @short : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @short() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "short";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"byte")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"byte"})]
        public sealed class @byte : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @byte() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "byte";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"nonNegativeInteger")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"nonNegativeInteger"})]
        public sealed class nonNegativeInteger : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public nonNegativeInteger() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "nonNegativeInteger";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"unsignedLong")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"unsignedLong"})]
        public sealed class unsignedLong : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public unsignedLong() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "unsignedLong";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"unsignedInt")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"unsignedInt"})]
        public sealed class unsignedInt : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public unsignedInt() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "unsignedInt";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"unsignedShort")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"unsignedShort"})]
        public sealed class unsignedShort : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public unsignedShort() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "unsignedShort";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"unsignedByte")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"unsignedByte"})]
        public sealed class unsignedByte : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public unsignedByte() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "unsignedByte";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"positiveInteger")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"positiveInteger"})]
        public sealed class positiveInteger : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public positiveInteger() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "positiveInteger";
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
        
        [Schema(@"http://schemas.xmlsoap.org/soap/encoding/",@"anyType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"anyType"})]
        public sealed class anyType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public anyType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "anyType";
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
}
