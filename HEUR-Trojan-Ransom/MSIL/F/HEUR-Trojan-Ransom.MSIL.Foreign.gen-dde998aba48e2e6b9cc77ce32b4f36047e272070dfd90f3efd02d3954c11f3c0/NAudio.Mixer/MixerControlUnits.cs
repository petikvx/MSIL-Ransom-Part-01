using System;

namespace NAudio.Mixer;

[Flags]
internal enum MixerControlUnits
{
	Custom = 0,
	Boolean = 0x10000,
	Signed = 0x20000,
	Unsigned = 0x30000,
	Decibels = 0x40000,
	Percent = 0x50000,
	Mask = 0xFF0000
}
