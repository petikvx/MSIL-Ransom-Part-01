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
	public unsafe static void CreateGetStringDelegate(Type ownerType)
	{
		//IL_013f: Incompatible stack heights: 0 vs 1
		//IL_015f: Incompatible stack heights: 0 vs 1
		//IL_0169: Incompatible stack heights: 0 vs 1
		//IL_0175: Incompatible stack heights: 0 vs 1
		//IL_017b: Incompatible stack heights: 0 vs 1
		//IL_0181: Incompatible stack heights: 0 vs 1
		void* ptr = stackalloc byte[8];
		((Type)/*Error near IL_0169: Stack underflow*/).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		FieldInfo[] array = (FieldInfo[])/*Error near IL_016f: Stack underflow*/;
		*(int*)(nint)/*Error near IL_0024: Stack underflow*/ = 0;
		while (*(int*)ptr < array.Length)
		{
			int num = *(int*)(nint)/*Error near IL_0034: Stack underflow*/;
			FieldInfo fieldInfo = (FieldInfo)((object[])/*Error near IL_0035: Stack underflow*/)[num];
			try
			{
				if ((object)((FieldInfo)/*Error near IL_0044: Stack underflow*/).FieldType == typeof(GetString))
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(string), new Type[1] { typeof(int) }, ownerType.Module, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					iLGenerator.Emit(OpCodes.Ldarg_0);
					MethodInfo[] methods = typeof(_0080._0001).GetMethods(BindingFlags.Static | BindingFlags.Public);
					*(int*)((byte*)ptr + 4) = 0;
					while (*(int*)((byte*)ptr + 4) < methods.Length)
					{
						MethodInfo methodInfo = methods[*(int*)((byte*)ptr + 4)];
						if ((object)methodInfo.ReturnType == typeof(string))
						{
							iLGenerator.Emit(OpCodes.Ldc_I4, fieldInfo.MetadataToken & 0xFFFFFF);
							iLGenerator.Emit(OpCodes.Sub);
							iLGenerator.Emit(OpCodes.Call, methodInfo);
							break;
						}
						(*(int*)((byte*)ptr + 4))++;
					}
					if (0 == 0)
					{
						iLGenerator.Emit(OpCodes.Ret);
					}
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
