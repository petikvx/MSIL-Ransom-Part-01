using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using DNGVM.Runtime;

internal static class Class61
{
	private delegate RuntimeMethodHandle Delegate6(DynamicMethod dynamicMethod_0);

	private static readonly Delegate6 delegate6_0;

	private static readonly MethodInfo methodInfo_0;

	private static readonly MethodInfo a348992b;

	private static readonly Hashtable hashtable_0;

	static Class61()
	{
		hashtable_0 = new Hashtable();
		MethodInfo[] methods = typeof(VMEntry).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.ReturnType != typeof(void) && methodInfo.GetParameters().Length > 4)
			{
				methodInfo_0 = methodInfo;
			}
			else
			{
				a348992b = methodInfo;
			}
		}
		delegate6_0 = (Delegate6)Delegate.CreateDelegate(typeof(Delegate6), typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.Instance | BindingFlags.NonPublic));
	}

	public static IntPtr smethod_0(Module module_0, ulong ulong_0, uint uint_0, Class66 class66_0, uint uint_1)
	{
		object obj = hashtable_0[ulong_0];
		if (obj != null)
		{
			return delegate6_0((DynamicMethod)obj).GetFunctionPointer();
		}
		lock (hashtable_0)
		{
			obj = (DynamicMethod)hashtable_0[ulong_0];
			if (obj != null)
			{
				return delegate6_0((DynamicMethod)obj).GetFunctionPointer();
			}
			obj = ((!smethod_1(class66_0)) ? smethod_2(Class1.d214bb26(module_0), ulong_0, uint_0, class66_0, uint_1) : smethod_3(Class1.d214bb26(module_0), ulong_0, uint_0, class66_0, uint_1));
			hashtable_0[ulong_0] = obj;
			return delegate6_0((DynamicMethod)obj).GetFunctionPointer();
		}
	}

	private static bool smethod_1(Class66 class66_0)
	{
		Type[] array = class66_0.method_0();
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				Type type = array[num];
				if (type.IsByRef)
				{
					break;
				}
				num++;
				continue;
			}
			return class66_0.method_1().IsByRef;
		}
		return true;
	}

	private static DynamicMethod smethod_2(int int_0, ulong ulong_0, uint uint_0, Class66 class66_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class66_0.method_1(), class66_0.method_0(), df300be.d69fb105, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class66_0.method_0().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(object));
		for (int i = 0; i < class66_0.method_0().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			iLGenerator.Emit(OpCodes.Ldarg, i);
			if (class66_0.method_0()[i].IsValueType)
			{
				iLGenerator.Emit(OpCodes.Box, class66_0.method_0()[i]);
			}
			iLGenerator.Emit(OpCodes.Stelem_Ref);
		}
		iLGenerator.Emit(OpCodes.Call, methodInfo_0);
		if ((object)class66_0.method_1() == typeof(void))
		{
			iLGenerator.Emit(OpCodes.Pop);
		}
		else if (class66_0.method_1().IsValueType)
		{
			iLGenerator.Emit(OpCodes.Unbox_Any, class66_0.method_1());
		}
		else
		{
			iLGenerator.Emit(OpCodes.Castclass, class66_0.method_1());
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}

	private unsafe static DynamicMethod smethod_3(int int_0, ulong ulong_0, uint uint_0, Class66 class66_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class66_0.method_1(), class66_0.method_0(), df300be.d69fb105, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class66_0.method_0().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(void*));
		for (int i = 0; i < class66_0.method_0().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			if (class66_0.method_0()[i].IsByRef)
			{
				iLGenerator.Emit(OpCodes.Ldarg, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class66_0.method_0()[i].GetElementType());
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldarga, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class66_0.method_0()[i]);
			}
			LocalBuilder local = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Stloc, local);
			iLGenerator.Emit(OpCodes.Ldloca, local);
			iLGenerator.Emit(OpCodes.Conv_I);
			iLGenerator.Emit(OpCodes.Stelem_I);
		}
		if ((object)class66_0.method_1() != typeof(void))
		{
			LocalBuilder local2 = iLGenerator.DeclareLocal(class66_0.method_1());
			LocalBuilder local3 = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ldloca, local2);
			iLGenerator.Emit(OpCodes.Mkrefany, class66_0.method_1());
			iLGenerator.Emit(OpCodes.Stloc, local3);
			iLGenerator.Emit(OpCodes.Ldloca, local3);
			iLGenerator.Emit(OpCodes.Call, a348992b);
			iLGenerator.Emit(OpCodes.Ldloc, local2);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Call, a348992b);
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}
}
