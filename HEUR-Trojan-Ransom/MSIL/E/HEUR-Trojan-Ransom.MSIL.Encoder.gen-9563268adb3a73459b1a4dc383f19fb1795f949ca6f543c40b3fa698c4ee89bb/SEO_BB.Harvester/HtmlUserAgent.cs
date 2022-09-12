namespace SEO_BB.Harvester;

public class HtmlUserAgent
{
	private static int userAgentIndex = 0;

	private static string[] list = new string[5] { "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36", "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2226.0 Safari/537.36", "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2224.3 Safari/537.36", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:29.0) Gecko/20120101 Firefox/29.0" };

	private static string[] listOld = new string[6] { "Mozilla/5.0 (MSIE 7.0; Macintosh; U; SunOS; X11; gu; SV1; InfoPath.2; .NET CLR 3.0.04506.30; .NET CLR 3.0.04506.648)", "Mozilla/5.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; GTB7.4; InfoPath.2; SV1; .NET CLR 3.3.69573; WOW64; en-US)", "Mozilla/5.0 (compatible; MSIE 8.0; Windows NT 6.0; Trident/4.0; InfoPath.1; SV1; .NET CLR 3.8.36217; WOW64; en-US)", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; Media Center PC 6.0; InfoPath.3; MS-RTC LM 8; Zune 4.7", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; chromeframe/12.0.742.112)" };

	public static string userAgent
	{
		get
		{
			if (userAgentIndex >= list.Length)
			{
				userAgentIndex = 0;
			}
			return list[userAgentIndex++];
		}
	}

	public static string userAgentMyspace
	{
		get
		{
			if (userAgentIndex >= 5)
			{
				userAgentIndex = 0;
			}
			return list[userAgentIndex++];
		}
	}

	public static string userAgentOld
	{
		get
		{
			if (userAgentIndex >= listOld.Length)
			{
				userAgentIndex = 0;
			}
			return listOld[userAgentIndex++];
		}
	}
}
