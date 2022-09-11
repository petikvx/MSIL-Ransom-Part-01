using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class6
{
	public delegate bool Delegate0(IntPtr intptr_0, IntPtr intptr_1);

	public delegate bool Delegate1(IntPtr intptr_0, IntPtr intptr_1);

	public delegate bool Delegate2(IntPtr intptr_0, IntPtr intptr_1);

	public enum Enum0
	{
		const_0 = -20,
		const_1 = -6,
		const_2 = -8,
		const_3 = -12,
		const_4 = -16,
		const_5 = -21,
		const_6 = -4,
		const_7 = 8,
		const_8 = 0,
		const_9 = 4
	}

	public enum Enum1
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 3,
		const_4 = 3,
		const_5 = 4,
		const_6 = 5,
		const_7 = 6,
		const_8 = 7,
		const_9 = 8,
		const_10 = 9,
		const_11 = 10,
		const_12 = 11
	}

	public enum Enum2
	{
		const_0 = 12,
		const_1 = 13,
		const_2 = 14,
		const_3 = 8,
		const_4 = 10,
		const_5 = 273,
		const_6 = 207,
		const_7 = 204,
		const_8 = 397,
		const_9 = 1045,
		const_10 = 512
	}

	public enum Enum3
	{
		const_0 = 0x8000000
	}

	public struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int Int32_0
		{
			get
			{
				int result = default(int);
				while (true)
				{
					int num = Class46.Class47.smethod_0(82);
					while (true)
					{
						switch (num ^ Class84.smethod_0(398))
						{
						case -78:
							result = checked(int_2 - int_0);
							num = -21;
							continue;
						case -80:
							num = -22;
							continue;
						case -79:
						case -77:
							return result;
						}
						break;
					}
				}
			}
		}

		public int Int32_1
		{
			get
			{
				int result = default(int);
				while (true)
				{
					int num = Class89.smethod_1(63);
					while (true)
					{
						switch (num ^ Class84.smethod_0(15))
						{
						case -82:
							result = checked(int_3 - int_1);
							num = Class89.smethod_1(56);
							continue;
						case -84:
							num = -15;
							continue;
						case -83:
						case -81:
							return result;
						}
						break;
					}
				}
			}
		}
	}

	private enum Enum4 : uint
	{
		const_0 = 1u,
		const_1 = 2u,
		const_2 = 4u,
		const_3 = 8u,
		const_4 = 0x10u,
		const_5 = 0x20u,
		const_6 = 0x40u,
		const_7 = 0x80u,
		const_8 = 0x100u,
		const_9 = 0x200u,
		const_10 = 0x400u,
		const_11 = 0x800u
	}

	public static long long_0 = Class84.smethod_0(0);

	public static int int_0;

	public static int int_1;

	public static long long_1;

	static Class6()
	{
		while (true)
		{
			int num = Class84.smethod_0(1);
			while (true)
			{
				switch (num ^ Class84.smethod_0(389))
				{
				case 84:
					long_1 = Class84.smethod_0(108);
					num = Class84.smethod_0(9);
					continue;
				case 83:
					int_1 = Class84.smethod_0(0);
					num = 4;
					continue;
				case 82:
					num = 2;
					continue;
				case 81:
					int_0 = Class84.smethod_0(0);
					num = 3;
					continue;
				case 85:
					return;
				}
				break;
			}
		}
	}

	[DllImport("user32.dll")]
	public static extern bool SetWindowText(IntPtr intptr_0, string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern IntPtr GetParent(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern IntPtr WindowFromPoint(Point point_0);

	[DllImport("user32.dll")]
	public static extern IntPtr ChildWindowFromPointEx(IntPtr intptr_0, Point point_0, uint uint_0);

	[DllImport("user32.dll")]
	public static extern int GetWindowText(int int_2, StringBuilder stringBuilder_0, int int_3);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool ShowWindow(IntPtr intptr_0, Enum1 enum1_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_2);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint GetModuleFileName([In] IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, [In][MarshalAs(UnmanagedType.U4)] int int_2);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SendMessage(IntPtr intptr_0, int int_2, IntPtr intptr_1, IntPtr intptr_2);

	public static IntPtr smethod_0(IntPtr intptr_0, int int_2, int int_3, string string_0)
	{
		IntPtr intptr_ = default(IntPtr);
		IntPtr result = default(IntPtr);
		while (true)
		{
			int num = Class84.smethod_0(6);
			while (true)
			{
				switch (num ^ Class84.smethod_0(61))
				{
				case 79:
					intptr_ = Marshal.StringToHGlobalUni(string_0);
					num = 3;
					continue;
				case 78:
					result = Delegate161.smethod_0(intptr_0, int_2, (IntPtr)int_3, intptr_);
					num = 29;
					continue;
				case 77:
					num = 0;
					continue;
				case 80:
					return result;
				}
				break;
			}
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool PostMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll")]
	public static extern bool EnableWindow(IntPtr intptr_0, bool bool_0);

	[DllImport("user32.dll")]
	public static extern long GetWindowLong(IntPtr intptr_0, [MarshalAs(UnmanagedType.I4)] Enum0 enum0_0);

	[DllImport("user32.dll")]
	public static extern long SetWindowLong(IntPtr intptr_0, Enum0 enum0_0, long long_2);

	[DllImport("user32.dll")]
	public static extern bool UpdateWindow(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr intptr_0, ref Struct0 struct0_0);

	[DllImport("user32.dll")]
	public static extern bool InvalidateRect(IntPtr intptr_0, ref IntPtr intptr_1, int int_2);

	[DllImport("user32.dll")]
	private static extern bool RedrawWindow(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, Enum4 enum4_0);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowDC(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern bool ReleaseDC(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(long long_2, bool bool_0, int int_2);

	[DllImport("user32.dll")]
	public static extern bool EnumThreadWindows(uint uint_0, Delegate0 delegate0_0, IntPtr intptr_0);

	public static long smethod_1(long long_2, long long_3)
	{
		Delegate55.smethod_0(Delegate12.smethod_0(Delegate11.smethod_0())).get_Items().Add((object)long_2.ToString());
		Delegate162.smethod_0((IntPtr)long_2, (_Closure_0024__._0024IR25_002D1 != null || 1 == 0) ? _Closure_0024__._0024IR25_002D1 : (_Closure_0024__._0024IR25_002D1 = (IntPtr a0, IntPtr a1) => (ulong)Delegate178.smethod_0((long)a0, (long)a1) > (ulong)Class84.smethod_0(0)), (int)IntPtr.Zero);
		return Class84.smethod_0(0);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern bool EnumChildWindows(IntPtr intptr_0, Delegate1 delegate1_0, int int_2);

	public static long smethod_2(long long_2, long long_3)
	{
		long result = default(long);
		while (true)
		{
			int num = Class49.smethod_0(81);
			while (true)
			{
				switch (num ^ Class84.smethod_0(392))
				{
				case -81:
				{
					ObjectCollection items = Delegate55.smethod_0(Delegate12.smethod_0(Delegate11.smethod_0())).get_Items();
					string[] array = new string[Class84.smethod_0(5)];
					array[Class84.smethod_0(0)] = long_2.ToString();
					array[Class84.smethod_0(1)] = Class86.smethod_0("\uf3df\uf3d2\uf3df", 62271);
					array[Class84.smethod_0(6)] = Delegate36.smethod_0((IntPtr)long_2);
					array[Class84.smethod_0(7)] = Class86.smethod_0("\uf5dd\uf5a6\uf5dd", 62964);
					array[Class84.smethod_0(8)] = Delegate34.smethod_0((IntPtr)long_2);
					array[Class84.smethod_0(9)] = Class86.smethod_0("\ue58a", 58823);
					items.Add((object)string.Concat(array));
					num = -21;
					continue;
				}
				case -82:
					num = -24;
					continue;
				case -83:
					result = Class84.smethod_0(1);
					num = -10;
					continue;
				case -80:
				case -79:
					return result;
				}
				break;
			}
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern long EnumWindows(Delegate2 delegate2_0, IntPtr intptr_0);

	public static long smethod_3(IntPtr intptr_0, IntPtr intptr_1)
	{
		bool visible = default(bool);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			int num = Class84.smethod_0(1);
			while (true)
			{
				switch (num ^ Class84.smethod_0(394))
				{
				case 82:
					num = 28;
					continue;
				case 81:
					if (visible)
					{
						num = 29;
						continue;
					}
					if (1 == 0)
					{
						goto case 83;
					}
					if (((Control)Delegate53.smethod_0(Delegate12.smethod_0(Delegate11.smethod_0()))).get_Visible() || 1 == 0)
					{
						string? text = Delegate53.smethod_0(Delegate12.smethod_0(Delegate11.smethod_0())).get_SelectedItem().ToString();
						char[] array = new char[Class84.smethod_0(1)];
						array[Class84.smethod_0(0)] = (char)Class84.smethod_0(14);
						string obj = text!.Split(array)[Class84.smethod_0(1)];
						char[] array2 = new char[Class84.smethod_0(1)];
						array2[Class84.smethod_0(0)] = (char)Class84.smethod_0(15);
						num3 = Conversions.ToInteger(obj.Split(array2)[Class84.smethod_0(0)]);
					}
					goto IL_020e;
				case 80:
					visible = ((Control)Delegate52.smethod_0(Delegate12.smethod_0(Delegate11.smethod_0()))).get_Visible();
					num = 31;
					continue;
				case 79:
					Delegate38.smethod_0(intptr_0, ref num2);
					num = Class84.smethod_0(69);
					continue;
				case 83:
					{
						while (true)
						{
							int num4 = Class84.smethod_0(66);
							int num5 = -32;
							while (true)
							{
								string? text2;
								char[] array4;
								string obj2;
								char[] array5;
								switch (num5 ^ Class84.smethod_0(85))
								{
								case -74:
									num4 ^= Class84.smethod_0(392);
									goto default;
								default:
									num5 = Class49.smethod_0(78);
									continue;
								case -75:
									switch (num4)
									{
									case 83:
										goto IL_00c4;
									case 84:
										goto IL_00cf;
									case 85:
										goto IL_00d5;
									case 86:
										goto end_IL_0178;
									}
									num5 = -30;
									continue;
								case -77:
									num5 = -27;
									continue;
								case -76:
									break;
									IL_00d5:
									text2 = Delegate52.smethod_0(Delegate12.smethod_0(Delegate11.smethod_0())).get_SelectedItem().ToString();
									array4 = new char[Class84.smethod_0(1)];
									array4[Class84.smethod_0(0)] = (char)Class84.smethod_0(14);
									obj2 = text2!.Split(array4)[Class84.smethod_0(1)];
									array5 = new char[Class84.smethod_0(1)];
									array5[Class84.smethod_0(0)] = (char)Class84.smethod_0(15);
									num3 = Conversions.ToInteger(obj2.Split(array5)[Class84.smethod_0(0)]);
									num4 = 21;
									goto case -74;
									IL_00cf:
									num4 = 18;
									goto case -74;
									IL_00c4:
									num4 = Class84.smethod_0(17);
									goto case -74;
								}
								break;
							}
							continue;
							end_IL_0178:
							break;
						}
						goto IL_020e;
					}
					IL_020e:
					if (num2 == num3 || 1 == 0)
					{
						ObjectCollection items = Delegate55.smethod_0(Delegate12.smethod_0(Delegate11.smethod_0())).get_Items();
						string[] array3 = new string[Class84.smethod_0(5)];
						array3[Class84.smethod_0(0)] = intptr_0.ToString();
						array3[Class84.smethod_0(1)] = Class86.smethod_0("\uf3df\uf3d2\uf3df", 62271);
						array3[Class84.smethod_0(6)] = Delegate36.smethod_0(intptr_0);
						array3[Class84.smethod_0(7)] = Class86.smethod_0("\uf5dd\uf5a6\uf5dd", 62964);
						array3[Class84.smethod_0(8)] = Delegate34.smethod_0(intptr_0);
						array3[Class84.smethod_0(9)] = Class86.smethod_0("\ue58a", 58823);
						items.Add((object)string.Concat(array3));
						Delegate162.smethod_0(intptr_0, (_Closure_0024__._0024IR31_002D2 != null || 1 == 0) ? _Closure_0024__._0024IR31_002D2 : (_Closure_0024__._0024IR31_002D2 = (IntPtr a0, IntPtr a1) => (ulong)Delegate178.smethod_0((long)a0, (long)a1) > (ulong)Class84.smethod_0(0)), (int)IntPtr.Zero);
					}
					return Class84.smethod_0(1);
				}
				break;
			}
		}
	}

	public static byte[] smethod_4(Bitmap bitmap_0)
	{
		return (byte[])Class65.smethod_0(4174583, null, bitmap_0);
	}

	public static object smethod_5(int int_2, IntPtr intptr_0)
	{
		if (int_2 == Class84.smethod_0(0) || 1 == 0)
		{
			Delegate164.smethod_0(intptr_0, (Enum1)Class84.smethod_0(9));
		}
		else if (int_2 == Class84.smethod_0(1) || 1 == 0)
		{
			Delegate164.smethod_0(intptr_0, (Enum1)Class84.smethod_0(0));
		}
		else if (int_2 == Class84.smethod_0(6) || 1 == 0)
		{
			Delegate164.smethod_0(intptr_0, (Enum1)Class84.smethod_0(7));
		}
		else if (int_2 == Class84.smethod_0(7) || 1 == 0)
		{
			Delegate164.smethod_0(intptr_0, (Enum1)Class84.smethod_0(5));
		}
		else if (int_2 == Class84.smethod_0(8) || 1 == 0)
		{
			Delegate164.smethod_0(intptr_0, (Enum1)Class84.smethod_0(79));
		}
		else if (int_2 == Class84.smethod_0(9) || 1 == 0)
		{
			Delegate165.smethod_0(intptr_0, (byte)Class84.smethod_0(1) != 0);
		}
		else if (int_2 == Class84.smethod_0(5) || 1 == 0)
		{
			Delegate165.smethod_0(intptr_0, (byte)Class84.smethod_0(0) != 0);
		}
		else if (int_2 == Class84.smethod_0(77) || 1 == 0)
		{
			Delegate161.smethod_0(intptr_0, Class84.smethod_0(109), (IntPtr)Class84.smethod_0(0), (IntPtr)Class84.smethod_0(0));
		}
		else if (int_2 == Class84.smethod_0(75) || 1 == 0)
		{
			Delegate161.smethod_0(intptr_0, Class84.smethod_0(109), (IntPtr)Class84.smethod_0(1), (IntPtr)Class84.smethod_0(0));
		}
		else if (int_2 == Class84.smethod_0(79) || 1 == 0)
		{
			Delegate166.smethod_0((long)intptr_0);
		}
		else if (int_2 == Class84.smethod_0(80) || 1 == 0)
		{
			Delegate161.smethod_0(intptr_0, Class84.smethod_0(110), (IntPtr)Class84.smethod_0(0), (IntPtr)Class84.smethod_0(0));
			while (true)
			{
				int num = Class49.smethod_0(84);
				int num2 = -11;
				while (true)
				{
					switch (num2 ^ Class84.smethod_0(14))
					{
					case -82:
						num ^= Class84.smethod_0(387);
						goto default;
					default:
						num2 = Class89.smethod_1(56);
						continue;
					case -83:
						num2 = -10;
						continue;
					case -85:
						switch (num)
						{
						case -86:
							goto IL_021c;
						case -85:
							goto IL_0227;
						case -84:
							goto IL_023b;
						case -83:
							goto IL_0248;
						case -82:
							goto IL_025e;
						case -81:
							goto end_IL_0292;
						}
						num2 = Class46.Class47.smethod_0(72);
						continue;
					case -84:
						break;
						IL_025e:
						num = -26;
						goto case -82;
						IL_0248:
						Delegate164.smethod_0(intptr_0, (Enum1)Class84.smethod_0(0));
						num = -29;
						goto case -82;
						IL_023b:
						Delegate167.smethod_0(intptr_0);
						num = -30;
						goto case -82;
						IL_0227:
						Delegate164.smethod_0(intptr_0, (Enum1)Class84.smethod_0(9));
						num = -28;
						goto case -82;
						IL_021c:
						num = Class49.smethod_0(69);
						goto case -82;
					}
					break;
				}
				continue;
				end_IL_0292:
				break;
			}
		}
		else if (int_2 == Class84.smethod_0(20) || 1 == 0)
		{
			Delegate168.smethod_0(intptr_0, Class84.smethod_0(111), Class84.smethod_0(0), Delegate69.smethod_0(Delegate12.smethod_0(Delegate11.smethod_0())).get_Text());
			while (true)
			{
				int num3 = Class84.smethod_0(33);
				while (true)
				{
					switch (num3 ^ Class84.smethod_0(389))
					{
					case 75:
						num3 = 27;
						continue;
					case 74:
						Delegate167.smethod_0(intptr_0);
						num3 = Class84.smethod_0(55);
						continue;
					case 73:
						num3 = 28;
						continue;
					case 76:
						goto end_IL_0322;
					}
					break;
				}
				continue;
				end_IL_0322:
				break;
			}
		}
		else if (int_2 == Class84.smethod_0(31) || 1 == 0)
		{
			Delegate168.smethod_0(intptr_0, Class84.smethod_0(112), Class84.smethod_0(113), Conversions.ToString(Class84.smethod_0(0)));
			Delegate167.smethod_0(intptr_0);
		}
		return Class84.smethod_0(0);
	}

	public static void smethod_6(IntPtr intptr_0)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		checked
		{
			Struct0 struct0_ = default(Struct0);
			bool flag = default(bool);
			IntPtr intPtr = default(IntPtr);
			while (true)
			{
				int num = Class49.smethod_0(69);
				while (true)
				{
					switch (num ^ Class84.smethod_0(85))
					{
					case -75:
						Delegate169.smethod_0(intptr_0, ref struct0_);
						num = -26;
						continue;
					case -76:
						if (flag)
						{
							num = -32;
							continue;
						}
						if (1 == 0)
						{
							goto case -74;
						}
						goto IL_0112;
					case -77:
						flag = intPtr != IntPtr.Zero;
						num = Class49.smethod_0(88);
						continue;
					case -78:
						num = -28;
						continue;
					case -79:
						struct0_ = default(Struct0);
						num = -29;
						continue;
					case -80:
						intPtr = Delegate170.smethod_0(intptr_0);
						num = -27;
						continue;
					case -74:
						{
							Pen val = new Pen(Color.Black, Class84.smethod_2(3));
							try
							{
								Graphics val2 = Graphics.FromHdc(intPtr);
								try
								{
									val2.DrawRectangle(val, Class84.smethod_0(0), Class84.smethod_0(0), struct0_.int_2 - struct0_.int_0 - Class84.smethod_0(7), struct0_.int_3 - struct0_.int_1 - Class84.smethod_0(7));
								}
								finally
								{
									if (val2 != null || 1 == 0)
									{
										((IDisposable)val2).Dispose();
									}
								}
							}
							finally
							{
								if (val != null || 1 == 0)
								{
									((IDisposable)val).Dispose();
								}
							}
							goto IL_0112;
						}
						IL_0112:
						Delegate171.smethod_0(intptr_0, intPtr);
						return;
					}
					break;
				}
			}
		}
	}

	public static void smethod_7(IntPtr intptr_0)
	{
		while (true)
		{
			int num = Class84.smethod_0(5);
			while (true)
			{
				switch (num ^ Class84.smethod_0(389))
				{
				case 87:
					Delegate167.smethod_0(intptr_0);
					num = 5;
					continue;
				case 86:
				{
					IntPtr intptr_ = IntPtr.Zero;
					Delegate172.smethod_0(intptr_0, ref intptr_, Class84.smethod_0(1));
					num = 7;
					continue;
				}
				case 85:
					Delegate173.smethod_0(intptr_0, IntPtr.Zero, IntPtr.Zero, (Enum4)Class84.smethod_0(114));
					num = 8;
					continue;
				case 84:
					num = 4;
					continue;
				case 88:
					return;
				}
				break;
			}
		}
	}

	public static string smethod_8(IntPtr intptr_0)
	{
		string text = default(string);
		IntPtr intPtr = default(IntPtr);
		string result = default(string);
		while (true)
		{
			int num = Class89.smethod_2(91);
			while (true)
			{
				switch (num ^ Class84.smethod_0(85))
				{
				case -75:
					text = Marshal.PtrToStringUni(intPtr);
					num = Class49.smethod_0(69);
					continue;
				case -76:
					_ = (int)Delegate161.smethod_0(intptr_0, Class84.smethod_0(42), (IntPtr)Class84.smethod_0(115), intPtr);
					num = -29;
					continue;
				case -78:
					intPtr = Marshal.AllocHGlobal(Class84.smethod_0(112));
					num = -7;
					continue;
				case -79:
					result = text;
					num = -27;
					continue;
				case -80:
					num = -26;
					continue;
				case -81:
					text = "";
					num = -30;
					continue;
				case -77:
				case -74:
					return result;
				}
				break;
			}
		}
	}

	public static long smethod_9(IntPtr intptr_0, string string_0)
	{
		IntPtr intptr_ = default(IntPtr);
		long result = default(long);
		while (true)
		{
			int num = Class46.Class47.smethod_0(75);
			while (true)
			{
				switch (num ^ Class84.smethod_0(85))
				{
				case -85:
					intptr_ = Marshal.StringToHGlobalUni(string_0);
					num = -13;
					continue;
				case -86:
					Delegate164.smethod_0(intptr_0, (Enum1)Class84.smethod_0(9));
					num = -14;
					continue;
				case -87:
					result = Class84.smethod_0(0);
					num = -2;
					continue;
				case -89:
					num = -15;
					continue;
				case -90:
					Delegate164.smethod_0(intptr_0, (Enum1)Class84.smethod_0(0));
					num = Class89.smethod_1(54);
					continue;
				case -91:
					Delegate161.smethod_0(intptr_0, Class84.smethod_0(31), (IntPtr)Class84.smethod_0(0), intptr_);
					num = -16;
					continue;
				case -92:
					Delegate167.smethod_0(intptr_0);
					num = -1;
					continue;
				case -88:
				case -84:
					return result;
				}
				break;
			}
		}
	}

	public static string smethod_10(IntPtr intptr_0)
	{
		string result = default(string);
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num = Class89.smethod_1(54);
			while (true)
			{
				switch (num ^ Class84.smethod_0(29))
				{
				case -78:
					num = -31;
					continue;
				case -79:
					result = stringBuilder.ToString();
					num = -3;
					continue;
				case -80:
					Delegate174.smethod_0(intptr_0, stringBuilder, stringBuilder.Capacity);
					num = -30;
					continue;
				case -81:
					stringBuilder = new StringBuilder(Class84.smethod_0(2));
					num = -29;
					continue;
				case -82:
				case -77:
					return result;
				}
				break;
			}
		}
	}

	public static byte[] smethod_11(byte[] byte_0, int int_2 = 16)
	{
		return (byte[])Class65.smethod_0(4174240, null, byte_0, int_2);
	}

	public static long smethod_12(long long_2)
	{
		int num = Class84.smethod_0(0);
		long result = default(long);
		while (true)
		{
			Delegate31.smethod_0((IntPtr)long_2);
			while (true)
			{
				IL_012b:
				int num2 = Class84.smethod_0(7);
				int num3 = -12;
				while (true)
				{
					switch (num3 ^ Class84.smethod_0(133))
					{
					case -88:
						num2 ^= Class84.smethod_0(24);
						goto default;
					default:
						num3 = Class89.smethod_1(60);
						continue;
					case -89:
						switch (num2)
						{
						default:
							num3 = -6;
							continue;
						case 83:
							goto IL_0068;
						case 84:
							num2 = 13;
							break;
						case 85:
							result = Class84.smethod_0(0);
							num2 = 15;
							break;
						case 87:
							Thread.Sleep(Class84.smethod_0(81));
							num2 = 2;
							break;
						case 88:
							num2 = 4;
							break;
						case 89:
							num2 = 7;
							break;
						case 90:
							num2 = 14;
							break;
						case 91:
							num2 = Class84.smethod_0(9);
							break;
						case 92:
							Delegate42.smethod_0((IntPtr)long_2);
							num2 = 1;
							break;
						case 93:
							Thread.Sleep(Class84.smethod_0(81));
							num2 = 0;
							break;
						case 94:
							num = checked(num + Class84.smethod_0(1));
							num2 = 10;
							break;
						case 86:
						case 95:
							return result;
						}
						goto case -88;
					case -91:
						num3 = Class46.Class47.smethod_0(65);
						continue;
					case -90:
						break;
						IL_0068:
						if (num <= Class84.smethod_0(9))
						{
							goto end_IL_0100;
						}
						num2 = 12;
						goto case -88;
					}
					goto IL_012b;
					continue;
					end_IL_0100:
					break;
				}
				break;
			}
		}
	}

	public static long smethod_13(long long_2)
	{
		bool flag = default(bool);
		IntPtr intptr_ = default(IntPtr);
		while (true)
		{
			int num = Class89.smethod_2(90);
			while (true)
			{
				switch (num ^ Class84.smethod_0(15))
				{
				case -75:
					flag = intptr_.ToInt64() > Class84.smethod_0(0);
					num = -18;
					continue;
				case -76:
					Delegate161.smethod_0((IntPtr)long_2, Class84.smethod_0(80), (IntPtr)Class84.smethod_0(1), (IntPtr)Class84.smethod_0(0));
					num = -19;
					continue;
				case -77:
					if (flag)
					{
						num = -21;
						continue;
					}
					if (1 == 0)
					{
						goto case -74;
					}
					goto IL_0192;
				case -78:
					Delegate165.smethod_0((IntPtr)long_2, (byte)Class84.smethod_0(1) != 0);
					num = -23;
					continue;
				case -79:
					num = -20;
					continue;
				case -80:
					intptr_ = Delegate175.smethod_0((IntPtr)long_2);
					num = -24;
					continue;
				case -74:
					{
						while (true)
						{
							int num2 = Class84.smethod_0(0);
							int num3 = -2;
							while (true)
							{
								switch (num3 ^ Class84.smethod_0(29))
								{
								case -83:
									num2 ^= Class84.smethod_0(398);
									goto default;
								default:
									num3 = Class89.smethod_1(55);
									continue;
								case -84:
									num3 = -1;
									continue;
								case -85:
									switch (num2)
									{
									case 88:
										goto IL_0103;
									case 89:
										goto IL_0108;
									case 90:
										goto IL_0131;
									case 91:
										goto end_IL_0184;
									}
									num3 = -7;
									continue;
								case -86:
									break;
									IL_0131:
									Delegate176.smethod_0(intptr_, (uint)Class84.smethod_0(116), (IntPtr)Class84.smethod_0(80), (IntPtr)long_2);
									num2 = 3;
									goto case -83;
									IL_0108:
									Delegate176.smethod_0((IntPtr)long_2, (uint)Class84.smethod_0(116), (IntPtr)Class84.smethod_0(80), IntPtr.Zero);
									num2 = 1;
									goto case -83;
									IL_0103:
									num2 = 2;
									goto case -83;
								}
								break;
							}
							continue;
							end_IL_0184:
							break;
						}
						goto IL_0192;
					}
					IL_0192:
					return Class84.smethod_0(0);
				}
				break;
			}
		}
	}
}
