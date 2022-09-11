using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

[Serializable]
[XmlType(AnonymousType = true)]
[GeneratedCode("xsd", "4.6.1055.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcase
{
	private testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseProperties propertiesField;

	private testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseReason reasonField;

	private testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseFailure failureField;

	private string outputField;

	private string idField;

	private string nameField;

	private string fullnameField;

	private string methodnameField;

	private string classnameField;

	private string runstateField;

	private uint seedField;

	private string resultField;

	private string starttimeField;

	private string endtimeField;

	private decimal durationField;

	private byte assertsField;

	private string labelField;

	public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseProperties properties
	{
		get
		{
			return propertiesField;
		}
		set
		{
			propertiesField = value;
		}
	}

	public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseReason reason
	{
		get
		{
			return reasonField;
		}
		set
		{
			reasonField = value;
		}
	}

	public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseFailure failure
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

	public string output
	{
		get
		{
			return outputField;
		}
		set
		{
			outputField = value;
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
	public string methodname
	{
		get
		{
			return methodnameField;
		}
		set
		{
			methodnameField = value;
		}
	}

	[XmlAttribute]
	public string classname
	{
		get
		{
			return classnameField;
		}
		set
		{
			classnameField = value;
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
	public uint seed
	{
		get
		{
			return seedField;
		}
		set
		{
			seedField = value;
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

	[XmlAttribute]
	public string label
	{
		get
		{
			return labelField;
		}
		set
		{
			labelField = value;
		}
	}
}
