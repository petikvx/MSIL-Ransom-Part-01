using System;

namespace NAudio.Utils;

public sealed class Decibels
{
	private const double LOG_2_DB = 8.685889638065037;

	private const double DB_2_LOG = 0.11512925464970228;

	public static double LinearToDecibels(double lin)
	{
		return Math.Log(lin) * 8.685889638065037;
	}

	public static double DecibelsToLinear(double dB)
	{
		return Math.Exp(dB * 0.11512925464970228);
	}
}
