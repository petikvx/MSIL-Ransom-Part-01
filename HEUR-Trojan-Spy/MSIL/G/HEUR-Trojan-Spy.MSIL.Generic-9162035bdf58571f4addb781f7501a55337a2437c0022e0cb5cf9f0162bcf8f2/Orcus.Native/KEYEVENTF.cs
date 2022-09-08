using System;

namespace Orcus.Native;

[Flags]
internal enum KEYEVENTF : uint
{
	EXTENDEDKEY = 1u,
	KEYUP = 2u,
	SCANCODE = 8u,
	UNICODE = 4u
}
