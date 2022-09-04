using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Lexplorer;

internal static class Class3
{
	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private const int MOUSEEVENTF_RIGHTDOWN = 8;

	private const int MOUSEEVENTF_RIGHTUP = 16;

	private const int MOUSEEVENTF_MIDDLEDOWN = 32;

	private const int MOUSEEVENTF_MIDDLEUP = 64;

	private const int MOUSEEVENTF_WHEEL = 2048;

	private const int WHEEL_DELTA = 120;

	private const int KEYEVENTF_EXTENDEDKEY = 1;

	private const int KEYEVENTF_KEYUP = 2;

	private const int KEYEVENTF_SCANCODE = 8;

	private const string REGISTRY_PATH_USER_CHOICE_WIN7 = "Software\\Microsoft\\Windows\\Shell\\Associations\\UrlAssociations\\http\\UserChoice";

	public static string GetFileMd5(string filename)
	{
		using MD5 mD = MD5.Create();
		using FileStream inputStream = File.OpenRead(filename);
		byte[] array = mD.ComputeHash(inputStream);
		string text = "";
		for (int i = 0; i < array.Length; i++)
		{
			text += array[i].ToString("x2");
		}
		return text;
	}

	public static string GetDefaultBrowser()
	{
		try
		{
			string name = "Software\\Microsoft\\Windows\\Shell\\Associations\\UrlAssociations\\http\\UserChoice";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name);
			if (registryKey == null)
			{
				return GetDefaultBrowserPathOldStyle();
			}
			object value = registryKey.GetValue("Progid");
			if (value != null)
			{
				return value.ToString();
			}
			return string.Empty;
		}
		catch
		{
		}
		return string.Empty;
	}

	public static bool SetDefaultBrowser(string browserName)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\Shell\\Associations\\UrlAssociations\\http\\UserChoice", writable: true);
			if (registryKey == null)
			{
				RegistryKey registryKey2 = Registry.ClassesRoot.OpenSubKey("\\http\\shell\\open\\command");
				if (registryKey2 == null)
				{
					return false;
				}
				registryKey2.SetValue(null, browserName);
			}
			else
			{
				registryKey.SetValue("Progid", browserName);
			}
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static bool SetDefaultBrowser()
	{
		return SetDefaultBrowser("IE.HTTP");
	}

	public static string GetDefaultBrowserPath()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\Shell\\Associations\\UrlAssociations\\http\\UserChoice");
		if (registryKey == null)
		{
			return GetDefaultBrowserPathOldStyle();
		}
		object value = registryKey.GetValue("Progid");
		if (value == null)
		{
			return GetDefaultBrowserPathOldStyle();
		}
		string progId = value.ToString();
		return GetDefaultBrowserPath(progId);
	}

	private static string GetDefaultBrowserPath(string progId)
	{
		string name = progId + "\\shell\\open\\command";
		using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(name))
		{
			if (registryKey == null)
			{
				return null;
			}
			try
			{
				name = registryKey.GetValue(null)!.ToString()!.ToLower().Replace("\"", "");
				if (!name.EndsWith(".exe"))
				{
					return name.Substring(0, name.LastIndexOf(".exe", StringComparison.Ordinal) + ".exe".Length);
				}
			}
			catch
			{
				return null;
			}
		}
		return null;
	}

	private static string GetDefaultBrowserPathOldStyle()
	{
		string text = ".exe";
		string text2 = null;
		using RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("\\http\\shell\\open\\command");
		if (registryKey == null)
		{
			return null;
		}
		try
		{
			text2 = registryKey.GetValue(null)!.ToString()!.ToLower().Replace("\"", "");
			if (!text2.EndsWith(text))
			{
				text2 = text2.Substring(0, text2.LastIndexOf(text, StringComparison.Ordinal) + text.Length);
				return text2;
			}
			return text2;
		}
		catch
		{
			return text2;
		}
	}

	public static bool MoveMouseTo(Point newPosition, int durationSeconds, int durationMilliseconds, bool forced)
	{
		return MoveMouse(newPosition, 0, durationMilliseconds, forced);
	}

	private static bool MoveMouse(Point newPosition, int durationSeconds, int durationMilliseconds, bool forced)
	{
		Cursor.set_Position(newPosition);
		if (durationMilliseconds > 0)
		{
			Thread.Sleep(durationMilliseconds);
		}
		if (!forced)
		{
			if (Cursor.get_Position().X == newPosition.X)
			{
				return Cursor.get_Position().Y == newPosition.Y;
			}
			return false;
		}
		return true;
	}

	private static double Hypotenuse(Point p1, Point p2)
	{
		return Math.Sqrt(Math.Pow(p1.X - p2.X, 2.0) + Math.Pow(p1.Y - p2.Y, 2.0));
	}

	public static Process OpenInExternalProgram(string what, string inWhichProgram)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = inWhichProgram;
			processStartInfo.Arguments = what;
			processStartInfo.UseShellExecute = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Maximized;
			return Process.Start(processStartInfo);
		}
		catch
		{
			return null;
		}
	}

	public static Process OpenInExternalProgram(string what)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo(what);
		processStartInfo.WindowStyle = ProcessWindowStyle.Maximized;
		return Process.Start(processStartInfo);
	}

	public static void KeyDown(int keycode)
	{
		INPUT pInputs = default(INPUT);
		pInputs.type = 1u;
		KEYBDINPUT ki = default(KEYBDINPUT);
		ki.dwFlags = KEYEVENTF.EXTENDEDKEY;
		ki.wVk = (short)keycode;
		pInputs.U.ki = ki;
		Class25.SendInput(1, ref pInputs, Marshal.SizeOf((object)pInputs));
	}

	public static void KeyUp(int keycode)
	{
		INPUT pInputs = default(INPUT);
		pInputs.type = 1u;
		KEYBDINPUT ki = default(KEYBDINPUT);
		ki.dwFlags = KEYEVENTF.KEYUP;
		ki.wVk = (short)keycode;
		pInputs.U.ki = ki;
		Class25.SendInput(1, ref pInputs, Marshal.SizeOf((object)pInputs));
	}

	public static void SimulateClick(int delay)
	{
		Thread.Sleep(delay);
		INPUT pInputs = default(INPUT);
		pInputs.U.mi.dwFlags = 2;
		pInputs.U.mi.dwExtraInfo = 0;
		pInputs.U.mi.mouseData = 0;
		pInputs.U.mi.time = 0;
		Class25.SendInput(1, ref pInputs, 28);
		INPUT pInputs2 = default(INPUT);
		pInputs2.U.mi.dwFlags = 4;
		pInputs2.U.mi.dwExtraInfo = 0;
		pInputs2.U.mi.mouseData = 0;
		pInputs2.U.mi.time = 0;
		Class25.SendInput(1, ref pInputs2, 28);
	}

	public static void SimulateMouseVerticalScroll(int direction)
	{
		INPUT pInputs = default(INPUT);
		pInputs.U.mi.dwFlags = 2048;
		pInputs.U.mi.dwExtraInfo = 0;
		pInputs.U.mi.mouseData = ((direction > 0) ? 120 : (-120));
		pInputs.U.mi.time = 0;
		Class25.SendInput(1, ref pInputs, 28);
	}

	public static void HoldMouseButton(MouseButtons button)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		int dwFlags = 2;
		if ((int)button != 1048576)
		{
			if ((int)button != 2097152)
			{
				if ((int)button == 4194304)
				{
					dwFlags = 32;
				}
			}
			else
			{
				dwFlags = 8;
			}
		}
		else
		{
			dwFlags = 2;
		}
		INPUT pInputs = default(INPUT);
		pInputs.U.mi.dwFlags = dwFlags;
		pInputs.U.mi.dwExtraInfo = 0;
		pInputs.U.mi.mouseData = 0;
		pInputs.U.mi.time = 0;
		Class25.SendInput(1, ref pInputs, 28);
	}

	public static void UnholdMouseButton(MouseButtons button)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		int dwFlags = 4;
		if ((int)button != 1048576)
		{
			if ((int)button != 2097152)
			{
				if ((int)button == 4194304)
				{
					dwFlags = 64;
				}
			}
			else
			{
				dwFlags = 16;
			}
		}
		else
		{
			dwFlags = 4;
		}
		INPUT pInputs = default(INPUT);
		pInputs.U.mi.dwFlags = dwFlags;
		pInputs.U.mi.dwExtraInfo = 0;
		pInputs.U.mi.mouseData = 0;
		pInputs.U.mi.time = 0;
		Class25.SendInput(1, ref pInputs, 28);
	}

	public static void SimulateClick(int delay, MouseButtons button)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		int dwFlags = 2;
		int dwFlags2 = 4;
		if ((int)button != 1048576)
		{
			if ((int)button != 2097152)
			{
				if ((int)button == 4194304)
				{
					dwFlags = 32;
					dwFlags2 = 64;
				}
			}
			else
			{
				dwFlags = 8;
				dwFlags2 = 16;
			}
		}
		else
		{
			dwFlags = 2;
			dwFlags2 = 4;
		}
		Thread.Sleep(delay);
		INPUT pInputs = default(INPUT);
		pInputs.U.mi.dwFlags = dwFlags;
		pInputs.U.mi.dwExtraInfo = 0;
		pInputs.U.mi.mouseData = 0;
		pInputs.U.mi.time = 0;
		Class25.SendInput(1, ref pInputs, 28);
		INPUT pInputs2 = default(INPUT);
		pInputs2.U.mi.dwFlags = dwFlags2;
		pInputs2.U.mi.dwExtraInfo = 0;
		pInputs2.U.mi.mouseData = 0;
		pInputs2.U.mi.time = 0;
		Class25.SendInput(1, ref pInputs2, 28);
	}

	public static void ShowConsole()
	{
		IntPtr consoleWindow = Class7.GetConsoleWindow();
		if (consoleWindow != IntPtr.Zero)
		{
			Class25.ShowWindow(consoleWindow, 5);
		}
		else
		{
			Class7.AllocConsole();
		}
	}

	public static void HideConsole()
	{
		IntPtr consoleWindow = Class7.GetConsoleWindow();
		if (consoleWindow != IntPtr.Zero)
		{
			Class25.ShowWindow(consoleWindow, 0);
		}
	}

	public static void ChangeKeyboardLayout(string code)
	{
		Class25.PostMessage(Class25.GetForegroundWindow(), 80u, IntPtr.Zero, Class25.LoadKeyboardLayout(code, 1u));
	}

	public static bool IsExeRunning(string filename)
	{
		filename.LastIndexOf('\\');
		filename.LastIndexOf(".exe");
		string exeName = GetExeName(filename);
		Process[] processesByName = Process.GetProcessesByName(exeName);
		Process[] array = processesByName;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				Process process = array[num];
				if (process.MainModule!.FileName == filename)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static string GetExeName(string pathToExe)
	{
		int num = pathToExe.LastIndexOf('\\');
		int num2 = pathToExe.LastIndexOf(".exe");
		if (num != -1 && num2 != -1)
		{
			return pathToExe.Substring(num + 1, num2 - num - 1);
		}
		return null;
	}
}
