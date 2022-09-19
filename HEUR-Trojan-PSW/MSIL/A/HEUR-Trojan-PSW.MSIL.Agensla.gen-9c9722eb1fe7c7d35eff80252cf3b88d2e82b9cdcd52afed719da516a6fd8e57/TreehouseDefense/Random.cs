using System;

namespace TreehouseDefense;

internal static class Random
{
	private static System.Random _random = new System.Random();

	public static double NextDouble()
	{
		return _random.NextDouble();
	}
}
