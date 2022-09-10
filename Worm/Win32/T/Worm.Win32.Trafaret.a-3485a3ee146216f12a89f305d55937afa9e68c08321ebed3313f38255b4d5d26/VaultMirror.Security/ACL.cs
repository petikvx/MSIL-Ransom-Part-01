using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Security;

[Serializable]
[XmlType(Namespace = "http://AutodeskDM/Services/Security/01/02/2007/")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
public class ACL
{
	private ACE[] aCEArrayField;

	private long idField;

	public ACE[] ACEArray
	{
		get
		{
			return aCEArrayField;
		}
		set
		{
			aCEArrayField = value;
		}
	}

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
}
