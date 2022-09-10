using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
public class FileDelStatus
{
	private File fileField;

	private int codeField;

	public File File
	{
		get
		{
			return fileField;
		}
		set
		{
			fileField = value;
		}
	}

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
}
