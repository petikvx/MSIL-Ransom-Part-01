using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using e9a0jRW7WM0ZtAYBQW;

namespace eqBwXEVVjn3ZGyCGaq;

internal class egHVMZo7kHkAOIIyye
{
	public static void eLXkTa1IW(int int_0)
	{
		for (int i = 0; i < int_0 / 5; i++)
		{
			Thread.Sleep(5000);
			Application.DoEvents();
		}
	}

	public static void eWXRATGtC(string string_0, WebProxy webProxy_0, CookieContainer cookieContainer_0, out string string_1, out CookieContainer cookieContainer_1, bool bool_0 = false, string string_2 = null)
	{
		string text = "";
		ServicePointManager.Expect100Continue = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
		if (webProxy_0 != null)
		{
			httpWebRequest.Proxy = webProxy_0;
		}
		if (string_2 != null)
		{
			httpWebRequest.UserAgent = string_2;
		}
		if (bool_0)
		{
			httpWebRequest.AllowAutoRedirect = true;
		}
		if (string.IsNullOrEmpty(string_2))
		{
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1700.72 Safari/537.36";
		}
		httpWebRequest.CookieContainer = cookieContainer_0;
		httpWebRequest.Timeout = 30000;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		if (httpWebResponse.StatusCode == HttpStatusCode.OK)
		{
			try
			{
				cookieContainer_0.Add(httpWebResponse.Cookies);
			}
			catch (Exception)
			{
			}
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			text = streamReader.ReadToEnd();
			streamReader.Close();
		}
		string_1 = text;
		cookieContainer_1 = cookieContainer_0;
	}

	public static void eeV3rFgdR(string string_0, WebProxy webProxy_0, string string_1, CookieContainer cookieContainer_0, out string string_2, out CookieContainer cookieContainer_1, bool bool_0 = false, string string_3 = null)
	{
		string text = "";
		ServicePointManager.Expect100Continue = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
		if (webProxy_0 != null)
		{
			httpWebRequest.Proxy = webProxy_0;
		}
		if (string_3 != null)
		{
			httpWebRequest.UserAgent = string_3;
		}
		if (bool_0)
		{
			httpWebRequest.AllowAutoRedirect = true;
		}
		if (string.IsNullOrEmpty(string_3))
		{
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1700.72 Safari/537.36";
		}
		httpWebRequest.CookieContainer = cookieContainer_0;
		httpWebRequest.Timeout = 30000;
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.Method = "POST";
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		httpWebRequest.ContentLength = bytes.Length;
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		if (httpWebResponse.StatusCode == HttpStatusCode.OK)
		{
			try
			{
				cookieContainer_0.Add(httpWebResponse.Cookies);
			}
			catch (Exception)
			{
			}
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			text = streamReader.ReadToEnd();
			streamReader.Close();
		}
		string_2 = text;
		cookieContainer_1 = cookieContainer_0;
	}

	public static string eyKPMrxcW(string string_0, string string_1, int int_0 = 0)
	{
		Match match = Regex.Match(string_0, string_1);
		if (match.Success)
		{
			return match.Groups[int_0].Value;
		}
		return "";
	}

	public static byte[] eY0Mv8pEp(Stream stream_0)
	{
		long position = 0L;
		if (stream_0.CanSeek)
		{
			position = stream_0.Position;
			stream_0.Position = 0L;
		}
		try
		{
			byte[] array = new byte[4096];
			int num = 0;
			int num2;
			while ((num2 = stream_0.Read(array, num, array.Length - num)) > 0)
			{
				num += num2;
				if (num == array.Length)
				{
					int num3 = stream_0.ReadByte();
					if (num3 != -1)
					{
						byte[] array2 = new byte[array.Length * 2];
						Buffer.BlockCopy(array, 0, array2, 0, array.Length);
						Buffer.SetByte(array2, num, (byte)num3);
						array = array2;
						num++;
					}
				}
			}
			byte[] array3 = array;
			if (array.Length != num)
			{
				array3 = new byte[num];
				Buffer.BlockCopy(array, 0, array3, 0, num);
			}
			return array3;
		}
		finally
		{
			if (stream_0.CanSeek)
			{
				stream_0.Position = position;
			}
		}
	}

	public egHVMZo7kHkAOIIyye()
	{
		eZTsNS9ebAJySZpK7R.eLHe04W3E();
		base._002Ector();
	}
}
