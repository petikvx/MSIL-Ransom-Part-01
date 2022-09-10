using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
public class Label
{
	private long idField;

	private string nameField;

	private string commField;

	private DateTime createDateField;

	private long createUserIdField;

	private string createUserNameField;

	private int numFilesField;

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
	public string Comm
	{
		get
		{
			return commField;
		}
		set
		{
			commField = value;
		}
	}

	[XmlAttribute]
	public DateTime CreateDate
	{
		get
		{
			return createDateField;
		}
		set
		{
			createDateField = value;
		}
	}

	[XmlAttribute]
	public long CreateUserId
	{
		get
		{
			return createUserIdField;
		}
		set
		{
			createUserIdField = value;
		}
	}

	[XmlAttribute]
	public string CreateUserName
	{
		get
		{
			return createUserNameField;
		}
		set
		{
			createUserNameField = value;
		}
	}

	[XmlAttribute]
	public int NumFiles
	{
		get
		{
			return numFilesField;
		}
		set
		{
			numFilesField = value;
		}
	}
}
