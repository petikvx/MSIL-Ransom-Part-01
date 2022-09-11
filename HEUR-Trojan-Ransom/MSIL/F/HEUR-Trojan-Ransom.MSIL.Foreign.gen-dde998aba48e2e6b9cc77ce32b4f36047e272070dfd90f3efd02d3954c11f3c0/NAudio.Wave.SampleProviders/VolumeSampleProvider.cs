using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class VolumeSampleProvider : ISampleProvider
{
	private readonly ISampleProvider source;

	private float volume;

	[NonSerialized]
	internal static GetString _0008;

	public WaveFormat WaveFormat => source.WaveFormat;

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

	public VolumeSampleProvider(ISampleProvider source)
	{
		this.source = source;
		volume = 1f;
	}

	public int Read(float[] buffer, int offset, int sampleCount)
	{
		int result = source.Read(buffer, offset, sampleCount);
		if (volume != 1f)
		{
			for (int i = 0; i < sampleCount; i++)
			{
				buffer[offset + i] *= volume;
			}
		}
		return result;
	}

	static VolumeSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(VolumeSampleProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0008(107398735), _0008(107398698)), _0008(107398693), _0008(107398688)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0008(107398715)))
		{
			return;
		}
		throw new SecurityException(_0008(107398658));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
