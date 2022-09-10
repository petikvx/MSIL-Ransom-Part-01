using System;
using System.Reflection;
using System.Reflection.Emit;
using _003F12_003F;
using _003F9_003F._003F14_003F;
using _003F9_003F._003F19_003F;

namespace _003F9_003F._003F16_003F;

[_003F12_003F._003F13_003F]
[global::_003F12_003F._003F12_003F]
public static class _003F18_003F
{
	[_003F12_003F._003F13_003F]
	[global::_003F12_003F._003F12_003F]
	public static void _003F35_003F(Type P_0)
	{
		//IL_001e: Incompatible stack heights: 0 vs 1
		//IL_01a5: Incompatible stack heights: 0 vs 1
		//IL_01b9: Incompatible stack heights: 0 vs 1
		_ = 1064;
		((Type)/*Error near IL_01af: Stack underflow*/).GetFields((BindingFlags)/*Error near IL_01af: Stack underflow*/);
		FieldInfo[] array = (FieldInfo[])/*Error near IL_01c0: Stack underflow*/;
		foreach (FieldInfo fieldInfo in array)
		{
			try
			{
				if ((object)fieldInfo.FieldType != typeof(_003F15_003F))
				{
					continue;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(string), new Type[1] { typeof(int) }, P_0, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				iLGenerator.Emit(OpCodes.Ldarg_0);
				MethodInfo[] methods = typeof(_003F9_003F._003F19_003F._003F18_003F).GetMethods(BindingFlags.Static | BindingFlags.Public);
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
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeof(_003F15_003F)));
				break;
			}
			catch
			{
			}
		}
	}
}
