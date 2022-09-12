using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

internal static class e6aa6259
{
	public delegate object Delegate1(Class54 class54_0, Interface2[] interface2_0, Type[] type_0);

	private static Hashtable hashtable_0;

	private static Hashtable ad4a569d;

	private static Hashtable hashtable_1;

	private static MethodInfo methodInfo_0;

	private static MethodInfo methodInfo_1;

	private static ConstructorInfo constructorInfo_0;

	static e6aa6259()
	{
		hashtable_0 = new Hashtable();
		ad4a569d = new Hashtable();
		hashtable_1 = new Hashtable();
		MethodInfo[] methods = typeof(Interface2).GetMethods();
		foreach (MethodInfo methodInfo in methods)
		{
			ParameterInfo[] parameters = methodInfo.GetParameters();
			foreach (ParameterInfo parameterInfo in parameters)
			{
				if ((object)parameterInfo.ParameterType == typeof(Struct1))
				{
					methodInfo_0 = methodInfo;
					break;
				}
			}
			if ((object)methodInfo_0 != null)
			{
				break;
			}
		}
		MethodInfo[] methods2 = typeof(Class59).GetMethods();
		foreach (MethodInfo methodInfo2 in methods2)
		{
			if ((object)methodInfo2.GetParameters()[0].ParameterType == typeof(Struct1))
			{
				methodInfo_1 = methodInfo2;
				break;
			}
		}
		ConstructorInfo[] constructors = typeof(Class53).GetConstructors();
		foreach (ConstructorInfo constructorInfo in constructors)
		{
			ParameterInfo[] parameters2 = constructorInfo.GetParameters();
			foreach (ParameterInfo parameterInfo2 in parameters2)
			{
				if ((object)parameterInfo2.ParameterType == typeof(TypedReference))
				{
					constructorInfo_0 = constructorInfo;
					break;
				}
			}
			if ((object)constructorInfo_0 != null)
			{
				break;
			}
		}
	}

	public static MethodBase smethod_0(MethodBase methodBase_0)
	{
		MethodBase methodBase = (MethodBase)hashtable_0[methodBase_0];
		if ((object)methodBase != null)
		{
			return methodBase;
		}
		lock (hashtable_0)
		{
			methodBase = (MethodBase)hashtable_0[methodBase_0];
			if ((object)methodBase != null)
			{
				return methodBase;
			}
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			Type[] array = new Type[parameters.Length + ((!methodBase_0.IsStatic) ? 1 : 0)];
			for (int i = 0; i < array.Length; i++)
			{
				if (methodBase_0.IsStatic)
				{
					array[i] = parameters[i].ParameterType;
				}
				else if (i == 0)
				{
					array[0] = methodBase_0.DeclaringType;
				}
				else
				{
					array[i] = parameters[i - 1].ParameterType;
				}
			}
			Type returnType = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
			DynamicMethod dynamicMethod = new DynamicMethod("", returnType, array, df300be.d69fb105, skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			for (int j = 0; j < array.Length; j++)
			{
				if (!methodBase_0.IsStatic && j == 0 && array[0].IsValueType)
				{
					iLGenerator.Emit(OpCodes.Ldarga, j);
				}
				else
				{
					iLGenerator.Emit(OpCodes.Ldarg, j);
				}
			}
			if (methodBase_0 is MethodInfo)
			{
				iLGenerator.Emit(OpCodes.Call, (MethodInfo)methodBase_0);
			}
			else
			{
				iLGenerator.Emit(OpCodes.Call, (ConstructorInfo)methodBase_0);
			}
			iLGenerator.Emit(OpCodes.Ret);
			hashtable_0[methodBase_0] = dynamicMethod;
			return dynamicMethod;
		}
	}

	public static Delegate1 smethod_1(MethodBase methodBase_0, OpCode opCode_0, Type type_0)
	{
		object key;
		Hashtable hashtable;
		if ((object)type_0 == null)
		{
			key = new KeyValuePair<MethodBase, OpCode>(methodBase_0, opCode_0);
			hashtable = ad4a569d;
		}
		else
		{
			key = new KeyValuePair<MethodBase, Type>(methodBase_0, type_0);
			hashtable = hashtable_1;
		}
		Delegate1 @delegate = (Delegate1)hashtable[key];
		if (@delegate != null)
		{
			return @delegate;
		}
		lock (ad4a569d)
		{
			@delegate = (Delegate1)hashtable[key];
			if (@delegate != null)
			{
				return @delegate;
			}
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			Type[] array;
			if (opCode_0 != OpCodes.Newobj)
			{
				array = new Type[parameters.Length + ((!methodBase_0.IsStatic) ? 1 : 0) + 1];
				for (int i = 0; i < array.Length - 1; i++)
				{
					if (methodBase_0.IsStatic)
					{
						array[i] = parameters[i].ParameterType;
					}
					else if (i == 0)
					{
						if ((object)type_0 != null)
						{
							array[0] = type_0.MakeByRefType();
						}
						else if (methodBase_0.DeclaringType!.IsValueType)
						{
							array[0] = methodBase_0.DeclaringType!.MakeByRefType();
						}
						else
						{
							array[0] = methodBase_0.DeclaringType;
						}
					}
					else
					{
						array[i] = parameters[i - 1].ParameterType;
					}
				}
			}
			else
			{
				array = new Type[parameters.Length + 1];
				for (int j = 0; j < array.Length - 1; j++)
				{
					array[j] = parameters[j].ParameterType;
				}
			}
			Type type = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
			if (opCode_0 == OpCodes.Newobj)
			{
				type = methodBase_0.DeclaringType;
			}
			DynamicMethod dynamicMethod = new DynamicMethod("", typeof(object), new Type[3]
			{
				typeof(Class54),
				typeof(Interface2[]),
				typeof(Type[])
			}, df300be.d69fb105, skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			for (int k = 0; k < array.Length - 1; k++)
			{
				Type type2 = array[k];
				bool isByRef;
				if (isByRef = type2.IsByRef)
				{
					type2 = type2.GetElementType();
				}
				LocalBuilder local = iLGenerator.DeclareLocal(typeof(TypedReference));
				iLGenerator.Emit(OpCodes.Ldarg_1);
				iLGenerator.Emit(OpCodes.Ldc_I4, k);
				iLGenerator.Emit(OpCodes.Ldelem_Ref);
				iLGenerator.Emit(OpCodes.Ldarg_0);
				iLGenerator.Emit(OpCodes.Ldloca, local);
				iLGenerator.Emit(OpCodes.Ldarg_2);
				iLGenerator.Emit(OpCodes.Ldc_I4, k);
				iLGenerator.Emit(OpCodes.Ldelem_Ref);
				iLGenerator.Emit(OpCodes.Callvirt, methodInfo_0);
				iLGenerator.Emit(OpCodes.Ldloca, local);
				iLGenerator.Emit(OpCodes.Ldarg_2);
				iLGenerator.Emit(OpCodes.Ldc_I4, k);
				iLGenerator.Emit(OpCodes.Ldelem_Ref);
				iLGenerator.Emit(OpCodes.Call, methodInfo_1);
				iLGenerator.Emit(OpCodes.Ldloc, local);
				iLGenerator.Emit(OpCodes.Refanyval, type2);
				if (!isByRef)
				{
					iLGenerator.Emit(OpCodes.Ldobj, type2);
				}
			}
			if ((object)type_0 != null)
			{
				iLGenerator.Emit(OpCodes.Constrained, type_0);
			}
			if (methodBase_0 is MethodInfo)
			{
				iLGenerator.Emit(opCode_0, (MethodInfo)methodBase_0);
			}
			else
			{
				iLGenerator.Emit(opCode_0, (ConstructorInfo)methodBase_0);
			}
			if (type.IsByRef)
			{
				iLGenerator.Emit(OpCodes.Mkrefany, type.GetElementType());
				iLGenerator.Emit(OpCodes.Newobj, constructorInfo_0);
			}
			else if ((object)type == typeof(void))
			{
				iLGenerator.Emit(OpCodes.Ldnull);
			}
			else if (type.IsValueType)
			{
				iLGenerator.Emit(OpCodes.Box, type);
			}
			iLGenerator.Emit(OpCodes.Ret);
			return (Delegate1)(hashtable[key] = (Delegate1)dynamicMethod.CreateDelegate(typeof(Delegate1)));
		}
	}
}
