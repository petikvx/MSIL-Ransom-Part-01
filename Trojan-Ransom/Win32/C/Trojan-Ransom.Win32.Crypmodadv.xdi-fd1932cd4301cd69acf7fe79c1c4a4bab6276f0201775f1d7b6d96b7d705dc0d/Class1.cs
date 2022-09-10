using System.Windows.Forms;
using Vindows.Engine.Interface;

internal class Class1 : ApplicationContext
{
	public Class4 class4_0;

	internal Class1()
	{
		class4_0 = new Class4(this);
		class4_0.method_4();
		((ApplicationContext)this).set_MainForm((Form)(object)new MainForm());
	}
}
