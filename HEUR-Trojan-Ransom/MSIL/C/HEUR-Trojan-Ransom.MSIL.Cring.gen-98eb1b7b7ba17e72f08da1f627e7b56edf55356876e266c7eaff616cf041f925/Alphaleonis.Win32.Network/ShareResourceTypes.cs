using System;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Network;

[Flags]
public enum ShareResourceTypes
{
	None = 0,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	Dfs = 1,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	DfsRoot = 2,
	RestrictExclusiveOpens = 0x100,
	ForceSharedDelete = 0x200,
	AllowNamespaceCaching = 0x400,
	AccessBasedDirectoryEnum = 0x800,
	ForceLevel2OpLock = 0x1000,
	EnableHash = 0x2000,
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Ca")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ca")]
	EnableCa = 0x4000
}
