using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DesignerCategory("code")]
public class FileAssoc
{
	private File parFileField;

	private File cldFileField;

	private long idField;

	private AssociationType typField;

	private string sourceField;

	public File ParFile
	{
		get
		{
			return parFileField;
		}
		set
		{
			parFileField = value;
		}
	}

	public File CldFile
	{
		get
		{
			return cldFileField;
		}
		set
		{
			cldFileField = value;
		}
	}

	[XmlAttribute]
	public long Id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}

	[XmlAttribute]
	public AssociationType Typ
	{
		get
		{
			return typField;
		}
		set
		{
			typField = value;
		}
	}

	[XmlAttribute]
	public string Source
	{
		get
		{
			return sourceField;
		}
		set
		{
			sourceField = value;
		}
	}
}
