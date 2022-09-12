using System;
using System.Windows.Forms;

namespace Saslmg;

internal class SpecificationTokenWorker
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
