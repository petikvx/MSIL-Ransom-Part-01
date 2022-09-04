using System;
using System.IO;
using System.Net;
using System.Text;

namespace CryptoSrv.Shared.Managers;

public class LogManager
{
	private readonly string _postUrl;

	public LogManager(string url)
	{
		_postUrl = url + "/log/";
	}

	public string Add(string action, string message, string appVersion = null)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(_postUrl + action);
			byte[] bytes = Encoding.UTF8.GetBytes("message=" + message + "&appVersion=" + appVersion);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
			}
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			return new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		}
		catch (Exception)
		{
			return null;
		}
	}
}
