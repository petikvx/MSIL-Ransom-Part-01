using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DebuggerStepThrough]
public class Folder
{
	private long idField;

	private string nameField;

	private string fullNameField;

	private long parIdField;

	private DateTime createDateField;

	private long createUserIdField;

	private bool isActField;

	private bool isLibField;

	private string createUserNameField;

	private int numCldsField;

	private string fullUncNameField;

	private bool cloakedField;

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
	public string FullName
	{
		get
		{
			return fullNameField;
		}
		set
		{
			fullNameField = value;
		}
	}

	[XmlAttribute]
	public long ParId
	{
		get
		{
			return parIdField;
		}
		set
		{
			parIdField = value;
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
	public bool IsAct
	{
		get
		{
			return isActField;
		}
		set
		{
			isActField = value;
		}
	}

	[XmlAttribute]
	public bool IsLib
	{
		get
		{
			return isLibField;
		}
		set
		{
			isLibField = value;
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
	public int NumClds
	{
		get
		{
			return numCldsField;
		}
		set
		{
			numCldsField = value;
		}
	}

	[XmlAttribute]
	public string FullUncName
	{
		get
		{
			return fullUncNameField;
		}
		set
		{
			fullUncNameField = value;
		}
	}

	[XmlAttribute]
	public bool Cloaked
	{
		get
		{
			return cloakedField;
		}
		set
		{
			cloakedField = value;
		}
	}
}
