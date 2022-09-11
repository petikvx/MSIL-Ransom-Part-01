using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Dsp;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class AdsrSampleProvider : ISampleProvider
{
	private readonly ISampleProvider source;

	private readonly EnvelopeGenerator adsr;

	private float attackSeconds;

	private float releaseSeconds;

	[NonSerialized]
	internal static GetString _0016;

	public float AttackSeconds
	{
		get
		{
			return attackSeconds;
		}
		set
		{
			attackSeconds = value;
			adsr.AttackRate = attackSeconds * (float)WaveFormat.SampleRate;
		}
	}

	public float ReleaseSeconds
	{
		get
		{
			return releaseSeconds;
		}
		set
		{
			releaseSeconds = value;
			adsr.ReleaseRate = releaseSeconds * (float)WaveFormat.SampleRate;
		}
	}

	public WaveFormat WaveFormat => source.WaveFormat;

	public AdsrSampleProvider(ISampleProvider source)
	{
		if (source.WaveFormat.Channels > 1)
		{
			throw new ArgumentException(_0016(107384177));
		}
		this.source = source;
		adsr = new EnvelopeGenerator();
		AttackSeconds = 0.01f;
		adsr.SustainLevel = 1f;
		adsr.DecayRate = 0f * (float)WaveFormat.SampleRate;
		ReleaseSeconds = 0.3f;
		adsr.Gate(gate: true);
	}

	public int Read(float[] buffer, int offset, int count)
	{
		if (adsr.State == EnvelopeGenerator.EnvelopeState.Idle)
		{
			return 0;
		}
		int num = source.Read(buffer, offset, count);
		for (int i = 0; i < num; i++)
		{
			buffer[offset++] *= adsr.Process();
		}
		return num;
	}

	public void Stop()
	{
		adsr.Gate(gate: false);
	}

	static AdsrSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(AdsrSampleProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0016(107398581), _0016(107398544)), _0016(107398539), _0016(107398534)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0016(107398561)))
		{
			return;
		}
		throw new SecurityException(_0016(107398504));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
