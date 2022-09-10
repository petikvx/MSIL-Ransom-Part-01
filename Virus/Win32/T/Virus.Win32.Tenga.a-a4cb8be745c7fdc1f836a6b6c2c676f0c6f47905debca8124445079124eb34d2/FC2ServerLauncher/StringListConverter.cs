using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace FC2ServerLauncher;

public class StringListConverter : TypeConverter
{
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		List<string> list = (List<string>)value;
		string text = "";
		bool flag = true;
		foreach (string item in list)
		{
			if (!flag)
			{
				text += ", ";
			}
			text += item;
			flag = false;
		}
		return text;
	}
}
