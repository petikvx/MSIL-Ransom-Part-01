using System;
using System.Windows.Forms;

namespace WatsonDialog;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		SqlWatsonDialog.LaunchDialog();
	}
}
