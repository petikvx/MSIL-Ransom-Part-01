using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
public class DocRestric
{
	private object[] paramsField;

	private DocRestricCode codeField;

	[XmlElement("Params")]
	public object[] Params
	{
		get
		{
			return paramsField;
		}
		set
		{
			paramsField = value;
		}
	}

	[XmlAttribute]
	public DocRestricCode Code
	{
		get
		{
			return codeField;
		}
		set
		{
			codeField = value;
		}
	}
}
