using System;
using System.IO;
using System.Net;

public class GClass13
{
	public static bool smethod_0(CookieContainer cookieContainer_0)
	{
		HttpWebResponse httpWebResponse = null;
		StreamReader streamReader = null;
		HttpWebRequest httpWebRequest = null;
		try
		{
			httpWebRequest = (HttpWebRequest)WebRequest.Create("http://steamcommunity.com");
			httpWebRequest.Method = "GET";
			httpWebRequest.Headers["Origin"] = "http://steamcommunity.com";
			httpWebRequest.Referer = "http://steamcommunity.com";
			httpWebRequest.Headers["Accept-Encoding"] = "gzip,deflate";
			httpWebRequest.Headers["Accept-Language"] = "en-us,en";
			httpWebRequest.Headers["Accept-Charset"] = "iso-8859-1,*,utf-8";
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.3; en-US; Valve Steam Client/1393366296; ) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.166 Safari/535.19";
			httpWebRequest.CookieContainer = cookieContainer_0;
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
			httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				streamReader.ReadToEnd();
				if (!streamReader.ReadToEnd().Contains("g_steamID = false;") && httpWebResponse.Cookies["sessionid"] != null)
				{
					return true;
				}
				return false;
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			streamReader?.Close();
			httpWebResponse?.Close();
		}
		return false;
	}

	public static string smethod_1(CookieContainer cookieContainer_0, string string_0, string string_1 = null, string string_2 = "")
	{
		HttpWebResponse httpWebResponse = null;
		StreamReader streamReader = null;
		HttpWebRequest httpWebRequest = null;
		try
		{
			httpWebRequest = null;
			httpWebRequest = ((!string_0.StartsWith("http")) ? ((HttpWebRequest)WebRequest.Create("http" + ((string_1 != null) ? "s" : "") + "://steamcommunity.com/" + string_0)) : ((HttpWebRequest)WebRequest.Create(string_0)));
			httpWebRequest.Referer = "http://steamcommunity.com/" + string_2;
			httpWebRequest.Accept = ((string_1 != null) ? "*/*" : "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
			httpWebRequest.Method = ((string_1 != null) ? "POST" : "GET");
			if (string_1 != null)
			{
				httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
			}
			httpWebRequest.Headers["Accept-Charset"] = "iso-8859-1,*,utf-8";
			httpWebRequest.Headers["Origin"] = "https://steamcommunity.com";
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.3; en-US; Valve Steam Client/1393366296; ) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.166 Safari/535.19";
			httpWebRequest.Headers["Accept-Language"] = "en-us,en";
			httpWebRequest.Headers["Accept-Encoding"] = "gzip,deflate";
			httpWebRequest.CookieContainer = cookieContainer_0;
			httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			if (string_1 != null)
			{
				using StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
				streamWriter.Write(string_1);
			}
			httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				return streamReader.ReadToEnd();
			}
		}
		catch (WebException ex)
		{
			if (ex.Response != null)
			{
				HttpWebResponse httpWebResponse2 = (HttpWebResponse)ex.Response;
				return new StreamReader(httpWebResponse2.GetResponseStream()).ReadToEnd();
			}
		}
		finally
		{
			streamReader?.Close();
			httpWebResponse?.Close();
		}
		return null;
	}
}
