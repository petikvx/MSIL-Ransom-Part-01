using System;
using System.IO;
using System.Net;
using System.Text;

public class clsWWW : MarshalByRefObject
{
	public const bool debug = false;

	public string Useragent = null;

	public string Referrer = null;

	public string Proxy = null;

	private string AcceptExts = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";

	private string AcceptLanguage = "en-us,en;q=0.5";

	public CookieContainer cJar = new CookieContainer();

	private static Random rnd = new Random(Environment.TickCount);

	private static DecompressionMethods _autodecomp = DecompressionMethods.GZip | DecompressionMethods.Deflate;

	private string[] userAgents = new string[3] { "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.0.3) Gecko/2008092417 Firefox/3.0.3", "Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US; rv:1.8.1.11) Gecko/20071127 Firefox/2.0.0.11)", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.0.4) Gecko/2008102920 Firefox/3.0.4)" };

	private string randomFromArray(string[] obj)
	{
		string result = null;
		lock (obj)
		{
			int num = rnd.Next(0, obj.Length);
			result = obj[num];
		}
		return result;
	}

	public string getFullHttp(string url)
	{
		if (url == null)
		{
			return null;
		}
		if (Useragent == null)
		{
			Useragent = randomFromArray(userAgents);
		}
		url = url.Replace("&amp;", "&");
		StringBuilder stringBuilder = new StringBuilder();
		ServicePointManager.Expect100Continue = false;
		try
		{
			Uri requestUri = new Uri(url);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
			if (Proxy != null)
			{
				httpWebRequest.Proxy = new WebProxy("http://" + Proxy);
				httpWebRequest.Timeout = 3000000;
			}
			else
			{
				httpWebRequest.Proxy = null;
				httpWebRequest.Timeout = 55000;
			}
			httpWebRequest.Headers.Add("Accept-Language: " + AcceptLanguage);
			httpWebRequest.Accept = AcceptExts;
			httpWebRequest.CookieContainer = cJar;
			httpWebRequest.UserAgent = Useragent;
			httpWebRequest.KeepAlive = false;
			httpWebRequest.AutomaticDecompression = _autodecomp;
			httpWebRequest.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Referer = Referrer;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			WebHeaderCollection headers = httpWebResponse.Headers;
			stringBuilder.AppendLine(headers.ToString());
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
			stringBuilder.AppendLine(streamReader.ReadToEnd());
			httpWebResponse.Close();
		}
		catch (Exception)
		{
		}
		return stringBuilder.ToString();
	}

	public string postFullHttp(string url, string postdata)
	{
		if (Useragent == null)
		{
			Useragent = randomFromArray(userAgents);
		}
		if (url == null)
		{
			return null;
		}
		url = url.Replace("&amp;", "&");
		StringBuilder stringBuilder = new StringBuilder();
		ServicePointManager.Expect100Continue = false;
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(postdata);
			Uri requestUri = new Uri(url);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
			if (Proxy != null)
			{
				httpWebRequest.Proxy = new WebProxy("http://" + Proxy);
				httpWebRequest.Timeout = 300000;
			}
			else
			{
				httpWebRequest.Proxy = null;
				httpWebRequest.Timeout = 45000;
			}
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			httpWebRequest.CookieContainer = cJar;
			httpWebRequest.Referer = Referrer;
			httpWebRequest.UserAgent = Useragent;
			httpWebRequest.Accept = AcceptExts;
			httpWebRequest.Headers.Add("Accept-Language: " + AcceptLanguage);
			httpWebRequest.AllowAutoRedirect = true;
			httpWebRequest.AutomaticDecompression = _autodecomp;
			httpWebRequest.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
			httpWebRequest.KeepAlive = true;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			WebHeaderCollection headers = httpWebResponse.Headers;
			stringBuilder.AppendLine(headers.ToString());
			stringBuilder.AppendLine(streamReader.ReadToEnd());
			httpWebResponse.Close();
		}
		catch (Exception)
		{
		}
		return stringBuilder.ToString();
	}

	public string postFullHttp(string url, byte[] postDataBytes, string boundary)
	{
		if (url == null)
		{
			return null;
		}
		if (Useragent == null)
		{
			Useragent = randomFromArray(userAgents);
		}
		url = url.Replace("&amp;", "&");
		StringBuilder stringBuilder = new StringBuilder();
		ServicePointManager.Expect100Continue = false;
		try
		{
			Uri requestUri = new Uri(url);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
			if (Proxy != null)
			{
				httpWebRequest.Proxy = new WebProxy("http://" + Proxy);
				httpWebRequest.Timeout = 300000;
			}
			else
			{
				httpWebRequest.Timeout = 45000;
			}
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "multipart/form-data; boundary=" + boundary;
			httpWebRequest.ContentLength = postDataBytes.Length;
			httpWebRequest.KeepAlive = false;
			httpWebRequest.CookieContainer = cJar;
			httpWebRequest.Referer = Referrer;
			httpWebRequest.UserAgent = Useragent;
			httpWebRequest.Accept = AcceptExts;
			httpWebRequest.AutomaticDecompression = _autodecomp;
			httpWebRequest.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
			httpWebRequest.KeepAlive = true;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(postDataBytes, 0, postDataBytes.Length);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			WebHeaderCollection headers = httpWebResponse.Headers;
			stringBuilder.AppendLine(headers.ToString());
			stringBuilder.AppendLine(streamReader.ReadToEnd());
			httpWebResponse.Close();
		}
		catch (Exception)
		{
		}
		return stringBuilder.ToString();
	}

	public bool getFileHttp(string url, string localfile)
	{
		if (Useragent == null)
		{
			Useragent = randomFromArray(userAgents);
		}
		WebClient webClient = new WebClient();
		if (Proxy != null)
		{
			webClient.Proxy = new WebProxy("http://" + Proxy);
		}
		webClient.Headers.Add("Accept: " + AcceptExts);
		webClient.Headers.Add("Accept-Language: " + AcceptLanguage);
		webClient.Headers.Add("User-Agent: " + Useragent);
		webClient.Headers.Add("Cache-Control: max-age=0");
		string cookieHeader = cJar.GetCookieHeader(new Uri(url));
		webClient.Headers.Add("Cookie: " + cookieHeader);
		for (int i = 0; i < 5; i++)
		{
			try
			{
				webClient.DownloadFile(url, localfile);
			}
			catch (Exception)
			{
				continue;
			}
			break;
		}
		webClient.Dispose();
		webClient = null;
		return true;
	}

	public string parseBetween(string basestring, string string1, string string2, int offset)
	{
		if (basestring == null)
		{
			return null;
		}
		if (basestring.Contains(string1))
		{
			string text = basestring.Substring(basestring.IndexOf(string1) + offset);
			if (text.Contains(string2) && string2 != "")
			{
				text = text.Substring(0, text.IndexOf(string2));
			}
			return text;
		}
		return null;
	}

	public string parseBetweenRev(string basestring, string string1, string string2, int offset)
	{
		if (basestring == null)
		{
			return null;
		}
		if (basestring.Contains(string1))
		{
			basestring.IndexOf(string1);
			string text = basestring.Substring(0, basestring.IndexOf(string1));
			if (text.Contains(string2) && string2 != "")
			{
				return text.Substring(text.LastIndexOf(string2) + offset);
			}
			return text;
		}
		return null;
	}

	public string parseForms(string resp)
	{
		if (resp == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		string text = resp;
		while (text.Contains("<input "))
		{
			string basestring = parseBetween(text, "name=\"", ">", 0);
			string text2 = parseBetween(basestring, "name=\"", "\"", 6);
			string text3 = parseBetween(basestring, "value=\"", "\"", 7);
			stringBuilder.Append(text2 + "=" + text3 + "&");
			text = text.Substring(text.IndexOf("name=") + 6);
		}
		if (stringBuilder.Length > 1)
		{
			stringBuilder.Remove(stringBuilder.Length - 1, 1);
		}
		return stringBuilder.ToString();
	}

	public string parseForms(string resp, bool mustHaveValue)
	{
		if (resp == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		string text = resp;
		while (text.Contains("<input "))
		{
			string basestring = parseBetween(text, "name=\"", ">", 0);
			string text2 = parseBetween(basestring, "name=\"", "\"", 6);
			string text3 = parseBetween(basestring, "value=\"", "\"", 7);
			if (mustHaveValue)
			{
				if (text3 != "")
				{
					stringBuilder.Append(text2 + "=" + text3 + "&");
				}
			}
			else
			{
				stringBuilder.Append(text2 + "=" + text3 + "&");
			}
			text = text.Substring(text.IndexOf("name=") + 6);
		}
		if (stringBuilder.Length > 1)
		{
			stringBuilder.Remove(stringBuilder.Length - 1, 1);
		}
		return stringBuilder.ToString();
	}

	public string getFormIdText(string response, string Id)
	{
		string text = response;
		string result = null;
		try
		{
			text = text.Substring(text.IndexOf("id=\"" + Id + "\"") + 5);
			result = parseBetween(text, "value=\"", "\"", 7);
		}
		catch
		{
		}
		return result;
	}

	public string getFormNameAfterText(string response, string formtype, string text)
	{
		string text2 = response.Substring(response.IndexOf(text) + text.Length);
		string text3 = null;
		text2 = text2.Substring(text2.IndexOf("<" + formtype) + formtype.Length);
		return parseBetween(text2, "name=\"", "\"", 6);
	}

	public string getFormAfterText(string response, string text)
	{
		string text2 = response.Substring(response.IndexOf(text) + text.Length);
		string text3 = null;
		string text4 = null;
		if (text2.ToLower().IndexOf("<input") < text2.ToLower().IndexOf("<textarea"))
		{
			text2 = text2.Substring(text2.IndexOf("<input") + 5);
			text3 = parseBetween(text2, "name=\"", "\"", 6);
			text4 = parseBetween(text2, "value=\"", "\"", 7);
		}
		else
		{
			text2 = text2.Substring(text2.IndexOf("<textarea") + 5);
			text3 = parseBetween(text2, "name=\"", "\"", 6);
			text4 = parseBetween(text2, "value=\"", "\"", 7);
		}
		return text3 + "=" + text4;
	}
}
