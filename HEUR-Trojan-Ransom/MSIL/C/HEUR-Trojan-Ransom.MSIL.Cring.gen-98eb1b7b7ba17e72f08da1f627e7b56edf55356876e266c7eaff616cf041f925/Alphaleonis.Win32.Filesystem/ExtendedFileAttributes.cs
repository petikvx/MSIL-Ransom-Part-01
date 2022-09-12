using System;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Filesystem;

[Flags]
[SuppressMessage("Microsoft.Usage", "CA2217:DoNotMarkEnumsWithFlags")]
public enum ExtendedFileAttributes
{
	None = 0,
	ReadOnly = 1,
	Hidden = 2,
	System = 4,
	Directory = 0x10,
	Archive = 0x20,
	Device = 0x40,
	Normal = 0x80,
	Temporary = 0x100,
	SparseFile = 0x200,
	ReparsePoint = 0x400,
	Compressed = 0x800,
	Offline = 0x1000,
	NotContentIndexed = 0x2000,
	Encrypted = 0x4000,
	IntegrityStream = 0x8000,
	NoScrubData = 0x20000,
	FirstPipeInstance = 0x80000,
	OpenNoRecall = 0x100000,
	OpenReparsePoint = 0x200000,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Posix")]
	PosixSemantics = 0x1000000,
	BackupSemantics = 0x2000000,
	DeleteOnClose = 0x4000000,
	SequentialScan = 0x8000000,
	RandomAccess = 0x10000000,
	NoBuffering = 0x20000000,
	Overlapped = 0x40000000,
	WriteThrough = int.MinValue
}
