using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class WaveToSampleProvider64 : SampleProviderConverterBase
{
	[NonSerialized]
	internal static GetString _0015;

	public WaveToSampleProvider64(IWaveProvider source)
		: base(source)
	{
		if (source.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
		{
			throw new ArgumentException(_0015(107383313));
		}
	}

	public override int Read(float[] buffer, int offset, int count)
	{
		int num = count * 8;
		EnsureSourceBuffer(num);
		int num2 = source.Read(sourceBuffer, 0, num);
		int result = num2 / 8;
		int num3 = offset;
		for (int i = 0; i < num2; i += 8)
		{
			long value = BitConverter.ToInt64(sourceBuffer, i);
			buffer[num3++] = (float)BitConverter.Int64BitsToDouble(value);
		}
		return result;
	}

	static WaveToSampleProvider64()
	{
		Strings.CreateGetStringDelegate(typeof(WaveToSampleProvider64));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0015(107398662), _0015(107398625)), _0015(107398620), _0015(107398615)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0015(107398642)))
		{
			return;
		}
		throw new SecurityException(_0015(107398585));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
