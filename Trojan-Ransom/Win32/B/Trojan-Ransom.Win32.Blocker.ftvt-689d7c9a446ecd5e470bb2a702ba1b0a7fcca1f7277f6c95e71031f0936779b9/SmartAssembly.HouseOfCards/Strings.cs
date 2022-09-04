using System;
using System.Reflection;
using System.Reflection.Emit;
using SmartAssembly.Delegates;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.StringsEncoding;

namespace SmartAssembly.HouseOfCards;

public static class Strings
{
	public static void CreateGetStringDelegate(Type type_0)
	{
		FieldInfo[] fields = default(FieldInfo[]);
		int i = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		Type[] array = default(Type[]);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		ILGenerator iLGenerator = default(ILGenerator);
		MethodInfo[] methods = default(MethodInfo[]);
		int j = default(int);
		MethodInfo methodInfo = default(MethodInfo);
		try
		{
			fields = type_0.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (i = 0; i < fields.Length; i++)
			{
				fieldInfo = fields[i];
				try
				{
					if ((object)fieldInfo.FieldType != typeof(GetString))
					{
						continue;
					}
					string empty = string.Empty;
					Type typeFromHandle = typeof(string);
					array = new Type[1] { typeof(int) };
					dynamicMethod = new DynamicMethod(empty, typeFromHandle, array, type_0, skipVisibility: true);
					iLGenerator = dynamicMethod.GetILGenerator();
					iLGenerator.Emit(OpCodes.Ldarg_0);
					methods = typeof(SmartAssembly.StringsEncoding.Strings).GetMethods(BindingFlags.Static | BindingFlags.Public);
					for (j = 0; j < methods.Length; j++)
					{
						methodInfo = methods[j];
						if ((object)methodInfo.ReturnType == typeof(string))
						{
							iLGenerator.Emit(OpCodes.Ldc_I4, fieldInfo.MetadataToken & 0xFFFFFF);
							iLGenerator.Emit(OpCodes.Sub);
							iLGenerator.Emit(OpCodes.Call, methodInfo);
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeof(GetString)));
					break;
				}
				catch
				{
				}
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException10(exception_, fieldInfo, dynamicMethod, iLGenerator, methodInfo, fields, i, array, methods, j, type_0);
			throw;
		}
	}
}
