using System;

namespace ns0;

[Flags]
public enum GEnum5 : ulong
{
	FileWriteThrough = 2uL,
	FileSequentialOnly = 4uL,
	FileNoIntermediateBuffering = 8uL,
	FileSynchronousIoAlert = 0x10uL,
	FileSynchronousIoNonalert = 0x20uL,
	FileNonDirectoryFile = 0x40uL,
	FileRandomAccess = 0x800uL,
	FileDeleteOnClose = 0x1000uL,
	FileOpenForBackupIntent = 0x4000uL,
	FileNoCompression = 0x8000uL
}
