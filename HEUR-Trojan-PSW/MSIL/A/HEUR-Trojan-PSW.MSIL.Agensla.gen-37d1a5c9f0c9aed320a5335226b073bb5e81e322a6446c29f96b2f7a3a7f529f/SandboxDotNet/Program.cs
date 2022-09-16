using System;
using System.Windows.Forms;
using SandboxDotNet.UserInterface;

namespace SandboxDotNet;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new HelpForm());
	}
}
