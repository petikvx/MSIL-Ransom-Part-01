using System;

namespace NAudio.Codecs;

[Flags]
public enum G722Flags
{
	None = 0,
	SampleRate8000 = 1,
	Packed = 2
}
