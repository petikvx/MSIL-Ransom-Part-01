using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Security;

[Serializable]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://AutodeskDM/Services/Security/01/02/2007/")]
public class AccessPermisAndGrp
{
	private AccessPermisDef[] defArrayField;

	private AccessPermisGrp[] grpArrayField;

	[XmlArrayItem("Def")]
	public AccessPermisDef[] DefArray
	{
		get
		{
			return defArrayField;
		}
		set
		{
			defArrayField = value;
		}
	}

	[XmlArrayItem("Desc")]
	public AccessPermisGrp[] GrpArray
	{
		get
		{
			return grpArrayField;
		}
		set
		{
			grpArrayField = value;
		}
	}
}
