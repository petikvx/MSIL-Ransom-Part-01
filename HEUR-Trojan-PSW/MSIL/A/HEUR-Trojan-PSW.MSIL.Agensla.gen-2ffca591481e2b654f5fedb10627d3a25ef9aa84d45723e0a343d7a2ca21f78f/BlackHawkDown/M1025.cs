using System;

namespace BlackHawkDown;

internal class M1025 : Vehicles
{
	public Person _Gunner;

	private Person _p1;

	private Person _p2;

	private static int _count;

	public M1025(string name)
	{
		base.name = name;
		status = "engine off";
		Console.WriteLine(base.name + " is " + status);
		_count++;
	}

	public int DisplayCount()
	{
		return _count;
	}

	public void MountGunner(Person gunner, string[,] AO)
	{
		if (_Gunner != null)
		{
			Console.WriteLine("There already is a gunner in " + name);
			return;
		}
		_Gunner = gunner;
		AO[gunner.coordinatex, gunner.coordinatey] = "";
		gunner.coordinatex = coordinatex;
		gunner.coordinatey = coordinatey;
		Console.WriteLine(gunner.name + " mounted the gun of " + name);
	}

	public void DismountGunner(Person gunner, string[,] AO)
	{
		if (_Gunner == null)
		{
			Console.WriteLine("No one is in the gunner seat of " + name);
		}
		else if (_Gunner.name == gunner.name)
		{
			AO[gunner.coordinatex, gunner.coordinatey] = "";
			gunner.coordinatex = coordinatex - 1;
			gunner.coordinatey = coordinatey;
			Console.WriteLine(gunner.name + " got out of " + name);
		}
		else
		{
			Console.WriteLine(gunner.name + " is not in " + name);
		}
	}

	public void Mount(Person pass, string[,] AO)
	{
		if (_p1 == null)
		{
			_p1 = pass;
			pass.myvec = this;
			AO[pass.coordinatex, pass.coordinatey] = "";
			pass.coordinatex = coordinatex;
			pass.coordinatey = coordinatey;
			Console.WriteLine(pass.name + " is in passenger seat 1 of " + name);
		}
		else if (_p2 == null)
		{
			_p2 = pass;
			pass.myvec = this;
			AO[pass.coordinatex, pass.coordinatey] = "";
			pass.coordinatex = coordinatex;
			pass.coordinatey = coordinatey;
			Console.WriteLine(pass.name + " is in passenger seat 2 of " + name);
		}
		else
		{
			Console.WriteLine("there is no room in " + name);
		}
	}

	public void Dismount(Person pass, string[,] AO)
	{
		if (_p1 != null)
		{
			if (_p1.name == pass.name)
			{
				_p1 = null;
				pass.myvec = null;
				AO[pass.coordinatex, pass.coordinatey] = "";
				pass.coordinatex = coordinatex + 1;
				pass.coordinatey = coordinatey;
				AO[pass.coordinatex, pass.coordinatey] = pass.name ?? "";
				Console.WriteLine(pass.name + " got out of passenger seat 1 on " + name);
			}
			else
			{
				Console.WriteLine(pass.name + " is not in " + name);
			}
		}
		else if (_p2 != null)
		{
			if (_p2.name == pass.name)
			{
				_p2 = null;
				pass.myvec = null;
				AO[pass.coordinatex, pass.coordinatey] = "";
				pass.coordinatex = coordinatex - 1;
				pass.coordinatey = coordinatey;
				AO[pass.coordinatex, pass.coordinatey] = pass.name ?? "";
				Console.WriteLine(pass.name + " got out of passenger seat 2 on " + name);
			}
			else
			{
				Console.WriteLine(pass.name + " is not in " + name);
			}
		}
		else
		{
			Console.WriteLine("all passenger seats in " + name + " are empty");
		}
	}
}
