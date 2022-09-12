using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using DNGVM.Runtime;

internal static class dcfb16a7
{
	private delegate RuntimeMethodHandle Delegate5(DynamicMethod dynamicMethod_0);

	private static readonly Delegate5 d7fdd7ae;

	private static readonly MethodInfo methodInfo_0;

	private static readonly MethodInfo e7761310;

	private static readonly Hashtable e5964b2f;

	static dcfb16a7()
	{
		e5964b2f = new Hashtable();
		MethodInfo[] methods = typeof(VMEntry).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.ReturnType != typeof(void) && methodInfo.GetParameters().Length > 4)
			{
				methodInfo_0 = methodInfo;
			}
			else
			{
				e7761310 = methodInfo;
			}
		}
		d7fdd7ae = (Delegate5)Delegate.CreateDelegate(typeof(Delegate5), typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.Instance | BindingFlags.NonPublic));
	}

	public static IntPtr b684a3da(Module module_0, ulong ulong_0, uint uint_0, Class71 class71_0, uint uint_1)
	{
		object obj = e5964b2f[ulong_0];
		if (obj != null)
		{
			return d7fdd7ae((DynamicMethod)obj).GetFunctionPointer();
		}
		lock (e5964b2f)
		{
			obj = (DynamicMethod)e5964b2f[ulong_0];
			if (obj != null)
			{
				return d7fdd7ae((DynamicMethod)obj).GetFunctionPointer();
			}
			obj = ((!smethod_0(class71_0)) ? dd72ac1c(Class2.smethod_0(module_0), ulong_0, uint_0, class71_0, uint_1) : fa90d8cb(Class2.smethod_0(module_0), ulong_0, uint_0, class71_0, uint_1));
			e5964b2f[ulong_0] = obj;
			return d7fdd7ae((DynamicMethod)obj).GetFunctionPointer();
		}
	}

	private static bool smethod_0(Class71 class71_0)
	{
		Type[] array = class71_0.d379c4d9();
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
			return class71_0.b73d6864().IsByRef;
		}
		return true;
	}

	private static DynamicMethod dd72ac1c(int int_0, ulong ulong_0, uint uint_0, Class71 class71_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class71_0.b73d6864(), class71_0.d379c4d9(), Class67.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class71_0.d379c4d9().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(object));
		for (int i = 0; i < class71_0.d379c4d9().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			iLGenerator.Emit(OpCodes.Ldarg, i);
			if (class71_0.d379c4d9()[i].IsValueType)
			{
				iLGenerator.Emit(OpCodes.Box, class71_0.d379c4d9()[i]);
			}
			iLGenerator.Emit(OpCodes.Stelem_Ref);
		}
		iLGenerator.Emit(OpCodes.Call, methodInfo_0);
		if ((object)class71_0.b73d6864() == typeof(void))
		{
			iLGenerator.Emit(OpCodes.Pop);
		}
		else if (class71_0.b73d6864().IsValueType)
		{
			iLGenerator.Emit(OpCodes.Unbox_Any, class71_0.b73d6864());
		}
		else
		{
			iLGenerator.Emit(OpCodes.Castclass, class71_0.b73d6864());
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}

	private unsafe static DynamicMethod fa90d8cb(int int_0, ulong ulong_0, uint uint_0, Class71 class71_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class71_0.b73d6864(), class71_0.d379c4d9(), Class67.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class71_0.d379c4d9().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(void*));
		for (int i = 0; i < class71_0.d379c4d9().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			if (class71_0.d379c4d9()[i].IsByRef)
			{
				iLGenerator.Emit(OpCodes.Ldarg, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class71_0.d379c4d9()[i].GetElementType());
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldarga, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class71_0.d379c4d9()[i]);
			}
			LocalBuilder local = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Stloc, local);
			iLGenerator.Emit(OpCodes.Ldloca, local);
			iLGenerator.Emit(OpCodes.Conv_I);
			iLGenerator.Emit(OpCodes.Stelem_I);
		}
		if ((object)class71_0.b73d6864() != typeof(void))
		{
			LocalBuilder local2 = iLGenerator.DeclareLocal(class71_0.b73d6864());
			LocalBuilder local3 = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ldloca, local2);
			iLGenerator.Emit(OpCodes.Mkrefany, class71_0.b73d6864());
			iLGenerator.Emit(OpCodes.Stloc, local3);
			iLGenerator.Emit(OpCodes.Ldloca, local3);
			iLGenerator.Emit(OpCodes.Call, e7761310);
			iLGenerator.Emit(OpCodes.Ldloc, local2);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Call, e7761310);
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}
}
