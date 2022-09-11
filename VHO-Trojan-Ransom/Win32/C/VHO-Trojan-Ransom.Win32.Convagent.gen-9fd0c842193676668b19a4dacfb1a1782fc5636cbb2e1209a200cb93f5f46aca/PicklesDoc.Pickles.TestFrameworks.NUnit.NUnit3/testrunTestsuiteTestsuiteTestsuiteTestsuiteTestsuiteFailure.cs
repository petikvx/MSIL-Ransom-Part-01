using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("xsd", "4.6.1055.0")]
[XmlType(AnonymousType = true)]
public class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteFailure
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
