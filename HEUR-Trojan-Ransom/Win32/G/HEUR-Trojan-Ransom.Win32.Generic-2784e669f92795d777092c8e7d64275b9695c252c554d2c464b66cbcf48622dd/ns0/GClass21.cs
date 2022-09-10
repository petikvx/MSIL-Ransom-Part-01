using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public class GClass21
{
	private static object object_0 = new RC2CryptoServiceProvider();

	private static object object_1;

	private static object object_2;

	public GClass21()
	{
		smethod_7(this);
		smethod_10();
		if (!smethod_11())
		{
			smethod_8(object_0);
		}
		smethod_9(object_0);
	}

	public GClass21(byte[] byte_0)
	{
		while (true)
		{
			smethod_7(this);
			smethod_10();
			if (smethod_11())
			{
				break;
			}
			if (!smethod_11())
			{
				switch (0)
				{
				case 3:
					continue;
				case 0:
				case 1:
					smethod_12(object_0, byte_0);
					break;
				case 5:
					return;
				}
				break;
			}
			return;
		}
		smethod_9(object_0);
	}

	public GClass21(byte[] byte_0, byte[] byte_1)
	{
		_ = 1;
		if (!smethod_11())
		{
			goto IL_001b;
		}
		int num = 5;
		if (!smethod_11())
		{
			goto IL_0038;
		}
		goto IL_008d;
		IL_008d:
		smethod_16(object_0, smethod_13(object_0), smethod_14(object_0));
		return;
		IL_0038:
		switch (num)
		{
		case 0:
		case 6:
			break;
		case 1:
			goto IL_0021;
		case 2:
			smethod_12(object_0, byte_1);
			goto default;
		default:
			object_1 = smethod_15(object_0, smethod_13(object_0), smethod_14(object_0));
			goto IL_008d;
		case 4:
			goto IL_008d;
		case 7:
			return;
		}
		goto IL_001b;
		IL_0021:
		smethod_12(object_0, byte_0);
		num = 2;
		if (smethod_11())
		{
			return;
		}
		goto IL_0038;
		IL_001b:
		smethod_7(this);
		goto IL_0021;
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
		((RC2CryptoServiceProvider)object_3).GenerateKey();
	}

	internal static void smethod_9(object object_3)
	{
		((RC2CryptoServiceProvider)object_3).GenerateIV();
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
		((SymmetricAlgorithm)object_3).Key = (byte[])object_4;
	}

	internal static object smethod_13(object object_3)
	{
		return ((SymmetricAlgorithm)object_3).Key;
	}

	internal static object smethod_14(object object_3)
	{
		return ((SymmetricAlgorithm)object_3).IV;
	}

	internal static object smethod_15(object object_3, object object_4, object object_5)
	{
		return ((RC2CryptoServiceProvider)object_3).CreateEncryptor((byte[])object_4, (byte[]?)object_5);
	}

	internal static object smethod_16(object object_3, object object_4, object object_5)
	{
		return ((RC2CryptoServiceProvider)object_3).CreateDecryptor((byte[])object_4, (byte[]?)object_5);
	}

	internal static bool smethod_17(object object_3, int int_0)
	{
		return ((SymmetricAlgorithm)object_3).ValidKeySize(int_0);
	}

	internal static int smethod_18(object object_3)
	{
		return ((RC2)object_3).KeySize;
	}

	internal static int smethod_19(object object_3)
	{
		return Conversions.ToInteger(object_3);
	}

	internal static void smethod_20(object object_3, int int_0)
	{
		((RC2)object_3).KeySize = int_0;
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
