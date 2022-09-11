using System;
using System.Reflection;
using System.Reflection.Emit;
using _0001;
using SmartAssembly.Delegates;
using _0080;

namespace SmartAssembly.HouseOfCards;

public static class Strings
{
	[global::_0001._0001]
	public static void CreateGetStringDelegate(Type ownerType)
	{
		//IL_0126: Incompatible stack heights: 0 vs 1
		//IL_0130: Incompatible stack heights: 0 vs 1
		((Type)/*Error near IL_0130: Stack underflow*/).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		FieldInfo[] array = default(FieldInfo[]);
		if (0 == 0)
		{
			array = (FieldInfo[])/*Error near IL_0136: Stack underflow*/;
		}
		foreach (FieldInfo fieldInfo in array)
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
				MethodInfo[] methods = typeof(_0080._0014).GetMethods(BindingFlags.Static | BindingFlags.Public);
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
