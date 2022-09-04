using System;
using System.IO;
using System.Reflection;
using System.Security.Policy;
using ns0;

public sealed class BabelAttribute : Attribute
{
	public const string Version = "4.0.0.0";

	static BabelAttribute()
	{
		Class5.smethod_7();
	}

	internal static void smethod_0(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 73:
				Class9.Class11.smethod_0(appDomain_0, string_0, object_0, 490, 402);
				return;
			case 74:
				appDomain_0.SetData(string_0, object_0);
				return;
			}
		}
	}

	internal static byte[] smethod_1(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 48:
				return Class12.smethod_0(memoryStream_0, 726, 679);
			}
		}
	}

	internal static Evidence smethod_2(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 63:
				return Class9.smethod_2(assembly_0, 469, 433);
			}
		}
	}
}
