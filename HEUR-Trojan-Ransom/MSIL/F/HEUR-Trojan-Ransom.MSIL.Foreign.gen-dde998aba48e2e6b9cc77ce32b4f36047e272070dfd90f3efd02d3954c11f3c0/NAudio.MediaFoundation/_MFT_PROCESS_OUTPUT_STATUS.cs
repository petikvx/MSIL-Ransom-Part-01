using System;

namespace NAudio.MediaFoundation;

[Flags]
public enum _MFT_PROCESS_OUTPUT_STATUS
{
	None = 0,
	MFT_PROCESS_OUTPUT_STATUS_NEW_STREAMS = 0x100
}
