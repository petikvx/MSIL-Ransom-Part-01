using System;

namespace Yakari;

public class ConsoleLogger : ILogger
{
	private readonly LogLevel _minimumLogLevel;

	public ConsoleLogger(LogLevel minimumLogLevel)
	{
		_minimumLogLevel = minimumLogLevel;
	}

	public void Log(string message)
	{
		LogInternal((LogLevel)Convert.ToInt32(3.0 - Math.Floor(1.0)), message);
	}

	public void Log(LogLevel level, string message)
	{
		LogInternal((LogLevel)Convert.ToInt32(2.0 + Math.Ceiling(2.0)), message);
	}

	public void Log(string message, Exception exception)
	{
		LogInternal((LogLevel)Convert.ToInt32(2.0 + Math.Ceiling(2.0)), message, exception);
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
				string value = ((exception == null) ? $"{DateTime.UtcNow} : {message}" : $"{message} happend with Exception:\r\n\t {exception.Message} \r\n\t\t Stack Trace: {exception.StackTrace}, \r\n ---------------------------------------------------------------------");
				Console.WriteLine(value);
			}
		}, swallowException: true);
	}
}
