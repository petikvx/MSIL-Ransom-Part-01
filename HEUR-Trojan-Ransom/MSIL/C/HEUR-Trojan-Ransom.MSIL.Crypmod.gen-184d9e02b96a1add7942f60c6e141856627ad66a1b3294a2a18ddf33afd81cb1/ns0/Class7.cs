using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ns0;

internal static class Class7
{
	private static readonly Func<object, IntPtr, Class10> func_0 = smethod_3();

	internal static Class10 smethod_0(object object_0, IntPtr intptr_0)
	{
		return func_0(object_0, intptr_0);
	}

	internal static Class10 smethod_1(object object_0, MethodInfo methodInfo_0)
	{
		return smethod_0(object_0, methodInfo_0.MethodHandle.GetFunctionPointer());
	}

	internal static Assembly smethod_2(AppDomain appDomain_0)
	{
		return appDomain_0.Load(Class1.smethod_1(new byte[27]
		{
			35, 26, 21, 39, 20, 43, 25, 60, 48, 45,
			51, 42, 38, 64, 62, 53, 7, 30, 49, 37,
			8, 23, 17, 33, 22, 36, 2
		}));
	}

	private static Func<object, IntPtr, Class10> smethod_3()
	{
		ConstructorInfo constructor = typeof(Class10).GetConstructor(new Type[2]
		{
			typeof(object),
			typeof(IntPtr)
		});
		DynamicMethod dynamicMethod = new DynamicMethod(" " + typeof(Class10).Name, typeof(Class10), new Type[2]
		{
			typeof(object),
			typeof(IntPtr)
		}, typeof(Class7), skipVisibility: true);
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
		return (Func<object, IntPtr, Class10>)dynamicMethod.CreateDelegate(typeof(Func<object, IntPtr, Class10>));
	}
}
