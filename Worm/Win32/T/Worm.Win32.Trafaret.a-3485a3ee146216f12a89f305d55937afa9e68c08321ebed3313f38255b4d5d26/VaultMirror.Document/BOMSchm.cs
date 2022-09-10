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
public class BOMSchm
{
	private long idField;

	private SchemeTypeEnum schmTypField;

	private long rootCompIdField;

	private bool insepAsPrtField;

	private bool insepPrmtsPrchField;

	private bool prchAsPrtField;

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
	public SchemeTypeEnum SchmTyp
	{
		get
		{
			return schmTypField;
		}
		set
		{
			schmTypField = value;
		}
	}

	[XmlAttribute]
	public long RootCompId
	{
		get
		{
			return rootCompIdField;
		}
		set
		{
			rootCompIdField = value;
		}
	}

	[XmlAttribute]
	public bool InsepAsPrt
	{
		get
		{
			return insepAsPrtField;
		}
		set
		{
			insepAsPrtField = value;
		}
	}

	[XmlAttribute]
	public bool InsepPrmtsPrch
	{
		get
		{
			return insepPrmtsPrchField;
		}
		set
		{
			insepPrmtsPrchField = value;
		}
	}

	[XmlAttribute]
	public bool PrchAsPrt
	{
		get
		{
			return prchAsPrtField;
		}
		set
		{
			prchAsPrtField = value;
		}
	}
}
