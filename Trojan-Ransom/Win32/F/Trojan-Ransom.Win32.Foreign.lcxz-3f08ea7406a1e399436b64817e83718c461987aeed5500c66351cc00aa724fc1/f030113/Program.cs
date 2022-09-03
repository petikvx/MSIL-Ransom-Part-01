using System;
using System.Windows.Forms;

namespace f030113;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new tela_inicial());
	}
}
