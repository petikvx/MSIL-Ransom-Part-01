using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DebuggerStepThrough]
public class FileFolder
{
	private Folder folderField;

	private File fileField;

	public Folder Folder
	{
		get
		{
			return folderField;
		}
		set
		{
			folderField = value;
		}
	}

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
}
