using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
public enum PropertyTypeEnum
{
	Number,
	Date,
	Boolean,
	Text
}
