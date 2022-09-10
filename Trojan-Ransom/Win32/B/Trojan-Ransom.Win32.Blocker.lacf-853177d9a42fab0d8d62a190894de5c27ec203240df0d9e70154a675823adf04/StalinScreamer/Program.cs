using System;
using System.Windows.Forms;

namespace StalinScreamer;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		try
		{
			Application.Run((Form)(object)new Form1());
		}
		catch (Exception)
		{
			Application.Restart();
		}
	}
}
