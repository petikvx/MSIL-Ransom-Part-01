using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns0;

public class GClass2
{
	private object object_0;

	private object object_1;

	public GEnum3 genum3_0;

	public long long_0;

	public GClass2(FileStream fileStream_0, GEnum3 genum3_1 = (GEnum3)1, long long_1 = 0L)
	{
		int num = 10;
		if (!smethod_3())
		{
			while (true)
			{
				switch (num)
				{
				case 10:
					smethod_0(this);
					goto case 2;
				case 3:
					object_1 = null;
					num = 1;
					if (!smethod_3())
					{
						continue;
					}
					goto case 2;
				case 2:
					object_0 = null;
					goto case 3;
				case 1:
					genum3_0 = (GEnum3)1;
					break;
				case 5:
					break;
				default:
					goto IL_0081;
				case 6:
				case 9:
					goto IL_009a;
				case 7:
				case 8:
					goto IL_00ab;
				case 4:
					goto IL_00b2;
				case 11:
					return;
				}
				break;
			}
		}
		long_0 = 0L;
		goto IL_0081;
		IL_00b2:
		genum3_0 = genum3_1;
		return;
		IL_00ab:
		smethod_1(this, long_1);
		goto IL_00b2;
		IL_009a:
		object_1 = new BinaryWriter((Stream)object_0);
		goto IL_00ab;
		IL_0081:
		object_0 = fileStream_0;
		smethod_2();
		if (!smethod_3())
		{
			goto IL_009a;
		}
		goto IL_00ab;
	}

	public GClass2(string string_0, GEnum3 genum3_1 = (GEnum3)1, long long_1 = 0L)
	{
		while (true)
		{
			smethod_0(this);
			while (true)
			{
				object_0 = null;
				while (true)
				{
					object_1 = null;
					while (true)
					{
						genum3_0 = (GEnum3)1;
						while (true)
						{
							IL_008d:
							long_0 = 0L;
							while (true)
							{
								_ = 0;
								if (!smethod_2())
								{
									goto IL_0078;
								}
								int num = 4;
								if (smethod_3())
								{
									break;
								}
								goto IL_0021;
								IL_0078:
								smethod_1(this, long_1);
								num = 2;
								if (!smethod_2())
								{
									return;
								}
								goto IL_0021;
								IL_0021:
								switch (num)
								{
								case 4:
								case 5:
									object_0 = new FileStream(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
									goto case 1;
								case 1:
									object_1 = new BinaryWriter((Stream)object_0);
									goto IL_0078;
								case 7:
								case 10:
									goto IL_0078;
								case 9:
									goto IL_008d;
								case 0:
									goto end_IL_0006;
								case 3:
									goto end_IL_00a2;
								case 8:
									goto end_IL_00ab;
								case 6:
									goto end_IL_00b4;
								case 2:
									genum3_0 = genum3_1;
									return;
								case 11:
									return;
								}
								continue;
								end_IL_0006:
								break;
							}
							break;
						}
						continue;
						end_IL_00a2:
						break;
					}
					continue;
					end_IL_00ab:
					break;
				}
				continue;
				end_IL_00b4:
				break;
			}
		}
	}

	public GClass2(string string_0, FileMode fileMode_0, GEnum3 genum3_1 = (GEnum3)1, long long_1 = 0L)
		: this(new FileStream(string_0, fileMode_0, FileAccess.ReadWrite, FileShare.ReadWrite), genum3_1, long_1)
	{
	}

	public GClass2(byte[] byte_0, GEnum3 genum3_1 = (GEnum3)1, long long_1 = 0L)
	{
		smethod_0(this);
		object_0 = null;
		object_1 = null;
		genum3_0 = (GEnum3)1;
		long_0 = 0L;
		object_0 = new MemoryStream(byte_0);
		object_1 = new BinaryWriter((Stream)object_0);
		smethod_3();
		if (smethod_2())
		{
			smethod_1(this, long_1);
		}
		genum3_0 = genum3_1;
	}

	public GClass2(Stream stream_0, GEnum3 genum3_1 = (GEnum3)1, long long_1 = 0L)
	{
		smethod_0(this);
		object_0 = null;
		object_1 = null;
		genum3_0 = (GEnum3)1;
		_ = 1;
		if (!smethod_3())
		{
			long_0 = 0L;
			object_0 = stream_0;
		}
		object_1 = new BinaryWriter((Stream)object_0);
		smethod_1(this, long_1);
		genum3_0 = genum3_1;
	}

	public GClass2(MemoryStream memoryStream_0, GEnum3 genum3_1 = (GEnum3)1, long long_1 = 0L)
	{
		smethod_2();
		if (!smethod_3())
		{
			smethod_0(this);
			object_0 = null;
		}
		object_1 = null;
		genum3_0 = (GEnum3)1;
		long_0 = 0L;
		object_0 = memoryStream_0;
		object_1 = new BinaryWriter((Stream)object_0);
		smethod_1(this, long_1);
		genum3_0 = genum3_1;
	}

	[SpecialName]
	public long method_0()
	{
		return smethod_4(object_0);
	}

	[SpecialName]
	public void method_1(long long_1)
	{
		long_0 = smethod_4(object_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_5(object_0, long_1);
		}
	}

	public void method_2(long long_1)
	{
		smethod_6(this, long_1, SeekOrigin.Begin);
	}

	public void method_3(long long_1, SeekOrigin seekOrigin_0)
	{
		long_0 = smethod_4(object_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_8(smethod_7(object_1), long_1, seekOrigin_0);
		}
	}

	[SpecialName]
	public long method_4()
	{
		return smethod_9(object_0);
	}

	public void method_5(byte[] byte_0, GEnum3 genum3_1)
	{
		int num = 4;
		if (!smethod_2())
		{
			goto IL_005f;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				long_0 = smethod_4(object_0);
				_ = 0;
				if (!smethod_2())
				{
					num = 5;
					if (!smethod_3())
					{
					}
					continue;
				}
				goto IL_005f;
			case 6:
				break;
			case 0:
			case 1:
				goto IL_005f;
			case 2:
				goto IL_0063;
			default:
				goto IL_006a;
			}
			break;
		}
		goto IL_005c;
		IL_0063:
		smethod_10(byte_0);
		goto IL_006a;
		IL_005c:
		if (true)
		{
			return;
		}
		goto IL_005f;
		IL_006a:
		smethod_11(object_1, byte_0, 0, byte_0.Length);
		goto IL_005c;
		IL_005f:
		if (genum3_1 == (GEnum3)2)
		{
			goto IL_0063;
		}
		goto IL_006a;
	}

	public void method_6(byte[] byte_0, int int_0, GEnum3 genum3_1)
	{
		_ = 1;
		if (!smethod_3())
		{
			long_0 = smethod_4(object_0);
		}
		do
		{
			if (genum3_1 == (GEnum3)2)
			{
				smethod_10(byte_0);
			}
			smethod_11(object_1, byte_0, 0, int_0);
		}
		while (1 == 0);
	}

	public void method_7(byte[] byte_0, int int_0, int int_1, GEnum3 genum3_1)
	{
		long_0 = smethod_4(object_0);
		for (int num = 0; num == 0; num = 1)
		{
			if (genum3_1 == (GEnum3)2)
			{
				smethod_2();
				if (!smethod_3())
				{
					smethod_10(byte_0);
				}
			}
			smethod_11(object_1, byte_0, int_0, int_1);
		}
	}

	public void method_8(byte[] byte_0)
	{
		smethod_12(this, byte_0, genum3_0);
	}

	public void method_9(byte[] byte_0, int int_0)
	{
		smethod_13(this, byte_0, int_0, genum3_0);
	}

	public void method_10(byte[] byte_0, int int_0, int int_1)
	{
		smethod_14(this, byte_0, int_0, int_1, genum3_0);
	}

	public void method_11(sbyte sbyte_0)
	{
		byte[] object_ = (byte[])smethod_15(sbyte_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_16(this, object_, 0, 1);
		}
	}

	public void method_12(short short_0)
	{
		smethod_17(this, short_0, genum3_0);
	}

	public void method_13(short short_0, GEnum3 genum3_1)
	{
		byte[] object_ = (byte[])smethod_15(short_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_14(this, object_, 0, 2, genum3_1);
		}
	}

	public void method_14(ushort ushort_0)
	{
		smethod_18(this, ushort_0, genum3_0);
	}

	public void method_15(ushort ushort_0, GEnum3 genum3_1)
	{
		byte[] object_ = (byte[])smethod_19(ushort_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_14(this, object_, 0, 2, genum3_1);
		}
	}

	public void method_16(int int_0)
	{
		smethod_20(this, int_0, genum3_0);
	}

	public void method_17(int int_0, GEnum3 genum3_1)
	{
		smethod_14(this, smethod_21(int_0), 0, 3, genum3_1);
	}

	public void method_18(uint uint_0)
	{
		smethod_22(this, uint_0, genum3_0);
	}

	public void method_19(uint uint_0, GEnum3 genum3_1)
	{
		smethod_14(this, smethod_21(checked((int)uint_0)), 0, 3, genum3_1);
	}

	public void method_20(int int_0)
	{
		smethod_23(this, int_0, genum3_0);
	}

	public void method_21(int int_0, GEnum3 genum3_1)
	{
		byte[] object_ = (byte[])smethod_24(int_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_14(this, object_, 0, 4, genum3_1);
		}
	}

	public void method_22(uint uint_0)
	{
		smethod_25(this, uint_0, genum3_0);
	}

	public void method_23(uint uint_0, GEnum3 genum3_1)
	{
		byte[] object_ = (byte[])smethod_26(uint_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_14(this, object_, 0, 4, genum3_1);
		}
	}

	public void method_24(long long_1)
	{
		smethod_27(this, long_1, genum3_0);
	}

	public void method_25(long long_1, GEnum3 genum3_1)
	{
		smethod_14(this, smethod_28(long_1), 0, 5, genum3_1);
	}

	public void method_26(ulong ulong_0)
	{
		smethod_29(this, ulong_0, genum3_0);
	}

	public void method_27(ulong ulong_0, GEnum3 genum3_1)
	{
		smethod_14(this, smethod_28(checked((long)ulong_0)), 0, 5, genum3_1);
	}

	public void method_28(long long_1)
	{
		smethod_30(this, long_1, genum3_0);
	}

	public void method_29(long long_1, GEnum3 genum3_1)
	{
		smethod_14(this, smethod_31(long_1), 0, 6, genum3_1);
	}

	public void method_30(ulong ulong_0)
	{
		smethod_32(this, ulong_0, genum3_0);
	}

	public void method_31(ulong ulong_0, GEnum3 genum3_1)
	{
		smethod_14(this, smethod_31(checked((long)ulong_0)), 0, 6, genum3_1);
	}

	public void method_32(long long_1)
	{
		smethod_33(this, long_1, genum3_0);
	}

	public void method_33(long long_1, GEnum3 genum3_1)
	{
		smethod_14(this, smethod_34(long_1), 0, 7, genum3_1);
	}

	public void method_34(ulong ulong_0)
	{
		smethod_35(this, ulong_0, genum3_0);
	}

	public void method_35(ulong ulong_0, GEnum3 genum3_1)
	{
		smethod_14(this, smethod_34(checked((long)ulong_0)), 0, 7, genum3_1);
	}

	public void method_36(long long_1)
	{
		smethod_36(this, long_1, genum3_0);
	}

	public void method_37(long long_1, GEnum3 genum3_1)
	{
		byte[] object_ = (byte[])smethod_37(long_1);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_14(this, object_, 0, 8, genum3_1);
		}
	}

	public void method_38(ulong ulong_0)
	{
		smethod_38(this, ulong_0, genum3_0);
	}

	public void method_39(ulong ulong_0, GEnum3 genum3_1)
	{
		byte[] object_ = (byte[])smethod_39(ulong_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_14(this, object_, 0, 8, genum3_1);
		}
	}

	public void method_40(float float_0)
	{
		smethod_40(this, float_0, genum3_0);
	}

	public void method_41(float float_0, GEnum3 genum3_1)
	{
		byte[] object_ = (byte[])smethod_41(float_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_14(this, object_, 0, 4, genum3_1);
		}
	}

	public void method_42(double double_0)
	{
		smethod_42(this, double_0, genum3_0);
	}

	public void method_43(double double_0, GEnum3 genum3_1)
	{
		byte[] object_ = (byte[])smethod_43(double_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_14(this, object_, 0, 8, genum3_1);
		}
	}

	public void method_44(char char_0)
	{
		long_0 = smethod_4(object_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_44(object_1, char_0);
		}
	}

	public void method_45(char[] char_0)
	{
		smethod_2();
		int num = default(int);
		if (!smethod_3())
		{
			num = 0;
			goto IL_0016;
		}
		goto IL_0027;
		IL_0016:
		if (num < char_0.Length)
		{
			char char_ = char_0[num];
			smethod_45(this, char_);
			goto IL_0027;
		}
		return;
		IL_0027:
		num = checked(num + 1);
		goto IL_0016;
	}

	public void method_46(string string_0)
	{
		smethod_47(this, string_0, 0, smethod_46(string_0));
	}

	public void method_47(string string_0, int int_0)
	{
		smethod_47(this, string_0, 0, int_0);
	}

	public void method_48(string string_0, int int_0, int int_1)
	{
		byte[] object_ = (byte[])smethod_49(smethod_48(), string_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_16(this, object_, int_0, int_1);
		}
	}

	public void method_49(string string_0)
	{
		_ = 1;
		int num;
		if (!smethod_3())
		{
			num = 5;
			if (smethod_3())
			{
				return;
			}
			goto IL_0048;
		}
		goto IL_0072;
		IL_006b:
		char[] object_ = (char[])smethod_50(string_0);
		goto IL_0072;
		IL_0072:
		if (genum3_0 != (GEnum3)2)
		{
			smethod_12(this, smethod_52(smethod_53(), object_), (GEnum3)1);
			num = 6;
			if (!smethod_3())
			{
				goto IL_0048;
			}
			goto IL_006b;
		}
		goto IL_007b;
		IL_007b:
		smethod_12(this, smethod_52(smethod_51(), object_), (GEnum3)1);
		return;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			default:
				num = 4;
				if (!smethod_3())
				{
				}
				continue;
			case 0:
			case 5:
				break;
			case 1:
			case 2:
				goto IL_0072;
			case 3:
				goto IL_007b;
			case 4:
				return;
			case 6:
				return;
			}
			break;
		}
		goto IL_006b;
	}

	public void method_50(string string_0, int int_0)
	{
		smethod_54(this, string_0, 0, int_0, genum3_0);
	}

	public void method_51(string string_0, int int_0, int int_1)
	{
		smethod_54(this, string_0, int_0, int_1, genum3_0);
	}

	public void method_52(string string_0, int int_0, int int_1, GEnum3 genum3_1)
	{
		char[] object_ = (char[])smethod_50(string_0);
		_ = 0;
		if (smethod_2() && genum3_1 != (GEnum3)2)
		{
			smethod_14(this, smethod_52(smethod_53(), object_), int_0, int_1, (GEnum3)1);
		}
		else
		{
			smethod_14(this, smethod_52(smethod_51(), object_), int_0, int_1, (GEnum3)1);
		}
	}

	public void method_53(string string_0)
	{
		byte[] array = (byte[])smethod_55(string_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_16(this, array, 0, array.Length);
		}
	}

	public void method_54(string string_0, int int_0)
	{
		smethod_56(this, string_0, int_0, genum3_0);
	}

	public void method_55(string string_0, int int_0, GEnum3 genum3_1)
	{
		smethod_13(this, smethod_55(string_0), int_0, genum3_1);
	}

	public void method_56()
	{
		smethod_3();
		if (smethod_2() && genum3_0 != (GEnum3)1)
		{
			genum3_0 = (GEnum3)1;
		}
		else
		{
			genum3_0 = (GEnum3)2;
		}
	}

	public void method_57()
	{
		smethod_57(object_1);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_58(object_0);
		}
	}

	public void method_58()
	{
		smethod_59(this);
		smethod_3();
		if (smethod_2())
		{
			smethod_60(object_1);
		}
		smethod_61(object_0);
	}

	internal static void smethod_0(object object_2)
	{
		object_2._002Ector();
	}

	internal static void smethod_1(object object_2, long long_1)
	{
		((GClass2)object_2).method_1(long_1);
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static bool smethod_3()
	{
		return false;
	}

	internal static long smethod_4(object object_2)
	{
		return ((Stream)object_2).Position;
	}

	internal static void smethod_5(object object_2, long long_1)
	{
		((Stream)object_2).Position = long_1;
	}

	internal static void smethod_6(object object_2, long long_1, SeekOrigin seekOrigin_0)
	{
		((GClass2)object_2).method_3(long_1, seekOrigin_0);
	}

	internal static object smethod_7(object object_2)
	{
		return ((BinaryWriter)object_2).BaseStream;
	}

	internal static long smethod_8(object object_2, long long_1, SeekOrigin seekOrigin_0)
	{
		return ((Stream)object_2).Seek(long_1, seekOrigin_0);
	}

	internal static long smethod_9(object object_2)
	{
		return ((Stream)object_2).Length;
	}

	internal static object smethod_10(object object_2)
	{
		return GClass4.smethod_3(object_2);
	}

	internal static void smethod_11(object object_2, object object_3, int int_0, int int_1)
	{
		((BinaryWriter)object_2).Write((byte[])object_3, int_0, int_1);
	}

	internal static void smethod_12(object object_2, object object_3, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_5((byte[])object_3, genum3_1);
	}

	internal static void smethod_13(object object_2, object object_3, int int_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_6((byte[])object_3, int_0, genum3_1);
	}

	internal static void smethod_14(object object_2, object object_3, int int_0, int int_1, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_7((byte[])object_3, int_0, int_1, genum3_1);
	}

	internal static object smethod_15(short short_0)
	{
		return BitConverter.GetBytes(short_0);
	}

	internal static void smethod_16(object object_2, object object_3, int int_0, int int_1)
	{
		((GClass2)object_2).method_10((byte[])object_3, int_0, int_1);
	}

	internal static void smethod_17(object object_2, short short_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_13(short_0, genum3_1);
	}

	internal static void smethod_18(object object_2, ushort ushort_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_15(ushort_0, genum3_1);
	}

	internal static object smethod_19(ushort ushort_0)
	{
		return BitConverter.GetBytes(ushort_0);
	}

	internal static void smethod_20(object object_2, int int_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_17(int_0, genum3_1);
	}

	internal static object smethod_21(int int_0)
	{
		return GClass3.smethod_13(int_0);
	}

	internal static void smethod_22(object object_2, uint uint_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_19(uint_0, genum3_1);
	}

	internal static void smethod_23(object object_2, int int_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_21(int_0, genum3_1);
	}

	internal static object smethod_24(int int_0)
	{
		return BitConverter.GetBytes(int_0);
	}

	internal static void smethod_25(object object_2, uint uint_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_23(uint_0, genum3_1);
	}

	internal static object smethod_26(uint uint_0)
	{
		return BitConverter.GetBytes(uint_0);
	}

	internal static void smethod_27(object object_2, long long_1, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_25(long_1, genum3_1);
	}

	internal static object smethod_28(long long_1)
	{
		return GClass3.smethod_17(long_1);
	}

	internal static void smethod_29(object object_2, ulong ulong_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_27(ulong_0, genum3_1);
	}

	internal static void smethod_30(object object_2, long long_1, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_29(long_1, genum3_1);
	}

	internal static object smethod_31(long long_1)
	{
		return GClass3.smethod_19(long_1);
	}

	internal static void smethod_32(object object_2, ulong ulong_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_31(ulong_0, genum3_1);
	}

	internal static void smethod_33(object object_2, long long_1, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_33(long_1, genum3_1);
	}

	internal static object smethod_34(long long_1)
	{
		return GClass3.smethod_21(long_1);
	}

	internal static void smethod_35(object object_2, ulong ulong_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_35(ulong_0, genum3_1);
	}

	internal static void smethod_36(object object_2, long long_1, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_37(long_1, genum3_1);
	}

	internal static object smethod_37(long long_1)
	{
		return BitConverter.GetBytes(long_1);
	}

	internal static void smethod_38(object object_2, ulong ulong_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_39(ulong_0, genum3_1);
	}

	internal static object smethod_39(ulong ulong_0)
	{
		return BitConverter.GetBytes(ulong_0);
	}

	internal static void smethod_40(object object_2, float float_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_41(float_0, genum3_1);
	}

	internal static object smethod_41(float float_0)
	{
		return BitConverter.GetBytes(float_0);
	}

	internal static void smethod_42(object object_2, double double_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_43(double_0, genum3_1);
	}

	internal static object smethod_43(double double_0)
	{
		return BitConverter.GetBytes(double_0);
	}

	internal static void smethod_44(object object_2, char char_0)
	{
		((BinaryWriter)object_2).Write(char_0);
	}

	internal static void smethod_45(object object_2, char char_0)
	{
		((GClass2)object_2).method_44(char_0);
	}

	internal static int smethod_46(object object_2)
	{
		return ((string)object_2).Length;
	}

	internal static void smethod_47(object object_2, object object_3, int int_0, int int_1)
	{
		((GClass2)object_2).method_48((string)object_3, int_0, int_1);
	}

	internal static object smethod_48()
	{
		return Encoding.ASCII;
	}

	internal static object smethod_49(object object_2, object object_3)
	{
		return ((Encoding)object_2).GetBytes((string)object_3);
	}

	internal static object smethod_50(object object_2)
	{
		return ((string)object_2).ToCharArray();
	}

	internal static object smethod_51()
	{
		return Encoding.BigEndianUnicode;
	}

	internal static object smethod_52(object object_2, object object_3)
	{
		return ((Encoding)object_2).GetBytes((char[])object_3);
	}

	internal static object smethod_53()
	{
		return Encoding.Unicode;
	}

	internal static void smethod_54(object object_2, object object_3, int int_0, int int_1, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_52((string)object_3, int_0, int_1, genum3_1);
	}

	internal static object smethod_55(object object_2)
	{
		return GClass3.smethod_8(object_2);
	}

	internal static void smethod_56(object object_2, object object_3, int int_0, GEnum3 genum3_1)
	{
		((GClass2)object_2).method_55((string)object_3, int_0, genum3_1);
	}

	internal static void smethod_57(object object_2)
	{
		((BinaryWriter)object_2).Flush();
	}

	internal static void smethod_58(object object_2)
	{
		((Stream)object_2).Flush();
	}

	internal static void smethod_59(object object_2)
	{
		((GClass2)object_2).method_57();
	}

	internal static void smethod_60(object object_2)
	{
		((BinaryWriter)object_2).Close();
	}

	internal static void smethod_61(object object_2)
	{
		((Stream)object_2).Close();
	}
}
