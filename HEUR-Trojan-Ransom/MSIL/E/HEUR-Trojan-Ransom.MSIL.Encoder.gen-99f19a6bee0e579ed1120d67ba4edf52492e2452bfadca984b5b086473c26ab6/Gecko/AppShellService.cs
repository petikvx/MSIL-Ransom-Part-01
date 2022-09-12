using Gecko.Interop;

namespace Gecko;

public static class AppShellService
{
	private static ComPtr<nsIAppShellService> _appShellService;

	static AppShellService()
	{
		_appShellService = Xpcom.GetService2<nsIAppShellService>("@mozilla.org/appshell/appShellService;1");
	}

	public static void CreateHiddenWindow()
	{
		_appShellService.Instance.CreateHiddenWindow();
	}

	public static nsIXULWindow CreateTopLevelWindow(nsIXULWindow aParent, nsIURI aUrl, uint aChromeMask, int aInitialWidth, int aInitialHeight)
	{
		return _appShellService.Instance.CreateTopLevelWindow(aParent, aUrl, aChromeMask, aInitialWidth, aInitialHeight, null);
	}
}
