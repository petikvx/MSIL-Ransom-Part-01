using Gecko.Interop;

namespace Gecko;

public static class XulRuntime
{
	private static ComPtr<nsIXULRuntime> _xulRuntime;

	public static string OS => nsString.Get(_xulRuntime.Instance.GetOSAttribute);

	static XulRuntime()
	{
		_xulRuntime = Xpcom.GetService2<nsIXULRuntime>("@mozilla.org/xre/app-info;1");
	}
}
