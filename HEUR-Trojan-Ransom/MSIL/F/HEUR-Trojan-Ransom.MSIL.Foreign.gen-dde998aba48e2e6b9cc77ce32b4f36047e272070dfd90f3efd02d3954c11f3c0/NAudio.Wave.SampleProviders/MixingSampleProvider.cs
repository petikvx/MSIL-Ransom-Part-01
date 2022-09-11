using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class MixingSampleProvider : ISampleProvider
{
	private readonly List<ISampleProvider> sources;

	private float[] sourceBuffer;

	private const int MaxInputs = 1024;

	[NonSerialized]
	internal static GetString _0011;

	public IEnumerable<ISampleProvider> MixerInputs => sources;

	public bool ReadFully { get; set; }

	public WaveFormat WaveFormat { get; private set; }

	public event EventHandler<SampleProviderEventArgs> MixerInputEnded;

	public MixingSampleProvider(WaveFormat waveFormat)
	{
		if (waveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
		{
			throw new ArgumentException(_0011(107383315));
		}
		sources = new List<ISampleProvider>();
		WaveFormat = waveFormat;
	}

	public MixingSampleProvider(IEnumerable<ISampleProvider> sources)
	{
		this.sources = new List<ISampleProvider>();
		foreach (ISampleProvider source in sources)
		{
			AddMixerInput(source);
		}
		if (this.sources.Count == 0)
		{
			throw new ArgumentException(_0011(107383234));
		}
	}

	public void AddMixerInput(IWaveProvider mixerInput)
	{
		AddMixerInput(SampleProviderConverters.ConvertWaveProviderIntoSampleProvider(mixerInput));
	}

	public void AddMixerInput(ISampleProvider mixerInput)
	{
		lock (sources)
		{
			if (sources.Count >= 1024)
			{
				throw new InvalidOperationException(_0011(107383709));
			}
			sources.Add(mixerInput);
		}
		if (WaveFormat == null)
		{
			WaveFormat = mixerInput.WaveFormat;
		}
		else if (WaveFormat.SampleRate != mixerInput.WaveFormat.SampleRate || WaveFormat.Channels != mixerInput.WaveFormat.Channels)
		{
			throw new ArgumentException(_0011(107383648));
		}
	}

	public void RemoveMixerInput(ISampleProvider mixerInput)
	{
		lock (sources)
		{
			sources.Remove(mixerInput);
		}
	}

	public void RemoveAllMixerInputs()
	{
		lock (sources)
		{
			sources.Clear();
		}
	}

	public int Read(float[] buffer, int offset, int count)
	{
		int num = 0;
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, count);
		lock (sources)
		{
			for (int num2 = sources.Count - 1; num2 >= 0; num2--)
			{
				ISampleProvider sampleProvider = sources[num2];
				int num3 = sampleProvider.Read(sourceBuffer, 0, count);
				int num4 = offset;
				for (int i = 0; i < num3; i++)
				{
					if (i >= num)
					{
						buffer[num4++] = sourceBuffer[i];
					}
					else
					{
						buffer[num4++] += sourceBuffer[i];
					}
				}
				num = Math.Max(num3, num);
				if (num3 < count)
				{
					this.MixerInputEnded?.Invoke(this, new SampleProviderEventArgs(sampleProvider));
					sources.RemoveAt(num2);
				}
			}
		}
		if (ReadFully && num < count)
		{
			int num5 = offset + num;
			while (num5 < offset + count)
			{
				buffer[num5++] = 0f;
			}
			num = count;
		}
		return num;
	}

	static MixingSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(MixingSampleProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0011(107398705), _0011(107398668)), _0011(107398663), _0011(107398658)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0011(107398685)))
		{
			return;
		}
		throw new SecurityException(_0011(107398628));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
