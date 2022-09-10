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
public class BOMComp
{
	private long idField;

	private string uniqueIdField;

	private XRefTypeEnum xRefTypField;

	private long xRefIdField;

	private string nameField;

	private ComponentTypeEnum compTypField;

	private string baseUOMField;

	private double baseQtyField;

	private BOMStructureEnum bOMStructField;

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
	public string UniqueId
	{
		get
		{
			return uniqueIdField;
		}
		set
		{
			uniqueIdField = value;
		}
	}

	[XmlAttribute]
	public XRefTypeEnum XRefTyp
	{
		get
		{
			return xRefTypField;
		}
		set
		{
			xRefTypField = value;
		}
	}

	[XmlAttribute]
	public long XRefId
	{
		get
		{
			return xRefIdField;
		}
		set
		{
			xRefIdField = value;
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
	public ComponentTypeEnum CompTyp
	{
		get
		{
			return compTypField;
		}
		set
		{
			compTypField = value;
		}
	}

	[XmlAttribute]
	public string BaseUOM
	{
		get
		{
			return baseUOMField;
		}
		set
		{
			baseUOMField = value;
		}
	}

	[XmlAttribute]
	public double BaseQty
	{
		get
		{
			return baseQtyField;
		}
		set
		{
			baseQtyField = value;
		}
	}

	[XmlAttribute]
	public BOMStructureEnum BOMStruct
	{
		get
		{
			return bOMStructField;
		}
		set
		{
			bOMStructField = value;
		}
	}
}
