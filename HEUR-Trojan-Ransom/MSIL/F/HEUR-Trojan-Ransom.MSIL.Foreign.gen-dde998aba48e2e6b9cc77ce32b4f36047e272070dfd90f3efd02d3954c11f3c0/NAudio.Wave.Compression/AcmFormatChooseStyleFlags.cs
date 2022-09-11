using System;

namespace NAudio.Wave.Compression;

[Flags]
internal enum AcmFormatChooseStyleFlags
{
	None = 0,
	ShowHelp = 4,
	EnableHook = 8,
	EnableTemplate = 0x10,
	EnableTemplateHandle = 0x20,
	InitToWfxStruct = 0x40,
	ContextHelp = 0x80
}
