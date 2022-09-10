using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Security;

[Serializable]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://AutodeskDM/Services/Security/01/02/2007/")]
[DesignerCategory("code")]
public class AccessPermisGrp
{
	private AccessPermis[] permisArrayField;

	private long idField;

	private string nameField;

	private string descrField;

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
	public string Descr
	{
		get
		{
			return descrField;
		}
		set
		{
			descrField = value;
		}
	}
}
