using System;
using System.Windows.Forms;
using ns2;

namespace ns1;

internal static class Class8
{
	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1(args));
	}
}
