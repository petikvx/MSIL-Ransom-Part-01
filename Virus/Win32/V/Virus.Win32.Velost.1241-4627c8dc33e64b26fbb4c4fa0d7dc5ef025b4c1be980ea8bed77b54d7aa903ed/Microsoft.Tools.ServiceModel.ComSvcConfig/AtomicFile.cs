using System;
using System.IO;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class AtomicFile
{
	private bool prepared;

	private string originalFileName;

	private bool originalFileExists;

	private string tempFileName;

	private string backupOfOriginalFileName;

	private bool deleteOriginalFile;

	public string OriginalFileName => originalFileName;

	public bool OriginalFileExists => originalFileExists;

	public AtomicFile(string fileName)
	{
		originalFileName = fileName;
		originalFileExists = File.Exists(originalFileName);
		tempFileName = null;
		backupOfOriginalFileName = null;
		deleteOriginalFile = false;
		prepared = false;
	}

	public bool CurrentExists()
	{
		if (tempFileName != null)
		{
			return true;
		}
		return originalFileExists;
	}

	public void Delete()
	{
		if (tempFileName != null)
		{
			throw new InvalidOperationException();
		}
		if (!originalFileExists)
		{
			throw new InvalidOperationException();
		}
		deleteOriginalFile = true;
	}

	public string GetCurrentFileName(bool readOnly)
	{
		if (deleteOriginalFile)
		{
			throw new InvalidOperationException();
		}
		if (tempFileName != null)
		{
			return tempFileName;
		}
		if (originalFileExists)
		{
			if (readOnly)
			{
				return originalFileName;
			}
			tempFileName = GetTempFileName();
			File.Copy(originalFileName, tempFileName);
			return tempFileName;
		}
		if (readOnly)
		{
			return null;
		}
		tempFileName = GetTempFileName();
		return tempFileName;
	}

	public bool HasBeenModified()
	{
		if (tempFileName == null)
		{
			if (originalFileExists)
			{
				return deleteOriginalFile;
			}
			return false;
		}
		return true;
	}

	public void Prepare()
	{
		if (tempFileName != null)
		{
			if (originalFileExists)
			{
				backupOfOriginalFileName = GetTempFileName();
				File.Copy(originalFileName, backupOfOriginalFileName);
				SafeDeleteFile(originalFileName);
			}
			File.Copy(tempFileName, originalFileName);
			SafeDeleteFile(tempFileName);
		}
		else if (deleteOriginalFile)
		{
			backupOfOriginalFileName = GetTempFileName();
			File.Copy(originalFileName, backupOfOriginalFileName);
			SafeDeleteFile(originalFileName);
		}
		prepared = true;
	}

	public void Commit()
	{
		if (!prepared)
		{
			throw new InvalidOperationException();
		}
		SafeDeleteFile(backupOfOriginalFileName);
	}

	public void Abort()
	{
		if (originalFileExists)
		{
			if (backupOfOriginalFileName != null && File.Exists(backupOfOriginalFileName))
			{
				SafeDeleteFile(originalFileName);
				File.Copy(backupOfOriginalFileName, originalFileName);
			}
		}
		else
		{
			SafeDeleteFile(originalFileName);
		}
		SafeDeleteFile(backupOfOriginalFileName);
		SafeDeleteFile(tempFileName);
	}

	internal static void SafeDeleteFile(string fileName)
	{
		if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
		{
			File.Delete(fileName);
		}
	}

	private string GetTempFileName()
	{
		return Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
	}
}
