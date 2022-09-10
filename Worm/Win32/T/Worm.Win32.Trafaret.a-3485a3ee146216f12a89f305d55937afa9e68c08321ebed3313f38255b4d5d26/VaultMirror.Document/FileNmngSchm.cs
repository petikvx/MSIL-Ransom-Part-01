using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
public class FileNmngSchm
{
	private long idField;

	private string nameField;

	private string descrField;

	private string prefixField;

	private string suffixField;

	private long startNumField;

	private int fieldLenField;

	private bool isDfltField;

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
	public string Name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
		}
	}

	[XmlAttribute]
	public string Descr
	{
		get
		{
			return descrField;
		}
		set
		{
			descrField = value;
		}
	}

	[XmlAttribute]
	public string Prefix
	{
		get
		{
			return prefixField;
		}
		set
		{
			prefixField = value;
		}
	}

	[XmlAttribute]
	public string Suffix
	{
		get
		{
			return suffixField;
		}
		set
		{
			suffixField = value;
		}
	}

	[XmlAttribute]
	public long StartNum
	{
		get
		{
			return startNumField;
		}
		set
		{
			startNumField = value;
		}
	}

	[XmlAttribute]
	public int FieldLen
	{
		get
		{
			return fieldLenField;
		}
		set
		{
			fieldLenField = value;
		}
	}

	[XmlAttribute]
	public bool IsDflt
	{
		get
		{
			return isDfltField;
		}
		set
		{
			isDfltField = value;
		}
	}
}
