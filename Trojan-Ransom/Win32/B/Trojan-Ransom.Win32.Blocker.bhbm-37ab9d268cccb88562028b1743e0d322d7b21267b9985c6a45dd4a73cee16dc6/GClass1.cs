using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;
using ns5;

public sealed class GClass1 : GClass0
{
	private static bool bool_0;

	internal uint uint_0 = 255u;

	internal bool bool_1 = true;

	internal uint uint_1 = 1024u;

	internal uint uint_2 = 4u;

	internal uint uint_3 = 1048576u;

	internal static Assembly smethod_3(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string text = Exception0.smethod_0(859720300, 0);
		string text2 = text;
		string text3 = Class6.smethod_4(text2, '1', 957, 1011);
		AppDomain appDomain_ = Class1.smethod_5(308, 326);
		Dictionary<string, string> dictionary = (Dictionary<string, string>)Exception1.smethod_1(appDomain_, text3, 854, 880);
		Assembly assembly;
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, string>();
			Exception0.smethod_4(appDomain_, text3, dictionary, 733, 686);
			Assembly assembly_ = Class2.smethod_5(340, 374);
			Stream stream = Exception0.smethod_5(assembly_, text, 632, 516);
			if (stream == null)
			{
				return null;
			}
			byte[] array = new byte[Class1.smethod_6(stream, 702, 716) - 1L];
			int num = GClass2.smethod_0(stream, 786, 839);
			Class1.smethod_2(stream, array, 0, array.Length, 397, 391);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] ^= (byte)((i + num) & 0xFF);
			}
			MemoryStream memoryStream = new MemoryStream();
			using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
			{
				byte[] array2 = new byte[1024];
				int int_;
				while ((int_ = Class1.smethod_2(stream_, array2, 0, array2.Length, 399, 388)) > 0)
				{
					Exception0.smethod_3(memoryStream, array2, 0, int_, 157, 248);
				}
			}
			assembly = Class6.smethod_5(Exception1.smethod_0(memoryStream, 422, 471), null, Exception1.smethod_2(assembly_, 232, 252), 736, 719);
			Class9.smethod_3(appDomain_, text2, assembly, 643, 660);
			string[] array3 = Class9.Class10.Class11.smethod_6(assembly, 496, 413);
			foreach (string text4 in array3)
			{
				dictionary[text4] = text4;
			}
		}
		else
		{
			assembly = (Assembly)Class9.Class10.Class11.smethod_1(appDomain_, text2, 928, 941);
		}
		if (dictionary.ContainsKey(Class7.smethod_6(resolveEventArgs_0, 212, 202)))
		{
			return assembly;
		}
		return null;
	}

	static GClass1()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		smethod_7();
	}

	internal static GCHandle smethod_4(object object_0, GCHandleType gchandleType_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 31:
				return Class9.Class10.smethod_3(object_0, gchandleType_0, 90, 93);
			}
		}
	}

	internal static void smethod_5(ref GCHandle gchandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 4:
				Class9.smethod_11(ref gchandle_0, 548, 545);
				return;
			}
		}
	}

	internal static int smethod_6(string string_0, string string_1, bool bool_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 48:
				return Class9.Class10.Class11.smethod_7(string_0, string_1, bool_2, 94, 18);
			}
		}
	}

	internal static void smethod_7()
	{
		if (bool_0)
		{
			return;
		}
		Type obj;
		Class9.Class10.Class11.smethod_8(obj = Class9.Class10.smethod_4(typeof(GClass1).TypeHandle, 756, 744), 740, 750);
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				Class7.Class8.smethod_12(Class9.Class10.Class11.smethod_0(640, 706), smethod_3, 991, 918);
			}
		}
		finally
		{
			Monitor.Exit(obj);
		}
	}
}
