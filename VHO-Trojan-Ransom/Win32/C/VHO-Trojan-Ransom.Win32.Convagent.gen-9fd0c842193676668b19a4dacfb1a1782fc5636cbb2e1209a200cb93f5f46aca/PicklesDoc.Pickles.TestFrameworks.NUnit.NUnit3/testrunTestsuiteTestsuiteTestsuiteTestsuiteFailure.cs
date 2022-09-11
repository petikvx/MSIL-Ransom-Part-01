using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[DebuggerStepThrough]
[GeneratedCode("xsd", "4.6.1055.0")]
public class testrunTestsuiteTestsuiteTestsuiteTestsuiteFailure
{
	private string messageField;

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
}
