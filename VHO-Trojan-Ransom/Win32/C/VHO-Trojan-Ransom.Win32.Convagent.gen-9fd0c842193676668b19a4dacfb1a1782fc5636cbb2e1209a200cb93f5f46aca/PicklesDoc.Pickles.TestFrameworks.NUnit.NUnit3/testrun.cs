using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.6.1055.0")]
[DebuggerStepThrough]
[XmlType(AnonymousType = true)]
[XmlRoot("test-run", Namespace = "", IsNullable = false)]
public class testrun
{
	private string commandlineField;

	private testrunTestsuite testsuiteField;

	private byte idField;

	private byte testcasecountField;

	private string resultField;

	private byte totalField;

	private byte passedField;

	private byte failedField;

	private byte inconclusiveField;

	private byte skippedField;

	private byte assertsField;

	private string engineversionField;

	private string clrversionField;

	private string starttimeField;

	private string endtimeField;

	private decimal durationField;

	[XmlElement("command-line")]
	public string commandline
	{
		get
		{
			return commandlineField;
		}
		set
		{
			commandlineField = value;
		}
	}

	[XmlElement("test-suite")]
	public testrunTestsuite testsuite
	{
		get
		{
			return testsuiteField;
		}
		set
		{
			testsuiteField = value;
		}
	}

	[XmlAttribute]
	public byte id
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
	public byte testcasecount
	{
		get
		{
			return testcasecountField;
		}
		set
		{
			testcasecountField = value;
		}
	}

	[XmlAttribute]
	public string result
	{
		get
		{
			return resultField;
		}
		set
		{
			resultField = value;
		}
	}

	[XmlAttribute]
	public byte total
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
	public byte passed
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
	public byte failed
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
	public byte inconclusive
	{
		get
		{
			return inconclusiveField;
		}
		set
		{
			inconclusiveField = value;
		}
	}

	[XmlAttribute]
	public byte skipped
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
	public byte asserts
	{
		get
		{
			return assertsField;
		}
		set
		{
			assertsField = value;
		}
	}

	[XmlAttribute("engine-version")]
	public string engineversion
	{
		get
		{
			return engineversionField;
		}
		set
		{
			engineversionField = value;
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

	[XmlAttribute("start-time")]
	public string starttime
	{
		get
		{
			return starttimeField;
		}
		set
		{
			starttimeField = value;
		}
	}

	[XmlAttribute("end-time")]
	public string endtime
	{
		get
		{
			return endtimeField;
		}
		set
		{
			endtimeField = value;
		}
	}

	[XmlAttribute]
	public decimal duration
	{
		get
		{
			return durationField;
		}
		set
		{
			durationField = value;
		}
	}
}
