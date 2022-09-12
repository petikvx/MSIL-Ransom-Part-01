using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;

internal class e4935382
{
	private delegate void Delegate0(Array array_0, int int_0, object object_0);

	private static Hashtable hashtable_0 = new Hashtable();

	public static void e44a2829(Array array_0, int int_0, object object_0, Type type_0, Type type_1)
	{
		KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(type_0, type_1);
		object obj = hashtable_0[keyValuePair];
		if (obj == null)
		{
			lock (hashtable_0)
			{
				obj = hashtable_0[keyValuePair];
				if (obj == null)
				{
					obj = b2e1fcf9(type_0, type_1);
					hashtable_0[keyValuePair] = obj;
				}
			}
		}
		((Delegate0)obj)(array_0, int_0, object_0);
	}

	private static Delegate0 b2e1fcf9(Type type_0, Type type_1)
	{
		Type[] parameterTypes = new Type[3]
		{
			typeof(Array),
			typeof(int),
			typeof(object)
		};
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), parameterTypes, Class67.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		if (type_1.IsValueType)
		{
			iLGenerator.Emit(OpCodes.Unbox_Any, type_0);
		}
		iLGenerator.Emit(OpCodes.Stelem, type_1);
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate0)dynamicMethod.CreateDelegate(typeof(Delegate0));
	}
}
