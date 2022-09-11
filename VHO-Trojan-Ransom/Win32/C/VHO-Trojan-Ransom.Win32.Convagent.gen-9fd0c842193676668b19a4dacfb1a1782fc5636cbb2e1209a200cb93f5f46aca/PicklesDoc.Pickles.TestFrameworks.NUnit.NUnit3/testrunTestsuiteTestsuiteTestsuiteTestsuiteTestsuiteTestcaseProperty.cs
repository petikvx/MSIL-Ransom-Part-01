using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

[Serializable]
[GeneratedCode("xsd", "4.6.1055.0")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlType(AnonymousType = true)]
public class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseProperty
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
