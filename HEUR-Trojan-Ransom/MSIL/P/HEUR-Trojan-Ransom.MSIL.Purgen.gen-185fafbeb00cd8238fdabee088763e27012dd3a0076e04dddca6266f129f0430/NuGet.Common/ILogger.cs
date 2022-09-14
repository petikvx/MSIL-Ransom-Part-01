using System.Threading.Tasks;

namespace NuGet.Common;

public interface ILogger
{
	void LogDebug(string data);

	void LogVerbose(string data);

	void LogInformation(string data);

	void LogMinimal(string data);

	void LogWarning(string data);

	void LogError(string data);

	void LogInformationSummary(string data);

	void Log(HVe4ZaB2Yt level, string data);

	Task LogAsync(HVe4ZaB2Yt level, string data);

	void Log(ILogMessage message);

	Task LogAsync(ILogMessage message);
}
