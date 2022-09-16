using System;

namespace BlackHawkDown;

internal class Person
{
	public string name;

	public string status;

	public int coordinatex;

	public int coordinatey;

	public Vehicles myvec;

	public Firearm primarygun;

	public void move(int x, int y, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				AO[coordinatex, coordinatey] = "";
				coordinatex = x;
				coordinatey = y;
				AO[x, y] = name ?? "";
				Console.WriteLine($"{name} is moving to coordinates {x},{y}");
			}
			else
			{
				Console.WriteLine("unable to move " + name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void MountBlackHawkOperator(Blackhawk hawk, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				hawk.mountO(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(status + " is KIA");
		}
	}

	public void DismountBlackHawkOperator(Blackhawk hawk, string[,] AO)
	{
		if (status != "KIA")
		{
			if (name == hawk.Operator.name)
			{
				hawk.dismountO(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not in the operator seat of " + hawk.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void MountBlackHawkAOperator(Blackhawk hawk, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				hawk.mountA(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void DismountBlackHawkAOperator(Blackhawk hawk, string[,] AO)
	{
		if (status != "KIA")
		{
			if (name == hawk.AOperator.name)
			{
				hawk.dismountA(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not in the A driver seat of " + hawk.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void MountBlackHawkPassenger(Blackhawk hawk, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				hawk.mountBlackHawk(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void DismountBlackHawkPassenger(Blackhawk hawk, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec.name == hawk.name && name != hawk.AOperator.name && name != hawk.Operator.name)
			{
				hawk.dismountBlackHawk(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not in passenger seat of " + hawk.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void MountLittleBirdOperator(LittleBird bird, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				bird.mountO(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void DismountLittleBirdOperator(LittleBird bird, string[,] AO)
	{
		if (status != "KIA")
		{
			if (name == bird.Operator.name)
			{
				bird.dismountO(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not in the operator seat of " + bird.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void MountLittleBirdAOperator(LittleBird bird, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				bird.mountA(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void DismountLittleBirdAOperator(LittleBird bird, string[,] AO)
	{
		if (status != "KIA")
		{
			if (name == bird.Operator.name)
			{
				bird.dismountA(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not in the A driver seat of " + bird.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void MountLittleBirdPassenger(LittleBird bird, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				bird.mountLittleBird(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void DismountLittleBirdPassenger(LittleBird bird, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec.name == bird.name && name != bird.AOperator.name && name != bird.Operator.name)
			{
				bird.dismountLittleBird(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not in passenger seat of " + bird.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void MountHumveeOperator(M1025 humvee, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				humvee.mountO(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void DismountHumveeOperator(M1025 humvee, string[,] AO)
	{
		if (status != "KIA")
		{
			if (humvee.Operator.name == name)
			{
				humvee.dismountO(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not the operator in " + humvee.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void MountHumveeAOPerator(M1025 humvee, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				humvee.mountA(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void DismountHumveeAOperator(M1025 humvee, string[,] AO)
	{
		if (status != "KIA")
		{
			if (humvee.AOperator.name == name)
			{
				humvee.dismountA(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not the A driver in " + humvee.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void MountHumveePassenger(M1025 humvee, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				humvee.Mount(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void DismountHumveePassenger(M1025 humvee, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec.name == humvee.name && name != humvee.AOperator.name && name != humvee.Operator.name)
			{
				humvee.Dismount(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not in passenger seat of " + humvee.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void MountGunner(M1025 humvee, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				humvee.MountGunner(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void DismountGunner(M1025 humvee, string[,] AO)
	{
		if (status != "KIA")
		{
			if (humvee._Gunner.name == name)
			{
				humvee.DismountGunner(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not the Gunner in " + humvee.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void Mount5TonOperator(M939 truck, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				truck.mountO(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void Dismount5TonOpperator(M939 truck, string[,] AO)
	{
		if (status != "KIA")
		{
			if (truck.Operator.name == name)
			{
				truck.dismountO(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not the operator of " + truck.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void Mount5TonAOperator(M939 truck, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				truck.mountA(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void Dismount5TonAOpperator(M939 truck, string[,] AO)
	{
		if (status != "KIA")
		{
			if (truck.AOperator.name == name)
			{
				truck.dismountA(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not the operator of " + truck.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void Mount5TonPassenger(M939 truck, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec == null)
			{
				truck.MountPassenger(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is in " + myvec.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void Dismount5TonPassenger(M939 truck, string[,] AO)
	{
		if (status != "KIA")
		{
			if (myvec.name == truck.name && name != truck.AOperator.name && name != truck.Operator.name)
			{
				truck.DismountPassenger(this, AO);
			}
			else
			{
				Console.WriteLine(name + " is not in passenger seat of " + truck.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void pickupgun(Firearm myweapon)
	{
		if (status != "KIA")
		{
			if (primarygun == null)
			{
				primarygun = myweapon;
				myweapon.Owner = this;
				Console.WriteLine(name + " picked up " + myweapon.name);
			}
			else
			{
				dropgun(primarygun);
				primarygun = myweapon;
				myweapon.Owner = this;
				Console.WriteLine(name + " picked up " + myweapon.name);
			}
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void dropgun(Firearm weapon)
	{
		if (status != "KIA")
		{
			primarygun = null;
			weapon.Owner = null;
			weapon.coordinatex = coordinatex + 1;
			weapon.coordinatey = coordinatey + 1;
			Console.WriteLine(name + " dropped " + weapon.name);
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void idle()
	{
		if (status != "KIA")
		{
			status = "idle";
			Console.WriteLine(name + " is " + status);
		}
		else
		{
			Console.WriteLine(name + " is KIA");
		}
	}

	public void KIA(string[,] AO)
	{
		if (status != "KIA")
		{
			status = "KIA";
			AO[coordinatex, coordinatey] = "X";
			Console.WriteLine(name + " is " + status);
		}
		else
		{
			Console.WriteLine(name + " is already KIA");
		}
	}
}
