using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
public class PropDef
{
	private object dfltValField;

	private object[] valArrayField;

	private long idField;

	private string setIdField;

	private string propIdField;

	private string typField;

	private string dispNameField;

	private string sysNameField;

	private bool isActField;

	private string monikerField;

	private PropDefSrc srcField;

	private int usageCountField;

	public object DfltVal
	{
		get
		{
			return dfltValField;
		}
		set
		{
			dfltValField = value;
		}
	}

	[XmlArrayItem("Val")]
	public object[] ValArray
	{
		get
		{
			return valArrayField;
		}
		set
		{
			valArrayField = value;
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
	public string SetId
	{
		get
		{
			return setIdField;
		}
		set
		{
			setIdField = value;
		}
	}

	[XmlAttribute]
	public string PropId
	{
		get
		{
			return propIdField;
		}
		set
		{
			propIdField = value;
		}
	}

	[XmlAttribute]
	public string Typ
	{
		get
		{
			return typField;
		}
		set
		{
			typField = value;
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

	[XmlAttribute]
	public string Moniker
	{
		get
		{
			return monikerField;
		}
		set
		{
			monikerField = value;
		}
	}

	[XmlAttribute]
	public PropDefSrc Src
	{
		get
		{
			return srcField;
		}
		set
		{
			srcField = value;
		}
	}

	[XmlAttribute]
	public int UsageCount
	{
		get
		{
			return usageCountField;
		}
		set
		{
			usageCountField = value;
		}
	}
}
