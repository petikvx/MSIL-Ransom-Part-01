using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dsp;

public sealed class ImpulseResponseConvolution
{
	[NonSerialized]
	internal static GetString _009A;

	public float[] Convolve(float[] input, float[] impulseResponse)
	{
		float[] array = new float[input.Length + impulseResponse.Length];
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < impulseResponse.Length; j++)
			{
				if (i >= j && i - j < input.Length)
				{
					array[i] += impulseResponse[j] * input[i - j];
				}
			}
		}
		Normalize(array);
		return array;
	}

	public void Normalize(float[] data)
	{
		float num = 0f;
		for (int i = 0; i < data.Length; i++)
		{
			num = Math.Max(num, Math.Abs(data[i]));
		}
		if ((double)num > 1.0)
		{
			for (int j = 0; j < data.Length; j++)
			{
				data[j] /= num;
			}
		}
	}

	static ImpulseResponseConvolution()
	{
		Strings.CreateGetStringDelegate(typeof(ImpulseResponseConvolution));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009A(107400031), _009A(107399994)), _009A(107399989), _009A(107399984)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009A(107400011)))
		{
			return;
		}
		throw new SecurityException(_009A(107399954));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
