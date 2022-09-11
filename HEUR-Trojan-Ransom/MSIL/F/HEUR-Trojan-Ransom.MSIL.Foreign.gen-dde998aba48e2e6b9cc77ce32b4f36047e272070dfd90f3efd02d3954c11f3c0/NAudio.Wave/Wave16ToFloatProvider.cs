using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class Wave16ToFloatProvider : IWaveProvider
{
	private IWaveProvider sourceProvider;

	private readonly WaveFormat waveFormat;

	private volatile float volume;

	private byte[] sourceBuffer;

	[NonSerialized]
	internal static GetString _008F;

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

	public Wave16ToFloatProvider(IWaveProvider sourceProvider)
	{
		if (sourceProvider.WaveFormat.Encoding != WaveFormatEncoding.Pcm)
		{
			throw new ArgumentException(_008F(107386136));
		}
		if (sourceProvider.WaveFormat.BitsPerSample != 16)
		{
			throw new ArgumentException(_008F(107386111));
		}
		waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sourceProvider.WaveFormat.SampleRate, sourceProvider.WaveFormat.Channels);
		this.sourceProvider = sourceProvider;
		volume = 1f;
	}

	public int Read(byte[] destBuffer, int offset, int numBytes)
	{
		int num = numBytes / 2;
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, num);
		int num2 = sourceProvider.Read(sourceBuffer, offset, num);
		WaveBuffer waveBuffer = new WaveBuffer(sourceBuffer);
		WaveBuffer waveBuffer2 = new WaveBuffer(destBuffer);
		int num3 = num2 / 2;
		int num4 = offset / 4;
		for (int i = 0; i < num3; i++)
		{
			waveBuffer2.FloatBuffer[num4++] = (float)waveBuffer.ShortBuffer[i] / 32768f * volume;
		}
		return num3 * 4;
	}

	static Wave16ToFloatProvider()
	{
		Strings.CreateGetStringDelegate(typeof(Wave16ToFloatProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008F(107398372), _008F(107398335)), _008F(107398330), _008F(107398325)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008F(107398352)))
		{
			return;
		}
		throw new SecurityException(_008F(107398295));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
