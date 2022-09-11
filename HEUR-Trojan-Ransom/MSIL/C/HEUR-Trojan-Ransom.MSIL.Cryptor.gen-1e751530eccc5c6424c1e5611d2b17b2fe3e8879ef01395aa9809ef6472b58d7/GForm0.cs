using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

public sealed class GForm0 : Form
{
	private GClass1 gclass1_0;

	private IContainer icontainer_0;

	public GForm0()
	{
		method_4();
		method_1(new GClass1());
	}

	public GClass1 method_0()
	{
		return gclass1_0;
	}

	public void method_1(GClass1 gclass1_1)
	{
		gclass1_0 = gclass1_1;
	}

	private void method_2()
	{
		using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(Class4.smethod_0(-1659687981));
		int int_ = Convert.ToInt32(registryKey.GetValue(Class4.smethod_0(-1659688039)));
		if (method_3(int_) == Class4.smethod_0(-1659689399))
		{
			File.WriteAllText(Class4.smethod_0(-1659688085), Class4.smethod_0(-1659688079));
			Application.Exit();
		}
	}

	private string method_3(int int_0)
	{
		if (int_0 >= 461808)
		{
			return Class4.smethod_0(-1659688156);
		}
		if (int_0 >= 461308)
		{
			return Class4.smethod_0(-1659688177);
		}
		if (int_0 >= 460798)
		{
			return Class4.smethod_0(-1659688174);
		}
		if (int_0 >= 394802)
		{
			return Class4.smethod_0(-1659688729);
		}
		if (int_0 >= 394254)
		{
			return Class4.smethod_0(-1659688758);
		}
		if (int_0 >= 393295)
		{
			return Class4.smethod_0(-1659688739);
		}
		if (int_0 >= 393273)
		{
			return Class4.smethod_0(-1659688798);
		}
		if (int_0 >= 379893)
		{
			return Class4.smethod_0(-1659688780);
		}
		if (int_0 >= 378675)
		{
			return Class4.smethod_0(-1659688801);
		}
		if (int_0 >= 378389)
		{
			return Class4.smethod_0(-1659688862);
		}
		return Class4.smethod_0(-1659689399);
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		method_0().method_18();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_4()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(Class4.smethod_0(-1659688841));
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text(Class4.smethod_0(-1659688884));
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)this).ResumeLayout(false);
	}
}
