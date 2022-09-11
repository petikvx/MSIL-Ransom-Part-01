using System;
using System.Windows.Forms;

namespace GhosTEncryptor;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form2());
	}
}
