using System;

namespace BlackHawkDown;

internal class Firearm
{
	public Person Owner;

	public string name;

	public string status;

	public int coordinatex;

	public int coordinatey;

	public string firingmode;

	public string caliber;

	public void shoot(Person target, string[,] AO)
	{
		if (Owner.primarygun.firingmode == "safe")
		{
			Owner.primarygun.changemode(2);
		}
		if (target.status != "KIA")
		{
			Console.WriteLine(Owner.name + " shot " + target.name);
			target.KIA(AO);
		}
		else
		{
			Console.WriteLine(target.name + " is already KIA");
		}
	}

	public void reload()
	{
	}

	public virtual void changemode(int mode)
	{
		if (mode == 0)
		{
			firingmode = "safe";
			Console.WriteLine(Owner.name + " set " + name + " to " + firingmode);
		}
		else
		{
			firingmode = "semi";
			Console.WriteLine(Owner.name + " set " + name + " to " + firingmode);
		}
	}
}
