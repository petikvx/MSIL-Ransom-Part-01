using System;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Network;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
[Flags]
[SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
public enum DfsVolumeStates
{
	None = 0,
	Ok = 1,
	Inconsistent = 2,
	Offline = 3,
	Online = 4,
	FlavorStandalone = 0x100,
	FlavorAdBlob = 0x200
}
