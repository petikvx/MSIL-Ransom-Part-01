using System;

namespace X11;

[Flags]
internal enum MotifFlags
{
	Functions = 1,
	Decorations = 2,
	InputMode = 4,
	Status = 8
}
