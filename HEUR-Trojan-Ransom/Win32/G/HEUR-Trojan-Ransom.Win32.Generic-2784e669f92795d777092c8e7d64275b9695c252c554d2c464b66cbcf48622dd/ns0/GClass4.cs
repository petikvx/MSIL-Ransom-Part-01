using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public class GClass4
{
	[DebuggerNonUserCode]
	public GClass4()
	{
		smethod_13(this);
	}

	public static byte[] smethod_0(object object_0, int int_0)
	{
		return (byte[])smethod_16(smethod_15(smethod_14(object_0), int_0, 2));
	}

	public static byte[] smethod_1(object object_0, byte byte_0)
	{
		return (byte[])smethod_16(smethod_20(smethod_14(object_0), smethod_19(byte_0), ""));
	}

	public static bool smethod_2(object object_0, object object_1)
	{
		return smethod_21(smethod_14(object_0), smethod_14(object_1), bool_0: false) == 0;
	}

	public static byte[] smethod_3(object object_0)
	{
		return (byte[])smethod_22(object_0);
	}

	public static Array smethod_4(object object_0)
	{
		smethod_23(object_0);
		return (Array)object_0;
	}

	public static object smethod_5(object object_0, int int_0, int int_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		return smethod_25(object_0, int_0, int_1, (object)(GetThumbnailImageAbort)smethod_24(new Delegate[0]), IntPtr.Zero);
	}

	public static int smethod_6(object object_0)
	{
		if (smethod_26(object_0) == 0)
		{
			return 0;
		}
		return smethod_28(smethod_27(), object_0);
	}

	public static int smethod_7(object object_0)
	{
		return checked((int)smethod_29(object_0));
	}

	public static bool smethod_8(object object_0)
	{
		return smethod_30(new Regex("^[A-Fa-f0-9]*$", RegexOptions.IgnoreCase), object_0);
	}

	public static bool smethod_9(object object_0)
	{
		return smethod_26(object_0) == smethod_31(object_0);
	}

	public static bool smethod_10(long long_0)
	{
		return smethod_30(new Regex("^[0-9]+\\d"), long_0.ToString());
	}

	public static string smethod_11(int int_0)
	{
		_ = 1;
		if (!smethod_18())
		{
			while (int_0 >= 1024)
			{
				if (int_0 >= 1024)
				{
					goto IL_0069;
				}
				goto IL_0071;
				IL_0054:
				if (int_0 >= 1073741824)
				{
					goto IL_005c;
				}
				goto IL_00c0;
				IL_0071:
				if (int_0 >= 1048576)
				{
					goto IL_0054;
				}
				goto IL_005c;
				IL_005c:
				if (int_0 >= 1073741824)
				{
					if (smethod_17())
					{
						switch (5)
						{
						case 7:
							goto IL_0069;
						case 0:
						case 3:
							continue;
						case 5:
							if (int_0 < 1099511627776L)
							{
								goto case 9;
							}
							goto IL_012a;
						case 2:
							goto IL_009a;
						case 8:
							goto IL_00c0;
						case 9:
							return (string)smethod_33(smethod_34((double)int_0 / 1024.0 / 1024.0 / 1024.0, "0.00"), " gb");
						case 1:
						case 4:
							goto end_IL_007b;
						}
					}
					goto IL_0054;
				}
				goto IL_012a;
				IL_00c0:
				return (string)smethod_33(smethod_34((double)int_0 / 1024.0 / 1024.0, "0.00"), " mb");
				IL_012a:
				throw new Exception("WTF!");
				IL_0069:
				if (int_0 >= 1048576)
				{
					goto IL_0071;
				}
				goto IL_009a;
				IL_009a:
				return (string)smethod_33(smethod_34((double)int_0 / 1024.0, "0.00"), " kb");
				continue;
				end_IL_007b:
				break;
			}
		}
		return (string)smethod_33(smethod_32(int_0), " b");
	}

	public static string smethod_12(long long_0, long long_1)
	{
		return (string)smethod_33(smethod_34((double)long_0 / (double)long_1, "0.00"), "%");
	}

	internal static void smethod_13(object object_0)
	{
		object_0._002Ector();
	}

	internal static object smethod_14(object object_0)
	{
		return GClass3.smethod_9(object_0);
	}

	internal static object smethod_15(object object_0, int int_0, int int_1)
	{
		return ((string)object_0).Remove(int_0, int_1);
	}

	internal static object smethod_16(object object_0)
	{
		return GClass3.smethod_8(object_0);
	}

	internal static bool smethod_17()
	{
		return true;
	}

	internal static bool smethod_18()
	{
		return false;
	}

	internal static object smethod_19(byte byte_0)
	{
		return Conversions.ToString(byte_0);
	}

	internal static object smethod_20(object object_0, object object_1, object object_2)
	{
		return ((string)object_0).Replace((string)object_1, (string?)object_2);
	}

	internal static int smethod_21(object object_0, object object_1, bool bool_0)
	{
		return Operators.CompareString((string)object_0, (string)object_1, bool_0);
	}

	internal static object smethod_22(object object_0)
	{
		return smethod_4(object_0);
	}

	internal static void smethod_23(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object smethod_24(object object_0)
	{
		return Delegate.Combine((Delegate?[]?)object_0);
	}

	internal static object smethod_25(object object_0, int int_0, int int_1, object object_1, IntPtr intptr_0)
	{
		return ((Image)object_0).GetThumbnailImage(int_0, int_1, (GetThumbnailImageAbort)object_1, intptr_0);
	}

	internal static int smethod_26(object object_0)
	{
		return Strings.Len((string)object_0);
	}

	internal static object smethod_27()
	{
		return Encoding.Unicode;
	}

	internal static int smethod_28(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetByteCount((string)object_1);
	}

	internal static long smethod_29(object object_0)
	{
		return FileSystem.FileLen((string)object_0);
	}

	internal static bool smethod_30(object object_0, object object_1)
	{
		return ((Regex)object_0).IsMatch((string)object_1);
	}

	internal static int smethod_31(object object_0)
	{
		return smethod_6(object_0);
	}

	internal static object smethod_32(int int_0)
	{
		return Conversions.ToString(int_0);
	}

	internal static object smethod_33(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static object smethod_34(object object_0, object object_1)
	{
		return Strings.Format(object_0, (string)object_1);
	}
}
