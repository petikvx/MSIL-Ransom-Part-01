using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[DesignerCategory("code")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
public class File
{
	private long idField;

	private string nameField;

	private long masterIdField;

	private int verNumField;

	private int maxCkInVerNumField;

	private DateTime ckInDateField;

	private string commField;

	private DateTime createDateField;

	private long createUserIdField;

	private int cksumField;

	private long fileSizeField;

	private string createUserNameField;

	private bool checkedOutField;

	private long ckOutFolderIdField;

	private string ckOutSpecField;

	private string ckOutMachField;

	private long ckOutUserIdField;

	private FileClassification fileClassField;

	private bool hiddenField;

	private bool lockedField;

	private bool cloakedField;

	private FileStatus fileStatusField;

	private bool isOnSiteField;

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
	public long MasterId
	{
		get
		{
			return masterIdField;
		}
		set
		{
			masterIdField = value;
		}
	}

	[XmlAttribute]
	public int VerNum
	{
		get
		{
			return verNumField;
		}
		set
		{
			verNumField = value;
		}
	}

	[XmlAttribute]
	public int MaxCkInVerNum
	{
		get
		{
			return maxCkInVerNumField;
		}
		set
		{
			maxCkInVerNumField = value;
		}
	}

	[XmlAttribute]
	public DateTime CkInDate
	{
		get
		{
			return ckInDateField;
		}
		set
		{
			ckInDateField = value;
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
	public int Cksum
	{
		get
		{
			return cksumField;
		}
		set
		{
			cksumField = value;
		}
	}

	[XmlAttribute]
	public long FileSize
	{
		get
		{
			return fileSizeField;
		}
		set
		{
			fileSizeField = value;
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
	public bool CheckedOut
	{
		get
		{
			return checkedOutField;
		}
		set
		{
			checkedOutField = value;
		}
	}

	[XmlAttribute]
	public long CkOutFolderId
	{
		get
		{
			return ckOutFolderIdField;
		}
		set
		{
			ckOutFolderIdField = value;
		}
	}

	[XmlAttribute]
	public string CkOutSpec
	{
		get
		{
			return ckOutSpecField;
		}
		set
		{
			ckOutSpecField = value;
		}
	}

	[XmlAttribute]
	public string CkOutMach
	{
		get
		{
			return ckOutMachField;
		}
		set
		{
			ckOutMachField = value;
		}
	}

	[XmlAttribute]
	public long CkOutUserId
	{
		get
		{
			return ckOutUserIdField;
		}
		set
		{
			ckOutUserIdField = value;
		}
	}

	[XmlAttribute]
	public FileClassification FileClass
	{
		get
		{
			return fileClassField;
		}
		set
		{
			fileClassField = value;
		}
	}

	[XmlAttribute]
	public bool Hidden
	{
		get
		{
			return hiddenField;
		}
		set
		{
			hiddenField = value;
		}
	}

	[XmlAttribute]
	public bool Locked
	{
		get
		{
			return lockedField;
		}
		set
		{
			lockedField = value;
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

	[XmlAttribute]
	public FileStatus FileStatus
	{
		get
		{
			return fileStatusField;
		}
		set
		{
			fileStatusField = value;
		}
	}

	[XmlAttribute]
	public bool IsOnSite
	{
		get
		{
			return isOnSiteField;
		}
		set
		{
			isOnSiteField = value;
		}
	}
}
