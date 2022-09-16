using System;

namespace BlackHawkDown;

internal class M939 : Vehicles
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

	private Person _p14;

	private Person _p15;

	private Person _p16;

	private static int _count;

	public M939(string name)
	{
		base.name = name;
		status = "engine off";
		Console.WriteLine(base.name + " is " + status);
		_count++;
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
		if (_p14 != null)
		{
			_p14.KIA(AO);
		}
		if (_p15 != null)
		{
			_p15.KIA(AO);
		}
		if (_p16 != null)
		{
			_p16.KIA(AO);
		}
	}

	public int displaycount()
	{
		return _count;
	}

	public void MountPassenger(Person pers, string[,] AO)
	{
		if (_p1 == null)
		{
			_p1 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 1 of " + name);
		}
		else if (_p2 == null)
		{
			_p2 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 2 of " + name);
		}
		else if (_p3 == null)
		{
			_p3 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 3 of " + name);
		}
		else if (_p4 == null)
		{
			_p4 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 4 of " + name);
		}
		else if (_p5 == null)
		{
			_p5 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 5 of " + name);
		}
		else if (_p6 == null)
		{
			_p6 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 6 of " + name);
		}
		else if (_p7 == null)
		{
			_p7 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 7 of " + name);
		}
		else if (_p8 == null)
		{
			_p8 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 8 of " + name);
		}
		else if (_p9 == null)
		{
			_p9 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 9 of " + name);
		}
		else if (_p10 == null)
		{
			_p10 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 10 of " + name);
		}
		else if (_p11 == null)
		{
			_p11 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 11 of " + name);
		}
		else if (_p12 == null)
		{
			_p12 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 12 of " + name);
		}
		else if (_p13 == null)
		{
			_p13 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 13 of " + name);
		}
		else if (_p14 == null)
		{
			_p14 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 14 of " + name);
		}
		else if (_p15 == null)
		{
			_p15 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 15 of " + name);
		}
		else if (_p16 == null)
		{
			_p16 = pers;
			pers.myvec = this;
			AO[pers.coordinatex, pers.coordinatey] = "";
			pers.coordinatex = coordinatex;
			pers.coordinatey = coordinatey;
			Console.WriteLine(pers.name + " is in passenger seat 16 of " + name);
		}
		else
		{
			Console.WriteLine(name + " is full");
		}
	}

	public void DismountPassenger(Person pers, string[,] AO)
	{
		if (_p1 != null)
		{
			if (_p1.name == pers.name)
			{
				_p1 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex - 1;
				pers.coordinatey = coordinatey - 4;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 1 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p2 != null)
		{
			if (_p2.name == pers.name)
			{
				_p2 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex - 1;
				pers.coordinatey = coordinatey - 3;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 2 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p3 != null)
		{
			if (_p3.name == pers.name)
			{
				_p3 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex - 1;
				pers.coordinatey = coordinatey - 2;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 3 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p4 != null)
		{
			if (_p4.name == pers.name)
			{
				_p4 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex - 1;
				pers.coordinatey = coordinatey - 1;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 4 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p5 != null)
		{
			if (_p5.name == pers.name)
			{
				_p5 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex - 1;
				pers.coordinatey = coordinatey;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 5 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p6 != null)
		{
			if (_p6.name == pers.name)
			{
				_p6 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex - 1;
				pers.coordinatey = coordinatey + 1;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 6 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p7 != null)
		{
			if (_p7.name == pers.name)
			{
				_p7 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex - 1;
				pers.coordinatey = coordinatey + 2;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 7 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p8 != null)
		{
			if (_p8.name == pers.name)
			{
				_p8 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex - 1;
				pers.coordinatey = coordinatey + 3;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 8 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p9 != null)
		{
			if (_p9.name == pers.name)
			{
				_p9 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex + 1;
				pers.coordinatey = coordinatey - 4;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 9 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p10 != null)
		{
			if (_p10.name == pers.name)
			{
				_p10 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex + 1;
				pers.coordinatey = coordinatey - 3;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 10 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p11 != null)
		{
			if (_p11.name == pers.name)
			{
				_p11 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex + 1;
				pers.coordinatey = coordinatey - 2;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 11 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p12 != null)
		{
			if (_p12.name == pers.name)
			{
				_p12 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex + 1;
				pers.coordinatey = coordinatey - 1;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 12 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p13 != null)
		{
			if (_p13.name == pers.name)
			{
				_p13 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex + 1;
				pers.coordinatey = coordinatey;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 13 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p14 != null)
		{
			if (_p14.name == pers.name)
			{
				_p14 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex + 1;
				pers.coordinatey = coordinatey + 1;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 14 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p15 != null)
		{
			if (_p15.name == pers.name)
			{
				_p15 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex + 1;
				pers.coordinatey = coordinatey + 2;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 15 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else if (_p16 != null)
		{
			if (_p16.name == pers.name)
			{
				_p16 = null;
				pers.myvec = null;
				AO[pers.coordinatex, pers.coordinatey] = "";
				pers.coordinatex = coordinatex + 1;
				pers.coordinatey = coordinatey + 3;
				AO[pers.coordinatex, pers.coordinatey] = pers.name ?? "";
				Console.WriteLine(pers.name + " got out of passenger seat 16 of " + name);
			}
			else
			{
				Console.WriteLine(pers.name + " is not a passenger");
			}
		}
		else
		{
			Console.WriteLine("all passenger seats in " + name + " are empty");
		}
	}
}
