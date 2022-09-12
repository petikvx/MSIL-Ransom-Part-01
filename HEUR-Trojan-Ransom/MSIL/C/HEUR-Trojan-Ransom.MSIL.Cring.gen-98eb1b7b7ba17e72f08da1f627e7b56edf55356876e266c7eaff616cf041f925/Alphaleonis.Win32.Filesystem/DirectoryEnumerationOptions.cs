using System;

namespace Alphaleonis.Win32.Filesystem;

[Flags]
public enum DirectoryEnumerationOptions
{
	None = 0,
	Files = 1,
	Folders = 2,
	FilesAndFolders = 3,
	AsLongPath = 4,
	SkipReparsePoints = 8,
	ContinueOnException = 0x10,
	Recursive = 0x20,
	BasicSearch = 0x40,
	LargeCache = 0x80
}
