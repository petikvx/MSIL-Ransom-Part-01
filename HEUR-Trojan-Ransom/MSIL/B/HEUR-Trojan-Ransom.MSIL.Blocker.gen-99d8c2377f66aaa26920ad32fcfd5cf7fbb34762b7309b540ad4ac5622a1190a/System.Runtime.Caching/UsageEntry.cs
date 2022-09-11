using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Caching;

[StructLayout(LayoutKind.Explicit)]
[SecuritySafeCritical]
internal struct UsageEntry
{
	[FieldOffset(0)]
	internal UsageEntryLink _ref1;

	[FieldOffset(4)]
	internal int _cFree;

	[FieldOffset(8)]
	internal UsageEntryLink _ref2;

	[FieldOffset(16)]
	internal DateTime _utcDate;

	[FieldOffset(24)]
	internal MemoryCacheEntry _cacheEntry;
}
