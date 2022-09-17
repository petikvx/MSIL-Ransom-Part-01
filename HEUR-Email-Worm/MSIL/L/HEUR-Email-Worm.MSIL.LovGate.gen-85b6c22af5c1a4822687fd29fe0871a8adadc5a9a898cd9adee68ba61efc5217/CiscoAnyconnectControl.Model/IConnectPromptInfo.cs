using System.Collections.Generic;

namespace CiscoAnyconnectControl.Model;

public interface IConnectPromptInfo
{
	int ConnectPromptType { get; }

	IEnumerable<dynamic> PromptEntries { get; }
}
