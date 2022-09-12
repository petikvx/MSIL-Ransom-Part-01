using System;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Network;

[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
[Flags]
public enum DfsPropertyFlags
{
	None = 0,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Insite")]
	InsiteReferrals = 1,
	RootScalability = 2,
	SiteCosting = 4,
	TargetFailback = 8,
	ClusterEnabled = 0x10,
	AccessBasedDirectoryEnumeration = 0x20
}
