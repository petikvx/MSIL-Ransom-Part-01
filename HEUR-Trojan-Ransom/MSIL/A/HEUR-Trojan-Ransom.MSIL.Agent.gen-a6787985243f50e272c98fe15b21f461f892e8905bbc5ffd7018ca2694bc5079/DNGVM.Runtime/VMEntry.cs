using System;
using System.Reflection;

namespace DNGVM.Runtime;

public class VMEntry
{
	public static object Run(RuntimeTypeHandle runtimeTypeHandle_0, uint uint_0, object[] object_0)
	{
		Module module = Type.GetTypeFromHandle(runtimeTypeHandle_0).Module;
		return c184d4f4.c8dafbc3(module).method_2(uint_0, object_0);
	}

	public unsafe static void Run(RuntimeTypeHandle runtimeTypeHandle_0, uint uint_0, void*[] pVoid_0, void* pVoid_1)
	{
		Module module = Type.GetTypeFromHandle(runtimeTypeHandle_0).Module;
		c184d4f4.c8dafbc3(module).method_4(uint_0, pVoid_0, pVoid_1);
	}

	internal static object RunInternal(int int_0, ulong ulong_0, uint uint_0, uint uint_1, object[] object_0)
	{
		return c184d4f4.c8dafbc3(int_0).method_3(ulong_0, uint_0, uint_1, object_0);
	}

	internal unsafe static void RunInternal(int int_0, ulong ulong_0, uint uint_0, uint uint_1, void*[] pVoid_0, void* pVoid_1)
	{
		c184d4f4.c8dafbc3(int_0).method_5(ulong_0, uint_0, uint_1, pVoid_0, pVoid_1);
	}
}
