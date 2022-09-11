using System;
using System.Windows.Forms;
using ns0;

namespace ns5;

internal static class Class7
{
	[STAThread]
	private static void Main()
	{
		if (Class37.smethod_4())
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form1());
		}
	}
}
