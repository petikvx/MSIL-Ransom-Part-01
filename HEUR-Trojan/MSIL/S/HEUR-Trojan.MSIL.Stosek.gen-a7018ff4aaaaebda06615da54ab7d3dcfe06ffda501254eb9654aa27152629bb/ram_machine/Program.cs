using System;
using System.Windows.Forms;

namespace ram_machine;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Display("46696C65494F41636365", "4B7865"));
	}
}
