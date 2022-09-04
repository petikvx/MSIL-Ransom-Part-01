using System;
using System.IO;
using System.Reflection;
using System.Security.Policy;

internal sealed class Class14
{
	static Class14()
	{
		if (DateTime.Now > new DateTime(635043653220361328L))
		{
			throw new Exception();
		}
		Class15.Class16.smethod_7();
		if (Class15.Class16.smethod_1(Class19.smethod_0(697, 718), new DateTime(635043613567509765L), 792, 820))
		{
			throw new Exception();
		}
		if (Class19.smethod_0(368, 263) > new DateTime(635043608442568359L))
		{
			throw new Exception();
		}
		Class10.Class11.Class12.smethod_3();
	}

	internal static Evidence smethod_0(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 92:
				return Class15.smethod_0(assembly_0, 608, 626);
			}
		}
	}

	internal static void smethod_1(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 24:
				Class15.Class16.smethod_2(appDomain_0, resolveEventHandler_0, 541, 595);
				return;
			}
		}
	}

	internal static int smethod_2(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return Class15.smethod_1(stream_0, 313, 348);
			}
		}
	}

	internal static string smethod_3(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 76:
				return Class19.smethod_1(string_0, 898, 1002);
			}
		}
	}

	internal static long smethod_4(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 28:
				return Class15.smethod_2(stream_0, 984, 980);
			}
		}
	}

	internal static int smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 10:
				return Class15.Class16.Class17.smethod_0(stream_0, byte_0, int_0, int_1, 95, 120);
			case 11:
				return stream_0.Read(byte_0, int_0, int_1);
			}
		}
	}
}
