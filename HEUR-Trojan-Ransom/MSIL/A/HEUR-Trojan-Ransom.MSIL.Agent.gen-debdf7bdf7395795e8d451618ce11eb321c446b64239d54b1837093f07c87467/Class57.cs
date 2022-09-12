using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using DNGVM.Runtime;

internal static class Class57
{
	private delegate RuntimeMethodHandle Delegate4(DynamicMethod dynamicMethod_0);

	private static readonly Delegate4 delegate4_0;

	private static readonly MethodInfo methodInfo_0;

	private static readonly MethodInfo methodInfo_1;

	private static readonly Hashtable hashtable_0;

	static Class57()
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
		delegate4_0 = (Delegate4)Delegate.CreateDelegate(typeof(Delegate4), typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.Instance | BindingFlags.NonPublic));
	}

	public static IntPtr smethod_0(Module module_0, ulong ulong_0, uint uint_0, Class61 class61_0, uint uint_1)
	{
		object obj = hashtable_0[ulong_0];
		if (obj != null)
		{
			return delegate4_0((DynamicMethod)obj).GetFunctionPointer();
		}
		lock (hashtable_0)
		{
			obj = (DynamicMethod)hashtable_0[ulong_0];
			if (obj != null)
			{
				return delegate4_0((DynamicMethod)obj).GetFunctionPointer();
			}
			obj = ((!smethod_1(class61_0)) ? ccbee618(Class2.b23774b3(module_0), ulong_0, uint_0, class61_0, uint_1) : smethod_2(Class2.b23774b3(module_0), ulong_0, uint_0, class61_0, uint_1));
			hashtable_0[ulong_0] = obj;
			return delegate4_0((DynamicMethod)obj).GetFunctionPointer();
		}
	}

	private static bool smethod_1(Class61 class61_0)
	{
		Type[] array = class61_0.c7148f45();
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
			return class61_0.method_0().IsByRef;
		}
		return true;
	}

	private static DynamicMethod ccbee618(int int_0, ulong ulong_0, uint uint_0, Class61 class61_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class61_0.method_0(), class61_0.c7148f45(), Class56.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class61_0.c7148f45().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(object));
		for (int i = 0; i < class61_0.c7148f45().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			iLGenerator.Emit(OpCodes.Ldarg, i);
			if (class61_0.c7148f45()[i].IsValueType)
			{
				iLGenerator.Emit(OpCodes.Box, class61_0.c7148f45()[i]);
			}
			iLGenerator.Emit(OpCodes.Stelem_Ref);
		}
		iLGenerator.Emit(OpCodes.Call, methodInfo_0);
		if ((object)class61_0.method_0() == typeof(void))
		{
			iLGenerator.Emit(OpCodes.Pop);
		}
		else if (class61_0.method_0().IsValueType)
		{
			iLGenerator.Emit(OpCodes.Unbox_Any, class61_0.method_0());
		}
		else
		{
			iLGenerator.Emit(OpCodes.Castclass, class61_0.method_0());
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}

	private unsafe static DynamicMethod smethod_2(int int_0, ulong ulong_0, uint uint_0, Class61 class61_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class61_0.method_0(), class61_0.c7148f45(), Class56.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class61_0.c7148f45().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(void*));
		for (int i = 0; i < class61_0.c7148f45().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			if (class61_0.c7148f45()[i].IsByRef)
			{
				iLGenerator.Emit(OpCodes.Ldarg, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class61_0.c7148f45()[i].GetElementType());
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldarga, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class61_0.c7148f45()[i]);
			}
			LocalBuilder local = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Stloc, local);
			iLGenerator.Emit(OpCodes.Ldloca, local);
			iLGenerator.Emit(OpCodes.Conv_I);
			iLGenerator.Emit(OpCodes.Stelem_I);
		}
		if ((object)class61_0.method_0() != typeof(void))
		{
			LocalBuilder local2 = iLGenerator.DeclareLocal(class61_0.method_0());
			LocalBuilder local3 = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ldloca, local2);
			iLGenerator.Emit(OpCodes.Mkrefany, class61_0.method_0());
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
