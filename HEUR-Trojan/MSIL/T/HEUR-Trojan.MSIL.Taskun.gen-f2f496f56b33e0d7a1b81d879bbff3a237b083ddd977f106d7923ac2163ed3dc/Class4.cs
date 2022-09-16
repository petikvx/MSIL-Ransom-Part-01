using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

internal static class Class4
{
	private sealed class Class5
	{
		private int int_0;

		private int int_1;

		internal Class5()
		{
			method_1(0L);
		}

		internal long method_0()
		{
			if ((object)Assembly.GetCallingAssembly() != typeof(Class5).Assembly)
			{
				return 2918384L;
			}
			if (!smethod_1())
			{
				return 2918384L;
			}
			int[] array = new int[4];
			array[3] = -1200793392;
			array[1] = 1779381100;
			array[2] = -201807314;
			array[0] = 1941191542;
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
			if ((object)Assembly.GetCallingAssembly() == typeof(Class5).Assembly && smethod_1())
			{
				int[] array = new int[4];
				array[1] = 1779381100;
				array[0] = 1941191542;
				array[2] = -201807314;
				array[3] = -1200793392;
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

	private sealed class Class6
	{
		internal static int smethod_0()
		{
			return Class7.smethod_0(smethod_3(typeof(Class6)), Class7.smethod_2(Class7.smethod_1(smethod_3(typeof(Class12)), smethod_3(typeof(Class8))), Class7.smethod_2(smethod_3(typeof(Class10)) ^ 0x536D037A, Class12.smethod_0())));
		}
	}

	private static class Class7
	{
		internal static int smethod_0(int int_0, int int_1)
		{
			return int_0 ^ (int_1 - 731710887);
		}

		internal static int smethod_1(int int_0, int int_1)
		{
			return (int_0 - 1765837789) ^ (int_1 + 1170618246);
		}

		internal static int smethod_2(int int_0, int int_1)
		{
			return int_0 ^ ((int_1 - -1710303190) ^ (int_0 - int_1));
		}
	}

	private sealed class Class8
	{
		internal static int smethod_0()
		{
			return Class7.smethod_2(Class7.smethod_1(smethod_3(typeof(Class9)), Class7.smethod_2(smethod_3(typeof(Class8)), smethod_3(typeof(Class12)))), Class6.smethod_0());
		}
	}

	private sealed class Class9
	{
		internal static int smethod_0()
		{
			return Class7.smethod_0(smethod_3(typeof(Class10)), smethod_3(typeof(Class11)) ^ Class7.smethod_1(smethod_3(typeof(Class9)), Class7.smethod_2(smethod_3(typeof(Class6)), Class11.smethod_0())));
		}
	}

	private sealed class Class10
	{
		internal static int smethod_0()
		{
			return Class7.smethod_2(Class7.smethod_0(Class9.smethod_0() ^ 0x1F74F46E, smethod_3(typeof(Class11))), Class7.smethod_1(smethod_3(typeof(Class8)) ^ smethod_3(typeof(Class6)), -1123051852));
		}
	}

	private sealed class Class11
	{
		internal static int smethod_0()
		{
			return Class7.smethod_2(smethod_3(typeof(Class11)), Class7.smethod_0(smethod_3(typeof(Class8)), Class7.smethod_1(smethod_3(typeof(Class9)), Class7.smethod_2(smethod_3(typeof(Class10)), Class7.smethod_0(smethod_3(typeof(Class12)), smethod_3(typeof(Class6)))))));
		}
	}

	private sealed class Class12
	{
		internal static int smethod_0()
		{
			return Class7.smethod_1(Class7.smethod_1(Class10.smethod_0(), Class7.smethod_0(smethod_3(typeof(Class12)), Class9.smethod_0())), smethod_3(typeof(Class6)));
		}
	}

	private static Class5 class5_0 = new Class5();

	internal static long smethod_0()
	{
		if ((object)Assembly.GetCallingAssembly() == typeof(Class4).Assembly && smethod_1())
		{
			lock (class5_0)
			{
				long num = class5_0.method_0();
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
					int num2 = smethod_3(typeof(Class4));
					int num3 = Class8.smethod_0();
					list.Add((byte)(num2 >> 16));
					list.Add((byte)(num3 >> 24));
					list.Add((byte)(num2 >> 8));
					list.Add((byte)(num3 >> 16));
					list.Add((byte)num2);
					list.Add((byte)num3);
					list.Add((byte)(num2 >> 24));
					list.Add((byte)(num3 >> 8));
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
					num ^= -2752098460229539513L;
					class5_0.method_1(num);
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
		if ((object)type.Assembly != typeof(Class4).Assembly)
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
