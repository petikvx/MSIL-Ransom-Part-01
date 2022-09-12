using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

internal static class Class14
{
	private sealed class Class15
	{
		internal static int smethod_0()
		{
			return Class16.smethod_1(Class16.smethod_1(Class18.smethod_0(), Class16.smethod_0(smethod_3(typeof(Class15)), Class19.smethod_0())), smethod_3(typeof(Class21)));
		}
	}

	private static class Class16
	{
		internal static int smethod_0(int int_0, int int_1)
		{
			return int_0 ^ (int_1 - -1914223988);
		}

		internal static int smethod_1(int int_0, int int_1)
		{
			return (int_0 - 538482151) ^ (int_1 + -2096874931);
		}

		internal static int smethod_2(int int_0, int int_1)
		{
			return int_0 ^ ((int_1 - 187306936) ^ (int_0 - int_1));
		}
	}

	private sealed class Class17
	{
		internal static int smethod_0()
		{
			return Class16.smethod_2(smethod_3(typeof(Class17)), Class16.smethod_0(smethod_3(typeof(Class20)), Class16.smethod_1(smethod_3(typeof(Class19)), Class16.smethod_2(smethod_3(typeof(Class18)), Class16.smethod_0(smethod_3(typeof(Class15)), smethod_3(typeof(Class21)))))));
		}
	}

	private sealed class Class18
	{
		internal static int smethod_0()
		{
			return Class16.smethod_2(Class16.smethod_0(Class19.smethod_0() ^ 0x1F74F46E, smethod_3(typeof(Class17))), Class16.smethod_1(smethod_3(typeof(Class20)) ^ smethod_3(typeof(Class21)), -1746189508));
		}
	}

	private sealed class Class19
	{
		internal static int smethod_0()
		{
			return Class16.smethod_0(smethod_3(typeof(Class18)), smethod_3(typeof(Class17)) ^ Class16.smethod_1(smethod_3(typeof(Class19)), Class16.smethod_2(smethod_3(typeof(Class21)), Class17.smethod_0())));
		}
	}

	private sealed class Class20
	{
		internal static int smethod_0()
		{
			return Class16.smethod_2(Class16.smethod_1(smethod_3(typeof(Class19)), Class16.smethod_2(smethod_3(typeof(Class20)), smethod_3(typeof(Class15)))), Class21.smethod_0());
		}
	}

	private sealed class Class21
	{
		internal static int smethod_0()
		{
			return Class16.smethod_0(smethod_3(typeof(Class21)), Class16.smethod_2(Class16.smethod_1(smethod_3(typeof(Class15)), smethod_3(typeof(Class20))), Class16.smethod_2(smethod_3(typeof(Class18)) ^ 0x15DEA485, Class15.smethod_0())));
		}
	}

	private sealed class Class22
	{
		private int int_0;

		private int int_1;

		internal Class22()
		{
			method_1(0L);
		}

		internal long method_0()
		{
			if ((object)Assembly.GetCallingAssembly() != typeof(Class22).Assembly)
			{
				return 2918384L;
			}
			if (!smethod_1())
			{
				return 2918384L;
			}
			int[] array = new int[4];
			array[3] = 870210558;
			array[1] = 980180348;
			array[2] = 1846422689;
			array[0] = -1994166951;
			int num = int_0;
			int num2 = int_1;
			int num3 = -1640531527;
			int num4 = -957401312;
			for (int i = 0; i != 32; i++)
			{
				num2 -= (((num << 4) ^ (num >> 5)) + num) ^ (num4 + array[(num4 >> 11) & 3]);
				num4 -= num3;
				num -= (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[num4 & 3]);
			}
			for (int j = 0; j != 4; j++)
			{
				array[j] = 0;
			}
			ulong num5 = (ulong)((long)num2 << 32);
			return (long)(num5 | (uint)num);
		}

		internal void method_1(long long_0)
		{
			if ((object)Assembly.GetCallingAssembly() == typeof(Class22).Assembly && smethod_1())
			{
				int[] array = new int[4];
				array[1] = 980180348;
				array[0] = -1994166951;
				array[2] = 1846422689;
				array[3] = 870210558;
				int num = -1640531527;
				int num2 = (int)long_0;
				int num3 = (int)(long_0 >> 32);
				int num4 = 0;
				for (int i = 0; i != 32; i++)
				{
					num2 += (((num3 << 4) ^ (num3 >> 5)) + num3) ^ (num4 + array[num4 & 3]);
					num4 += num;
					num3 += (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[(num4 >> 11) & 3]);
				}
				for (int j = 0; j != 4; j++)
				{
					array[j] = 0;
				}
				int_0 = num2;
				int_1 = num3;
			}
		}
	}

	private static Class22 class22_0 = new Class22();

	internal static long smethod_0()
	{
		if ((object)Assembly.GetCallingAssembly() == typeof(Class14).Assembly && smethod_1())
		{
			lock (class22_0)
			{
				long num = class22_0.method_0();
				if (num == 0L)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					List<byte> list = new List<byte>();
					AssemblyName assemblyName;
					try
					{
						assemblyName = executingAssembly.GetName();
					}
					catch
					{
						assemblyName = new AssemblyName(executingAssembly.FullName);
					}
					byte[] array = assemblyName.GetPublicKeyToken();
					if (array != null && array.Length == 0)
					{
						array = null;
					}
					if (array != null)
					{
						list.AddRange(array);
					}
					list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
					int num2 = smethod_3(typeof(Class14));
					int num3 = Class20.smethod_0();
					list.Add((byte)(num2 >> 16));
					list.Add((byte)(num3 >> 8));
					list.Add((byte)(num2 >> 8));
					list.Add((byte)(num3 >> 24));
					list.Add((byte)num2);
					list.Add((byte)(num3 >> 16));
					list.Add((byte)(num2 >> 24));
					list.Add((byte)num3);
					int count = list.Count;
					ulong num4 = 0uL;
					for (int i = 0; i != count; i++)
					{
						num4 += list[i];
						num4 += num4 << 20;
						num4 ^= num4 >> 12;
						list[i] = 0;
					}
					num4 += num4 << 6;
					num4 ^= num4 >> 22;
					num4 += num4 << 30;
					num = (long)num4;
					num ^= 0x5FACC6005BD0A106L;
					class22_0.method_1(num);
				}
				return num;
			}
		}
		return 0L;
	}

	private static bool smethod_1()
	{
		if (!smethod_2())
		{
			return false;
		}
		return true;
	}

	private static bool smethod_2()
	{
		StackTrace stackTrace = new StackTrace();
		Type type = (stackTrace.GetFrame(3)?.GetMethod())?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			return false;
		}
		if ((object)type == null)
		{
			return false;
		}
		if ((object)type.Assembly != typeof(Class14).Assembly)
		{
			return false;
		}
		return true;
	}

	private static int smethod_3(Type type_0)
	{
		return type_0.MetadataToken;
	}
}
