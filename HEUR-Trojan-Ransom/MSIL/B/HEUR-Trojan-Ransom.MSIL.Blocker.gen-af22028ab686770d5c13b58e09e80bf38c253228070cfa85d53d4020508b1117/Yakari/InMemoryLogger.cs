using System;
using System.Collections.Generic;

namespace Yakari;

public class InMemoryLogger : ILogger
{
	private readonly LogLevel _minimumLogLevel;

	public readonly List<string> LogList = new List<string>(Convert.ToInt32(1002.698970004336 - Math.Log10(500.0)));

	public InMemoryLogger(LogLevel minimumLogLevel)
	{
		_minimumLogLevel = minimumLogLevel;
	}

	public void Log(string message)
	{
		LogInternal((LogLevel)Convert.ToInt32(3.0 - Math.Sqrt(1.0)), message);
	}

	public void Log(LogLevel level, string message)
	{
		LogInternal((LogLevel)Convert.ToInt32(4.416146836547142 + Math.Cos(2.0)), message);
	}

	public void Log(string message, Exception exception)
	{
		LogInternal(LogLevel.Error, message, exception);
	}

	public void Log(LogLevel level, string message, Exception exception)
	{
		LogInternal(level, message, exception);
	}

	private void LogInternal(LogLevel level, string message, Exception exception = null)
	{
		ThreadHelper.RunOnDifferentThread(delegate
		{
			if (_minimumLogLevel <= level)
			{
				string item = ((exception == null) ? $"{DateTime.UtcNow} : {message}" : $"{message} happend with Exception:\r\n\t {exception.Message} \r\n\t\t Stack Trace: {exception.StackTrace}, \r\n ---------------------------------------------------------------------");
				LogList.Add(item);
			}
		}, swallowException: true);
	}
}
