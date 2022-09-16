using System;

namespace BlackHawkDown;

internal class Insurgent : Person
{
	public Insurgent(string name)
	{
		base.name = name;
		status = "Alive";
		Console.WriteLine(base.name + " is " + status);
	}
}
