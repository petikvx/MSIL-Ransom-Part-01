using System;

namespace ransom;

internal class ConsoleHelper
{
	public static void Writelinewithcolor(string text, ConsoleColor color)
	{
		Console.ForegroundColor = color;
		Console.WriteLine(text);
		Console.ResetColor();
	}

	public static void Writewithcolor(string text, ConsoleColor color)
	{
		Console.ForegroundColor = color;
		Console.Write(text);
		Console.ResetColor();
	}

	public static void WriteEmptyline()
	{
		Console.Write(Environment.NewLine);
	}
}
