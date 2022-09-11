using System;
using System.Security.Cryptography;

namespace RandomRansom;

public static class RandomNumber
{
	private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

	public static int Between(int minimumValue, int maximumValue)
	{
		byte[] array = new byte[1];
		_generator.GetBytes(array);
		double num = Convert.ToDouble(array[0]);
		double num2 = Math.Max(0.0, num / 255.0 - 1E-11);
		int num3 = maximumValue - minimumValue + 1;
		double num4 = Math.Floor(num2 * (double)num3);
		return (int)((double)minimumValue + num4);
	}
}
