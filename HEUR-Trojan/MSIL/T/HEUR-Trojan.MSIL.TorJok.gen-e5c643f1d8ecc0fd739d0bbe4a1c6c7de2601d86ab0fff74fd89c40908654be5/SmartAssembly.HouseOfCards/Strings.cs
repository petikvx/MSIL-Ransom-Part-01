using System;
using System.Reflection;
using System.Reflection.Emit;
using SmartAssembly.Delegates;
using ns8;
using ns9;

namespace SmartAssembly.HouseOfCards;

public static class Strings
{
	[Attribute1]
	public static void CreateGetStringDelegate(Type ownerType)
	{
		FieldInfo[] fields = ownerType.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			try
			{
				if ((object)fieldInfo.FieldType != typeof(GetString))
				{
					continue;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(string), new Type[1] { typeof(int) }, ownerType.Module, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				iLGenerator.Emit(OpCodes.Ldarg_0);
				MethodInfo[] methods = typeof(Class72).GetMethods(BindingFlags.Static | BindingFlags.Public);
				foreach (MethodInfo methodInfo in methods)
				{
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
}
