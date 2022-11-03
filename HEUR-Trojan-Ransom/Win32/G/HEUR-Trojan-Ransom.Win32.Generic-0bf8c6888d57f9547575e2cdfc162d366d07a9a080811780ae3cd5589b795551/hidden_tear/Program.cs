using System;
using System.Windows.Forms;

namespace hidden_tear;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		try
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form1());
		}
		catch (UnauthorizedAccessException)
		{
		}
	}
}
