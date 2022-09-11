using System.Runtime.CompilerServices;

namespace PreEmptive.Analytics.Common;

public abstract class LoggerBase
{
	[CompilerGenerated]
	private LoggingLevel loggingLevel_0;

	public LoggingLevel MessageLoggingLevel
	{
		[CompilerGenerated]
		get
		{
			int num = 14504;
			int num2 = num;
			num = 14504;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return loggingLevel_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 8464;
			int num2 = num;
			num = 8464;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			loggingLevel_0 = value;
		}
	}

	public LoggerBase(LoggingLevel level)
	{
		MessageLoggingLevel = level;
	}
}
