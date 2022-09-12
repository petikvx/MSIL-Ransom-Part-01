using Gecko.Interop;

namespace Gecko;

public static class ScreenManager
{
	private static ComPtr<nsIScreenManager> _screenManager;

	public static int NumberOfScreens => (int)_screenManager.Instance.GetNumberOfScreensAttribute();

	public static Screen PrimaryScreen => new Screen(_screenManager.Instance.GetPrimaryScreenAttribute());

	static ScreenManager()
	{
		_screenManager = Xpcom.GetService2<nsIScreenManager>("@mozilla.org/gfx/screenmanager;1");
	}

	public static Screen ScreenForRect(int left, int top, int width, int height)
	{
		return new Screen(_screenManager.Instance.ScreenForRect(left, top, width, height));
	}
}
