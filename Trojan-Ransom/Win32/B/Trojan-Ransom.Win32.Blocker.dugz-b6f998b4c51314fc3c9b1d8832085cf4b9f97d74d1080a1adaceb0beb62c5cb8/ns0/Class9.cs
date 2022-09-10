using System;
using System.Windows.Forms;
using ns2;
using ns3;

namespace ns0;

internal sealed class Class9
{
	[STAThread]
	public static void Main(string[] args)
	{
		if (Class32.smethod_3())
		{
			Console.WriteLine("Now Executing Custom Application...");
			Form form = new Form();
			((Control)form).set_Visible(false);
			Application.Run((Form)(object)form);
		}
	}
}
