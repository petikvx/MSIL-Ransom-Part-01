using System;

namespace NAudio.Wave.Compression;

[Flags]
internal enum AcmStreamHeaderStatusFlags
{
	Done = 0x10000,
	Prepared = 0x20000,
	InQueue = 0x100000
}
