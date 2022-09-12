using System;
using System.Collections;
using System.Reflection.Emit;

internal class Class54
{
	private static Hashtable bcc177d6 = new Hashtable();

	public static int smethod_0(Type type_0)
	{
		object obj = bcc177d6[type_0];
		if (obj == null)
		{
			lock (bcc177d6)
			{
				obj = bcc177d6[type_0];
				if (obj == null)
				{
					obj = smethod_1(type_0);
					bcc177d6[type_0] = obj;
				}
			}
		}
		return (int)obj;
	}

	private static int smethod_1(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(int), Type.EmptyTypes, Class56.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Sizeof, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (int)dynamicMethod.Invoke(null, null);
	}
}
