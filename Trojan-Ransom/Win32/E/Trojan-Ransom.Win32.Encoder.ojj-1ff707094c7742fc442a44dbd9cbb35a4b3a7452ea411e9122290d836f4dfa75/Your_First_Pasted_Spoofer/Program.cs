using System;
using System.Threading;

namespace Your_First_Pasted_Spoofer;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Title = "Cracked by Geek#2648";
		Misc.DrawASCII();
		Misc.HashText("Disney account checker is not loaded properly, pls open Cracked by Geek#2648.exe then open me!");
		Console.ReadKey();
		Console.Clear();
		Misc.DrawASCII();
		Misc.OptionText("Pls enter your Combos in the Disney account checker file!");
		Misc.OptionText("Pls enter your Proxies in the Disney account checker file!");
		Misc.HashText("Option : ");
		string text = Console.ReadLine();
		if (text == "1")
		{
			Console.Clear();
			Misc.DrawASCII();
			Console.WriteLine("Checking Comobos pls wait");
			Thread.Sleep(10000);
			Console.WriteLine("No good Combos");
			Thread.Sleep(1000);
			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}
		else if (text == "2")
		{
			Console.Clear();
			Misc.DrawASCII();
			Console.WriteLine("This cracked checker doesnt need proxies");
			Thread.Sleep(1000);
			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}
		else
		{
			Misc.HashText("Ok retard maybe type right next time");
		}
	}
}
