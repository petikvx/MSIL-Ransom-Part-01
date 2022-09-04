using System.Runtime.InteropServices;

namespace CoreAudioApi.Interfaces;

[Guid("DD79923C-0599-45e0-B8B6-C8DF7DB6E796")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAudioPeakMeter
{
	int GetChannelCount(out int pcChannels);

	int GetLevel(int Channel, out float level);
}
