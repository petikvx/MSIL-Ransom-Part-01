using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "2.0.50727.42")]
public class FileAssocRestric
{
	private int codeField;

	private long fileIdField;

	private string fileNameField;

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
	public string FileName
	{
		get
		{
			return fileNameField;
		}
		set
		{
			fileNameField = value;
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
