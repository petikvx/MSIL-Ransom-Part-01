using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public sealed class ImaAdpcmWaveFormat : WaveFormat
{
	private short samplesPerBlock;

	[NonSerialized]
	internal static GetString _008D;

	private ImaAdpcmWaveFormat()
	{
	}

	public ImaAdpcmWaveFormat(int sampleRate, int channels, int bitsPerSample)
	{
		waveFormatTag = WaveFormatEncoding.DviAdpcm;
		base.sampleRate = sampleRate;
		base.channels = (short)channels;
		base.bitsPerSample = (short)bitsPerSample;
		extraSize = 2;
		blockAlign = 0;
		averageBytesPerSecond = 0;
		samplesPerBlock = 0;
	}

	static ImaAdpcmWaveFormat()
	{
		Strings.CreateGetStringDelegate(typeof(ImaAdpcmWaveFormat));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008D(107397901), _008D(107397864)), _008D(107397859), _008D(107397854)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008D(107397881)))
		{
			return;
		}
		throw new SecurityException(_008D(107397824));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
