using NAudio.Dsp;

namespace NAudio.Wave.SampleProviders;

public sealed class WdlResamplingSampleProvider : ISampleProvider
{
	private readonly WdlResampler resampler;

	private readonly WaveFormat outFormat;

	private readonly ISampleProvider source;

	private readonly int channels;

	public WaveFormat WaveFormat => outFormat;

	public WdlResamplingSampleProvider(ISampleProvider source, int newSampleRate)
	{
		channels = source.WaveFormat.Channels;
		outFormat = WaveFormat.CreateIeeeFloatWaveFormat(newSampleRate, channels);
		this.source = source;
		resampler = new WdlResampler();
		resampler.SetMode(interp: true, 2, sinc: false);
		resampler.SetFilterParms();
		resampler.SetFeedMode(wantInputDriven: false);
		resampler.SetRates(source.WaveFormat.SampleRate, newSampleRate);
	}

	public int Read(float[] buffer, int offset, int count)
	{
		int num = count / channels;
		float[] inbuffer;
		int inbufferOffset;
		int num2 = resampler.ResamplePrepare(num, outFormat.Channels, out inbuffer, out inbufferOffset);
		int nsamples_in = source.Read(inbuffer, inbufferOffset, num2 * channels) / channels;
		return resampler.ResampleOut(buffer, offset, nsamples_in, num, channels) * channels;
	}
}
