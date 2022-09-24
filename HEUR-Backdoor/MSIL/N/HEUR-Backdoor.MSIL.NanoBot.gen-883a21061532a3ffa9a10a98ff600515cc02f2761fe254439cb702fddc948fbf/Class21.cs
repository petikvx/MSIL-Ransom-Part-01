using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

internal static class Class21
{
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
			array[3] = 198135302;
			array[1] = -482054035;
			array[2] = -858733526;
			array[0] = 114870245;
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
				array[1] = -482054035;
				array[0] = 114870245;
				array[2] = -858733526;
				array[3] = 198135302;
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

	private sealed class Class23
	{
		internal static int smethod_0()
		{
			return Class27.smethod_2(Class27.smethod_0(Class25.smethod_0() ^ 0x1F74F46E, smethod_3(typeof(Class29))), Class27.smethod_1(smethod_3(typeof(Class26)) ^ smethod_3(typeof(Class24)), -2088425620));
		}
	}

	private sealed class Class24
	{
		internal static int smethod_0()
		{
			return Class27.smethod_0(smethod_3(typeof(Class24)), Class27.smethod_2(Class27.smethod_1(smethod_3(typeof(Class28)), smethod_3(typeof(Class26))), Class27.smethod_2(smethod_3(typeof(Class23)) ^ -539463358, Class28.smethod_0())));
		}
	}

	private sealed class Class25
	{
		internal static int smethod_0()
		{
			return Class27.smethod_0(smethod_3(typeof(Class23)), smethod_3(typeof(Class29)) ^ Class27.smethod_1(smethod_3(typeof(Class25)), Class27.smethod_2(smethod_3(typeof(Class24)), Class29.smethod_0())));
		}
	}

	private sealed class Class26
	{
		internal static int smethod_0()
		{
			return Class27.smethod_2(Class27.smethod_1(smethod_3(typeof(Class25)), Class27.smethod_2(smethod_3(typeof(Class26)), smethod_3(typeof(Class28)))), Class24.smethod_0());
		}
	}

	private static class Class27
	{
		internal static int smethod_0(int int_0, int int_1)
		{
			return int_0 ^ (int_1 - 637517906);
		}

		internal static int smethod_1(int int_0, int int_1)
		{
			return (int_0 - -578218795) ^ (int_1 + 382671045);
		}

		internal static int smethod_2(int int_0, int int_1)
		{
			return int_0 ^ ((int_1 - 1960549205) ^ (int_0 - int_1));
		}
	}

	private sealed class Class28
	{
		internal static int smethod_0()
		{
			return Class27.smethod_1(Class27.smethod_1(Class23.smethod_0(), Class27.smethod_0(smethod_3(typeof(Class28)), Class25.smethod_0())), smethod_3(typeof(Class24)));
		}
	}

	private sealed class Class29
	{
		internal static int smethod_0()
		{
			return Class27.smethod_2(smethod_3(typeof(Class29)), Class27.smethod_0(smethod_3(typeof(Class26)), Class27.smethod_1(smethod_3(typeof(Class25)), Class27.smethod_2(smethod_3(typeof(Class23)), Class27.smethod_0(smethod_3(typeof(Class28)), smethod_3(typeof(Class24)))))));
		}
	}

	private static Class22 class22_0 = new Class22();

	internal static long smethod_0()
	{
		if ((object)Assembly.GetCallingAssembly() == typeof(Class21).Assembly && smethod_1())
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
					int num2 = smethod_3(typeof(Class21));
					int num3 = Class26.smethod_0();
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
					num ^= -347319780578461615L;
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
		if ((object)type.Assembly != typeof(Class21).Assembly)
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
