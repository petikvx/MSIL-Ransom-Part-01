using System;
using System.Reflection;
using System.Reflection.Emit;
using ns0;
using ns2;
using ns6;

namespace ns4;

[Attribute2]
[Attribute1]
internal static class Class14
{
	[Attribute0]
	[Attribute1]
	[Attribute2]
	public static void smethod_0(Type type_0)
	{
		FieldInfo[] fields = type_0.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			try
			{
				if ((object)fieldInfo.FieldType != typeof(Delegate1))
				{
					continue;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(string), new Type[1] { typeof(int) }, type_0.Module, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				iLGenerator.Emit(OpCodes.Ldarg_0);
				MethodInfo[] methods = typeof(Class16).GetMethods(BindingFlags.Static | BindingFlags.Public);
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
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeof(Delegate1)));
				break;
			}
			catch
			{
			}
		}
	}
}
