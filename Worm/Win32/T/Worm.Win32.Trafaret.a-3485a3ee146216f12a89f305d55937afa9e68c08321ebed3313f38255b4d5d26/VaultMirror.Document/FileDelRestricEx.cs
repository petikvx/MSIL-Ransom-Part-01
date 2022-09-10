using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
public class FileDelRestricEx
{
	private int codeField;

	private long masterIdField;

	private long fileIdField;

	private int verNumField;

	private string paramField;

	private string param2Field;

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
	public long MasterId
	{
		get
		{
			return masterIdField;
		}
		set
		{
			masterIdField = value;
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
	public int VerNum
	{
		get
		{
			return verNumField;
		}
		set
		{
			verNumField = value;
		}
	}

	[XmlAttribute]
	public string Param
	{
		get
		{
			return paramField;
		}
		set
		{
			paramField = value;
		}
	}

	[XmlAttribute]
	public string Param2
	{
		get
		{
			return param2Field;
		}
		set
		{
			param2Field = value;
		}
	}
}
