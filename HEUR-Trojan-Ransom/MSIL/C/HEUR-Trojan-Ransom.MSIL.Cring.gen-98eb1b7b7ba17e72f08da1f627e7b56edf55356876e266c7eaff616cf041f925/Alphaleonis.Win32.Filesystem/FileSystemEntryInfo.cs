using System;
using System.IO;
using System.Security;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
[SecurityCritical]
public sealed class FileSystemEntryInfo
{
	private string _fullPath;

	private string _longFullPath;

	public string AlternateFileName => Win32FindData.cAlternateFileName;

	public FileAttributes Attributes => Win32FindData.dwFileAttributes;

	public DateTime CreationTime => CreationTimeUtc.ToLocalTime();

	public DateTime CreationTimeUtc => DateTime.FromFileTimeUtc(Win32FindData.ftCreationTime);

	public string Extension => Path.GetExtension(Win32FindData.cFileName, checkInvalidPathChars: false);

	public string FileName => Win32FindData.cFileName;

	public long FileSize => NativeMethods.ToLong(Win32FindData.nFileSizeHigh, Win32FindData.nFileSizeLow);

	public string FullPath
	{
		get
		{
			return _fullPath;
		}
		set
		{
			LongFullPath = value;
			_fullPath = Path.GetRegularPathCore(LongFullPath, GetFullPathOptions.None, allowEmpty: false);
		}
	}

	public bool IsArchive
	{
		get
		{
			if (File.HasValidAttributes(Attributes))
			{
				return (Attributes & FileAttributes.Archive) != 0;
			}
			return false;
		}
	}

	public bool IsCompressed
	{
		get
		{
			if (File.HasValidAttributes(Attributes))
			{
				return (Attributes & FileAttributes.Compressed) != 0;
			}
			return false;
		}
	}

	public bool IsDevice
	{
		get
		{
			if (File.HasValidAttributes(Attributes))
			{
				return (Attributes & FileAttributes.Device) != 0;
			}
			return false;
		}
	}

	public bool IsDirectory => File.IsDirectory(Attributes);

	public bool IsEncrypted
	{
		get
		{
			if (File.HasValidAttributes(Attributes))
			{
				return (Attributes & FileAttributes.Encrypted) != 0;
			}
			return false;
		}
	}

	public bool IsHidden => File.IsHidden(Attributes);

	public bool IsMountPoint => ReparsePointTag == ReparsePointTag.MountPoint;

	public bool IsNormal
	{
		get
		{
			if (File.HasValidAttributes(Attributes))
			{
				return (Attributes & FileAttributes.Normal) != 0;
			}
			return false;
		}
	}

	public bool IsNotContentIndexed
	{
		get
		{
			if (File.HasValidAttributes(Attributes))
			{
				return (Attributes & FileAttributes.NotContentIndexed) != 0;
			}
			return false;
		}
	}

	public bool IsOffline
	{
		get
		{
			if (File.HasValidAttributes(Attributes))
			{
				return (Attributes & FileAttributes.Offline) != 0;
			}
			return false;
		}
	}

	public bool IsReadOnly => File.IsReadOnly(Attributes);

	public bool IsReparsePoint
	{
		get
		{
			if (File.HasValidAttributes(Attributes))
			{
				return (Attributes & FileAttributes.ReparsePoint) != 0;
			}
			return false;
		}
	}

	public bool IsSparseFile
	{
		get
		{
			if (File.HasValidAttributes(Attributes))
			{
				return (Attributes & FileAttributes.SparseFile) != 0;
			}
			return false;
		}
	}

	public bool IsSymbolicLink => ReparsePointTag == ReparsePointTag.SymLink;

	public bool IsSystem
	{
		get
		{
			if (File.HasValidAttributes(Attributes))
			{
				return (Attributes & FileAttributes.System) != 0;
			}
			return false;
		}
	}

	public bool IsTemporary
	{
		get
		{
			if (File.HasValidAttributes(Attributes))
			{
				return (Attributes & FileAttributes.Temporary) != 0;
			}
			return false;
		}
	}

	public DateTime LastAccessTime => LastAccessTimeUtc.ToLocalTime();

	public DateTime LastAccessTimeUtc => DateTime.FromFileTimeUtc(Win32FindData.ftLastAccessTime);

	public DateTime LastWriteTime => LastWriteTimeUtc.ToLocalTime();

	public DateTime LastWriteTimeUtc => DateTime.FromFileTimeUtc(Win32FindData.ftLastWriteTime);

	public string LongFullPath
	{
		get
		{
			return _longFullPath;
		}
		private set
		{
			_longFullPath = Path.GetLongPathCore(value, GetFullPathOptions.None);
		}
	}

	public ReparsePointTag ReparsePointTag
	{
		get
		{
			if (!IsReparsePoint)
			{
				return ReparsePointTag.None;
			}
			return Win32FindData.dwReserved0;
		}
	}

	internal NativeMethods.WIN32_FIND_DATA Win32FindData { get; private set; }

	internal FileSystemEntryInfo(NativeMethods.WIN32_FIND_DATA findData)
	{
		Win32FindData = findData;
	}

	public override string ToString()
	{
		return FullPath;
	}
}
