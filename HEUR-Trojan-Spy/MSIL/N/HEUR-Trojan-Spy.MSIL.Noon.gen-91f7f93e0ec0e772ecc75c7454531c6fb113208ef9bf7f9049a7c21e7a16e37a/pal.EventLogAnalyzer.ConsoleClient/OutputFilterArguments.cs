using System.Collections.Generic;

namespace pal.EventLogAnalyzer.ConsoleClient;

internal class OutputFilterArguments
{
	private const string DEFAULT_REPORT_FIELDS = "All";

	private readonly List<string> _knownOutputArguments = new List<string>();

	private readonly Dictionary<string, string> _providedOutputArguments = new Dictionary<string, string>();

	public string OutputFolder => _providedOutputArguments["-output"];

	public object ReportFields
	{
		get
		{
			string result = "All";
			if (_providedOutputArguments.ContainsKey("-include"))
			{
				result = _providedOutputArguments["-include"];
			}
			return result;
		}
	}

	public OutputFilterArguments()
	{
		_knownOutputArguments.Add("-include");
		_knownOutputArguments.Add("-output");
	}

	public bool IsKnown(string @switch)
	{
		return _knownOutputArguments.Contains(@switch);
	}

	public void Add(string @switch, string parameter)
	{
		_providedOutputArguments.Add(@switch, parameter);
	}
}
