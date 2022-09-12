using System;
using System.Windows.Forms;
using ns0;
using ns1;

namespace ns3;

internal static class Class7
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		AppDomain.CurrentDomain.AssemblyResolve += Class4.smethod_11;
		Application.Run((Form)(object)new Form0());
	}
}
