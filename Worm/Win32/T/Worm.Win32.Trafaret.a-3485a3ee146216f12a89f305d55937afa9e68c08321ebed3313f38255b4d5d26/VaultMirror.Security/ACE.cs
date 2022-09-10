using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Security;

[Serializable]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[XmlType(Namespace = "http://AutodeskDM/Services/Security/01/02/2007/")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class ACE
{
	private AccessPermis[] permisArrayField;

	private long userGrpIdField;

	[XmlArrayItem("Permis")]
	public AccessPermis[] PermisArray
	{
		get
		{
			return permisArrayField;
		}
		set
		{
			permisArrayField = value;
		}
	}

	[XmlAttribute]
	public long UserGrpId
	{
		get
		{
			return userGrpIdField;
		}
		set
		{
			userGrpIdField = value;
		}
	}
}
