using System;
using System.Collections.Generic;

namespace Elfie_city;

public class ElvishMaster : ElvishUnit
{
	public static List<ElvishMaster> ElvishList = new List<ElvishMaster>();

	public static int StandardTimeTraining = 50000;

	public new static int Damage = 10;

	public new static int HealthPoints = 100;

	public ElvishMaster()
	{
		ElvishList.Add(this);
	}

	public static int[] TrainingCost()
	{
		return new int[6] { 50, 250, 50, 250, 5, 5 };
	}

	public static int TrainingTime()
	{
		return Convert.ToInt32((double)StandardTimeTraining - (double)ElvishBuildings.LevelOfMartialArtsSchool * 5.0 / 100.0 * (double)StandardTimeTraining + 1.0);
	}
}
