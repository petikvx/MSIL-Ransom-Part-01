using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

internal static class SampleProviderConverters
{
	[NonSerialized]
	internal static GetString _0018;

	public static ISampleProvider ConvertWaveProviderIntoSampleProvider(IWaveProvider waveProvider)
	{
		if (waveProvider.WaveFormat.Encoding == WaveFormatEncoding.Pcm)
		{
			if (waveProvider.WaveFormat.BitsPerSample == 8)
			{
				return new Pcm8BitToSampleProvider(waveProvider);
			}
			if (waveProvider.WaveFormat.BitsPerSample == 16)
			{
				return new Pcm16BitToSampleProvider(waveProvider);
			}
			if (waveProvider.WaveFormat.BitsPerSample == 24)
			{
				return new Pcm24BitToSampleProvider(waveProvider);
			}
			if (waveProvider.WaveFormat.BitsPerSample == 32)
			{
				return new Pcm32BitToSampleProvider(waveProvider);
			}
			throw new InvalidOperationException(_0018(107385124));
		}
		if (waveProvider.WaveFormat.Encoding == WaveFormatEncoding.IeeeFloat)
		{
			if (waveProvider.WaveFormat.BitsPerSample == 64)
			{
				return new WaveToSampleProvider64(waveProvider);
			}
			return new WaveToSampleProvider(waveProvider);
		}
		throw new ArgumentException(_0018(107384001));
	}

	static SampleProviderConverters()
	{
		Strings.CreateGetStringDelegate(typeof(SampleProviderConverters));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0018(107398614), _0018(107398577)), _0018(107398572), _0018(107398567)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0018(107398594)))
		{
			return;
		}
		throw new SecurityException(_0018(107398537));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
