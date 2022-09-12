using System;
using System.Security;
using System.Windows.Forms;
using LoginModern;

namespace ns0;

internal static class Class0
{
	[SecuritySafeCritical]
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new login());
	}
}
