using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

internal static class Class63
{
	private delegate void Delegate1(Struct0 struct0_0);

	private unsafe delegate void Delegate2(void* pVoid_0, Struct0 struct0_0);

	private delegate void Delegate3(object object_0, Struct0 struct0_0);

	private delegate void ce09226c(object object_0, Struct0 struct0_0);

	private delegate void b328badb(Struct0 struct0_0, Struct0 struct0_1);

	private static Hashtable cde78639 = new Hashtable();

	private static Hashtable c3c7a44 = new Hashtable();

	private static Hashtable e4dc40d3 = new Hashtable();

	private static Hashtable f20d5016 = new Hashtable();

	private static Hashtable a72ac87d = new Hashtable();

	private static FieldInfo fieldInfo_0 = typeof(Struct0).GetFields()[0];

	public unsafe static void smethod_0(Struct0 struct0_0, Type type_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)Struct0.smethod_1(struct0_0));
		KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(targetType, type_0);
		object obj = cde78639[keyValuePair];
		if (obj == null)
		{
			lock (cde78639)
			{
				obj = cde78639[keyValuePair];
				if (obj == null)
				{
					obj = smethod_3(targetType, type_0);
					cde78639[keyValuePair] = obj;
				}
			}
		}
		((Delegate1)obj)(struct0_0);
	}

	public unsafe static void smethod_1(void* pVoid_0, Struct0 struct0_0, Type type_0)
	{
		object obj = c3c7a44[type_0];
		if (obj == null)
		{
			lock (c3c7a44)
			{
				obj = c3c7a44[type_0];
				if (obj == null)
				{
					obj = a4f02235(type_0);
					c3c7a44[type_0] = obj;
				}
			}
		}
		((Delegate2)obj)(pVoid_0, struct0_0);
	}

	public static void a1521871(object object_0, Struct0 struct0_0)
	{
		a1521871(object_0, struct0_0, object_0.GetType());
		if (object_0 is ad414660)
		{
			smethod_0(struct0_0, ((ad414660)object_0).ea29c63f());
		}
	}

	public static void a1521871(object object_0, Struct0 struct0_0, Type type_0)
	{
		object obj = e4dc40d3[type_0];
		if (obj == null)
		{
			lock (e4dc40d3)
			{
				obj = e4dc40d3[type_0];
				if (obj == null)
				{
					obj = a16ece10(type_0);
					e4dc40d3[type_0] = obj;
				}
			}
		}
		((Delegate3)obj)(object_0, struct0_0);
	}

	public unsafe static void smethod_2(object object_0, Struct0 struct0_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)Struct0.smethod_1(struct0_0));
		object obj = f20d5016[targetType];
		if (obj == null)
		{
			lock (f20d5016)
			{
				obj = f20d5016[targetType];
				if (obj == null)
				{
					obj = b4b9ca2f(targetType);
					f20d5016[targetType] = obj;
				}
			}
		}
		((ce09226c)obj)(object_0, struct0_0);
	}

	public unsafe static void c702e7cb(Class58 class58_0, object object_0, FieldInfo fieldInfo_1, Struct0 struct0_0)
	{
		object obj = a72ac87d[fieldInfo_1];
		if (obj == null)
		{
			lock (a72ac87d)
			{
				obj = a72ac87d[fieldInfo_1];
				if (obj == null)
				{
					obj = smethod_4(fieldInfo_1);
					a72ac87d[fieldInfo_1] = obj;
				}
			}
		}
		TypedReference typedReference = default(TypedReference);
		if (object_0 == null)
		{
			typedReference = default(TypedReference);
		}
		else if (object_0 is Interface0)
		{
			((Interface0)object_0).imethod_0(class58_0, Struct0.smethod_0(&typedReference), fieldInfo_1.DeclaringType);
		}
		else
		{
			typedReference = __makeref(object_0);
			smethod_0(Struct0.smethod_0(&typedReference), object_0.GetType());
		}
		((b328badb)obj)(Struct0.smethod_0(&typedReference), struct0_0);
	}

	private static Delegate1 smethod_3(Type type_0, Type type_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[1] { typeof(Struct0) }, cf56b27e.bd4237c5, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 0);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Dup);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_1);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate1)dynamicMethod.CreateDelegate(typeof(Delegate1));
	}

	private unsafe static Delegate2 a4f02235(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(void*),
			typeof(Struct0)
		}, cf56b27e.bd4237c5, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate2)dynamicMethod.CreateDelegate(typeof(Delegate2));
	}

	private static Delegate3 a16ece10(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(Struct0)
		}, cf56b27e.bd4237c5, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate3)dynamicMethod.CreateDelegate(typeof(Delegate3));
	}

	private static ce09226c b4b9ca2f(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(Struct0)
		}, cf56b27e.bd4237c5, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox_Any, type_0);
		iLGenerator.Emit(OpCodes.Stobj, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (ce09226c)dynamicMethod.CreateDelegate(typeof(ce09226c));
	}

	private static b328badb smethod_4(FieldInfo fieldInfo_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(Struct0),
			typeof(Struct0)
		}, cf56b27e.bd4237c5, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		if (fieldInfo_1.IsStatic)
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
			iLGenerator.Emit(OpCodes.Ldsflda, fieldInfo_1);
			iLGenerator.Emit(OpCodes.Mkrefany, fieldInfo_1.FieldType);
			iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ret);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
			iLGenerator.Emit(OpCodes.Ldarga, 0);
			iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
			iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Refanyval, fieldInfo_1.DeclaringType);
			if (!fieldInfo_1.DeclaringType!.IsValueType)
			{
				iLGenerator.Emit(OpCodes.Ldobj, fieldInfo_1.DeclaringType);
			}
			iLGenerator.Emit(OpCodes.Ldflda, fieldInfo_1);
			iLGenerator.Emit(OpCodes.Mkrefany, fieldInfo_1.FieldType);
			iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ret);
		}
		return (b328badb)dynamicMethod.CreateDelegate(typeof(b328badb));
	}
}
