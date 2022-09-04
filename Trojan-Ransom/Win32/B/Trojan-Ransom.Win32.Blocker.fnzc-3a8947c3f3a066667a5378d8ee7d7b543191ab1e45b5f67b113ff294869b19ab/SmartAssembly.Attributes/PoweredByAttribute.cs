using System;
using System.IO;
using System.Reflection.Emit;
using System.Security;
using ns0;

namespace SmartAssembly.Attributes;

public sealed class PoweredByAttribute : Attribute
{
	public PoweredByAttribute(string string_0)
	{
	}

	[SecuritySafeCritical]
	static PoweredByAttribute()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(BinaryWriter binaryWriter_0, ulong ulong_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 29:
				binaryWriter_0.Write(ulong_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Label smethod_1(ILGenerator ilgenerator_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 26:
				return ilgenerator_0.DefineLabel();
			}
		}
	}

	[SecuritySafeCritical]
	internal static LocalBuilder smethod_2(ILGenerator ilgenerator_0, Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 85:
				return ilgenerator_0.DeclareLocal(type_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_3(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 8:
				return type_0.IsByRef;
			case 9:
				return type_0.IsPointer;
			case 10:
				return type_0.IsArray;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_4(ref DateTime dateTime_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 0:
				return dateTime_0.Hour;
			case 1:
				return dateTime_0.Second;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_5(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 125:
				return memoryStream_0.ToArray();
			}
		}
	}
}
