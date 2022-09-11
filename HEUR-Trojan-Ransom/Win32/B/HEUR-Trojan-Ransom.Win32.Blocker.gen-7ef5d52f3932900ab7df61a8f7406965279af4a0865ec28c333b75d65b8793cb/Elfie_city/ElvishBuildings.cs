namespace Elfie_city;

internal static class ElvishBuildings
{
	public static int LevelOfHuntingBuilding = 1;

	public static int LevelOfWoodshet = 1;

	public static int LevelOfQuarry = 1;

	public static int LevelOfIronWorks = 1;

	public static int LevelOfCrystalMine = 0;

	public static int LevelOfHouses = 1;

	public static int LevelOfTemple = 0;

	public static int LevelOfElvishBuilding = 0;

	public static int LevelOfMartialArtsSchool = 0;

	public static int LevelOfInfrastructure = 1;

	public static int[] HuntingBuildingCost()
	{
		int num = LevelOfHuntingBuilding * 20;
		int num2 = (LevelOfHuntingBuilding + 1) * 15;
		int num3 = LevelOfHuntingBuilding * 10;
		int num4 = 0;
		if (LevelOfHuntingBuilding >= 20)
		{
			num = LevelOfHuntingBuilding * 30;
			num2 = (LevelOfHuntingBuilding + 1) * 20;
			num3 = LevelOfHuntingBuilding * 40;
			num4 = LevelOfHuntingBuilding - LevelOfTemple * 2;
		}
		return new int[4] { num, num2, num3, num4 };
	}

	public static int[] WoodshetCost()
	{
		int num = LevelOfWoodshet * 25;
		int num2 = (LevelOfWoodshet + 1) * 10;
		int num3 = 0;
		int num4 = 0;
		if (LevelOfWoodshet >= 3)
		{
			num3 = LevelOfWoodshet * 15;
		}
		if (LevelOfWoodshet >= 20 && LevelOfWoodshet < 30)
		{
			num = LevelOfWoodshet * 40;
			num2 = (LevelOfWoodshet + 1) * 20;
			num3 = LevelOfWoodshet * 30;
			num4 = LevelOfWoodshet - LevelOfTemple * 2;
		}
		if (LevelOfWoodshet >= 30)
		{
			num = LevelOfWoodshet * 50;
			num2 = (LevelOfWoodshet + 1) * 30;
			num3 = LevelOfWoodshet * 45;
			num4 = LevelOfWoodshet * 2 - LevelOfTemple * 2;
		}
		return new int[4] { num, num2, num3, num4 };
	}

	public static int[] QuarryCost()
	{
		int num = LevelOfQuarry * 25;
		int num2 = (LevelOfQuarry + 1) * 15;
		int num3 = 0;
		int num4 = 0;
		if (LevelOfQuarry >= 3 && LevelOfQuarry < 20)
		{
			num3 = LevelOfQuarry * 10;
		}
		if (LevelOfQuarry >= 20 && LevelOfQuarry < 30)
		{
			num = LevelOfQuarry * 45;
			num2 = (LevelOfQuarry + 1) * 35;
			num3 = LevelOfQuarry * 30;
			num4 = LevelOfQuarry - LevelOfTemple * 2;
		}
		if (LevelOfQuarry >= 30)
		{
			num = LevelOfQuarry * 60;
			num2 = (LevelOfQuarry + 1) * 50;
			num3 = LevelOfQuarry * 50;
			num4 = LevelOfQuarry * 2 - LevelOfTemple * 2;
		}
		return new int[4] { num, num2, num3, num4 };
	}

	public static int[] IronWorksCost()
	{
		int num = LevelOfIronWorks * 25;
		int num2 = (LevelOfIronWorks + 1) * 35;
		int num3 = LevelOfIronWorks * 30;
		int num4 = 0;
		if (LevelOfIronWorks >= 20 && LevelOfIronWorks < 30)
		{
			num = LevelOfIronWorks * 40;
			num2 = (LevelOfIronWorks + 1) * 60;
			num3 = LevelOfIronWorks * 50;
			num4 = LevelOfIronWorks - LevelOfTemple * 2;
		}
		if (LevelOfIronWorks >= 30)
		{
			num = LevelOfIronWorks * 50;
			num2 = (LevelOfIronWorks + 1) * 70;
			num3 = LevelOfIronWorks * 60;
			num4 = LevelOfIronWorks * 2 - LevelOfTemple * 2;
		}
		return new int[4] { num, num2, num3, num4 };
	}

	public static int[] CrystalMineCost()
	{
		int num = (LevelOfCrystalMine + 1) * 250;
		int num2 = (LevelOfCrystalMine + 1) * 250;
		int num3 = LevelOfCrystalMine * 300;
		int num4 = 0;
		if (LevelOfCrystalMine >= 10)
		{
			num = (LevelOfCrystalMine + 1) * 350;
			num2 = (LevelOfCrystalMine + 1) * 350;
			num3 = LevelOfCrystalMine * 400;
			num4 = LevelOfCrystalMine * 4 - LevelOfTemple * 2;
		}
		return new int[4] { num, num2, num3, num4 };
	}

	public static int[] HousesCost()
	{
		int num = LevelOfHouses * 30;
		int num2 = LevelOfHouses * 20;
		int num3 = LevelOfHouses * 10;
		int num4 = 0;
		if (LevelOfHouses >= 10)
		{
			num = LevelOfHouses * 60;
			num2 = (LevelOfHouses + 5) * 40;
			num3 = LevelOfHouses * 20;
		}
		if (LevelOfHouses >= 20)
		{
			num = LevelOfHouses * 80;
			num2 = (LevelOfHouses + 5) * 100;
			num3 = LevelOfHouses * 50;
			num4 = LevelOfHouses - LevelOfTemple * 2;
		}
		return new int[4] { num, num2, num3, num4 };
	}

	public static int[] TempleCost()
	{
		int num = (LevelOfTemple + 1) * 500;
		int num2 = (LevelOfTemple + 2) * 500;
		int num3 = (LevelOfTemple + 1) * 500;
		int num4 = 0;
		if (LevelOfTemple >= 5)
		{
			num4 = LevelOfTemple * 4;
		}
		return new int[4] { num, num2, num3, num4 };
	}

	public static int[] ElvishBuildingCost()
	{
		int num = (LevelOfElvishBuilding + 2) * 30;
		int num2 = (LevelOfElvishBuilding + 2) * 30;
		int num3 = (LevelOfElvishBuilding + 2) * 10;
		int num4 = 0;
		if (LevelOfElvishBuilding >= 10)
		{
			num = (LevelOfElvishBuilding + 2) * 50;
			num2 = (LevelOfElvishBuilding + 2) * 50;
			num3 = (LevelOfElvishBuilding + 2) * 20;
			num4 = LevelOfElvishBuilding - LevelOfTemple * 2;
		}
		if (LevelOfElvishBuilding >= 20)
		{
			num = (LevelOfElvishBuilding + 4) * 70;
			num2 = (LevelOfElvishBuilding + 4) * 70;
			num3 = (LevelOfElvishBuilding + 4) * 50;
			num4 = LevelOfElvishBuilding * 2 - LevelOfTemple * 2;
		}
		return new int[4] { num, num2, num3, num4 };
	}

	public static int[] MartialArtsSchoolCost()
	{
		int num = (LevelOfMartialArtsSchool + 5) * 15;
		int num2 = (LevelOfMartialArtsSchool + 10) * 15;
		int num3 = LevelOfMartialArtsSchool * 25;
		int num4 = 0;
		if (LevelOfMartialArtsSchool >= 10)
		{
			num = (LevelOfMartialArtsSchool + 10) * 25;
			num2 = (LevelOfMartialArtsSchool + 20) * 30;
			num3 = (LevelOfMartialArtsSchool + 10) * 35;
			num4 = LevelOfMartialArtsSchool * 2 - LevelOfTemple * 2;
		}
		return new int[4] { num, num2, num3, num4 };
	}

	public static int[] InfrastructureCost()
	{
		int num = (LevelOfInfrastructure + 40) * 10;
		int num2 = (LevelOfInfrastructure + 30) * 10;
		int num3 = LevelOfInfrastructure * 100;
		int num4 = 0;
		if (LevelOfInfrastructure >= 10)
		{
			num = LevelOfInfrastructure * 100;
			num2 = LevelOfInfrastructure * 120;
			num3 = LevelOfInfrastructure * 150;
			num4 = LevelOfInfrastructure * 2 - LevelOfTemple * 2;
		}
		return new int[4] { num, num2, num3, num4 };
	}
}
