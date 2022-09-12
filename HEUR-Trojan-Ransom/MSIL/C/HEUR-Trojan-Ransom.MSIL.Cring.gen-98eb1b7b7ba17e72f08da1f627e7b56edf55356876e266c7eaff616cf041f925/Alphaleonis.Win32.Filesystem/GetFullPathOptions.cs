using System;

namespace Alphaleonis.Win32.Filesystem;

[Flags]
public enum GetFullPathOptions
{
	None = 0,
	TrimEnd = 1,
	AddTrailingDirectorySeparator = 2,
	RemoveTrailingDirectorySeparator = 4,
	AsLongPath = 8,
	ContinueOnNonExist = 0x10,
	CheckInvalidPathChars = 0x20,
	CheckAdditional = 0x40,
	KeepDotOrSpace = 0x80,
	FullCheck = 0x60
}
