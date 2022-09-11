using System;

namespace Ransimware;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("--- Starting Ransimware ---");
		new Ransimware().Simulate();
		Console.WriteLine("Simulation ended successfully\nPress Enter to continue....");
		Console.ReadKey();
	}
}
