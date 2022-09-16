using System;

namespace BlackHawkDown;

internal class AK : Firearm
{
	public AK(string Name)
	{
		name = Name;
		status = "created";
		firingmode = "safe";
		caliber = "7.62x39";
		Console.WriteLine("AK " + name + " is " + status);
	}

	public override void changemode(int mode)
	{
		switch (mode)
		{
		case 0:
			firingmode = "safe";
			Console.WriteLine(Owner.name + " set " + name + " to " + firingmode);
			break;
		case 2:
			firingmode = "semi";
			Console.WriteLine(Owner.name + " set " + name + " to " + firingmode);
			break;
		case 3:
			firingmode = "auto";
			Console.WriteLine(Owner.name + " set " + name + " to " + firingmode);
			break;
		default:
			Console.WriteLine("Thats not a correct number");
			break;
		}
	}
}
