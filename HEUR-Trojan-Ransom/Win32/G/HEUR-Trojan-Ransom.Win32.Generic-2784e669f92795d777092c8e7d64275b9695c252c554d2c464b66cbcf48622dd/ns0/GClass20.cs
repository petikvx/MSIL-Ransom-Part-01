using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public class GClass20
{
	private static object object_0 = new DESCryptoServiceProvider();

	private static object object_1;

	private static object object_2;

	public GClass20()
	{
		if (smethod_10())
		{
			switch (3)
			{
			case 3:
				smethod_7(this);
				_ = 1;
				if (!smethod_11())
				{
					break;
				}
				goto IL_004c;
			case 1:
			case 4:
				break;
			default:
				goto IL_004c;
			case 5:
				return;
			}
		}
		smethod_8(object_0);
		goto IL_004c;
		IL_004c:
		smethod_9(object_0);
	}

	public GClass20(byte[] byte_0)
	{
		_ = 1;
		if (!smethod_11())
		{
			smethod_7(this);
			smethod_12(object_0, byte_0);
		}
		smethod_9(object_0);
	}

	public GClass20(byte[] byte_0, byte[] byte_1)
	{
		int num = 2;
		if (!smethod_11())
		{
		}
		do
		{
			switch (num)
			{
			case 2:
				smethod_7(this);
				smethod_10();
				if (smethod_11())
				{
					goto IL_0020;
				}
				goto case 1;
			case 1:
			case 4:
				smethod_12(object_0, byte_0);
				goto case 6;
			case 6:
				smethod_12(object_0, byte_1);
				goto default;
			default:
				object_1 = smethod_15(object_0, smethod_13(object_0), smethod_14(object_0));
				break;
			case 5:
				break;
			case 7:
				return;
			}
			break;
			IL_0020:
			num = 0;
		}
		while (smethod_10());
		smethod_16(object_0, smethod_13(object_0), smethod_14(object_0));
	}

	public static bool smethod_0(int int_0)
	{
		return smethod_17(object_0, int_0);
	}

	[SpecialName]
	public object method_0()
	{
		return smethod_13(object_0);
	}

	[SpecialName]
	public void method_1(object object_3)
	{
		smethod_12(object_0, (byte[])object_3);
	}

	[SpecialName]
	public object method_2()
	{
		return smethod_18(object_0);
	}

	[SpecialName]
	public void method_3(object object_3)
	{
		smethod_20(object_0, smethod_19(object_3));
	}

	[SpecialName]
	public object method_4()
	{
		return smethod_14(object_0);
	}

	[SpecialName]
	public void method_5(object object_3)
	{
		smethod_21(object_0, (byte[])object_3);
	}

	public static byte[] smethod_1(object object_3)
	{
		return (byte[])smethod_22(object_3, 0L, ((Array)object_3).Length);
	}

	public static byte[] smethod_2(object object_3, int int_0)
	{
		return (byte[])smethod_22(object_3, 0L, int_0);
	}

	public static byte[] smethod_3(object object_3, long long_0, int int_0)
	{
		checked
		{
			byte[] array = new byte[int_0 - 1 + 1];
			for (int num = 0; num == 0; num = 1)
			{
				smethod_23(object_1, object_3, (int)long_0, int_0, array, 0);
			}
			return array;
		}
	}

	public static byte[] smethod_4(object object_3)
	{
		return (byte[])smethod_24(object_3, 0L, ((Array)object_3).Length);
	}

	public static byte[] smethod_5(object object_3, int int_0)
	{
		return (byte[])smethod_24(object_3, 0L, int_0);
	}

	public static byte[] smethod_6(object object_3, long long_0, int int_0)
	{
		checked
		{
			byte[] array = new byte[int_0 - 1 + 1];
			for (int num = 0; num == 0; num = 1)
			{
				smethod_23(object_2, object_3, (int)long_0, int_0, array, 0);
			}
			return array;
		}
	}

	internal static void smethod_7(object object_3)
	{
		object_3._002Ector();
	}

	internal static void smethod_8(object object_3)
	{
		((DESCryptoServiceProvider)object_3).GenerateKey();
	}

	internal static void smethod_9(object object_3)
	{
		((DESCryptoServiceProvider)object_3).GenerateIV();
	}

	internal static bool smethod_10()
	{
		return true;
	}

	internal static bool smethod_11()
	{
		return false;
	}

	internal static void smethod_12(object object_3, object object_4)
	{
		((DES)object_3).Key = (byte[])object_4;
	}

	internal static object smethod_13(object object_3)
	{
		return ((DES)object_3).Key;
	}

	internal static object smethod_14(object object_3)
	{
		return ((SymmetricAlgorithm)object_3).IV;
	}

	internal static object smethod_15(object object_3, object object_4, object object_5)
	{
		return ((DESCryptoServiceProvider)object_3).CreateEncryptor((byte[])object_4, (byte[]?)object_5);
	}

	internal static object smethod_16(object object_3, object object_4, object object_5)
	{
		return ((DESCryptoServiceProvider)object_3).CreateDecryptor((byte[])object_4, (byte[]?)object_5);
	}

	internal static bool smethod_17(object object_3, int int_0)
	{
		return ((SymmetricAlgorithm)object_3).ValidKeySize(int_0);
	}

	internal static int smethod_18(object object_3)
	{
		return ((SymmetricAlgorithm)object_3).KeySize;
	}

	internal static int smethod_19(object object_3)
	{
		return Conversions.ToInteger(object_3);
	}

	internal static void smethod_20(object object_3, int int_0)
	{
		((SymmetricAlgorithm)object_3).KeySize = int_0;
	}

	internal static void smethod_21(object object_3, object object_4)
	{
		((SymmetricAlgorithm)object_3).IV = (byte[])object_4;
	}

	internal static object smethod_22(object object_3, long long_0, int int_0)
	{
		return smethod_3(object_3, long_0, int_0);
	}

	internal static int smethod_23(object object_3, object object_4, int int_0, int int_1, object object_5, int int_2)
	{
		return ((ICryptoTransform)object_3).TransformBlock((byte[])object_4, int_0, int_1, (byte[])object_5, int_2);
	}

	internal static object smethod_24(object object_3, long long_0, int int_0)
	{
		return smethod_6(object_3, long_0, int_0);
	}
}
