using System;

namespace NAudio.Wave.SampleProviders;

public sealed class MeteringSampleProvider : ISampleProvider
{
	private readonly ISampleProvider source;

	private readonly float[] maxSamples;

	private int sampleCount;

	private readonly int channels;

	private readonly StreamVolumeEventArgs args;

	public int SamplesPerNotification { get; set; }

	public WaveFormat WaveFormat => source.WaveFormat;

	public event EventHandler<StreamVolumeEventArgs> StreamVolume;

	public MeteringSampleProvider(ISampleProvider source)
		: this(source, source.WaveFormat.SampleRate / 10)
	{
	}

	public MeteringSampleProvider(ISampleProvider source, int samplesPerNotification)
	{
		this.source = source;
		channels = source.WaveFormat.Channels;
		maxSamples = new float[channels];
		SamplesPerNotification = samplesPerNotification;
		args = new StreamVolumeEventArgs
		{
			MaxSampleValues = maxSamples
		};
	}

	public int Read(float[] buffer, int offset, int count)
	{
		int num = source.Read(buffer, offset, count);
		if (this.StreamVolume != null)
		{
			for (int i = 0; i < num; i += channels)
			{
				for (int j = 0; j < channels; j++)
				{
					float val = Math.Abs(buffer[offset + i + j]);
					maxSamples[j] = Math.Max(maxSamples[j], val);
				}
				sampleCount++;
				if (sampleCount >= SamplesPerNotification)
				{
					this.StreamVolume(this, args);
					sampleCount = 0;
					Array.Clear(maxSamples, 0, channels);
				}
			}
		}
		return num;
	}
}
