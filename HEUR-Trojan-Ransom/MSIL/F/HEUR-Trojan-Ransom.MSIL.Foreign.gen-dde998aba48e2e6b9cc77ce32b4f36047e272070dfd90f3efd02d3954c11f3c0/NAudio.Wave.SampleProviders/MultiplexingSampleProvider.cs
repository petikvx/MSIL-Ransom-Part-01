using System;
using System.Collections.Generic;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class MultiplexingSampleProvider : ISampleProvider
{
	private readonly IList<ISampleProvider> inputs;

	private readonly WaveFormat waveFormat;

	private readonly int outputChannelCount;

	private readonly int inputChannelCount;

	private readonly List<int> mappings;

	private float[] inputBuffer;

	[NonSerialized]
	internal static GetString _0088;

	public WaveFormat WaveFormat => waveFormat;

	public int InputChannelCount => inputChannelCount;

	public int OutputChannelCount => outputChannelCount;

	public MultiplexingSampleProvider(IEnumerable<ISampleProvider> inputs, int numberOfOutputChannels)
	{
		this.inputs = new List<ISampleProvider>(inputs);
		outputChannelCount = numberOfOutputChannels;
		if (this.inputs.Count == 0)
		{
			throw new ArgumentException(_0088(107387501));
		}
		if (numberOfOutputChannels < 1)
		{
			throw new ArgumentException(_0088(107386908));
		}
		foreach (ISampleProvider input in this.inputs)
		{
			if (waveFormat == null)
			{
				if (input.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
				{
					throw new ArgumentException(_0088(107384542));
				}
				waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(input.WaveFormat.SampleRate, numberOfOutputChannels);
			}
			else
			{
				if (input.WaveFormat.BitsPerSample != waveFormat.BitsPerSample)
				{
					throw new ArgumentException(_0088(107386838));
				}
				if (input.WaveFormat.SampleRate != waveFormat.SampleRate)
				{
					throw new ArgumentException(_0088(107386753));
				}
			}
			inputChannelCount += input.WaveFormat.Channels;
		}
		mappings = new List<int>();
		for (int i = 0; i < outputChannelCount; i++)
		{
			mappings.Add(i % inputChannelCount);
		}
	}

	public int Read(float[] buffer, int offset, int count)
	{
		int num = count / outputChannelCount;
		int num2 = 0;
		int num3 = 0;
		foreach (ISampleProvider input in inputs)
		{
			int num4 = num * input.WaveFormat.Channels;
			inputBuffer = BufferHelpers.Ensure(inputBuffer, num4);
			int num5 = input.Read(inputBuffer, 0, num4);
			num3 = Math.Max(num3, num5 / input.WaveFormat.Channels);
			for (int i = 0; i < input.WaveFormat.Channels; i++)
			{
				int num6 = num2 + i;
				for (int j = 0; j < outputChannelCount; j++)
				{
					if (mappings[j] != num6)
					{
						continue;
					}
					int num7 = i;
					int num8 = offset + j;
					int k;
					for (k = 0; k < num; k++)
					{
						if (num7 >= num5)
						{
							break;
						}
						buffer[num8] = inputBuffer[num7];
						num8 += outputChannelCount;
						num7 += input.WaveFormat.Channels;
					}
					for (; k < num; k++)
					{
						buffer[num8] = 0f;
						num8 += outputChannelCount;
					}
				}
			}
			num2 += input.WaveFormat.Channels;
		}
		return num3 * outputChannelCount;
	}

	public void ConnectInputToOutput(int inputChannel, int outputChannel)
	{
		if (inputChannel < 0 || inputChannel >= InputChannelCount)
		{
			throw new ArgumentException(_0088(107387208));
		}
		if (outputChannel < 0 || outputChannel >= OutputChannelCount)
		{
			throw new ArgumentException(_0088(107387211));
		}
		mappings[outputChannel] = inputChannel;
	}

	static MultiplexingSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(MultiplexingSampleProvider));
	}
}
