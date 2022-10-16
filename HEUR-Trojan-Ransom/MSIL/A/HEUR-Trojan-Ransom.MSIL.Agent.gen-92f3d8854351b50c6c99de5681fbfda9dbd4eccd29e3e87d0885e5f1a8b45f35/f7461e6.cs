using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using DNGVM.Runtime;

internal static class f7461e6
{
	private delegate RuntimeMethodHandle a8ff155(DynamicMethod dynamicMethod_0);

	private static readonly a8ff155 a8ff155_0;

	private static readonly MethodInfo methodInfo_0;

	private static readonly MethodInfo methodInfo_1;

	private static readonly Hashtable hashtable_0;

	static f7461e6()
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
				methodInfo_1 = methodInfo;
			}
		}
		a8ff155_0 = (a8ff155)Delegate.CreateDelegate(typeof(a8ff155), typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.Instance | BindingFlags.NonPublic));
	}

	public static IntPtr f3cf900d(Module module_0, ulong ulong_0, uint uint_0, ff656cf5 ff656cf5_0, uint uint_1)
	{
		object obj = hashtable_0[ulong_0];
		if (obj != null)
		{
			return a8ff155_0((DynamicMethod)obj).GetFunctionPointer();
		}
		lock (hashtable_0)
		{
			obj = (DynamicMethod)hashtable_0[ulong_0];
			if (obj != null)
			{
				return a8ff155_0((DynamicMethod)obj).GetFunctionPointer();
			}
			obj = ((!smethod_0(ff656cf5_0)) ? smethod_1(a49ada94.b477a4e6(module_0), ulong_0, uint_0, ff656cf5_0, uint_1) : cbf1507a(a49ada94.b477a4e6(module_0), ulong_0, uint_0, ff656cf5_0, uint_1));
			hashtable_0[ulong_0] = obj;
			return a8ff155_0((DynamicMethod)obj).GetFunctionPointer();
		}
	}

	private static bool smethod_0(ff656cf5 ff656cf5_0)
	{
		Type[] array = ff656cf5_0.method_0();
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
			return ff656cf5_0.method_1().IsByRef;
		}
		return true;
	}

	private static DynamicMethod smethod_1(int int_0, ulong ulong_0, uint uint_0, ff656cf5 ff656cf5_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", ff656cf5_0.method_1(), ff656cf5_0.method_0(), cf56b27e.bd4237c5, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, ff656cf5_0.method_0().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(object));
		for (int i = 0; i < ff656cf5_0.method_0().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			iLGenerator.Emit(OpCodes.Ldarg, i);
			if (ff656cf5_0.method_0()[i].IsValueType)
			{
				iLGenerator.Emit(OpCodes.Box, ff656cf5_0.method_0()[i]);
			}
			iLGenerator.Emit(OpCodes.Stelem_Ref);
		}
		iLGenerator.Emit(OpCodes.Call, methodInfo_0);
		if ((object)ff656cf5_0.method_1() == typeof(void))
		{
			iLGenerator.Emit(OpCodes.Pop);
		}
		else if (ff656cf5_0.method_1().IsValueType)
		{
			iLGenerator.Emit(OpCodes.Unbox_Any, ff656cf5_0.method_1());
		}
		else
		{
			iLGenerator.Emit(OpCodes.Castclass, ff656cf5_0.method_1());
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}

	private unsafe static DynamicMethod cbf1507a(int int_0, ulong ulong_0, uint uint_0, ff656cf5 ff656cf5_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", ff656cf5_0.method_1(), ff656cf5_0.method_0(), cf56b27e.bd4237c5, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, ff656cf5_0.method_0().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(void*));
		for (int i = 0; i < ff656cf5_0.method_0().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			if (ff656cf5_0.method_0()[i].IsByRef)
			{
				iLGenerator.Emit(OpCodes.Ldarg, i);
				iLGenerator.Emit(OpCodes.Mkrefany, ff656cf5_0.method_0()[i].GetElementType());
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldarga, i);
				iLGenerator.Emit(OpCodes.Mkrefany, ff656cf5_0.method_0()[i]);
			}
			LocalBuilder local = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Stloc, local);
			iLGenerator.Emit(OpCodes.Ldloca, local);
			iLGenerator.Emit(OpCodes.Conv_I);
			iLGenerator.Emit(OpCodes.Stelem_I);
		}
		if ((object)ff656cf5_0.method_1() != typeof(void))
		{
			LocalBuilder local2 = iLGenerator.DeclareLocal(ff656cf5_0.method_1());
			LocalBuilder local3 = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ldloca, local2);
			iLGenerator.Emit(OpCodes.Mkrefany, ff656cf5_0.method_1());
			iLGenerator.Emit(OpCodes.Stloc, local3);
			iLGenerator.Emit(OpCodes.Ldloca, local3);
			iLGenerator.Emit(OpCodes.Call, methodInfo_1);
			iLGenerator.Emit(OpCodes.Ldloc, local2);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Call, methodInfo_1);
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}
}
