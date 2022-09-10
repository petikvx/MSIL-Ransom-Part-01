using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Timers;
using Microsoft.Win32;
using ServiceInterface;
using eSettings.Model.Library;

namespace eRecoveryService;

public class ServerClass : MarshalByRefObject, Interface
{
	public const int BOOT_FLOPPY = 0;

	public const int BOOT_HD = 1;

	public const int BOOT_ODD = 2;

	public const int BOOT_SCSI = 3;

	public const int BOOT_D2D = 4;

	public const int BOOT_LS120 = 5;

	public const int BOOT_PCMCIA = 6;

	public const int BOOT_NETWORK = 7;

	public const int BOOT_ZIP = 8;

	public const int BOOT_1394ODD = 9;

	public const int BOOT_USBHD = 10;

	public const int BOOT_USBODD = 11;

	public const int BOOT_USBFDD = 12;

	public const int BOOT_USBRD = 13;

	public const int BOOT_SECHD = 14;

	public const int BOOT_USBZIP = 15;

	public const int BOOT_USBOTH = 16;

	public const int BOOT_OTHER = 17;

	private IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

	private System.Timers.Timer PercentageTiemr;

	private string m_szTmpHid;

	public int globalint;

	private System.Timers.Timer SWCDExtractTimer;

	private string wimFile;

	private string tmpDir;

	private string applyDir;

	private bool bLog;

	private string szLogPath = "C:\\Acer\\Empowering Technology\\Logs";

	private ILease lease;

	public ServerClass()
	{
		bLog = NeedLog();
		if (bLog)
		{
			LogStart();
		}
	}

	public override object InitializeLifetimeService()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		if (lease == null)
		{
			lease = (ILease)base.InitializeLifetimeService();
			if ((int)lease.get_CurrentState() == 1)
			{
				lease.set_InitialLeaseTime(TimeSpan.Zero);
			}
		}
		return lease;
	}

	public bool SetBootSeqFromInt15(int nType)
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "SetBootSeqFromInt15", nType.ToString());
		}
		IntPtr bootSequence = INT15.GetBootSequence();
		int num = 0;
		int num2 = 0;
		if (bootSequence != IntPtr.Zero)
		{
			byte b;
			while ((b = Marshal.ReadByte(bootSequence, num)) != byte.MaxValue)
			{
				num++;
				num2 = ((b == 0) ? (num2 + 1) : 0);
				if (num2 == 4)
				{
					num -= 3;
					break;
				}
			}
		}
		int num3 = 0;
		byte[] array = new byte[num];
		if (nType != 0 && nType != 1)
		{
			for (int i = 0; i < num; i++)
			{
				byte b = (array[i] = Marshal.ReadByte(bootSequence, i));
				if (array[i] == 2)
				{
					num3 = i;
				}
			}
			array[num3] = array[0];
			array[0] = 2;
		}
		else
		{
			for (int j = 0; j < num; j++)
			{
				byte b = (array[j] = Marshal.ReadByte(bootSequence, j));
				if (array[j] == 1)
				{
					num3 = j;
				}
			}
			array[num3] = array[0];
			array[0] = 1;
		}
		return INT15.SetBootSequenceNB(array, num);
	}

	public bool StartBackupMachine()
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "StartBackupMachine", "1");
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
		if (registryKey != null)
		{
			if (registryKey.GetValue("InstallPath") != null)
			{
				string text = registryKey.GetValue("InstallPath")!.ToString();
				Process process = new Process();
				process.StartInfo.FileName = text + "\\BackupMachine.exe";
				process.Start();
				registryKey.Close();
				return true;
			}
			return false;
		}
		return false;
	}

	public bool LauncSetFDFolderExe(string InArg)
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "LauncSetFDFolderExe", InArg);
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
		if (registryKey != null)
		{
			if (registryKey.GetValue("InstallPath") != null)
			{
				string text = registryKey.GetValue("InstallPath")!.ToString();
				text += "\\SetFDFolder.exe";
				Process.Start(text, InArg);
				registryKey.Close();
				return true;
			}
			return false;
		}
		return false;
	}

	public bool SetMBR()
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "SetMBR", "1");
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
		if (registryKey != null)
		{
			if (registryKey.GetValue("InstallPath") != null)
			{
				string text = registryKey.GetValue("InstallPath")!.ToString();
				Process process = new Process();
				process.StartInfo.FileName = text + "\\MBRwrWin.exe";
				process.StartInfo.Arguments = "-directh";
				process.Start();
				registryKey.Close();
				return true;
			}
			return false;
		}
		return false;
	}

	public bool CheckD2DBIOS()
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "CheckD2DBIOS", "1");
		}
		return INT15.GetD2DBIOS();
	}

	public void DeleteFile(string filePath)
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "DeleteFile", filePath);
		}
		File.Delete(filePath);
	}

	public bool WriteLocalRegString(string RegSubKeyString, string RegKeyName, int RegKeyValue)
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "WriteLocalRegString", RegSubKeyString + "\\" + RegKeyName + "\\" + RegKeyValue);
		}
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(RegSubKeyString);
		try
		{
			registryKey.SetValue(RegKeyName, RegKeyValue);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public bool WriteLocalReg(string RegSubKeyString, string RegKeyName, object RegKeyValue, RegistryValueKind valueKind)
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "WriteLocalReg", RegSubKeyString + "\\" + RegKeyName + "\\" + RegKeyValue.ToString() + "\\" + valueKind);
		}
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(RegSubKeyString);
		try
		{
			registryKey.SetValue(RegKeyName, RegKeyValue, valueKind);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public bool IsNeedToExtractData()
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "IsNeedToExtractData", "1");
		}
		string text = FindAutorunPath();
		text += "\\Autorun.ini";
		bool result = true;
		WIN32.WIN32_FIND_DATA lpFindFileData;
		IntPtr intPtr = WIN32.FindFirstFile("C:\\Acer\\Empowering Technology\\eRecovery\\Autorun.ini", out lpFindFileData);
		if (intPtr != INVALID_HANDLE_VALUE)
		{
			WIN32.FindClose(intPtr);
			int num = 4096;
			byte[] array = new byte[4096];
			StringBuilder stringBuilder = new StringBuilder(4096);
			StringBuilder stringBuilder2 = new StringBuilder(32);
			StringBuilder stringBuilder3 = new StringBuilder(8);
			WIN32.GetPrivateProfileSectionNamesA(array, array.Length, text);
			string text2 = "";
			for (int i = 0; i < num; i++)
			{
				string text3 = ((array[i].ToString().CompareTo("0") == 0) ? "\0" : ((byte)(array[i] - 48)).ToString());
				if (text3.CompareTo("\0") == 0)
				{
					if (text2.CompareTo("") == 0)
					{
						break;
					}
					WIN32.GetPrivateProfileString(text2, "Filename", "xfail", stringBuilder, (uint)stringBuilder.Capacity, text);
					string lpFileName = stringBuilder.ToString();
					WIN32.WIN32_FIND_DATA lpFindFileData2;
					IntPtr intPtr2 = WIN32.FindFirstFile(lpFileName, out lpFindFileData2);
					if (intPtr2 == INVALID_HANDLE_VALUE)
					{
						result = false;
						i = num + 1;
					}
					else
					{
						WIN32.FindClose(intPtr2);
						WIN32.GetPrivateProfileString(text2, "Size", "xfail", stringBuilder2, (uint)stringBuilder2.Capacity, text);
						uint num2 = Convert.ToUInt32(stringBuilder2.ToString());
						if (lpFindFileData2.nFileSizeLow != num2)
						{
							result = false;
							i = num + 1;
						}
						else
						{
							WIN32.GetPrivateProfileString(text2, "Time", "xfail", stringBuilder3, (uint)stringBuilder3.Capacity, text);
							stringBuilder3.ToString();
						}
					}
					text2 = "";
				}
				else
				{
					text2 += text3;
				}
			}
		}
		else
		{
			result = false;
		}
		return result;
	}

	public bool GetSystemVolumnInfo()
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "GetSystemVolumnInfo", "1");
		}
		long num = 0L;
		num = GetSysVolumnSize("C:\\System Volume Information");
		num /= 1048576L;
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\acer\\eRecovery\\Main", RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue("SysVolSize", num, RegistryValueKind.DWord);
		}
		catch
		{
			return false;
		}
		return true;
	}

	private long GetSysVolumnSize(string pPath)
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "GetSysVolumnSize", pPath);
		}
		long num = 0L;
		string lpFileName = pPath + "\\*.*";
		WIN32.WIN32_FIND_DATA lpFindFileData;
		IntPtr intPtr = WIN32.FindFirstFile(lpFileName, out lpFindFileData);
		if (intPtr == INVALID_HANDLE_VALUE)
		{
			return 0L;
		}
		do
		{
			string cFileName = lpFindFileData.cFileName;
			if ((lpFindFileData.dwFileAttributes & 0x10) == 0)
			{
				num += (long)lpFindFileData.nFileSizeHigh * 4294967296L + lpFindFileData.nFileSizeLow;
			}
			else if (cFileName.CompareTo(".") != 0 && cFileName.CompareTo("..") != 0)
			{
				string pPath2 = pPath + "\\" + lpFindFileData.cFileName;
				num += GetSysVolumnSize(pPath2);
			}
		}
		while (WIN32.FindNextFile(intPtr, out lpFindFileData));
		WIN32.FindClose(intPtr);
		return num;
	}

	public bool ExtractData()
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "ExtractData", "1");
		}
		string text = FindAutorunPath();
		string path = text + "\\autorun.ini";
		string text2 = text + "\\autorun";
		if (Directory.Exists(text2))
		{
			try
			{
				File.SetAttributes(text2, FileAttributes.Normal);
				WIN32.SHFILEOPSTRUCT lpFileOp = default(WIN32.SHFILEOPSTRUCT);
				lpFileOp.hwnd = IntPtr.Zero;
				lpFileOp.wFunc = WIN32.FO_Func.FO_DELETE;
				lpFileOp.pFrom = text2 + "\0\0";
				lpFileOp.pTo = "";
				lpFileOp.fFlags = 3604;
				WIN32.SHFileOperation(ref lpFileOp);
			}
			catch (UnauthorizedAccessException)
			{
				return false;
			}
		}
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		m_szTmpHid = GetAvailableDrLetter();
		MountHiddenPartition(m_szTmpHid);
		wimFile = m_szTmpHid + "\\autorun\\swcd.wim";
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: true);
		if (registryKey.GetValue("InstallPath") != null)
		{
			applyDir = registryKey.GetValue("InstallPath")!.ToString();
			tmpDir = applyDir.Remove(applyDir.IndexOf("eRecovery"));
			registryKey.GetValue("InstallPath")!.ToString();
		}
		else
		{
			applyDir = "C:\\Acer\\Empowering Technology\\eRecovery";
			tmpDir = "C:\\Acer\\Empowering Technology";
		}
		if (File.Exists(wimFile))
		{
			SWCDExtractTimer = new System.Timers.Timer();
			SWCDExtractTimer.Elapsed += OnSWCDExtractTimedEvent;
			SWCDExtractTimer.Interval = 1000.0;
			SWCDExtractTimer.Enabled = true;
			return true;
		}
		return false;
	}

	private static int SWCDApplyCallback(int msgId, IntPtr param1, IntPtr param2, IntPtr unused)
	{
		param1.ToString();
		param1.ToString();
		int num = param1.ToInt32();
		int num2 = param2.ToInt32();
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\acer\\eRecovery\\Main");
		switch (msgId)
		{
		case 38015:
			try
			{
				registryKey.SetValue("SWCDErrorCode", num2);
			}
			catch
			{
			}
			break;
		case 38017:
			try
			{
				registryKey.SetValue("SWCDErrorCode", num2);
			}
			catch
			{
			}
			break;
		case 38020:
			try
			{
				registryKey.SetValue("SWCDErrorCode", num2);
			}
			catch
			{
			}
			break;
		case 38021:
			try
			{
				registryKey.SetValue("SWCDErrorCode", num2);
			}
			catch
			{
			}
			break;
		case 38008:
			try
			{
				registryKey.SetValue("SWCDPercent", num);
			}
			catch
			{
			}
			if (num >= 100)
			{
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
				string text = ((registryKey2.GetValue("InstallPath") == null) ? "C:\\Acer\\Empowering Technology\\eRecovery" : registryKey2.GetValue("InstallPath")!.ToString());
				string text2 = text + "\\autorun\\CheckFiles.exe";
				if (File.Exists(text2))
				{
					WIN32.PROCESS_INFORMATION lpProcessInformation = default(WIN32.PROCESS_INFORMATION);
					WIN32.STARTUPINFO lpStartupInfo = default(WIN32.STARTUPINFO);
					WIN32.SECURITY_ATTRIBUTES lpProcessAttributes = default(WIN32.SECURITY_ATTRIBUTES);
					WIN32.SECURITY_ATTRIBUTES lpThreadAttributes = default(WIN32.SECURITY_ATTRIBUTES);
					lpProcessAttributes.nLength = Marshal.SizeOf((object)lpProcessAttributes);
					lpThreadAttributes.nLength = Marshal.SizeOf((object)lpThreadAttributes);
					WIN32.CreateProcess(text2, null, ref lpProcessAttributes, ref lpThreadAttributes, bInheritHandles: false, 0u, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation);
				}
			}
			break;
		}
		return 0;
	}

	private void SampleApplyCleanup(IntPtr hwim, IntPtr himg, WIN32.WIMMessageCallback callback, bool bExtractSuccess)
	{
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (bLog)
		{
			LogToFile("eRecoveryService", "SampleApplyCleanup", lastWin32Error.ToString());
		}
		if (!bExtractSuccess)
		{
			WriteLocalRegString("Software\\acer\\eRecovery\\Main", "SWCDErrorCode", lastWin32Error);
		}
		if (himg != IntPtr.Zero && !WIN32.WIMCloseHandle(himg) && lastWin32Error == 0)
		{
			lastWin32Error = Marshal.GetLastWin32Error();
		}
		if (hwim != IntPtr.Zero && !WIN32.WIMCloseHandle(hwim) && lastWin32Error == 0)
		{
			lastWin32Error = Marshal.GetLastWin32Error();
		}
		if (callback != null && !WIN32.WIMUnregisterMessageCallback(IntPtr.Zero, callback) && lastWin32Error == 0)
		{
			lastWin32Error = Marshal.GetLastWin32Error();
		}
		WIN32.SetLastError((uint)lastWin32Error);
	}

	private void OnSWCDExtractTimedEvent(object sender, ElapsedEventArgs e)
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "OnSWCDExtractTimedEvent", "1");
		}
		SWCDExtractTimer.Enabled = false;
		IntPtr zero = IntPtr.Zero;
		IntPtr zero2 = IntPtr.Zero;
		int lpdwCreationResult = 0;
		WIN32.WIMMessageCallback wIMMessageCallback = SWCDApplyCallback;
		int dwImageIndex = 1;
		if (WIN32.WIMRegisterMessageCallback(IntPtr.Zero, wIMMessageCallback, IntPtr.Zero) == uint.MaxValue)
		{
			WriteLocalRegString("Software\\acer\\eRecovery\\Main", "SWCDErrorCode", 999);
			return;
		}
		zero = WIN32.WIMCreateFile(wimFile, 2147483648u, 3, 0, 0, lpdwCreationResult);
		if (zero == IntPtr.Zero)
		{
			SampleApplyCleanup(zero, zero2, wIMMessageCallback, bExtractSuccess: false);
			return;
		}
		if (!WIN32.WIMSetTemporaryPath(zero, tmpDir))
		{
			SampleApplyCleanup(zero, zero2, wIMMessageCallback, bExtractSuccess: false);
			return;
		}
		zero2 = WIN32.WIMLoadImage(zero, dwImageIndex);
		if (zero2 == IntPtr.Zero)
		{
			SampleApplyCleanup(zero, zero2, wIMMessageCallback, bExtractSuccess: false);
			return;
		}
		if (!WIN32.WIMApplyImage(zero2, applyDir, 0))
		{
			SampleApplyCleanup(zero, zero2, wIMMessageCallback, bExtractSuccess: false);
			WriteLocalRegString("Software\\acer\\eRecovery\\Main", "SWCDErrorCode", 999);
			return;
		}
		if (Marshal.GetLastWin32Error() != 0)
		{
			WIN32.SetLastError(0u);
		}
		SampleApplyCleanup(zero, zero2, wIMMessageCallback, bExtractSuccess: true);
		if (Marshal.GetLastWin32Error() != 0)
		{
			WriteLocalRegString("Software\\acer\\eRecovery\\Main", "SWCDErrorCode", 999);
		}
	}

	private void CallProcessNoWait(string szCommand)
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "CallProcessNoWait", szCommand);
		}
		WIN32.PROCESS_INFORMATION lpProcessInformation = default(WIN32.PROCESS_INFORMATION);
		WIN32.STARTUPINFO lpStartupInfo = default(WIN32.STARTUPINFO);
		WIN32.SECURITY_ATTRIBUTES lpProcessAttributes = default(WIN32.SECURITY_ATTRIBUTES);
		WIN32.SECURITY_ATTRIBUTES lpThreadAttributes = default(WIN32.SECURITY_ATTRIBUTES);
		lpProcessAttributes.nLength = Marshal.SizeOf((object)lpProcessAttributes);
		lpThreadAttributes.nLength = Marshal.SizeOf((object)lpThreadAttributes);
		if (!WIN32.CreateProcess(null, szCommand, ref lpProcessAttributes, ref lpThreadAttributes, bInheritHandles: false, 0u, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation))
		{
		}
	}

	private bool MountHiddenPartition(string szDr)
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "MountHiddenPartition", szDr);
		}
		bool flag = false;
		int num = 0;
		while (!flag && num < 5)
		{
			if (!(flag = WIN32.DefineDosDevice(1u, szDr, "\\Device\\Harddisk0\\Partition1")))
			{
				Thread.Sleep(1000);
			}
		}
		return flag;
	}

	private string GetAvailableDrLetter()
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "GetAvailableDrLetter", "1");
		}
		uint logicalDrives = WIN32.GetLogicalDrives();
		string text = "";
		char c = 'D';
		int num = 3;
		for (num = 3; num < 26; num++)
		{
			if (((logicalDrives >> num) & (true ? 1u : 0u)) != 0)
			{
				c = (char)(c + 1);
				continue;
			}
			text = c.ToString();
			break;
		}
		text += ":";
		if (num == 26)
		{
			text = "";
		}
		return text;
	}

	public bool UnMountHiddenPartition()
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "UnMountHiddenPartition", "1");
		}
		bool flag = false;
		int num = 0;
		if (m_szTmpHid.Length != 0)
		{
			while (!flag && num < 5 && !(flag = WIN32.DefineDosDevice(7u, m_szTmpHid, "\\Device\\Harddisk0\\Partition1")))
			{
				Thread.Sleep(1000);
				num++;
			}
		}
		return flag;
	}

	private string FindAutorunPath()
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "FindAutorunPath", "1");
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
		if (registryKey.GetValue("InstallPath") != null)
		{
			return registryKey.GetValue("InstallPath")!.ToString();
		}
		return "C:\\Acer\\Empowering Technology\\eRecovery";
	}

	public void LaunchCheckFiles()
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "LaunchCheckFiles", "1");
		}
		string text = FindAutorunPath();
		string text2 = text + "\\autorun\\CheckFiles.exe";
		if (File.Exists(text2))
		{
			WIN32.PROCESS_INFORMATION lpProcessInformation = default(WIN32.PROCESS_INFORMATION);
			WIN32.STARTUPINFO lpStartupInfo = default(WIN32.STARTUPINFO);
			WIN32.SECURITY_ATTRIBUTES lpProcessAttributes = default(WIN32.SECURITY_ATTRIBUTES);
			WIN32.SECURITY_ATTRIBUTES lpThreadAttributes = default(WIN32.SECURITY_ATTRIBUTES);
			lpProcessAttributes.nLength = Marshal.SizeOf((object)lpProcessAttributes);
			lpThreadAttributes.nLength = Marshal.SizeOf((object)lpThreadAttributes);
			WIN32.CreateProcess(text2, null, ref lpProcessAttributes, ref lpThreadAttributes, bInheritHandles: false, 0u, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation);
		}
	}

	public bool UnMountHiddenPartition(string m_szTempHid)
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "UnMountHiddenPartition", m_szTempHid);
		}
		bool flag = false;
		int num = 0;
		while (!flag && num < 5)
		{
			if (!(flag = WIN32.DefineDosDevice(7u, m_szTempHid, "\\Device\\Harddisk0\\Partition1")))
			{
				Thread.Sleep(1000);
			}
		}
		return flag;
	}

	public bool SetHiddenPartPassHint(string szPass, string szHint)
	{
		if (bLog)
		{
			LogToFile("eRecoveryService", "SetHiddenPartPassHint", szPass + " " + szHint);
		}
		string availableDrLetter = GetAvailableDrLetter();
		string text = availableDrLetter + "\\aimdrs.dat";
		MountHiddenPartition(availableDrLetter);
		if (szPass.Length == 0 && File.Exists(text))
		{
			File.SetAttributes(text, FileAttributes.Normal);
			File.Delete(text);
			UnMountHiddenPartition(availableDrLetter);
			return true;
		}
		if (szPass.Length > 0 && File.Exists(text))
		{
			File.SetAttributes(text, FileAttributes.Normal);
		}
		WIN32.WritePrivateProfileString("MyData", "PD", szPass, text);
		WIN32.WritePrivateProfileString("MyData", "HT", szHint, text);
		File.SetAttributes(text, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
		UnMountHiddenPartition(availableDrLetter);
		return true;
	}

	private bool NeedLog()
	{
		bool result = false;
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Acer\\Empowering Technology 2.5\\Log\\eRecovery", writable: false);
			if (Convert.ToInt32(registryKey.GetValue("Service")) != 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	private void LogStart()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\acer\\eRecovery", writable: false);
			if (registryKey.GetValue("InstallPath") != null)
			{
				szLogPath = registryKey.GetValue("InstallPath")!.ToString();
				int num = szLogPath.IndexOf("eRecovery");
				if (num != -1)
				{
					szLogPath = szLogPath.Remove(num);
					szLogPath += "Logs";
				}
				else
				{
					szLogPath = "C:\\Acer\\Empowering Technology\\Logs";
				}
			}
		}
		catch
		{
		}
		if (!Directory.Exists(szLogPath))
		{
			Directory.CreateDirectory(szLogPath);
		}
	}

	private void LogToFile(string lpAppName, string lpKeyName, string lpString)
	{
		DateTime now = DateTime.Now;
		WIN32.WritePrivateProfileString(lpAppName, "[" + now.ToString() + "." + now.Millisecond + "] " + lpKeyName, lpString, szLogPath + "\\eRecovery_Service.Log");
	}

	public int IsBitLockerWorking()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		string text = "";
		string text2 = "";
		ConnectionOptions val = null;
		val = new ConnectionOptions();
		val.set_Username((string)null);
		val.set_Password((string)null);
		ManagementScope val2 = new ManagementScope("root\\cimv2\\security\\microsoftvolumeencryption", val);
		try
		{
			val2.Connect();
		}
		catch
		{
			return 0;
		}
		ManagementClass val3 = new ManagementClass("root\\cimv2\\security\\microsoftvolumeencryption:Win32_EncryptableVolume");
		((ManagementObject)val3).set_Scope(val2);
		ManagementObjectCollection instances = val3.GetInstances();
		if (instances != null)
		{
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			while (enumerator.MoveNext())
			{
				text = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Properties().get_Item("DeviceID").get_Value()
					.ToString()!.Trim();
				try
				{
					text2 = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Properties().get_Item("DriveLetter").get_Value()
						.ToString()!.Trim();
				}
				catch
				{
				}
				if (text2.CompareTo("C:") == 0)
				{
					break;
				}
			}
			text = text.Remove(0, text.IndexOf("Volume"));
			text = text.Remove(text.IndexOf("}\\") + 1, 1);
			_ = "Win32_EncryptableVolume.DeviceID=\"\\\\\\\\?\\\\" + text + "\\\\\"";
			ManagementPath val4 = new ManagementPath("Win32_EncryptableVolume.DeviceID=\"\\\\\\\\?\\\\" + text + "\\\\\"");
			ManagementObject val5 = new ManagementObject(val2, val4, (ObjectGetOptions)null);
			ManagementBaseObject val6 = val5.InvokeMethod("GetConversionStatus", (ManagementBaseObject)null, (InvokeMethodOptions)null);
			return Convert.ToInt32(val6.get_Item("ConversionStatus").ToString());
		}
		return 0;
	}
}
