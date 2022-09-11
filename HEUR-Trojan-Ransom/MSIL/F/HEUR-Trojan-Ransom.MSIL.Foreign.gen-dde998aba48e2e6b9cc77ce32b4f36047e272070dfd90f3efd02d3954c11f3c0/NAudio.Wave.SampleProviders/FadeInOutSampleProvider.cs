using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class FadeInOutSampleProvider : ISampleProvider
{
	private enum FadeState
	{
		Silence,
		FadingIn,
		FullVolume,
		FadingOut
	}

	private readonly object lockObject = new object();

	private readonly ISampleProvider source;

	private int fadeSamplePosition;

	private int fadeSampleCount;

	private FadeState fadeState;

	[NonSerialized]
	internal static GetString _008F;

	public WaveFormat WaveFormat => source.WaveFormat;

	public FadeInOutSampleProvider(ISampleProvider source, bool initiallySilent = false)
	{
		this.source = source;
		fadeState = ((!initiallySilent) ? FadeState.FullVolume : FadeState.Silence);
	}

	public void BeginFadeIn(double fadeDurationInMilliseconds)
	{
		lock (lockObject)
		{
			fadeSamplePosition = 0;
			fadeSampleCount = (int)(fadeDurationInMilliseconds * (double)source.WaveFormat.SampleRate / 1000.0);
			fadeState = FadeState.FadingIn;
		}
	}

	public void BeginFadeOut(double fadeDurationInMilliseconds)
	{
		lock (lockObject)
		{
			fadeSamplePosition = 0;
			fadeSampleCount = (int)(fadeDurationInMilliseconds * (double)source.WaveFormat.SampleRate / 1000.0);
			fadeState = FadeState.FadingOut;
		}
	}

	public int Read(float[] buffer, int offset, int count)
	{
		int num = source.Read(buffer, offset, count);
		lock (lockObject)
		{
			if (fadeState == FadeState.FadingIn)
			{
				FadeIn(buffer, offset, num);
				return num;
			}
			if (fadeState == FadeState.FadingOut)
			{
				FadeOut(buffer, offset, num);
				return num;
			}
			if (fadeState == FadeState.Silence)
			{
				ClearBuffer(buffer, offset, count);
				return num;
			}
			return num;
		}
	}

	private static void ClearBuffer(float[] buffer, int offset, int count)
	{
		for (int i = 0; i < count; i++)
		{
			buffer[i + offset] = 0f;
		}
	}

	private void FadeOut(float[] buffer, int offset, int sourceSamplesRead)
	{
		int num = 0;
		while (num < sourceSamplesRead)
		{
			float num2 = 1f - (float)fadeSamplePosition / (float)fadeSampleCount;
			for (int i = 0; i < source.WaveFormat.Channels; i++)
			{
				buffer[offset + num++] *= num2;
			}
			fadeSamplePosition++;
			if (fadeSamplePosition > fadeSampleCount)
			{
				fadeState = FadeState.Silence;
				ClearBuffer(buffer, num + offset, sourceSamplesRead - num);
				break;
			}
		}
	}

	private void FadeIn(float[] buffer, int offset, int sourceSamplesRead)
	{
		int num = 0;
		while (num < sourceSamplesRead)
		{
			float num2 = (float)fadeSamplePosition / (float)fadeSampleCount;
			for (int i = 0; i < source.WaveFormat.Channels; i++)
			{
				buffer[offset + num++] *= num2;
			}
			fadeSamplePosition++;
			if (fadeSamplePosition > fadeSampleCount)
			{
				fadeState = FadeState.FullVolume;
				break;
			}
		}
	}

	static FadeInOutSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(FadeInOutSampleProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008F(107398590), _008F(107398553)), _008F(107398548), _008F(107398543)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008F(107398570)))
		{
			return;
		}
		throw new SecurityException(_008F(107398513));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
