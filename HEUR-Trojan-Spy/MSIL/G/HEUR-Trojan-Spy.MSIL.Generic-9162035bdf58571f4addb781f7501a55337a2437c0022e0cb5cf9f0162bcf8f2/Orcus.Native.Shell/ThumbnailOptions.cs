using System;

namespace Orcus.Native.Shell;

[Flags]
public enum ThumbnailOptions
{
	None = 0,
	BiggerSizeOk = 1,
	InMemoryOnly = 2,
	IconOnly = 4,
	ThumbnailOnly = 8,
	InCacheOnly = 0x10
}
