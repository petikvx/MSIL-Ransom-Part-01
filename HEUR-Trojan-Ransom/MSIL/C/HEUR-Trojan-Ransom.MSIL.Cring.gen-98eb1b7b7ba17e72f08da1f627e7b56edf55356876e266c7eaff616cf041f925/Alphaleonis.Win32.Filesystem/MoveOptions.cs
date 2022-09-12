using System;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Filesystem;

[Flags]
public enum MoveOptions
{
	None = 0,
	ReplaceExisting = 1,
	CopyAllowed = 2,
	DelayUntilReboot = 4,
	WriteThrough = 8,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hardlink")]
	CreateHardlink = 0x10,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Trackable")]
	FailIfNotTrackable = 0x20
}
