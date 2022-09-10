using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class FileDelRestric
{
	private int codeField;

	private string infoField;

	[XmlAttribute]
	public int Code
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

	[XmlAttribute]
	public string Info
	{
		get
		{
			return infoField;
		}
		set
		{
			infoField = value;
		}
	}
}
