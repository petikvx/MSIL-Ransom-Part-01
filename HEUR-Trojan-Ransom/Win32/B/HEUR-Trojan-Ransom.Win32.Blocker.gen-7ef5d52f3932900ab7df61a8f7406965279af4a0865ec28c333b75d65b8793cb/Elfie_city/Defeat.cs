namespace Elfie_city;

internal static class Defeat
{
	public static bool EndBceauseOfLowPopulation()
	{
		if (Resources.Population < 10)
		{
			return true;
		}
		return false;
	}
}
