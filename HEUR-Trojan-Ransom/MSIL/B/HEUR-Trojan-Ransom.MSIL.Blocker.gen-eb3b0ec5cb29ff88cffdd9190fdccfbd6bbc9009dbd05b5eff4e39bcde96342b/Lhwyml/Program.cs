using System;

namespace Lhwyml;

internal class Program
{
	private static string fileName { get; set; }

	[STAThread]
	private static void Main(string[] args)
	{
		Boss.Mouse();
		Boss.Cow();
		Boss.Rabbit();
	}
}
