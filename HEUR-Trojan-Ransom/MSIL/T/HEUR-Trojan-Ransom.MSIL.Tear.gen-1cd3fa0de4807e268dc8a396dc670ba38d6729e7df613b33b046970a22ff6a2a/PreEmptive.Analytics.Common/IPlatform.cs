using System;
using System.Collections.Generic;
using PreEmptive.Analytics.Common.Messages;

namespace PreEmptive.Analytics.Common;

public interface IPlatform : IAsyncProvider
{
	IXMLTransmitter CreateXMLTransmitter();

	AgentInfo GetAgentInfo();

	HostInfo GetHostInfo();

	OSInfo GetOSInfo();

	UserInfo GetUserInfo();

	string GetDefaultEndpoint();

	IList<StackInfo> GetStackInfo(Exception exception);

	IList<ComponentInfo> GetComponentInfo();

	ISettingsStore GetSettingsStore();

	SystemInfo GetSystemInfo(bool fulldata);

	PerformanceInfo GetPerformanceInfo(bool fulldata);

	IOfflineDataStore GetOfflineDataStore();

	Configuration.ApplicationStopBehavior GetStopBehaviorDefaults();
}
