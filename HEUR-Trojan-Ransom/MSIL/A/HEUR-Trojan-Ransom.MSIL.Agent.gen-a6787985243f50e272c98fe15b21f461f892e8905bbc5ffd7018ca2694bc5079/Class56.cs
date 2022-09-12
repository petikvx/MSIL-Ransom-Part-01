using System;
using System.Collections;
using System.Reflection.Emit;

internal class Class56
{
	private static Hashtable hashtable_0 = new Hashtable();

	public static int smethod_0(Type type_0)
	{
		object obj = hashtable_0[type_0];
		if (obj == null)
		{
			lock (hashtable_0)
			{
				obj = hashtable_0[type_0];
				if (obj == null)
				{
					obj = fb258ba6(type_0);
					hashtable_0[type_0] = obj;
				}
			}
		}
		return (int)obj;
	}

	private static int fb258ba6(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(int), Type.EmptyTypes, Class58.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Sizeof, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (int)dynamicMethod.Invoke(null, null);
	}
}
