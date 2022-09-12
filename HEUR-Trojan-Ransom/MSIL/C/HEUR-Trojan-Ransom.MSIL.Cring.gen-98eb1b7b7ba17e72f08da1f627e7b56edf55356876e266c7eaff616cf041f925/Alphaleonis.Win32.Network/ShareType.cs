using System;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Network;

[SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
[SuppressMessage("Microsoft.Usage", "CA2217:DoNotMarkEnumsWithFlags")]
[SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames")]
[Flags]
public enum ShareType
{
	DiskTree = 0,
	PrintQueue = 1,
	Device = 2,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ipc")]
	Ipc = 3,
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Fs")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Fs")]
	ClusterFs = 0x2000000,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Fs")]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Fs")]
	ClusterSoFs = 0x4000000,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dfs")]
	ClusterDfs = 0x8000000,
	Special = int.MinValue,
	Temporary = 0x40000000,
	All = -838860797
}
