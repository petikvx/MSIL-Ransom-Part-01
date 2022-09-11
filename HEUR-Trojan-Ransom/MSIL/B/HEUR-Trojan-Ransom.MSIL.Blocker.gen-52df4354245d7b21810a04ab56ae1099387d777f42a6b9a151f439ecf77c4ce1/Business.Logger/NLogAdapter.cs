using NLog;

namespace Business.Logger;

public class NLogAdapter : ILogger
{
	private readonly ILogger log;

	public NLogAdapter(ILogger log)
	{
		this.log = log;
	}

	public void Debug(string message)
	{
		if (log.get_IsDebugEnabled())
		{
			log.Debug(message);
		}
	}

	public void Debug(string format, params object[] args)
	{
		if (log.get_IsDebugEnabled())
		{
			log.Debug(format, args);
		}
	}

	public void Info(string message)
	{
		if (log.get_IsInfoEnabled())
		{
			log.Info(message);
		}
	}

	public void Info(string format, params object[] args)
	{
		if (log.get_IsInfoEnabled())
		{
			log.Info(format, args);
		}
	}

	public void Warn(string message)
	{
		if (log.get_IsWarnEnabled())
		{
			log.Warn(message);
		}
	}

	public void Warn(string format, params object[] args)
	{
		if (log.get_IsWarnEnabled())
		{
			log.Warn(format, args);
		}
	}

	public void Error(string message)
	{
		if (log.get_IsErrorEnabled())
		{
			log.Error(message);
		}
	}

	public void Error(string format, params object[] args)
	{
		if (log.get_IsErrorEnabled())
		{
			log.Error(format, args);
		}
	}

	public void Fatal(string message)
	{
		if (log.get_IsFatalEnabled())
		{
			log.Fatal(message);
		}
	}

	public void Fatal(string format, params object[] args)
	{
		if (log.get_IsFatalEnabled())
		{
			log.Fatal(format, args);
		}
	}
}
