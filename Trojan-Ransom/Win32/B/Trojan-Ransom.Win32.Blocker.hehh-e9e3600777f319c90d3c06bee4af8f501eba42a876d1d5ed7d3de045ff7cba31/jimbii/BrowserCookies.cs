using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

namespace jimbii;

internal class BrowserCookies
{
	private static Dictionary<string, CookieContainer> CookieYar = new Dictionary<string, CookieContainer>();

	[DllImport("wininet.dll", SetLastError = true)]
	public static extern bool InternetGetCookie(string url, string cookieName, StringBuilder cookieData, ref int size);

	[DllImport("wininet.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool InternetSetCookie(string url, string cookieName, string cookieData);

	private static CookieContainer GetUriCookieContainer(Uri uri)
	{
		CookieContainer cookieContainer = null;
		int size = 256;
		StringBuilder stringBuilder = new StringBuilder(256);
		if (!InternetGetCookie(uri.ToString(), null, stringBuilder, ref size))
		{
			if (size < 0)
			{
				return null;
			}
			stringBuilder = new StringBuilder(size);
			if (!InternetGetCookie(uri.ToString(), null, stringBuilder, ref size))
			{
				return null;
			}
		}
		if (stringBuilder.Length > 0)
		{
			cookieContainer = new CookieContainer();
			cookieContainer.SetCookies(uri, stringBuilder.ToString().Replace(';', ','));
		}
		return cookieContainer;
	}

	private static string GetFireFoxCookiePath()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		folderPath += "\\Mozilla\\Firefox\\Profiles\\";
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
			DirectoryInfo[] directories = directoryInfo.GetDirectories("*.default");
			if (directories.Length != 1)
			{
				return string.Empty;
			}
			folderPath = folderPath + directories[0].Name + "\\cookies.sqlite";
			if (!File.Exists(folderPath))
			{
				return string.Empty;
			}
			return folderPath;
		}
		catch (Exception)
		{
			return "";
		}
	}

	private static CookieContainer GetCookieContainerForFirefox(Uri uri)
	{
		string text = uri.Host.Replace("www.", "");
		if (CookieYar.ContainsKey(text))
		{
			return CookieYar[text];
		}
		CookieContainer cookieContainer = new CookieContainer();
		string fireFoxCookiePath = GetFireFoxCookiePath();
		string tempFileName = Path.GetTempFileName();
		File.Copy(fireFoxCookiePath, tempFileName, overwrite: true);
		if (File.Exists(tempFileName))
		{
			using SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=" + fireFoxCookiePath);
			using (SQLiteCommand sQLiteCommand = sQLiteConnection.CreateCommand())
			{
				sQLiteCommand.CommandText = "select * from moz_cookies where host like '%" + text + "%';";
				sQLiteConnection.Open();
				using SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
				while (sQLiteDataReader.Read())
				{
					cookieContainer.Add(new Cookie(sQLiteDataReader["name"].ToString(), sQLiteDataReader["value"].ToString(), sQLiteDataReader["path"].ToString(), sQLiteDataReader["host"].ToString()));
				}
			}
			sQLiteConnection.Close();
		}
		File.Delete(tempFileName);
		CookieYar.Add(text, cookieContainer);
		return cookieContainer;
	}

	public void get_or_set_cookies()
	{
		Uri uri = new Uri("http://jimbii.com");
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Jimbii\\Preferences");
		string text = "";
		string text2 = "";
		try
		{
			if (registryKey != null)
			{
				text = registryKey.GetValue("AffiliateID")!.ToString();
				text2 = registryKey.GetValue("identity")!.ToString();
			}
		}
		catch (Exception)
		{
		}
		CookieCollection cookieCollection = null;
		if (!(text == "") && !(text2 == ""))
		{
			return;
		}
		CookieContainer uriCookieContainer = GetUriCookieContainer(uri);
		try
		{
			cookieCollection = uriCookieContainer.GetCookies(uri);
		}
		catch (Exception)
		{
		}
		if (cookieCollection != null)
		{
			foreach (Cookie item in cookieCollection)
			{
				registryKey?.SetValue(item.Name, item.Value);
			}
		}
		try
		{
			uriCookieContainer = GetCookieContainerForFirefox(uri);
			cookieCollection = uriCookieContainer.GetCookies(uri);
		}
		catch (Exception)
		{
		}
		if (cookieCollection == null)
		{
			return;
		}
		foreach (Cookie item2 in cookieCollection)
		{
			registryKey?.SetValue(item2.Name, item2.Value);
		}
	}
}
