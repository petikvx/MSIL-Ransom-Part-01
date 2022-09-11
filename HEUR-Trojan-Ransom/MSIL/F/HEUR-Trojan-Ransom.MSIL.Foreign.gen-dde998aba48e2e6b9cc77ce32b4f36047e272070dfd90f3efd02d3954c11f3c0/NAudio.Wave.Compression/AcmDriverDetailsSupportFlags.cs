using System;

namespace NAudio.Wave.Compression;

[Flags]
public enum AcmDriverDetailsSupportFlags
{
	Codec = 1,
	Converter = 2,
	Filter = 4,
	Hardware = 8,
	Async = 0x10,
	Local = 0x40000000,
	Disabled = int.MinValue
}
