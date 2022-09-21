using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ns0;

internal sealed class Class7
{
	private static readonly int int_0;

	private static readonly int int_1;

	private static readonly int int_2;

	private static readonly int int_3;

	private static readonly int int_4;

	private static readonly int int_5;

	private static readonly int int_6;

	private static readonly int int_7;

	private static readonly int int_8;

	private static readonly int int_9;

	private static readonly int int_10;

	private static readonly int int_11;

	private static readonly int int_12;

	private static readonly int int_13;

	private static readonly int int_14;

	private static readonly int int_15;

	private static readonly int int_16;

	private static readonly int int_17;

	private static readonly int int_18;

	private static readonly int int_19;

	private static readonly ModuleHandle moduleHandle_0;

	private int Int32_0 => 1;

	static Class7()
	{
		if ((object)typeof(MulticastDelegate) != null)
		{
			moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
		}
	}

	public static void smethod_0(int int_20, int int_21, int int_22)
	{
		Type typeFromHandle;
		MethodInfo methodInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(moduleHandle_0.ResolveTypeHandle(int_20));
			object obj = ((int_22 != 16777215) ? MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(int_21), moduleHandle_0.ResolveTypeHandle(int_22)) : MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(int_21)));
			methodInfo = (MethodInfo)obj;
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			try
			{
				Delegate value;
				if (methodInfo.IsStatic)
				{
					value = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
				}
				else
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num = parameters.Length + 1;
					Type[] array = new Type[num];
					if (methodInfo.DeclaringType!.IsValueType)
					{
						array[0] = methodInfo.DeclaringType!.MakeByRefType();
					}
					else
					{
						array[0] = typeof(object);
					}
					for (int j = 1; j < num; j++)
					{
						array[j] = parameters[j - 1].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					iLGenerator.Emit(OpCodes.Ldarg_0);
					if (num > 1)
					{
						iLGenerator.Emit(OpCodes.Ldarg_1);
					}
					if (num > 2)
					{
						iLGenerator.Emit(OpCodes.Ldarg_2);
					}
					if (num > 3)
					{
						iLGenerator.Emit(OpCodes.Ldarg_3);
					}
					if (num > 4)
					{
						for (int k = 4; k < num; k++)
						{
							iLGenerator.Emit(OpCodes.Ldarg_S, k);
						}
					}
					iLGenerator.Emit(fieldInfo.IsFamilyOrAssembly ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					iLGenerator.Emit(OpCodes.Ret);
					value = dynamicMethod.CreateDelegate(typeFromHandle);
				}
				fieldInfo.SetValue(null, value);
			}
			catch (Exception)
			{
			}
		}
	}
}
