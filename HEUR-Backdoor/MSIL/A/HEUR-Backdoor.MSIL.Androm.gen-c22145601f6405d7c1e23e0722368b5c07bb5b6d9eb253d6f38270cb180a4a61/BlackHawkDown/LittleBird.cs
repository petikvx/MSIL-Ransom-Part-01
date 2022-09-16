using System;

namespace BlackHawkDown;

internal class LittleBird : Vehicles
{
	private Person _p1;

	private Person _p2;

	private Person _p3;

	private Person _p4;

	private static int count;

	public LittleBird(string name)
	{
		base.name = name;
		status = "engine off";
		Console.WriteLine(base.name + " is " + status);
		count++;
	}

	public int DisplayCount()
	{
		return count;
	}

	public void explode(string[,] AO)
	{
		if (_p1 != null)
		{
			_p1.KIA(AO);
		}
		if (_p2 != null)
		{
			_p2.KIA(AO);
		}
		if (_p3 != null)
		{
			_p3.KIA(AO);
		}
		if (_p4 != null)
		{
			_p4.KIA(AO);
		}
	}

	public void Shoot(Person Target, string[,] AO)
	{
		Target.KIA(AO);
		Console.WriteLine(name + " killed " + Target.name);
	}

	public override void start()
	{
		status = "Starting Rotors";
		Console.WriteLine(name + " is " + status);
	}

	public void hover()
	{
		status = "hover";
		Console.WriteLine(name + " is " + status);
	}

	public override void stop()
	{
		status = "Stopping Rotors";
		Console.WriteLine(name + " is " + status);
	}

	public void mountLittleBird(Person mountee, string[,] AO)
	{
		if (_p1 == null)
		{
			_p1 = mountee;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			mountee.myvec = this;
			Console.WriteLine(mountee.name + " is in passenger seat 1 of " + name);
		}
		else if (_p2 == null)
		{
			_p2 = mountee;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			mountee.myvec = this;
			Console.WriteLine(mountee.name + " is in passenger seat 2 of" + name);
		}
		else if (_p3 == null)
		{
			_p3 = mountee;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			mountee.myvec = this;
			Console.WriteLine(mountee.name + " is in passenger seat 3 of " + name);
		}
		else if (_p4 == null)
		{
			_p4 = mountee;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			mountee.myvec = this;
			Console.WriteLine(mountee.name + " is in passenger seat 4 of " + name);
		}
		else
		{
			Console.WriteLine(name + " is full");
		}
	}

	public void dismountLittleBird(Person mountee, string[,] AO)
	{
		if (_p1 != null)
		{
			if (_p1.name == mountee.name)
			{
				_p1 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex - 1;
				mountee.coordinatey = coordinatey - 1;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 1 of " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in aircraft");
			}
		}
		else if (_p2 != null)
		{
			if (_p2.name == mountee.name)
			{
				_p2 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex - 1;
				mountee.coordinatey = coordinatey;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 2 of " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in aircraft");
			}
		}
		else if (_p3 != null)
		{
			if (_p3.name == mountee.name)
			{
				_p3 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex + 1;
				mountee.coordinatey = coordinatey - 1;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 3 of " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in aircraft");
			}
		}
		else if (_p4 != null)
		{
			if (_p4.name == mountee.name)
			{
				_p4 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex + 1;
				mountee.coordinatey = coordinatey;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 4 of " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in aircraft");
			}
		}
		else
		{
			Console.WriteLine("all passenger seats in " + name + " are empty");
		}
	}
}
