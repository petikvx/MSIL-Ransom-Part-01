using System;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Network;

[Flags]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
public enum DfsStorageStates
{
	None = 0,
	Offline = 1,
	Online = 2,
	Active = 4
}
