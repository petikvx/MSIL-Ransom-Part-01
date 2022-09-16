using System;

namespace BlackHawkDown;

internal class Vehicles
{
	public string name;

	public string status;

	public int coordinatex;

	public int coordinatey;

	public Person Operator;

	public Person AOperator;

	public void move(int x, int y, string[,] AO)
	{
		if (status != "destroyed")
		{
			AO[coordinatex, coordinatey] = "";
			status = "moving";
			coordinatex = x;
			coordinatey = y;
			AO[coordinatex, coordinatey] = name ?? "";
			if (AOperator != null)
			{
				AOperator.coordinatex = x;
				AOperator.coordinatey = y;
			}
			if (Operator != null)
			{
				Operator.coordinatex = x;
				Operator.coordinatey = y;
			}
			Console.WriteLine($"{name} is {status} to {x},{y}");
		}
		else
		{
			Console.WriteLine(name + " is destroyed");
		}
	}

	public virtual void start()
	{
		if (status != "destroyed")
		{
			status = "start engine";
			Console.WriteLine(name + " is " + status);
		}
		else
		{
			Console.WriteLine(name + " is destroyed");
		}
	}

	public virtual void stop()
	{
		if (status != "destroyed")
		{
			status = "stop engine";
			Console.WriteLine(name + " is " + status);
		}
		else
		{
			Console.WriteLine(name + " is destroyed");
		}
	}

	public void mountO(Person driver, string[,] AO)
	{
		if (status != "destroyed")
		{
			if (Operator == null)
			{
				Operator = driver;
				driver.myvec = this;
				AO[driver.coordinatex, driver.coordinatey] = "";
				driver.coordinatex = coordinatex;
				driver.coordinatey = coordinatey;
				Console.WriteLine(driver.name + " is operating " + name);
			}
			else
			{
				Console.WriteLine("This seat is taken in " + name);
			}
		}
		else
		{
			Console.WriteLine(name + " is destroyed");
		}
	}

	public void mountA(Person Adriver, string[,] AO)
	{
		if (status != "destroyed")
		{
			if (AOperator == null)
			{
				AOperator = Adriver;
				AO[Adriver.coordinatex, Adriver.coordinatey] = "";
				Adriver.myvec = this;
				Adriver.coordinatex = coordinatex;
				Adriver.coordinatey = coordinatey;
				Console.WriteLine(Adriver.name + " is A driving " + name);
			}
			else
			{
				Console.WriteLine("This seat is taken in " + name);
			}
		}
		else
		{
			Console.WriteLine(name + " is destroyed");
		}
	}

	public void dismountO(Person driver, string[,] AO)
	{
		if (status != "destroyed")
		{
			if (Operator.name == driver.name)
			{
				Operator = null;
				driver.myvec = null;
				AO[driver.coordinatex, driver.coordinatey] = "";
				driver.coordinatex = coordinatex + 1;
				driver.coordinatey = coordinatey + 1;
				Console.WriteLine(driver.name + " got out of " + name);
			}
			else
			{
				Console.WriteLine(driver.name + " is not in " + name);
			}
		}
		else
		{
			Console.WriteLine(name + " is destroyed");
		}
	}

	public void dismountA(Person Adriver, string[,] AO)
	{
		if (status != "destroyed")
		{
			if (AOperator.name == Adriver.name)
			{
				AOperator = null;
				Adriver.myvec = null;
				AO[Adriver.coordinatex, Adriver.coordinatey] = "";
				Adriver.coordinatex = coordinatex + 1;
				Adriver.coordinatey = coordinatey + 1;
				Console.WriteLine($"{Adriver} is got out");
			}
			else
			{
				Console.WriteLine(Adriver.name + " is not in " + name);
			}
		}
		else
		{
			Console.WriteLine(name + " is destroyed");
		}
	}

	public void idle()
	{
		if (status != "destroyed")
		{
			status = "idle";
			Console.WriteLine(name + " is " + status);
		}
		else
		{
			Console.WriteLine(name + " is destroyed");
		}
	}

	public void destroyed(string[,] AO)
	{
		if (status != "destroyed")
		{
			if (Operator != null)
			{
				Operator.KIA(AO);
			}
			if (AOperator != null)
			{
				AOperator.KIA(AO);
			}
			status = "destroyed";
			AO[coordinatex, coordinatey] = "CS";
			Console.WriteLine(name + " is " + status);
		}
		else
		{
			Console.WriteLine(name + " is destroyed");
		}
	}
}
