using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class LinearPanStrategy : IPanStrategy
{
	[NonSerialized]
	internal static GetString _0088;

	public StereoSamplePair GetMultipliers(float pan)
	{
		float num = (0f - pan + 1f) / 2f;
		float left = num;
		float right = 1f - num;
		StereoSamplePair result = default(StereoSamplePair);
		result.Left = left;
		result.Right = right;
		return result;
	}

	static LinearPanStrategy()
	{
		Strings.CreateGetStringDelegate(typeof(LinearPanStrategy));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0088(107398719), _0088(107398682)), _0088(107398677), _0088(107398672)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0088(107398699)))
		{
			return;
		}
		throw new SecurityException(_0088(107398642));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
