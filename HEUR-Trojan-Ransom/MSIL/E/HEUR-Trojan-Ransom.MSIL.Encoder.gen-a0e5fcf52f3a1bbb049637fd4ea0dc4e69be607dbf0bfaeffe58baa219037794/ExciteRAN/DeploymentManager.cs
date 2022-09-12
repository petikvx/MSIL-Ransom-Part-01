using System;

namespace ExciteRAN;

internal sealed class DeploymentManager
{
	internal static TimeSpan CleanAssistant(TimeSpan windowPosition, TimeSpan parentLog)
	{
		return windowPosition - parentLog;
	}
}
