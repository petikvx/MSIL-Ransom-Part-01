using System;
using System.Security;
using System.Windows.Forms;
using KamelAmenThaabet;

namespace ns0;

internal static class Class4
{
	[SecuritySafeCritical]
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
