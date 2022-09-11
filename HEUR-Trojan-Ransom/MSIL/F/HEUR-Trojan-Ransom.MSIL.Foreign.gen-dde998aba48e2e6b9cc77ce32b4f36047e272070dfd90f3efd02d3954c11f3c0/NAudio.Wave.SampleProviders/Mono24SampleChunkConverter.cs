using NAudio.Utils;

namespace NAudio.Wave.SampleProviders;

internal sealed class Mono24SampleChunkConverter : ISampleChunkConverter
{
	private int offset;

	private byte[] sourceBuffer;

	private int sourceBytes;

	public bool Supports(WaveFormat waveFormat)
	{
		if (waveFormat.Encoding == WaveFormatEncoding.Pcm && waveFormat.BitsPerSample == 24)
		{
			return waveFormat.Channels == 1;
		}
		return false;
	}

	public void LoadNextChunk(IWaveProvider source, int samplePairsRequired)
	{
		int num = samplePairsRequired * 3;
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, num);
		sourceBytes = source.Read(sourceBuffer, 0, num);
		offset = 0;
	}

	public bool GetNextSample(out float sampleLeft, out float sampleRight)
	{
		if (offset < sourceBytes)
		{
			sampleLeft = (float)(((sbyte)sourceBuffer[offset + 2] << 16) | (sourceBuffer[offset + 1] << 8) | sourceBuffer[offset]) / 8388608f;
			offset += 3;
			sampleRight = sampleLeft;
			return true;
		}
		sampleLeft = 0f;
		sampleRight = 0f;
		return false;
	}
}
