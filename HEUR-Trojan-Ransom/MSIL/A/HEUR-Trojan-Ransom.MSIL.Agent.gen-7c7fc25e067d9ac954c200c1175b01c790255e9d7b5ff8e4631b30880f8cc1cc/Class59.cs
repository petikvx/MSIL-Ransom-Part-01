using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

internal static class Class59
{
	private delegate void Delegate3(Struct1 struct1_0);

	private unsafe delegate void Delegate4(void* pVoid_0, Struct1 struct1_0);

	private delegate void f547241(object object_0, Struct1 struct1_0);

	private delegate void d197a6ac(object object_0, Struct1 struct1_0);

	private delegate void Delegate5(Struct1 struct1_0, Struct1 struct1_1);

	private static Hashtable b505a379 = new Hashtable();

	private static Hashtable a3ab7684 = new Hashtable();

	private static Hashtable hashtable_0 = new Hashtable();

	private static Hashtable baf8d656 = new Hashtable();

	private static Hashtable cede19bd = new Hashtable();

	private static FieldInfo bf6c8ff8 = typeof(Struct1).GetFields()[0];

	public unsafe static void smethod_0(Struct1 struct1_0, Type type_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)Struct1.smethod_1(struct1_0));
		KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(targetType, type_0);
		object obj = b505a379[keyValuePair];
		if (obj == null)
		{
			lock (b505a379)
			{
				obj = b505a379[keyValuePair];
				if (obj == null)
				{
					obj = smethod_2(targetType, type_0);
					b505a379[keyValuePair] = obj;
				}
			}
		}
		((Delegate3)obj)(struct1_0);
	}

	public unsafe static void f0dcf11a(void* pVoid_0, Struct1 struct1_0, Type type_0)
	{
		object obj = a3ab7684[type_0];
		if (obj == null)
		{
			lock (a3ab7684)
			{
				obj = a3ab7684[type_0];
				if (obj == null)
				{
					obj = smethod_3(type_0);
					a3ab7684[type_0] = obj;
				}
			}
		}
		((Delegate4)obj)(pVoid_0, struct1_0);
	}

	public static void b418db1(object object_0, Struct1 struct1_0)
	{
		b418db1(object_0, struct1_0, object_0.GetType());
		if (object_0 is c8feea0)
		{
			smethod_0(struct1_0, ((c8feea0)object_0).imethod_1());
		}
	}

	public static void b418db1(object object_0, Struct1 struct1_0, Type type_0)
	{
		object obj = hashtable_0[type_0];
		if (obj == null)
		{
			lock (hashtable_0)
			{
				obj = hashtable_0[type_0];
				if (obj == null)
				{
					obj = bbf66650(type_0);
					hashtable_0[type_0] = obj;
				}
			}
		}
		((f547241)obj)(object_0, struct1_0);
	}

	public unsafe static void c380ab5c(object object_0, Struct1 struct1_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)Struct1.smethod_1(struct1_0));
		object obj = baf8d656[targetType];
		if (obj == null)
		{
			lock (baf8d656)
			{
				obj = baf8d656[targetType];
				if (obj == null)
				{
					obj = f286056f(targetType);
					baf8d656[targetType] = obj;
				}
			}
		}
		((d197a6ac)obj)(object_0, struct1_0);
	}

	public unsafe static void smethod_1(Class54 class54_0, object object_0, FieldInfo fieldInfo_0, Struct1 struct1_0)
	{
		object obj = cede19bd[fieldInfo_0];
		if (obj == null)
		{
			lock (cede19bd)
			{
				obj = cede19bd[fieldInfo_0];
				if (obj == null)
				{
					obj = smethod_4(fieldInfo_0);
					cede19bd[fieldInfo_0] = obj;
				}
			}
		}
		TypedReference typedReference = default(TypedReference);
		if (object_0 == null)
		{
			typedReference = default(TypedReference);
		}
		else if (object_0 is Interface2)
		{
			((Interface2)object_0).imethod_3(class54_0, Struct1.smethod_0(&typedReference), fieldInfo_0.DeclaringType);
		}
		else
		{
			typedReference = __makeref(object_0);
			smethod_0(Struct1.smethod_0(&typedReference), object_0.GetType());
		}
		((Delegate5)obj)(Struct1.smethod_0(&typedReference), struct1_0);
	}

	private static Delegate3 smethod_2(Type type_0, Type type_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[1] { typeof(Struct1) }, df300be.d69fb105, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 0);
		iLGenerator.Emit(OpCodes.Ldfld, bf6c8ff8);
		iLGenerator.Emit(OpCodes.Dup);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_1);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate3)dynamicMethod.CreateDelegate(typeof(Delegate3));
	}

	private unsafe static Delegate4 smethod_3(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(void*),
			typeof(Struct1)
		}, df300be.d69fb105, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, bf6c8ff8);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate4)dynamicMethod.CreateDelegate(typeof(Delegate4));
	}

	private static f547241 bbf66650(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(Struct1)
		}, df300be.d69fb105, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, bf6c8ff8);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (f547241)dynamicMethod.CreateDelegate(typeof(f547241));
	}

	private static d197a6ac f286056f(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(Struct1)
		}, df300be.d69fb105, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, bf6c8ff8);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox_Any, type_0);
		iLGenerator.Emit(OpCodes.Stobj, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (d197a6ac)dynamicMethod.CreateDelegate(typeof(d197a6ac));
	}

	private static Delegate5 smethod_4(FieldInfo fieldInfo_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(Struct1),
			typeof(Struct1)
		}, df300be.d69fb105, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		if (fieldInfo_0.IsStatic)
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, bf6c8ff8);
			iLGenerator.Emit(OpCodes.Ldsflda, fieldInfo_0);
			iLGenerator.Emit(OpCodes.Mkrefany, fieldInfo_0.FieldType);
			iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ret);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, bf6c8ff8);
			iLGenerator.Emit(OpCodes.Ldarga, 0);
			iLGenerator.Emit(OpCodes.Ldfld, bf6c8ff8);
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
		return (Delegate5)dynamicMethod.CreateDelegate(typeof(Delegate5));
	}
}
