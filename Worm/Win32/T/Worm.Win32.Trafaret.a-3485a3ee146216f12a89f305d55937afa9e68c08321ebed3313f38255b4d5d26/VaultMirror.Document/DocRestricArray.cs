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
public class DocRestricArray
{
	private DocRestric[] restrictionsField;

	public DocRestric[] Restrictions
	{
		get
		{
			return restrictionsField;
		}
		set
		{
			restrictionsField = value;
		}
	}
}
