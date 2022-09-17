using System;
using System.Windows.Forms;

namespace Server;

internal static class Program
{
	public static Form1 form1;

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		form1 = new Form1();
		Application.Run((Form)(object)form1);
	}
}
