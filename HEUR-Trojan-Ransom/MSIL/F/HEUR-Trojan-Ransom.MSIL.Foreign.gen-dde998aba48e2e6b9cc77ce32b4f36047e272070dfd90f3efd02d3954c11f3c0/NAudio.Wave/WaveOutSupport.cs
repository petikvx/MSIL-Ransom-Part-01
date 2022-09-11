using System;

namespace NAudio.Wave;

[Flags]
internal enum WaveOutSupport
{
	Pitch = 1,
	PlaybackRate = 2,
	Volume = 4,
	LRVolume = 8,
	Sync = 0x10,
	SampleAccurate = 0x20
}
