using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dsp;

internal sealed class SimpleGate : AttRelEnvelope
{
	private double threshdB;

	private double thresh;

	private double env;

	[NonSerialized]
	internal static GetString _0097;

	public double Threshold
	{
		get
		{
			return threshdB;
		}
		set
		{
			threshdB = value;
			thresh = Decibels.DecibelsToLinear(value);
		}
	}

	public SimpleGate()
		: base(10.0, 10.0, 44100.0)
	{
		threshdB = 0.0;
		thresh = 1.0;
		env = 1E-25;
	}

	public void Process(ref double in1, ref double in2)
	{
		double val = Math.Abs(in1);
		double val2 = Math.Abs(in2);
		double num = ((Math.Max(val, val2) > thresh) ? 1.0 : 0.0);
		num += 1E-25;
		Run(num, ref env);
		num = env - 1E-25;
		in1 *= num;
		in2 *= num;
	}

	static SimpleGate()
	{
		Strings.CreateGetStringDelegate(typeof(SimpleGate));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0097(107400039), _0097(107400002)), _0097(107399997), _0097(107399992)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0097(107400019)))
		{
			return;
		}
		throw new SecurityException(_0097(107399962));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
