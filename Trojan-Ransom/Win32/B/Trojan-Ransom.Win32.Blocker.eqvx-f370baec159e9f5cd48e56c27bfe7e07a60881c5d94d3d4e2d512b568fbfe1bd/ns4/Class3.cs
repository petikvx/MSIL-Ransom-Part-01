using System;
using System.Windows.Forms;
using ns2;
using ns3;

namespace ns4;

internal class Class3
{
	[STAThread]
	public static void Main(string[] args)
	{
		if (Class30.smethod_3())
		{
			Console.WriteLine("Now Executing Custom Application...");
			Form form = new Form();
			((Control)form).set_Visible(false);
			Application.Run((Form)(object)form);
		}
	}
}
