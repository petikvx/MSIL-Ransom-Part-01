using System;
using System.Runtime.CompilerServices;

internal class Class21
{
	private uint uint_0;

	private static uint[] uint_1;

	internal uint UInt32_0
	{
		get
		{
			return uint_0;
		}
		set
		{
			uint_0 = value;
		}
	}

	public static uint smethod_0(byte[] byte_0)
	{
		uint num = uint.MaxValue;
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = Class89.smethod_2(86);
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(413))
				{
				case -104:
					num3 = byte_0.Length;
					num2 = -28;
					continue;
				case -105:
					num5 = Class84.smethod_0(0);
					num2 = Class49.smethod_0(74);
					continue;
				case -106:
					num2 = -27;
					continue;
				case -103:
					while (num3 > Class84.smethod_0(0))
					{
						num3 -= Class84.smethod_0(1);
						while (true)
						{
							int num4 = Class84.smethod_0(56);
							while (true)
							{
								switch (num4 ^ Class84.smethod_0(93))
								{
								case 118:
									num = Delegate384.smethod_0(byte_0[num3], num);
									num4 = Class84.smethod_0(37);
									continue;
								case 117:
									num5 += Class84.smethod_0(1);
									num4 = 19;
									continue;
								case 116:
									num4 = 16;
									continue;
								case 119:
									goto end_IL_00aa;
								}
								break;
							}
							continue;
							end_IL_00aa:
							break;
						}
					}
					return ~num;
				}
				break;
			}
		}
	}

	public static uint smethod_1(string string_0)
	{
		uint num = uint.MaxValue;
		int num2 = string_0.Length;
		int num3 = Class84.smethod_0(0);
		byte byte_ = default(byte);
		ushort num7 = default(ushort);
		byte byte_2 = default(byte);
		while (num2 > Class84.smethod_0(0))
		{
			num2 -= Class84.smethod_0(1);
			while (true)
			{
				int num4 = Class84.smethod_0(58);
				int num5 = Class84.smethod_0(69);
				while (true)
				{
					num5 ^= Class84.smethod_0(67);
					while (true)
					{
						int num6 = Class84.smethod_0(37);
						while (true)
						{
							switch (num6 ^ Class84.smethod_0(48))
							{
							case 116:
								break;
							case 115:
								goto IL_00d8;
							case 114:
								num6 = Class84.smethod_0(49);
								continue;
							default:
								goto end_IL_00f0;
							case 117:
								goto end_IL_0116;
							}
							switch (num5)
							{
							case 115:
								goto IL_0047;
							case 118:
								goto IL_00cc;
							case 116:
								goto IL_0127;
							case 117:
								goto end_IL_012b;
							}
							num6 = 22;
							continue;
							IL_00cc:
							num4 ^= Class84.smethod_0(51);
							goto IL_00d8;
							IL_0127:
							num5 = 28;
							goto end_IL_0116;
							IL_0047:
							switch (num4)
							{
							case 114:
								break;
							case 115:
								goto IL_0078;
							case 116:
								goto IL_0086;
							case 117:
								goto IL_0095;
							case 118:
								goto IL_00a3;
							case 119:
								goto IL_00ba;
							default:
								goto IL_0121;
							case 120:
								goto end_IL_0139;
							}
							num4 = 31;
							goto IL_00cc;
							IL_0121:
							num5 = 29;
							goto end_IL_0116;
							IL_00ba:
							byte_ = (byte)(num7 & Class84.smethod_0(136));
							num4 = 27;
							goto IL_00cc;
							IL_00a3:
							byte_2 = (byte)(num7 >> Class84.smethod_0(75));
							num4 = Class84.smethod_0(55);
							goto IL_00cc;
							IL_0095:
							num7 = string_0[num2];
							num4 = 26;
							goto IL_00cc;
							IL_0086:
							num = Delegate384.smethod_0(byte_2, num);
							num4 = 30;
							goto IL_00cc;
							IL_0078:
							num = Delegate384.smethod_0(byte_, num);
							num4 = 21;
							goto IL_00cc;
							IL_00d8:
							num5 = Class84.smethod_0(71);
							num6 = 16;
							continue;
							end_IL_00f0:
							break;
						}
						continue;
						end_IL_0116:
						break;
					}
					continue;
					end_IL_012b:
					break;
				}
				continue;
				end_IL_0139:
				break;
			}
			num3 += Class84.smethod_0(1);
		}
		return ~num;
	}

	internal uint method_0(int int_0)
	{
		return Delegate385.smethod_0(this, (ushort)int_0);
	}

	internal uint method_1(ushort ushort_0)
	{
		byte byte_ = (byte)(ushort_0 & Class84.smethod_0(136));
		byte byte_2 = default(byte);
		while (true)
		{
			int num = Class89.smethod_1(54);
			while (true)
			{
				switch (num ^ Class84.smethod_0(410))
				{
				case -104:
					uint_0 = Delegate384.smethod_0(byte_2, uint_0);
					num = -1;
					continue;
				case -105:
					num = -2;
					continue;
				case -106:
					uint_0 = Delegate384.smethod_0(byte_, uint_0);
					num = Class89.smethod_1(56);
					continue;
				case -107:
					byte_2 = (byte)(ushort_0 >> Class84.smethod_0(75));
					num = -15;
					continue;
				case -103:
					return ~uint_0;
				}
				break;
			}
		}
	}

	private static uint smethod_2(byte byte_0, uint uint_2)
	{
		return uint_1[(uint_2 ^ byte_0) & (uint)Class84.smethod_0(136)] ^ (uint_2 >> Class84.smethod_0(75));
	}

	static Class21()
	{
		byte[] array = new byte[Class84.smethod_0(137)];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		uint_1 = (uint[])Class84.smethod_4(array);
	}
}
