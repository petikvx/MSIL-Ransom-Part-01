using System;
using System.Reflection;
using System.Reflection.Emit;
using _0001;
using _0005;

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
		//IL_02a8: Incompatible stack heights: 0 vs 1
		//IL_02b2: Incompatible stack heights: 0 vs 1
		//IL_02be: Incompatible stack heights: 0 vs 1
		void* ptr = stackalloc byte[29];
		Type type = default(Type);
		FieldInfo[] array = default(FieldInfo[]);
		FieldInfo fieldInfo = default(FieldInfo);
		string name = default(string);
		char c = default(char);
		MethodInfo methodInfo = default(MethodInfo);
		Delegate @delegate = default(Delegate);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		Type[] array2 = default(Type[]);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		ILGenerator iLGenerator = default(ILGenerator);
		try
		{
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
			((Type)/*Error near IL_02b2: Stack underflow*/).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			array = (FieldInfo[])/*Error near IL_02b8: Stack underflow*/;
			*(int*)(nint)/*Error near IL_0054: Stack underflow*/ = 0;
			for (; *(int*)ptr < array.Length; (*(int*)ptr)++)
			{
				fieldInfo = array[*(int*)ptr];
				name = fieldInfo.Name;
				((byte*)ptr)[28] = 0;
				*(int*)((byte*)ptr + 4) = 0;
				*(int*)((byte*)ptr + 8) = name.Length - 1;
				while (*(int*)((byte*)ptr + 8) >= 0)
				{
					c = name[*(int*)((byte*)ptr + 8)];
					if (c == '~')
					{
						((byte*)ptr)[28] = 1;
						break;
					}
					*(int*)((byte*)ptr + 12) = 0;
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
				try
				{
					methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(MemberRefsProxy._0001.ResolveMethodHandle(*(int*)((byte*)ptr + 4) + 167772161));
				}
				catch
				{
					continue;
				}
				if (methodInfo.IsStatic)
				{
					try
					{
						@delegate = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
					}
					catch (Exception)
					{
						continue;
					}
				}
				else
				{
					parameters = methodInfo.GetParameters();
					*(int*)((byte*)ptr + 16) = parameters.Length + 1;
					array2 = new Type[*(int*)((byte*)ptr + 16)];
					array2[0] = typeof(object);
					*(int*)((byte*)ptr + 20) = 1;
					while (true)
					{
						if (*(int*)((byte*)ptr + 20) < *(int*)((byte*)ptr + 16))
						{
							array2[*(int*)((byte*)ptr + 20)] = parameters[*(int*)((byte*)ptr + 20) - 1].ParameterType;
							(*(int*)((byte*)ptr + 20))++;
							continue;
						}
						dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array2, type, skipVisibility: true);
						iLGenerator = dynamicMethod.GetILGenerator();
						if (3u != 0)
						{
							break;
						}
					}
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
						@delegate = dynamicMethod.CreateDelegate(type);
					}
					catch
					{
						continue;
					}
				}
				try
				{
					fieldInfo.SetValue(null, @delegate);
				}
				catch
				{
				}
			}
		}
		catch (Exception ex2)
		{
			_0005._0011._0001(ex2, new object[20]
			{
				type,
				array,
				*(int*)ptr,
				fieldInfo,
				name,
				((byte*)ptr)[28] != 0,
				*(int*)((byte*)ptr + 4),
				methodInfo,
				@delegate,
				*(int*)((byte*)ptr + 8),
				c,
				*(int*)((byte*)ptr + 12),
				parameters,
				*(int*)((byte*)ptr + 16),
				array2,
				dynamicMethod,
				iLGenerator,
				*(int*)((byte*)ptr + 20),
				*(int*)((byte*)ptr + 24),
				typeID
			});
			throw;
		}
	}

	static MemberRefsProxy()
	{
		//IL_003d: Incompatible stack heights: 0 vs 1
		//IL_0044: Incompatible stack heights: 0 vs 1
		//IL_004b: Incompatible stack heights: 0 vs 1
		//IL_0052: Incompatible stack heights: 0 vs 1
		//IL_0059: Incompatible stack heights: 0 vs 1
		try
		{
			while (true)
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
				if (0 == 0 && 7u != 0)
				{
					if (false)
					{
						break;
					}
					_ = typeof(MulticastDelegate);
					if ((int)/*Error near IL_0029: Stack underflow*/ != 0)
					{
						break;
					}
					return;
				}
			}
			Assembly.GetExecutingAssembly();
			((Assembly)/*Error near IL_0052: Stack underflow*/).GetModules();
			_ = ((Module)((object[])/*Error near IL_002f: Stack underflow*/)[0]).ModuleHandle;
			MemberRefsProxy._0001 = (ModuleHandle)/*Error near IL_0036: Stack underflow*/;
		}
		catch (Exception ex)
		{
			_0005._0011._0001(ex);
			throw;
		}
	}
}
