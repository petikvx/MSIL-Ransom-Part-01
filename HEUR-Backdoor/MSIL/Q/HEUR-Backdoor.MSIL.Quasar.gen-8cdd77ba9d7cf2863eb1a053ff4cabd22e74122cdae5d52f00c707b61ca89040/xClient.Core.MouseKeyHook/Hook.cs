using xClient.Core.MouseKeyHook.Implementation;

namespace xClient.Core.MouseKeyHook;

public static class Hook
{
	public static IKeyboardMouseEvents AppEvents()
	{
		return new AppEventFacade();
	}

	public static IKeyboardMouseEvents GlobalEvents()
	{
		return new GlobalEventFacade();
	}
}
