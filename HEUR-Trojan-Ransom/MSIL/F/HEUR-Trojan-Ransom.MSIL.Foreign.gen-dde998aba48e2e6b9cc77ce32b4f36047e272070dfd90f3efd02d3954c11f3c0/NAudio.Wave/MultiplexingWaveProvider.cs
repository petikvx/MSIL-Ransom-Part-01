using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class MultiplexingWaveProvider : IWaveProvider
{
	private readonly IList<IWaveProvider> inputs;

	private readonly WaveFormat waveFormat;

	private readonly int outputChannelCount;

	private readonly int inputChannelCount;

	private readonly List<int> mappings;

	private readonly int bytesPerSample;

	private byte[] inputBuffer;

	[NonSerialized]
	internal static GetString _0096;

	public WaveFormat WaveFormat => waveFormat;

	public int InputChannelCount => inputChannelCount;

	public int OutputChannelCount => outputChannelCount;

	public MultiplexingWaveProvider(IEnumerable<IWaveProvider> inputs, int numberOfOutputChannels)
	{
		this.inputs = new List<IWaveProvider>(inputs);
		outputChannelCount = numberOfOutputChannels;
		if (this.inputs.Count == 0)
		{
			throw new ArgumentException(_0096(107387245));
		}
		if (numberOfOutputChannels < 1)
		{
			throw new ArgumentException(_0096(107386652));
		}
		foreach (IWaveProvider input in this.inputs)
		{
			if (waveFormat == null)
			{
				if (input.WaveFormat.Encoding == WaveFormatEncoding.Pcm)
				{
					waveFormat = new WaveFormat(input.WaveFormat.SampleRate, input.WaveFormat.BitsPerSample, numberOfOutputChannels);
				}
				else
				{
					if (input.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
					{
						throw new ArgumentException(_0096(107386635));
					}
					waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(input.WaveFormat.SampleRate, numberOfOutputChannels);
				}
			}
			else
			{
				if (input.WaveFormat.BitsPerSample != waveFormat.BitsPerSample)
				{
					throw new ArgumentException(_0096(107386582));
				}
				if (input.WaveFormat.SampleRate != waveFormat.SampleRate)
				{
					throw new ArgumentException(_0096(107386497));
				}
			}
			inputChannelCount += input.WaveFormat.Channels;
		}
		bytesPerSample = waveFormat.BitsPerSample / 8;
		mappings = new List<int>();
		for (int i = 0; i < outputChannelCount; i++)
		{
			mappings.Add(i % inputChannelCount);
		}
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		int num = bytesPerSample * outputChannelCount;
		int num2 = count / num;
		int num3 = 0;
		int num4 = 0;
		foreach (IWaveProvider input in inputs)
		{
			int num5 = bytesPerSample * input.WaveFormat.Channels;
			int num6 = num2 * num5;
			inputBuffer = BufferHelpers.Ensure(inputBuffer, num6);
			int num7 = input.Read(inputBuffer, 0, num6);
			num4 = Math.Max(num4, num7 / num5);
			for (int i = 0; i < input.WaveFormat.Channels; i++)
			{
				int num8 = num3 + i;
				for (int j = 0; j < outputChannelCount; j++)
				{
					if (mappings[j] != num8)
					{
						continue;
					}
					int num9 = i * bytesPerSample;
					int num10 = offset + j * bytesPerSample;
					int k;
					for (k = 0; k < num2; k++)
					{
						if (num9 >= num7)
						{
							break;
						}
						Array.Copy(inputBuffer, num9, buffer, num10, bytesPerSample);
						num10 += num;
						num9 += num5;
					}
					for (; k < num2; k++)
					{
						Array.Clear(buffer, num10, bytesPerSample);
						num10 += num;
					}
				}
			}
			num3 += input.WaveFormat.Channels;
		}
		return num4 * num;
	}

	public void ConnectInputToOutput(int inputChannel, int outputChannel)
	{
		if (inputChannel < 0 || inputChannel >= InputChannelCount)
		{
			throw new ArgumentException(_0096(107386952));
		}
		if (outputChannel < 0 || outputChannel >= OutputChannelCount)
		{
			throw new ArgumentException(_0096(107386955));
		}
		mappings[outputChannel] = inputChannel;
	}

	static MultiplexingWaveProvider()
	{
		Strings.CreateGetStringDelegate(typeof(MultiplexingWaveProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0096(107398346), _0096(107398309)), _0096(107398304), _0096(107398299)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0096(107398326)))
		{
			return;
		}
		throw new SecurityException(_0096(107398269));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
