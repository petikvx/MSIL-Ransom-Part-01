using System;

namespace NAudio.Wave;

[Flags]
public enum WaveHeaderFlags
{
	BeginLoop = 4,
	Done = 1,
	EndLoop = 8,
	InQueue = 0x10,
	Prepared = 2
}
