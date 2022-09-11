using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class Pcm24BitToSampleProvider : SampleProviderConverterBase
{
	[NonSerialized]
	internal static GetString _0015;

	public Pcm24BitToSampleProvider(IWaveProvider source)
		: base(source)
	{
	}

	public override int Read(float[] buffer, int offset, int count)
	{
		int num = count * 3;
		EnsureSourceBuffer(num);
		int num2 = source.Read(sourceBuffer, 0, num);
		int num3 = offset;
		for (int i = 0; i < num2; i += 3)
		{
			buffer[num3++] = (float)(((sbyte)sourceBuffer[i + 2] << 16) | (sourceBuffer[i + 1] << 8) | sourceBuffer[i]) / 8388608f;
		}
		return num2 / 3;
	}

	static Pcm24BitToSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(Pcm24BitToSampleProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0015(107398745), _0015(107398708)), _0015(107398703), _0015(107398698)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0015(107398725)))
		{
			return;
		}
		throw new SecurityException(_0015(107398668));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
