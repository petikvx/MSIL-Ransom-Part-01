using System;
using System.Threading;
using System.Windows.Forms;

namespace Data_Locker;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		new Mutex(initiallyOwned: true, "54GDFB54Vf45415BGD64F5V4C6554V6D5WX4151F65DS165FE1S6G4F81VER6SD5C165", out var createdNew);
		if (createdNew)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form1());
		}
	}
}
