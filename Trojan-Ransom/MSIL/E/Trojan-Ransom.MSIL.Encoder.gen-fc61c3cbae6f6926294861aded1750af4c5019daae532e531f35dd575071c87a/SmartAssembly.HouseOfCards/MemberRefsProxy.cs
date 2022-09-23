using System;
using System.Reflection;
using System.Reflection.Emit;
using _0001;

namespace SmartAssembly.HouseOfCards;

public static class MemberRefsProxy
{
	private static ModuleHandle _0001;

	private static char[] _0001;

	[global::_0001._0001]
	public unsafe static void CreateMemberRefsDelegates(int typeID)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Incompatible stack heights: 0 vs 3
		//IL_0027: Expected I4, but got Unknown
		//IL_0027: Incompatible stack heights: 0 vs 1
		//IL_002e: Incompatible stack heights: 0 vs 1
		//IL_02c2: Incompatible stack heights: 0 vs 1
		//IL_02cc: Incompatible stack heights: 0 vs 1
		//IL_02d8: Incompatible stack heights: 0 vs 1
		void* ptr = stackalloc byte[29];
		Type type;
		try
		{
			_ = ref MemberRefsProxy._0001;
			_ = 33554433;
			_003F val = /*Error near IL_0017: Stack underflow*/+ /*Error near IL_0017: Stack underflow*/;
			((ModuleHandle*)/*Error near IL_0027: Stack underflow*/)->ResolveTypeHandle((int)val);
			Type.GetTypeFromHandle((RuntimeTypeHandle)/*Error near IL_002e: Stack underflow*/);
			type = (Type)/*Error near IL_0031: Stack underflow*/;
		}
		catch
		{
			return;
		}
		if (8 == 0)
		{
			goto IL_01d4;
		}
		((Type)/*Error near IL_02cc: Stack underflow*/).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		FieldInfo[] array = (FieldInfo[])/*Error near IL_02d2: Stack underflow*/;
		*(int*)(nint)/*Error near IL_005a: Stack underflow*/ = 0;
		goto IL_02b0;
		IL_0298:
		FieldInfo fieldInfo = default(FieldInfo);
		Delegate value;
		try
		{
			fieldInfo.SetValue(null, value);
		}
		catch
		{
		}
		goto IL_02a7;
		IL_01b4:
		MethodInfo methodInfo = default(MethodInfo);
		Type[] array2;
		DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array2, type, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		goto IL_01d4;
		IL_01d4:
		iLGenerator.Emit(OpCodes.Ldarg_0);
		if (*(int*)((byte*)ptr + 16) > 1)
		{
			iLGenerator.Emit(OpCodes.Ldarg_1);
		}
		if (*(int*)((byte*)ptr + 16) > 2)
		{
			iLGenerator.Emit(OpCodes.Ldarg_2);
		}
		if (*(int*)((byte*)ptr + 16) > 3)
		{
			iLGenerator.Emit(OpCodes.Ldarg_3);
		}
		if (*(int*)((byte*)ptr + 16) > 4)
		{
			*(int*)((byte*)ptr + 24) = 4;
			while (*(int*)((byte*)ptr + 24) < *(int*)((byte*)ptr + 16))
			{
				iLGenerator.Emit(OpCodes.Ldarg_S, *(int*)((byte*)ptr + 24));
				(*(int*)((byte*)ptr + 24))++;
			}
		}
		iLGenerator.Emit(OpCodes.Tailcall);
		iLGenerator.Emit((((byte*)ptr)[28] != 0) ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
		iLGenerator.Emit(OpCodes.Ret);
		try
		{
			value = dynamicMethod.CreateDelegate(type);
		}
		catch
		{
			goto IL_02a7;
		}
		goto IL_0298;
		IL_02a7:
		if (0 == 0)
		{
			(*(int*)ptr)++;
			goto IL_02b0;
		}
		return;
		IL_02b0:
		while (true)
		{
			if (*(int*)ptr >= array.Length)
			{
				return;
			}
			fieldInfo = array[*(int*)ptr];
			string name = fieldInfo.Name;
			((byte*)ptr)[28] = 0;
			*(int*)((byte*)ptr + 4) = 0;
			*(int*)((byte*)ptr + 8) = name.Length - 1;
			while (0 == 0)
			{
				if (*(int*)((byte*)ptr + 8) < 0)
				{
					goto end_IL_02b0;
				}
				char c = name[*(int*)((byte*)ptr + 8)];
				if (c == '~')
				{
					((byte*)ptr)[28] = 1;
					goto end_IL_02b0;
				}
				*(int*)((byte*)ptr + 12) = 0;
				if (false)
				{
					goto end_IL_02b0;
				}
				while (*(int*)((byte*)ptr + 12) < 58)
				{
					if (_0001[*(int*)((byte*)ptr + 12)] == c)
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 4) * 58 + *(int*)((byte*)ptr + 12);
						break;
					}
					(*(int*)((byte*)ptr + 12))++;
				}
				(*(int*)((byte*)ptr + 8))--;
			}
			continue;
			end_IL_02b0:
			break;
		}
		while (true)
		{
			IL_00fd:
			try
			{
				methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(MemberRefsProxy._0001.ResolveMethodHandle(*(int*)((byte*)ptr + 4) + 167772161));
			}
			catch
			{
				break;
			}
			if (methodInfo.IsStatic)
			{
				goto IL_012f;
			}
			ParameterInfo[] parameters = methodInfo.GetParameters();
			*(int*)((byte*)ptr + 16) = parameters.Length + 1;
			array2 = new Type[*(int*)((byte*)ptr + 16)];
			array2[0] = typeof(object);
			*(int*)((byte*)ptr + 20) = 1;
			while (*(int*)((byte*)ptr + 20) < *(int*)((byte*)ptr + 16))
			{
				array2[*(int*)((byte*)ptr + 20)] = parameters[*(int*)((byte*)ptr + 20) - 1].ParameterType;
				if (false)
				{
					goto IL_00fd;
				}
				(*(int*)((byte*)ptr + 20))++;
			}
			goto IL_01b4;
		}
		goto IL_02a7;
		IL_012f:
		try
		{
			value = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
		}
		catch (Exception)
		{
			goto IL_02a7;
		}
		goto IL_0298;
	}

	static MemberRefsProxy()
	{
		//IL_003c: Incompatible stack heights: 0 vs 1
		//IL_0043: Incompatible stack heights: 0 vs 1
		//IL_004a: Incompatible stack heights: 0 vs 1
		//IL_0051: Incompatible stack heights: 0 vs 1
		//IL_0058: Incompatible stack heights: 0 vs 1
		while (true)
		{
			if (uint.MaxValue != 0)
			{
				_ = new char[58]
				{
					'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
					'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
					'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
					'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
					'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
					'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
				};
				_0001 = (char[])/*Error near IL_0017: Stack underflow*/;
				_ = typeof(MulticastDelegate);
				if ((int)/*Error near IL_0020: Stack underflow*/ == 0)
				{
					goto IL_002d;
				}
			}
			goto IL_0045;
			IL_002d:
			if (0 == 0)
			{
				if (false)
				{
					continue;
				}
				if (5u != 0)
				{
					break;
				}
			}
			goto IL_0045;
			IL_0045:
			Assembly.GetExecutingAssembly();
			((Assembly)/*Error near IL_0051: Stack underflow*/).GetModules();
			_ = ((Module)((object[])/*Error near IL_0026: Stack underflow*/)[0]).ModuleHandle;
			MemberRefsProxy._0001 = (ModuleHandle)/*Error near IL_002d: Stack underflow*/;
			goto IL_002d;
		}
	}
}
