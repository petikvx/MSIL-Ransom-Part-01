using System;
using System.Collections.Generic;
using System.IO;

namespace adclicker;

internal static class BlockListParser
{
	public static AVBlockInfo[] LoadBlockList(string filename)
	{
		string source = "";
		try
		{
			using (StreamReader streamReader = new StreamReader(filename))
			{
				source = streamReader.ReadToEnd();
			}
			return Parse(source);
		}
		catch
		{
			return null;
		}
	}

	public static AVBlockInfo[] Parse(string source)
	{
		string[] array = source.Split(new string[1] { "),(" }, StringSplitOptions.RemoveEmptyEntries);
		List<AVBlockInfo> list = new List<AVBlockInfo>();
		string[] array2 = array;
		foreach (string text in array2)
		{
			string text2 = "";
			string text3 = "";
			try
			{
				string[] array3 = text.Split(new char[1] { ',' });
				for (int j = 0; j < array3.Length; j++)
				{
					int num = array3[j].IndexOf('"');
					int num2 = array3[j].LastIndexOf('"');
					array3[j] = array3[j].Substring(num + 1, num2 - num - 1);
				}
				text2 = array3[0];
				text3 = array3[1];
				list.Add(new AVBlockInfo((text2 == "null") ? null : text2, text3));
			}
			catch
			{
			}
		}
		return list.ToArray();
	}

	public static bool Save(AVBlockInfo[] blocks, string filename)
	{
		try
		{
			using (StreamWriter streamWriter = new StreamWriter(filename))
			{
				for (int i = 0; i < blocks.Length; i++)
				{
					streamWriter.Write(string.Format("{0}{1}", blocks[i].ToString(), (i == blocks.Length - 1) ? "" : ","));
				}
			}
			return true;
		}
		catch
		{
			return false;
		}
	}
}
