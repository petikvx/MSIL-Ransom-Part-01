using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core;

public class FileSystemScanner
{
	private bool qkZWELgjvAXEoMTyFiQvoGXnlpQL;

	public CompletedFileHandler CompletedFile;

	public DirectoryFailureHandler DirectoryFailure;

	private IScanFilter pxlaYbJffTNlOZYoilHxnaPprzZC;

	public FileFailureHandler FileFailure;

	private IScanFilter wKydZuOcoODDyquyLpOyWATujZQ;

	public ProcessDirectoryHandler ProcessDirectory;

	public ProcessFileHandler ProcessFile;

	public FileSystemScanner(IScanFilter fileFilter)
	{
		wKydZuOcoODDyquyLpOyWATujZQ = fileFilter;
	}

	public FileSystemScanner(string filter)
	{
		wKydZuOcoODDyquyLpOyWATujZQ = new PathFilter(filter);
	}

	public FileSystemScanner(IScanFilter fileFilter, IScanFilter directoryFilter)
	{
		wKydZuOcoODDyquyLpOyWATujZQ = fileFilter;
		pxlaYbJffTNlOZYoilHxnaPprzZC = directoryFilter;
	}

	public FileSystemScanner(string fileFilter, string directoryFilter)
	{
		wKydZuOcoODDyquyLpOyWATujZQ = new PathFilter(fileFilter);
		pxlaYbJffTNlOZYoilHxnaPprzZC = new PathFilter(directoryFilter);
	}

	private void ksXqAHiyzJjvWfLqZmnktFaThQUM(string file)
	{
		CompletedFileHandler completedFile = CompletedFile;
		if (completedFile != null)
		{
			ScanEventArgs scanEventArgs = new ScanEventArgs(file);
			completedFile(this, scanEventArgs);
			qkZWELgjvAXEoMTyFiQvoGXnlpQL = scanEventArgs.ContinueRunning;
		}
	}

	private bool remzdPBHtheUnfdYrIezIunuDcmz(string directory, Exception exception_0)
	{
		DirectoryFailureHandler directoryFailure = DirectoryFailure;
		bool result;
		if (result = directoryFailure != null)
		{
			ScanFailureEventArgs scanFailureEventArgs = new ScanFailureEventArgs(directory, exception_0);
			directoryFailure(this, scanFailureEventArgs);
			qkZWELgjvAXEoMTyFiQvoGXnlpQL = scanFailureEventArgs.ContinueRunning;
		}
		return result;
	}

	private bool hkMoesEhcUsVKvOrXVWAuSWOPhLn(string file, Exception exception_0)
	{
		bool result;
		if (result = FileFailure != null)
		{
			ScanFailureEventArgs scanFailureEventArgs = new ScanFailureEventArgs(file, exception_0);
			FileFailure(this, scanFailureEventArgs);
			qkZWELgjvAXEoMTyFiQvoGXnlpQL = scanFailureEventArgs.ContinueRunning;
		}
		return result;
	}

	private void ghhfqeriMHcBDAyNNXYkMJjJRUYf(string directory, bool hasMatchingFiles)
	{
		ProcessDirectoryHandler processDirectory = ProcessDirectory;
		if (processDirectory != null)
		{
			DirectoryEventArgs directoryEventArgs = new DirectoryEventArgs(directory, hasMatchingFiles);
			processDirectory(this, directoryEventArgs);
			qkZWELgjvAXEoMTyFiQvoGXnlpQL = directoryEventArgs.ContinueRunning;
		}
	}

	private void nOMXDpmfusmvEdULVApqTouzpxOV(string file)
	{
		ProcessFileHandler processFile = ProcessFile;
		if (processFile != null)
		{
			ScanEventArgs scanEventArgs = new ScanEventArgs(file);
			processFile(this, scanEventArgs);
			qkZWELgjvAXEoMTyFiQvoGXnlpQL = scanEventArgs.ContinueRunning;
		}
	}

	public void Scan(string directory, bool recurse)
	{
		qkZWELgjvAXEoMTyFiQvoGXnlpQL = true;
		NhZktovIMNyhbfEmGtvgNqHAHWGiA(directory, recurse);
	}

	private void NhZktovIMNyhbfEmGtvgNqHAHWGiA(string directory, bool recurse)
	{
		try
		{
			string[] files = Directory.GetFiles(directory);
			bool flag = false;
			for (int i = 0; i < files.Length; i++)
			{
				if (!wKydZuOcoODDyquyLpOyWATujZQ.IsMatch(files[i]))
				{
					files[i] = null;
				}
				else
				{
					flag = true;
				}
			}
			ghhfqeriMHcBDAyNNXYkMJjJRUYf(directory, flag);
			if (qkZWELgjvAXEoMTyFiQvoGXnlpQL && flag)
			{
				string[] array = files;
				foreach (string text in array)
				{
					try
					{
						if (text != null)
						{
							nOMXDpmfusmvEdULVApqTouzpxOV(text);
							if (!qkZWELgjvAXEoMTyFiQvoGXnlpQL)
							{
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						if (!hkMoesEhcUsVKvOrXVWAuSWOPhLn(text, exception_))
						{
							throw;
						}
					}
				}
			}
		}
		catch (Exception exception_2)
		{
			if (!remzdPBHtheUnfdYrIezIunuDcmz(directory, exception_2))
			{
				throw;
			}
		}
		if (!(qkZWELgjvAXEoMTyFiQvoGXnlpQL && recurse))
		{
			return;
		}
		try
		{
			string[] directories = Directory.GetDirectories(directory);
			foreach (string text2 in directories)
			{
				if (pxlaYbJffTNlOZYoilHxnaPprzZC == null || pxlaYbJffTNlOZYoilHxnaPprzZC.IsMatch(text2))
				{
					NhZktovIMNyhbfEmGtvgNqHAHWGiA(text2, recurse: true);
					if (!qkZWELgjvAXEoMTyFiQvoGXnlpQL)
					{
						break;
					}
				}
			}
		}
		catch (Exception exception_3)
		{
			if (!remzdPBHtheUnfdYrIezIunuDcmz(directory, exception_3))
			{
				throw;
			}
		}
	}
}
