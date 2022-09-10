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
public class PropGrp
{
	private PropDef[] propDefArrayField;

	private long idField;

	private string dispNameField;

	private string sysNameField;

	private bool isActField;

	public PropDef[] PropDefArray
	{
		get
		{
			return propDefArrayField;
		}
		set
		{
			propDefArrayField = value;
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
	public string DispName
	{
		get
		{
			return dispNameField;
		}
		set
		{
			dispNameField = value;
		}
	}

	[XmlAttribute]
	public string SysName
	{
		get
		{
			return sysNameField;
		}
		set
		{
			sysNameField = value;
		}
	}

	[XmlAttribute]
	public bool IsAct
	{
		get
		{
			return isActField;
		}
		set
		{
			isActField = value;
		}
	}
}
