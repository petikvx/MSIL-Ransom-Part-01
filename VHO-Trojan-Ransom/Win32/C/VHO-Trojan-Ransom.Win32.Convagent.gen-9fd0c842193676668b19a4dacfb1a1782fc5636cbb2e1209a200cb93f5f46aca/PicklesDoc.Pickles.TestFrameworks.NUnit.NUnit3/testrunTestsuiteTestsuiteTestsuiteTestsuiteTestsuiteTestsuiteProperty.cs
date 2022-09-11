using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("xsd", "4.6.1055.0")]
[XmlType(AnonymousType = true)]
[DesignerCategory("code")]
public class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteProperty
{
	private string nameField;

	private string valueField;

	[XmlAttribute]
	public string name
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
	public string value
	{
		get
		{
			return valueField;
		}
		set
		{
			valueField = value;
		}
	}
}
