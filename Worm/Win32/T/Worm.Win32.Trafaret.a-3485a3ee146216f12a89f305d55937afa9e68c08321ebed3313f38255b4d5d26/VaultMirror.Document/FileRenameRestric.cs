using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DesignerCategory("code")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DebuggerStepThrough]
public class FileRenameRestric
{
	private int codeField;

	private long fileIdField;

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
	public long FileId
	{
		get
		{
			return fileIdField;
		}
		set
		{
			fileIdField = value;
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
