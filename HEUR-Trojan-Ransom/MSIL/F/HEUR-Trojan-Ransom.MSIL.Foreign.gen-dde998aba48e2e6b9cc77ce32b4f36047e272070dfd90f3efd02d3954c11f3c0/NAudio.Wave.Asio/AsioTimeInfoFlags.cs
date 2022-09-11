using System;

namespace NAudio.Wave.Asio;

[Flags]
internal enum AsioTimeInfoFlags
{
	kSystemTimeValid = 1,
	kSamplePositionValid = 2,
	kSampleRateValid = 4,
	kSpeedValid = 8,
	kSampleRateChanged = 0x10,
	kClockSourceChanged = 0x20
}
