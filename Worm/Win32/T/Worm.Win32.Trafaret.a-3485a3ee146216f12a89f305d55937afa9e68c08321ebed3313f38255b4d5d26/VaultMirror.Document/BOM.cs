using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
public class BOM
{
	private BOMComp[] compArrayField;

	private BOMInst[] instArrayField;

	private BOMProp[] propArrayField;

	private BOMCompAttr[] compAttrArrayField;

	private BOMSchm[] schmArrayField;

	private BOMSchmOccur[] schmOccArrayField;

	private BOMRefDesig[] refDsgArrayField;

	private BOMRefDesigAttr[] refDsgAttrArrayField;

	private BOMCompRefDesig[] compRefDsgArrayField;

	[XmlArrayItem("Comp")]
	public BOMComp[] CompArray
	{
		get
		{
			return compArrayField;
		}
		set
		{
			compArrayField = value;
		}
	}

	[XmlArrayItem("Inst")]
	public BOMInst[] InstArray
	{
		get
		{
			return instArrayField;
		}
		set
		{
			instArrayField = value;
		}
	}

	[XmlArrayItem("Prop")]
	public BOMProp[] PropArray
	{
		get
		{
			return propArrayField;
		}
		set
		{
			propArrayField = value;
		}
	}

	[XmlArrayItem("CompAttr")]
	public BOMCompAttr[] CompAttrArray
	{
		get
		{
			return compAttrArrayField;
		}
		set
		{
			compAttrArrayField = value;
		}
	}

	[XmlArrayItem("Schm")]
	public BOMSchm[] SchmArray
	{
		get
		{
			return schmArrayField;
		}
		set
		{
			schmArrayField = value;
		}
	}

	[XmlArrayItem("SchmOcc")]
	public BOMSchmOccur[] SchmOccArray
	{
		get
		{
			return schmOccArrayField;
		}
		set
		{
			schmOccArrayField = value;
		}
	}

	[XmlArrayItem("RefDsg")]
	public BOMRefDesig[] RefDsgArray
	{
		get
		{
			return refDsgArrayField;
		}
		set
		{
			refDsgArrayField = value;
		}
	}

	[XmlArrayItem("RefDsgAttr")]
	public BOMRefDesigAttr[] RefDsgAttrArray
	{
		get
		{
			return refDsgAttrArrayField;
		}
		set
		{
			refDsgAttrArrayField = value;
		}
	}

	[XmlArrayItem("CompRefDsg")]
	public BOMCompRefDesig[] CompRefDsgArray
	{
		get
		{
			return compRefDsgArrayField;
		}
		set
		{
			compRefDsgArrayField = value;
		}
	}
}
