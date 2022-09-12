using System;
using System.Text;

namespace ns0;

internal class Class14
{
	protected string string_0;

	public int int_0 = Class9.smethod_0(844);

	private readonly Class3 class3_0;

	public string string_1 = Class10.smethod_0(5055);

	public Class14()
	{
		class3_0 = new Class3();
	}

	public void method_0()
	{
		string text = class3_0.method_11("", Class3.string_2);
		if (Delegate22.smethod_0(text, Class10.smethod_0(49)))
		{
			method_2();
			method_0();
		}
		else
		{
			string_0 = Class17.smethod_1(text);
		}
	}

	public string method_1()
	{
		return string_0;
	}

	private void method_2()
	{
		class3_0.method_7("", Class3.string_2, Class17.smethod_0(method_3()));
	}

	private string method_3()
	{
		StringBuilder object_ = Delegate45.smethod_0();
		Random object_2 = Delegate14.smethod_0();
		while (true)
		{
			int num = Class9.smethod_0(836);
			int num2 = int_0;
			int_0 = num2 - Class9.smethod_0(840);
			if (num >= num2)
			{
				break;
			}
			char c = Delegate70.smethod_0(string_1, Delegate53.smethod_0(object_2, Delegate108.smethod_0(string_1)));
			if (Delegate32.smethod_0(c))
			{
				c = ((((Delegate53.smethod_0(object_2, Class9.smethod_0(820)) <= Class9.smethod_0(824)) ? Class9.smethod_0(832) : Class9.smethod_0(828)) != 0) ? Delegate197.smethod_0(c) : c);
			}
			Delegate19.smethod_0(object_, c);
		}
		return Delegate204.smethod_0(object_);
	}
}
