using System;

namespace Alphaleonis.Win32.Filesystem;

[Flags]
public enum FinalPathFormats
{
	None = 0,
	VolumeNameGuid = 1,
	VolumeNameNT = 2,
	VolumeNameNone = 4,
	FileNameOpened = 8
}
