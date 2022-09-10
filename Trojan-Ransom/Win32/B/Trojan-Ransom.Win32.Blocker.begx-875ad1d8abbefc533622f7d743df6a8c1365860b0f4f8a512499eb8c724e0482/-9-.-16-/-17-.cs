using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using _003F12_003F;

namespace _003F9_003F._003F16_003F;

[global::_003F12_003F._003F12_003F]
[global::_003F12_003F._003F13_003F]
public static class _003F17_003F
{
	private static ModuleHandle _003F12_003F;

	private static char[] _003F12_003F;

	[global::_003F12_003F._003F12_003F]
	[global::_003F12_003F._003F13_003F]
	public unsafe static void _003F34_003F(int P_0)
	{
		//IL_0014: Incompatible stack heights: 0 vs 2
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Incompatible stack heights: 0 vs 1
		//IL_0049: Incompatible stack heights: 0 vs 1
		//IL_005d: Incompatible stack heights: 0 vs 1
		//IL_0071: Incompatible stack heights: 0 vs 1
		//IL_0304: Incompatible stack heights: 0 vs 1
		//IL_0318: Incompatible stack heights: 0 vs 1
		//IL_031d: Incompatible stack heights: 0 vs 1
		Type type;
		try
		{
			_ = ref _003F17_003F._003F12_003F;
			_ = 33554433;
			_ = /*Error near IL_001a: Stack underflow*/+ /*Error near IL_001a: Stack underflow*/;
			((ModuleHandle*)/*Error near IL_0053: Stack underflow*/)->ResolveTypeHandle((int)/*Error near IL_0053: Stack underflow*/);
			Type.GetTypeFromHandle((RuntimeTypeHandle)/*Error near IL_0067: Stack underflow*/);
			type = (Type)/*Error near IL_0039: Stack underflow*/;
		}
		catch
		{
			return;
		}
		FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			string name = fieldInfo.Name;
			bool flag = false;
			int num = 0;
			for (int num2 = name.Length - 1; num2 >= 0; num2--)
			{
				char c = name[num2];
				if (c == '~')
				{
					flag = true;
					break;
				}
				for (int j = 0; j < 58; j++)
				{
					if (_003F12_003F[j] == c)
					{
						num = num * 58 + j;
						break;
					}
				}
			}
			MethodInfo methodInfo;
			try
			{
				methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(_003F17_003F._003F12_003F.ResolveMethodHandle(num + 167772161));
			}
			catch
			{
				continue;
			}
			Delegate value;
			if (methodInfo.IsStatic)
			{
				try
				{
					value = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
				}
				catch (Exception)
				{
					continue;
				}
			}
			else
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num3 = parameters.Length + 1;
				Type[] array = new Type[num3];
				array[0] = typeof(object);
				for (int k = 1; k < num3; k++)
				{
					array[k] = parameters[k - 1].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array, type, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				iLGenerator.Emit(OpCodes.Ldarg_0);
				if (num3 > 1)
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
				}
				if (num3 > 2)
				{
					iLGenerator.Emit(OpCodes.Ldarg_2);
				}
				if (num3 > 3)
				{
					iLGenerator.Emit(OpCodes.Ldarg_3);
				}
				if (num3 > 4)
				{
					for (int l = 4; l < num3; l++)
					{
						iLGenerator.Emit(OpCodes.Ldarg_S, l);
					}
				}
				if (!flag)
				{
					_ = OpCodes.Call;
				}
				else
				{
					_ = OpCodes.Callvirt;
				}
				((ILGenerator)/*Error near IL_0329: Stack underflow*/).Emit((OpCode)/*Error near IL_0329: Stack underflow*/, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				try
				{
					value = dynamicMethod.CreateDelegate(type);
				}
				catch
				{
					continue;
				}
			}
			try
			{
				fieldInfo.SetValue(null, value);
			}
			catch
			{
			}
		}
	}

	static _003F17_003F()
	{
		//IL_0053: Incompatible stack heights: 0 vs 3
		//IL_0058: Incompatible stack heights: 0 vs 1
		//IL_0078: Incompatible stack heights: 0 vs 2
		//IL_0082: Incompatible stack heights: 0 vs 1
		_ = new char[58];
		/*OpCode not supported: LdMemberToken*/;
		RuntimeHelpers.InitializeArray((Array)/*Error near IL_003e: Stack underflow*/, (RuntimeFieldHandle)/*Error near IL_003e: Stack underflow*/);
		_003F12_003F = (char[])/*Error near IL_0017: Stack underflow*/;
		_ = typeof(MulticastDelegate).TypeHandle;
		Type.GetTypeFromHandle((RuntimeTypeHandle)/*Error near IL_0048: Stack underflow*/);
		Type type;
		if (3u != 0)
		{
			type = (Type)/*Error near IL_004e: Stack underflow*/;
		}
		if ((object)type != null)
		{
			Assembly.GetExecutingAssembly().GetModules();
			_ = 0;
			_003F17_003F._003F12_003F = ((Module)((object[])/*Error near IL_002e: Stack underflow*/)[/*Error near IL_002e: Stack underflow*/]).ModuleHandle;
		}
	}
}
