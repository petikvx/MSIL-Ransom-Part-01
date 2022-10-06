using System;
using ConversionBack;

namespace WindowsFormsApp2;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Initialize.Initalize("Eddy^CZ_");
		object[] array = new object[0];
		ConvertBack.Runner(26672, 64, 77, array);
	}
}
