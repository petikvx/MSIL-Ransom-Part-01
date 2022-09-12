using System;

namespace Gecko.Events;

public class GeckoNavigationErrorEventArgs : EventArgs
{
	public readonly GeckoWindow DomWindow;

	public readonly int ErrorCode;

	public readonly string Uri;

	public bool DomWindowTopLevel => DomWindow.IsTopWindow();

	internal GeckoNavigationErrorEventArgs(string uri, GeckoWindow domWind, int errorCode)
	{
		Uri = uri;
		DomWindow = domWind;
		ErrorCode = errorCode;
	}
}
