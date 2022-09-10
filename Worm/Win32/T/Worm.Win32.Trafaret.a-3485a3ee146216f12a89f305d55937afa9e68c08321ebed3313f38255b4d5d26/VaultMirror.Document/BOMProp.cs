using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DesignerCategory("code")]
public class BOMProp
{
	private long idField;

	private string propSetIdField;

	private string propIdField;

	private string nameField;

	private string dispNameField;

	private PropertyTypeEnum typField;

	[XmlAttribute]
	public long Id
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
	public string PropSetId
	{
		get
		{
			return propSetIdField;
		}
		set
		{
			propSetIdField = value;
		}
	}

	[XmlAttribute]
	public string PropId
	{
		get
		{
			return propIdField;
		}
		set
		{
			propIdField = value;
		}
	}

	[XmlAttribute]
	public string Name
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
	public string DispName
	{
		get
		{
			return dispNameField;
		}
		set
		{
			dispNameField = value;
		}
	}

	[XmlAttribute]
	public PropertyTypeEnum Typ
	{
		get
		{
			return typField;
		}
		set
		{
			typField = value;
		}
	}
}
