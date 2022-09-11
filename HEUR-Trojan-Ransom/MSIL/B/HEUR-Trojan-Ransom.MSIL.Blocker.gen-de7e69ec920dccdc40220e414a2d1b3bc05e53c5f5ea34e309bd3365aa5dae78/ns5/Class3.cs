using System;
using System.Reflection;
using ns3;
using ns4;
using ns8;

namespace ns5;

internal sealed class Class3
{
	internal delegate void Delegate0();

	internal sealed class Class4
	{
		internal static Assembly smethod_0(object A_0, ResolveEventArgs A_1)
		{
			return null;
		}
	}

	internal static int i;

	internal static Assembly assembly;

	internal static void smethod_0()
	{
		//Discarded unreachable code: IL_0008, IL_000e, IL_0107, IL_010e, IL_0114, IL_011f, IL_013d, IL_0140, IL_0148, IL_0179, IL_0181, IL_0186, IL_018d, IL_01a8, IL_01ab, IL_01b2, IL_01bb, IL_01c2, IL_01ed, IL_01f7, IL_020b
		int num = 0;
		/*Error near IL_0003: Could not find block for branch target IL_00ed*/;
	}

	private static byte[] smethod_1()
	{
		int num = 0;
		Array array = default(Array);
		do
		{
			if (num == 6)
			{
				goto IL_005b;
			}
			goto IL_0079;
			IL_0079:
			if (num == 5)
			{
				goto IL_004d;
			}
			goto IL_006f;
			IL_006f:
			if (num != 2)
			{
				if (num == 4)
				{
					(array as byte[])[i] = (byte)((array as byte[])[i] - 12 - 5);
					num = 5;
				}
				if (num == 1)
				{
					array = Class1.smethod_0();
					num = 2;
				}
				if (num == 3)
				{
					goto IL_0041;
				}
				goto IL_0083;
			}
			goto IL_005b;
			IL_005b:
			if (smethod_10(i, array as byte[]))
			{
				goto IL_0041;
			}
			num = 7;
			goto IL_0079;
			IL_0083:
			if (num == 0)
			{
				num = 1;
			}
			continue;
			IL_004d:
			smethod_13(ref i);
			num = 6;
			goto IL_006f;
			IL_0041:
			if (!smethod_12(i))
			{
				goto IL_004d;
			}
			num = 4;
			goto IL_0083;
		}
		while (num != 7);
		return (byte[])array;
	}

	internal static char smethod_2()
	{
		int num = 0;
		do
		{
			int num2 = num;
			Class9.byte_0[123] = (byte)((Class9.byte_0[123] + GClass1.byte_0[112]) & 0xDD);
			if (num2 == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return 'o';
	}

	internal static char smethod_3()
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return 'd';
	}

	internal static char smethod_4()
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return 'a';
	}

	internal static char smethod_5()
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return 'L';
	}

	internal static char smethod_6()
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return 'n';
	}

	internal static char smethod_7()
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return 'i';
	}

	internal static char smethod_8()
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return 'a';
	}

	internal static char smethod_9()
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return 'M';
	}

	private static bool smethod_10(int i, byte[] array)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return i < smethod_11(array);
	}

	internal static int smethod_11(byte[] array)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return array.Length;
	}

	private static bool smethod_12(int i)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return i % 4 / 2 == 0;
	}

	private static void smethod_13(ref int i)
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				i++;
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
	}

	static Class3()
	{
	}
}
