using System;
using NAudio.Wave;

namespace NAudio.Utils;

public static class WavePositionExtensions
{
	public static TimeSpan GetPositionTimeSpan(this IWavePosition @this)
	{
		return TimeSpan.FromMilliseconds((double)(@this.GetPosition() / (@this.OutputWaveFormat.Channels * @this.OutputWaveFormat.BitsPerSample / 8)) * 1000.0 / (double)@this.OutputWaveFormat.SampleRate);
	}
}
