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
public class CompPropInfo
{
	private CompIdent[] compIdentArrayField;

	private BOMProp[] propArrayField;

	private BOMCompAttr[] attrArrayField;

	[XmlArrayItem("CompIdentity")]
	public CompIdent[] CompIdentArray
	{
		get
		{
			return compIdentArrayField;
		}
		set
		{
			compIdentArrayField = value;
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

	[XmlArrayItem("Attr")]
	public BOMCompAttr[] AttrArray
	{
		get
		{
			return attrArrayField;
		}
		set
		{
			attrArrayField = value;
		}
	}
}
