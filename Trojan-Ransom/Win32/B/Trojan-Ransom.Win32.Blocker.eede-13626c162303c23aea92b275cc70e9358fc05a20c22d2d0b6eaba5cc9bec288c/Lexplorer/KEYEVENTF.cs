using System;

namespace Lexplorer;

[Flags]
internal enum KEYEVENTF : uint
{
	EXTENDEDKEY = 1u,
	KEYUP = 2u,
	SCANCODE = 8u,
	UNICODE = 4u
}
