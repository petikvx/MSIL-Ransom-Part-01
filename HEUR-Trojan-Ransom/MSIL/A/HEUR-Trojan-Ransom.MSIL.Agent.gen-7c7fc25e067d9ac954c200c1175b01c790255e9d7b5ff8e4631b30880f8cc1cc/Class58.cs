using System;
using System.Collections;
using System.Reflection.Emit;

internal class Class58
{
	private static Hashtable hashtable_0 = new Hashtable();

	public static int d7440f03(Type type_0)
	{
		object obj = hashtable_0[type_0];
		if (obj == null)
		{
			lock (hashtable_0)
			{
				obj = hashtable_0[type_0];
				if (obj == null)
				{
					obj = c029e886(type_0);
					hashtable_0[type_0] = obj;
				}
			}
		}
		return (int)obj;
	}

	private static int c029e886(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(int), Type.EmptyTypes, df300be.d69fb105, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Sizeof, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (int)dynamicMethod.Invoke(null, null);
	}
}
