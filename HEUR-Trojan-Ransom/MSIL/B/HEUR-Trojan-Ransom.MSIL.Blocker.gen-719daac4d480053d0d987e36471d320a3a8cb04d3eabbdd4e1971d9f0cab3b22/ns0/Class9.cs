using System;
using System.Windows.Forms;
using ns2;

namespace ns0;

internal static class Class9
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		AppDomain.CurrentDomain.AssemblyResolve += Class7.smethod_18;
		Application.Run((Form)(object)new Form0());
	}
}
