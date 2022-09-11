using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;
using ns14;
using ns18;
using ns19;
using ns2;
using ns20;
using ns21;
using ns25;
using ns6;
using ns7;
using ns8;

namespace ns13;

internal class Class39 : Class38
{
	[NonSerialized]
	internal static GetString getString_1;

	internal Class39()
		: base(null, null)
	{
	}

	internal Class39(Class41 class41_1, string string_1)
		: base(class41_1, string_1)
	{
	}

	public Class68 method_0(params object[] object_0)
	{
		if (object_0 == null)
		{
			throw new ArgumentNullException();
		}
		Class68 @class = new Class68(this);
		@class.method_3(object_0);
		return @class;
	}

	public Class65 method_1(string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			throw new ArgumentNullException(getString_1(107408391), Class121.ParameterNullOrEmpty);
		}
		return new Class65(this, string_1);
	}

	public Class65 method_2(object object_0)
	{
		string arg = ((object_0 is string) ? (getString_1(107408346) + object_0.ToString() + getString_1(107408346)) : object_0.ToString());
		string text = string.Format(getString_1(107408341), arg);
		return new Class65(this, text);
	}

	public Class65 method_3(Class43 class43_0)
	{
		if (!class43_0.HasId)
		{
			throw new InvalidOperationException(Class122.RemovingRequiresId);
		}
		return method_2(class43_0.Id);
	}

	public Class54 method_4(object object_0)
	{
		if (object_0 == null)
		{
			throw new ArgumentNullException(getString_1(107408360));
		}
		string text = object_0.ToString();
		if (string.IsNullOrWhiteSpace(text))
		{
			throw new ArgumentNullException(getString_1(107408360), Class121.ParameterNullOrEmpty);
		}
		return method_1(getString_1(107408355)).method_5(getString_1(107408360), (object_0 is string) ? (getString_1(107408346) + text + getString_1(107408346)) : text).vmethod_0();
	}

	public Class64 method_5(string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			throw new ArgumentNullException(getString_1(107408391), Class121.ParameterNullOrEmpty);
		}
		return new Class64(this, string_1);
	}

	public Class54 method_6(object object_0, object object_1)
	{
		if (object_0 == null)
		{
			throw new ArgumentNullException(getString_1(107408360));
		}
		string text = object_0.ToString();
		if (string.IsNullOrWhiteSpace(text))
		{
			throw new ArgumentNullException(getString_1(107408360), Class121.ParameterNullOrEmpty);
		}
		if (object_1 == null)
		{
			throw new ArgumentNullException(getString_1(107408310));
		}
		Class43 @class = method_12(object_0);
		Class64 class2 = method_5(getString_1(107408355)).method_5(getString_1(107408360), text);
		Class43 class3 = ((object_1 is Class43) ? (object_1 as Class43) : new Class43(object_1));
		if (@class != null)
		{
			foreach (KeyValuePair<string, object> item in @class.dictionary_0)
			{
				if (item.Key != getString_1(107408337))
				{
					class2.method_11(item.Key);
				}
			}
		}
		foreach (KeyValuePair<string, object> item2 in class3.dictionary_0)
		{
			if (item2.Key != getString_1(107408337))
			{
				class2.method_9(item2.Key, item2.Value);
			}
		}
		return class2.vmethod_0();
	}

	public Class54 method_7(object object_0, object object_1)
	{
		if (!base.Session.InternalSession.method_5().method_0(8, 0, 3))
		{
			throw new MySqlException(string.Format(Class122.FunctionalityNotSupported, getString_1(107408332)));
		}
		if (object_0 == null)
		{
			throw new ArgumentNullException(getString_1(107408360));
		}
		if (string.IsNullOrWhiteSpace(object_0.ToString()))
		{
			throw new ArgumentNullException(getString_1(107408360), Class121.ParameterNullOrEmpty);
		}
		if (object_1 == null)
		{
			throw new ArgumentNullException(getString_1(107408310));
		}
		Class43 @class = ((object_1 is Class43) ? (object_1 as Class43) : new Class43(object_1));
		@class.Id = object_0;
		Class68 class2 = method_0(@class);
		class2.bool_0 = true;
		return class2.vmethod_0();
	}

	public long method_8()
	{
		return base.Session.XSession.method_16(base.Schema, base.Name);
	}

	public Class63 method_9(string string_1 = null)
	{
		return new Class63(this, string_1);
	}

	public Class69 method_10(string string_1, object object_0)
	{
		return new Class69(this, string_1, new Class43(object_0));
	}

	public void method_11(string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			throw new ArgumentNullException(getString_1(107408323));
		}
		if (Convert.ToInt32(base.Session.XSession.method_4(string.Format(getString_1(107408278), base.Schema.Name, base.Name, string_1))) == 1)
		{
			base.Session.XSession.method_15(base.Schema.Name, base.Name, string_1);
		}
	}

	public override bool vmethod_0()
	{
		return base.Session.XSession.method_17(base.Schema, base.Name);
	}

	public Class43 method_12(object object_0)
	{
		if (object_0 == null)
		{
			throw new ArgumentNullException(getString_1(107408360));
		}
		string text = object_0.ToString();
		if (string.IsNullOrWhiteSpace(text))
		{
			throw new ArgumentNullException(getString_1(107408360), Class121.ParameterNullOrEmpty);
		}
		return method_9(getString_1(107408355)).method_5(getString_1(107408360), (object_0 is string) ? (getString_1(107408346) + text + getString_1(107408346)) : text).vmethod_0().method_4();
	}

	static Class39()
	{
		Strings.CreateGetStringDelegate(typeof(Class39));
	}
}
