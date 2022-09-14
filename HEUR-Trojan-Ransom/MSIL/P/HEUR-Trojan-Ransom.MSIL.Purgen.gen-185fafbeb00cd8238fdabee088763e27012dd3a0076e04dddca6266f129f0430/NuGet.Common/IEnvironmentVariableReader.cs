namespace NuGet.Common;

public interface IEnvironmentVariableReader
{
	string GetEnvironmentVariable(string variable);
}
