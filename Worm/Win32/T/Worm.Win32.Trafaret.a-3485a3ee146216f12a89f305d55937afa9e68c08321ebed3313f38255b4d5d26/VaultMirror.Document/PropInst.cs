using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class PropInst
{
	private object valField;

	private long entityIdField;

	private long propDefIdField;

	private string valTypField;

	public object Val
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

	[XmlAttribute]
	public long EntityId
	{
		get
		{
			return entityIdField;
		}
		set
		{
			entityIdField = value;
		}
	}

	[XmlAttribute]
	public long PropDefId
	{
		get
		{
			return propDefIdField;
		}
		set
		{
			propDefIdField = value;
		}
	}

	[XmlAttribute]
	public string ValTyp
	{
		get
		{
			return valTypField;
		}
		set
		{
			valTypField = value;
		}
	}
}
