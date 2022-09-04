using System;
using System.IO;
using System.Reflection;
using System.Security.Policy;
using ns2;
using ns3;
using ns5;

namespace ns4;

internal sealed class Exception1 : ApplicationException
{
	public Exception1()
		: base(Exception0.smethod_0(859720275, 0))
	{
	}

	static Exception1()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
	}

	internal static byte[] smethod_0(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 112:
				return Class9.smethod_1(memoryStream_0, 601, 618);
			case 113:
				return Class9.smethod_1(memoryStream_0, 14, 61);
			}
		}
	}

	internal static object smethod_1(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 38:
				return Class9.Class10.Class11.smethod_1(appDomain_0, string_0, 416, 429);
			}
		}
	}

	internal static Evidence smethod_2(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 20:
				return Class9.smethod_2(assembly_0, 513, 602);
			}
		}
	}
}
