namespace Homework1;

public static class Parser
{
	private static readonly string[] SupportedOperations;

	public static extern int TryParseArguments(string[] args, out double val1, out string operation, out double val2);
}
