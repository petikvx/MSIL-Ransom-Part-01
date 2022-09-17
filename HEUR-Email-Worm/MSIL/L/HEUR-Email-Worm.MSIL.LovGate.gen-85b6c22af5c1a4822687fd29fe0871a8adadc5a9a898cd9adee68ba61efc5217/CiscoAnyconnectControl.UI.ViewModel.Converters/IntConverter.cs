using System;
using System.ComponentModel;
using System.Globalization;

namespace CiscoAnyconnectControl.UI.ViewModel.Converters;

internal class IntConverter : TypeConverter
{
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		int result = 0;
		if (!(value is string))
		{
			if (value is int)
			{
				result = (int)value;
			}
		}
		else if (!int.TryParse((string)value, out result))
		{
			throw IntConverter.smethod_0();
		}
		return result;
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return IntConverter.smethod_2(sourceType, IntConverter.smethod_1(typeof(string).TypeHandle)) || IntConverter.smethod_2(sourceType, IntConverter.smethod_1(typeof(int).TypeHandle));
	}

	static NotSupportedException smethod_0()
	{
		return new NotSupportedException();
	}

	static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static bool smethod_2(Type type_0, Type type_1)
	{
		return type_0 == type_1;
	}
}
