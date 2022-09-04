using System;
using System.Windows.Forms;

namespace Fcueorm;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Class9.NewMethod();
		Application.Run((Form)(object)new Template());
	}
}
