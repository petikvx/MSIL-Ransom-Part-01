using System;

namespace BirdHuntingGame.Code;

public static class Extensions
{
	private static Random RandomTicker = new Random();

	public static int GetRandomInterval()
	{
		return RandomTicker.Next(5, 100);
	}

	public static int GetRandomNumber()
	{
		return RandomTicker.Next(10, 25);
	}

	public static int GetLimitedRandomNumber(int Min, int Max)
	{
		return RandomTicker.Next(Min, Max);
	}
}
