using RedLine.Reburn.Data.Core;
using RedLine.Reburn.Data.Core.Launchers;
using RedLine.Reburn.Data.Core.LogParsers;
using RedLine.Reburn.Models.Core;

namespace RedLine.Reburn;

internal class Program
{
	private static void Main(string[] args)
	{
		using BaseAppLauncher baseAppLauncher = new DefaultAppLauncher();
		using ICommunicator communicator = new ApiController();
		BaseLogParser logParser = new Processor();
		baseAppLauncher?.Init(communicator)?.Prepere(logParser)?.Report();
	}
}
