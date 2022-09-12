using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using DNGVM.Runtime;

internal static class aab2ab46
{
	private delegate RuntimeMethodHandle Delegate5(DynamicMethod dynamicMethod_0);

	private static readonly Delegate5 d6264d71;

	private static readonly MethodInfo ef44e81c;

	private static readonly MethodInfo methodInfo_0;

	private static readonly Hashtable hashtable_0;

	static aab2ab46()
	{
		hashtable_0 = new Hashtable();
		MethodInfo[] methods = typeof(VMEntry).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.ReturnType != typeof(void) && methodInfo.GetParameters().Length > 4)
			{
				ef44e81c = methodInfo;
			}
			else
			{
				methodInfo_0 = methodInfo;
			}
		}
		d6264d71 = (Delegate5)Delegate.CreateDelegate(typeof(Delegate5), typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.Instance | BindingFlags.NonPublic));
	}

	public static IntPtr d19589ed(Module module_0, ulong ulong_0, uint uint_0, Class62 class62_0, uint uint_1)
	{
		object obj = hashtable_0[ulong_0];
		if (obj != null)
		{
			return d6264d71((DynamicMethod)obj).GetFunctionPointer();
		}
		lock (hashtable_0)
		{
			obj = (DynamicMethod)hashtable_0[ulong_0];
			if (obj != null)
			{
				return d6264d71((DynamicMethod)obj).GetFunctionPointer();
			}
			obj = ((!ee206268(class62_0)) ? d77162a7(c184d4f4.smethod_0(module_0), ulong_0, uint_0, class62_0, uint_1) : fcce7fda(c184d4f4.smethod_0(module_0), ulong_0, uint_0, class62_0, uint_1));
			hashtable_0[ulong_0] = obj;
			return d6264d71((DynamicMethod)obj).GetFunctionPointer();
		}
	}

	private static bool ee206268(Class62 class62_0)
	{
		Type[] array = class62_0.b05b0630();
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
			return class62_0.method_0().IsByRef;
		}
		return true;
	}

	private static DynamicMethod d77162a7(int int_0, ulong ulong_0, uint uint_0, Class62 class62_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class62_0.method_0(), class62_0.b05b0630(), Class58.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class62_0.b05b0630().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(object));
		for (int i = 0; i < class62_0.b05b0630().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			iLGenerator.Emit(OpCodes.Ldarg, i);
			if (class62_0.b05b0630()[i].IsValueType)
			{
				iLGenerator.Emit(OpCodes.Box, class62_0.b05b0630()[i]);
			}
			iLGenerator.Emit(OpCodes.Stelem_Ref);
		}
		iLGenerator.Emit(OpCodes.Call, ef44e81c);
		if ((object)class62_0.method_0() == typeof(void))
		{
			iLGenerator.Emit(OpCodes.Pop);
		}
		else if (class62_0.method_0().IsValueType)
		{
			iLGenerator.Emit(OpCodes.Unbox_Any, class62_0.method_0());
		}
		else
		{
			iLGenerator.Emit(OpCodes.Castclass, class62_0.method_0());
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}

	private unsafe static DynamicMethod fcce7fda(int int_0, ulong ulong_0, uint uint_0, Class62 class62_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class62_0.method_0(), class62_0.b05b0630(), Class58.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class62_0.b05b0630().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(void*));
		for (int i = 0; i < class62_0.b05b0630().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			if (class62_0.b05b0630()[i].IsByRef)
			{
				iLGenerator.Emit(OpCodes.Ldarg, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class62_0.b05b0630()[i].GetElementType());
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldarga, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class62_0.b05b0630()[i]);
			}
			LocalBuilder local = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Stloc, local);
			iLGenerator.Emit(OpCodes.Ldloca, local);
			iLGenerator.Emit(OpCodes.Conv_I);
			iLGenerator.Emit(OpCodes.Stelem_I);
		}
		if ((object)class62_0.method_0() != typeof(void))
		{
			LocalBuilder local2 = iLGenerator.DeclareLocal(class62_0.method_0());
			LocalBuilder local3 = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ldloca, local2);
			iLGenerator.Emit(OpCodes.Mkrefany, class62_0.method_0());
			iLGenerator.Emit(OpCodes.Stloc, local3);
			iLGenerator.Emit(OpCodes.Ldloca, local3);
			iLGenerator.Emit(OpCodes.Call, methodInfo_0);
			iLGenerator.Emit(OpCodes.Ldloc, local2);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Call, methodInfo_0);
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}
}
