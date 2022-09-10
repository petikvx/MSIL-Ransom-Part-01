using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DesignerCategory("code")]
public class BOMRefDesig
{
	private long idField;

	private string tagField;

	private string locField;

	private string instField;

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
	public string Tag
	{
		get
		{
			return tagField;
		}
		set
		{
			tagField = value;
		}
	}

	[XmlAttribute]
	public string Loc
	{
		get
		{
			return locField;
		}
		set
		{
			locField = value;
		}
	}

	[XmlAttribute]
	public string Inst
	{
		get
		{
			return instField;
		}
		set
		{
			instField = value;
		}
	}
}
