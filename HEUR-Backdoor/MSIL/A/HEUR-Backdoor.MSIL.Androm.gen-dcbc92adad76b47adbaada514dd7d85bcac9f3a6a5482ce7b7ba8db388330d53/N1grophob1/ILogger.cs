using System.Threading.Tasks;
using Geologe8s;
using ns4;

namespace N1grophob1;

public interface ILogger
{
	void LogDebug(string data);

	void LogVerbose(string data);

	void LogInformation(string data);

	void LogMinimal(string data);

	void LogWarning(string data);

	void LogError(string data);

	void LogInformationSummary(string data);

	void Log(Te3timonie3 level, string data);

	Task LogAsync(Te3timonie3 level, string data);

	void Log(ILogMessage message);

	Task LogAsync(ILogMessage message);
}
