using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

internal class Class25
{
	public static void smethod_0(string[] string_0)
	{
		try
		{
			string text = Delegate59.smethod_5((string)_003CModule_003E.smethod_0(3913163461u));
			string[] array = Delegate77.smethod_0(text, new char[1] { ':' });
			string text2 = array[0];
			string string_ = array[1];
			if (!Delegate63.smethod_0(text, ""))
			{
				return;
			}
			bool flag = false;
			string text3 = "";
			foreach (string text4 in string_0)
			{
				if (Delegate60.smethod_1(text4, (string)_003CModule_003E.smethod_0(3913163509u)))
				{
					flag = true;
				}
				if (Delegate60.smethod_2(text4, (string)_003CModule_003E.smethod_0(3913163509u)))
				{
					flag = false;
					text3 = Delegate71.smethod_0(text3, text4);
				}
				if (flag)
				{
					text3 = Delegate72.smethod_0(text3, text4, (string)_003CModule_003E.smethod_0(3913166209u));
				}
			}
			text3 = Delegate165.smethod_0(text3, (string)_003CModule_003E.smethod_0(3913163509u), "");
			Delegate236.smethod_1(text3, new char[1] { ' ' });
			if (Delegate63.smethod_0(text3, "") && Delegate294.smethod_0(text2, string_, text3))
			{
				Delegate64.smethod_3(Delegate80.smethod_0(new string[5]
				{
					(string)_003CModule_003E.smethod_0(3913163503u),
					Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3913166209u), text2)),
					(string)_003CModule_003E.smethod_0(3913166267u),
					Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3913166209u), text3)),
					(string)_003CModule_003E.smethod_0(3913166288u)
				}), Delegate70.smethod_4());
			}
		}
		catch
		{
		}
	}

	public static bool smethod_1(string string_0, string string_1, string string_2)
	{
		CookieContainer cookieContainer_ = Delegate295.smethod_0();
		string text = Delegate296.smethod_0((string)_003CModule_003E.smethod_0(217994302u), ref cookieContainer_);
		string text2 = "";
		int num = Delegate297.smethod_0(text, (string)_003CModule_003E.smethod_0(217994251u));
		if (num > -1)
		{
			Regex object_ = Delegate298.smethod_0((string)_003CModule_003E.smethod_0(217992174u));
			Match object_2 = Delegate299.smethod_0(object_, text);
			if (Delegate300.smethod_0(object_2))
			{
				string text3 = Delegate303.smethod_0(Delegate302.smethod_0(Delegate301.smethod_0(object_2), 1));
				text2 = text3;
			}
		}
		Delegate304.smethod_0((string)_003CModule_003E.smethod_0(217992114u), Delegate80.smethod_0(new string[6]
		{
			(string)_003CModule_003E.smethod_0(217992090u),
			text2,
			(string)_003CModule_003E.smethod_0(217992050u),
			string_0,
			(string)_003CModule_003E.smethod_0(217992035u),
			string_1
		}), ref cookieContainer_, (string)_003CModule_003E.smethod_0(217994302u));
		string object_3 = Delegate296.smethod_0((string)_003CModule_003E.smethod_0(217992044u), ref cookieContainer_);
		if (Delegate60.smethod_0(object_3, (string)_003CModule_003E.smethod_0(217992012u)))
		{
			Delegate304.smethod_0((string)_003CModule_003E.smethod_0(217992044u), Delegate80.smethod_0(new string[5]
			{
				(string)_003CModule_003E.smethod_0(217992090u),
				text2,
				(string)_003CModule_003E.smethod_0(217991999u),
				Delegate59.smethod_6(string_2),
				(string)_003CModule_003E.smethod_0(217991953u)
			}), ref cookieContainer_, (string)_003CModule_003E.smethod_0(217991852u));
			return true;
		}
		return false;
	}

	private static string smethod_2(string string_0, string string_1, ref CookieContainer cookieContainer_0, string string_2)
	{
		try
		{
			HttpWebRequest object_ = (HttpWebRequest)Delegate305.smethod_0(string_0);
			Delegate306.smethod_0(object_, bool_0: true);
			Delegate307.smethod_0(object_, HttpVersion.Version11);
			Delegate308.smethod_0(object_, (string)_003CModule_003E.smethod_0(583559653u));
			Delegate309.smethod_0(object_, (string)_003CModule_003E.smethod_0(583564119u));
			Delegate309.smethod_1(object_, string_2);
			if (cookieContainer_0 != null)
			{
				Delegate310.smethod_0(object_, cookieContainer_0);
			}
			byte[] array = Delegate101.smethod_0(Delegate100.smethod_2(), string_1);
			Delegate308.smethod_1(object_, (string)_003CModule_003E.smethod_0(583564260u));
			Delegate311.smethod_0(object_, array.Length);
			Stream object_2 = Delegate312.smethod_0(object_);
			Delegate251.smethod_0(object_2, array, 0, array.Length);
			Delegate164.smethod_0(object_2);
			HttpWebResponse object_3 = (HttpWebResponse)Delegate313.smethod_0(object_);
			return Delegate235.smethod_1(Delegate231.smethod_0(Delegate314.smethod_0(object_3)));
		}
		catch (Exception object_4)
		{
			return Delegate183.smethod_0(object_4);
		}
	}

	private static string smethod_3(string string_0, ref CookieContainer cookieContainer_0)
	{
		string result = string.Empty;
		try
		{
			HttpWebRequest object_ = (HttpWebRequest)Delegate305.smethod_0(string_0);
			Delegate308.smethod_0(object_, (string)_003CModule_003E.smethod_0(4220384971u));
			Delegate306.smethod_0(object_, bool_0: true);
			Delegate309.smethod_0(object_, (string)_003CModule_003E.smethod_0(4220384890u));
			Delegate316.smethod_0(Delegate315.smethod_0(object_), bool_0: false);
			if (cookieContainer_0 != null)
			{
				Delegate310.smethod_0(object_, cookieContainer_0);
			}
			using (HttpWebResponse object_2 = Delegate313.smethod_0(object_) as HttpWebResponse)
			{
				if (cookieContainer_0 != null)
				{
					Delegate318.smethod_0(cookieContainer_0, Delegate317.smethod_0(object_2));
				}
				using Stream stream_ = Delegate314.smethod_0(object_2);
				using StreamReader object_3 = Delegate231.smethod_0(stream_);
				result = Delegate235.smethod_1(object_3);
			}
			return result;
		}
		catch
		{
			return result;
		}
	}
}
