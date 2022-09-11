using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit2;

[Serializable]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.6.1055.0")]
[DebuggerStepThrough]
public class assemblies
{
	private assembliesAssembly assemblyField;

	public assembliesAssembly assembly
	{
		get
		{
			return assemblyField;
		}
		set
		{
			assemblyField = value;
		}
	}
}
