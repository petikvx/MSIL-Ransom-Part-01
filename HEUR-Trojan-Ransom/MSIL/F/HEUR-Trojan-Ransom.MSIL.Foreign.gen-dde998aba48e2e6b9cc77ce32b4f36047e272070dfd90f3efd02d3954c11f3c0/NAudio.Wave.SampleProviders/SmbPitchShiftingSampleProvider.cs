using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Dsp;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class SmbPitchShiftingSampleProvider : ISampleProvider
{
	private readonly ISampleProvider sourceStream;

	private readonly WaveFormat waveFormat;

	private float pitch = 1f;

	private readonly int fftSize;

	private readonly long osamp;

	private readonly SmbPitchShifter shifterLeft = new SmbPitchShifter();

	private readonly SmbPitchShifter shifterRight = new SmbPitchShifter();

	private const float LIM_THRESH = 0.95f;

	private const float LIM_RANGE = 0.050000012f;

	private const float M_PI_2 = (float)Math.PI / 2f;

	[NonSerialized]
	internal static GetString _0092;

	public WaveFormat WaveFormat => waveFormat;

	public float PitchFactor
	{
		get
		{
			return pitch;
		}
		set
		{
			pitch = value;
		}
	}

	public SmbPitchShiftingSampleProvider(ISampleProvider sourceProvider)
		: this(sourceProvider, 4096, 4L, 1f)
	{
	}

	public SmbPitchShiftingSampleProvider(ISampleProvider sourceProvider, int fftSize, long osamp, float initialPitch)
	{
		sourceStream = sourceProvider;
		waveFormat = sourceProvider.WaveFormat;
		this.fftSize = fftSize;
		this.osamp = osamp;
		PitchFactor = initialPitch;
	}

	public int Read(float[] buffer, int offset, int count)
	{
		int num = sourceStream.Read(buffer, offset, count);
		if (pitch == 1f)
		{
			return num;
		}
		if (waveFormat.Channels == 1)
		{
			float[] array = new float[num];
			int num2 = 0;
			for (int i = offset; i <= num + offset - 1; i++)
			{
				array[num2] = buffer[i];
				num2++;
			}
			shifterLeft.PitchShift(pitch, num, fftSize, osamp, waveFormat.SampleRate, array);
			num2 = 0;
			for (int j = offset; j <= num + offset - 1; j++)
			{
				buffer[j] = Limiter(array[num2]);
				num2++;
			}
			return num;
		}
		if (waveFormat.Channels == 2)
		{
			float[] array2 = new float[num >> 1];
			float[] array3 = new float[num >> 1];
			int num3 = 0;
			for (int k = offset; k <= num + offset - 1; k += 2)
			{
				array2[num3] = buffer[k];
				array3[num3] = buffer[k + 1];
				num3++;
			}
			shifterLeft.PitchShift(pitch, num >> 1, fftSize, osamp, waveFormat.SampleRate, array2);
			shifterRight.PitchShift(pitch, num >> 1, fftSize, osamp, waveFormat.SampleRate, array3);
			num3 = 0;
			for (int l = offset; l <= num + offset - 1; l += 2)
			{
				buffer[l] = Limiter(array2[num3]);
				buffer[l + 1] = Limiter(array3[num3]);
				num3++;
			}
			return num;
		}
		throw new Exception(_0092(107383355));
	}

	private float Limiter(float sample)
	{
		if (0.95f < sample)
		{
			float num = (sample - 0.95f) / 0.050000012f;
			return (float)(Math.Atan(num) / 1.5707963705062866 * 0.050000011920928955 + 0.949999988079071);
		}
		if (sample < -0.95f)
		{
			float num = (0f - (sample + 0.95f)) / 0.050000012f;
			return 0f - (float)(Math.Atan(num) / 1.5707963705062866 * 0.050000011920928955 + 0.949999988079071);
		}
		return sample;
	}

	static SmbPitchShiftingSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(SmbPitchShiftingSampleProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0092(107398655), _0092(107398618)), _0092(107398613), _0092(107398608)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0092(107398635)))
		{
			return;
		}
		throw new SecurityException(_0092(107398578));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
