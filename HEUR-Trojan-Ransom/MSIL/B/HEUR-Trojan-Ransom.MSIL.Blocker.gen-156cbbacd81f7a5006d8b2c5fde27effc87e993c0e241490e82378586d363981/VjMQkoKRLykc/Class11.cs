using System;
using System.Reflection;
using System.Reflection.Emit;

namespace VjMQkoKRLykc;

internal static class Class11
{
	private static readonly Func<object, IntPtr, Class18> K9VtUsJ0LQtz1Te4r6s8vDuZv7RUWKSvWH0R4Elr59Qj = smethod_3();

	internal static Class18 smethod_0(object object_0, IntPtr intptr_0)
	{
		return K9VtUsJ0LQtz1Te4r6s8vDuZv7RUWKSvWH0R4Elr59Qj(object_0, intptr_0);
	}

	internal static Class18 smethod_1(object object_0, MethodInfo methodInfo_0)
	{
		return smethod_0(object_0, methodInfo_0.MethodHandle.GetFunctionPointer());
	}

	internal static Assembly smethod_2(AppDomain appDomain_0)
	{
		return appDomain_0.Load(Class1.smethod_0(new byte[27]
		{
			22, 141, 120, 13, 80, 89, 127, 5, 49, 102,
			62, 1, 14, 112, 23, 94, 124, 86, 2, 130,
			24, 3, 132, 87, 104, 16, 46
		}));
	}

	private static Func<object, IntPtr, Class18> smethod_3()
	{
		ConstructorInfo constructor = typeof(Class18).GetConstructor(new Type[2]
		{
			typeof(object),
			typeof(IntPtr)
		});
		DynamicMethod dynamicMethod = new DynamicMethod(" " + typeof(Class18).Name, typeof(Class18), new Type[2]
		{
			typeof(object),
			typeof(IntPtr)
		}, typeof(Class11), skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		OpCode newobj = OpCodes.Newobj;
		ConstructorInfo constructorInfo = constructor;
		if (constructorInfo == null)
		{
			throw new InvalidOperationException();
		}
		iLGenerator.Emit(newobj, constructorInfo);
		iLGenerator.Emit(OpCodes.Ret);
		return (Func<object, IntPtr, Class18>)dynamicMethod.CreateDelegate(typeof(Func<object, IntPtr, Class18>));
	}
}
