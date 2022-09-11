using System;

namespace Elfie_city;

internal static class Resources
{
	public static int ResourcesFood = 100;

	public static int ResourcesWood = 100;

	public static int ResoucresStone = 100;

	public static int ResoucresCrystals = 0;

	public static int ResoucresIron = 100;

	public static int Population = 10;

	public static int FoodGrowth()
	{
		double a = ElvishBuildings.LevelOfHuntingBuilding * 8 + ElvishBuildings.LevelOfHuntingBuilding * 8 * ElvishBuildings.LevelOfInfrastructure / 10 - Population;
		return Convert.ToInt32(Math.Round(a));
	}

	public static int WoodGrowth()
	{
		double a = ElvishBuildings.LevelOfWoodshet * 3 + ElvishBuildings.LevelOfWoodshet * 3 * ElvishBuildings.LevelOfInfrastructure / 10;
		if (ElvishBuildings.LevelOfWoodshet >= 15)
		{
			a = ElvishBuildings.LevelOfWoodshet * 4 + ElvishBuildings.LevelOfWoodshet * 4 * ElvishBuildings.LevelOfInfrastructure / 10;
		}
		return Convert.ToInt32(Math.Round(a));
	}

	public static int StoneGrowth()
	{
		double a = ElvishBuildings.LevelOfQuarry * 2 + ElvishBuildings.LevelOfQuarry * 2 * ElvishBuildings.LevelOfInfrastructure / 10;
		if (ElvishBuildings.LevelOfQuarry >= 15)
		{
			a = ElvishBuildings.LevelOfQuarry * 3 + ElvishBuildings.LevelOfQuarry * 3 * ElvishBuildings.LevelOfInfrastructure / 10;
		}
		return Convert.ToInt32(Math.Round(a));
	}

	public static int IronGrowth()
	{
		double a = ElvishBuildings.LevelOfIronWorks * 2 + ElvishBuildings.LevelOfIronWorks * 2 * ElvishBuildings.LevelOfInfrastructure / 10;
		if (ElvishBuildings.LevelOfIronWorks >= 15)
		{
			a = ElvishBuildings.LevelOfIronWorks * 3 + ElvishBuildings.LevelOfIronWorks * 3 * ElvishBuildings.LevelOfInfrastructure / 10;
		}
		return Convert.ToInt32(Math.Round(a));
	}

	public static int CrystalsGrowth()
	{
		double a = ElvishBuildings.LevelOfCrystalMine + ElvishBuildings.LevelOfCrystalMine * ElvishBuildings.LevelOfInfrastructure / 10;
		return Convert.ToInt32(Math.Round(a));
	}

	public static int PopulationGrowth()
	{
		if (ElvishBuildings.LevelOfHouses * 10 > Population && ResourcesFood > 0)
		{
			double value = (ElvishBuildings.LevelOfHouses + ElvishBuildings.LevelOfInfrastructure + ElvishBuildings.LevelOfTemple + ElvishBuildings.LevelOfElvishBuilding) / 4;
			if (Convert.ToInt32(Math.Round(value, 0)) + Population > ElvishBuildings.LevelOfHouses * 10)
			{
				return ElvishBuildings.LevelOfHouses * 10 - Population;
			}
			return Convert.ToInt32(Math.Round(value, 0));
		}
		if (ResourcesFood <= 0 && Population >= 50)
		{
			return -Convert.ToInt32(Math.Round((double)Population * 0.1));
		}
		if (ResourcesFood <= 0 && Population < 50)
		{
			return -1;
		}
		return 0;
	}
}
