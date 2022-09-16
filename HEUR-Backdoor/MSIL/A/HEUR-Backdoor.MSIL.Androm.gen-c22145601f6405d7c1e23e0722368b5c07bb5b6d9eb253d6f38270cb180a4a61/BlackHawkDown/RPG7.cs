using System;

namespace BlackHawkDown;

internal class RPG7 : Firearm
{
	public RPG7(string Name)
	{
		name = Name;
		status = "created";
		firingmode = "safe";
		caliber = "40mm Grenade";
		Console.WriteLine("RPG7 " + name + " is " + status);
	}

	public void DestroyVec(Vehicles vec, string[,] AO)
	{
		if (vec.status != null)
		{
			Console.WriteLine(Owner.name + " shot " + vec.name);
			vec.destroyed(AO);
		}
	}
}
