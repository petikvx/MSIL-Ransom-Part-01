using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

[Serializable]
[XmlType(AnonymousType = true)]
[GeneratedCode("xsd", "4.6.1055.0")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class testrunTestsuiteFailure
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
