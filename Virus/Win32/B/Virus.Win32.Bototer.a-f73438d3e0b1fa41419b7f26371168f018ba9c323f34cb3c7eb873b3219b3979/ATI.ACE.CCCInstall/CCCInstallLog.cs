using System;
using System.IO;
using System.Text;

namespace ATI.ACE.CCCInstall;

public class CCCInstallLog
{
	private StringBuilder sb;

	private bool ShowLog = true;

	public CCCInstallLog()
	{
		try
		{
			sb = new StringBuilder();
			sb.AppendLine("===========================================");
			sb.AppendLine("** CCCInstall started: " + DateTime.Now.ToString("u"));
		}
		catch
		{
		}
	}

	public CCCInstallLog(bool showLog)
	{
		ShowLog = showLog;
		if (showLog)
		{
			try
			{
				sb = new StringBuilder();
				sb.AppendLine("===========================================");
				sb.AppendLine("** CCCInstall started: " + DateTime.Now.ToString("u"));
			}
			catch
			{
			}
		}
	}

	public void LogException(Exception e)
	{
		if (ShowLog)
		{
			try
			{
				sb.AppendFormat("[{0}] Exception:\r\n{1}\r\n{2}\r\n", DateTime.Now.ToString("u"), e.Message, e.StackTrace);
			}
			catch
			{
			}
		}
	}

	public void LogException(Exception e, string additionalMessage)
	{
		if (ShowLog)
		{
			try
			{
				sb.AppendFormat("[{0}] Exception: {1}\r\n{2}\r\n{3}\r\n", DateTime.Now.ToString("u"), additionalMessage, e.Message, e.StackTrace);
			}
			catch
			{
			}
		}
	}

	public void LogMessage(string message)
	{
		if (ShowLog)
		{
			try
			{
				sb.AppendFormat("[{0}] Message: {1}\r\n", DateTime.Now.ToString("u"), message);
			}
			catch
			{
			}
		}
	}

	public void LogFinished()
	{
		if (ShowLog)
		{
			StreamWriter streamWriter = null;
			try
			{
				streamWriter = new StreamWriter("CCCInstall_" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".log", append: true);
				streamWriter.Write(sb.ToString());
				streamWriter.WriteLine("** CCCInstall ended: " + DateTime.Now.ToString("u"));
				streamWriter.WriteLine("===========================================");
			}
			finally
			{
				streamWriter?.Close();
			}
		}
	}
}
