using System;
using System.Windows.Forms;

namespace lulu_cry;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
