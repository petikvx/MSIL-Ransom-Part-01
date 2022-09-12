using System;
using NLog;

namespace Caliburn.Micro.Logging.NLog;

public class NLogLogger : ILog, ILogExtended
{
	private readonly Logger logger_0;

	public NLogLogger(Type type)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		logger_0 = LogManager.GetLogger(type.Name);
	}

	public NLogLogger(string loggerName)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		logger_0 = LogManager.GetLogger(loggerName);
	}

	public void Error(Exception exception)
	{
		logger_0.ErrorException(exception.Message, exception);
	}

	public void Info(string format, params object[] args)
	{
		logger_0.Info(format, args);
	}

	public void Warn(string format, params object[] args)
	{
		logger_0.Warn(format, args);
	}

	public void Error(string format, params object[] args)
	{
		logger_0.Error(format, args);
	}

	public void Error(Exception exception, string format, params object[] args)
	{
		logger_0.ErrorException(string.Format(format, args), exception);
	}
}
