using System;
using System.Windows.Forms;

namespace Matryoshka;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Matryoshka());
	}
}
