using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class7
{
	public struct Struct1
	{
		public IntPtr intptr_0;

		public int int_0;
	}

	public struct Struct2
	{
		public Struct1 struct1_0;
	}

	public enum Enum5
	{
		const_0 = 2035711,
		const_1 = 1,
		const_2 = 2,
		const_3 = 8,
		const_4 = 16,
		const_5 = 32,
		const_6 = 64,
		const_7 = 128,
		const_8 = 256,
		const_9 = 512,
		const_10 = 1024,
		const_11 = 4096,
		const_12 = 1048576
	}

	public enum Enum6
	{
		const_0 = 1,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12,
		const_13,
		const_14,
		const_15,
		const_16
	}

	public enum Enum7
	{
		const_0 = 1,
		const_1 = 2,
		const_2 = 4,
		const_3 = 8,
		const_4 = 16,
		const_5 = int.MinValue,
		const_6 = 31,
		const_7 = 1073741824
	}

	public struct Struct3
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public byte byte_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_1;
	}

	[DllImport("kernel32.dll")]
	public static extern int OpenProcess(Enum5 enum5_0, bool bool_0, int int_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool OpenProcessToken(IntPtr intptr_0, int int_0, ref IntPtr intptr_1);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool GetTokenInformation(IntPtr intptr_0, Enum6 enum6_0, IntPtr intptr_1, uint uint_0, ref uint uint_1);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool ConvertSidToStringSid(IntPtr intptr_0, ref string string_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool GetExitCodeProcess(IntPtr intptr_0, ref uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateToolhelp32Snapshot(Enum7 enum7_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern long Module32First(long long_0, Struct3 struct3_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern long Module32Next(long long_0, Struct3 struct3_0);

	public static string smethod_0(long long_0)
	{
		try
		{
			if (long_0 == Class84.smethod_0(0) || 1 == 0)
			{
				return Class86.smethod_0("\ue093\ue089\ue0fd\ue09c\ue0a8\ue0a9\ue0b5\ue0b2\ue0af\ue0b4\ue0a9\ue0a4\ue081\ue08e\ue0a4\ue0ae\ue0a9\ue0b8\ue0b0", 57556);
			}
			int num3 = default(int);
			bool flag = default(bool);
			int num4 = default(int);
			Struct2 @struct = default(Struct2);
			IntPtr intPtr = default(IntPtr);
			int num6 = default(int);
			bool flag2 = default(bool);
			uint uint_ = default(uint);
			string string_ = default(string);
			string text = default(string);
			while (true)
			{
				int num = Class46.Class47.smethod_0(65);
				int num2 = 1;
				while (true)
				{
					switch (num2 ^ Class84.smethod_0(400))
					{
					case 95:
						num ^= Class84.smethod_0(24);
						goto default;
					default:
						num2 = Class84.smethod_0(6);
						continue;
					case 94:
						num2 = 0;
						continue;
					case 92:
						switch (num)
						{
						default:
							num2 = Class84.smethod_0(7);
							continue;
						case -96:
							num3 = Delegate179.smethod_0((Enum5)Class84.smethod_0(117), (byte)Class84.smethod_0(0) != 0, checked((int)long_0));
							num = -8;
							break;
						case -95:
							flag = (uint)num3 > (uint)Class84.smethod_0(0);
							num = -6;
							break;
						case -94:
							num = Class89.smethod_1(60);
							break;
						case -93:
							if (flag)
							{
								num = -3;
								break;
							}
							if (true)
							{
								return Class86.smethod_0("\uf5d2\uf58f\uf58d\uf58d\uf58b\uf59d\uf59d\uf5ce\uf58a\uf58b\uf580\uf587\uf58b\uf58a\uf5d0", 62818);
							}
							goto case -92;
						case -92:
						{
							IntPtr intptr_ = (IntPtr)num3;
							int int_ = Class84.smethod_0(75);
							IntPtr intptr_2 = (IntPtr)num4;
							Delegate180.smethod_0(intptr_, int_, ref intptr_2);
							checked
							{
								while (true)
								{
									int num5 = Class84.smethod_0(72);
									while (true)
									{
										switch (num5 ^ Class84.smethod_0(24))
										{
										case 93:
											@struct = (Struct2)Marshal.PtrToStructure(intPtr, @struct.GetType());
											num5 = 10;
											continue;
										case 92:
											num6 = Class84.smethod_0(0);
											num5 = 14;
											continue;
										case 91:
											if (flag2)
											{
												num5 = 7;
												continue;
											}
											if (1 == 0)
											{
												goto case 94;
											}
											goto IL_02c9;
										case 90:
										{
											IntPtr intptr_5 = (IntPtr)num4;
											int enum6_2 = Class84.smethod_0(1);
											IntPtr zero = IntPtr.Zero;
											int uint_3 = Class84.smethod_0(0);
											uint_ = (uint)num6;
											unchecked
											{
												Delegate181.smethod_0(intptr_5, (Enum6)enum6_2, zero, (uint)uint_3, ref uint_);
												num5 = 11;
												continue;
											}
										}
										case 89:
											num5 = 0;
											continue;
										case 88:
										{
											IntPtr intptr_3 = (IntPtr)num4;
											int enum6_ = Class84.smethod_0(1);
											IntPtr intptr_4 = intPtr;
											uint uint_2 = (uint)num6;
											uint_ = (uint)num6;
											Delegate181.smethod_0(intptr_3, unchecked((Enum6)enum6_), intptr_4, uint_2, ref uint_);
											num5 = 12;
											continue;
										}
										case 87:
											string_ = "";
											num5 = 13;
											continue;
										case 86:
											num4 = (int)intptr_2;
											num5 = 5;
											continue;
										case 85:
											num6 = (int)uint_;
											num5 = 4;
											continue;
										case 84:
											text = Class86.smethod_0("\uf5d2\uf58f\uf58d\uf58d\uf58b\uf59d\uf59d\uf5ce\uf58a\uf58b\uf580\uf587\uf58b\uf58a\uf5d0", 62818);
											num5 = 3;
											continue;
										case 83:
											Delegate182.smethod_0(@struct.struct1_0.intptr_0, ref string_);
											num5 = 9;
											continue;
										case 82:
											num6 = (int)uint_;
											num5 = 8;
											continue;
										case 81:
											intPtr = Marshal.AllocHGlobal(num6);
											num5 = Class84.smethod_0(1);
											continue;
										case 80:
											flag2 = string_.StartsWith(Class86.smethod_0("\uf5b8", 62827));
											num5 = 2;
											continue;
										case 94:
											{
												text = new SecurityIdentifier(string_).Translate(typeof(NTAccount)).ToString();
												goto IL_02c9;
											}
											IL_02c9:
											return text.ToLower();
										}
										break;
									}
								}
							}
						}
						}
						goto case 95;
					case 93:
						break;
					}
					break;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = Class86.smethod_0("\uf5d2\uf58f\uf58d\uf58d\uf58b\uf59d\uf59d\uf5ce\uf58a\uf58b\uf580\uf587\uf58b\uf58a\uf5d0", 62818);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static byte[] smethod_1(Bitmap bitmap_0)
	{
		return (byte[])Class65.smethod_0(4177448, null, bitmap_0);
	}

	public static bool smethod_2(long long_0)
	{
		bool flag = default(bool);
		uint uint_ = default(uint);
		bool result = default(bool);
		while (true)
		{
			int num = Class84.smethod_0(5);
			while (true)
			{
				switch (num ^ Class84.smethod_0(29))
				{
				case 88:
					flag = ((uint_ == Class84.smethod_0(1)) ? 1 : 0) == Class84.smethod_0(0);
					num = 4;
					continue;
				case 87:
					if (flag)
					{
						num = 10;
						continue;
					}
					if (1 == 0)
					{
						goto case 89;
					}
					while (true)
					{
						int num2 = Class84.smethod_0(6);
						int num3 = 12;
						while (true)
						{
							switch (num3 ^ Class84.smethod_0(393))
							{
							case 93:
								num2 ^= Class84.smethod_0(389);
								goto default;
							default:
								num3 = Class84.smethod_0(42);
								continue;
							case 92:
								switch (num2)
								{
								case 81:
									goto IL_00cf;
								case 82:
									goto IL_00d4;
								case 80:
								case 83:
									goto end_IL_0114;
								}
								num3 = 10;
								continue;
							case 90:
								num3 = Class84.smethod_0(20);
								continue;
							case 91:
								break;
								IL_00d4:
								result = (byte)Class84.smethod_0(0) != 0;
								num2 = 0;
								goto case 93;
								IL_00cf:
								num2 = 1;
								goto case 93;
							}
							break;
						}
						continue;
						end_IL_0114:
						break;
					}
					goto IL_0122;
				case 86:
					num = 5;
					continue;
				case 85:
					Delegate184.smethod_0((IntPtr)Delegate179.smethod_0((Enum5)Class84.smethod_0(115), (byte)Class84.smethod_0(0) != 0, checked((int)long_0)), ref uint_);
					num = Class84.smethod_0(20);
					continue;
				case 89:
					{
						result = (byte)Class84.smethod_0(1) != 0;
						goto IL_0122;
					}
					IL_0122:
					return result;
				}
				break;
			}
		}
	}

	public static string[] smethod_3(byte[] byte_0)
	{
		return (string[])Class65.smethod_0(4177781, null, byte_0);
	}

	private static int smethod_4(int int_0)
	{
		int result = default(int);
		while (true)
		{
			int num = Class84.smethod_0(5);
			while (true)
			{
				switch (num ^ Class84.smethod_0(390))
				{
				case 85:
					num = 7;
					continue;
				case 84:
					result = Class84.smethod_0(1);
					num = 4;
					continue;
				case 86:
				case 87:
					return result;
				}
				break;
			}
		}
	}
}
