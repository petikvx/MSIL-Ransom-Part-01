using System;

namespace PreEmptive.Analytics.Common;

[Flags]
public enum LoggingLevel
{
	None = 0,
	Error = 1,
	Warning = 3,
	Info = 7
}
