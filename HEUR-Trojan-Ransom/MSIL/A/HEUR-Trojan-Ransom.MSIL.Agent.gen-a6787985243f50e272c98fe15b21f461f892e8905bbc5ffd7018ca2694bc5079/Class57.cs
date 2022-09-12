using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

internal static class Class57
{
	private delegate void Delegate2(Struct1 struct1_0);

	private unsafe delegate void Delegate3(void* pVoid_0, Struct1 struct1_0);

	private delegate void a722dce1(object object_0, Struct1 struct1_0);

	private delegate void Delegate4(object object_0, Struct1 struct1_0);

	private delegate void acecd5bb(Struct1 struct1_0, Struct1 struct1_1);

	private static Hashtable d9c13a19 = new Hashtable();

	private static Hashtable f4d5dca4 = new Hashtable();

	private static Hashtable hashtable_0 = new Hashtable();

	private static Hashtable c3a9c176 = new Hashtable();

	private static Hashtable b3a8ca5d = new Hashtable();

	private static FieldInfo fieldInfo_0 = typeof(Struct1).GetFields()[0];

	public unsafe static void c271ba87(Struct1 struct1_0, Type type_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)Struct1.d9a770c4(struct1_0));
		KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(targetType, type_0);
		object obj = d9c13a19[keyValuePair];
		if (obj == null)
		{
			lock (d9c13a19)
			{
				obj = d9c13a19[keyValuePair];
				if (obj == null)
				{
					obj = smethod_3(targetType, type_0);
					d9c13a19[keyValuePair] = obj;
				}
			}
		}
		((Delegate2)obj)(struct1_0);
	}

	public unsafe static void a3b6363a(void* pVoid_0, Struct1 struct1_0, Type type_0)
	{
		object obj = f4d5dca4[type_0];
		if (obj == null)
		{
			lock (f4d5dca4)
			{
				obj = f4d5dca4[type_0];
				if (obj == null)
				{
					obj = smethod_4(type_0);
					f4d5dca4[type_0] = obj;
				}
			}
		}
		((Delegate3)obj)(pVoid_0, struct1_0);
	}

	public static void smethod_0(object object_0, Struct1 struct1_0)
	{
		smethod_1(object_0, struct1_0, object_0.GetType());
		if (object_0 is Interface2)
		{
			c271ba87(struct1_0, ((Interface2)object_0).ea5d1f1f());
		}
	}

	public static void smethod_1(object object_0, Struct1 struct1_0, Type type_0)
	{
		object obj = hashtable_0[type_0];
		if (obj == null)
		{
			lock (hashtable_0)
			{
				obj = hashtable_0[type_0];
				if (obj == null)
				{
					obj = smethod_5(type_0);
					hashtable_0[type_0] = obj;
				}
			}
		}
		((a722dce1)obj)(object_0, struct1_0);
	}

	public unsafe static void e8c6cd7c(object object_0, Struct1 struct1_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)Struct1.d9a770c4(struct1_0));
		object obj = c3a9c176[targetType];
		if (obj == null)
		{
			lock (c3a9c176)
			{
				obj = c3a9c176[targetType];
				if (obj == null)
				{
					obj = ecc16b0f(targetType);
					c3a9c176[targetType] = obj;
				}
			}
		}
		((Delegate4)obj)(object_0, struct1_0);
	}

	public unsafe static void smethod_2(Class52 class52_0, object object_0, FieldInfo fieldInfo_1, Struct1 struct1_0)
	{
		object obj = b3a8ca5d[fieldInfo_1];
		if (obj == null)
		{
			lock (b3a8ca5d)
			{
				obj = b3a8ca5d[fieldInfo_1];
				if (obj == null)
				{
					obj = c7605d22(fieldInfo_1);
					b3a8ca5d[fieldInfo_1] = obj;
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
			((Interface1)object_0).imethod_1(class52_0, Struct1.d9a770c4(&typedReference), fieldInfo_1.DeclaringType);
		}
		else
		{
			typedReference = __makeref(object_0);
			c271ba87(Struct1.d9a770c4(&typedReference), object_0.GetType());
		}
		((acecd5bb)obj)(Struct1.d9a770c4(&typedReference), struct1_0);
	}

	private static Delegate2 smethod_3(Type type_0, Type type_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[1] { typeof(Struct1) }, Class58.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 0);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Dup);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_1);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate2)dynamicMethod.CreateDelegate(typeof(Delegate2));
	}

	private unsafe static Delegate3 smethod_4(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(void*),
			typeof(Struct1)
		}, Class58.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate3)dynamicMethod.CreateDelegate(typeof(Delegate3));
	}

	private static a722dce1 smethod_5(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(Struct1)
		}, Class58.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (a722dce1)dynamicMethod.CreateDelegate(typeof(a722dce1));
	}

	private static Delegate4 ecc16b0f(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(Struct1)
		}, Class58.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox_Any, type_0);
		iLGenerator.Emit(OpCodes.Stobj, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate4)dynamicMethod.CreateDelegate(typeof(Delegate4));
	}

	private static acecd5bb c7605d22(FieldInfo fieldInfo_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(Struct1),
			typeof(Struct1)
		}, Class58.module_0, skipVisibility: true);
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
		return (acecd5bb)dynamicMethod.CreateDelegate(typeof(acecd5bb));
	}
}
