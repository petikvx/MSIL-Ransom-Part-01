using System;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Filesystem;

[Flags]
public enum CopyOptions
{
	None = 0,
	FailIfExists = 1,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Restartable")]
	Restartable = 2,
	OpenSourceForWrite = 4,
	AllowDecryptedDestination = 8,
	CopySymbolicLink = 0x800,
	NoBuffering = 0x1000
}
