using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

[Serializable]
[DebuggerStepThrough]
[XmlType(AnonymousType = true)]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.6.1055.0")]
public class testrunTestsuiteTestsuiteTestsuite
{
	private testrunTestsuiteTestsuiteTestsuiteFailure failureField;

	private testrunTestsuiteTestsuiteTestsuiteTestsuite testsuiteField;

	private string typeField;

	private string idField;

	private string nameField;

	private string fullnameField;

	private string runstateField;

	private byte testcasecountField;

	private string resultField;

	private string siteField;

	private string starttimeField;

	private string endtimeField;

	private decimal durationField;

	private byte totalField;

	private byte passedField;

	private byte failedField;

	private byte inconclusiveField;

	private byte skippedField;

	private byte assertsField;

	public testrunTestsuiteTestsuiteTestsuiteFailure failure
	{
		get
		{
			return failureField;
		}
		set
		{
			failureField = value;
		}
	}

	[XmlElement("test-suite")]
	public testrunTestsuiteTestsuiteTestsuiteTestsuite testsuite
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
	public string type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
		}
	}

	[XmlAttribute]
	public string id
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
	public string fullname
	{
		get
		{
			return fullnameField;
		}
		set
		{
			fullnameField = value;
		}
	}

	[XmlAttribute]
	public string runstate
	{
		get
		{
			return runstateField;
		}
		set
		{
			runstateField = value;
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
	public string site
	{
		get
		{
			return siteField;
		}
		set
		{
			siteField = value;
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
}
