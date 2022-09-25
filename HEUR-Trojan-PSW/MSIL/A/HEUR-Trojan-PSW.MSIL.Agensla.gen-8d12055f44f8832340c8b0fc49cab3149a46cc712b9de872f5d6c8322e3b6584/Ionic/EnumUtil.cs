using System;
using System.ComponentModel;

namespace Ionic;

internal sealed class EnumUtil
{
	private EnumUtil()
	{
	}

	internal static string GetDescription(Enum value)
	{
		DescriptionAttribute[] array = (DescriptionAttribute[])value.GetType().GetField(value.ToString())!.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
		if (array.Length != 0)
		{
			return array[0].Description;
		}
		return value.ToString();
	}

	internal static object Parse(Type enumType, string stringRepresentation)
	{
		return Parse(enumType, stringRepresentation, ignoreCase: false);
	}

	internal static object Parse(Type enumType, string stringRepresentation, bool ignoreCase)
	{
		if (ignoreCase)
		{
			stringRepresentation = stringRepresentation.ToLower();
		}
		foreach (Enum value in Enum.GetValues(enumType))
		{
			string text = GetDescription(value);
			if (ignoreCase)
			{
				text = text.ToLower();
			}
			if (text == stringRepresentation)
			{
				return value;
			}
		}
		return Enum.Parse(enumType, stringRepresentation, ignoreCase);
	}
}
