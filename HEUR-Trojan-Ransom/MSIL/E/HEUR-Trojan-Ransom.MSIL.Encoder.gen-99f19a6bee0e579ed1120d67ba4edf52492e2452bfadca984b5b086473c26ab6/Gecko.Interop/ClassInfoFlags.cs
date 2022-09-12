using System;

namespace Gecko.Interop;

[Flags]
public enum ClassInfoFlags
{
	Singleton = 1,
	ThreadSafe = 2,
	MainThreadOnly = 4,
	DomObject = 8,
	PluginObject = 0x10,
	ContentNode = 0x40,
	[Obsolete("Obsolete since Gecko 2.0", true)]
	EagerClassInfo = 0x20
}
