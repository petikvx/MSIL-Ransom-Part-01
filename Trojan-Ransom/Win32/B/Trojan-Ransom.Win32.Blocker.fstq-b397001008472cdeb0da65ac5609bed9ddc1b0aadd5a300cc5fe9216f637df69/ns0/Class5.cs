using System;
using System.Windows.Forms;

namespace ns0;

internal class Class5
{
	[STAThread]
	public static void Main(string[] args)
	{
		Form0 form = default(Form0);
		try
		{
			Class15.smethod_11();
			Class23.smethod_1();
			Console.WriteLine(Class6.smethod_0(22374));
			form = new Form0();
			((Control)form).set_Visible(false);
			Application.Run((Form)(object)form);
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, args, form);
			throw;
		}
	}
}
