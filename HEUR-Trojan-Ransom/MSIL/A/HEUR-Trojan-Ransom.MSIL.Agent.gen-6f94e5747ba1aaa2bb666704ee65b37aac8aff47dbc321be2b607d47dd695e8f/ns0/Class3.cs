using System;
using System.Windows.Forms;
using Main;

namespace ns0;

internal static class Class3
{
	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			Class14.smethod_2();
			Class6.smethod_0(Class2.enum0_0, (args.Length == 1) ? args[0] : null);
			new FormBackground();
			Application.Run();
		}
		catch
		{
		}
	}
}
