using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

internal static class Class61
{
	private delegate void f30c9cda(Struct2 struct2_0);

	private unsafe delegate void ebdbc671(void* pVoid_0, Struct2 struct2_0);

	private delegate void Delegate1(object object_0, Struct2 struct2_0);

	private delegate void Delegate2(object object_0, Struct2 struct2_0);

	private delegate void Delegate3(Struct2 struct2_0, Struct2 struct2_1);

	private static Hashtable deeacef4 = new Hashtable();

	private static Hashtable hashtable_0 = new Hashtable();

	private static Hashtable hashtable_1 = new Hashtable();

	private static Hashtable hashtable_2 = new Hashtable();

	private static Hashtable hashtable_3 = new Hashtable();

	private static FieldInfo f35b3a7 = typeof(Struct2).GetFields()[0];

	public unsafe static void smethod_0(Struct2 struct2_0, Type type_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)Struct2.smethod_1(struct2_0));
		KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(targetType, type_0);
		object obj = deeacef4[keyValuePair];
		if (obj == null)
		{
			lock (deeacef4)
			{
				obj = deeacef4[keyValuePair];
				if (obj == null)
				{
					obj = smethod_5(targetType, type_0);
					deeacef4[keyValuePair] = obj;
				}
			}
		}
		((f30c9cda)obj)(struct2_0);
	}

	public unsafe static void ed2615e1(void* pVoid_0, Struct2 struct2_0, Type type_0)
	{
		object obj = hashtable_0[type_0];
		if (obj == null)
		{
			lock (hashtable_0)
			{
				obj = hashtable_0[type_0];
				if (obj == null)
				{
					obj = smethod_6(type_0);
					hashtable_0[type_0] = obj;
				}
			}
		}
		((ebdbc671)obj)(pVoid_0, struct2_0);
	}

	public static void smethod_1(object object_0, Struct2 struct2_0)
	{
		smethod_2(object_0, struct2_0, object_0.GetType());
		if (object_0 is Interface2)
		{
			smethod_0(struct2_0, ((Interface2)object_0).imethod_0());
		}
	}

	public static void smethod_2(object object_0, Struct2 struct2_0, Type type_0)
	{
		object obj = hashtable_1[type_0];
		if (obj == null)
		{
			lock (hashtable_1)
			{
				obj = hashtable_1[type_0];
				if (obj == null)
				{
					obj = smethod_7(type_0);
					hashtable_1[type_0] = obj;
				}
			}
		}
		((Delegate1)obj)(object_0, struct2_0);
	}

	public unsafe static void smethod_3(object object_0, Struct2 struct2_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)Struct2.smethod_1(struct2_0));
		object obj = hashtable_2[targetType];
		if (obj == null)
		{
			lock (hashtable_2)
			{
				obj = hashtable_2[targetType];
				if (obj == null)
				{
					obj = eb055ef2(targetType);
					hashtable_2[targetType] = obj;
				}
			}
		}
		((Delegate2)obj)(object_0, struct2_0);
	}

	public unsafe static void smethod_4(fdc40966 fdc40966_0, object object_0, FieldInfo fieldInfo_0, Struct2 struct2_0)
	{
		object obj = hashtable_3[fieldInfo_0];
		if (obj == null)
		{
			lock (hashtable_3)
			{
				obj = hashtable_3[fieldInfo_0];
				if (obj == null)
				{
					obj = smethod_8(fieldInfo_0);
					hashtable_3[fieldInfo_0] = obj;
				}
			}
		}
		TypedReference typedReference = default(TypedReference);
		if (object_0 == null)
		{
			typedReference = default(TypedReference);
		}
		else if (object_0 is Interface1)
		{
			((Interface1)object_0).imethod_0(fdc40966_0, Struct2.smethod_0(&typedReference), fieldInfo_0.DeclaringType);
		}
		else
		{
			typedReference = __makeref(object_0);
			smethod_0(Struct2.smethod_0(&typedReference), object_0.GetType());
		}
		((Delegate3)obj)(Struct2.smethod_0(&typedReference), struct2_0);
	}

	private static f30c9cda smethod_5(Type type_0, Type type_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[1] { typeof(Struct2) }, Class62.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 0);
		iLGenerator.Emit(OpCodes.Ldfld, f35b3a7);
		iLGenerator.Emit(OpCodes.Dup);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_1);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (f30c9cda)dynamicMethod.CreateDelegate(typeof(f30c9cda));
	}

	private unsafe static ebdbc671 smethod_6(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(void*),
			typeof(Struct2)
		}, Class62.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, f35b3a7);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (ebdbc671)dynamicMethod.CreateDelegate(typeof(ebdbc671));
	}

	private static Delegate1 smethod_7(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(Struct2)
		}, Class62.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, f35b3a7);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate1)dynamicMethod.CreateDelegate(typeof(Delegate1));
	}

	private static Delegate2 eb055ef2(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(Struct2)
		}, Class62.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, f35b3a7);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox_Any, type_0);
		iLGenerator.Emit(OpCodes.Stobj, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate2)dynamicMethod.CreateDelegate(typeof(Delegate2));
	}

	private static Delegate3 smethod_8(FieldInfo fieldInfo_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(Struct2),
			typeof(Struct2)
		}, Class62.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		if (fieldInfo_0.IsStatic)
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, f35b3a7);
			iLGenerator.Emit(OpCodes.Ldsflda, fieldInfo_0);
			iLGenerator.Emit(OpCodes.Mkrefany, fieldInfo_0.FieldType);
			iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ret);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, f35b3a7);
			iLGenerator.Emit(OpCodes.Ldarga, 0);
			iLGenerator.Emit(OpCodes.Ldfld, f35b3a7);
			iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Refanyval, fieldInfo_0.DeclaringType);
			if (!fieldInfo_0.DeclaringType!.IsValueType)
			{
				iLGenerator.Emit(OpCodes.Ldobj, fieldInfo_0.DeclaringType);
			}
			iLGenerator.Emit(OpCodes.Ldflda, fieldInfo_0);
			iLGenerator.Emit(OpCodes.Mkrefany, fieldInfo_0.FieldType);
			iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ret);
		}
		return (Delegate3)dynamicMethod.CreateDelegate(typeof(Delegate3));
	}
}
