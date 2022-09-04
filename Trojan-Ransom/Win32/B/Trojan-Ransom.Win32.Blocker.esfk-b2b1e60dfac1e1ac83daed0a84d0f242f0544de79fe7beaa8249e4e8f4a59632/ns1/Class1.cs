using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace ns1;

internal sealed class Class1 : Computer
{
	[SecuritySafeCritical]
	internal static bool smethod_0(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 31:
				return object.ReferenceEquals(object_0, object_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 103:
				return Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Process smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 90:
				return Process.GetCurrentProcess();
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte smethod_3(string string_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 77:
				return Convert.ToByte(string_0, int_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_4(ILGenerator ilgenerator_0, OpCode opCode_0, MethodInfo methodInfo_0, Type[] type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 93:
				ilgenerator_0.EmitCall(opCode_0, methodInfo_0, type_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_5(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 49:
				return Assembly.Load(byte_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_6(object object_0, Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 110:
				return Conversions.ChangeType(object_0, type_0);
			}
		}
	}
}
