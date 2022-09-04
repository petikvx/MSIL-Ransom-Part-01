using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Locker;

internal class FileLockList
{
	public static string filelist = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "filelist.txt");

	private List<FileLock> filelocks = new List<FileLock>();

	private readonly long maxSize = 3145728000L;

	private long currentSize;

	public int Count => filelocks.Count;

	public long CurrentSize => currentSize;

	public long MaxSize => maxSize;

	public void Initialize()
	{
		if (!File.Exists(filelist))
		{
			return;
		}
		StreamReader streamReader = new StreamReader(filelist);
		string originalFileFullPath;
		while ((originalFileFullPath = streamReader.ReadLine()) != null)
		{
			FileLock fileLock = new FileLock();
			fileLock.originalFileFullPath = originalFileFullPath;
			if (File.Exists(fileLock.originalFileFullPath) || File.Exists(fileLock.cryptedFileFullPath))
			{
				FileInfo fileInfo = ((!File.Exists(fileLock.originalFileFullPath)) ? new FileInfo(fileLock.cryptedFileFullPath) : new FileInfo(fileLock.originalFileFullPath));
				filelocks.Add(fileLock);
				currentSize += fileInfo.Length;
			}
		}
		streamReader.Close();
	}

	public List<FileLock> GetList()
	{
		return filelocks;
	}

	public void AddFile(FileLock file)
	{
		if (!filelocks.Contains(file) && currentSize < maxSize)
		{
			FileInfo fileInfo = new FileInfo(file.originalFileFullPath);
			currentSize += fileInfo.Length;
			filelocks.Add(file);
		}
	}

	public bool Save()
	{
		if (File.Exists(filelist))
		{
			try
			{
				File.Delete(filelist);
			}
			catch (Exception)
			{
				return false;
			}
		}
		StreamWriter streamWriter = new StreamWriter(filelist);
		foreach (FileLock filelock in filelocks)
		{
			streamWriter.WriteLine(filelock.originalFileFullPath);
		}
		streamWriter.Close();
		return true;
	}
}
