using System;
using System.Reflection;
using p;

namespace ns0;

internal static class Class10
{
	public static MethodBase smethod_0(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, Type[] type_0, ParameterModifier[] parameterModifier_0)
	{
		Type[] array = new Type[type_0.Length];
		for (int i = 0; i < type_0.Length; i++)
		{
			array[i] = type_0[i].UnderlyingSystemType;
		}
		type_0 = array;
		int num = 0;
		for (int j = 0; j < methodBase_0.Length; j++)
		{
			ParameterInfo[] parameters = methodBase_0[j].GetParameters();
			if (parameters.Length != type_0.Length)
			{
				continue;
			}
			int k;
			for (k = 0; k < type_0.Length; k++)
			{
				Type parameterType = parameters[k].ParameterType;
				if (parameterType != type_0[k] && parameterType != typeof(object) && !parameterType.IsPrimitive && !parameterType.IsAssignableFrom(type_0[k]))
				{
					break;
				}
			}
			if (k == type_0.Length)
			{
				methodBase_0[num++] = methodBase_0[j];
			}
		}
		switch (num)
		{
		case 0:
			return null;
		case 1:
			return methodBase_0[0];
		default:
		{
			int num2 = 0;
			int[] array2 = new int[type_0.Length];
			for (int l = 0; l < type_0.Length; l++)
			{
				array2[l] = l;
			}
			for (int m = 1; m < num; m++)
			{
			}
			return methodBase_0[num2];
		}
		}
	}

	static Class10()
	{
		Class8.smethod_0();
		Class1.smethod_0();
	}

	[STAThread]
	public static void Main()
	{
		smethod_1();
	}

	internal static void smethod_1()
	{
		Program.Main();
		char.IsSymbol(0.GetHashCode().ToString(), -1589808012);
	}

	public static Assembly smethod_2(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Class3.smethod_0(resolveEventArgs_0))
		{
			return null;
		}
		return Class7.assembly_0;
	}
}
