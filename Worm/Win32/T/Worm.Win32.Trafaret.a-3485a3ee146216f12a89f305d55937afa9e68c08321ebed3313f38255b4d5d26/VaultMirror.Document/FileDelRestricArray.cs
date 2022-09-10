using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
public class FileDelRestricArray
{
	private FileDelRestric[] fileDeleteRestrictionsField;

	public FileDelRestric[] FileDeleteRestrictions
	{
		get
		{
			return fileDeleteRestrictionsField;
		}
		set
		{
			fileDeleteRestrictionsField = value;
		}
	}
}
