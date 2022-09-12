using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Security;
using System.Text;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
[SecurityCritical]
public sealed class Shell32Info
{
	private NativeMethods.IQueryAssociations _iQaNone;

	private NativeMethods.IQueryAssociations _iQaByExe;

	private string _association;

	private Shell32.GetAttributesOf _attributes;

	private string _command;

	private string _contentType;

	private string _ddeApplication;

	private string _defaultIcon;

	private string _friendlyAppName;

	private string _friendlyDocName;

	private string _openWithAppName;

	public string Association
	{
		get
		{
			if (_association == null)
			{
				_association = GetString(_iQaNone, Shell32.AssociationString.Executable, null);
			}
			return _association;
		}
		private set
		{
			_association = value;
		}
	}

	public Shell32.GetAttributesOf Attributes
	{
		get
		{
			if (_attributes == Shell32.GetAttributesOf.None)
			{
				_attributes = Shell32.GetFileInfoCore(FullPath, FileAttributes.Normal, Shell32.FileAttributes.Attributes, checkInvalidPathChars: false, continueOnException: true).Attributes;
			}
			return _attributes;
		}
		private set
		{
			_attributes = value;
		}
	}

	public string Command
	{
		get
		{
			if (_command == null)
			{
				_command = GetString(_iQaNone, Shell32.AssociationString.Command, null);
			}
			return _command;
		}
		private set
		{
			_command = value;
		}
	}

	public string ContentType
	{
		get
		{
			if (_contentType == null)
			{
				_contentType = GetString(_iQaNone, Shell32.AssociationString.ContentType, null);
			}
			return _contentType;
		}
		private set
		{
			_contentType = value;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dde")]
	public string DdeApplication
	{
		get
		{
			if (_ddeApplication == null)
			{
				_ddeApplication = GetString(_iQaNone, Shell32.AssociationString.DdeApplication, null);
			}
			return _ddeApplication;
		}
		private set
		{
			_ddeApplication = value;
		}
	}

	public string DefaultIcon
	{
		get
		{
			if (_defaultIcon == null)
			{
				_defaultIcon = GetString(_iQaNone, Shell32.AssociationString.DefaultIcon, null);
			}
			return _defaultIcon;
		}
		private set
		{
			_defaultIcon = value;
		}
	}

	public string FullPath { get; private set; }

	public string FriendlyAppName
	{
		get
		{
			if (_friendlyAppName == null)
			{
				_friendlyAppName = GetString(_iQaByExe, Shell32.AssociationString.FriendlyAppName, null);
			}
			return _friendlyAppName;
		}
		private set
		{
			_friendlyAppName = value;
		}
	}

	public string FriendlyDocName
	{
		get
		{
			if (_friendlyDocName == null)
			{
				_friendlyDocName = GetString(_iQaNone, Shell32.AssociationString.FriendlyDocName, null);
			}
			return _friendlyDocName;
		}
		private set
		{
			_friendlyDocName = value;
		}
	}

	internal bool Initialized { get; set; }

	public string OpenWithAppName
	{
		get
		{
			if (_openWithAppName == null)
			{
				_openWithAppName = GetString(_iQaNone, Shell32.AssociationString.FriendlyAppName, null);
			}
			return _openWithAppName;
		}
		private set
		{
			_openWithAppName = value;
		}
	}

	public Shell32Info(string fileName)
		: this(fileName, PathFormat.RelativePath)
	{
	}

	public Shell32Info(string fileName, PathFormat pathFormat)
	{
		if (Utils.IsNullOrWhiteSpace(fileName))
		{
			throw new ArgumentNullException("fileName");
		}
		FullPath = Path.GetExtendedLengthPathCore(null, fileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		Initialize();
	}

	[SecurityCritical]
	public IntPtr GetIcon(Shell32.FileAttributes iconAttributes)
	{
		return Shell32.GetFileIcon(FullPath, iconAttributes);
	}

	[SecurityCritical]
	public string GetVerbCommand(string shellVerb)
	{
		return GetString(_iQaNone, Shell32.AssociationString.Command, shellVerb);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	private static string GetString(NativeMethods.IQueryAssociations iQa, Shell32.AssociationString assocString, string shellVerb)
	{
		try
		{
			int pcchOut = 4096;
			StringBuilder stringBuilder = new StringBuilder(4096);
			iQa.GetString(Shell32.AssociationAttributes.NoTruncate | Shell32.AssociationAttributes.RemapRunDll, assocString, shellVerb, stringBuilder, out pcchOut);
			return stringBuilder.ToString();
		}
		catch
		{
			return string.Empty;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	[SecurityCritical]
	private void Initialize()
	{
		if (Initialized)
		{
			return;
		}
		Guid riid = new Guid("C46CA590-3C3F-11D2-BEE6-0000F805CA57");
		if (NativeMethods.AssocCreate(NativeMethods.ClsidQueryAssociations, ref riid, out _iQaNone) != 0)
		{
			return;
		}
		try
		{
			_iQaNone.Init(Shell32.AssociationAttributes.None, FullPath, IntPtr.Zero, IntPtr.Zero);
			if (NativeMethods.AssocCreate(NativeMethods.ClsidQueryAssociations, ref riid, out _iQaByExe) == 0)
			{
				_iQaByExe.Init(Shell32.AssociationAttributes.InitByExeName, FullPath, IntPtr.Zero, IntPtr.Zero);
				Initialized = true;
			}
		}
		catch
		{
		}
	}

	[SecurityCritical]
	public void Refresh()
	{
		string text2 = (OpenWithAppName = null);
		string text4 = (FriendlyDocName = text2);
		string text6 = (FriendlyAppName = text4);
		string text8 = (DefaultIcon = text6);
		string text10 = (DdeApplication = text8);
		string text12 = (ContentType = text10);
		string text15 = (Association = (Command = text12));
		Attributes = Shell32.GetAttributesOf.None;
		Initialized = false;
		Initialize();
	}

	public override string ToString()
	{
		return FullPath;
	}
}
