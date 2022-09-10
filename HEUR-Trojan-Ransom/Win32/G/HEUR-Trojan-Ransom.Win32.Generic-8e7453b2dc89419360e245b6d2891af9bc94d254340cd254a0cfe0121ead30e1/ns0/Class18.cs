using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ns0;

internal class Class18
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

	static Class18()
	{
		if ((object)typeof(MulticastDelegate) != null)
		{
			moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
		}
	}

	public static void smethod_0(int int_20, int int_21, int int_22)
	{
		Type typeFromHandle;
		ConstructorInfo constructorInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(moduleHandle_0.ResolveTypeHandle(int_20));
			object obj = ((int_22 != 16777215) ? MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(int_21), moduleHandle_0.ResolveTypeHandle(int_22)) : MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(int_21)));
			constructorInfo = (ConstructorInfo)obj;
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
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				int num = parameters.Length;
				Type[] array = new Type[num];
				for (int j = 0; j < num; j++)
				{
					array[j] = parameters[j].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, constructorInfo.DeclaringType, array, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				if (num > 0)
				{
					iLGenerator.Emit(OpCodes.Ldarg_0);
				}
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
				iLGenerator.Emit(OpCodes.Newobj, constructorInfo);
				iLGenerator.Emit(OpCodes.Ret);
				Delegate value = dynamicMethod.CreateDelegate(typeFromHandle);
				fieldInfo.SetValue(null, value);
			}
			catch (Exception)
			{
			}
		}
	}
}
