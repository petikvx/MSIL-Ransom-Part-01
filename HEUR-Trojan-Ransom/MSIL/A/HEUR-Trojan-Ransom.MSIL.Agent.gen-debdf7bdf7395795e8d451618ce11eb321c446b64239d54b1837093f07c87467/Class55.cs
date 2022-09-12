using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

internal static class Class55
{
	private delegate void Delegate2(fe387972 fe387972_0);

	private unsafe delegate void a94f4087(void* pVoid_0, fe387972 fe387972_0);

	private delegate void b65a043a(object object_0, fe387972 fe387972_0);

	private delegate void c65a4651(object object_0, fe387972 fe387972_0);

	private delegate void Delegate3(fe387972 fe387972_0, fe387972 fe387972_1);

	private static Hashtable hashtable_0 = new Hashtable();

	private static Hashtable hashtable_1 = new Hashtable();

	private static Hashtable cf9c4154 = new Hashtable();

	private static Hashtable hashtable_2 = new Hashtable();

	private static Hashtable hashtable_3 = new Hashtable();

	private static FieldInfo cf4044cd = typeof(fe387972).GetFields()[0];

	public unsafe static void dae92d78(fe387972 fe387972_0, Type type_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)fe387972.smethod_1(fe387972_0));
		KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(targetType, type_0);
		object obj = hashtable_0[keyValuePair];
		if (obj == null)
		{
			lock (hashtable_0)
			{
				obj = hashtable_0[keyValuePair];
				if (obj == null)
				{
					obj = smethod_3(targetType, type_0);
					hashtable_0[keyValuePair] = obj;
				}
			}
		}
		((Delegate2)obj)(fe387972_0);
	}

	public unsafe static void b31c1277(void* pVoid_0, fe387972 fe387972_0, Type type_0)
	{
		object obj = hashtable_1[type_0];
		if (obj == null)
		{
			lock (hashtable_1)
			{
				obj = hashtable_1[type_0];
				if (obj == null)
				{
					obj = b64fd23e(type_0);
					hashtable_1[type_0] = obj;
				}
			}
		}
		((a94f4087)obj)(pVoid_0, fe387972_0);
	}

	public static void smethod_0(object object_0, fe387972 fe387972_0)
	{
		smethod_1(object_0, fe387972_0, object_0.GetType());
		if (object_0 is Interface1)
		{
			dae92d78(fe387972_0, ((Interface1)object_0).imethod_1());
		}
	}

	public static void smethod_1(object object_0, fe387972 fe387972_0, Type type_0)
	{
		object obj = cf9c4154[type_0];
		if (obj == null)
		{
			lock (cf9c4154)
			{
				obj = cf9c4154[type_0];
				if (obj == null)
				{
					obj = d44f5485(type_0);
					cf9c4154[type_0] = obj;
				}
			}
		}
		((b65a043a)obj)(object_0, fe387972_0);
	}

	public unsafe static void smethod_2(object object_0, fe387972 fe387972_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)fe387972.smethod_1(fe387972_0));
		object obj = hashtable_2[targetType];
		if (obj == null)
		{
			lock (hashtable_2)
			{
				obj = hashtable_2[targetType];
				if (obj == null)
				{
					obj = e1203c20(targetType);
					hashtable_2[targetType] = obj;
				}
			}
		}
		((c65a4651)obj)(object_0, fe387972_0);
	}

	public unsafe static void c6cb5c2c(Class49 class49_0, object object_0, FieldInfo fieldInfo_0, fe387972 fe387972_0)
	{
		object obj = hashtable_3[fieldInfo_0];
		if (obj == null)
		{
			lock (hashtable_3)
			{
				obj = hashtable_3[fieldInfo_0];
				if (obj == null)
				{
					obj = smethod_4(fieldInfo_0);
					hashtable_3[fieldInfo_0] = obj;
				}
			}
		}
		TypedReference typedReference = default(TypedReference);
		if (object_0 == null)
		{
			typedReference = default(TypedReference);
		}
		else if (object_0 is da5e0024)
		{
			((da5e0024)object_0).c4cba08f(class49_0, fe387972.smethod_0(&typedReference), fieldInfo_0.DeclaringType);
		}
		else
		{
			typedReference = __makeref(object_0);
			dae92d78(fe387972.smethod_0(&typedReference), object_0.GetType());
		}
		((Delegate3)obj)(fe387972.smethod_0(&typedReference), fe387972_0);
	}

	private static Delegate2 smethod_3(Type type_0, Type type_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[1] { typeof(fe387972) }, Class56.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 0);
		iLGenerator.Emit(OpCodes.Ldfld, cf4044cd);
		iLGenerator.Emit(OpCodes.Dup);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_1);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate2)dynamicMethod.CreateDelegate(typeof(Delegate2));
	}

	private unsafe static a94f4087 b64fd23e(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(void*),
			typeof(fe387972)
		}, Class56.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, cf4044cd);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (a94f4087)dynamicMethod.CreateDelegate(typeof(a94f4087));
	}

	private static b65a043a d44f5485(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(fe387972)
		}, Class56.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, cf4044cd);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (b65a043a)dynamicMethod.CreateDelegate(typeof(b65a043a));
	}

	private static c65a4651 e1203c20(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(fe387972)
		}, Class56.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, cf4044cd);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox_Any, type_0);
		iLGenerator.Emit(OpCodes.Stobj, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (c65a4651)dynamicMethod.CreateDelegate(typeof(c65a4651));
	}

	private static Delegate3 smethod_4(FieldInfo fieldInfo_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(fe387972),
			typeof(fe387972)
		}, Class56.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		if (fieldInfo_0.IsStatic)
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, cf4044cd);
			iLGenerator.Emit(OpCodes.Ldsflda, fieldInfo_0);
			iLGenerator.Emit(OpCodes.Mkrefany, fieldInfo_0.FieldType);
			iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ret);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, cf4044cd);
			iLGenerator.Emit(OpCodes.Ldarga, 0);
			iLGenerator.Emit(OpCodes.Ldfld, cf4044cd);
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
