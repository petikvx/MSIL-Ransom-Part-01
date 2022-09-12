using System;

namespace X11;

[Flags]
internal enum MotifInputMode
{
	Modeless = 0,
	ApplicationModal = 1,
	SystemModal = 2,
	FullApplicationModal = 3
}
