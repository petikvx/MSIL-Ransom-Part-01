using System;

namespace NAudio.CoreAudioApi;

[Flags]
public enum AudioClientStreamFlags
{
	None = 0,
	CrossProcess = 0x10000,
	Loopback = 0x20000,
	EventCallback = 0x40000,
	NoPersist = 0x80000
}
