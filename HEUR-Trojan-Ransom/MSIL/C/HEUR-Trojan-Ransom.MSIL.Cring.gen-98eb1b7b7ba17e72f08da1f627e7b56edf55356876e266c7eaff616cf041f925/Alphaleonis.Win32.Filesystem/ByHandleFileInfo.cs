using System;
using System.IO;
using System.Security;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
[SecurityCritical]
public sealed class ByHandleFileInfo
{
	public FileAttributes Attributes { get; private set; }

	public DateTime CreationTime => CreationTimeUtc.ToLocalTime();

	public DateTime CreationTimeUtc { get; private set; }

	public DateTime LastAccessTime => LastAccessTimeUtc.ToLocalTime();

	public DateTime LastAccessTimeUtc { get; private set; }

	public DateTime LastWriteTime => LastWriteTimeUtc.ToLocalTime();

	public DateTime LastWriteTimeUtc { get; private set; }

	public long VolumeSerialNumber { get; private set; }

	public long FileSize { get; private set; }

	public int NumberOfLinks { get; private set; }

	public long FileIndex { get; private set; }

	internal ByHandleFileInfo(NativeMethods.BY_HANDLE_FILE_INFORMATION fibh)
	{
		CreationTimeUtc = DateTime.FromFileTimeUtc(fibh.ftCreationTime);
		LastAccessTimeUtc = DateTime.FromFileTimeUtc(fibh.ftLastAccessTime);
		LastWriteTimeUtc = DateTime.FromFileTimeUtc(fibh.ftLastWriteTime);
		Attributes = fibh.dwFileAttributes;
		FileIndex = NativeMethods.ToLong(fibh.nFileIndexHigh, fibh.nFileIndexLow);
		FileSize = NativeMethods.ToLong(fibh.nFileSizeHigh, fibh.nFileSizeLow);
		NumberOfLinks = (int)fibh.nNumberOfLinks;
		VolumeSerialNumber = fibh.dwVolumeSerialNumber;
	}
}
