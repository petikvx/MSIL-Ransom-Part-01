using System;
using System.ComponentModel;

internal sealed class Class8
{
	private Class8()
	{
	}

	internal static string smethod_0(Enum enum_0)
	{
		DescriptionAttribute[] array = (DescriptionAttribute[])enum_0.GetType().GetField(enum_0.ToString())!.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
		if (array.Length != 0)
		{
			return array[0].Description;
		}
		return enum_0.ToString();
	}

	internal static object smethod_1(Type type_0, string string_0)
	{
		return smethod_2(type_0, string_0, bool_0: false);
	}

	internal static object smethod_2(Type type_0, string string_0, bool bool_0)
	{
		if (bool_0)
		{
			string_0 = string_0.ToLower();
		}
		foreach (Enum value in Enum.GetValues(type_0))
		{
			string text = smethod_0(value);
			if (bool_0)
			{
				text = text.ToLower();
			}
			if (text == string_0)
			{
				return value;
			}
		}
		return Enum.Parse(type_0, string_0, bool_0);
	}
}
