using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace ns0;

internal class Class3
{
	public static string string_0 = Class10.smethod_0(270);

	public static string string_1 = Class10.smethod_0(281);

	public static string string_2 = Class10.smethod_0(294);

	private readonly string string_3 = Class10.smethod_0(231);

	public List<string> method_0(string string_4)
	{
		RegistryKey object_ = Delegate165.smethod_0(Registry.CurrentUser, Delegate166.smethod_0(string_3, Class10.smethod_0(129), string_4));
		try
		{
			List<string> list = Delegate25.smethod_0(Delegate217.smethod_0(object_));
			if (Delegate146.smethod_0(list) == 0)
			{
				List<string> list2 = Delegate113.smethod_0();
				Delegate4.smethod_0(list2, Class10.smethod_0(22));
				return list2;
			}
			return list;
		}
		catch (NullReferenceException)
		{
			List<string> list3 = Delegate113.smethod_0();
			Delegate4.smethod_0(list3, Class10.smethod_0(22));
			return list3;
		}
	}

	public void method_1()
	{
		Delegate35.smethod_0(Registry.CurrentUser, string_3);
	}

	public void method_2(string string_4)
	{
		Delegate35.smethod_0(Registry.CurrentUser, Delegate166.smethod_0(string_3, Class10.smethod_0(129), string_4));
	}

	public void method_3(string string_4)
	{
		Delegate20.smethod_0(Registry.CurrentUser, Delegate166.smethod_0(string_3, Class10.smethod_0(129), string_4));
	}

	public void method_4()
	{
		Delegate37.smethod_0(Registry.CurrentUser, string_3);
	}

	public void method_5(string string_4, string string_5, bool bool_0)
	{
		Delegate172.smethod_0(Delegate35.smethod_0(Registry.CurrentUser, Delegate166.smethod_0(string_3, Class10.smethod_0(129), string_4)), string_5, bool_0 ? Class9.smethod_0(16) : Class9.smethod_0(12));
	}

	public void method_6(string string_4, string string_5)
	{
		Delegate211.smethod_0(Delegate35.smethod_0(Registry.CurrentUser, Delegate166.smethod_0(string_3, Class10.smethod_0(129), string_4)), string_5);
	}

	public void method_7(string string_4, string string_5, string string_6)
	{
		Delegate172.smethod_0(Delegate35.smethod_0(Registry.CurrentUser, Delegate166.smethod_0(string_3, Class10.smethod_0(129), string_4)), string_5, string_6);
	}

	public void method_8(string string_4, string string_5, string string_6)
	{
		RegistryKey object_ = Delegate35.smethod_0(Registry.CurrentUser, Class10.smethod_0(132));
		if (Delegate22.smethod_0(string_6, ""))
		{
			Delegate172.smethod_0(object_, string_4, Delegate166.smethod_0(Class10.smethod_0(223), string_5, Class10.smethod_0(223)));
		}
		else
		{
			Delegate172.smethod_0(object_, string_4, Delegate89.smethod_0(Class10.smethod_0(223), string_5, Class10.smethod_0(226), string_6));
		}
	}

	public string method_9(string string_4)
	{
		RegistryKey object_ = Delegate165.smethod_0(Registry.CurrentUser, Class10.smethod_0(132));
		try
		{
			return Delegate204.smethod_0(Delegate97.smethod_0(object_, string_4));
		}
		catch (Exception)
		{
			return Class10.smethod_0(49);
		}
	}

	public void method_10(string string_4)
	{
		try
		{
			Delegate211.smethod_0(Delegate35.smethod_0(Registry.CurrentUser, Class10.smethod_0(132)), string_4);
		}
		catch (Exception)
		{
		}
	}

	public string method_11(string string_4, string string_5)
	{
		RegistryKey object_ = Delegate165.smethod_0(Registry.CurrentUser, Delegate166.smethod_0(string_3, Class10.smethod_0(129), string_4));
		try
		{
			return Delegate204.smethod_0(Delegate97.smethod_0(object_, string_5));
		}
		catch (Exception)
		{
			return Class10.smethod_0(49);
		}
	}

	public bool method_12(string string_4, string string_5)
	{
		RegistryKey object_ = Delegate165.smethod_0(Registry.CurrentUser, Delegate166.smethod_0(string_3, Class10.smethod_0(129), string_4));
		try
		{
			return (byte)(((int)Delegate97.smethod_0(object_, string_5) == Class9.smethod_0(20)) ? Class9.smethod_0(28) : Class9.smethod_0(24)) != 0;
		}
		catch (NullReferenceException)
		{
			return (byte)Class9.smethod_0(32) != 0;
		}
	}
}
