using System;

namespace NAudio.Wave.SampleProviders;

public sealed class Pcm16BitToSampleProvider : SampleProviderConverterBase
{
	public Pcm16BitToSampleProvider(IWaveProvider source)
		: base(source)
	{
	}

	public override int Read(float[] buffer, int offset, int count)
	{
		int num = count * 2;
		EnsureSourceBuffer(num);
		int num2 = source.Read(sourceBuffer, 0, num);
		int num3 = offset;
		for (int i = 0; i < num2; i += 2)
		{
			buffer[num3++] = (float)BitConverter.ToInt16(sourceBuffer, i) / 32768f;
		}
		return num2 / 2;
	}
}
