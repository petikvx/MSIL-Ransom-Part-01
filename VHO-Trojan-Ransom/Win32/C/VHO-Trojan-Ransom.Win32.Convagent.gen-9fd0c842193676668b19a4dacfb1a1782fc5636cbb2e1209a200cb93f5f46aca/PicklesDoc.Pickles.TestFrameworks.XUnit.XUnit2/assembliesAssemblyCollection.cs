using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit2;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.6.1055.0")]
[DebuggerStepThrough]
[XmlType(AnonymousType = true)]
public class assembliesAssemblyCollection
{
	private assembliesAssemblyCollectionTest[] testField;

	private int totalField;

	private int passedField;

	private int failedField;

	private int skippedField;

	private string nameField;

	private decimal timeField;

	[XmlElement("test")]
	public assembliesAssemblyCollectionTest[] test
	{
		get
		{
			return testField;
		}
		set
		{
			testField = value;
		}
	}

	[XmlAttribute]
	public int total
	{
		get
		{
			return totalField;
		}
		set
		{
			totalField = value;
		}
	}

	[XmlAttribute]
	public int passed
	{
		get
		{
			return passedField;
		}
		set
		{
			passedField = value;
		}
	}

	[XmlAttribute]
	public int failed
	{
		get
		{
			return failedField;
		}
		set
		{
			failedField = value;
		}
	}

	[XmlAttribute]
	public int skipped
	{
		get
		{
			return skippedField;
		}
		set
		{
			skippedField = value;
		}
	}

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
	public decimal time
	{
		get
		{
			return timeField;
		}
		set
		{
			timeField = value;
		}
	}
}
