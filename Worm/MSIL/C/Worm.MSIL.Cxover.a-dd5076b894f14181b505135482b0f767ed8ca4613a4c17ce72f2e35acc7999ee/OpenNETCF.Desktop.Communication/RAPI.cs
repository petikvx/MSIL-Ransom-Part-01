using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace OpenNETCF.Desktop.Communication;

public class RAPI : IDisposable
{
	public enum RAPIFileAttributes
	{
		ReadOnly = 1,
		Hidden = 2,
		System = 4,
		Directory = 0x10,
		Archive = 0x20,
		InROM = 0x40,
		Normal = 0x80,
		Temporary = 0x100,
		Sparse = 0x200,
		ReparsePt = 0x400,
		Compressed = 0x800,
		ROMModule = 0x2000
	}

	public enum RAPIFileTime : short
	{
		CreateTime = 1,
		LastModifiedTime,
		LastAccessTime
	}

	internal struct RAPIINIT
	{
		public int cbSize;

		public IntPtr heRapiInit;

		public int hrRapiInit;
	}

	internal struct PROCESS_INFORMATION
	{
		public IntPtr hProcess;

		public IntPtr hThread;

		public int dwProcessID;

		public int dwThreadID;

		public PROCESS_INFORMATION(bool NewInstance)
		{
			hProcess = IntPtr.Zero;
			hThread = IntPtr.Zero;
			dwProcessID = 0;
			dwThreadID = 0;
		}
	}

	internal const int ERROR_NO_MORE_FILES = 18;

	private const short INVALID_HANDLE_VALUE = -1;

	private const short FILE_ATTRIBUTE_NORMAL = 128;

	private const short CREATE_NEW = 1;

	private const short CREATE_ALWAYS = 2;

	private const uint GENERIC_WRITE = 1073741824u;

	private const uint GENERIC_READ = 2147483648u;

	private const short OPEN_EXISTING = 3;

	private Thread m_initThread;

	private IntPtr m_hInitEvent = IntPtr.Zero;

	private int m_InitResult = 0;

	private bool m_connected = false;

	private bool m_killThread = false;

	private bool m_devicepresent = false;

	private RAPIINIT m_ri;

	private ActiveSync m_activesync;

	private int m_timeout = 0;

	private CFPerformanceMonitor m_perfmon;

	private uint WAIT_OBJECT_0 = 0u;

	private uint WAIT_ABANDONED = 128u;

	private uint WAIT_FAILED = uint.MaxValue;

	private int FILE_SHARE_READ = 1;

	public ActiveSync ActiveSync => m_activesync;

	public CFPerformanceMonitor CFPerformanceMonitor => m_perfmon;

	public bool Connected => m_connected;

	public bool DevicePresent => m_devicepresent;

	public event RAPIConnectedHandler RAPIConnected;

	public event RAPIConnectedHandler RAPIDisconnected;

	public RAPI()
	{
		m_activesync = new ActiveSync();
		m_perfmon = new CFPerformanceMonitor(this);
		m_activesync.Disconnect += activesync_Disconnect;
		m_activesync.Active += m_activesync_Active;
		m_activesync.BeginListen();
	}

	~RAPI()
	{
		m_activesync.EndListen();
		if (m_connected)
		{
			CeRapiUninit();
		}
		Dispose();
	}

	public void Connect()
	{
		Connect(WaitForInit: true, 0);
	}

	public void Connect(bool WaitForInit)
	{
		Connect(WaitForInit, 0);
	}

	public void Connect(bool WaitForInit, int TimeoutSeconds)
	{
		int num = 0;
		m_timeout = TimeoutSeconds;
		if (WaitForInit)
		{
			num = CeRapiInit();
			if (num != 0)
			{
				CeRapiGetError();
				Marshal.ThrowExceptionForHR(num);
			}
			lock (this)
			{
				m_connected = true;
			}
			if (this.RAPIConnected != null)
			{
				this.RAPIConnected();
			}
			return;
		}
		m_ri = default(RAPIINIT);
		m_ri.cbSize = Marshal.SizeOf((object)m_ri);
		m_ri.hrRapiInit = m_InitResult;
		m_hInitEvent = CreateEvent(IntPtr.Zero, 0, 0, "OpenNETCF.RAPI");
		if ((int)m_hInitEvent == -1)
		{
			throw new RAPIException("Failed to Initialize RAPI");
		}
		m_ri.heRapiInit = m_hInitEvent;
		num = CeRapiInitEx(ref m_ri);
		if (num != 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
		m_initThread = new Thread(InitThreadProc);
		m_initThread.Start();
	}

	public void Disconnect()
	{
		if (m_connected)
		{
			lock (this)
			{
				CeRapiUninit();
				m_connected = false;
			}
		}
	}

	private void InitThreadProc()
	{
		int num = 0;
		int num2 = m_timeout * 4;
		bool flag = num2 < 0;
		while (true)
		{
			if (m_killThread)
			{
				return;
			}
			num = WaitForSingleObject(m_ri.heRapiInit, 250u);
			if (num != WAIT_FAILED && num != WAIT_ABANDONED)
			{
				if (flag || num2-- >= 0)
				{
					if (num == WAIT_OBJECT_0)
					{
						if (m_InitResult != 0)
						{
							Marshal.ThrowExceptionForHR(m_InitResult);
						}
						lock (this)
						{
							m_connected = true;
						}
						if (this.RAPIConnected != null)
						{
							this.RAPIConnected();
						}
						break;
					}
					continue;
				}
				throw new RAPIException("Timeout waiting for device connection");
			}
			throw new RAPIException("Failed to Initialize RAPI");
		}
		CloseHandle(m_hInitEvent);
	}

	public bool DeviceFileExists(string RemoteFileName)
	{
		CheckConnection();
		uint num = CeGetFileAttributes(RemoteFileName);
		if (num == uint.MaxValue)
		{
			return false;
		}
		return true;
	}

	public void CopyFileFromDevice(string LocalFileName, string RemoteFileName)
	{
		CopyFileFromDevice(LocalFileName, RemoteFileName, Overwrite: false);
	}

	public void CopyFileFromDevice(string LocalFileName, string RemoteFileName, bool Overwrite)
	{
		CheckConnection();
		IntPtr zero = IntPtr.Zero;
		int lpNumberOfbytesRead = 0;
		byte[] array = new byte[4096];
		zero = CeCreateFile(RemoteFileName, 2147483648u, 0, 0, 3, 128, 0);
		if ((int)zero == -1)
		{
			throw new RAPIException("Could not open remote file");
		}
		FileStream fileStream = new FileStream(LocalFileName, (!Overwrite) ? FileMode.CreateNew : FileMode.Create, FileAccess.Write);
		CeReadFile(zero, array, 4096, ref lpNumberOfbytesRead, 0);
		while (lpNumberOfbytesRead > 0)
		{
			fileStream.Write(array, 0, lpNumberOfbytesRead);
			if (!Convert.ToBoolean(CeReadFile(zero, array, 4096, ref lpNumberOfbytesRead, 0)))
			{
				CeCloseHandle(zero);
				fileStream.Close();
				throw new RAPIException("Failed to read device data");
			}
		}
		CeCloseHandle(zero);
		fileStream.Flush();
		fileStream.Close();
	}

	public void CopyFileToDevice(string LocalFileName, string RemoteFileName)
	{
		CopyFileToDevice(LocalFileName, RemoteFileName, Overwrite: false);
	}

	public void CopyFileToDevice(string LocalFileName, string RemoteFileName, bool Overwrite)
	{
		CheckConnection();
		IntPtr zero = IntPtr.Zero;
		int num = 0;
		int lpNumberOfbytesWritten = 0;
		int num2 = 0;
		int dwCreationDisposition = ((!Overwrite) ? 1 : 2);
		byte[] array = new byte[4096];
		zero = CeCreateFile(RemoteFileName, 1073741824u, 0, 0, dwCreationDisposition, 128, 0);
		if ((int)zero == -1)
		{
			throw new RAPIException("Could not create remote file");
		}
		FileStream fileStream = new FileStream(LocalFileName, FileMode.Open);
		num = fileStream.Read(array, num2, array.Length);
		while (num > 0)
		{
			num2 += num;
			if (Convert.ToBoolean(CeWriteFile(zero, array, num, ref lpNumberOfbytesWritten, 0)))
			{
				try
				{
					num = fileStream.Read(array, 0, array.Length);
				}
				catch (Exception)
				{
					num = 0;
				}
				continue;
			}
			CeCloseHandle(zero);
			throw new RAPIException("Could not write to remote file");
		}
		fileStream.Close();
		CeCloseHandle(zero);
		SetDeviceFileTime(RemoteFileName, RAPIFileTime.CreateTime, File.GetCreationTime(LocalFileName));
		SetDeviceFileTime(RemoteFileName, RAPIFileTime.LastAccessTime, DateTime.Now);
		SetDeviceFileTime(RemoteFileName, RAPIFileTime.LastModifiedTime, File.GetLastWriteTime(LocalFileName));
	}

	public void CopyFileOnDevice(string SourceFile, string DestinationFile)
	{
		CopyFileOnDevice(SourceFile, DestinationFile, Overwrite: false);
	}

	public void CopyFileOnDevice(string ExistingFileName, string NewFileName, bool Overwrite)
	{
		CheckConnection();
		if (!Convert.ToBoolean(CeCopyFile(ExistingFileName, NewFileName, Convert.ToInt32(!Overwrite))))
		{
			throw new RAPIException("Cannot copy file");
		}
	}

	public void DeleteDeviceFile(string FileName)
	{
		CheckConnection();
		if (!Convert.ToBoolean(CeDeleteFile(FileName)))
		{
			throw new RAPIException("Could not delete file");
		}
	}

	public void MoveDeviceFile(string ExistingFileName, string NewFileName)
	{
		CheckConnection();
		if (!Convert.ToBoolean(CeMoveFile(ExistingFileName, NewFileName)))
		{
			throw new RAPIException("Cannot move file");
		}
	}

	public RAPIFileAttributes GetDeviceFileAttributes(string FileName)
	{
		CheckConnection();
		uint num = 0u;
		num = CeGetFileAttributes(FileName);
		if (num == uint.MaxValue)
		{
			throw new RAPIException("Could not get file attributes");
		}
		return (RAPIFileAttributes)num;
	}

	public void SetDeviceFileAttributes(string FileName, RAPIFileAttributes Attributes)
	{
		CheckConnection();
		if (!Convert.ToBoolean(CeSetFileAttributes(FileName, (uint)Attributes)))
		{
			throw new RAPIException("Cannot set device file attributes");
		}
	}

	public void RemoveDeviceDirectory(string PathName, bool Recurse)
	{
		CheckConnection();
		if (!Recurse)
		{
			if (!Convert.ToBoolean(CeRemoveDirectory(PathName)))
			{
				throw new RAPIException("Could not remove directory");
			}
			return;
		}
		FileList fileList = null;
		StringBuilder stringBuilder = new StringBuilder(PathName);
		stringBuilder.Append("\\*");
		CheckConnection();
		fileList = EnumFiles(stringBuilder.ToString());
		if (fileList != null)
		{
			foreach (FileInformation item in fileList)
			{
				if (item.FileAttributes.ToString() == "16")
				{
					StringBuilder stringBuilder2 = new StringBuilder(PathName);
					stringBuilder2.Append("\\");
					stringBuilder2.Append(item.FileName);
					RemoveDeviceDirectory(stringBuilder2.ToString(), Recurse: true);
				}
				else
				{
					StringBuilder stringBuilder3 = new StringBuilder(PathName);
					stringBuilder3.Append("\\");
					stringBuilder3.Append(item.FileName);
					SetDeviceFileAttributes(stringBuilder3.ToString(), RAPIFileAttributes.Normal);
					DeleteDeviceFile(stringBuilder3.ToString());
				}
			}
			RemoveDeviceDirectory(PathName);
		}
		else if (!Convert.ToBoolean(CeRemoveDirectory(PathName)))
		{
			throw new RAPIException("Could not remove directory");
		}
	}

	public string GetDeviceShortcutTarget(string shortcutPath)
	{
		string text = new string(' ', 255);
		if (!Convert.ToBoolean(CeSHGetShortcutTarget(shortcutPath, text, 255)))
		{
			throw new RAPIException("Could not get target");
		}
		return text.Trim();
	}

	public void CreateDeviceShortcut(string ShortcutName, string Target)
	{
		CheckConnection();
		if (!Convert.ToBoolean(CeSHCreateShortcut(ShortcutName, Target)))
		{
			throw new RAPIException("Could not create shortcut");
		}
	}

	public void RemoveDeviceDirectory(string PathName)
	{
		RemoveDeviceDirectory(PathName, Recurse: false);
	}

	public void CreateDeviceDirectory(string PathName)
	{
		CheckConnection();
		if (!Convert.ToBoolean(CeCreateDirectory(PathName, 0u)))
		{
			throw new RAPIException("Could not create directory");
		}
	}

	public long GetDeviceFileSize(string FileName)
	{
		CheckConnection();
		IntPtr zero = IntPtr.Zero;
		uint num = 0u;
		uint lpFileSizeHigh = 0u;
		zero = CeCreateFile(FileName, 0u, FILE_SHARE_READ, 0, 3, 0, 0);
		if ((int)zero == -1)
		{
			throw new RAPIException("Could not open remote file");
		}
		num = CeGetFileSize(zero, ref lpFileSizeHigh);
		if (num == uint.MaxValue)
		{
			CeCloseHandle(zero);
			throw new RAPIException("Could not get file size");
		}
		CeCloseHandle(zero);
		return num + lpFileSizeHigh;
	}

	public DateTime GetDeviceFileTime(string FileName, RAPIFileTime DesiredTime)
	{
		CheckConnection();
		IntPtr zero = IntPtr.Zero;
		long lpCreationTime = 0L;
		long lpLastAccessTime = 0L;
		long lpLastWriteTime = 0L;
		zero = CeCreateFile(FileName, 2147483648u, FILE_SHARE_READ, 0, 3, 0, 0);
		if ((int)zero == -1)
		{
			throw new RAPIException("Could not open remote file");
		}
		if (!Convert.ToBoolean(CeGetFileTime(zero, ref lpCreationTime, ref lpLastAccessTime, ref lpLastWriteTime)))
		{
			CeCloseHandle(zero);
			throw new RAPIException("Could not get file time");
		}
		CeCloseHandle(zero);
		return DesiredTime switch
		{
			RAPIFileTime.CreateTime => DateTime.FromFileTime(lpCreationTime), 
			RAPIFileTime.LastModifiedTime => DateTime.FromFileTime(lpLastAccessTime), 
			RAPIFileTime.LastAccessTime => DateTime.FromFileTime(lpLastWriteTime), 
			_ => throw new RAPIException("Invalid DesiredTime parameter"), 
		};
	}

	public void SetDeviceFileTime(string FileName, RAPIFileTime DesiredTime, DateTime NewTime)
	{
		CheckConnection();
		IntPtr zero = IntPtr.Zero;
		zero = CeCreateFile(FileName, 1073741824u, FILE_SHARE_READ, 0, 3, 0, 0);
		if ((int)zero == -1)
		{
			throw new RAPIException("Could not open remote file");
		}
		SYSTEMTIME sYSTEMTIME = new SYSTEMTIME(NewTime);
		long lpLastAccessTime = sYSTEMTIME;
		long lpCreationTime = 0L;
		switch (DesiredTime)
		{
		default:
			throw new RAPIException("Invalid DesiredTime parameter");
		case RAPIFileTime.CreateTime:
			if (!Convert.ToBoolean(CeSetFileTime(zero, ref lpLastAccessTime, ref lpCreationTime, ref lpCreationTime)))
			{
				CeCloseHandle(zero);
				throw new RAPIException("Could not get file time");
			}
			break;
		case RAPIFileTime.LastModifiedTime:
			if (!Convert.ToBoolean(CeSetFileTime(zero, ref lpCreationTime, ref lpCreationTime, ref lpLastAccessTime)))
			{
				CeCloseHandle(zero);
				throw new RAPIException("Could not get file time");
			}
			break;
		case RAPIFileTime.LastAccessTime:
			if (!Convert.ToBoolean(CeSetFileTime(zero, ref lpCreationTime, ref lpLastAccessTime, ref lpCreationTime)))
			{
				CeCloseHandle(zero);
				throw new RAPIException("Could not get file time");
			}
			break;
		}
		CeCloseHandle(zero);
	}

	public void CreateProcess(string FileName, string CommandLine)
	{
		CheckConnection();
		if (CeCreateProcess(pi: new PROCESS_INFORMATION(NewInstance: true), pszImageName: FileName, pszCmdLine: CommandLine, psaProcess: IntPtr.Zero, psaThread: IntPtr.Zero, fInheritHandles: 0, fdwCreate: 0, pvEnvironment: IntPtr.Zero, pszCurDir: IntPtr.Zero, psiStartInfo: IntPtr.Zero) == 0)
		{
			throw new RAPIException("Error " + CeGetLastError().ToString("x") + ": Cannot Create Process");
		}
	}

	public void Invoke(string DLLPath, string FunctionName, byte[] InputData, out byte[] OutputData)
	{
		CheckConnection();
		uint pcbOutput = 0u;
		IntPtr ppOutput = IntPtr.Zero;
		IntPtr intPtr = Marshal.AllocHGlobal(InputData.Length);
		for (int i = 0; i < InputData.Length; i++)
		{
			Marshal.WriteInt16(intPtr, i, InputData[i]);
		}
		CeRapiInvoke(DLLPath, FunctionName, (uint)InputData.Length, intPtr, out pcbOutput, out ppOutput, IntPtr.Zero, 0u);
		OutputData = new byte[pcbOutput];
		Marshal.Copy(ppOutput, OutputData, 0, (int)pcbOutput);
		Marshal.FreeHGlobal(ppOutput);
	}

	public FileList EnumFiles(string FileName)
	{
		CheckConnection();
		FileList fileList = null;
		IntPtr zero = IntPtr.Zero;
		FileInformation fileInformation = new FileInformation();
		zero = CeFindFirstFile(FileName, fileInformation);
		if (zero != (IntPtr)(-1))
		{
			fileList = new FileList();
			fileList.Add(fileInformation);
			fileInformation = new FileInformation();
			while (CeFindNextFile(zero, fileInformation) != 0)
			{
				fileList.Add(fileInformation);
				fileInformation = new FileInformation();
			}
			CeFindClose(zero);
		}
		return fileList;
	}

	public void GetDeviceSystemInfo(out SYSTEM_INFO pSI)
	{
		CheckConnection();
		try
		{
			CeGetSystemInfo(out pSI);
		}
		catch (Exception)
		{
			throw new RAPIException("Error retrieving system info.");
		}
	}

	public string GetDeviceSystemFolderPath(SystemFolders Folder)
	{
		CheckConnection();
		StringBuilder stringBuilder = new StringBuilder(260);
		if (!Convert.ToBoolean(CeGetSpecialFolderPath((int)Folder, 260u, stringBuilder)))
		{
			throw new RAPIException("Cannot get folder path!");
		}
		return stringBuilder.ToString();
	}

	internal void CheckConnection()
	{
		if (!m_devicepresent)
		{
			throw new RAPIException("No connected device.");
		}
	}

	public void GetDeviceSystemPowerStatus(out SYSTEM_POWER_STATUS_EX PowerStatus)
	{
		CheckConnection();
		try
		{
			CeGetSystemPowerStatusEx(out PowerStatus, fUpdate: true);
		}
		catch (Exception)
		{
			throw new RAPIException("Error retrieving system power status.");
		}
	}

	public void GetDeviceStoreInformation(out STORE_INFORMATION StoreInfo)
	{
		CheckConnection();
		try
		{
			CeGetStoreInformation(out StoreInfo);
		}
		catch (Exception)
		{
			throw new RAPIException("Error retrieving store information.");
		}
	}

	public void GetDeviceVersion(out OSVERSIONINFO VersionInfo)
	{
		CheckConnection();
		VersionInfo.dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFO));
		if (!CeGetVersionEx(out VersionInfo))
		{
			throw new RAPIException("Error retrieving version information.", Marshal.GetLastWin32Error());
		}
	}

	public void GetDeviceMemoryStatus(out MEMORYSTATUS ms)
	{
		CheckConnection();
		CeGlobalMemoryStatus(out ms);
	}

	public int GetDeviceCapabilities(DeviceCaps CapabiltyToGet)
	{
		CheckConnection();
		return CeGetDesktopDeviceCaps((int)CapabiltyToGet);
	}

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr CeCreateFile(string lpFileName, uint dwDesiredAccess, int dwShareMode, int lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr CreateEvent(IntPtr lpEventAttributes, int bManualReset, int bInitialState, string lpName);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern int CloseHandle(IntPtr hObject);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeRapiInitEx([MarshalAs(UnmanagedType.Struct)] ref RAPIINIT pRapiInit);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeRapiInit();

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeRapiGetError();

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeRapiUninit();

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeWriteFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfbytesToWrite, ref int lpNumberOfbytesWritten, int lpOverlapped);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeCopyFile(string lpExistingFileName, string lpNewFileName, int bFailIfExists);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeDeleteFile(string lpFileName);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeMoveFile(string lpExistingFileName, string lpNewFileName);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern uint CeGetFileAttributes(string lpFileName);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeSetFileAttributes(string lpFileName, uint dwFileAttributes);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeRemoveDirectory(string lpPathName);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeCreateDirectory(string lpPathName, uint lpSecurityAttributes);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern uint CeGetFileSize(IntPtr hFile, ref uint lpFileSizeHigh);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeCloseHandle(IntPtr hObject);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeGetFileTime(IntPtr hFile, ref long lpCreationTime, ref long lpLastAccessTime, ref long lpLastWriteTime);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode)]
	internal static extern int CeSetFileTime(IntPtr hFile, ref long lpCreationTime, ref long lpLastAccessTime, ref long lpLastWriteTime);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeGetLastError();

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeReadFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfbytesToRead, ref int lpNumberOfbytesRead, int lpOverlapped);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeCreateProcess(string pszImageName, string pszCmdLine, IntPtr psaProcess, IntPtr psaThread, int fInheritHandles, int fdwCreate, IntPtr pvEnvironment, IntPtr pszCurDir, IntPtr psiStartInfo, PROCESS_INFORMATION pi);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeRapiInvoke(string pDllPath, string pFunctionName, uint cbInput, IntPtr pInput, out uint pcbOutput, out IntPtr ppOutput, IntPtr ppIRAPIStream, uint dwReserved);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr CeFindFirstFile(string lpFileName, byte[] lpFindFileData);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeFindNextFile(IntPtr hFindFile, byte[] lpFindFileData);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeFindClose(IntPtr hFindFile);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeSHCreateShortcut(string pShortcutName, string pTarget);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeSHGetShortcutTarget(string lpszShortcut, string lpszTarget, int cbMax);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeSetEndOfFile(int hFile);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeGetSystemInfo(out SYSTEM_INFO pSI);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeGetStoreInformation(out STORE_INFORMATION lpsi);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool CeGetSystemPowerStatusEx(out SYSTEM_POWER_STATUS_EX pStatus, bool fUpdate);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeGetSpecialFolderPath(int nFolder, uint nBufferLength, StringBuilder lpBuffer);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool CeGetVersionEx(out OSVERSIONINFO lpVersionInformation);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern void CeGlobalMemoryStatus(out MEMORYSTATUS msce);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int CeGetDesktopDeviceCaps(int nIndex);

	public void Dispose()
	{
		lock (this)
		{
			m_killThread = true;
		}
	}

	private void activesync_Disconnect()
	{
		if (m_devicepresent)
		{
			CeRapiUninit();
			m_devicepresent = false;
		}
		lock (this)
		{
			m_connected = false;
		}
		if (this.RAPIDisconnected != null)
		{
			this.RAPIDisconnected();
		}
	}

	private void m_activesync_Active()
	{
		m_devicepresent = true;
	}
}
