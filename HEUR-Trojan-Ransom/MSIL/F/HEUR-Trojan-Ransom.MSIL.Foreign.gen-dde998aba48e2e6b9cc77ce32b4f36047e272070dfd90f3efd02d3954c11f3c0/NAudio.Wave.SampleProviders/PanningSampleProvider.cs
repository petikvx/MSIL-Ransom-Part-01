using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class PanningSampleProvider : ISampleProvider
{
	private readonly ISampleProvider source;

	private float pan;

	private float leftMultiplier;

	private float rightMultiplier;

	private readonly WaveFormat waveFormat;

	private float[] sourceBuffer;

	private IPanStrategy panStrategy;

	[NonSerialized]
	internal static GetString _000E;

	public float Pan
	{
		get
		{
			return pan;
		}
		set
		{
			if (value < -1f || value > 1f)
			{
				throw new ArgumentOutOfRangeException(_000E(107391943), _000E(107383543));
			}
			pan = value;
			UpdateMultipliers();
		}
	}

	public IPanStrategy PanStrategy
	{
		get
		{
			return panStrategy;
		}
		set
		{
			panStrategy = value;
			UpdateMultipliers();
		}
	}

	public WaveFormat WaveFormat => waveFormat;

	public PanningSampleProvider(ISampleProvider source)
	{
		if (source.WaveFormat.Channels != 1)
		{
			throw new ArgumentException(_000E(107383624));
		}
		this.source = source;
		waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(source.WaveFormat.SampleRate, 2);
		panStrategy = new SinPanStrategy();
	}

	private void UpdateMultipliers()
	{
		StereoSamplePair multipliers = panStrategy.GetMultipliers(Pan);
		leftMultiplier = multipliers.Left;
		rightMultiplier = multipliers.Right;
	}

	public int Read(float[] buffer, int offset, int count)
	{
		int num = count / 2;
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, num);
		int num2 = source.Read(sourceBuffer, 0, num);
		int num3 = offset;
		for (int i = 0; i < num2; i++)
		{
			buffer[num3++] = leftMultiplier * sourceBuffer[i];
			buffer[num3++] = rightMultiplier * sourceBuffer[i];
		}
		return num2 * 2;
	}

	static PanningSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(PanningSampleProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _000E(107398714), _000E(107398677)), _000E(107398672), _000E(107398667)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _000E(107398694)))
		{
			return;
		}
		throw new SecurityException(_000E(107398637));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
