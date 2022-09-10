using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DtkGurmePdaPrn;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		string processName = Process.GetCurrentProcess().ProcessName;
		Process[] processesByName = Process.GetProcessesByName(processName);
		if (processesByName.Length > 1)
		{
			MessageBox.Show("UYGULAMA ZATEN ÇALIŞIYOR", "Hata", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
