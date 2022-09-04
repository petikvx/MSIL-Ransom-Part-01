using System;
using System.Reflection;
using System.Reflection.Emit;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns6;

[Attribute2]
[Attribute1]
internal static class Class5
{
	[Attribute0]
	[Attribute1]
	[Attribute2]
	public unsafe static void smethod_0(Type type_0)
	{
		void* ptr = stackalloc byte[8];
		FieldInfo[] fields = type_0.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		*(int*)ptr = 0;
		while (*(int*)ptr < fields.Length)
		{
			FieldInfo fieldInfo = fields[*(int*)ptr];
			try
			{
				if ((object)fieldInfo.FieldType == typeof(Delegate0))
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(string), new Type[1] { typeof(int) }, type_0.Module, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					iLGenerator.Emit(OpCodes.Ldarg_0);
					MethodInfo[] methods = typeof(Class10).GetMethods(BindingFlags.Static | BindingFlags.Public);
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
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeof(Delegate0)));
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
