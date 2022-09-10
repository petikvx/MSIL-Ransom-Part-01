using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Security;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[XmlType(Namespace = "http://AutodeskDM/Services/Security/01/02/2007/")]
public class SecRestric
{
	private object[] paramArrayField;

	private SecRestricCode codeField;

	[XmlElement("ParamArray")]
	public object[] ParamArray
	{
		get
		{
			return paramArrayField;
		}
		set
		{
			paramArrayField = value;
		}
	}

	[XmlAttribute]
	public SecRestricCode Code
	{
		get
		{
			return codeField;
		}
		set
		{
			codeField = value;
		}
	}
}
