using System;
using System.Collections.Generic;
using System.IO;

namespace ns3;

internal static class Class27
{
	public static void smethod_0(string startPath, string filePattern, bool subdirectories, Action<List<string>> actionForFiles, List<string> excludedBaseFolders = null, bool async = false)
	{
		if (excludedBaseFolders != null && smethod_1(excludedBaseFolders, startPath))
		{
			return;
		}
		string[] array = new string[0];
		if (subdirectories)
		{
			try
			{
				array = Directory.GetDirectories(startPath, "*", SearchOption.TopDirectoryOnly);
			}
			catch
			{
			}
		}
		string[] array2 = filePattern.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
		List<string> list = new List<string>();
		string[] array3 = array2;
		foreach (string searchPattern in array3)
		{
			try
			{
				string[] files = Directory.GetFiles(startPath, searchPattern, SearchOption.TopDirectoryOnly);
				if (files.Length > 0)
				{
					list.AddRange(files);
				}
			}
			catch
			{
			}
		}
		if (list.Count > 0 && actionForFiles != null)
		{
			if (async)
			{
				actionForFiles.BeginInvoke(list, null, null);
			}
			else
			{
				actionForFiles(list);
			}
			string[] files = new string[0];
		}
		if (array == null || array.Length <= 0)
		{
			return;
		}
		string[] array4 = array;
		foreach (string text in array4)
		{
			if (excludedBaseFolders == null || !smethod_1(excludedBaseFolders, text))
			{
				smethod_0(text, filePattern, subdirectories, actionForFiles, excludedBaseFolders, async);
			}
		}
	}

	private static bool smethod_1(IList<string> ilist_0, string string_0)
	{
		string_0 = string_0.ToLower();
		int num = 0;
		while (true)
		{
			if (num < ilist_0.Count)
			{
				string value = ilist_0[num].ToLower();
				if (string_0.StartsWith(value))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}
}
