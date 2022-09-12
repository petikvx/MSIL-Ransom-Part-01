using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using DNGVM.Runtime;

internal static class Class63
{
	private delegate RuntimeMethodHandle Delegate4(DynamicMethod dynamicMethod_0);

	private static readonly Delegate4 d828786c;

	private static readonly MethodInfo methodInfo_0;

	private static readonly MethodInfo methodInfo_1;

	private static readonly Hashtable hashtable_0;

	static Class63()
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
		d828786c = (Delegate4)Delegate.CreateDelegate(typeof(Delegate4), typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.Instance | BindingFlags.NonPublic));
	}

	public static IntPtr fcace5b8(Module module_0, ulong ulong_0, uint uint_0, Class68 class68_0, uint uint_1)
	{
		object obj = hashtable_0[ulong_0];
		if (obj != null)
		{
			return d828786c((DynamicMethod)obj).GetFunctionPointer();
		}
		lock (hashtable_0)
		{
			obj = (DynamicMethod)hashtable_0[ulong_0];
			if (obj != null)
			{
				return d828786c((DynamicMethod)obj).GetFunctionPointer();
			}
			obj = ((!smethod_0(class68_0)) ? smethod_1(Class2.smethod_2(module_0), ulong_0, uint_0, class68_0, uint_1) : ecdfdb01(Class2.smethod_2(module_0), ulong_0, uint_0, class68_0, uint_1));
			hashtable_0[ulong_0] = obj;
			return d828786c((DynamicMethod)obj).GetFunctionPointer();
		}
	}

	private static bool smethod_0(Class68 class68_0)
	{
		Type[] array = class68_0.method_0();
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
			return class68_0.method_1().IsByRef;
		}
		return true;
	}

	private static DynamicMethod smethod_1(int int_0, ulong ulong_0, uint uint_0, Class68 class68_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class68_0.method_1(), class68_0.method_0(), Class62.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class68_0.method_0().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(object));
		for (int i = 0; i < class68_0.method_0().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			iLGenerator.Emit(OpCodes.Ldarg, i);
			if (class68_0.method_0()[i].IsValueType)
			{
				iLGenerator.Emit(OpCodes.Box, class68_0.method_0()[i]);
			}
			iLGenerator.Emit(OpCodes.Stelem_Ref);
		}
		iLGenerator.Emit(OpCodes.Call, methodInfo_0);
		if ((object)class68_0.method_1() == typeof(void))
		{
			iLGenerator.Emit(OpCodes.Pop);
		}
		else if (class68_0.method_1().IsValueType)
		{
			iLGenerator.Emit(OpCodes.Unbox_Any, class68_0.method_1());
		}
		else
		{
			iLGenerator.Emit(OpCodes.Castclass, class68_0.method_1());
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}

	private unsafe static DynamicMethod ecdfdb01(int int_0, ulong ulong_0, uint uint_0, Class68 class68_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class68_0.method_1(), class68_0.method_0(), Class62.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class68_0.method_0().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(void*));
		for (int i = 0; i < class68_0.method_0().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			if (class68_0.method_0()[i].IsByRef)
			{
				iLGenerator.Emit(OpCodes.Ldarg, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class68_0.method_0()[i].GetElementType());
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldarga, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class68_0.method_0()[i]);
			}
			LocalBuilder local = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Stloc, local);
			iLGenerator.Emit(OpCodes.Ldloca, local);
			iLGenerator.Emit(OpCodes.Conv_I);
			iLGenerator.Emit(OpCodes.Stelem_I);
		}
		if ((object)class68_0.method_1() != typeof(void))
		{
			LocalBuilder local2 = iLGenerator.DeclareLocal(class68_0.method_1());
			LocalBuilder local3 = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ldloca, local2);
			iLGenerator.Emit(OpCodes.Mkrefany, class68_0.method_1());
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
