using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
public class FileLockRestricArray
{
	private FileLockRestric[] fileLockRestrictionsField;

	public FileLockRestric[] FileLockRestrictions
	{
		get
		{
			return fileLockRestrictionsField;
		}
		set
		{
			fileLockRestrictionsField = value;
		}
	}
}
