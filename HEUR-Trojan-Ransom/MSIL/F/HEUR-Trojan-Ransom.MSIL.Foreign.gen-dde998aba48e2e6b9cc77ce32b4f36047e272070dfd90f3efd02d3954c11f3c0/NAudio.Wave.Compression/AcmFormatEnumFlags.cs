using System;

namespace NAudio.Wave.Compression;

[Flags]
public enum AcmFormatEnumFlags
{
	None = 0,
	Convert = 0x100000,
	Hardware = 0x400000,
	Input = 0x800000,
	Channels = 0x20000,
	SamplesPerSecond = 0x40000,
	Output = 0x1000000,
	Suggest = 0x200000,
	BitsPerSample = 0x80000,
	FormatTag = 0x10000
}
