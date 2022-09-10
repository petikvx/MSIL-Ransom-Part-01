using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "2.0.50727.42")]
public class FileRenameRestricArray
{
	private FileRenameRestric[] fileRenameRestrictionsField;

	public FileRenameRestric[] FileRenameRestrictions
	{
		get
		{
			return fileRenameRestrictionsField;
		}
		set
		{
			fileRenameRestrictionsField = value;
		}
	}
}
