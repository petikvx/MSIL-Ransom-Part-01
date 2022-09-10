using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class FileNmngDescr
{
	private long schemeIdField;

	private string valField;

	private long numField;

	[XmlAttribute]
	public long SchemeId
	{
		get
		{
			return schemeIdField;
		}
		set
		{
			schemeIdField = value;
		}
	}

	[XmlAttribute]
	public string Val
	{
		get
		{
			return valField;
		}
		set
		{
			valField = value;
		}
	}

	[XmlAttribute]
	public long Num
	{
		get
		{
			return numField;
		}
		set
		{
			numField = value;
		}
	}
}
