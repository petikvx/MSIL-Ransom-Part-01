using System;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Text;
using System.Web;

namespace SEO_BB.Harvester;

public class HTMLReader
{
	public static string GetHTML(WebResponse response)
	{
		string text = string.Empty;
		try
		{
			Stream responseStream = response.GetResponseStream();
			if (((HttpWebResponse)response).ContentEncoding.ToLower().Contains("gzip"))
			{
				responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
				text = new StreamReader(responseStream, Encoding.GetEncoding(1251)).ReadToEnd();
				text = HttpUtility.HtmlDecode(text);
			}
			else if (((HttpWebResponse)response).ContentEncoding.ToLower().Contains("deflate"))
			{
				responseStream = new DeflateStream(responseStream, CompressionMode.Decompress);
				text = new StreamReader(responseStream, Encoding.GetEncoding(1251)).ReadToEnd();
				text = HttpUtility.HtmlDecode(text);
			}
			else
			{
				text = new StreamReader(responseStream, Encoding.GetEncoding(1251)).ReadToEnd();
				text = HttpUtility.HtmlDecode(text);
			}
		}
		catch
		{
		}
		return text;
	}

	public static string GetHTMLHtmlRaw(WebResponse response)
	{
		string result = string.Empty;
		try
		{
			Stream responseStream = response.GetResponseStream();
			if (((HttpWebResponse)response).ContentEncoding.ToLower().Contains("gzip"))
			{
				responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
				result = new StreamReader(responseStream, Encoding.GetEncoding(1251)).ReadToEnd();
			}
			else if (((HttpWebResponse)response).ContentEncoding.ToLower().Contains("deflate"))
			{
				responseStream = new DeflateStream(responseStream, CompressionMode.Decompress);
				result = new StreamReader(responseStream, Encoding.GetEncoding(1251)).ReadToEnd();
			}
			else
			{
				result = new StreamReader(responseStream, Encoding.GetEncoding(1251)).ReadToEnd();
			}
		}
		catch
		{
		}
		return result;
	}

	public static HttpWebRequest GetWebRequest(string url)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		httpWebRequest.ProtocolVersion = HttpVersion.Version11;
		httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
		httpWebRequest.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
		httpWebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.8");
		httpWebRequest.Proxy = WebRequest.GetSystemWebProxy();
		httpWebRequest.Proxy!.Credentials = CredentialCache.DefaultCredentials;
		httpWebRequest.Timeout = 30000;
		return httpWebRequest;
	}

	public static byte[] GetFile(string url)
	{
		HttpWebResponse httpWebResponse = null;
		try
		{
			int num = 0;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/x-silverlight, */*";
				httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; GM_UserLogonTimeUTC: 2008-07-09 14:45:13; GM_UserLogonTimeBias: 240; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
				httpWebRequest.KeepAlive = true;
				httpWebRequest.ConnectionGroupName = Guid.NewGuid().ToString();
				httpWebRequest.ProtocolVersion = HttpVersion.Version11;
				httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
				Stream responseStream = httpWebResponse.GetResponseStream();
				MemoryStream memoryStream = new MemoryStream();
				byte[] array = new byte[8192];
				for (int num2 = responseStream.Read(array, 0, array.Length); num2 > 0; num2 = responseStream.Read(array, 0, array.Length))
				{
					memoryStream.Write(array, 0, num2);
				}
				return memoryStream.ToArray();
			}
			catch (WebException ex)
			{
				if (ex.Status == WebExceptionStatus.NameResolutionFailure || ex.Status == WebExceptionStatus.ConnectFailure)
				{
					return null;
				}
				if (ex.Response is HttpWebResponse httpWebResponse2 && httpWebResponse2.StatusCode == HttpStatusCode.NotFound)
				{
					return null;
				}
				num++;
			}
		}
		finally
		{
			httpWebResponse?.Close();
		}
		return null;
	}

	public static bool ReadBadge(string url)
	{
		try
		{
			HttpWebRequest webRequest = GetWebRequest(url);
			webRequest.AllowAutoRedirect = true;
			webRequest.UserAgent = HtmlUserAgent.userAgent;
			webRequest.ServicePoint.Expect100Continue = false;
			webRequest.Headers.Add("Cache-Control", "max-age=0");
			webRequest.Method = "GET";
			WebResponse response = webRequest.GetResponse();
			string text = string.Empty;
			try
			{
				text = GetHTML(response);
			}
			catch
			{
			}
			finally
			{
				response.Close();
				response.Close();
			}
			return text.ToLower().Contains("socisyd.com");
		}
		catch
		{
		}
		return false;
	}

	public static void BugFix_CookieDomain(CookieContainer cookieContainer)
	{
		Type typeFromHandle = typeof(CookieContainer);
		Hashtable hashtable = (Hashtable)typeFromHandle.InvokeMember("m_domainTable", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField, null, cookieContainer, new object[0]);
		ArrayList arrayList = new ArrayList(hashtable.Keys);
		foreach (string item in arrayList)
		{
			string text2 = item;
			if (text2[0] == '.')
			{
				string key = text2.Remove(0, 1);
				hashtable[key] = hashtable[item];
			}
		}
	}
}
