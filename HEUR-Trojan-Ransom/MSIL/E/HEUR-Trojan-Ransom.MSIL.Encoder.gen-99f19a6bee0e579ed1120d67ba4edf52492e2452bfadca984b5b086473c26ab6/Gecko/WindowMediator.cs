using System.Collections.Generic;
using Gecko.Collections;
using Gecko.Interop;

namespace Gecko;

public static class WindowMediator
{
	private static ComPtr<nsIWindowMediator> _windowMediator;

	public static bool Disable { get; set; }

	static WindowMediator()
	{
		_windowMediator = Xpcom.GetService2<nsIWindowMediator>("@mozilla.org/appshell/window-mediator;1");
	}

	public static void Shutdown()
	{
		if (_windowMediator != null)
		{
			_windowMediator.Dispose();
		}
		_windowMediator = null;
	}

	public static void RegisterWindow(nsIXULWindow window)
	{
		if (!Disable)
		{
			_windowMediator.Instance.RegisterWindow(window);
		}
	}

	public static void UnregisterWindow(nsIXULWindow window)
	{
		if (!Disable)
		{
			_windowMediator.Instance.UnregisterWindow(window);
		}
	}

	public static nsIDOMWindow GetMostRecentWindow(string type)
	{
		if (Disable)
		{
			return null;
		}
		return _windowMediator.Instance.GetMostRecentWindow(type);
	}

	public static IEnumerator<GeckoWindow> GetEnumerator(string type)
	{
		if (Disable)
		{
			return null;
		}
		return new GeckoEnumerator<GeckoWindow, nsIDOMWindow>(_windowMediator.Instance.GetEnumerator(type), (nsIDOMWindow x) => new GeckoWindow(x));
	}
}
