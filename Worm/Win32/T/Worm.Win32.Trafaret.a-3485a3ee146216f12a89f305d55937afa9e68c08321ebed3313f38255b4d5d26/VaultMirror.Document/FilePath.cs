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
public class FilePath
{
	private File fileField;

	private string pathField;

	public File File
	{
		get
		{
			return fileField;
		}
		set
		{
			fileField = value;
		}
	}

	[XmlAttribute]
	public string Path
	{
		get
		{
			return pathField;
		}
		set
		{
			pathField = value;
		}
	}
}
