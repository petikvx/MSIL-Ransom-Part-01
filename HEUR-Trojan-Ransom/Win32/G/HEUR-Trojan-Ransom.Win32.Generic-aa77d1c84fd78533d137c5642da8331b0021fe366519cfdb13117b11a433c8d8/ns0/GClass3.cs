using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public class GClass3
{
	[DebuggerNonUserCode]
	public GClass3()
	{
		smethod_32(this);
	}

	public static string smethod_0(object object_0)
	{
		return (string)smethod_34(smethod_33(), object_0);
	}

	public static byte[] smethod_1(object object_0)
	{
		return (byte[])smethod_37(smethod_33(), object_0);
	}

	public static string smethod_2(object object_0, bool bool_0 = false)
	{
		if (bool_0)
		{
			return (string)smethod_34(smethod_38(), object_0);
		}
		return (string)smethod_34(smethod_39(), object_0);
	}

	public static byte[] smethod_3(object object_0, bool bool_0 = false)
	{
		if (bool_0)
		{
			return (byte[])smethod_37(smethod_38(), object_0);
		}
		return (byte[])smethod_37(smethod_39(), object_0);
	}

	public static string smethod_4(object object_0)
	{
		return (string)smethod_40(object_0);
	}

	public static byte[] smethod_5(object object_0)
	{
		return (byte[])smethod_41(object_0);
	}

	public static string smethod_6(object object_0)
	{
		return (string)smethod_43(smethod_42(object_0));
	}

	public static string smethod_7(object object_0)
	{
		return (string)smethod_45(smethod_44(object_0));
	}

	public static byte[] smethod_8(object object_0)
	{
		checked
		{
			while (smethod_46(object_0))
			{
				byte[] array = new byte[(int)smethod_48((double)smethod_47(object_0) / 2.0 - 1.0) + 1];
				while (true)
				{
					int num = (int)smethod_48((double)smethod_47(object_0) / 2.0 - 1.0);
					int num2 = 0;
					smethod_36();
					if (!smethod_35())
					{
						int num3 = 0;
						if (!smethod_36())
						{
							while (true)
							{
								switch (num3)
								{
								case 7:
									break;
								default:
									num3 = 1;
									if (smethod_35())
									{
										continue;
									}
									goto IL_00ec;
								case 6:
									goto end_IL_002f;
								case 4:
									goto end_IL_00a5;
								case 1:
									goto IL_00e8;
								case 0:
								case 2:
								case 3:
								case 5:
									goto IL_00ec;
								case 8:
									goto IL_00f0;
								}
								break;
							}
							continue;
						}
					}
					goto IL_00ec;
					IL_00f0:
					return array;
					IL_00e8:
					num2++;
					goto IL_00ec;
					IL_00ec:
					if (num2 <= num)
					{
						array[num2] = (byte)smethod_48(smethod_51(smethod_50("&h", smethod_49(object_0, num2 * 2, 2))));
						goto IL_00e8;
					}
					goto IL_00f0;
					continue;
					end_IL_002f:
					break;
				}
				continue;
				end_IL_00a5:
				break;
			}
			throw new Exception("Invalid hex input");
		}
	}

	public static string smethod_9(object object_0)
	{
		string object_ = object_0.GetType().ToString();
		if (smethod_52(object_, "System.Byte[]", bool_0: false) == 0)
		{
			return (string)smethod_54(smethod_53((byte[])object_0), "-", "");
		}
		return (string)smethod_56(smethod_55(object_0));
	}

	public static short smethod_10(object object_0, bool bool_0 = false)
	{
		if (bool_0)
		{
			object_0 = smethod_57(object_0);
		}
		return smethod_58(object_0, 0);
	}

	public static byte[] smethod_11(short short_0, bool bool_0 = false)
	{
		byte[] array = (byte[])smethod_59(short_0);
		_ = 1;
		if (smethod_36() || bool_0)
		{
			array = (byte[])smethod_57(array);
		}
		return array;
	}

	public static int smethod_12(object object_0)
	{
		return (byte)(((byte[])object_0)[2] << 0) | (byte)(((byte[])object_0)[1] << 0) | ((byte[])object_0)[0];
	}

	public static byte[] smethod_13(int int_0)
	{
		int num = 5;
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		if (!smethod_36())
		{
			while (true)
			{
				switch (num)
				{
				case 5:
					array2 = (byte[])smethod_60(int_0);
					_ = 1;
					if (!smethod_36())
					{
						num = 3;
						if (smethod_36())
						{
						}
						continue;
					}
					break;
				default:
					num = 4;
					if (smethod_35())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					array = new byte[3];
					break;
				case 2:
				case 6:
					break;
				case 4:
					goto IL_0071;
				case 0:
					goto IL_0077;
				case 7:
					goto IL_007d;
				}
				break;
			}
		}
		array[0] = array2[0];
		goto IL_0071;
		IL_0077:
		array[2] = array2[2];
		goto IL_007d;
		IL_007d:
		return array;
		IL_0071:
		array[1] = array2[1];
		goto IL_0077;
	}

	public static int smethod_14(object object_0, bool bool_0 = false)
	{
		if (bool_0)
		{
			object_0 = smethod_57(object_0);
		}
		return smethod_61(object_0, 0);
	}

	public static byte[] smethod_15(int int_0, bool bool_0 = false)
	{
		byte[] array = (byte[])smethod_60(int_0);
		_ = 1;
		if (smethod_36() || bool_0)
		{
			array = (byte[])smethod_57(array);
		}
		return array;
	}

	public static long smethod_16(object object_0)
	{
		return (uint)((byte)(((byte[])object_0)[4] << 0) | (byte)(((byte[])object_0)[3] << 0) | (byte)(((byte[])object_0)[2] << 0) | (byte)(((byte[])object_0)[1] << 0) | ((byte[])object_0)[0]);
	}

	public static byte[] smethod_17(long long_0)
	{
		smethod_36();
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		if (smethod_35())
		{
			while (true)
			{
				array = (byte[])smethod_62(long_0);
				if (smethod_35())
				{
					switch (7)
					{
					case 0:
					case 1:
						break;
					case 7:
						goto IL_0050;
					case 2:
					case 4:
						goto end_IL_000d;
					case 3:
						goto IL_0060;
					default:
						goto IL_0066;
					case 8:
						goto IL_006c;
					case 5:
						goto IL_0072;
					case 9:
						goto IL_0078;
					}
					continue;
				}
				goto IL_0050;
				IL_0050:
				array2 = new byte[5];
				break;
				continue;
				end_IL_000d:
				break;
			}
		}
		array2[0] = array[0];
		goto IL_0060;
		IL_006c:
		array2[3] = array[3];
		goto IL_0072;
		IL_0078:
		return array2;
		IL_0072:
		array2[4] = array[4];
		goto IL_0078;
		IL_0066:
		array2[2] = array[2];
		goto IL_006c;
		IL_0060:
		array2[1] = array[1];
		goto IL_0066;
	}

	public static long smethod_18(object object_0)
	{
		return (uint)((byte)(((byte[])object_0)[5] << 0) | (byte)(((byte[])object_0)[4] << 0) | (byte)(((byte[])object_0)[3] << 0) | (byte)(((byte[])object_0)[2] << 0) | (byte)(((byte[])object_0)[1] << 0) | ((byte[])object_0)[0]);
	}

	public static byte[] smethod_19(long long_0)
	{
		while (true)
		{
			byte[] array = (byte[])smethod_62(long_0);
			while (true)
			{
				byte[] array2 = new byte[6];
				while (true)
				{
					array2[0] = array[0];
					while (true)
					{
						array2[1] = array[1];
						_ = 0;
						if (!smethod_35())
						{
							goto IL_0012;
						}
						goto IL_0057;
						IL_0057:
						array2[2] = array[2];
						goto IL_0012;
						IL_0012:
						while (true)
						{
							array2[3] = array[3];
							if (smethod_36())
							{
							}
							switch (9)
							{
							case 8:
								break;
							default:
								continue;
							case 3:
							case 4:
								goto IL_0057;
							case 1:
								goto end_IL_0003;
							case 2:
								goto end_IL_0062;
							case 6:
								goto end_IL_006a;
							case 9:
								array2[4] = array[4];
								goto case 7;
							case 7:
								array2[5] = array[5];
								goto case 10;
							case 10:
								return array2;
							}
							break;
						}
						continue;
						end_IL_0003:
						break;
					}
					continue;
					end_IL_0062:
					break;
				}
				continue;
				end_IL_006a:
				break;
			}
		}
	}

	public static long smethod_20(object object_0)
	{
		return (uint)((byte)(((byte[])object_0)[6] << 0) | (byte)(((byte[])object_0)[5] << 0) | (byte)(((byte[])object_0)[4] << 0) | (byte)(((byte[])object_0)[3] << 0) | (byte)(((byte[])object_0)[2] << 0) | (byte)(((byte[])object_0)[1] << 0) | ((byte[])object_0)[0]);
	}

	public static byte[] smethod_21(long long_0)
	{
		int num = 6;
		if (!smethod_36())
		{
		}
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		do
		{
			switch (num)
			{
			case 1:
			case 8:
				array = new byte[7];
				goto case 2;
			case 2:
			case 3:
				array[0] = array2[0];
				goto IL_001b;
			case 4:
				goto IL_001b;
			case 6:
				array2 = (byte[])smethod_62(long_0);
				_ = 0;
				if (smethod_35())
				{
					goto case 1;
				}
				goto case 2;
			case 5:
				array[2] = array2[2];
				goto default;
			default:
				array[3] = array2[3];
				goto case 7;
			case 7:
				array[4] = array2[4];
				goto case 10;
			case 10:
				array[5] = array2[5];
				goto case 9;
			case 9:
				array[6] = array2[6];
				break;
			case 11:
				break;
			}
			break;
			IL_001b:
			array[1] = array2[1];
			num = 5;
		}
		while (smethod_35());
		return array;
	}

	public static long smethod_22(object object_0, bool bool_0 = false)
	{
		if (bool_0)
		{
			object_0 = smethod_57(object_0);
		}
		return smethod_63(object_0, 0);
	}

	public static byte[] smethod_23(long long_0, bool bool_0 = false)
	{
		smethod_35();
		byte[] array = default(byte[]);
		if (!smethod_36())
		{
			array = (byte[])smethod_62(long_0);
		}
		if (bool_0)
		{
			array = (byte[])smethod_57(array);
		}
		return array;
	}

	public static float smethod_24(object object_0, bool bool_0 = false)
	{
		if (bool_0)
		{
			object_0 = smethod_57(object_0);
		}
		return smethod_64(object_0, 0);
	}

	public static byte[] smethod_25(float float_0, bool bool_0 = false)
	{
		_ = 1;
		byte[] array = default(byte[]);
		if (!smethod_36())
		{
			array = (byte[])smethod_65(float_0);
		}
		if (bool_0)
		{
			array = (byte[])smethod_57(array);
		}
		return array;
	}

	public static double smethod_26(object object_0, bool bool_0 = false)
	{
		if (bool_0)
		{
			object_0 = smethod_57(object_0);
		}
		return smethod_66(object_0, 0);
	}

	public static byte[] smethod_27(double double_0, bool bool_0 = false)
	{
		smethod_35();
		byte[] array = default(byte[]);
		if (!smethod_36())
		{
			while (true)
			{
				array = (byte[])smethod_67(double_0);
				if (smethod_35())
				{
					switch (3)
					{
					case 0:
					case 1:
						break;
					case 3:
						goto IL_0040;
					default:
						goto end_IL_000d;
					case 5:
						goto IL_004d;
					}
					continue;
				}
				goto IL_0040;
				IL_0040:
				if (bool_0)
				{
					break;
				}
				goto IL_004d;
				continue;
				end_IL_000d:
				break;
			}
		}
		array = (byte[])smethod_57(array);
		goto IL_004d;
		IL_004d:
		return array;
	}

	public static Image smethod_28(object object_0)
	{
		return (Image)smethod_68(new MemoryStream((byte[])object_0));
	}

	public static byte[] smethod_29(object object_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		for (int num = 0; num == 0; num = 1)
		{
			smethod_70(object_0, memoryStream, smethod_69(object_0));
		}
		return (byte[])smethod_71(memoryStream);
	}

	public static string smethod_30(int int_0)
	{
		string text = null;
		_ = 1;
		if (!smethod_36())
		{
			goto IL_001c;
		}
		goto IL_0010;
		IL_0010:
		do
		{
			int_0 /= 2;
		}
		while (1 == 0);
		if (int_0 < 1)
		{
			return text;
		}
		goto IL_001c;
		IL_001c:
		text = (string)smethod_50(text, smethod_72(int_0 % 2));
		goto IL_0010;
	}

	public static int smethod_31(object object_0)
	{
		smethod_36();
		if (smethod_35())
		{
			goto IL_0072;
		}
		int num = 3;
		if (smethod_36())
		{
		}
		goto IL_007f;
		IL_005d:
		int num2 = default(int);
		int num3 = default(int);
		ulong num4 = default(ulong);
		if (num2 <= num3)
		{
			num4 = checked((ulong)smethod_48((double)num4 + smethod_51(smethod_74(object_0, smethod_73(object_0) - num2 + 1, 1)) * smethod_75(2.0, num2 - 1)));
			goto IL_001e;
		}
		num = 6;
		if (!smethod_36())
		{
			goto IL_007f;
		}
		goto IL_00a3;
		IL_007f:
		switch (num)
		{
		case 5:
			break;
		default:
			goto IL_005d;
		case 0:
		case 2:
			goto IL_0072;
		case 6:
			goto IL_00a3;
		}
		goto IL_001e;
		IL_0072:
		num3 = checked(smethod_73(object_0) - 1);
		num2 = 0;
		goto IL_005d;
		IL_001e:
		if (true)
		{
			num2 = checked(num2 + 1);
		}
		goto IL_005d;
		IL_00a3:
		return checked((int)num4);
	}

	internal static void smethod_32(object object_0)
	{
		object_0._002Ector();
	}

	internal static object smethod_33()
	{
		return Encoding.ASCII;
	}

	internal static object smethod_34(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static bool smethod_35()
	{
		return true;
	}

	internal static bool smethod_36()
	{
		return false;
	}

	internal static object smethod_37(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetBytes((string)object_1);
	}

	internal static object smethod_38()
	{
		return Encoding.BigEndianUnicode;
	}

	internal static object smethod_39()
	{
		return Encoding.Unicode;
	}

	internal static object smethod_40(object object_0)
	{
		return Convert.ToBase64String((byte[])object_0);
	}

	internal static object smethod_41(object object_0)
	{
		return Convert.FromBase64String((string)object_0);
	}

	internal static object smethod_42(object object_0)
	{
		return smethod_5(object_0);
	}

	internal static object smethod_43(object object_0)
	{
		return smethod_0(object_0);
	}

	internal static object smethod_44(object object_0)
	{
		return smethod_1(object_0);
	}

	internal static object smethod_45(object object_0)
	{
		return smethod_4(object_0);
	}

	internal static bool smethod_46(object object_0)
	{
		return GClass4.smethod_8(object_0);
	}

	internal static int smethod_47(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static double smethod_48(double double_0)
	{
		return Math.Round(double_0);
	}

	internal static object smethod_49(object object_0, int int_0, int int_1)
	{
		return ((string)object_0).Substring(int_0, int_1);
	}

	internal static object smethod_50(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static double smethod_51(object object_0)
	{
		return Conversion.Val((string)object_0);
	}

	internal static int smethod_52(object object_0, object object_1, bool bool_0)
	{
		return Operators.CompareString((string)object_0, (string)object_1, bool_0);
	}

	internal static object smethod_53(object object_0)
	{
		return BitConverter.ToString((byte[])object_0);
	}

	internal static object smethod_54(object object_0, object object_1, object object_2)
	{
		return ((string)object_0).Replace((string)object_1, (string?)object_2);
	}

	internal static object smethod_55(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static object smethod_56(object object_0)
	{
		return Conversion.Hex(object_0);
	}

	internal static object smethod_57(object object_0)
	{
		return GClass4.smethod_3(object_0);
	}

	internal static short smethod_58(object object_0, int int_0)
	{
		return BitConverter.ToInt16((byte[])object_0, int_0);
	}

	internal static object smethod_59(short short_0)
	{
		return BitConverter.GetBytes(short_0);
	}

	internal static object smethod_60(int int_0)
	{
		return BitConverter.GetBytes(int_0);
	}

	internal static int smethod_61(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static object smethod_62(long long_0)
	{
		return BitConverter.GetBytes(long_0);
	}

	internal static long smethod_63(object object_0, int int_0)
	{
		return BitConverter.ToInt64((byte[])object_0, int_0);
	}

	internal static float smethod_64(object object_0, int int_0)
	{
		return BitConverter.ToSingle((byte[])object_0, int_0);
	}

	internal static object smethod_65(float float_0)
	{
		return BitConverter.GetBytes(float_0);
	}

	internal static double smethod_66(object object_0, int int_0)
	{
		return BitConverter.ToDouble((byte[])object_0, int_0);
	}

	internal static object smethod_67(double double_0)
	{
		return BitConverter.GetBytes(double_0);
	}

	internal static object smethod_68(object object_0)
	{
		return Image.FromStream((Stream)object_0);
	}

	internal static object smethod_69(object object_0)
	{
		return ((Image)object_0).get_RawFormat();
	}

	internal static void smethod_70(object object_0, object object_1, object object_2)
	{
		((Image)object_0).Save((Stream)object_1, (ImageFormat)object_2);
	}

	internal static object smethod_71(object object_0)
	{
		return ((MemoryStream)object_0).GetBuffer();
	}

	internal static object smethod_72(int int_0)
	{
		return Conversions.ToString(int_0);
	}

	internal static int smethod_73(object object_0)
	{
		return Strings.Len((string)object_0);
	}

	internal static object smethod_74(object object_0, int int_0, int int_1)
	{
		return Strings.Mid((string)object_0, int_0, int_1);
	}

	internal static double smethod_75(double double_0, double double_1)
	{
		return Math.Pow(double_0, double_1);
	}
}
