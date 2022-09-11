using System;
using System.Collections.Generic;

namespace Elfie_city;

public class ElvishArcher : ElvishUnit
{
	public static List<ElvishArcher> ElvishList = new List<ElvishArcher>();

	public static int TrainingTimeStandart = 10000;

	public new static int Damage = 4;

	public new static int HealthPoints = 12;

	public ElvishArcher()
	{
		ElvishList.Add(this);
	}

	public static int[] TrainingCost()
	{
		return new int[6] { 20, 50, 20, 30, 0, 1 };
	}

	public static int TrainingTime()
	{
		return Convert.ToInt32((double)TrainingTimeStandart - (double)ElvishBuildings.LevelOfMartialArtsSchool * 5.0 / 100.0 * (double)TrainingTimeStandart + 1.0);
	}
}
