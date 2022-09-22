using System;
using System.Windows.Forms;
using VanillaStub.Forms;

namespace VanillaStub;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new InitialForm());
	}
}
