using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class SampleToWaveProvider : IWaveProvider
{
	private ISampleProvider source;

	[NonSerialized]
	internal static GetString _0013;

	public WaveFormat WaveFormat => source.WaveFormat;

	public SampleToWaveProvider(ISampleProvider source)
	{
		if (source.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
		{
			throw new ArgumentException(_0013(107383388));
		}
		this.source = source;
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		int count2 = count / 4;
		WaveBuffer waveBuffer = new WaveBuffer(buffer);
		return source.Read(waveBuffer.FloatBuffer, offset / 4, count2) * 4;
	}

	static SampleToWaveProvider()
	{
		Strings.CreateGetStringDelegate(typeof(SampleToWaveProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0013(107398737), _0013(107398700)), _0013(107398695), _0013(107398690)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0013(107398717)))
		{
			return;
		}
		throw new SecurityException(_0013(107398660));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
