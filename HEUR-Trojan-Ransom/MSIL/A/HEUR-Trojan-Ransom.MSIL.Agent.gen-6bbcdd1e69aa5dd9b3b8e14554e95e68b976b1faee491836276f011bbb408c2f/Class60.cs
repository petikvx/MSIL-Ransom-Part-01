using System;
using System.Collections;
using System.Reflection.Emit;

internal class Class60
{
	private static Hashtable d3085d18 = new Hashtable();

	public static int eb24e76(Type type_0)
	{
		object obj = d3085d18[type_0];
		if (obj == null)
		{
			lock (d3085d18)
			{
				obj = d3085d18[type_0];
				if (obj == null)
				{
					obj = b045f35d(type_0);
					d3085d18[type_0] = obj;
				}
			}
		}
		return (int)obj;
	}

	private static int b045f35d(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(int), Type.EmptyTypes, Class62.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Sizeof, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (int)dynamicMethod.Invoke(null, null);
	}
}
