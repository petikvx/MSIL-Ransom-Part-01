using System;

namespace NAudio.Wave;

[Flags]
public enum Mp3WaveFormatFlags
{
	PaddingIso = 0,
	PaddingOn = 1,
	PaddingOff = 2
}
