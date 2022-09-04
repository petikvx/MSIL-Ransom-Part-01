using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class20
{
	internal Type type_0;

	internal object object_0;

	internal bool bool_0;

	public Class20(object object_1, bool bool_1)
		: this(object_1, object_1?.GetType(), bool_1)
	{
	}

	public Class20(object object_1, Type type_1, bool bool_1)
	{
		object obj = (object_0 = object_1);
		Type type = (type_0 = type_1);
		bool flag = (bool_0 = bool_1);
	}

	[SpecialName]
	public bool method_0()
	{
		return bool_0;
	}

	public object method_1()
	{
		return object_0;
	}

	public Type method_2()
	{
		return type_0;
	}

	[SecuritySafeCritical]
	static Class20()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(Stream stream_0, long long_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 24:
				stream_0.Position = long_0;
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_1(RegistryKey registryKey_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 52:
				return registryKey_0.GetValue(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static AssemblyName smethod_2(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 10:
				return assembly_0.GetName();
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_3(ILGenerator ilgenerator_0, Label label_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 28:
				ilgenerator_0.MarkLabel(label_0);
				return;
			}
		}
	}
}
