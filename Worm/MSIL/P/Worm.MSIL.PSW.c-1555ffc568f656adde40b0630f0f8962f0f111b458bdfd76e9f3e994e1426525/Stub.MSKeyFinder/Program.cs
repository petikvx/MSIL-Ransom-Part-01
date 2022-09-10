using System;
using System.Windows.Forms;

namespace Stub.MSKeyFinder;

internal sealed class Program
{
	private Program()
	{
	}

	[STAThread]
	public static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
