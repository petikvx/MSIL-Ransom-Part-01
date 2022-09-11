namespace NAudio.Wave.SampleProviders;

public sealed class Pcm32BitToSampleProvider : SampleProviderConverterBase
{
	public Pcm32BitToSampleProvider(IWaveProvider source)
		: base(source)
	{
	}

	public override int Read(float[] buffer, int offset, int count)
	{
		int num = count * 4;
		EnsureSourceBuffer(num);
		int num2 = source.Read(sourceBuffer, 0, num);
		int num3 = offset;
		for (int i = 0; i < num2; i += 4)
		{
			buffer[num3++] = (float)(((sbyte)sourceBuffer[i + 3] << 24) | (sourceBuffer[i + 2] << 16) | (sourceBuffer[i + 1] << 8) | sourceBuffer[i]) / 2.1474836E+09f;
		}
		return num2 / 4;
	}
}
