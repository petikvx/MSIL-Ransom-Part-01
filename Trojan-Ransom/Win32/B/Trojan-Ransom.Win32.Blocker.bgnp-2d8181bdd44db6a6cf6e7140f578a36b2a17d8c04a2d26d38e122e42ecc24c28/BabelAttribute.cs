using System;
using System.Drawing;
using ns0;

public sealed class BabelAttribute : Attribute
{
	public const string Version = "4.0.0.0";

	static BabelAttribute()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
	}

	internal static string smethod_0(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 96:
				return Class26.Class28.smethod_0(object_0, object_1, 540, 621);
			}
		}
	}

	internal static byte smethod_1(ref Color color_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 51:
				return Class26.Class29.smethod_1(ref color_0, 94, 97);
			case 52:
				return Class26.Class29.smethod_1(ref color_0, 477, 413);
			case 53:
				return Class31.Class32.Class33.smethod_0(ref color_0, 535, 611);
			}
		}
	}
}
