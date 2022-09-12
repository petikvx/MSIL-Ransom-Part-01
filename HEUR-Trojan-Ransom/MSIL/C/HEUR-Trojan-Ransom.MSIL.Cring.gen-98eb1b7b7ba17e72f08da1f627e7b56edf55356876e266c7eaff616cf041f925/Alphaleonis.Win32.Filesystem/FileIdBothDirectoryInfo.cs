using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Security;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
[SecurityCritical]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dir")]
public sealed class FileIdBothDirectoryInfo
{
	public long AllocationSize { get; set; }

	public DateTime ChangeTime => ChangeTimeUtc.ToLocalTime();

	public DateTime ChangeTimeUtc { get; set; }

	public DateTime CreationTime => CreationTimeUtc.ToLocalTime();

	public DateTime CreationTimeUtc { get; set; }

	public int ExtendedAttributesSize { get; set; }

	public long EndOfFile { get; set; }

	public FileAttributes FileAttributes { get; set; }

	public long FileId { get; set; }

	public long FileIndex { get; set; }

	public string FileName { get; set; }

	public DateTime LastAccessTime => LastAccessTimeUtc.ToLocalTime();

	public DateTime LastAccessTimeUtc { get; set; }

	public DateTime LastWriteTime => LastWriteTimeUtc.ToLocalTime();

	public DateTime LastWriteTimeUtc { get; set; }

	public string ShortName { get; set; }

	internal FileIdBothDirectoryInfo(NativeMethods.FILE_ID_BOTH_DIR_INFO fibdi, string fileName)
	{
		CreationTimeUtc = DateTime.FromFileTimeUtc(fibdi.CreationTime);
		LastAccessTimeUtc = DateTime.FromFileTimeUtc(fibdi.LastAccessTime);
		LastWriteTimeUtc = DateTime.FromFileTimeUtc(fibdi.LastWriteTime);
		ChangeTimeUtc = DateTime.FromFileTimeUtc(fibdi.ChangeTime);
		AllocationSize = fibdi.AllocationSize;
		EndOfFile = fibdi.EndOfFile;
		ExtendedAttributesSize = fibdi.EaSize;
		FileAttributes = fibdi.FileAttributes;
		FileId = fibdi.FileId;
		FileIndex = fibdi.FileIndex;
		FileName = fileName;
		ShortName = new string(fibdi.ShortName, 0, (int)fibdi.ShortNameLength / 2);
	}
}
