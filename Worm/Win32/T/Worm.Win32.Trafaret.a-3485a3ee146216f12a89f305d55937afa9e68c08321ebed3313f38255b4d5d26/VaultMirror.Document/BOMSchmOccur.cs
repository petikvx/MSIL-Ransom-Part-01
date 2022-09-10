using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
public class BOMSchmOccur
{
	private long idField;

	private int schmIdField;

	private long parOccurIdField;

	private long compIdField;

	private int orderField;

	private string dtlIdField;

	private int depthField;

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
	public int SchmId
	{
		get
		{
			return schmIdField;
		}
		set
		{
			schmIdField = value;
		}
	}

	[XmlAttribute]
	public long ParOccurId
	{
		get
		{
			return parOccurIdField;
		}
		set
		{
			parOccurIdField = value;
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
	public int Order
	{
		get
		{
			return orderField;
		}
		set
		{
			orderField = value;
		}
	}

	[XmlAttribute]
	public string DtlId
	{
		get
		{
			return dtlIdField;
		}
		set
		{
			dtlIdField = value;
		}
	}

	[XmlAttribute]
	public int Depth
	{
		get
		{
			return depthField;
		}
		set
		{
			depthField = value;
		}
	}
}
