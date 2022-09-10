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
public class BOMRefDesigAttr
{
	private long idField;

	private long refIdField;

	private long propIdField;

	private string valField;

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
	public long RefId
	{
		get
		{
			return refIdField;
		}
		set
		{
			refIdField = value;
		}
	}

	[XmlAttribute]
	public long PropId
	{
		get
		{
			return propIdField;
		}
		set
		{
			propIdField = value;
		}
	}

	[XmlAttribute]
	public string Val
	{
		get
		{
			return valField;
		}
		set
		{
			valField = value;
		}
	}
}
