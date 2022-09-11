using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class1
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 573)]
	private struct Struct0
	{
	}

	internal static byte byte_0/* Not supported: data(00) */;

	private static bool bool_0;

	public static byte[] smethod_0(byte[] byte_1, byte[] byte_2)
	{
		Class3.smethod_0(byte_1, byte_2);
		return byte_1;
	}

	public static MethodBase smethod_1(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, Type[] type_0, ParameterModifier[] parameterModifier_0)
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

	public static byte[] smethod_2(string string_0)
	{
		byte[] result = new byte[string_0.Length * 2];
		Class3.smethod_1(string_0, result);
		return result;
	}

	public static PropertyInfo smethod_3(BindingFlags bindingFlags_0, PropertyInfo[] propertyInfo_0, Type type_0, Type[] type_1, ParameterModifier[] parameterModifier_0)
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
}
