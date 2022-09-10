using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class FilePathArray
{
	private FilePath[] filePathsField;

	public FilePath[] FilePaths
	{
		get
		{
			return filePathsField;
		}
		set
		{
			filePathsField = value;
		}
	}
}
