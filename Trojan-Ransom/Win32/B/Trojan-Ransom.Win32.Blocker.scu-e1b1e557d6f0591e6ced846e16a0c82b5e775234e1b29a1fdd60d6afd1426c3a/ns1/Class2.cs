using System;
using System.Windows.Forms;
using ns0;
using ns2;

namespace ns1;

internal class Class2
{
	[STAThread]
	public static void Main()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Form val = new Form();
		val.set_Opacity(0.0);
		((Control)val).set_Visible(false);
		val.set_ShowInTaskbar(false);
		Class1.smethod_0(new object[0], Class0.smethod_0(Class3.smethod_1(), "micro"), "A", "A");
		Application.Run(val);
	}
}
