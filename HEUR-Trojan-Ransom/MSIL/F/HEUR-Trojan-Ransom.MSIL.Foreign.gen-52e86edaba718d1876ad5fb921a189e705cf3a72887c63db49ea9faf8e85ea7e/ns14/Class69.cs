using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;
using ns13;
using ns18;
using ns2;
using ns20;
using ns24;

namespace ns14;

internal sealed class Class69 : Class67<Class54>
{
	internal Class71 class71_0;

	private readonly string[] string_0 = new string[2]
	{
		getString_0(107407807),
		getString_0(107407798)
	};

	private readonly string[] string_1 = new string[5]
	{
		getString_0(107408269),
		getString_0(107407798),
		getString_0(107408292),
		getString_0(107408279),
		getString_0(107408234)
	};

	private readonly string[] string_2 = new string[2]
	{
		getString_0(107408257),
		getString_0(107408248)
	};

	private readonly string[] string_3 = new string[28]
	{
		getString_0(107408203),
		getString_0(107408198),
		getString_0(107408217),
		getString_0(107408172),
		getString_0(107408191),
		getString_0(107408146),
		getString_0(107408137),
		getString_0(107408160),
		getString_0(107408151),
		getString_0(107408110),
		getString_0(107408129),
		getString_0(107408084),
		getString_0(107408099),
		getString_0(107408042),
		getString_0(107407505),
		getString_0(107407512),
		getString_0(107407487),
		getString_0(107407434),
		getString_0(107407445),
		getString_0(107407424),
		getString_0(107407371),
		getString_0(107407346),
		getString_0(107407353),
		getString_0(107407312),
		getString_0(107407303),
		getString_0(107407322),
		getString_0(107407277),
		getString_0(107407300)
	};

	[NonSerialized]
	internal static GetString getString_0;

	internal Class69(Class39 class39_0, string string_4, Class43 class43_0)
		: base(class39_0)
	{
		if (!class43_0.dictionary_0.ContainsKey(string_0[0]))
		{
			throw new FormatException(string.Format(Class122.MandatoryFieldNotFound, string_0[0]));
		}
		foreach (KeyValuePair<string, object> item in class43_0.dictionary_0)
		{
			if (!string_0.Contains(item.Key))
			{
				throw new FormatException(string.Format(Class122.UnexpectedField, item.Key));
			}
		}
		if (class43_0.dictionary_0.ContainsKey(string_0[1]))
		{
			string text = class43_0.dictionary_0[string_0[1]].ToString();
			if (!string_2.Contains(text))
			{
				throw new FormatException(string.Format(Class122.InvalidIndexType, text));
			}
		}
		object[] array = class43_0.dictionary_0[string_0[0]] as object[];
		for (int i = 0; i < array.Length; i++)
		{
			Dictionary<string, object> dictionary = array[i] as Dictionary<string, object>;
			if (dictionary.ContainsKey(string_1[0]))
			{
				if (dictionary.ContainsKey(string_1[1]))
				{
					foreach (KeyValuePair<string, object> item2 in dictionary)
					{
						if (!string_1.Contains(item2.Key))
						{
							throw new FormatException(string.Format(Class122.UnexpectedField, item2.Key));
						}
					}
					if (dictionary.ContainsKey(string_1[1]))
					{
						string text2 = dictionary[string_1[1]].ToString();
						if (!method_3(text2))
						{
							throw new FormatException(string.Format(Class122.InvalidFieldType, text2));
						}
					}
					continue;
				}
				throw new FormatException(string.Format(Class122.MandatoryFieldNotFound, string_1[1]));
			}
			throw new FormatException(string.Format(Class122.MandatoryFieldNotFound, string_1[0]));
		}
		class71_0 = new Class71(string_4, class43_0);
	}

	public override Class54 vmethod_0()
	{
		return base.Session.XSession.method_14(this);
	}

	private bool method_3(string string_4)
	{
		if (string_4.StartsWith(getString_0(107407287)))
		{
			return true;
		}
		return string_3.Contains(string_4);
	}

	static Class69()
	{
		Strings.CreateGetStringDelegate(typeof(Class69));
	}
}
