using System;
using System.Windows.Forms;

namespace WindowsFormsApp1;

public static class Program
{
	[STAThread]
	public static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
