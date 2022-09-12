using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
[ComVisible(true)]
public abstract class FileSystemInfo : MarshalByRefObject
{
	[SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
	protected string FullPath;

	[SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
	protected string OriginalPath;

	[NonSerialized]
	internal int DataInitialised = -1;

	[NonSerialized]
	internal NativeMethods.WIN32_FILE_ATTRIBUTE_DATA Win32AttributeData;

	private FileSystemEntryInfo _entryInfo;

	public FileAttributes Attributes
	{
		[SecurityCritical]
		get
		{
			if (DataInitialised == -1)
			{
				Win32AttributeData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
				Refresh();
			}
			if (DataInitialised != 0)
			{
				NativeError.ThrowException(DataInitialised, FullPath);
			}
			return Win32AttributeData.dwFileAttributes;
		}
		[SecurityCritical]
		set
		{
			File.SetAttributesCore(Transaction, IsDirectory, LongFullName, value, PathFormat.LongFullPath);
			Reset();
		}
	}

	public DateTime CreationTime
	{
		[SecurityCritical]
		get
		{
			return CreationTimeUtc.ToLocalTime();
		}
		[SecurityCritical]
		set
		{
			CreationTimeUtc = value.ToUniversalTime();
		}
	}

	[ComVisible(false)]
	public DateTime CreationTimeUtc
	{
		[SecurityCritical]
		get
		{
			if (DataInitialised == -1)
			{
				Win32AttributeData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
				Refresh();
			}
			if (DataInitialised != 0)
			{
				NativeError.ThrowException(DataInitialised, LongFullName);
			}
			return DateTime.FromFileTimeUtc(Win32AttributeData.ftCreationTime);
		}
		[SecurityCritical]
		set
		{
			File.SetFsoDateTimeCore(Transaction, IsDirectory, LongFullName, value, null, null, modifyReparsePoint: false, PathFormat.LongFullPath);
			Reset();
		}
	}

	public abstract bool Exists { get; }

	public string Extension => Path.GetExtension(FullPath, checkInvalidPathChars: false);

	public virtual string FullName
	{
		[SecurityCritical]
		get
		{
			return FullPath;
		}
	}

	public DateTime LastAccessTime
	{
		[SecurityCritical]
		get
		{
			return LastAccessTimeUtc.ToLocalTime();
		}
		[SecurityCritical]
		set
		{
			LastAccessTimeUtc = value.ToUniversalTime();
		}
	}

	[ComVisible(false)]
	public DateTime LastAccessTimeUtc
	{
		[SecurityCritical]
		get
		{
			if (DataInitialised == -1)
			{
				Win32AttributeData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
				Refresh();
			}
			if (DataInitialised != 0)
			{
				NativeError.ThrowException(DataInitialised, LongFullName);
			}
			return DateTime.FromFileTimeUtc(Win32AttributeData.ftLastAccessTime);
		}
		[SecurityCritical]
		set
		{
			File.SetFsoDateTimeCore(Transaction, IsDirectory, LongFullName, null, value, null, modifyReparsePoint: false, PathFormat.LongFullPath);
			Reset();
		}
	}

	public DateTime LastWriteTime
	{
		get
		{
			return LastWriteTimeUtc.ToLocalTime();
		}
		set
		{
			LastWriteTimeUtc = value.ToUniversalTime();
		}
	}

	[ComVisible(false)]
	public DateTime LastWriteTimeUtc
	{
		[SecurityCritical]
		get
		{
			if (DataInitialised == -1)
			{
				Win32AttributeData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
				Refresh();
			}
			if (DataInitialised != 0)
			{
				NativeError.ThrowException(DataInitialised, LongFullName);
			}
			return DateTime.FromFileTimeUtc(Win32AttributeData.ftLastWriteTime);
		}
		[SecurityCritical]
		set
		{
			File.SetFsoDateTimeCore(Transaction, IsDirectory, LongFullName, null, null, value, modifyReparsePoint: false, PathFormat.LongFullPath);
			Reset();
		}
	}

	public abstract string Name { get; }

	protected internal string DisplayPath { get; protected set; }

	public FileSystemEntryInfo EntryInfo
	{
		[SecurityCritical]
		get
		{
			if (_entryInfo == null)
			{
				Win32AttributeData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
				RefreshEntryInfo();
			}
			if (DataInitialised > 0)
			{
				NativeError.ThrowException(DataInitialised, LongFullName);
			}
			return _entryInfo;
		}
		internal set
		{
			_entryInfo = value;
			DataInitialised = ((value == null) ? (-1) : 0);
			if (DataInitialised == 0)
			{
				Win32AttributeData = new NativeMethods.WIN32_FILE_ATTRIBUTE_DATA(_entryInfo.Win32FindData);
			}
		}
	}

	protected bool IsDirectory { get; set; }

	protected string LongFullName { get; set; }

	protected KernelTransaction Transaction { get; set; }

	[SecurityCritical]
	public abstract void Delete();

	[SecurityCritical]
	public void Refresh()
	{
		DataInitialised = File.FillAttributeInfoCore(Transaction, LongFullName, ref Win32AttributeData, tryAgain: false, returnErrorOnNotFound: false);
		IsDirectory = File.IsDirectory(Win32AttributeData.dwFileAttributes);
	}

	public override string ToString()
	{
		return GetType().ToString();
	}

	public override bool Equals(object obj)
	{
		if (obj != null && (object)GetType() == obj.GetType())
		{
			FileSystemInfo fileSystemInfo = obj as FileSystemInfo;
			if (null != fileSystemInfo && fileSystemInfo.Name != null && fileSystemInfo.FullName.Equals(FullName, StringComparison.OrdinalIgnoreCase) && fileSystemInfo.Attributes.Equals(Attributes) && fileSystemInfo.CreationTimeUtc.Equals(CreationTimeUtc))
			{
				return fileSystemInfo.LastWriteTimeUtc.Equals(LastWriteTimeUtc);
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (FullName == null)
		{
			return 0;
		}
		return FullName.GetHashCode();
	}

	public static bool operator ==(FileSystemInfo left, FileSystemInfo right)
	{
		if ((object)left == null && (object)right == null)
		{
			return true;
		}
		if ((object)left != null && (object)right != null)
		{
			return left.Equals(right);
		}
		return false;
	}

	public static bool operator !=(FileSystemInfo left, FileSystemInfo right)
	{
		return !(left == right);
	}

	internal void UpdateSourcePath(string destinationPath, string destinationPathLp)
	{
		LongFullName = destinationPathLp;
		FullPath = ((destinationPathLp != null) ? Path.GetRegularPathCore(LongFullName, GetFullPathOptions.None, allowEmpty: false) : null);
		OriginalPath = destinationPath;
		DisplayPath = ((OriginalPath != null) ? Path.GetRegularPathCore(OriginalPath, GetFullPathOptions.None, allowEmpty: false) : null);
		Reset();
	}

	[SecurityCritical]
	protected void RefreshEntryInfo()
	{
		_entryInfo = File.GetFileSystemEntryInfoCore(Transaction, IsDirectory, LongFullName, continueOnException: true, PathFormat.LongFullPath);
		if (_entryInfo == null)
		{
			DataInitialised = -1;
			return;
		}
		DataInitialised = 0;
		Win32AttributeData = new NativeMethods.WIN32_FILE_ATTRIBUTE_DATA(_entryInfo.Win32FindData);
	}

	private void Reset()
	{
		DataInitialised = -1;
	}

	internal void InitializeCore(KernelTransaction transaction, bool isFolder, string path, PathFormat pathFormat)
	{
		if (pathFormat == PathFormat.RelativePath)
		{
			Path.CheckSupportedPathFormat(path, checkInvalidPathChars: true, checkAdditional: true);
		}
		LongFullName = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.TrimEnd | (isFolder ? GetFullPathOptions.RemoveTrailingDirectorySeparator : GetFullPathOptions.None) | GetFullPathOptions.ContinueOnNonExist);
		FullPath = Path.GetRegularPathCore(LongFullName, GetFullPathOptions.None, allowEmpty: false);
		IsDirectory = isFolder;
		Transaction = transaction;
		OriginalPath = ((FullPath.Length != 2 || FullPath[1] != Path.VolumeSeparatorChar) ? path : Path.CurrentDirectoryPrefix);
		DisplayPath = ((OriginalPath.Length != 2 || OriginalPath[1] != Path.VolumeSeparatorChar) ? Path.GetRegularPathCore(OriginalPath, GetFullPathOptions.None, allowEmpty: false) : Path.CurrentDirectoryPrefix);
	}

	internal static SafeFindFileHandle FindFirstFileNative(KernelTransaction transaction, string pathLp, NativeMethods.FINDEX_INFO_LEVELS infoLevel, NativeMethods.FINDEX_SEARCH_OPS searchOption, NativeMethods.FIND_FIRST_EX_FLAGS additionalFlags, out int lastError, out NativeMethods.WIN32_FIND_DATA win32FindData)
	{
		SafeFindFileHandle safeFindFileHandle = ((transaction == null || !NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.FindFirstFileExW(Path.RemoveTrailingDirectorySeparator(pathLp), infoLevel, out win32FindData, searchOption, IntPtr.Zero, additionalFlags) : NativeMethods.FindFirstFileTransactedW(Path.RemoveTrailingDirectorySeparator(pathLp), infoLevel, out win32FindData, searchOption, IntPtr.Zero, additionalFlags, transaction.SafeHandle));
		lastError = Marshal.GetLastWin32Error();
		if (!NativeMethods.IsValidHandle(safeFindFileHandle, throwException: false))
		{
			safeFindFileHandle = null;
		}
		return safeFindFileHandle;
	}
}
