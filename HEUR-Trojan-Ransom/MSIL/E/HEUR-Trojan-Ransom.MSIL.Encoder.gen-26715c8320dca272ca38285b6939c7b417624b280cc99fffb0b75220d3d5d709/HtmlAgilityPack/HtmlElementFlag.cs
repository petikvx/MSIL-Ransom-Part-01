using System;

namespace HtmlAgilityPack;

[Flags]
public enum HtmlElementFlag
{
	CData = 1,
	Empty = 2,
	Closed = 4,
	CanOverlap = 8
}
