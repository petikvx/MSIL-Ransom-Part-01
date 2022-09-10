using System;
using System.Reflection;
using System.Reflection.Emit;
using ns1;
using ns4;
using ns7;

namespace ns5;

[Attribute1]
[Attribute2]
internal static class Class28
{
	[Attribute1]
	[Attribute2]
	public static void smethod_0(Type type_0)
	{
		FieldInfo[] fields = type_0.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			try
			{
				if ((object)fieldInfo.FieldType != typeof(Delegate3))
				{
					continue;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(string), new Type[1] { typeof(int) }, type_0.Module, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				iLGenerator.Emit(OpCodes.Ldarg_0);
				MethodInfo[] methods = typeof(Class32).GetMethods(BindingFlags.Static | BindingFlags.Public);
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
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeof(Delegate3)));
				break;
			}
			catch
			{
			}
		}
	}
}
