using System;

namespace Gecko.Net;

[Flags]
public enum ResolveFlags
{
	ByPassCache = 1,
	CanonicalName = 2,
	PriorityMedium = 4,
	PriorityLow = 8,
	Speculate = 0x10,
	DisableIpV6 = 0x20
}
