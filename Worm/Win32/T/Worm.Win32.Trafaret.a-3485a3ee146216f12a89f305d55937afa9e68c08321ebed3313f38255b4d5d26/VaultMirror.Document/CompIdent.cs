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
public class CompIdent
{
	private long idField;

	private long fileIdField;

	private string uniqueIdField;

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
	public long FileId
	{
		get
		{
			return fileIdField;
		}
		set
		{
			fileIdField = value;
		}
	}

	[XmlAttribute]
	public string UniqueId
	{
		get
		{
			return uniqueIdField;
		}
		set
		{
			uniqueIdField = value;
		}
	}
}
