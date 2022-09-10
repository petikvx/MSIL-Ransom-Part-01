using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DesignerCategory("code")]
public class FileAssocArray
{
	private FileAssoc[] fileAssocsField;

	public FileAssoc[] FileAssocs
	{
		get
		{
			return fileAssocsField;
		}
		set
		{
			fileAssocsField = value;
		}
	}
}
