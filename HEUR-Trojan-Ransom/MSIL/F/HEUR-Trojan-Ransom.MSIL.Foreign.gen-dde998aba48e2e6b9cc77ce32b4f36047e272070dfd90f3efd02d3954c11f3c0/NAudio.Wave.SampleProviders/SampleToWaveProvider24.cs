using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class SampleToWaveProvider24 : IWaveProvider
{
	private readonly ISampleProvider sourceProvider;

	private readonly WaveFormat waveFormat;

	private volatile float volume;

	private float[] sourceBuffer;

	[NonSerialized]
	internal static GetString _008D;

	public WaveFormat WaveFormat => waveFormat;

	public float Volume
	{
		get
		{
			return volume;
		}
		set
		{
			volume = value;
		}
	}

	public SampleToWaveProvider24(ISampleProvider sourceProvider)
	{
		if (sourceProvider.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
		{
			throw new ArgumentException(_008D(107383974), _008D(107388015));
		}
		if (sourceProvider.WaveFormat.BitsPerSample != 32)
		{
			throw new ArgumentException(_008D(107383405), _008D(107388015));
		}
		waveFormat = new WaveFormat(sourceProvider.WaveFormat.SampleRate, 24, sourceProvider.WaveFormat.Channels);
		this.sourceProvider = sourceProvider;
		volume = 1f;
	}

	public int Read(byte[] destBuffer, int offset, int numBytes)
	{
		int num = numBytes / 3;
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, num);
		int num2 = sourceProvider.Read(sourceBuffer, 0, num);
		int num3 = offset;
		for (int i = 0; i < num2; i++)
		{
			float num4 = sourceBuffer[i] * volume;
			if (num4 > 1f)
			{
				num4 = 1f;
			}
			if (num4 < -1f)
			{
				num4 = -1f;
			}
			int num5 = (int)((double)num4 * 8388607.0);
			destBuffer[num3++] = (byte)num5;
			destBuffer[num3++] = (byte)(num5 >> 8);
			destBuffer[num3++] = (byte)(num5 >> 16);
		}
		return num2 * 3;
	}

	static SampleToWaveProvider24()
	{
		Strings.CreateGetStringDelegate(typeof(SampleToWaveProvider24));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008D(107398624), _008D(107398587)), _008D(107398582), _008D(107398577)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008D(107398604)))
		{
			return;
		}
		throw new SecurityException(_008D(107398547));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
