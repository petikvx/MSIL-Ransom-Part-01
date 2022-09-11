using System;

namespace ns0;

internal sealed class Class7
{
	public static Type type_0;

	private static void smethod_0(Type type_1, out bool bool_0, out bool bool_1)
	{
		AttributeUsageAttribute[] array = (AttributeUsageAttribute[])type_1.GetCustomAttributes(typeof(AttributeUsageAttribute), inherit: false);
		if (array.Length == 0)
		{
			bool_0 = true;
			bool_1 = false;
			return;
		}
		if (array.Length != 1)
		{
			throw new FormatException(new object[1] { type_1.ToString() }.ToString());
		}
		AttributeUsageAttribute attributeUsageAttribute = array[0];
		bool_0 = attributeUsageAttribute.Inherited;
		bool_1 = attributeUsageAttribute.AllowMultiple;
	}

	static Class7()
	{
		type_0 = Class2.smethod_1().GetType("swety.Program");
	}
}
