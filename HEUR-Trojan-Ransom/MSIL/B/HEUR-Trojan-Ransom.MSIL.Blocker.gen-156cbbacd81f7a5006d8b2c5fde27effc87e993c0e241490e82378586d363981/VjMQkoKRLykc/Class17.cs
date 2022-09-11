using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace VjMQkoKRLykc;

internal sealed class Class17
{
	private const int iqOhjJDf2M85kXm0XGa5r1f6g4u0yKtfvPHQEZFKP1vO = 2;

	internal long[] long_0;

	internal int int_0;

	internal int int_1;

	internal int int_2;

	internal int Int32_0 => int_0;

	internal long Int64_0 => long_0[int_2];

	internal Class17(int int_3)
	{
		int_0 = 0;
		int_1 = 0;
		long[] array = (long_0 = new long[int_3]);
	}

	internal void method_0(long long_1)
	{
		if (int_1 == long_0.Length)
		{
			method_4();
		}
		long[] array = long_0;
		int num = int_1;
		int num2 = (int_1 = num + 1);
		array[num] = long_1;
		int_0++;
	}

	internal void method_1()
	{
		int_2 = -1;
	}

	internal bool method_2()
	{
		int num;
		do
		{
			num = int_2 + 1;
			int num2 = (int_2 = num);
		}
		while (num < int_1 && long_0[int_2] == -1L);
		return int_2 != int_1;
	}

	internal bool method_3(long long_1)
	{
		int i;
		for (i = 0; i < int_1 && long_0[i] != long_1; i++)
		{
		}
		if (i == int_1)
		{
			return false;
		}
		long_0[i] = -1L;
		return true;
	}

	internal static bool smethod_0(ResolveEventArgs resolveEventArgs_0, out Assembly assembly_0, AppDomain appDomain_0)
	{
		if (resolveEventArgs_0.Name.Contains("Fm"))
		{
			assembly_0 = Class11.smethod_2(appDomain_0);
			return true;
		}
		assembly_0 = null;
		return false;
	}

	private void method_4()
	{
		int num = long_0.Length * 2;
		if (num < 0)
		{
			if (num == int.MaxValue)
			{
				throw new SerializationException("");
			}
			num = int.MaxValue;
		}
		long[] destinationArray = new long[num];
		Array.Copy(long_0, destinationArray, int_0);
		long[] array = (long_0 = destinationArray);
	}
}
