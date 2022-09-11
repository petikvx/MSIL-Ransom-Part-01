using NAudio.Utils;

namespace NAudio.Wave.SampleProviders;

public abstract class SampleProviderConverterBase : ISampleProvider
{
	protected IWaveProvider source;

	private WaveFormat waveFormat;

	protected byte[] sourceBuffer;

	public WaveFormat WaveFormat => waveFormat;

	public SampleProviderConverterBase(IWaveProvider source)
	{
		this.source = source;
		waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(source.WaveFormat.SampleRate, source.WaveFormat.Channels);
	}

	public abstract int Read(float[] buffer, int offset, int count);

	protected void EnsureSourceBuffer(int sourceBytesRequired)
	{
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, sourceBytesRequired);
	}
}
