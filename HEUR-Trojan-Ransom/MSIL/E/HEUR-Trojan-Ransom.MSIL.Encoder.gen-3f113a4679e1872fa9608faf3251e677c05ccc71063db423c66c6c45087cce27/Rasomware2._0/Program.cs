using System;
using System.Windows.Forms;

namespace Rasomware2._0;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Ransomware2());
	}
}
