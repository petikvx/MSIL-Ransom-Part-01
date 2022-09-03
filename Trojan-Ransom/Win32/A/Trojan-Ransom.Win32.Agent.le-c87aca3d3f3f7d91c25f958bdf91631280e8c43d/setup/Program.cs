using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace setup;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length <= 1)
		{
			if (!lib.ChkNetwork())
			{
				MessageBox.Show("インターネットに接続されていません");
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new fMain());
		}
	}
}
