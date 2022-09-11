namespace NAudio.Wave.SampleProviders;

public sealed class Pcm8BitToSampleProvider : SampleProviderConverterBase
{
	public Pcm8BitToSampleProvider(IWaveProvider source)
		: base(source)
	{
	}

	public override int Read(float[] buffer, int offset, int count)
	{
		EnsureSourceBuffer(count);
		int num = source.Read(sourceBuffer, 0, count);
		int num2 = offset;
		for (int i = 0; i < num; i++)
		{
			buffer[num2++] = (float)(int)sourceBuffer[i] / 128f - 1f;
		}
		return num;
	}
}
