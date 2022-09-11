using System;
using System.Collections.Generic;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class MixingWaveProvider32 : IWaveProvider
{
	private List<IWaveProvider> inputs;

	private WaveFormat waveFormat;

	private int bytesPerSample;

	[NonSerialized]
	internal static GetString _0092;

	public int InputCount => inputs.Count;

	public WaveFormat WaveFormat => waveFormat;

	public MixingWaveProvider32()
	{
		waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(44100, 2);
		bytesPerSample = 4;
		inputs = new List<IWaveProvider>();
	}

	public MixingWaveProvider32(IEnumerable<IWaveProvider> inputs)
		: this()
	{
		foreach (IWaveProvider input in inputs)
		{
			AddInputStream(input);
		}
	}

	public void AddInputStream(IWaveProvider waveProvider)
	{
		if (waveProvider.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
		{
			throw new ArgumentException(_0092(107387442), _0092(107387437));
		}
		if (waveProvider.WaveFormat.BitsPerSample != 32)
		{
			throw new ArgumentException(_0092(107387404), _0092(107387437));
		}
		if (inputs.Count == 0)
		{
			int sampleRate = waveProvider.WaveFormat.SampleRate;
			int channels = waveProvider.WaveFormat.Channels;
			waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channels);
		}
		else if (!waveProvider.WaveFormat.Equals(waveFormat))
		{
			throw new ArgumentException(_0092(107387319), _0092(107387437));
		}
		lock (inputs)
		{
			inputs.Add(waveProvider);
		}
	}

	public void RemoveInputStream(IWaveProvider waveProvider)
	{
		lock (inputs)
		{
			inputs.Remove(waveProvider);
		}
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		if (count % bytesPerSample != 0)
		{
			throw new ArgumentException(_0092(107387254), _0092(107387680));
		}
		Array.Clear(buffer, offset, count);
		int num = 0;
		byte[] array = new byte[count];
		lock (inputs)
		{
			foreach (IWaveProvider input in inputs)
			{
				int num2 = input.Read(array, 0, count);
				num = Math.Max(num, num2);
				if (num2 > 0)
				{
					Sum32BitAudio(buffer, offset, array, num2);
				}
			}
			return num;
		}
	}

	private unsafe static void Sum32BitAudio(byte[] destBuffer, int offset, byte[] sourceBuffer, int bytesRead)
	{
		fixed (byte* ptr = &destBuffer[offset])
		{
			fixed (byte* ptr3 = &sourceBuffer[0])
			{
				float* ptr2 = (float*)ptr;
				float* ptr4 = (float*)ptr3;
				int num = bytesRead / 4;
				for (int i = 0; i < num; i++)
				{
					ptr2[i] += ptr4[i];
				}
			}
		}
	}

	static MixingWaveProvider32()
	{
		Strings.CreateGetStringDelegate(typeof(MixingWaveProvider32));
	}
}
