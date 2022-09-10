using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

[SuppressIldasm]
public static class GClass1
{
	[_0024j]
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
				if ((object)fieldInfo.FieldType == typeof(GDelegate0))
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(string), new Type[1] { typeof(int) }, type_0.Module, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					iLGenerator.Emit(OpCodes.Ldarg_0);
					MethodInfo[] methods = typeof(Class6).GetMethods(BindingFlags.Static | BindingFlags.Public);
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
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeof(GDelegate0)));
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
