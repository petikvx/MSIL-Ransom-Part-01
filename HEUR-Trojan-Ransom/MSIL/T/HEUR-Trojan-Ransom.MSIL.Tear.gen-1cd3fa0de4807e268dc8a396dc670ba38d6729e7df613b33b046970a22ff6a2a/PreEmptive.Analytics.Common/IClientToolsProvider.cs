namespace PreEmptive.Analytics.Common;

public interface IClientToolsProvider : IConfigurationProvider, ILoggerProvider, IPlatformProvider
{
	bool AppStarted { get; }
}
