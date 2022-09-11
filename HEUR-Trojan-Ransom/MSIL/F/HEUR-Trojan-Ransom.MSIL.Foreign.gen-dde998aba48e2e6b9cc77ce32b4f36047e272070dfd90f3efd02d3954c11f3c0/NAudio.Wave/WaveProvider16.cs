using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public abstract class WaveProvider16 : IWaveProvider
{
	private WaveFormat waveFormat;

	[NonSerialized]
	internal static GetString _009C;

	public WaveFormat WaveFormat => waveFormat;

	public WaveProvider16()
		: this(44100, 1)
	{
	}

	public WaveProvider16(int sampleRate, int channels)
	{
		SetWaveFormat(sampleRate, channels);
	}

	public void SetWaveFormat(int sampleRate, int channels)
	{
		waveFormat = new WaveFormat(sampleRate, 16, channels);
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		WaveBuffer waveBuffer = new WaveBuffer(buffer);
		int sampleCount = count / 2;
		return Read(waveBuffer.ShortBuffer, offset / 2, sampleCount) * 2;
	}

	public abstract int Read(short[] buffer, int offset, int sampleCount);

	static WaveProvider16()
	{
		Strings.CreateGetStringDelegate(typeof(WaveProvider16));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009C(107398376), _009C(107398339)), _009C(107398334), _009C(107398329)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009C(107398356)))
		{
			return;
		}
		throw new SecurityException(_009C(107398299));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
