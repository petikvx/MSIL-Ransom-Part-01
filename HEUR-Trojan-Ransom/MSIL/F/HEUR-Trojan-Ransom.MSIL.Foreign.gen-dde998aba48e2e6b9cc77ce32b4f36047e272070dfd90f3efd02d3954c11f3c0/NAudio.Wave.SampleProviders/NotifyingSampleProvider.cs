using System;

namespace NAudio.Wave.SampleProviders;

public sealed class NotifyingSampleProvider : ISampleProvider, ISampleNotifier
{
	private ISampleProvider source;

	private SampleEventArgs sampleArgs = new SampleEventArgs(0f, 0f);

	private int channels;

	public WaveFormat WaveFormat => source.WaveFormat;

	public event EventHandler<SampleEventArgs> Sample;

	public NotifyingSampleProvider(ISampleProvider source)
	{
		this.source = source;
		channels = WaveFormat.Channels;
	}

	public int Read(float[] buffer, int offset, int sampleCount)
	{
		int num = source.Read(buffer, offset, sampleCount);
		if (this.Sample != null)
		{
			for (int i = 0; i < num; i += channels)
			{
				sampleArgs.Left = buffer[offset + i];
				sampleArgs.Right = ((channels > 1) ? buffer[offset + i + 1] : sampleArgs.Left);
				this.Sample(this, sampleArgs);
			}
		}
		return num;
	}
}
