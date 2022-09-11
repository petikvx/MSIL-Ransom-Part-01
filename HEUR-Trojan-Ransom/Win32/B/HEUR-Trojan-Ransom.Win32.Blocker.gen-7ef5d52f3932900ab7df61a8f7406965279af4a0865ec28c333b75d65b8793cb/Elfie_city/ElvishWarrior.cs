using System;
using System.Collections.Generic;

namespace Elfie_city;

public class ElvishWarrior : ElvishUnit
{
	public static List<ElvishWarrior> ElvishList = new List<ElvishWarrior>();

	public static int TrainingTimeStandard = 10000;

	public new static int Damage = 2;

	public new static int HealthPoints = 25;

	public ElvishWarrior()
	{
		ElvishList.Add(this);
	}

	public static int[] TrainingCost()
	{
		return new int[6] { 20, 20, 20, 50, 0, 1 };
	}

	public static int TrainingTime()
	{
		return Convert.ToInt32((double)TrainingTimeStandard - (double)ElvishBuildings.LevelOfMartialArtsSchool * 5.0 / 100.0 * (double)TrainingTimeStandard + 1.0);
	}
}
