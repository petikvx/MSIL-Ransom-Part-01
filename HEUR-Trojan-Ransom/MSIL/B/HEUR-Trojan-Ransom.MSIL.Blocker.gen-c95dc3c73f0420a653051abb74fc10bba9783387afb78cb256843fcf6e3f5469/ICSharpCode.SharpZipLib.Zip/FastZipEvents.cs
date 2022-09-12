using System;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip;

public class FastZipEvents
{
	public CompletedFileHandler CompletedFile;

	public DirectoryFailureHandler DirectoryFailure;

	public FileFailureHandler FileFailure;

	public ProcessDirectoryHandler ProcessDirectory;

	public ProcessFileHandler ProcessFile;

	public ProgressHandler Progress;

	private TimeSpan amdGXeEUlRDYGgujyYpnqlhtrksg = TimeSpan.FromSeconds(3.0);

	public TimeSpan ProgressInterval
	{
		get
		{
			return amdGXeEUlRDYGgujyYpnqlhtrksg;
		}
		set
		{
			amdGXeEUlRDYGgujyYpnqlhtrksg = value;
		}
	}

	public bool OnCompletedFile(string file)
	{
		bool result = true;
		CompletedFileHandler completedFile = CompletedFile;
		if (completedFile != null)
		{
			ScanEventArgs scanEventArgs = new ScanEventArgs(file);
			completedFile(this, scanEventArgs);
			result = scanEventArgs.ContinueRunning;
		}
		return result;
	}

	public bool OnDirectoryFailure(string directory, Exception exception_0)
	{
		bool result = false;
		DirectoryFailureHandler directoryFailure = DirectoryFailure;
		if (directoryFailure != null)
		{
			ScanFailureEventArgs scanFailureEventArgs = new ScanFailureEventArgs(directory, exception_0);
			directoryFailure(this, scanFailureEventArgs);
			result = scanFailureEventArgs.ContinueRunning;
		}
		return result;
	}

	public bool OnFileFailure(string file, Exception exception_0)
	{
		FileFailureHandler fileFailure = FileFailure;
		bool result;
		if (result = fileFailure != null)
		{
			ScanFailureEventArgs scanFailureEventArgs = new ScanFailureEventArgs(file, exception_0);
			fileFailure(this, scanFailureEventArgs);
			result = scanFailureEventArgs.ContinueRunning;
		}
		return result;
	}

	public bool OnProcessDirectory(string directory, bool hasMatchingFiles)
	{
		bool result = true;
		ProcessDirectoryHandler processDirectory = ProcessDirectory;
		if (processDirectory != null)
		{
			DirectoryEventArgs directoryEventArgs = new DirectoryEventArgs(directory, hasMatchingFiles);
			processDirectory(this, directoryEventArgs);
			result = directoryEventArgs.ContinueRunning;
		}
		return result;
	}

	public bool OnProcessFile(string file)
	{
		bool result = true;
		if (ProcessFile != null)
		{
			ScanEventArgs scanEventArgs = new ScanEventArgs(file);
			ProcessFile(this, scanEventArgs);
			result = scanEventArgs.ContinueRunning;
		}
		return result;
	}
}
