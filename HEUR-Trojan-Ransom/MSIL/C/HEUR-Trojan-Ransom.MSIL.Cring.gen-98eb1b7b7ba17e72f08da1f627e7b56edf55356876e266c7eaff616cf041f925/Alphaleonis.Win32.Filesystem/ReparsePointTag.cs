using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Filesystem;

public enum ReparsePointTag
{
	None = 0,
	AppXStream = -1073741804,
	Csv = -2147483639,
	DriverExtender = -2147483643,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dedup")]
	Dedup = -2147483629,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	Dfs = -2147483638,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfsr")]
	Dfsr = -2147483630,
	FilterManager = -2147483637,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hsm")]
	Hsm = -1073741820,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hsm")]
	Hsm2 = -2147483642,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Nfs")]
	Nfs = -2147483628,
	MountPoint = -1610612733,
	Sis = -2147483641,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sym")]
	SymLink = -1610612724,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Wim")]
	Wim = -2147483640
}
