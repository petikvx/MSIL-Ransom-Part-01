using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns0;

namespace Main;

public class FormBackground : Form
{
	private IContainer icontainer_0;

	private Timer timer_0;

	public FormBackground()
	{
		method_1();
		Delegate110.smethod_0(timer_0, Class2.int_1);
		Delegate123.smethod_0(timer_0, bool_0: true);
	}

	private void method_0(object sender, EventArgs e)
	{
		if (!Class2.bool_1 && Class5.smethod_2())
		{
			Class2.bool_1 = true;
			smethod_0();
			Delegate17.smethod_0(new FormGame(), (IWin32Window)(object)this);
		}
	}

	private static void smethod_0()
	{
		Class7.smethod_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			Delegate73.smethod_0(icontainer_0);
		}
		Delegate175.smethod_0(this, disposing);
	}

	private void method_1()
	{
		icontainer_0 = Delegate42.smethod_0();
		timer_0 = Delegate100.smethod_0(icontainer_0);
		Delegate146.smethod_0(this);
		Delegate123.smethod_0(timer_0, bool_0: true);
		Delegate16.smethod_0(timer_0, method_0);
		Delegate115.smethod_0(this, new SizeF(6f, 13f));
		Delegate58.smethod_0(this, (AutoScaleMode)1);
		Delegate122.smethod_0(this, new Size(284, 262));
		Delegate66.smethod_0(this, "FormBackground");
		Delegate131.smethod_0(this, "Form1");
		Delegate185.smethod_0(this, bool_0: false);
	}
}
