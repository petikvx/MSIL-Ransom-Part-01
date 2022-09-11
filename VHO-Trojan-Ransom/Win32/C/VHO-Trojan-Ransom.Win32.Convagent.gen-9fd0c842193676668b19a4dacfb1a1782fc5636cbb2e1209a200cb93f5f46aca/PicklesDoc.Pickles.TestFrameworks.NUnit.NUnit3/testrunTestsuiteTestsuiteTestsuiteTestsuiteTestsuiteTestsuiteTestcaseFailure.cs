using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

[Serializable]
[GeneratedCode("xsd", "4.6.1055.0")]
[DebuggerStepThrough]
[XmlType(AnonymousType = true)]
[DesignerCategory("code")]
public class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseFailure
{
	private string messageField;

	private string stacktraceField;

	public string message
	{
		get
		{
			return messageField;
		}
		set
		{
			messageField = value;
		}
	}

	[XmlElement("stack-trace")]
	public string stacktrace
	{
		get
		{
			return stacktraceField;
		}
		set
		{
			stacktraceField = value;
		}
	}
}
