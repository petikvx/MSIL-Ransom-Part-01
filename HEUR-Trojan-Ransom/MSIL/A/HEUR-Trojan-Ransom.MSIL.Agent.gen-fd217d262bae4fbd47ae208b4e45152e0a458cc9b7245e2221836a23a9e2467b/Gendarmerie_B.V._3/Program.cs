using System;
using System.Windows.Forms;

namespace Gendarmerie_B.V._3;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new GendarmerieForm());
	}
}
