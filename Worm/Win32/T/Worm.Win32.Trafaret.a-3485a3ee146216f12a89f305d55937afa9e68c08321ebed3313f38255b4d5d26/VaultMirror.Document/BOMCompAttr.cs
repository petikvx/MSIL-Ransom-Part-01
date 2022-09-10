using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DesignerCategory("code")]
public class BOMCompAttr
{
	private long idField;

	private long compIdField;

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
	public long CompId
	{
		get
		{
			return compIdField;
		}
		set
		{
			compIdField = value;
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
