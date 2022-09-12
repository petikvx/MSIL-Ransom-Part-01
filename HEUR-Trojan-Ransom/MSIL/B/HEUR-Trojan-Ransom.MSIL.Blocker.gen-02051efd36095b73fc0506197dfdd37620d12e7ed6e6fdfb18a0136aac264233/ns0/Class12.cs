using System;
using System.Collections.Generic;

namespace ns0;

internal class Class12
{
	public static List<string> list_0;

	private string string_0;

	static Class12()
	{
		List<string> object_ = Delegate113.smethod_0();
		Delegate4.smethod_0(object_, Delegate26.smethod_0(Delegate96.smethod_0(Class10.smethod_0(4150))));
		Delegate4.smethod_0(object_, Delegate26.smethod_0(Delegate96.smethod_0(Class10.smethod_0(4163))));
		Delegate4.smethod_0(object_, Delegate26.smethod_0(Delegate96.smethod_0(Class10.smethod_0(299))));
		Delegate4.smethod_0(object_, Delegate26.smethod_0(Delegate96.smethod_0(Class10.smethod_0(4186))));
		Delegate4.smethod_0(object_, Delegate26.smethod_0(Delegate209.smethod_0(Delegate96.smethod_0(Class10.smethod_0(4211)), Class10.smethod_0(4234))));
		Delegate4.smethod_0(object_, Delegate26.smethod_0(Delegate96.smethod_0(Class10.smethod_0(4263))));
		Delegate4.smethod_0(object_, Delegate26.smethod_0(Delegate96.smethod_0(Class10.smethod_0(4272))));
		Delegate4.smethod_0(object_, Delegate26.smethod_0(Delegate209.smethod_0(Delegate96.smethod_0(Class10.smethod_0(4211)), Class10.smethod_0(4279))));
		Delegate4.smethod_0(object_, Class10.smethod_0(4320));
		list_0 = object_;
	}

	public void method_0(string string_1)
	{
		string_0 = string_1;
	}

	public void method_1()
	{
		Class16 @class = new Class16();
		try
		{
			string[] array = Delegate11.smethod_0(string_0);
			for (int i = Class9.smethod_0(680); i < array.Length; i += Class9.smethod_0(684))
			{
				string string_ = array[i];
				@class.method_0(string_);
				@class.method_3();
				if (@class.method_6())
				{
					@class.method_1();
					@class.method_2();
				}
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (Exception)
		{
		}
	}

	public static List<string> smethod_0(string string_1)
	{
		Stack<string> object_ = Delegate158.smethod_0();
		List<string> list = Delegate113.smethod_0();
		Delegate30.smethod_0(object_, string_1);
		while (Delegate230.smethod_0(object_) > Class9.smethod_0(696))
		{
			string object_2 = Delegate231.smethod_0(object_);
			try
			{
				if (!Delegate155.smethod_0(list_0, Delegate26.smethod_0(object_2)))
				{
					Delegate4.smethod_0(list, object_2);
					string[] array = Delegate66.smethod_0(object_2);
					for (int i = Class9.smethod_0(688); i < array.Length; i += Class9.smethod_0(692))
					{
						string text = array[i];
						Delegate30.smethod_0(object_, text);
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}
}
