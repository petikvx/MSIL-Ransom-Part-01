using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using _0001;

namespace SmartAssembly.HouseOfCards;

public static class MemberRefsProxy
{
	private static ModuleHandle _0001;

	private static char[] _0001;

	[global::_0001._0001]
	public unsafe static void CreateMemberRefsDelegates(int typeID)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Incompatible stack heights: 0 vs 3
		//IL_001c: Expected I4, but got Unknown
		//IL_001c: Incompatible stack heights: 0 vs 1
		//IL_0023: Incompatible stack heights: 0 vs 1
		Type type;
		try
		{
			_ = ref MemberRefsProxy._0001;
			_ = 33554433;
			_003F val = /*Error near IL_000d: Stack underflow*/+ /*Error near IL_000d: Stack underflow*/;
			((ModuleHandle*)/*Error near IL_001c: Stack underflow*/)->ResolveTypeHandle((int)val);
			Type.GetTypeFromHandle((RuntimeTypeHandle)/*Error near IL_0023: Stack underflow*/);
			type = (Type)/*Error near IL_0012: Stack underflow*/;
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
					if (_0001[j] == c)
					{
						num = num * 58 + j;
						break;
					}
				}
			}
			MethodInfo methodInfo;
			try
			{
				methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(MemberRefsProxy._0001.ResolveMethodHandle(num + 167772161));
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
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
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

	static MemberRefsProxy()
	{
		//IL_0040: Incompatible stack heights: 0 vs 1
		//IL_0047: Incompatible stack heights: 0 vs 1
		char[] array = new char[58];
		if (0 == 0)
		{
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		}
		_0001 = array;
		_ = typeof(MulticastDelegate);
		if ((int)/*Error near IL_0020: Stack underflow*/ != 0)
		{
			Assembly.GetExecutingAssembly();
			MemberRefsProxy._0001 = ((Assembly)/*Error near IL_0027: Stack underflow*/).GetModules()[0].ModuleHandle;
		}
	}
}
