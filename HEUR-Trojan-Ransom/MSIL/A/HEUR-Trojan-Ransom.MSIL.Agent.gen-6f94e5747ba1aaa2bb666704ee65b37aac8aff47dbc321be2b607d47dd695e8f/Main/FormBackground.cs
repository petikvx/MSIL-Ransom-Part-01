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
		InitializeComponent();
		timer_0.set_Interval(Class2.int_1);
		timer_0.set_Enabled(true);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!Class2.bool_1 && Class6.smethod_2())
		{
			Class2.bool_1 = true;
			smethod_0();
			((Form)new FormGame()).Show((IWin32Window)(object)this);
		}
	}

	private static void smethod_0()
	{
		Class8.smethod_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		timer_0.set_Enabled(true);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).set_Name("FormBackground");
		((Control)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
