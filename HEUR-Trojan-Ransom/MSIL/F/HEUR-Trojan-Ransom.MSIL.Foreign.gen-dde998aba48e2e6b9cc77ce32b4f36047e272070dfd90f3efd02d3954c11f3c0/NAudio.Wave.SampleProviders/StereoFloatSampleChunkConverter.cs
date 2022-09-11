using NAudio.Utils;

namespace NAudio.Wave.SampleProviders;

internal sealed class StereoFloatSampleChunkConverter : ISampleChunkConverter
{
	private int sourceSample;

	private byte[] sourceBuffer;

	private WaveBuffer sourceWaveBuffer;

	private int sourceSamples;

	public bool Supports(WaveFormat waveFormat)
	{
		if (waveFormat.Encoding == WaveFormatEncoding.IeeeFloat)
		{
			return waveFormat.Channels == 2;
		}
		return false;
	}

	public void LoadNextChunk(IWaveProvider source, int samplePairsRequired)
	{
		int num = samplePairsRequired * 8;
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, num);
		sourceWaveBuffer = new WaveBuffer(sourceBuffer);
		sourceSamples = source.Read(sourceBuffer, 0, num) / 4;
		sourceSample = 0;
	}

	public bool GetNextSample(out float sampleLeft, out float sampleRight)
	{
		if (sourceSample < sourceSamples)
		{
			sampleLeft = sourceWaveBuffer.FloatBuffer[sourceSample++];
			sampleRight = sourceWaveBuffer.FloatBuffer[sourceSample++];
			return true;
		}
		sampleLeft = 0f;
		sampleRight = 0f;
		return false;
	}
}
