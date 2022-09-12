using System;

namespace Gecko;

[Flags]
public enum GeckoLoadFlags
{
	None = 0,
	IsRefresh = 0x10,
	IsLink = 0x20,
	BypassHistory = 0x40,
	ReplaceHistory = 0x80,
	BypassCache = 0x100,
	BypassProxy = 0x200,
	CharsetChange = 0x400,
	StopContent = 0x800,
	FromExternal = 0x1000,
	AllowThirdPartyFixup = 0x100000,
	FirstLoad = 0x4000
}
