using System;

namespace White.Core.Configuration;

public static class ConfigurationExtensions
{
	public static TimeSpan TooltipWaitTimeSpan(this ICoreConfiguration coreConfiguration)
	{
		return TimeSpan.FromMilliseconds(coreConfiguration.TooltipWaitTime);
	}

	public static TimeSpan BusyTimeout(this ICoreConfiguration coreConfiguration)
	{
		return TimeSpan.FromMilliseconds(coreConfiguration.BusyTimeout);
	}

	public static TimeSpan SuggestionListTimeout(this ICoreConfiguration coreConfiguration)
	{
		return TimeSpan.FromMilliseconds(coreConfiguration.SuggestionListTimeout);
	}

	public static TimeSpan UIAutomationZeroWindowBugTimeout(this ICoreConfiguration coreConfiguration)
	{
		return TimeSpan.FromMilliseconds(coreConfiguration.UIAutomationZeroWindowBugTimeout);
	}

	public static TimeSpan PopupTimeout(this ICoreConfiguration coreConfiguration)
	{
		return TimeSpan.FromMilliseconds(coreConfiguration.UIAutomationZeroWindowBugTimeout);
	}
}
