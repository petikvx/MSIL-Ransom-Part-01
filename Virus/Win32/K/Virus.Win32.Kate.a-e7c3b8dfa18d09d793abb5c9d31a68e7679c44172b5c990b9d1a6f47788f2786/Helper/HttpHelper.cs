using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;

namespace Helper;

public class HttpHelper
{
	private CookieContainer _cc = new CookieContainer();

	private WebProxy _proxy;

	private int _delayTime;

	private int _timeout = 120000;

	private int _tryTimes = 3;

	private string _lastUrl = string.Empty;

	private string reqUserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; MAXTHON 2.0)";

	public string Post(string url, string content)
	{
		string result = Post(url, content, _lastUrl);
		_lastUrl = url;
		return result;
	}

	public string Post(string url, string content, string referer)
	{
		int tryTimes = _tryTimes;
		while (tryTimes-- > 0)
		{
			try
			{
				DelaySomeTime();
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
				httpWebRequest.UserAgent = reqUserAgent;
				httpWebRequest.CookieContainer = _cc;
				byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(content);
				httpWebRequest.Method = "POST";
				httpWebRequest.Timeout = _timeout;
				httpWebRequest.Accept = "text/html, */*";
				httpWebRequest.Referer = referer;
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest.MediaType = "text/html, */*";
				httpWebRequest.ContentLength = bytes.Length;
				if (_proxy != null && _proxy.Credentials != null)
				{
					httpWebRequest.UseDefaultCredentials = true;
				}
				httpWebRequest.Proxy = _proxy;
				httpWebRequest.ServicePoint.Expect100Continue = false;
				Stream requestStream = httpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
				return streamReader.ReadToEnd();
			}
			catch (Exception ex)
			{
				TraceLog.Error("HTTP POST Error: " + ex.Message);
				TraceLog.Error("Url: " + url);
				TraceLog.Error("Data: " + content);
			}
		}
		return string.Empty;
	}

	private void DelaySomeTime()
	{
		if (_delayTime > 0)
		{
			Random random = new Random();
			int millisecondsTimeout = _delayTime * 1000 + random.Next(1000);
			Thread.Sleep(millisecondsTimeout);
		}
	}

	public string Get(string url, Encoding encode)
	{
		string result = Get(url, _lastUrl, encode);
		_lastUrl = url;
		return result;
	}

	public Stream GetStream(string url)
	{
		Stream stream = GetStream(url, _lastUrl);
		_lastUrl = url;
		return stream;
	}

	public string Get(string url, string referer, Encoding encode)
	{
		if (encode == null)
		{
			encode = Encoding.UTF8;
		}
		int tryTimes = _tryTimes;
		while (tryTimes-- > 0)
		{
			try
			{
				DelaySomeTime();
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
				httpWebRequest.UserAgent = reqUserAgent;
				httpWebRequest.CookieContainer = _cc;
				httpWebRequest.Referer = referer;
				httpWebRequest.Method = "GET";
				httpWebRequest.Timeout = _timeout;
				if (_proxy != null && _proxy.Credentials != null)
				{
					httpWebRequest.UseDefaultCredentials = true;
				}
				httpWebRequest.Proxy = _proxy;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), encode);
				return streamReader.ReadToEnd();
			}
			catch (Exception ex)
			{
				TraceLog.Error("HTTP GET Error: " + ex.Message);
				TraceLog.Error("Url: " + url);
			}
		}
		return string.Empty;
	}

	public Stream GetStream(string url, string referer)
	{
		int tryTimes = _tryTimes;
		while (tryTimes-- > 0)
		{
			try
			{
				DelaySomeTime();
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
				httpWebRequest.UserAgent = reqUserAgent;
				httpWebRequest.CookieContainer = _cc;
				httpWebRequest.Referer = referer;
				httpWebRequest.Method = "GET";
				httpWebRequest.Timeout = _timeout;
				if (_proxy != null && _proxy.Credentials != null)
				{
					httpWebRequest.UseDefaultCredentials = true;
				}
				httpWebRequest.Proxy = _proxy;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				return httpWebResponse.GetResponseStream();
			}
			catch (Exception ex)
			{
				TraceLog.Error("HTTP GET Error: " + ex.Message);
				TraceLog.Error("Url: " + url);
			}
		}
		return Stream.Null;
	}

	public void SetProxy(string server, int port, string username, string password)
	{
		if (server != null && port > 0)
		{
			_proxy = new WebProxy(server, port);
			if (username != null && password != null)
			{
				_proxy.Credentials = new NetworkCredential(username, password);
				_proxy.BypassProxyOnLocal = true;
			}
		}
	}

	public void SetDelayConnect(int delayTime)
	{
		_delayTime = delayTime;
	}

	public void SetTimeOut(int timeout)
	{
		if (timeout > 0)
		{
			_timeout = timeout;
		}
	}

	public void SetTryTimes(int times)
	{
		if (times > 0)
		{
			_tryTimes = times;
		}
	}

	public static string EncodePostData(string data)
	{
		return HttpUtility.UrlEncode(data);
	}

	public void Download(string url, string localfile)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile(url, localfile);
	}

	public void SetConfig(GlobalConfigData globalConfigData)
	{
		if (globalConfigData != null)
		{
			SetProxy(globalConfigData.ProxyServer, globalConfigData.ProxyPort, globalConfigData.ProxyUser, globalConfigData.ProxyPass);
			SetDelayConnect(globalConfigData.ConnectDelayTime);
			SetTimeOut(globalConfigData.HttpTimeout);
			SetTryTimes(globalConfigData.HttpTryTimes);
		}
	}
}
