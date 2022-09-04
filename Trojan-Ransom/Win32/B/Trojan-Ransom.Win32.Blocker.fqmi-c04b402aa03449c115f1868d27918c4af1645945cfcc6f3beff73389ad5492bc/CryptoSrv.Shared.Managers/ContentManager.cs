using System;
using System.IO;
using System.Threading;

namespace CryptoSrv.Shared.Managers;

public class ContentManager
{
	private readonly string _workerDir;

	private readonly string[] _relatedProcesses;

	private readonly bool _clearRootFiles;

	public ContentManager(string workerDir, string[] relatedProcesses, bool clearRootFiles = true)
	{
		_workerDir = workerDir;
		_relatedProcesses = relatedProcesses;
		_clearRootFiles = clearRootFiles;
	}

	public bool Clear(out string outMessage)
	{
		try
		{
			if (!StopProcesses(out outMessage))
			{
				return false;
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(_workerDir);
			if (_clearRootFiles)
			{
				FileInfo[] files = directoryInfo.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					fileInfo.Delete();
					Thread.Sleep(100);
				}
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				directoryInfo2.Delete(recursive: true);
				Thread.Sleep(200);
			}
			return true;
		}
		catch (Exception ex)
		{
			outMessage = ex.Message + ex.StackTrace;
			return false;
		}
	}

	public bool StopProcesses(out string outMessage)
	{
		outMessage = null;
		if (_relatedProcesses == null)
		{
			return true;
		}
		string[] relatedProcesses = _relatedProcesses;
		int num = 0;
		while (true)
		{
			if (num < relatedProcesses.Length)
			{
				string processName = relatedProcesses[num];
				if (!ProcessManager.KillProcess(processName, out outMessage))
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
