using System;
using System.Reflection;
using System.Security;

namespace ns0;

internal sealed class Class2
{
	internal delegate void Delegate0();

	public static byte[] byte_0;

	public static Type type_0;

	[SecuritySafeCritical]
	static Class2()
	{
		byte_0 = Class1.smethod_2("ØÎQ%○¦\u0090\u008dkv0µô\u0081Ta");
		type_0 = Assembly.Load(Class4.smethod_1()).GetType(Class4.smethod_0());
	}

	public static MethodBase smethod_0(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, Type[] type_1, ParameterModifier[] parameterModifier_0)
	{
		Type[] array = new Type[type_1.Length];
		for (int i = 0; i < type_1.Length; i++)
		{
			array[i] = type_1[i].UnderlyingSystemType;
		}
		type_1 = array;
		int num = 0;
		for (int j = 0; j < methodBase_0.Length; j++)
		{
			ParameterInfo[] parameters = methodBase_0[j].GetParameters();
			if (parameters.Length != type_1.Length)
			{
				continue;
			}
			int k;
			for (k = 0; k < type_1.Length; k++)
			{
				Type parameterType = parameters[k].ParameterType;
				if (parameterType != type_1[k] && parameterType != typeof(object) && !parameterType.IsPrimitive && !parameterType.IsAssignableFrom(type_1[k]))
				{
					break;
				}
			}
			if (k == type_1.Length)
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
			int[] array2 = new int[type_1.Length];
			for (int l = 0; l < type_1.Length; l++)
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

	internal static void smethod_1()
	{
		((Delegate0)Delegate.CreateDelegate(typeof(Delegate0), type_0, type_0.GetMethods()[1].Name))();
	}

	public static PropertyInfo smethod_2(BindingFlags bindingFlags_0, PropertyInfo[] propertyInfo_0, Type type_1, Type[] type_2, ParameterModifier[] parameterModifier_0)
	{
		int i = 0;
		int num = 0;
		int num2 = ((type_2 != null) ? type_2.Length : 0);
		for (int j = 0; j < propertyInfo_0.Length; j++)
		{
			if (type_2 != null)
			{
				ParameterInfo[] indexParameters = propertyInfo_0[j].GetIndexParameters();
				if (indexParameters.Length != num2)
				{
					continue;
				}
				for (i = 0; i < num2; i++)
				{
					Type parameterType = indexParameters[i].ParameterType;
					if (parameterType != type_2[i] && parameterType != typeof(object) && !parameterType.IsPrimitive && !parameterType.IsAssignableFrom(type_2[i]))
					{
						break;
					}
				}
			}
			if (i == num2 && (!(type_1 != null) || propertyInfo_0[j].PropertyType.IsPrimitive || propertyInfo_0[j].PropertyType.IsAssignableFrom(type_1)))
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
