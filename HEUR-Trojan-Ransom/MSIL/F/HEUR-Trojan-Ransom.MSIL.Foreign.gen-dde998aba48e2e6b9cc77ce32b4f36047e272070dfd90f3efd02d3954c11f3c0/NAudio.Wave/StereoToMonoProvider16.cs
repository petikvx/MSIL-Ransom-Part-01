using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class StereoToMonoProvider16 : IWaveProvider
{
	private readonly IWaveProvider sourceProvider;

	private byte[] sourceBuffer;

	[NonSerialized]
	internal static GetString _0097;

	public float LeftVolume { get; set; }

	public float RightVolume { get; set; }

	public WaveFormat WaveFormat { get; private set; }

	public StereoToMonoProvider16(IWaveProvider sourceProvider)
	{
		if (sourceProvider.WaveFormat.Encoding != WaveFormatEncoding.Pcm)
		{
			throw new ArgumentException(_0097(107386929));
		}
		if (sourceProvider.WaveFormat.Channels != 2)
		{
			throw new ArgumentException(_0097(107386904));
		}
		if (sourceProvider.WaveFormat.BitsPerSample != 16)
		{
			throw new ArgumentException(_0097(107386875));
		}
		this.sourceProvider = sourceProvider;
		WaveFormat = new WaveFormat(sourceProvider.WaveFormat.SampleRate, 1);
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		int num = count * 2;
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, num);
		WaveBuffer waveBuffer = new WaveBuffer(sourceBuffer);
		WaveBuffer waveBuffer2 = new WaveBuffer(buffer);
		int num2 = sourceProvider.Read(sourceBuffer, 0, num);
		int num3 = num2 / 2;
		int num4 = offset / 2;
		for (int i = 0; i < num3; i += 2)
		{
			short num5 = waveBuffer.ShortBuffer[i];
			short num6 = waveBuffer.ShortBuffer[i + 1];
			float num7 = (float)num5 * LeftVolume + (float)num6 * RightVolume;
			if (num7 > 32767f)
			{
				num7 = 32767f;
			}
			if (num7 < -32768f)
			{
				num7 = -32768f;
			}
			waveBuffer2.ShortBuffer[num4++] = (short)num7;
		}
		return num2 / 2;
	}

	static StereoToMonoProvider16()
	{
		Strings.CreateGetStringDelegate(typeof(StereoToMonoProvider16));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0097(107398353), _0097(107398316)), _0097(107398311), _0097(107398306)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0097(107398333)))
		{
			return;
		}
		throw new SecurityException(_0097(107398276));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
