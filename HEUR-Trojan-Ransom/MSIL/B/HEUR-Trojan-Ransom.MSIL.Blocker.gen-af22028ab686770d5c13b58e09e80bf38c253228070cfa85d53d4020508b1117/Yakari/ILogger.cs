using System;

namespace Yakari;

public interface ILogger
{
	void Log(string message);

	void Log(LogLevel level, string message);

	void Log(string message, Exception exception);

	void Log(LogLevel level, string message, Exception exception);
}
