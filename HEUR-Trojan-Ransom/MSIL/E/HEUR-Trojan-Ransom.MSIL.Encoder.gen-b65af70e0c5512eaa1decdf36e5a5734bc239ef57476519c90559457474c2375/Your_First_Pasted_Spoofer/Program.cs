using System;

namespace Your_First_Pasted_Spoofer;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Title = "Trace Cleaner 1.0";
		Console.Clear();
		Misc.HashText("Cleaning Traces");
		Spoof.CleanTraces("C:\\Windows\\IME\\cleaner.exe");
		Misc.HashText("Cleaned Traces");
		Console.ReadKey();
	}
}
