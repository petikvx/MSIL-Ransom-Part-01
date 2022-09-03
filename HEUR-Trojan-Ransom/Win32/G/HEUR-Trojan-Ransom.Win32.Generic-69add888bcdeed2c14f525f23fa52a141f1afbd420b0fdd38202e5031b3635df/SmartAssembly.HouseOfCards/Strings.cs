using System;
using System.Reflection;
using System.Reflection.Emit;
using SmartAssembly.Delegates;
using SmartAssembly.StringsEncoding;
using ns0;
using ns1;
using ns2;

namespace SmartAssembly.HouseOfCards;

[Attribute1]
[Attribute2]
public static class Strings
{
	[Attribute1]
	[Attribute2]
	[Attribute0]
	public unsafe static void CreateGetStringDelegate(Type type_0)
	{
		void* ptr = stackalloc byte[8];
		FieldInfo[] fields = type_0.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		*(int*)ptr = 0;
		while (*(int*)ptr < fields.Length)
		{
			FieldInfo fieldInfo = fields[*(int*)ptr];
			try
			{
				if ((object)fieldInfo.FieldType == typeof(GetString))
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(string), new Type[1] { typeof(int) }, type_0.Module, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					iLGenerator.Emit(OpCodes.Ldarg_0);
					MethodInfo[] methods = typeof(SmartAssembly.StringsEncoding.Strings).GetMethods(BindingFlags.Static | BindingFlags.Public);
					*(int*)((byte*)ptr + 4) = 0;
					while (*(int*)((byte*)ptr + 4) < methods.Length)
					{
						MethodInfo methodInfo = methods[*(int*)((byte*)ptr + 4)];
						if ((object)methodInfo.ReturnType != typeof(string))
						{
							(*(int*)((byte*)ptr + 4))++;
							continue;
						}
						iLGenerator.Emit(OpCodes.Ldc_I4, fieldInfo.MetadataToken & 0xFFFFFF);
						iLGenerator.Emit(OpCodes.Sub);
						iLGenerator.Emit(OpCodes.Call, methodInfo);
						break;
					}
					iLGenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeof(GetString)));
					break;
				}
			}
			catch
			{
			}
			(*(int*)ptr)++;
		}
	}
}
