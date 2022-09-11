using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dsp;

internal class AttRelEnvelope
{
	protected const double DC_OFFSET = 1E-25;

	private readonly EnvelopeDetector attack;

	private readonly EnvelopeDetector release;

	[NonSerialized]
	internal static GetString _0099;

	public double Attack
	{
		get
		{
			return attack.TimeConstant;
		}
		set
		{
			attack.TimeConstant = value;
		}
	}

	public double Release
	{
		get
		{
			return release.TimeConstant;
		}
		set
		{
			release.TimeConstant = value;
		}
	}

	public double SampleRate
	{
		get
		{
			return attack.SampleRate;
		}
		set
		{
			double num3 = (attack.SampleRate = (release.SampleRate = value));
		}
	}

	public AttRelEnvelope(double attackMilliseconds, double releaseMilliseconds, double sampleRate)
	{
		attack = new EnvelopeDetector(attackMilliseconds, sampleRate);
		release = new EnvelopeDetector(releaseMilliseconds, sampleRate);
	}

	public void Run(double inValue, ref double state)
	{
		if (inValue > state)
		{
			attack.Run(inValue, ref state);
		}
		else
		{
			release.Run(inValue, ref state);
		}
	}

	static AttRelEnvelope()
	{
		Strings.CreateGetStringDelegate(typeof(AttRelEnvelope));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0099(107400030), _0099(107399993)), _0099(107399988), _0099(107399983)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0099(107400010)))
		{
			return;
		}
		throw new SecurityException(_0099(107399953));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
