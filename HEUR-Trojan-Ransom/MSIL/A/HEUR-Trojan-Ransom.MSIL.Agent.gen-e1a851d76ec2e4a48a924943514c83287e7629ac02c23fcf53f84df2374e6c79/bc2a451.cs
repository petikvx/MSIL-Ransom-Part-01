using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

internal static class bc2a451
{
	private delegate void a71b94cc(f06aee96 f06aee96_0);

	private unsafe delegate void Delegate3(void* pVoid_0, f06aee96 f06aee96_0);

	private delegate void Delegate4(object object_0, f06aee96 f06aee96_0);

	private delegate void ad689a5(object object_0, f06aee96 f06aee96_0);

	private delegate void b548aec0(f06aee96 f06aee96_0, f06aee96 f06aee96_1);

	private static Hashtable ad4aa576 = new Hashtable();

	private static Hashtable efac5e5d = new Hashtable();

	private static Hashtable hashtable_0 = new Hashtable();

	private static Hashtable hashtable_1 = new Hashtable();

	private static Hashtable hashtable_2 = new Hashtable();

	private static FieldInfo d3b5b0e1 = typeof(f06aee96).GetFields()[0];

	public unsafe static void smethod_0(f06aee96 f06aee96_0, Type type_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)f06aee96.smethod_1(f06aee96_0));
		KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(targetType, type_0);
		object obj = ad4aa576[keyValuePair];
		if (obj == null)
		{
			lock (ad4aa576)
			{
				obj = ad4aa576[keyValuePair];
				if (obj == null)
				{
					obj = smethod_6(targetType, type_0);
					ad4aa576[keyValuePair] = obj;
				}
			}
		}
		((a71b94cc)obj)(f06aee96_0);
	}

	public unsafe static void smethod_1(void* pVoid_0, f06aee96 f06aee96_0, Type type_0)
	{
		object obj = efac5e5d[type_0];
		if (obj == null)
		{
			lock (efac5e5d)
			{
				obj = efac5e5d[type_0];
				if (obj == null)
				{
					obj = smethod_7(type_0);
					efac5e5d[type_0] = obj;
				}
			}
		}
		((Delegate3)obj)(pVoid_0, f06aee96_0);
	}

	public static void smethod_2(object object_0, f06aee96 f06aee96_0)
	{
		smethod_3(object_0, f06aee96_0, object_0.GetType());
		if (object_0 is Interface2)
		{
			smethod_0(f06aee96_0, ((Interface2)object_0).imethod_1());
		}
	}

	public static void smethod_3(object object_0, f06aee96 f06aee96_0, Type type_0)
	{
		object obj = hashtable_0[type_0];
		if (obj == null)
		{
			lock (hashtable_0)
			{
				obj = hashtable_0[type_0];
				if (obj == null)
				{
					obj = smethod_8(type_0);
					hashtable_0[type_0] = obj;
				}
			}
		}
		((Delegate4)obj)(object_0, f06aee96_0);
	}

	public unsafe static void smethod_4(object object_0, f06aee96 f06aee96_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)f06aee96.smethod_1(f06aee96_0));
		object obj = hashtable_1[targetType];
		if (obj == null)
		{
			lock (hashtable_1)
			{
				obj = hashtable_1[targetType];
				if (obj == null)
				{
					obj = smethod_9(targetType);
					hashtable_1[targetType] = obj;
				}
			}
		}
		((ad689a5)obj)(object_0, f06aee96_0);
	}

	public unsafe static void smethod_5(Class62 class62_0, object object_0, FieldInfo fieldInfo_0, f06aee96 f06aee96_0)
	{
		object obj = hashtable_2[fieldInfo_0];
		if (obj == null)
		{
			lock (hashtable_2)
			{
				obj = hashtable_2[fieldInfo_0];
				if (obj == null)
				{
					obj = smethod_10(fieldInfo_0);
					hashtable_2[fieldInfo_0] = obj;
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
			((Interface1)object_0).imethod_3(class62_0, f06aee96.smethod_0(&typedReference), fieldInfo_0.DeclaringType);
		}
		else
		{
			typedReference = __makeref(object_0);
			smethod_0(f06aee96.smethod_0(&typedReference), object_0.GetType());
		}
		((b548aec0)obj)(f06aee96.smethod_0(&typedReference), f06aee96_0);
	}

	private static a71b94cc smethod_6(Type type_0, Type type_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[1] { typeof(f06aee96) }, Class67.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 0);
		iLGenerator.Emit(OpCodes.Ldfld, d3b5b0e1);
		iLGenerator.Emit(OpCodes.Dup);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_1);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (a71b94cc)dynamicMethod.CreateDelegate(typeof(a71b94cc));
	}

	private unsafe static Delegate3 smethod_7(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(void*),
			typeof(f06aee96)
		}, Class67.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, d3b5b0e1);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate3)dynamicMethod.CreateDelegate(typeof(Delegate3));
	}

	private static Delegate4 smethod_8(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(f06aee96)
		}, Class67.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, d3b5b0e1);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate4)dynamicMethod.CreateDelegate(typeof(Delegate4));
	}

	private static ad689a5 smethod_9(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(f06aee96)
		}, Class67.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, d3b5b0e1);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox_Any, type_0);
		iLGenerator.Emit(OpCodes.Stobj, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (ad689a5)dynamicMethod.CreateDelegate(typeof(ad689a5));
	}

	private static b548aec0 smethod_10(FieldInfo fieldInfo_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(f06aee96),
			typeof(f06aee96)
		}, Class67.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		if (fieldInfo_0.IsStatic)
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, d3b5b0e1);
			iLGenerator.Emit(OpCodes.Ldsflda, fieldInfo_0);
			iLGenerator.Emit(OpCodes.Mkrefany, fieldInfo_0.FieldType);
			iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ret);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, d3b5b0e1);
			iLGenerator.Emit(OpCodes.Ldarga, 0);
			iLGenerator.Emit(OpCodes.Ldfld, d3b5b0e1);
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
		return (b548aec0)dynamicMethod.CreateDelegate(typeof(b548aec0));
	}
}
