using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AdobeSys;

[LicenseProvider(typeof(Class3))]
internal static class Class0
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		LicenseManager.Validate(typeof(Class0));
		Application.Run((Form)(object)new Form1());
	}

	static Class0()
	{
		LicenseManager.Validate(typeof(Class0));
	}
}
