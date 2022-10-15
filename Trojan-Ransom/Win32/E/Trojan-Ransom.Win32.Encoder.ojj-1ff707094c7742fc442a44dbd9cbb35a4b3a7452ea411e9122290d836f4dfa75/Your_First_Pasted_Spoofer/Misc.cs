using System;

namespace Your_First_Pasted_Spoofer;

internal class Misc
{
	private static int number;

	public static void DrawASCII()
	{
		Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("          █▀▀▄ ░▀░ █▀▀ █▀▀▄ █▀▀ █░░█   █▀▀ █░░█ █▀▀ █▀▀ █░█ █▀▀ █▀▀█");
		Console.WriteLine("          █░░█ ▀█▀ ▀▀█ █░░█ █▀▀ █▄▄█   █░░ █▀▀█ █▀▀ █░░ █▀▄ █▀▀ █▄▄▀");
		Console.WriteLine("          ▀▀▀░ ▀▀▀ ▀▀▀ ▀░░▀ ▀▀▀ ▄▄▄█   ▀▀▀ ▀░░▀ ▀▀▀ ▀▀▀ ▀░▀ ▀▀▀ ▀░▀▀");
	}

	public static void HashText(string text)
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write("\n[");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("#");
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write("] ");
		Console.Write(text);
	}

	public static void OptionText(string text)
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write("\n[");
		Console.ForegroundColor = ConsoleColor.White;
		number++;
		Console.Write(number);
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write("] ");
		Console.Write(text);
	}

	private static void ResetOption()
	{
		number = 0;
	}
}
