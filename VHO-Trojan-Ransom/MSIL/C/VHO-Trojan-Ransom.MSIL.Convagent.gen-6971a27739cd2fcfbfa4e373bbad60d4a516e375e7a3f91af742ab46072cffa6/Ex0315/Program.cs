using System;

namespace Ex0315;

internal class Program
{
	private static void Main()
	{
		Console.WriteLine($"a = {25}, b = {55}, c = {147}, d = {223}");
		Console.WriteLine($"(a>b) && (c>d) = {true}");
		Console.WriteLine($"(a>b) || (c>d) = {false}");
		Console.WriteLine($"!(a > b) = {true}");
		Console.ReadKey();
	}
}
