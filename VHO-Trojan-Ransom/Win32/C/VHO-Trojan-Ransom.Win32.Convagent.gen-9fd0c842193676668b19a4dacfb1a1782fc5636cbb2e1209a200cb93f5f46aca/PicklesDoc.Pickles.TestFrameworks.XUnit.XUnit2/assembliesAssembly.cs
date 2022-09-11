using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit2;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.6.1055.0")]
[XmlType(AnonymousType = true)]
public class assembliesAssembly
{
	private object errorsField;

	private assembliesAssemblyCollection[] collectionField;

	private string nameField;

	private string environmentField;

	private string testframeworkField;

	private DateTime rundateField;

	private DateTime runtimeField;

	private string configfileField;

	private int totalField;

	private int passedField;

	private int failedField;

	private int skippedField;

	private decimal timeField;

	private int errors1Field;

	public object errors
	{
		get
		{
			return errorsField;
		}
		set
		{
			errorsField = value;
		}
	}

	[XmlElement("collection")]
	public assembliesAssemblyCollection[] collection
	{
		get
		{
			return collectionField;
		}
		set
		{
			collectionField = value;
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
	public string environment
	{
		get
		{
			return environmentField;
		}
		set
		{
			environmentField = value;
		}
	}

	[XmlAttribute("test-framework")]
	public string testframework
	{
		get
		{
			return testframeworkField;
		}
		set
		{
			testframeworkField = value;
		}
	}

	[XmlAttribute("run-date", DataType = "date")]
	public DateTime rundate
	{
		get
		{
			return rundateField;
		}
		set
		{
			rundateField = value;
		}
	}

	[XmlAttribute("run-time", DataType = "time")]
	public DateTime runtime
	{
		get
		{
			return runtimeField;
		}
		set
		{
			runtimeField = value;
		}
	}

	[XmlAttribute("config-file")]
	public string configfile
	{
		get
		{
			return configfileField;
		}
		set
		{
			configfileField = value;
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

	[XmlAttribute("errors")]
	public int errors1
	{
		get
		{
			return errors1Field;
		}
		set
		{
			errors1Field = value;
		}
	}
}
