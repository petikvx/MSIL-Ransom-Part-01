using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using ATI.ACE.LOG.Foundation;
using ATI.ACE.LOG.Foundation.Implementation.Private;

namespace ATI.ACE.LOG.EXE;

public sealed class MgrLog
{
	private const string SEARCH = "<Search";

	private const int MAX_FILE_SIZE = 10000000;

	private const string ACE_LOG_FILE_NAME = "ACELog.";

	private const string ACE_LOG_FILE_EXT = ".txt";

	private const string SYS_LOG_NAME = "ACEEventLog";

	private StreamWriter logFile;

	private string logFileName;

	private string fullFileName;

	private int maxFileSize = 10000000;

	public string FileName => logFileName;

	public string FullPathFileName => fullFileName;

	public int FileSize => (int)new FileInfo(FullPathFileName).Length;

	public int MaxFileSize
	{
		get
		{
			return maxFileSize;
		}
		set
		{
			maxFileSize = value;
		}
	}

	public MgrLog()
	{
		InitLogFile();
	}

	public void ClearWndsEvtLog()
	{
		try
		{
			if (EventLog.Exists("ACEEventLog"))
			{
				EventLog.Delete("ACEEventLog");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public bool MatchesFilter(SLog log, string domainName, string assemblyName, string namespc, string messageText)
	{
		if ((!domainName.StartsWith("<Search") && !domainName.Equals(log.DomainName)) || (!assemblyName.StartsWith("<Search") && !assemblyName.Equals(log.AssemblyName)) || (namespc.Length != 0 && !namespc.StartsWith("<Search") && log.ClassName.IndexOf(namespc) < 0))
		{
			return false;
		}
		if (messageText.Length != 0 && !messageText.StartsWith("<Search"))
		{
			return log.Message.IndexOf(messageText) >= 0;
		}
		return true;
	}

	public void SaveLogMessage(string message)
	{
		logFile.WriteLine(message);
		logFile.Flush();
	}

	public void CloseLogFile()
	{
		try
		{
			logFile.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private void InitLogFile()
	{
		DateTime now = DateTime.Now;
		_ = now.Year;
		int month = now.Month;
		int day = now.Day;
		int hour = now.Hour;
		int minute = now.Minute;
		int second = now.Second;
		StringBuilder stringBuilder = new StringBuilder(now.Year.ToString());
		if (month < 10)
		{
			stringBuilder.Append("0");
		}
		stringBuilder.Append(month.ToString());
		if (day < 10)
		{
			stringBuilder.Append("0");
		}
		stringBuilder.Append(day.ToString());
		stringBuilder.Append("-");
		if (hour < 10)
		{
			stringBuilder.Append("0");
		}
		stringBuilder.Append(hour.ToString());
		if (minute < 10)
		{
			stringBuilder.Append("0");
		}
		stringBuilder.Append(minute.ToString());
		if (second < 10)
		{
			stringBuilder.Append("0");
		}
		stringBuilder.Append(second.ToString());
		logFileName = new StringBuilder("ACELog.", 64).Append(stringBuilder.ToString()).Append(".txt").ToString();
		fullFileName = new StringBuilder(Services.get_LocalAppDataPath(), 256).Append(logFileName).ToString();
		logFile = new StreamWriter(new FileStream(fullFileName, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.ReadWrite));
	}
}
