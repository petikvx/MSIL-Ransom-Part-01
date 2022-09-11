using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ns0;

internal static class Class4
{
	private static readonly Func<object, IntPtr, Class5> func_0 = smethod_3();

	internal static Class5 smethod_0(object object_0, IntPtr intptr_0)
	{
		return func_0(object_0, intptr_0);
	}

	internal static Class5 smethod_1(object object_0, MethodInfo methodInfo_0)
	{
		return smethod_0(object_0, methodInfo_0.MethodHandle.GetFunctionPointer());
	}

	internal static Assembly smethod_2(AppDomain appDomain_0)
	{
		return appDomain_0.Load(Class0.smethod_0(new byte[27]
		{
			81, 118, 98, 2, 23, 90, 88, 19, 104, 25,
			57, 65, 4, 22, 102, 7, 1, 107, 58, 120,
			105, 72, 95, 101, 10, 39, 67
		}));
	}

	private static Func<object, IntPtr, Class5> smethod_3()
	{
		ConstructorInfo constructor = typeof(Class5).GetConstructor(new Type[2]
		{
			typeof(object),
			typeof(IntPtr)
		});
		DynamicMethod dynamicMethod = new DynamicMethod("FastCreateDelegate_" + typeof(Class5).Name, typeof(Class5), new Type[2]
		{
			typeof(object),
			typeof(IntPtr)
		}, typeof(Class4), skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.Emit(OpCodes.Newobj, constructor ?? throw new InvalidOperationException());
		iLGenerator.Emit(OpCodes.Ret);
		return (Func<object, IntPtr, Class5>)dynamicMethod.CreateDelegate(typeof(Func<object, IntPtr, Class5>));
	}
}
