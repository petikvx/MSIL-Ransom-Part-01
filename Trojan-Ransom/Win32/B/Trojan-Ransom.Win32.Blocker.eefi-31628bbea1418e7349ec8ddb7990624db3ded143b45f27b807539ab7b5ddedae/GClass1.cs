using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

[SuppressIldasm]
public static class GClass1
{
	[Attribute1]
	public static void smethod_0(Type type_0)
	{
		FieldInfo[] fields = type_0.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			try
			{
				if ((object)fieldInfo.FieldType != typeof(GDelegate0))
				{
					continue;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(string), new Type[1] { typeof(int) }, type_0.Module, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				iLGenerator.Emit(OpCodes.Ldarg_0);
				MethodInfo[] methods = typeof(Class8).GetMethods(BindingFlags.Static | BindingFlags.Public);
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
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeof(GDelegate0)));
				break;
			}
			catch
			{
			}
		}
	}
}
