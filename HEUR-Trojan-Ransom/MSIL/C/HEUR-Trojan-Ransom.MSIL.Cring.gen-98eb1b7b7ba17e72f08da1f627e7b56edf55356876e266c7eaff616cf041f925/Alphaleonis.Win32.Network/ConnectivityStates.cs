using System;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Network;

[Flags]
public enum ConnectivityStates
{
	None = 0,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pv")]
	IPv4NoTraffic = 1,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pv")]
	IPv6NoTraffic = 2,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pv")]
	IPv4Subnet = 0x10,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pv")]
	IPv4LocalNetwork = 0x20,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pv")]
	IPv4Internet = 0x40,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pv")]
	IPv6Subnet = 0x100,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pv")]
	IPv6LocalNetwork = 0x200,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pv")]
	IPv6Internet = 0x400
}
