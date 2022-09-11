using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit2;

[Serializable]
[XmlType(AnonymousType = true)]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.6.1055.0")]
[DebuggerStepThrough]
public class assembliesAssemblyCollectionTestFailure
{
	private string messageField;

	private string stacktraceField;

	private string exceptiontypeField;

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

	[XmlAttribute("exception-type")]
	public string exceptiontype
	{
		get
		{
			return exceptiontypeField;
		}
		set
		{
			exceptiontypeField = value;
		}
	}
}
