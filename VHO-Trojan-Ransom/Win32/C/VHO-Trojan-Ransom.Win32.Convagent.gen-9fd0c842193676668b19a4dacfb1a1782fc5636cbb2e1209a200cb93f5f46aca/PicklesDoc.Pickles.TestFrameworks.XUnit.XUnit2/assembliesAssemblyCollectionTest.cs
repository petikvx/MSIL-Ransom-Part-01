using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit2;

[Serializable]
[XmlType(AnonymousType = true)]
[GeneratedCode("xsd", "4.6.1055.0")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class assembliesAssemblyCollectionTest
{
	private assembliesAssemblyCollectionTestTrait[] traitsField;

	private string reasonField;

	private assembliesAssemblyCollectionTestFailure failureField;

	private string nameField;

	private string typeField;

	private string methodField;

	private decimal timeField;

	private string resultField;

	[XmlArrayItem("trait", IsNullable = false)]
	public assembliesAssemblyCollectionTestTrait[] traits
	{
		get
		{
			return traitsField;
		}
		set
		{
			traitsField = value;
		}
	}

	public string reason
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

	public assembliesAssemblyCollectionTestFailure failure
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
	public string method
	{
		get
		{
			return methodField;
		}
		set
		{
			methodField = value;
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
}
