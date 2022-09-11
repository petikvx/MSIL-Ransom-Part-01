using System;

namespace Elfie_city;

internal static class OrcsAttack
{
	public static int battleCounter = 0;

	public static int[] BattleVsOrcs()
	{
		int num = ElvishArcher.ElvishList.Count * ElvishArcher.HealthPoints + ElvishWarrior.ElvishList.Count * ElvishWarrior.HealthPoints + ElvishMaster.ElvishList.Count * ElvishMaster.HealthPoints;
		int num2 = Convert.ToInt32(Math.Round((double)(ElvishArcher.ElvishList.Count * ElvishArcher.Damage + ElvishWarrior.ElvishList.Count * ElvishWarrior.Damage + ElvishMaster.ElvishList.Count * ElvishMaster.Damage) + (double)((ElvishArcher.ElvishList.Count * ElvishArcher.Damage + ElvishWarrior.ElvishList.Count * ElvishWarrior.Damage + ElvishMaster.ElvishList.Count * ElvishMaster.Damage) * ElvishBuildings.LevelOfTemple) * 0.1, 0));
		int num3 = OrcishCrossbowman.OrcishList.Count * OrcishCrossbowman.HealthPoints + OrcishWarrior.OrcishList.Count * OrcishWarrior.HealthPoints + OrcishCommander.OrcishList.Count * OrcishCommander.HealthPoints;
		int num4 = OrcishCrossbowman.OrcishList.Count * OrcishCrossbowman.Damage + OrcishWarrior.OrcishList.Count * OrcishWarrior.Damage + OrcishCommander.OrcishList.Count * OrcishCommander.Damage;
		int count = ElvishArcher.ElvishList.Count;
		int count2 = ElvishWarrior.ElvishList.Count;
		int count3 = ElvishMaster.ElvishList.Count;
		int num5 = 0;
		Random random = new Random();
		while (num >= 0 && num3 >= 0)
		{
			num -= num4;
			num3 -= num2;
		}
		if (num >= num3)
		{
			if (num >= ElvishArcher.HealthPoints || num >= ElvishWarrior.HealthPoints || num >= ElvishMaster.HealthPoints)
			{
				num5 = ElvishArcher.ElvishList.Count * ElvishArcher.HealthPoints + ElvishWarrior.ElvishList.Count * ElvishWarrior.HealthPoints + ElvishMaster.ElvishList.Count * ElvishMaster.HealthPoints - num;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				if (ElvishWarrior.ElvishList.Count > 0)
				{
					num6 = random.Next(0, num5 + 1);
					num6 /= ElvishWarrior.HealthPoints;
					if (num6 > ElvishWarrior.ElvishList.Count)
					{
						num6 = ElvishWarrior.ElvishList.Count;
					}
				}
				if (ElvishArcher.ElvishList.Count > 0)
				{
					num7 = random.Next(0, num5 + 1 - num6 + 1);
					num7 /= ElvishArcher.HealthPoints;
					if (num7 > ElvishArcher.ElvishList.Count)
					{
						num7 = ElvishArcher.ElvishList.Count;
					}
				}
				if (ElvishMaster.ElvishList.Count > 0)
				{
					num8 = random.Next(0, num5 + 1 - num6 - num7 + 1);
					num8 /= ElvishMaster.HealthPoints;
					if (num8 > ElvishMaster.ElvishList.Count)
					{
						num8 = ElvishMaster.ElvishList.Count;
					}
				}
				for (int num9 = num7; num9 > 0; num9--)
				{
					ElvishArcher.ElvishList.RemoveAt(ElvishArcher.ElvishList.Count - num9);
				}
				for (int num10 = num6; num10 > 0; num10--)
				{
					ElvishWarrior.ElvishList.RemoveAt(ElvishWarrior.ElvishList.Count - num10);
				}
				for (int num11 = num8; num11 > 0; num11--)
				{
					ElvishMaster.ElvishList.RemoveAt(ElvishMaster.ElvishList.Count - num11);
				}
				int[] result = new int[7]
				{
					1,
					OrcishCrossbowman.OrcishList.Count,
					OrcishWarrior.OrcishList.Count,
					OrcishCommander.OrcishList.Count,
					count - ElvishArcher.ElvishList.Count,
					count2 - ElvishWarrior.ElvishList.Count,
					count3 - ElvishMaster.ElvishList.Count
				};
				NextWave();
				return result;
			}
			ElvishArcher.ElvishList.Clear();
			ElvishWarrior.ElvishList.Clear();
			ElvishMaster.ElvishList.Clear();
			int[] result2 = new int[7]
			{
				2,
				OrcishCrossbowman.OrcishList.Count,
				OrcishWarrior.OrcishList.Count,
				OrcishCommander.OrcishList.Count,
				count,
				count2,
				count3
			};
			NextWave();
			return result2;
		}
		num5 = ElvishArcher.ElvishList.Count * ElvishArcher.HealthPoints + ElvishWarrior.ElvishList.Count * ElvishWarrior.HealthPoints + ElvishMaster.ElvishList.Count * ElvishMaster.HealthPoints - num;
		ElvishArcher.ElvishList.Clear();
		ElvishWarrior.ElvishList.Clear();
		ElvishMaster.ElvishList.Clear();
		int[] result3 = new int[7]
		{
			0,
			OrcishCrossbowman.OrcishList.Count,
			OrcishWarrior.OrcishList.Count,
			OrcishCommander.OrcishList.Count,
			count,
			count2,
			count3
		};
		plunder();
		return result3;
	}

	public static void NextWave()
	{
		Random random = new Random();
		battleCounter++;
		if (battleCounter == 1)
		{
			new OrcishWarrior();
			new OrcishCrossbowman();
		}
		if (battleCounter == 2)
		{
			new OrcishCommander();
		}
		if (battleCounter >= 3 && battleCounter < 10)
		{
			for (int i = 1; i <= random.Next(3, 7); i++)
			{
				new OrcishWarrior();
			}
			for (int j = 1; j <= random.Next(3, 7); j++)
			{
				new OrcishCrossbowman();
			}
			for (int k = 1; k <= random.Next(1, 3); k++)
			{
				new OrcishCommander();
			}
		}
		if (battleCounter >= 10)
		{
			for (int l = 1; l <= random.Next(7, 14); l++)
			{
				new OrcishWarrior();
			}
			for (int m = 1; m <= random.Next(7, 14); m++)
			{
				new OrcishCrossbowman();
			}
			for (int n = 1; n <= random.Next(3, 6); n++)
			{
				new OrcishCommander();
			}
		}
		if (battleCounter >= 16)
		{
			for (int num = 1; num <= random.Next(12, 20); num++)
			{
				new OrcishWarrior();
			}
			for (int num2 = 1; num2 <= random.Next(12, 20); num2++)
			{
				new OrcishCrossbowman();
			}
			for (int num3 = 1; num3 <= random.Next(4, 7); num3++)
			{
				new OrcishCommander();
			}
		}
	}

	public static void plunder()
	{
		if (battleCounter == 0)
		{
			Resources.ResourcesFood -= 20;
			Resources.ResourcesWood -= 20;
			Resources.ResoucresStone -= 20;
			Resources.ResoucresIron -= 20;
			Resources.ResourcesFood -= 40;
			Resources.Population -= 10;
		}
		if (battleCounter == 1 || battleCounter == 2)
		{
			Resources.ResourcesFood -= 70;
			Resources.ResourcesWood -= 50;
			Resources.ResoucresStone -= 50;
			Resources.ResoucresIron -= 50;
			Resources.ResoucresCrystals -= 20;
			Resources.Population -= 20;
		}
		if (battleCounter >= 3)
		{
			Resources.ResourcesFood -= 70 * battleCounter;
			Resources.ResourcesWood -= 50 * battleCounter;
			Resources.ResoucresStone -= 50 * battleCounter;
			Resources.ResoucresIron -= 50 * battleCounter;
			Resources.ResoucresCrystals -= 20 * battleCounter;
			Resources.Population -= 20 * battleCounter;
		}
		if (battleCounter >= 5)
		{
			Random random = new Random();
			int num = random.Next(1, 4);
			int num2 = random.Next(1, 3);
			if (num == 1)
			{
				ElvishBuildings.LevelOfHouses -= num2;
			}
			if (num == 2)
			{
				ElvishBuildings.LevelOfTemple -= num2;
			}
			if (num == 3)
			{
				ElvishBuildings.LevelOfElvishBuilding -= num2;
			}
		}
	}
}
