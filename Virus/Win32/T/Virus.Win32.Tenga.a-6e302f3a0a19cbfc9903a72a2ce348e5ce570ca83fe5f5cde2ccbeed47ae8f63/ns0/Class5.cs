using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VerificareSiuiFarmacie;

namespace ns0;

internal static class Class5
{
	private const int int_0 = 0;

	private const int int_1 = 1;

	private const int int_2 = 2;

	private const int int_3 = 3;

	private const int int_4 = 4;

	private const int int_5 = 9;

	private const int int_6 = 10;

	[DllImport("User32.dll")]
	public static extern int ShowWindowAsync(IntPtr intptr_0, int int_7);

	[STAThread]
	private static void Main()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (currentProcess.Id != process.Id && currentProcess.ProcessName == process.ProcessName)
			{
				MessageBox.Show("Aplicatia ruleaza deja!", "Atentie", (MessageBoxButtons)0);
				ShowWindowAsync(process.MainWindowHandle, 3);
				return;
			}
		}
		Application.Run((Form)(object)new frmServerCnas());
	}
}
