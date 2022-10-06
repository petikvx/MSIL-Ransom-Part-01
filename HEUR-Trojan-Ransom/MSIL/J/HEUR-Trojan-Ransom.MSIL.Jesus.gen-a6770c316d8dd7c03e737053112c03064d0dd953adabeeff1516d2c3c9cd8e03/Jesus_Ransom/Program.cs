using System;
using System.Windows.Forms;

namespace Jesus_Ransom;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((ApplicationContext)(object)new App(args));
	}
}
