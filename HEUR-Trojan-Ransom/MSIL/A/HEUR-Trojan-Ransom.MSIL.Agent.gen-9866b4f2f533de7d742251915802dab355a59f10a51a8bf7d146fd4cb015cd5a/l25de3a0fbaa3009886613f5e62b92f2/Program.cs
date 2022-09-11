using System;
using System.Windows.Forms;

namespace l25de3a0fbaa3009886613f5e62b92f2;

internal sealed class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new MainForm());
	}
}
