using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class WaveToSampleProvider : SampleProviderConverterBase
{
	[NonSerialized]
	internal static GetString _0019;

	public WaveToSampleProvider(IWaveProvider source)
		: base(source)
	{
		if (source.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
		{
			throw new ArgumentException(_0019(107383395));
		}
	}

	public override int Read(float[] buffer, int offset, int count)
	{
		int num = count * 4;
		EnsureSourceBuffer(num);
		int num2 = source.Read(sourceBuffer, 0, num);
		int result = num2 / 4;
		int num3 = offset;
		for (int i = 0; i < num2; i += 4)
		{
			buffer[num3++] = BitConverter.ToSingle(sourceBuffer, i);
		}
		return result;
	}

	static WaveToSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(WaveToSampleProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0019(107398744), _0019(107398707)), _0019(107398702), _0019(107398697)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0019(107398724)))
		{
			return;
		}
		throw new SecurityException(_0019(107398667));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
