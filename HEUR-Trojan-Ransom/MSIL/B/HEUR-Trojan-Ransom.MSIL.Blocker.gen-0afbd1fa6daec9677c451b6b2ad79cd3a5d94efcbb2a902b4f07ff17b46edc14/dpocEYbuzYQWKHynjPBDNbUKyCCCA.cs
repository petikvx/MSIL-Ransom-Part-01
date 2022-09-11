using System;
using System.Reflection;
using System.Reflection.Emit;
using ns0;

internal static class dpocEYbuzYQWKHynjPBDNbUKyCCCA
{
	private static readonly Func<object, IntPtr, Class0> OcCwxuBjOxEiRuessafcDBtFwjXgA = smethod_3();

	internal static Class0 smethod_0(object object_0, IntPtr intptr_0)
	{
		return OcCwxuBjOxEiRuessafcDBtFwjXgA(object_0, intptr_0);
	}

	internal static Class0 smethod_1(object object_0, MethodInfo methodInfo_0)
	{
		return smethod_0(object_0, methodInfo_0.MethodHandle.GetFunctionPointer());
	}

	internal static Assembly smethod_2(AppDomain appDomain_0)
	{
		return appDomain_0.Load(VwKYMaArJBoDiWVSacCTbXWElvXp.smethod_0(new byte[27]
		{
			81, 118, 98, 2, 23, 90, 88, 19, 104, 25,
			57, 65, 4, 22, 102, 7, 1, 107, 58, 120,
			105, 72, 95, 101, 10, 39, 67
		}));
	}

	private static Func<object, IntPtr, Class0> smethod_3()
	{
		ConstructorInfo constructor = typeof(Class0).GetConstructor(new Type[2]
		{
			typeof(object),
			typeof(IntPtr)
		});
		DynamicMethod dynamicMethod = new DynamicMethod("FastCreateDelegate_" + typeof(Class0).Name, typeof(Class0), new Type[2]
		{
			typeof(object),
			typeof(IntPtr)
		}, typeof(dpocEYbuzYQWKHynjPBDNbUKyCCCA), skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.Emit(OpCodes.Newobj, constructor ?? throw new InvalidOperationException());
		iLGenerator.Emit(OpCodes.Ret);
		return (Func<object, IntPtr, Class0>)dynamicMethod.CreateDelegate(typeof(Func<object, IntPtr, Class0>));
	}
}
