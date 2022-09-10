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
public class BOMInst
{
	private long idField;

	private long parIdField;

	private long cldIdField;

	private BOMStructureOverrideEnum bOMStructOverdeField;

	private int quantField;

	private double quantOverdeField;

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
	public long ParId
	{
		get
		{
			return parIdField;
		}
		set
		{
			parIdField = value;
		}
	}

	[XmlAttribute]
	public long CldId
	{
		get
		{
			return cldIdField;
		}
		set
		{
			cldIdField = value;
		}
	}

	[XmlAttribute]
	public BOMStructureOverrideEnum BOMStructOverde
	{
		get
		{
			return bOMStructOverdeField;
		}
		set
		{
			bOMStructOverdeField = value;
		}
	}

	[XmlAttribute]
	public int Quant
	{
		get
		{
			return quantField;
		}
		set
		{
			quantField = value;
		}
	}

	[XmlAttribute]
	public double QuantOverde
	{
		get
		{
			return quantOverdeField;
		}
		set
		{
			quantOverdeField = value;
		}
	}
}
