using System;
using System.Reflection;
using System.Reflection.Emit;
using _0001;
using _0005;
using _000E;
using SmartAssembly.Delegates;

namespace SmartAssembly.HouseOfCards;

public static class Strings
{
	[global::_0001._0001]
	public unsafe static void CreateGetStringDelegate(Type ownerType)
	{
		//IL_013c: Incompatible stack heights: 0 vs 1
		//IL_0157: Incompatible stack heights: 0 vs 1
		//IL_0161: Incompatible stack heights: 0 vs 1
		//IL_016d: Incompatible stack heights: 0 vs 1
		//IL_0173: Incompatible stack heights: 0 vs 1
		//IL_0179: Incompatible stack heights: 0 vs 1
		void* ptr = stackalloc byte[8];
		FieldInfo[] array = default(FieldInfo[]);
		FieldInfo fieldInfo = default(FieldInfo);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		ILGenerator iLGenerator = default(ILGenerator);
		MethodInfo[] methods = default(MethodInfo[]);
		MethodInfo methodInfo = default(MethodInfo);
		try
		{
			((Type)/*Error near IL_0161: Stack underflow*/).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			array = (FieldInfo[])/*Error near IL_0167: Stack underflow*/;
			*(int*)(nint)/*Error near IL_0024: Stack underflow*/ = 0;
			while (*(int*)ptr < array.Length)
			{
				int num = *(int*)(nint)/*Error near IL_0034: Stack underflow*/;
				fieldInfo = (FieldInfo)((object[])/*Error near IL_0035: Stack underflow*/)[num];
				try
				{
					if ((object)((FieldInfo)/*Error near IL_0044: Stack underflow*/).FieldType == typeof(GetString))
					{
						dynamicMethod = new DynamicMethod(string.Empty, typeof(string), new Type[1] { typeof(int) }, ownerType.Module, skipVisibility: true);
						iLGenerator = dynamicMethod.GetILGenerator();
						iLGenerator.Emit(OpCodes.Ldarg_0);
						methods = typeof(_000E._0003).GetMethods(BindingFlags.Static | BindingFlags.Public);
						*(int*)((byte*)ptr + 4) = 0;
						while (*(int*)((byte*)ptr + 4) < methods.Length)
						{
							methodInfo = methods[*(int*)((byte*)ptr + 4)];
							if ((object)methodInfo.ReturnType == typeof(string))
							{
								iLGenerator.Emit(OpCodes.Ldc_I4, fieldInfo.MetadataToken & 0xFFFFFF);
								iLGenerator.Emit(OpCodes.Sub);
								iLGenerator.Emit(OpCodes.Call, methodInfo);
								break;
							}
							(*(int*)((byte*)ptr + 4))++;
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
		catch (Exception ex)
		{
			_0005._0011._0001(ex, (object)array, (object)(*(int*)ptr), (object)fieldInfo, (object)dynamicMethod, (object)iLGenerator, (object)methods, (object)(*(int*)((byte*)ptr + 4)), (object)methodInfo, (object)ownerType);
			throw;
		}
	}
}
