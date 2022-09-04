using System;
using System.Reflection;
using System.Reflection.Emit;
using e0L3a2f4hfTEPNHirL;
using e1t9ZoIMs7pU1MfVBaV;
using e8LTutU7xPVoEGMHwY;
using e9tidtTOy7XQsxPlB3;
using etKNQTu9kgqwCqmIAv;

namespace eC98jAqdnPLlDITmK6;

[eeNgOOoJI24v6FIq7w]
[eQ4lsmegMDQXG3pADB]
internal static class eMbooerndU5ci2DHIZ
{
	[eQ4lsmegMDQXG3pADB]
	[eeNgOOoJI24v6FIq7w]
	public static void e4ZIbpnTa(Type type_0)
	{
		FieldInfo[] fields = default(FieldInfo[]);
		int i = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		Type[] array = default(Type[]);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		ILGenerator iLGenerator = default(ILGenerator);
		MethodInfo[] methods = default(MethodInfo[]);
		int j = default(int);
		MethodInfo methodInfo = default(MethodInfo);
		try
		{
			fields = type_0.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (i = 0; i < fields.Length; i++)
			{
				fieldInfo = fields[i];
				try
				{
					if ((object)e1ZvPxkutqll1QkrMaf(fieldInfo) != e2HcDXkbxkVu2P9tRGf(typeof(eDHHd4vO3FpvmheVMk).TypeHandle))
					{
						continue;
					}
					string empty = string.Empty;
					Type returnType = e2HcDXkbxkVu2P9tRGf(typeof(string).TypeHandle);
					array = new Type[1] { e2HcDXkbxkVu2P9tRGf(typeof(int).TypeHandle) };
					dynamicMethod = new DynamicMethod(empty, returnType, array, type_0, skipVisibility: true);
					iLGenerator = (ILGenerator)eQgEBmkS4ocJMF5qcad(dynamicMethod);
					eQmsRGkDITRYvZNIZmn(iLGenerator, OpCodes.Ldarg_0);
					methods = e2HcDXkbxkVu2P9tRGf(typeof(eleeaxETJdX5FMoGWm).TypeHandle).GetMethods(BindingFlags.Static | BindingFlags.Public);
					for (j = 0; j < methods.Length; j++)
					{
						methodInfo = methods[j];
						if ((object)ehgLsAkvkU2GamCyAIi(methodInfo) == e2HcDXkbxkVu2P9tRGf(typeof(string).TypeHandle))
						{
							e2qGjwkwNDmYZtjpu3O(iLGenerator, OpCodes.Ldc_I4, eq9DElk8qvwHFmUyYkp(fieldInfo) & 0xFFFFFF);
							eQmsRGkDITRYvZNIZmn(iLGenerator, OpCodes.Sub);
							eOkpnOk4jfVl4krWxWd(iLGenerator, OpCodes.Call, methodInfo);
							break;
						}
					}
					eQmsRGkDITRYvZNIZmn(iLGenerator, OpCodes.Ret);
					e6NsoakVtJfISR3cHdQ(fieldInfo, null, eMxA9wkpNKmJZJM7xtN(dynamicMethod, e2HcDXkbxkVu2P9tRGf(typeof(eDHHd4vO3FpvmheVMk).TypeHandle)));
					break;
				}
				catch
				{
				}
			}
		}
		catch (Exception object_)
		{
			eWIb8CkTnwZqWag1aDc(object_, fieldInfo, dynamicMethod, iLGenerator, methodInfo, fields, i, array, methods, j, type_0);
			throw;
		}
	}

	internal static Type e1ZvPxkutqll1QkrMaf(object object_0)
	{
		return ((FieldInfo)object_0).FieldType;
	}

	internal static Type e2HcDXkbxkVu2P9tRGf(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object eQgEBmkS4ocJMF5qcad(object object_0)
	{
		return ((DynamicMethod)object_0).GetILGenerator();
	}

	internal static void eQmsRGkDITRYvZNIZmn(object object_0, OpCode opCode_0)
	{
		((ILGenerator)object_0).Emit(opCode_0);
	}

	internal static Type ehgLsAkvkU2GamCyAIi(object object_0)
	{
		return ((MethodInfo)object_0).ReturnType;
	}

	internal static int eq9DElk8qvwHFmUyYkp(object object_0)
	{
		return ((MemberInfo)object_0).MetadataToken;
	}

	internal static void e2qGjwkwNDmYZtjpu3O(object object_0, OpCode opCode_0, int int_0)
	{
		((ILGenerator)object_0).Emit(opCode_0, int_0);
	}

	internal static void eOkpnOk4jfVl4krWxWd(object object_0, OpCode opCode_0, object object_1)
	{
		((ILGenerator)object_0).Emit(opCode_0, (MethodInfo)object_1);
	}

	internal static object eMxA9wkpNKmJZJM7xtN(object object_0, Type type_0)
	{
		return ((DynamicMethod)object_0).CreateDelegate(type_0);
	}

	internal static void e6NsoakVtJfISR3cHdQ(object object_0, object object_1, object object_2)
	{
		((FieldInfo)object_0).SetValue(object_1, object_2);
	}

	internal static void eWIb8CkTnwZqWag1aDc(object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9, object object_10)
	{
		eEJNauItTVW1j8pluTb.eb1x595Bx((Exception)object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9, object_10);
	}

	internal static bool eXPpYvkydT0tJy6wig4()
	{
		return true;
	}

	internal static bool eGyaSWkMULyKpK8TJnA()
	{
		return false;
	}
}
