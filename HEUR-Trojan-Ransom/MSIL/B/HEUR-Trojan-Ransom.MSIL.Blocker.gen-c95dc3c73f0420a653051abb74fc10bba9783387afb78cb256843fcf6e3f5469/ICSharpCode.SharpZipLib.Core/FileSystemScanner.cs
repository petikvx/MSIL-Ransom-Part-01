using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core;

public class FileSystemScanner
{
	private bool dWNgMoOnixaewvhXGjMMECAyCBJj;

	public CompletedFileHandler CompletedFile;

	public DirectoryFailureHandler DirectoryFailure;

	private IScanFilter eKxzKYnppabzSDgznuwURKfofGEjA;

	public FileFailureHandler FileFailure;

	private IScanFilter xfObLqGVcZhnBJBJlgovjEXEOQQyB;

	public ProcessDirectoryHandler ProcessDirectory;

	public ProcessFileHandler ProcessFile;

	public FileSystemScanner(IScanFilter fileFilter)
	{
		xfObLqGVcZhnBJBJlgovjEXEOQQyB = fileFilter;
	}

	public FileSystemScanner(string filter)
	{
		xfObLqGVcZhnBJBJlgovjEXEOQQyB = new PathFilter(filter);
	}

	public FileSystemScanner(IScanFilter fileFilter, IScanFilter directoryFilter)
	{
		xfObLqGVcZhnBJBJlgovjEXEOQQyB = fileFilter;
		eKxzKYnppabzSDgznuwURKfofGEjA = directoryFilter;
	}

	public FileSystemScanner(string fileFilter, string directoryFilter)
	{
		xfObLqGVcZhnBJBJlgovjEXEOQQyB = new PathFilter(fileFilter);
		eKxzKYnppabzSDgznuwURKfofGEjA = new PathFilter(directoryFilter);
	}

	private void peXtSkKqxabTMiOBSobLHTzJIvBfc(string file)
	{
		CompletedFileHandler completedFile = CompletedFile;
		if (completedFile != null)
		{
			ScanEventArgs scanEventArgs = new ScanEventArgs(file);
			completedFile(this, scanEventArgs);
			dWNgMoOnixaewvhXGjMMECAyCBJj = scanEventArgs.ContinueRunning;
		}
	}

	private bool iraZYohfSAeqvEfDilLCowFzFfxf(string directory, Exception exception_0)
	{
		DirectoryFailureHandler directoryFailure = DirectoryFailure;
		bool num = directoryFailure != null;
		if (num)
		{
			ScanFailureEventArgs scanFailureEventArgs = new ScanFailureEventArgs(directory, exception_0);
			directoryFailure(this, scanFailureEventArgs);
			dWNgMoOnixaewvhXGjMMECAyCBJj = scanFailureEventArgs.ContinueRunning;
		}
		return num;
	}

	private bool cyMAbPiSebhrGIbUKXDvAaNZcUKM(string file, Exception exception_0)
	{
		bool num = FileFailure != null;
		if (num)
		{
			ScanFailureEventArgs scanFailureEventArgs = new ScanFailureEventArgs(file, exception_0);
			FileFailure(this, scanFailureEventArgs);
			dWNgMoOnixaewvhXGjMMECAyCBJj = scanFailureEventArgs.ContinueRunning;
		}
		return num;
	}

	private void nAxXTJFXGslUJxfsSpYVecsGaeXu(string directory, bool hasMatchingFiles)
	{
		ProcessDirectoryHandler processDirectory = ProcessDirectory;
		if (processDirectory != null)
		{
			DirectoryEventArgs directoryEventArgs = new DirectoryEventArgs(directory, hasMatchingFiles);
			processDirectory(this, directoryEventArgs);
			dWNgMoOnixaewvhXGjMMECAyCBJj = directoryEventArgs.ContinueRunning;
		}
	}

	private void kuIjuIEyWPVYCMgDCqpRljugQiHe(string file)
	{
		ProcessFileHandler processFile = ProcessFile;
		if (processFile != null)
		{
			ScanEventArgs scanEventArgs = new ScanEventArgs(file);
			processFile(this, scanEventArgs);
			dWNgMoOnixaewvhXGjMMECAyCBJj = scanEventArgs.ContinueRunning;
		}
	}

	public void Scan(string directory, bool recurse)
	{
		dWNgMoOnixaewvhXGjMMECAyCBJj = true;
		SWPDsJJdMcFTjYxNLxoXdwWZSnPX(directory, recurse);
	}

	private void SWPDsJJdMcFTjYxNLxoXdwWZSnPX(string directory, bool recurse)
	{
		try
		{
			string[] files = Directory.GetFiles(directory);
			bool flag = false;
			for (int i = 0; i < files.Length; i++)
			{
				if (!xfObLqGVcZhnBJBJlgovjEXEOQQyB.IsMatch(files[i]))
				{
					files[i] = null;
				}
				else
				{
					flag = true;
				}
			}
			nAxXTJFXGslUJxfsSpYVecsGaeXu(directory, flag);
			if (dWNgMoOnixaewvhXGjMMECAyCBJj && flag)
			{
				string[] array = files;
				foreach (string text in array)
				{
					try
					{
						if (text != null)
						{
							kuIjuIEyWPVYCMgDCqpRljugQiHe(text);
							if (!dWNgMoOnixaewvhXGjMMECAyCBJj)
							{
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						if (!cyMAbPiSebhrGIbUKXDvAaNZcUKM(text, exception_))
						{
							throw;
						}
					}
				}
			}
		}
		catch (Exception exception_2)
		{
			if (!iraZYohfSAeqvEfDilLCowFzFfxf(directory, exception_2))
			{
				throw;
			}
		}
		if (!(dWNgMoOnixaewvhXGjMMECAyCBJj && recurse))
		{
			return;
		}
		try
		{
			string[] directories = Directory.GetDirectories(directory);
			foreach (string text2 in directories)
			{
				if (eKxzKYnppabzSDgznuwURKfofGEjA == null || eKxzKYnppabzSDgznuwURKfofGEjA.IsMatch(text2))
				{
					SWPDsJJdMcFTjYxNLxoXdwWZSnPX(text2, recurse: true);
					if (!dWNgMoOnixaewvhXGjMMECAyCBJj)
					{
						break;
					}
				}
			}
		}
		catch (Exception exception_3)
		{
			if (!iraZYohfSAeqvEfDilLCowFzFfxf(directory, exception_3))
			{
				throw;
			}
		}
	}
}
