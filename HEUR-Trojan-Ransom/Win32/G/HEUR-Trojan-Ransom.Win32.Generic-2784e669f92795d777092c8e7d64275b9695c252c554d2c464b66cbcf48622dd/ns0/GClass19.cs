using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public class GClass19
{
	private static object object_0 = new AesCryptoServiceProvider();

	private static object object_1;

	private static object object_2;

	public GClass19()
	{
		smethod_11();
		if (smethod_10())
		{
			smethod_7(this);
			smethod_8(object_0);
		}
		smethod_9(object_0);
	}

	public GClass19(byte[] byte_0)
	{
		smethod_11();
		if (smethod_10())
		{
			goto IL_0047;
		}
		goto IL_004d;
		IL_004d:
		while (true)
		{
			IL_004d_2:
			smethod_12(object_0, byte_0);
			while (true)
			{
				smethod_9(object_0);
				if (smethod_11())
				{
				}
				switch (5)
				{
				case 0:
				case 3:
					goto end_IL_0012;
				case 1:
				case 2:
					goto IL_004d_2;
				case 5:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			break;
		}
		goto IL_0047;
		IL_0047:
		smethod_7(this);
		goto IL_004d;
	}

	public GClass19(byte[] byte_0, byte[] byte_1)
	{
		smethod_10();
		if (!smethod_11())
		{
			goto IL_0046;
		}
		goto IL_0085;
		IL_0085:
		while (true)
		{
			IL_0085_2:
			smethod_16(object_0, smethod_13(object_0), smethod_14(object_0));
			int num = 7;
			if (smethod_11())
			{
				break;
			}
			while (true)
			{
				switch (num)
				{
				default:
					num = 3;
					if (smethod_10())
					{
						continue;
					}
					break;
				case 0:
				case 1:
					break;
				case 2:
					goto end_IL_0085;
				case 6:
					goto IL_0057;
				case 3:
					goto IL_0062;
				case 4:
				case 5:
					goto IL_0085_2;
				case 7:
					return;
				}
				break;
			}
			goto IL_0046;
			continue;
			end_IL_0085:
			break;
		}
		goto IL_004c;
		IL_0057:
		smethod_12(object_0, byte_1);
		goto IL_0062;
		IL_0062:
		object_1 = smethod_15(object_0, smethod_13(object_0), smethod_14(object_0));
		goto IL_0085;
		IL_0046:
		smethod_7(this);
		goto IL_004c;
		IL_004c:
		smethod_12(object_0, byte_0);
		goto IL_0057;
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
		((AesCryptoServiceProvider)object_3).GenerateKey();
	}

	internal static void smethod_9(object object_3)
	{
		((AesCryptoServiceProvider)object_3).GenerateIV();
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
		((AesCryptoServiceProvider)object_3).Key = (byte[])object_4;
	}

	internal static object smethod_13(object object_3)
	{
		return ((AesCryptoServiceProvider)object_3).Key;
	}

	internal static object smethod_14(object object_3)
	{
		return ((SymmetricAlgorithm)object_3).IV;
	}

	internal static object smethod_15(object object_3, object object_4, object object_5)
	{
		return ((AesCryptoServiceProvider)object_3).CreateEncryptor((byte[])object_4, (byte[]?)object_5);
	}

	internal static object smethod_16(object object_3, object object_4, object object_5)
	{
		return ((AesCryptoServiceProvider)object_3).CreateDecryptor((byte[])object_4, (byte[]?)object_5);
	}

	internal static bool smethod_17(object object_3, int int_0)
	{
		return ((SymmetricAlgorithm)object_3).ValidKeySize(int_0);
	}

	internal static int smethod_18(object object_3)
	{
		return ((AesCryptoServiceProvider)object_3).KeySize;
	}

	internal static int smethod_19(object object_3)
	{
		return Conversions.ToInteger(object_3);
	}

	internal static void smethod_20(object object_3, int int_0)
	{
		((AesCryptoServiceProvider)object_3).KeySize = int_0;
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
