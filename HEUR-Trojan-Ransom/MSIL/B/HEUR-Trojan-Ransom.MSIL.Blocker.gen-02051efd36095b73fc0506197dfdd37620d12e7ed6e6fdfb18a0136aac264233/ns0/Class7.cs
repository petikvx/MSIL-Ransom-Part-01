namespace ns0;

internal class Class7
{
	public static string smethod_0(string string_0, int int_0, string string_1 = "…")
	{
		string text = Delegate74.smethod_0(string_0);
		int num = Delegate108.smethod_0(text);
		int num2 = Delegate108.smethod_0(string_0);
		string object_ = Delegate78.smethod_0(string_0, Class9.smethod_0(628), num2 - num);
		int num3 = Delegate108.smethod_0(string_1);
		int num4 = num + num3;
		string string_2 = ((Delegate170.smethod_0(string_0, Class10.smethod_0(4147)) > Class9.smethod_0(632)) ? Class10.smethod_0(4147) : Class10.smethod_0(129));
		if (int_0 < num4)
		{
			return Delegate166.smethod_0(string_1, Delegate78.smethod_0(text, Class9.smethod_0(636), int_0 - Class9.smethod_0(640) * num3), string_1);
		}
		if (int_0 == num4)
		{
			return Delegate209.smethod_0(string_1, text);
		}
		return Delegate89.smethod_0(Delegate78.smethod_0(object_, Class9.smethod_0(644), int_0 - (num4 + Class9.smethod_0(648))), string_1, string_2, string_0);
	}
}
