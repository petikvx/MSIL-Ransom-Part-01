using System;
using System.IO;
using System.Reflection;
using System.Security.Policy;

internal sealed class Class9
{
	static Class9()
	{
		if (DateTime.Now > new DateTime(635043905220175781L))
		{
			throw new Exception();
		}
		Class15.Class16.smethod_7();
		if (Class15.Class16.smethod_1(Class19.smethod_0(452, 435), new DateTime(635043793567060546L), 252, 208))
		{
			throw new Exception();
		}
		if (Class15.Class16.smethod_1(Class19.smethod_0(983, 928), new DateTime(635043752442333984L), 823, 795))
		{
			throw new Exception();
		}
		Class10.Class11.Class12.smethod_3();
		Class5.Class6.smethod_6();
	}

	internal static string[] smethod_0(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 45:
				return Class10.Class11.smethod_0(assembly_0, 42, 77);
			}
		}
	}

	internal static int smethod_1(AppDomain appDomain_0, AssemblyName assemblyName_0, Evidence evidence_0, string[] string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 81:
				return Class10.smethod_0(appDomain_0, assemblyName_0, evidence_0, string_0, 798, 779);
			}
		}
	}

	internal static Evidence smethod_2(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 49:
				return Class14.smethod_0(assembly_0, 500, 424);
			}
		}
	}

	internal static object smethod_3(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 22:
				return Class10.smethod_1(appDomain_0, string_0, 656, 720);
			}
		}
	}

	internal static Assembly smethod_4(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 83:
				return Class10.smethod_2(142, 235);
			}
		}
	}

	internal static Stream smethod_5(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 125:
				return Class10.smethod_3(assembly_0, string_0, 77, 112);
			}
		}
	}
}
