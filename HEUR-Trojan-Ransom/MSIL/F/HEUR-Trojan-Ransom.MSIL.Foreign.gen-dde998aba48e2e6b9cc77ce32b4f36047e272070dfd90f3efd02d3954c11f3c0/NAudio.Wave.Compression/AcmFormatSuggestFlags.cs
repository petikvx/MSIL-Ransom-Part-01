using System;

namespace NAudio.Wave.Compression;

[Flags]
internal enum AcmFormatSuggestFlags
{
	FormatTag = 0x10000,
	Channels = 0x20000,
	SamplesPerSecond = 0x40000,
	BitsPerSample = 0x80000,
	TypeMask = 0xFF0000
}
