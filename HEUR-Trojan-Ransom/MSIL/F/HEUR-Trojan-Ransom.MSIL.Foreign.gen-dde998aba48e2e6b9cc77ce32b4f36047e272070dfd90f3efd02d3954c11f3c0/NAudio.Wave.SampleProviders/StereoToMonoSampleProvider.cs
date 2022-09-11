using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class StereoToMonoSampleProvider : ISampleProvider
{
	private readonly ISampleProvider sourceProvider;

	private float[] sourceBuffer;

	[NonSerialized]
	internal static GetString _0091;

	public float LeftVolume { get; set; }

	public float RightVolume { get; set; }

	public WaveFormat WaveFormat { get; private set; }

	public StereoToMonoSampleProvider(ISampleProvider sourceProvider)
	{
		LeftVolume = 0.5f;
		RightVolume = 0.5f;
		if (sourceProvider.WaveFormat.Channels != 2)
		{
			throw new ArgumentException(_0091(107387212));
		}
		this.sourceProvider = sourceProvider;
		WaveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sourceProvider.WaveFormat.SampleRate, 1);
	}

	public int Read(float[] buffer, int offset, int count)
	{
		int num = count * 2;
		if (sourceBuffer == null || sourceBuffer.Length < num)
		{
			sourceBuffer = new float[num];
		}
		int num2 = sourceProvider.Read(sourceBuffer, 0, num);
		int num3 = offset / 2;
		for (int i = 0; i < num2; i += 2)
		{
			float num4 = sourceBuffer[i];
			float num5 = sourceBuffer[i + 1];
			float num6 = num4 * LeftVolume + num5 * RightVolume;
			buffer[num3++] = num6;
		}
		return num2 / 2;
	}

	static StereoToMonoSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(StereoToMonoSampleProvider));
	}
}
