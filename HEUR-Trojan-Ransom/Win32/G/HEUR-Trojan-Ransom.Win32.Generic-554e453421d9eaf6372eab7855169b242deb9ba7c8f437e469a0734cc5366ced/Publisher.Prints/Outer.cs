using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
using NewtonsoftJson.Json;
using Publisher.Utility;

namespace Publisher.Prints;

internal class Outer
{
	public static string CallServer(string url)
	{
		qgO3XeZrR1D9KvSCtTR();
		if (!VyFATFZx19qlo9WAlH7())
		{
			goto IL_001e;
		}
		string text = null;
		WebClient object_ = new WebClient();
		DateTime dateTime_ = ruGRbyZvYA5MJFcDnLq();
		goto IL_0039;
		IL_0039:
		if (Erj9p2ZWlbacqQ16Xq7(EfnBjNZBeV1n795uMw9(ruGRbyZvYA5MJFcDnLq(), dateTime_), RjWHFeZytPsbIYjvTjK(2.0)))
		{
			goto IL_001e;
		}
		goto IL_005b;
		IL_001e:
		if (vhSUC7Z5V55GZUWoXMY(text))
		{
			try
			{
				text = (string)F0EtOPZtTTWH51D3tqC(object_, url);
			}
			catch (Exception)
			{
				text = null;
			}
			goto IL_0039;
		}
		goto IL_005b;
		IL_005b:
		return text;
	}

	internal static List<Pub> GetData(string data)
	{
		data = Cryptor.decrypt(data);
		data = Regex.Replace(data, "[^\\u0009^\\u000A^\\u000D^\\u0020-\\u007E]", "");
		data = data.Replace("&lt;", "<");
		data = data.Replace("&gt;", ">");
		data = data.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", "");
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(data);
		string text = JsonConvert.SerializeXmlNode((XmlNode)xmlDocument, (Formatting)1, true);
		AdsList adsList = JsonConvert.DeserializeObject<AdsList>(text);
		return adsList.ListInformation.pub;
	}

	public Outer()
	{
		ax0xK6ZAbHI55dxs8XH(this);
	}

	internal static DateTime ruGRbyZvYA5MJFcDnLq()
	{
		return DateTime.UtcNow;
	}

	internal static object F0EtOPZtTTWH51D3tqC(object object_0, object object_1)
	{
		return ((WebClient)object_0).DownloadString((string)object_1);
	}

	internal static TimeSpan EfnBjNZBeV1n795uMw9(DateTime dateTime_0, DateTime dateTime_1)
	{
		return dateTime_0 - dateTime_1;
	}

	internal static TimeSpan RjWHFeZytPsbIYjvTjK(double double_0)
	{
		return TimeSpan.FromMinutes(double_0);
	}

	internal static bool Erj9p2ZWlbacqQ16Xq7(TimeSpan timeSpan_0, TimeSpan timeSpan_1)
	{
		return timeSpan_0 < timeSpan_1;
	}

	internal static bool vhSUC7Z5V55GZUWoXMY(object object_0)
	{
		return string.IsNullOrEmpty((string?)object_0);
	}

	internal static bool VyFATFZx19qlo9WAlH7()
	{
		return true;
	}

	internal static bool qgO3XeZrR1D9KvSCtTR()
	{
		return false;
	}

	internal static void ax0xK6ZAbHI55dxs8XH(object object_0)
	{
		object_0._002Ector();
	}
}
