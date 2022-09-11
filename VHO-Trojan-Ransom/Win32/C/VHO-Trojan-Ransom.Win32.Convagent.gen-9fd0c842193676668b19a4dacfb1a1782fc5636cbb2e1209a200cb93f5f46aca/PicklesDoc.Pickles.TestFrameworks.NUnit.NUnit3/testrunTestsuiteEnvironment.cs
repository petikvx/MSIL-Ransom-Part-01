using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[DebuggerStepThrough]
[GeneratedCode("xsd", "4.6.1055.0")]
public class testrunTestsuiteEnvironment
{
	private string frameworkversionField;

	private string clrversionField;

	private string osversionField;

	private string platformField;

	private string cwdField;

	private string machinenameField;

	private string userField;

	private string userdomainField;

	private string cultureField;

	private string uicultureField;

	private string osarchitectureField;

	[XmlAttribute("framework-version")]
	public string frameworkversion
	{
		get
		{
			return frameworkversionField;
		}
		set
		{
			frameworkversionField = value;
		}
	}

	[XmlAttribute("clr-version")]
	public string clrversion
	{
		get
		{
			return clrversionField;
		}
		set
		{
			clrversionField = value;
		}
	}

	[XmlAttribute("os-version")]
	public string osversion
	{
		get
		{
			return osversionField;
		}
		set
		{
			osversionField = value;
		}
	}

	[XmlAttribute]
	public string platform
	{
		get
		{
			return platformField;
		}
		set
		{
			platformField = value;
		}
	}

	[XmlAttribute]
	public string cwd
	{
		get
		{
			return cwdField;
		}
		set
		{
			cwdField = value;
		}
	}

	[XmlAttribute("machine-name")]
	public string machinename
	{
		get
		{
			return machinenameField;
		}
		set
		{
			machinenameField = value;
		}
	}

	[XmlAttribute]
	public string user
	{
		get
		{
			return userField;
		}
		set
		{
			userField = value;
		}
	}

	[XmlAttribute("user-domain")]
	public string userdomain
	{
		get
		{
			return userdomainField;
		}
		set
		{
			userdomainField = value;
		}
	}

	[XmlAttribute]
	public string culture
	{
		get
		{
			return cultureField;
		}
		set
		{
			cultureField = value;
		}
	}

	[XmlAttribute]
	public string uiculture
	{
		get
		{
			return uicultureField;
		}
		set
		{
			uicultureField = value;
		}
	}

	[XmlAttribute("os-architecture")]
	public string osarchitecture
	{
		get
		{
			return osarchitectureField;
		}
		set
		{
			osarchitectureField = value;
		}
	}
}
