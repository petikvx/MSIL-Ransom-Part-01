using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class SampleChannel : ISampleProvider
{
	private readonly VolumeSampleProvider volumeProvider;

	private readonly MeteringSampleProvider preVolumeMeter;

	private readonly WaveFormat waveFormat;

	[NonSerialized]
	internal static GetString _0091;

	public WaveFormat WaveFormat => waveFormat;

	public float Volume
	{
		get
		{
			return volumeProvider.Volume;
		}
		set
		{
			volumeProvider.Volume = value;
		}
	}

	public event EventHandler<StreamVolumeEventArgs> PreVolumeMeter
	{
		add
		{
			preVolumeMeter.StreamVolume += value;
		}
		remove
		{
			preVolumeMeter.StreamVolume -= value;
		}
	}

	public SampleChannel(IWaveProvider waveProvider)
		: this(waveProvider, forceStereo: false)
	{
	}

	public SampleChannel(IWaveProvider waveProvider, bool forceStereo)
	{
		ISampleProvider sampleProvider = SampleProviderConverters.ConvertWaveProviderIntoSampleProvider(waveProvider);
		if (sampleProvider.WaveFormat.Channels == 1 && forceStereo)
		{
			sampleProvider = new MonoToStereoSampleProvider(sampleProvider);
		}
		waveFormat = sampleProvider.WaveFormat;
		preVolumeMeter = new MeteringSampleProvider(sampleProvider);
		volumeProvider = new VolumeSampleProvider(preVolumeMeter);
	}

	public int Read(float[] buffer, int offset, int sampleCount)
	{
		return volumeProvider.Read(buffer, offset, sampleCount);
	}

	static SampleChannel()
	{
		Strings.CreateGetStringDelegate(typeof(SampleChannel));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0091(107398749), _0091(107398712)), _0091(107398707), _0091(107398702)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0091(107398729)))
		{
			return;
		}
		throw new SecurityException(_0091(107398672));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
