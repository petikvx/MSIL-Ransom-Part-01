using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dsp;

public sealed class BiQuadFilter
{
	private double a0;

	private double a1;

	private double a2;

	private double a3;

	private double a4;

	private float x1;

	private float x2;

	private float y1;

	private float y2;

	[NonSerialized]
	internal static GetString _0002;

	public float Transform(float inSample)
	{
		double num = a0 * (double)inSample + a1 * (double)x1 + a2 * (double)x2 - a3 * (double)y1 - a4 * (double)y2;
		x2 = x1;
		x1 = inSample;
		y2 = y1;
		y1 = (float)num;
		return y1;
	}

	private void SetCoefficients(double aa0, double aa1, double aa2, double b0, double b1, double b2)
	{
		a0 = b0 / aa0;
		a1 = b1 / aa0;
		a2 = b2 / aa0;
		a3 = aa1 / aa0;
		a4 = aa2 / aa0;
	}

	public void SetLowPassFilter(float sampleRate, float cutoffFrequency, float q)
	{
		double num = Math.PI * 2.0 * (double)cutoffFrequency / (double)sampleRate;
		double num2 = Math.Cos(num);
		double num3 = Math.Sin(num) / (double)(2f * q);
		double b = (1.0 - num2) / 2.0;
		double b2 = 1.0 - num2;
		double b3 = (1.0 - num2) / 2.0;
		double aa = 1.0 + num3;
		double aa2 = -2.0 * num2;
		double aa3 = 1.0 - num3;
		SetCoefficients(aa, aa2, aa3, b, b2, b3);
	}

	public void SetPeakingEq(float sampleRate, float centreFrequency, float q, float dbGain)
	{
		double num = Math.PI * 2.0 * (double)centreFrequency / (double)sampleRate;
		double num2 = Math.Cos(num);
		double num3 = Math.Sin(num) / (double)(2f * q);
		double num4 = Math.Pow(10.0, dbGain / 40f);
		double b = 1.0 + num3 * num4;
		double b2 = -2.0 * num2;
		double b3 = 1.0 - num3 * num4;
		double aa = 1.0 + num3 / num4;
		double aa2 = -2.0 * num2;
		double aa3 = 1.0 - num3 / num4;
		SetCoefficients(aa, aa2, aa3, b, b2, b3);
	}

	public void SetHighPassFilter(float sampleRate, float cutoffFrequency, float q)
	{
		double num = Math.PI * 2.0 * (double)cutoffFrequency / (double)sampleRate;
		double num2 = Math.Cos(num);
		double num3 = Math.Sin(num) / (double)(2f * q);
		double b = (1.0 + num2) / 2.0;
		double b2 = 0.0 - (1.0 + num2);
		double b3 = (1.0 + num2) / 2.0;
		double aa = 1.0 + num3;
		double aa2 = -2.0 * num2;
		double aa3 = 1.0 - num3;
		SetCoefficients(aa, aa2, aa3, b, b2, b3);
	}

	public static BiQuadFilter LowPassFilter(float sampleRate, float cutoffFrequency, float q)
	{
		BiQuadFilter biQuadFilter = new BiQuadFilter();
		biQuadFilter.SetLowPassFilter(sampleRate, cutoffFrequency, q);
		return biQuadFilter;
	}

	public static BiQuadFilter HighPassFilter(float sampleRate, float cutoffFrequency, float q)
	{
		BiQuadFilter biQuadFilter = new BiQuadFilter();
		biQuadFilter.SetHighPassFilter(sampleRate, cutoffFrequency, q);
		return biQuadFilter;
	}

	public static BiQuadFilter BandPassFilterConstantSkirtGain(float sampleRate, float centreFrequency, float q)
	{
		double num = Math.PI * 2.0 * (double)centreFrequency / (double)sampleRate;
		double num2 = Math.Cos(num);
		double num3 = Math.Sin(num);
		double num4 = num3 / (double)(2f * q);
		double b = num3 / 2.0;
		int num5 = 0;
		double b2 = (0.0 - num3) / 2.0;
		double num6 = 1.0 + num4;
		double num7 = -2.0 * num2;
		double num8 = 1.0 - num4;
		return new BiQuadFilter(num6, num7, num8, b, num5, b2);
	}

	public static BiQuadFilter BandPassFilterConstantPeakGain(float sampleRate, float centreFrequency, float q)
	{
		double num = Math.PI * 2.0 * (double)centreFrequency / (double)sampleRate;
		double num2 = Math.Cos(num);
		double num3 = Math.Sin(num) / (double)(2f * q);
		double b = num3;
		int num4 = 0;
		double b2 = 0.0 - num3;
		double num5 = 1.0 + num3;
		double num6 = -2.0 * num2;
		double num7 = 1.0 - num3;
		return new BiQuadFilter(num5, num6, num7, b, num4, b2);
	}

	public static BiQuadFilter NotchFilter(float sampleRate, float centreFrequency, float q)
	{
		double num = Math.PI * 2.0 * (double)centreFrequency / (double)sampleRate;
		double num2 = Math.Cos(num);
		double num3 = Math.Sin(num) / (double)(2f * q);
		int num4 = 1;
		double b = -2.0 * num2;
		int num5 = 1;
		double num6 = 1.0 + num3;
		double num7 = -2.0 * num2;
		double num8 = 1.0 - num3;
		return new BiQuadFilter(num6, num7, num8, num4, b, num5);
	}

	public static BiQuadFilter AllPassFilter(float sampleRate, float centreFrequency, float q)
	{
		double num = Math.PI * 2.0 * (double)centreFrequency / (double)sampleRate;
		double num2 = Math.Cos(num);
		double num3 = Math.Sin(num) / (double)(2f * q);
		double b = 1.0 - num3;
		double b2 = -2.0 * num2;
		double b3 = 1.0 + num3;
		double num4 = 1.0 + num3;
		double num5 = -2.0 * num2;
		double num6 = 1.0 - num3;
		return new BiQuadFilter(num4, num5, num6, b, b2, b3);
	}

	public static BiQuadFilter PeakingEQ(float sampleRate, float centreFrequency, float q, float dbGain)
	{
		BiQuadFilter biQuadFilter = new BiQuadFilter();
		biQuadFilter.SetPeakingEq(sampleRate, centreFrequency, q, dbGain);
		return biQuadFilter;
	}

	public static BiQuadFilter LowShelf(float sampleRate, float cutoffFrequency, float shelfSlope, float dbGain)
	{
		double num = Math.PI * 2.0 * (double)cutoffFrequency / (double)sampleRate;
		double num2 = Math.Cos(num);
		double num3 = Math.Sin(num);
		double num4 = Math.Pow(10.0, dbGain / 40f);
		double num5 = num3 / 2.0 * Math.Sqrt((num4 + 1.0 / num4) * (double)(1f / shelfSlope - 1f) + 2.0);
		double num6 = 2.0 * Math.Sqrt(num4) * num5;
		double b = num4 * (num4 + 1.0 - (num4 - 1.0) * num2 + num6);
		double b2 = 2.0 * num4 * (num4 - 1.0 - (num4 + 1.0) * num2);
		double b3 = num4 * (num4 + 1.0 - (num4 - 1.0) * num2 - num6);
		double num7 = num4 + 1.0 + (num4 - 1.0) * num2 + num6;
		double num8 = -2.0 * (num4 - 1.0 + (num4 + 1.0) * num2);
		double num9 = num4 + 1.0 + (num4 - 1.0) * num2 - num6;
		return new BiQuadFilter(num7, num8, num9, b, b2, b3);
	}

	public static BiQuadFilter HighShelf(float sampleRate, float cutoffFrequency, float shelfSlope, float dbGain)
	{
		double num = Math.PI * 2.0 * (double)cutoffFrequency / (double)sampleRate;
		double num2 = Math.Cos(num);
		double num3 = Math.Sin(num);
		double num4 = Math.Pow(10.0, dbGain / 40f);
		double num5 = num3 / 2.0 * Math.Sqrt((num4 + 1.0 / num4) * (double)(1f / shelfSlope - 1f) + 2.0);
		double num6 = 2.0 * Math.Sqrt(num4) * num5;
		double b = num4 * (num4 + 1.0 + (num4 - 1.0) * num2 + num6);
		double b2 = -2.0 * num4 * (num4 - 1.0 + (num4 + 1.0) * num2);
		double b3 = num4 * (num4 + 1.0 + (num4 - 1.0) * num2 - num6);
		double num7 = num4 + 1.0 - (num4 - 1.0) * num2 + num6;
		double num8 = 2.0 * (num4 - 1.0 - (num4 + 1.0) * num2);
		double num9 = num4 + 1.0 - (num4 - 1.0) * num2 - num6;
		return new BiQuadFilter(num7, num8, num9, b, b2, b3);
	}

	private BiQuadFilter()
	{
		x1 = (x2 = 0f);
		y1 = (y2 = 0f);
	}

	private BiQuadFilter(double a0, double a1, double a2, double b0, double b1, double b2)
	{
		SetCoefficients(a0, a1, a2, b0, b1, b2);
		x1 = (x2 = 0f);
		y1 = (y2 = 0f);
	}

	static BiQuadFilter()
	{
		Strings.CreateGetStringDelegate(typeof(BiQuadFilter));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0002(107400021), _0002(107399984)), _0002(107399979), _0002(107399974)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0002(107400001)))
		{
			return;
		}
		throw new SecurityException(_0002(107399944));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
