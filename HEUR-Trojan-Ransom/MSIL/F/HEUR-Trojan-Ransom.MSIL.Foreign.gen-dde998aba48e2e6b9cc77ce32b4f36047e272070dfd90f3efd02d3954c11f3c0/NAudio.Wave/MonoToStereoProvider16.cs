using System;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class MonoToStereoProvider16 : IWaveProvider
{
	private IWaveProvider sourceProvider;

	private WaveFormat outputFormat;

	private byte[] sourceBuffer;

	[NonSerialized]
	internal static GetString _000E;

	public float LeftVolume { get; set; }

	public float RightVolume { get; set; }

	public WaveFormat WaveFormat => outputFormat;

	public MonoToStereoProvider16(IWaveProvider sourceProvider)
	{
		if (sourceProvider.WaveFormat.Encoding != WaveFormatEncoding.Pcm)
		{
			throw new ArgumentException(_000E(107386935));
		}
		if (sourceProvider.WaveFormat.Channels != 1)
		{
			throw new ArgumentException(_000E(107386852));
		}
		if (sourceProvider.WaveFormat.BitsPerSample != 16)
		{
			throw new ArgumentException(_000E(107386881));
		}
		this.sourceProvider = sourceProvider;
		outputFormat = new WaveFormat(sourceProvider.WaveFormat.SampleRate, 2);
		RightVolume = 1f;
		LeftVolume = 1f;
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		int num = count / 2;
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, num);
		WaveBuffer waveBuffer = new WaveBuffer(sourceBuffer);
		WaveBuffer waveBuffer2 = new WaveBuffer(buffer);
		int num2 = sourceProvider.Read(sourceBuffer, 0, num) / 2;
		int num3 = offset / 2;
		for (int i = 0; i < num2; i++)
		{
			short num4 = waveBuffer.ShortBuffer[i];
			waveBuffer2.ShortBuffer[num3++] = (short)(LeftVolume * (float)num4);
			waveBuffer2.ShortBuffer[num3++] = (short)(RightVolume * (float)num4);
		}
		return num2 * 4;
	}

	static MonoToStereoProvider16()
	{
		Strings.CreateGetStringDelegate(typeof(MonoToStereoProvider16));
	}
}
