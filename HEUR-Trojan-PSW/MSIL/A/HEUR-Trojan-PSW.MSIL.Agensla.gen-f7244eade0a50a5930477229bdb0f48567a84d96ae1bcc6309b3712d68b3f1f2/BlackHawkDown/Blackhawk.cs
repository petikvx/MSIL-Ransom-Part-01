using System;

namespace BlackHawkDown;

internal class Blackhawk : Vehicles
{
	private Person _p1;

	private Person _p2;

	private Person _p3;

	private Person _p4;

	private Person _p5;

	private Person _p6;

	private Person _p7;

	private Person _p8;

	private Person _p9;

	private Person _p10;

	private Person _p11;

	private Person _p12;

	private Person _p13;

	private static int _count;

	public Blackhawk(string name)
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

	public void Explode(string[,] AO)
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
		if (_p5 != null)
		{
			_p5.KIA(AO);
		}
		if (_p6 != null)
		{
			_p6.KIA(AO);
		}
		if (_p7 != null)
		{
			_p7.KIA(AO);
		}
		if (_p8 != null)
		{
			_p8.KIA(AO);
		}
		if (_p9 != null)
		{
			_p9.KIA(AO);
		}
		if (_p11 != null)
		{
			_p11.KIA(AO);
		}
		if (_p12 != null)
		{
			_p12.KIA(AO);
		}
		if (_p13 != null)
		{
			_p13.KIA(AO);
		}
	}

	public void hover()
	{
		status = "hover";
		Console.WriteLine(name + " is " + status);
	}

	public override void start()
	{
		status = "Starting Rotors";
		Console.WriteLine(name + " is " + status);
	}

	public override void stop()
	{
		status = "Stopping Rotors";
		Console.WriteLine(name + " is " + status);
	}

	public void mountBlackHawk(Person mountee, string[,] AO)
	{
		if (_p1 == null)
		{
			_p1 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 1 of " + name);
		}
		else if (_p2 == null)
		{
			_p2 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 2 of " + name);
		}
		else if (_p3 == null)
		{
			_p3 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 3 of " + name);
		}
		else if (_p4 == null)
		{
			_p4 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 4 of " + name);
		}
		else if (_p5 == null)
		{
			_p5 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 5 of " + name);
		}
		else if (_p6 == null)
		{
			_p6 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 6 of " + name);
		}
		else if (_p7 == null)
		{
			_p7 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 7 of " + name);
		}
		else if (_p8 == null)
		{
			_p8 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 8 of " + name);
		}
		else if (_p9 == null)
		{
			_p9 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 9 of " + name);
		}
		else if (_p10 == null)
		{
			_p10 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 10 of " + name);
		}
		else if (_p11 == null)
		{
			_p11 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 11 of " + name);
		}
		else if (_p12 == null)
		{
			_p12 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 12 of " + name);
		}
		else if (_p13 == null)
		{
			_p13 = mountee;
			mountee.myvec = this;
			AO[mountee.coordinatex, mountee.coordinatey] = "";
			mountee.coordinatex = coordinatex;
			mountee.coordinatey = coordinatey;
			Console.WriteLine(mountee.name + " is in passenger seat 13 of " + name);
		}
		else
		{
			Console.WriteLine(name + " is full");
		}
	}

	public void dismountBlackHawk(Person mountee, string[,] AO)
	{
		if (_p1 != null)
		{
			if (_p1.name == mountee.name && _p1 != null)
			{
				_p1 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex - 1;
				mountee.coordinatey = coordinatey - 3;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 1 of " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p2 != null)
		{
			if (_p2.name == mountee.name && _p2 != null)
			{
				_p2 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex - 1;
				mountee.coordinatey = coordinatey - 2;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 2 of " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p3 != null)
		{
			if (_p3.name == mountee.name && _p3 != null)
			{
				_p3 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex - 1;
				mountee.coordinatey = coordinatey - 1;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 3 " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p4 != null)
		{
			if (_p4.name == mountee.name && _p4 != null)
			{
				_p4 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex - 1;
				mountee.coordinatey = coordinatey;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 4 " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p5 != null)
		{
			if (_p5.name == mountee.name && _p5 != null)
			{
				_p5 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex - 1;
				mountee.coordinatey = coordinatey + 1;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 5 " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p6 != null)
		{
			if (_p6.name == mountee.name && _p6 != null)
			{
				_p6 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex - 1;
				mountee.coordinatey = coordinatey + 2;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 6 " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p7 != null)
		{
			if (_p7.name == mountee.name && _p7 != null)
			{
				_p7 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex - 1;
				mountee.coordinatey = coordinatey + 3;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 7 " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p8 != null)
		{
			if (_p8.name == mountee.name && _p8 != null)
			{
				_p8 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex + 1;
				mountee.coordinatey = coordinatey - 3;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 8 " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p9 != null)
		{
			if (_p9.name == mountee.name && _p9 != null)
			{
				_p9 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex + 1;
				mountee.coordinatey = coordinatey - 2;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 9 " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p10 != null)
		{
			if (_p10.name == mountee.name && _p10 != null)
			{
				_p10 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex + 1;
				mountee.coordinatey = coordinatey - 1;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 10 " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p11 != null)
		{
			if (_p11.name == mountee.name && _p11 != null)
			{
				_p11 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex + 1;
				mountee.coordinatey = coordinatey;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 11 " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p12 != null)
		{
			if (_p12.name == mountee.name && _p12 != null)
			{
				_p12 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex + 1;
				mountee.coordinatey = coordinatey + 1;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 12 " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else if (_p13 != null)
		{
			if (_p13.name == mountee.name && _p13 != null)
			{
				_p13 = null;
				mountee.myvec = null;
				AO[mountee.coordinatex, mountee.coordinatey] = "";
				mountee.coordinatex = coordinatex + 1;
				mountee.coordinatey = coordinatey + 2;
				AO[mountee.coordinatex, mountee.coordinatey] = mountee.name ?? "";
				Console.WriteLine(mountee.name + " got out of passenger seat 13 " + name);
			}
			else
			{
				Console.WriteLine(mountee.name + " is not in the " + name);
			}
		}
		else
		{
			Console.WriteLine("all passenger seats in " + name + " are empty");
		}
	}
}
