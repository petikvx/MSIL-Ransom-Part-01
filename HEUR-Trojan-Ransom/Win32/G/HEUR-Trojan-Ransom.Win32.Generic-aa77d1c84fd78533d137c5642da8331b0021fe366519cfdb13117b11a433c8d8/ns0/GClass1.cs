using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;

namespace ns0;

public class GClass1
{
	public enum GEnum1
	{

	}

	public enum GEnum2
	{

	}

	private object object_0;

	private object object_1;

	public GEnum3 genum3_0;

	public long long_0;

	public GClass1(FileStream fileStream_0, GEnum3 genum3_1 = (GEnum3)1, long long_1 = 0L)
	{
		while (true)
		{
			smethod_0(this);
			_ = 0;
			if (!smethod_2())
			{
				if (smethod_3())
				{
				}
				switch (5)
				{
				case 10:
					break;
				case 1:
				case 8:
					goto IL_0054;
				case 7:
					goto IL_005b;
				case 6:
					goto IL_0062;
				case 4:
				case 5:
					goto IL_0069;
				default:
					goto IL_0078;
				case 9:
					goto IL_007f;
				case 3:
					goto IL_0090;
				case 2:
					goto end_IL_0001;
				case 11:
					return;
				}
				continue;
			}
			goto IL_0054;
			IL_007f:
			object_1 = new BinaryReader((Stream)object_0);
			goto IL_0090;
			IL_0090:
			smethod_1(this, long_1);
			break;
			IL_0054:
			object_0 = null;
			goto IL_005b;
			IL_005b:
			object_1 = null;
			goto IL_0062;
			IL_0062:
			genum3_0 = (GEnum3)1;
			goto IL_0069;
			IL_0069:
			long_0 = 0L;
			goto IL_0078;
			IL_0078:
			object_0 = fileStream_0;
			goto IL_007f;
			continue;
			end_IL_0001:
			break;
		}
		genum3_0 = genum3_1;
	}

	public GClass1(string string_0, GEnum3 genum3_1 = (GEnum3)1, long long_1 = 0L)
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
					if (!smethod_3())
					{
						switch (2)
						{
						case 6:
							break;
						case 10:
							goto end_IL_0003;
						case 0:
							goto end_IL_004d;
						case 2:
							goto IL_005f;
						case 7:
							goto IL_0066;
						default:
							goto IL_0075;
						case 4:
						case 5:
							goto IL_007e;
						case 3:
							goto IL_008d;
						case 1:
							goto IL_009e;
						case 8:
						case 9:
							goto IL_00a8;
						case 11:
							return;
						}
						continue;
					}
					goto IL_005f;
					IL_00a8:
					genum3_0 = genum3_1;
					return;
					IL_005f:
					genum3_0 = (GEnum3)1;
					goto IL_0066;
					IL_0066:
					long_0 = 0L;
					goto IL_0075;
					IL_0075:
					_ = 1;
					if (!smethod_3())
					{
						goto IL_007e;
					}
					goto IL_00a8;
					IL_007e:
					object_0 = new FileStream(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
					goto IL_008d;
					IL_008d:
					object_1 = new BinaryReader((Stream)object_0);
					goto IL_009e;
					IL_009e:
					smethod_1(this, long_1);
					goto IL_00a8;
					continue;
					end_IL_0003:
					break;
				}
				continue;
				end_IL_004d:
				break;
			}
		}
	}

	public GClass1(byte[] byte_0, GEnum3 genum3_1 = (GEnum3)1, long long_1 = 0L)
	{
		while (true)
		{
			smethod_0(this);
			while (true)
			{
				object_0 = null;
				smethod_3();
				if (smethod_2())
				{
					int num = 9;
					if (smethod_3())
					{
						return;
					}
					while (true)
					{
						switch (num)
						{
						case 0:
							break;
						case 2:
						case 9:
							object_1 = null;
							num = 8;
							if (!smethod_3())
							{
								continue;
							}
							goto IL_00b6;
						default:
							num = 1;
							if (!smethod_3())
							{
							}
							continue;
						case 7:
							goto end_IL_0003;
						case 8:
							genum3_0 = (GEnum3)1;
							goto case 3;
						case 3:
							long_0 = 0L;
							goto case 1;
						case 1:
							object_0 = new MemoryStream(byte_0);
							goto IL_00b6;
						case 5:
						case 6:
							goto IL_00b6;
						case 10:
							goto IL_00c7;
						case 4:
							goto IL_00ce;
						case 11:
							return;
						}
						break;
					}
					continue;
				}
				goto IL_00b6;
				IL_00c7:
				smethod_1(this, long_1);
				goto IL_00ce;
				IL_00ce:
				genum3_0 = genum3_1;
				return;
				IL_00b6:
				object_1 = new BinaryReader((Stream)object_0);
				goto IL_00c7;
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	public GClass1(Stream stream_0, GEnum3 genum3_1 = (GEnum3)1, long long_1 = 0L)
	{
		while (true)
		{
			IL_0001:
			smethod_0(this);
			smethod_3();
			if (!smethod_2())
			{
				goto IL_00a3;
			}
			goto IL_0067;
			IL_0067:
			object_0 = null;
			goto IL_006e;
			IL_006e:
			object_1 = null;
			goto IL_0075;
			IL_0075:
			genum3_0 = (GEnum3)1;
			goto IL_007c;
			IL_007c:
			long_0 = 0L;
			goto IL_008b;
			IL_008b:
			object_0 = stream_0;
			goto IL_0092;
			IL_0092:
			object_1 = new BinaryReader((Stream)object_0);
			goto IL_00a3;
			IL_00a3:
			while (true)
			{
				IL_00a3_2:
				smethod_1(this, long_1);
				while (true)
				{
					genum3_0 = genum3_1;
					if (smethod_3())
					{
						break;
					}
					switch (11)
					{
					case 9:
						break;
					case 10:
						continue;
					case 1:
					case 2:
						goto end_IL_001c;
					case 4:
						goto IL_006e;
					case 8:
						goto IL_0075;
					case 3:
						goto IL_007c;
					default:
						goto IL_008b;
					case 5:
						goto IL_0092;
					case 0:
					case 7:
						goto IL_00a3_2;
					case 11:
						return;
					}
					goto IL_0001;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
			goto IL_0067;
		}
	}

	public GClass1(MemoryStream memoryStream_0, GEnum3 genum3_1 = (GEnum3)1, long long_1 = 0L)
	{
		while (true)
		{
			smethod_0(this);
			while (true)
			{
				object_0 = null;
				_ = 1;
				int num;
				if (smethod_3())
				{
					num = 9;
					if (!smethod_2())
					{
						goto IL_004f;
					}
					goto IL_007e;
				}
				goto IL_0075;
				IL_007e:
				switch (num)
				{
				case 10:
					break;
				case 4:
				case 9:
					goto IL_0028;
				default:
					goto IL_0037;
				case 8:
					goto IL_003e;
				case 6:
					goto IL_004f;
				case 0:
					goto IL_0056;
				case 3:
					goto IL_006c;
				case 2:
				case 7:
					goto IL_0075;
				case 5:
					goto end_IL_0006;
				case 11:
					return;
				}
				continue;
				IL_0075:
				object_1 = null;
				goto IL_006c;
				IL_006c:
				genum3_0 = (GEnum3)1;
				goto IL_0028;
				IL_0028:
				long_0 = 0L;
				goto IL_0037;
				IL_0037:
				object_0 = memoryStream_0;
				goto IL_003e;
				IL_003e:
				object_1 = new BinaryReader((Stream)object_0);
				goto IL_004f;
				IL_004f:
				smethod_1(this, long_1);
				goto IL_0056;
				IL_0056:
				genum3_0 = genum3_1;
				num = 11;
				if (!smethod_2())
				{
					goto IL_0075;
				}
				goto IL_007e;
				continue;
				end_IL_0006:
				break;
			}
		}
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

	public int method_5()
	{
		long_0 = smethod_4(object_0);
		return smethod_10(object_1);
	}

	public int method_6(char[] char_0, int int_0)
	{
		return smethod_11(this, char_0, 0, int_0);
	}

	public int method_7(char[] char_0, int int_0, int int_1)
	{
		long_0 = smethod_4(object_0);
		return smethod_12(object_1, char_0, int_0, int_1);
	}

	public int method_8(byte[] byte_0, int int_0)
	{
		return smethod_13(this, byte_0, 0, int_0);
	}

	public int method_9(byte[] byte_0, int int_0, int int_1)
	{
		long_0 = smethod_4(object_0);
		return smethod_14(object_1, byte_0, int_0, int_1);
	}

	public bool method_10()
	{
		long_0 = smethod_4(object_0);
		return smethod_15(object_1);
	}

	public char method_11()
	{
		char result = smethod_16(this);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_1(this, long_0);
		}
		return result;
	}

	public char[] method_12(int int_0)
	{
		char[] result = (char[])smethod_17(this, int_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_1(this, long_0);
		}
		return result;
	}

	public byte method_13()
	{
		byte result = smethod_18(this);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_1(this, long_0);
		}
		return result;
	}

	public byte[] method_14(int int_0)
	{
		return (byte[])smethod_19(this, int_0, genum3_0);
	}

	public byte[] method_15(int int_0, GEnum3 genum3_1)
	{
		byte[] result = (byte[])smethod_20(this, int_0, genum3_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_1(this, long_0);
		}
		return result;
	}

	public string method_16(int int_0)
	{
		string result = (string)smethod_21(this, int_0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_1(this, long_0);
		}
		return result;
	}

	public string method_17(int int_0)
	{
		return (string)smethod_22(this, int_0, genum3_0);
	}

	public string method_18(int int_0, GEnum3 genum3_1)
	{
		string result = (string)smethod_23(this, int_0, genum3_1);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_1(this, long_0);
		}
		return result;
	}

	public string method_19(int int_0)
	{
		return (string)smethod_24(this, int_0, genum3_0);
	}

	public string method_20(int int_0, GEnum3 genum3_1)
	{
		string result = (string)smethod_25(this, int_0, genum3_1);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_1(this, long_0);
		}
		return result;
	}

	public byte method_21()
	{
		long_0 = smethod_4(object_0);
		return smethod_26(object_1);
	}

	public byte[] method_22(int int_0)
	{
		return (byte[])smethod_20(this, int_0, genum3_0);
	}

	public byte[] method_23(int int_0, GEnum3 genum3_1)
	{
		smethod_3();
		byte[] array = default(byte[]);
		if (smethod_2())
		{
			while (true)
			{
				long_0 = smethod_4(object_0);
				if (smethod_2())
				{
					switch (1)
					{
					case 0:
					case 4:
						break;
					case 1:
						goto IL_0051;
					case 5:
						goto IL_005e;
					default:
						goto end_IL_000d;
					case 6:
						goto IL_006f;
					}
					continue;
				}
				goto IL_0051;
				IL_005e:
				if (1 == 0)
				{
					goto IL_0051;
				}
				if (genum3_1 == (GEnum3)2)
				{
					break;
				}
				goto IL_006f;
				IL_0051:
				array = (byte[])smethod_27(object_1, int_0);
				goto IL_005e;
				continue;
				end_IL_000d:
				break;
			}
		}
		smethod_28(array);
		goto IL_006f;
		IL_006f:
		return array;
	}

	public byte[] method_24(int int_0, int int_1)
	{
		return (byte[])smethod_29(this, int_0, int_1, genum3_0);
	}

	public byte[] method_25(int int_0, int int_1, GEnum3 genum3_1)
	{
		smethod_3();
		if (smethod_2())
		{
			long_0 = smethod_4(object_0);
		}
		byte[] array = new byte[checked(int_1 - 1 + 1)];
		smethod_30(smethod_20(this, int_1, genum3_1), int_0, array, 0, int_1);
		return array;
	}

	public sbyte method_26()
	{
		long_0 = smethod_4(object_0);
		return smethod_31(object_1);
	}

	public short method_27()
	{
		return smethod_32(this, genum3_0);
	}

	public short method_28(GEnum3 genum3_1)
	{
		return smethod_33(smethod_20(this, 2, genum3_1), 0);
	}

	public ushort method_29()
	{
		return smethod_34(this, genum3_0);
	}

	public ushort method_30(GEnum3 genum3_1)
	{
		return smethod_35(smethod_20(this, 2, genum3_1), 0);
	}

	public int method_31()
	{
		return smethod_36(this, genum3_0);
	}

	public int method_32(GEnum3 genum3_1)
	{
		return smethod_37(smethod_20(this, 3, genum3_1));
	}

	public uint method_33()
	{
		return smethod_38(this, genum3_0);
	}

	public uint method_34(GEnum3 genum3_1)
	{
		return checked((uint)smethod_37(smethod_20(this, 3, genum3_1)));
	}

	public int method_35()
	{
		return smethod_39(this, genum3_0);
	}

	public int method_36(GEnum3 genum3_1)
	{
		return smethod_40(smethod_20(this, 4, genum3_1), 0);
	}

	public uint method_37()
	{
		return smethod_41(this, genum3_0);
	}

	public uint method_38(GEnum3 genum3_1)
	{
		return smethod_42(smethod_20(this, 4, genum3_1), 0);
	}

	public long method_39()
	{
		return smethod_43(this, genum3_0);
	}

	public long method_40(GEnum3 genum3_1)
	{
		return smethod_44(smethod_20(this, 5, genum3_1));
	}

	public ulong method_41()
	{
		return smethod_45(this, genum3_0);
	}

	public ulong method_42(GEnum3 genum3_1)
	{
		return checked((ulong)smethod_44(smethod_20(this, 5, genum3_1)));
	}

	public long method_43()
	{
		return smethod_46(this, genum3_0);
	}

	public long method_44(GEnum3 genum3_1)
	{
		return smethod_47(smethod_20(this, 6, genum3_1));
	}

	public ulong method_45()
	{
		return smethod_48(this, genum3_0);
	}

	public ulong method_46(GEnum3 genum3_1)
	{
		return checked((ulong)smethod_47(smethod_20(this, 6, genum3_1)));
	}

	public long method_47()
	{
		return smethod_49(this, genum3_0);
	}

	public long method_48(GEnum3 genum3_1)
	{
		return smethod_50(smethod_20(this, 7, genum3_1));
	}

	public ulong method_49()
	{
		return smethod_51(this, genum3_0);
	}

	public ulong method_50(GEnum3 genum3_1)
	{
		return checked((ulong)smethod_50(smethod_20(this, 7, genum3_1)));
	}

	public long method_51()
	{
		return smethod_52(this, genum3_0);
	}

	public long method_52(GEnum3 genum3_1)
	{
		return smethod_53(smethod_20(this, 8, genum3_1), 0);
	}

	public ulong method_53()
	{
		return smethod_54(this, genum3_0);
	}

	public ulong method_54(GEnum3 genum3_1)
	{
		return smethod_55(smethod_20(this, 8, genum3_1), 0);
	}

	public float method_55()
	{
		return smethod_56(this, genum3_0);
	}

	public float method_56(GEnum3 genum3_1)
	{
		return smethod_57(smethod_20(this, 4, genum3_1), 0);
	}

	public double method_57()
	{
		return smethod_58(this, genum3_0);
	}

	public double method_58(GEnum3 genum3_1)
	{
		return smethod_59(smethod_20(this, 8, genum3_1), 0);
	}

	public char method_59()
	{
		long_0 = smethod_4(object_0);
		return smethod_60(object_1);
	}

	public char[] method_60(int int_0)
	{
		long_0 = smethod_4(object_0);
		return (char[])smethod_61(object_1, int_0);
	}

	public string method_61(int int_0)
	{
		return (string)smethod_63(smethod_62(), smethod_20(this, int_0, (GEnum3)1));
	}

	public string method_62(int int_0)
	{
		return (string)smethod_23(this, int_0, genum3_0);
	}

	public string method_63(int int_0, GEnum3 genum3_1)
	{
		byte[] object_ = (byte[])smethod_20(this, checked(int_0 * 2), (GEnum3)1);
		if (genum3_1 == (GEnum3)2)
		{
			return (string)smethod_63(smethod_64(), object_);
		}
		return (string)smethod_63(smethod_65(), object_);
	}

	public string method_64(int int_0)
	{
		return (string)smethod_25(this, int_0, genum3_0);
	}

	public string method_65(int int_0, GEnum3 genum3_1)
	{
		return (string)smethod_66(smethod_20(this, int_0, genum3_1));
	}

	public List<int> method_66(string string_0, GEnum2 genum2_0, long long_1 = 0L, bool bool_0 = true)
	{
		return method_68(genum2_0 switch
		{
			(GEnum2)0 => Encoding.ASCII.GetBytes(string_0), 
			(GEnum2)1 => Encoding.Unicode.GetBytes(string_0), 
			(GEnum2)2 => Encoding.BigEndianUnicode.GetBytes(string_0), 
			_ => GClass3.smethod_8(string_0), 
		}, long_1, bool_0);
	}

	public List<int> method_67(long long_1, GEnum1 genum1_0, bool bool_0 = false, long long_2 = 0L, bool bool_1 = true)
	{
		return method_68(checked(genum1_0 switch
		{
			(GEnum1)0 => new byte[1] { (byte)(sbyte)long_1 }, 
			(GEnum1)1 => (byte[])Interaction.IIf(bool_0, (object)GClass3.smethod_11((short)(ushort)long_1), (object)GClass3.smethod_11((short)long_1)), 
			(GEnum1)2 => (byte[])Interaction.IIf(bool_0, (object)GClass3.smethod_13((int)(uint)long_1), (object)GClass3.smethod_13((int)long_1)), 
			(GEnum1)3 => (byte[])Interaction.IIf(bool_0, (object)GClass3.smethod_15((int)(uint)long_1), (object)GClass3.smethod_15((int)long_1)), 
			(GEnum1)4 => (byte[])Interaction.IIf(bool_0, (object)GClass3.smethod_19((long)(ulong)long_1), (object)GClass3.smethod_19(long_1)), 
			(GEnum1)5 => (byte[])Interaction.IIf(bool_0, (object)GClass3.smethod_21((long)(ulong)long_1), (object)GClass3.smethod_21(long_1)), 
			(GEnum1)6 => (byte[])Interaction.IIf(bool_0, (object)GClass3.smethod_23((long)(ulong)long_1), (object)GClass3.smethod_23(long_1)), 
			(GEnum1)7 => GClass3.smethod_25(long_1), 
			_ => GClass3.smethod_27(long_1), 
		}), long_2, bool_1);
	}

	public List<int> method_68(byte[] byte_0, long long_1 = 0L, bool bool_0 = true)
	{
		List<int> list = new List<int>();
		checked
		{
			int num = (int)long_1;
			int num2 = (int)(method_4() - 1L);
			for (int i = num; i <= num2 && i + byte_0.Length <= method_4() - 1L; i++)
			{
				method_1(i);
				byte[] array = method_22(byte_0.Length);
				if (GClass4.smethod_2(byte_0, array) || GClass4.smethod_2(byte_0, GClass4.smethod_3(array)))
				{
					list.Add(i);
					if (bool_0)
					{
						return list;
					}
				}
			}
			return list;
		}
	}

	public void method_69()
	{
		smethod_2();
		if (!smethod_3() && genum3_0 != (GEnum3)1)
		{
			genum3_0 = (GEnum3)1;
		}
		else
		{
			genum3_0 = (GEnum3)2;
		}
	}

	public void method_70()
	{
		smethod_67(object_0);
	}

	public void method_71()
	{
		_ = 1;
		int num;
		if (!smethod_3())
		{
			num = 2;
			if (smethod_3())
			{
				goto IL_0065;
			}
		}
		else
		{
			num = 3;
			if (!smethod_2())
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			default:
				num = 4;
				if (smethod_2())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				smethod_68(this);
				goto case 1;
			case 1:
			case 3:
				smethod_69(object_1);
				break;
			case 4:
				break;
			case 5:
				return;
			}
			break;
		}
		goto IL_0065;
		IL_0065:
		smethod_70(object_0);
	}

	internal static void smethod_0(object object_2)
	{
		object_2._002Ector();
	}

	internal static void smethod_1(object object_2, long long_1)
	{
		((GClass1)object_2).method_1(long_1);
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
		((GClass1)object_2).method_3(long_1, seekOrigin_0);
	}

	internal static object smethod_7(object object_2)
	{
		return ((BinaryReader)object_2).BaseStream;
	}

	internal static long smethod_8(object object_2, long long_1, SeekOrigin seekOrigin_0)
	{
		return ((Stream)object_2).Seek(long_1, seekOrigin_0);
	}

	internal static long smethod_9(object object_2)
	{
		return ((Stream)object_2).Length;
	}

	internal static int smethod_10(object object_2)
	{
		return ((BinaryReader)object_2).Read();
	}

	internal static int smethod_11(object object_2, object object_3, int int_0, int int_1)
	{
		return ((GClass1)object_2).method_7((char[])object_3, int_0, int_1);
	}

	internal static int smethod_12(object object_2, object object_3, int int_0, int int_1)
	{
		return ((BinaryReader)object_2).Read((char[])object_3, int_0, int_1);
	}

	internal static int smethod_13(object object_2, object object_3, int int_0, int int_1)
	{
		return ((GClass1)object_2).method_9((byte[])object_3, int_0, int_1);
	}

	internal static int smethod_14(object object_2, object object_3, int int_0, int int_1)
	{
		return ((BinaryReader)object_2).Read((byte[])object_3, int_0, int_1);
	}

	internal static bool smethod_15(object object_2)
	{
		return ((BinaryReader)object_2).ReadBoolean();
	}

	internal static char smethod_16(object object_2)
	{
		return ((GClass1)object_2).method_59();
	}

	internal static object smethod_17(object object_2, int int_0)
	{
		return ((GClass1)object_2).method_60(int_0);
	}

	internal static byte smethod_18(object object_2)
	{
		return ((GClass1)object_2).method_21();
	}

	internal static object smethod_19(object object_2, int int_0, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_15(int_0, genum3_1);
	}

	internal static object smethod_20(object object_2, int int_0, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_23(int_0, genum3_1);
	}

	internal static object smethod_21(object object_2, int int_0)
	{
		return ((GClass1)object_2).method_61(int_0);
	}

	internal static object smethod_22(object object_2, int int_0, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_18(int_0, genum3_1);
	}

	internal static object smethod_23(object object_2, int int_0, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_63(int_0, genum3_1);
	}

	internal static object smethod_24(object object_2, int int_0, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_20(int_0, genum3_1);
	}

	internal static object smethod_25(object object_2, int int_0, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_65(int_0, genum3_1);
	}

	internal static byte smethod_26(object object_2)
	{
		return ((BinaryReader)object_2).ReadByte();
	}

	internal static object smethod_27(object object_2, int int_0)
	{
		return ((BinaryReader)object_2).ReadBytes(int_0);
	}

	internal static object smethod_28(object object_2)
	{
		return GClass4.smethod_3(object_2);
	}

	internal static object smethod_29(object object_2, int int_0, int int_1, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_25(int_0, int_1, genum3_1);
	}

	internal static void smethod_30(object object_2, int int_0, object object_3, int int_1, int int_2)
	{
		Array.Copy((Array)object_2, int_0, (Array)object_3, int_1, int_2);
	}

	internal static sbyte smethod_31(object object_2)
	{
		return ((BinaryReader)object_2).ReadSByte();
	}

	internal static short smethod_32(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_28(genum3_1);
	}

	internal static short smethod_33(object object_2, int int_0)
	{
		return BitConverter.ToInt16((byte[])object_2, int_0);
	}

	internal static ushort smethod_34(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_30(genum3_1);
	}

	internal static ushort smethod_35(object object_2, int int_0)
	{
		return BitConverter.ToUInt16((byte[])object_2, int_0);
	}

	internal static int smethod_36(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_32(genum3_1);
	}

	internal static int smethod_37(object object_2)
	{
		return GClass3.smethod_12(object_2);
	}

	internal static uint smethod_38(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_34(genum3_1);
	}

	internal static int smethod_39(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_36(genum3_1);
	}

	internal static int smethod_40(object object_2, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_2, int_0);
	}

	internal static uint smethod_41(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_38(genum3_1);
	}

	internal static uint smethod_42(object object_2, int int_0)
	{
		return BitConverter.ToUInt32((byte[])object_2, int_0);
	}

	internal static long smethod_43(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_40(genum3_1);
	}

	internal static long smethod_44(object object_2)
	{
		return GClass3.smethod_16(object_2);
	}

	internal static ulong smethod_45(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_42(genum3_1);
	}

	internal static long smethod_46(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_44(genum3_1);
	}

	internal static long smethod_47(object object_2)
	{
		return GClass3.smethod_18(object_2);
	}

	internal static ulong smethod_48(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_46(genum3_1);
	}

	internal static long smethod_49(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_48(genum3_1);
	}

	internal static long smethod_50(object object_2)
	{
		return GClass3.smethod_20(object_2);
	}

	internal static ulong smethod_51(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_50(genum3_1);
	}

	internal static long smethod_52(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_52(genum3_1);
	}

	internal static long smethod_53(object object_2, int int_0)
	{
		return BitConverter.ToInt64((byte[])object_2, int_0);
	}

	internal static ulong smethod_54(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_54(genum3_1);
	}

	internal static ulong smethod_55(object object_2, int int_0)
	{
		return BitConverter.ToUInt64((byte[])object_2, int_0);
	}

	internal static float smethod_56(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_56(genum3_1);
	}

	internal static float smethod_57(object object_2, int int_0)
	{
		return BitConverter.ToSingle((byte[])object_2, int_0);
	}

	internal static double smethod_58(object object_2, GEnum3 genum3_1)
	{
		return ((GClass1)object_2).method_58(genum3_1);
	}

	internal static double smethod_59(object object_2, int int_0)
	{
		return BitConverter.ToDouble((byte[])object_2, int_0);
	}

	internal static char smethod_60(object object_2)
	{
		return ((BinaryReader)object_2).ReadChar();
	}

	internal static object smethod_61(object object_2, int int_0)
	{
		return ((BinaryReader)object_2).ReadChars(int_0);
	}

	internal static object smethod_62()
	{
		return Encoding.ASCII;
	}

	internal static object smethod_63(object object_2, object object_3)
	{
		return ((Encoding)object_2).GetString((byte[])object_3);
	}

	internal static object smethod_64()
	{
		return Encoding.BigEndianUnicode;
	}

	internal static object smethod_65()
	{
		return Encoding.Unicode;
	}

	internal static object smethod_66(object object_2)
	{
		return GClass3.smethod_9(object_2);
	}

	internal static void smethod_67(object object_2)
	{
		((Stream)object_2).Flush();
	}

	internal static void smethod_68(object object_2)
	{
		((GClass1)object_2).method_70();
	}

	internal static void smethod_69(object object_2)
	{
		((BinaryReader)object_2).Close();
	}

	internal static void smethod_70(object object_2)
	{
		((Stream)object_2).Close();
	}
}
