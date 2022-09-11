using System;
using System.Reflection;
using System.Reflection.Emit;
using ns5;

namespace SmartAssembly.HouseOfCards;

public static class MemberRefsProxy
{
	private static ModuleHandle moduleHandle_0;

	private static char[] char_0;

	[Attribute0]
	public unsafe static void CreateMemberRefsDelegates(int typeID)
	{
		void* ptr = stackalloc byte[29];
		Type typeFromHandle;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(moduleHandle_0.ResolveTypeHandle(33554433 + typeID));
		}
		catch
		{
			return;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		*(int*)ptr = 0;
		for (; *(int*)ptr < fields.Length; (*(int*)ptr)++)
		{
			FieldInfo fieldInfo = fields[*(int*)ptr];
			string name = fieldInfo.Name;
			((byte*)ptr)[28] = 0;
			*(int*)((byte*)ptr + 4) = 0;
			*(int*)((byte*)ptr + 8) = name.Length - 1;
			while (*(int*)((byte*)ptr + 8) >= 0)
			{
				char c = name[*(int*)((byte*)ptr + 8)];
				if (c != '~')
				{
					*(int*)((byte*)ptr + 12) = 0;
					while (*(int*)((byte*)ptr + 12) < 58)
					{
						if (char_0[*(int*)((byte*)ptr + 12)] != c)
						{
							(*(int*)((byte*)ptr + 12))++;
							continue;
						}
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 4) * 58 + *(int*)((byte*)ptr + 12);
						break;
					}
					(*(int*)((byte*)ptr + 8))--;
					continue;
				}
				((byte*)ptr)[28] = 1;
				break;
			}
			MethodInfo methodInfo;
			try
			{
				methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(*(int*)((byte*)ptr + 4) + 167772161));
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
				*(int*)((byte*)ptr + 16) = parameters.Length + 1;
				Type[] array = new Type[*(int*)((byte*)ptr + 16)];
				array[0] = typeof(object);
				*(int*)((byte*)ptr + 20) = 1;
				while (*(int*)((byte*)ptr + 20) < *(int*)((byte*)ptr + 16))
				{
					array[*(int*)((byte*)ptr + 20)] = parameters[*(int*)((byte*)ptr + 20) - 1].ParameterType;
					(*(int*)((byte*)ptr + 20))++;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
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
					value = dynamicMethod.CreateDelegate(typeFromHandle);
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
		char_0 = new char[58]
		{
			'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
			'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
			'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
			'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
			'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
			'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
		};
		if ((object)typeof(MulticastDelegate) != null)
		{
			moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
		}
	}
}
