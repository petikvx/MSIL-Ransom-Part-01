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
public class SrchCond
{
	private long propDefIdField;

	private string propSetIdField;

	private string propIdField;

	private string valTypField;

	private long srchOperField;

	private string srchTxtField;

	private PropertySearchType propTypField;

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
	public string PropSetId
	{
		get
		{
			return propSetIdField;
		}
		set
		{
			propSetIdField = value;
		}
	}

	[XmlAttribute]
	public string PropId
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

	[XmlAttribute]
	public long SrchOper
	{
		get
		{
			return srchOperField;
		}
		set
		{
			srchOperField = value;
		}
	}

	[XmlAttribute]
	public string SrchTxt
	{
		get
		{
			return srchTxtField;
		}
		set
		{
			srchTxtField = value;
		}
	}

	[XmlAttribute]
	public PropertySearchType PropTyp
	{
		get
		{
			return propTypField;
		}
		set
		{
			propTypField = value;
		}
	}
}
