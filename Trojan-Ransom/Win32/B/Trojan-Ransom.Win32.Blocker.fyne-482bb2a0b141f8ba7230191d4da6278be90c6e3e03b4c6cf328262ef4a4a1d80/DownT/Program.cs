using System;
using System.Threading;
using System.Windows.Forms;

namespace DownT;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Thread.Sleep(Class1.minil);
		Application.Run((Form)(object)new Form1());
	}
}
