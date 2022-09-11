using System;

namespace NAudio.Mixer;

[Flags]
internal enum MixerControlSubclass
{
	SwitchBoolean = 0,
	SwitchButton = 0x1000000,
	MeterPolled = 0,
	TimeMicrosecs = 0,
	TimeMillisecs = 0x1000000,
	ListSingle = 0,
	ListMultiple = 0x1000000,
	Mask = 0xF000000
}
