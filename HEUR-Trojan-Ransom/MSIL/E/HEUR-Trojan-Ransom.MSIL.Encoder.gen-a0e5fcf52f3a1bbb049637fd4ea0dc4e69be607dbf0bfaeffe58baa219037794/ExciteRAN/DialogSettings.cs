using System;

namespace ExciteRAN;

internal sealed class DialogSettings
{
	internal static TimeSpan CleanAssistant(DateTime windowPosition, DateTime parentLog)
	{
		return windowPosition - parentLog;
	}
}
