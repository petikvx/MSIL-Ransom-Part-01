using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit2;

[Serializable]
[XmlType(AnonymousType = true)]
[GeneratedCode("xsd", "4.6.1055.0")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class assembliesAssemblyCollectionTestTrait
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
