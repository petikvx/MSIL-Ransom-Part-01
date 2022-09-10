using System;

namespace Intuit.Spc.Map.HelpSystem;

[Flags]
internal enum COINIT : uint
{
	COINIT_MULTITHREADED = 0u,
	COINIT_APARTMENTTHREADED = 2u,
	COINIT_DISABLE_OLE1DDE = 4u,
	COINIT_SPEED_OVER_MEMORY = 8u
}
