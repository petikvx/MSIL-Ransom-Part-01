using System.Collections.Generic;
using Gecko.Collections;
using Gecko.Interop;

namespace Gecko.Services;

public static class WindowWatcher
{
	private static ComPtr<nsIWindowWatcher> _watcher;

	private static bool _windowCreatorLocked;

	public static nsIWindowCreator2 WindowCreator
	{
		set
		{
			if (!_windowCreatorLocked)
			{
				_watcher.Instance.SetWindowCreator(value);
			}
		}
	}

	public static GeckoWindow ActiveWindow
	{
		get
		{
			return _watcher.Instance.GetActiveWindowAttribute().Wrap((nsIDOMWindow x) => new GeckoWindow(x));
		}
		set
		{
			if (value != null)
			{
				_watcher.Instance.SetActiveWindowAttribute(value.DomWindow);
			}
		}
	}

	static WindowWatcher()
	{
		_watcher = Xpcom.GetService2<nsIWindowWatcher>("@mozilla.org/embedcomp/window-watcher;1");
	}

	public static void Shutdown()
	{
		if (_watcher != null)
		{
			_watcher.Dispose();
		}
		_watcher = null;
	}

	public static void LockWindowCreator()
	{
		_windowCreatorLocked = true;
	}

	public static IEnumerator<GeckoWindow> GetWindowEnumerator()
	{
		return new GeckoEnumerator<GeckoWindow, nsIDOMWindow>(_watcher.Instance.GetWindowEnumerator(), (nsIDOMWindow x) => new GeckoWindow(x));
	}
}
